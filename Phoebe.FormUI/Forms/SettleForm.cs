﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phoebe.Business;
using Phoebe.Common;
using Phoebe.Model;

namespace Phoebe.FormUI
{
    /// <summary>
    /// 费用结算窗体
    /// </summary>
    public partial class SettleForm : Form
    {
        #region Field
        private SettleBusiness settleBusiness;

        private CustomerBusiness customerBusiness;
        #endregion //Field

        #region Constructor
        public SettleForm()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        private void InitData()
        {
            this.settleBusiness = new SettleBusiness();
            this.customerBusiness = new CustomerBusiness();
        }

        private void InitControl()
        {
            this.comboBoxCustomer.DataSource = this.customerBusiness.Get();
            this.comboBoxCustomer.DisplayMember = "Name";
            this.comboBoxCustomer.ValueMember = "ID";
        }

        /// <summary>
        /// 费用计算
        /// </summary>
        /// <returns>
        /// 应付款
        /// </returns>
        private decimal CalculateFee()
        {
            decimal sumFee = this.numericPastFee.Value + this.numericCurrentFee.Value;
            this.textBoxSumFee.Text = Math.Round(sumFee, 2).ToString();

            decimal dueFee = sumFee * this.numericDiscount.Value / 100 - this.numericRemission.Value;
            this.textBoxDueFee.Text = Math.Round(dueFee, 2).ToString();

            return dueFee;
        }
        #endregion Function

        #region Event
        /// <summary>
        /// 窗体载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettleForm_Load(object sender, EventArgs e)
        {
            InitData();
            InitControl();
        }

        /// <summary>
        /// 开始结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (this.comboBoxCustomer.SelectedIndex == -1)
                return;

            var customer = this.comboBoxCustomer.SelectedItem as Customer;
            var billings = this.settleBusiness.BaseProcess(customer.ID, this.dateStart.Value.Date, this.dateEnd.Value.Date);
            this.billingBindingSource.DataSource = billings;

            var colds = this.settleBusiness.ColdProcess(customer.ID, this.dateStart.Value.Date, this.dateEnd.Value.Date);
            this.coldSettlementBindingSource.DataSource = colds;

            decimal totalPrice = billings.Sum(r => r.TotalPrice) + colds.Sum(r => r.ColdPrice);
            this.numericCurrentFee.Value = totalPrice;

            CalculateFee();
        }


        private void billingDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < this.billingBindingSource.Count)
            {
                var billing = this.billingBindingSource[e.RowIndex] as Billing;

                if (billing.Contract != null)
                {
                    this.billingDataGridView.Rows[e.RowIndex].Cells[this.columnContract.Index].Value = billing.Contract.Name;
                }
            }
        }

        private void numericPastFee_ValueChanged(object sender, EventArgs e)
        {
            CalculateFee();
        }

        private void numericDiscount_ValueChanged(object sender, EventArgs e)
        {
            CalculateFee();
        }

        private void numericRemission_ValueChanged(object sender, EventArgs e)
        {
            CalculateFee();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.textBoxNumber.Text == "")
            {
                MessageBox.Show("结算单号不能为空", FormConstant.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Settlement settlement = new Settlement();
            settlement.ID = Guid.NewGuid();
            settlement.Number = this.textBoxNumber.Text;
            settlement.CustomerID = Convert.ToInt32(this.comboBoxCustomer.SelectedValue);
            settlement.StartTime = this.dateStart.Value.Date;
            settlement.EndTime = this.dateEnd.Value.Date;
            settlement.PastFee = this.numericPastFee.Value;
            settlement.CurrentFee = this.numericCurrentFee.Value;
            settlement.SumFee = settlement.PastFee + settlement.CurrentFee;
            settlement.Discount = Convert.ToInt32(this.numericDiscount.Value);
            settlement.Remission = this.numericRemission.Value;
            settlement.DueFee = CalculateFee();
            settlement.SettleTime = this.dateSettle.Value.Date;
            settlement.Remark = this.textBoxRemark.Text;

            List<SettlementDetail> details = new List<SettlementDetail>();

            for(int i = 0; i < this.billingBindingSource.Count; i++)
            {
                var billing = this.billingBindingSource[i] as Billing;

                SettlementDetail detail = new SettlementDetail();
                detail.ID = Guid.NewGuid();
                detail.SettlementID = settlement.ID;
                detail.StockInID = billing.StockInID;
                detail.ExpenseType = (int)ExpenseType.Base;
                detail.SumFee = billing.TotalPrice;

                details.Add(detail);
            }

            for(int i = 0; i < this.coldSettlementBindingSource.Count; i++)
            {
                var cold = this.coldSettlementBindingSource[i] as ColdSettlement;

                SettlementDetail detail = new SettlementDetail();
                detail.ID = Guid.NewGuid();
                detail.SettlementID = settlement.ID;
                detail.ContractID = cold.ContractID;
                detail.ExpenseType = (int)ExpenseType.Cold;
                detail.SumFee = cold.ColdPrice;

                details.Add(detail);
            }

            ErrorCode result = this.settleBusiness.Create(settlement, details);
            if (result == ErrorCode.Success)
            {
                MessageBox.Show("保存结算成功", FormConstant.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);             
            }
            else
            {
                MessageBox.Show("保存结算失败：" + result.DisplayName(), FormConstant.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion //Event        
    }
}
