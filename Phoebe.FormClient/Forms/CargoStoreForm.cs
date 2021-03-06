﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phoebe.FormClient
{
    using DevExpress.XtraEditors.Controls;
    using Phoebe.Base;
    using Phoebe.Business;
    using Phoebe.Common;
    using Phoebe.Model;

    /// <summary>
    /// 货品库存窗体
    /// </summary>
    public partial class CargoStoreForm : BaseForm
    {
        #region Constructor
        public CargoStoreForm()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 更新合同选择
        /// </summary>
        /// <param name="customerId">客户Id</param>
        private void UpdateContractList(int customerId)
        {
            var contracts = BusinessFactory<ContractBusiness>.Instance.GetByCustomer2(customerId);

            this.cmbContract.Properties.Items.Clear();

            ImageComboBoxItem empty = new ImageComboBoxItem();
            empty.Description = "--全部合同--";
            empty.Value = 0;
            this.cmbContract.Properties.Items.Add(empty);

            foreach (var item in contracts)
            {
                ImageComboBoxItem i = new ImageComboBoxItem();
                i.Description = item.Name;
                i.Value = item.Id;

                this.cmbContract.Properties.Items.Add(i);
            }

            this.cmbContract.EditValue = 0;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 窗体载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CargoStoreForm_Load(object sender, EventArgs e)
        {
            this.bsCustomer.DataSource = BusinessFactory<CustomerBusiness>.Instance.FindAll();
            this.lkuCustomer.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(EventUtil.LkuCustomer_CustomDisplayText);
        }

        /// <summary>
        /// 客户选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lkuCustomer_EditValueChanged(object sender, EventArgs e)
        {
            if (this.lkuCustomer.EditValue == null)
                UpdateContractList(0);
            else
                UpdateContractList(Convert.ToInt32(this.lkuCustomer.EditValue));
        }

        /// <summary>
        /// 查询货品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindCargo_Click(object sender, EventArgs e)
        {
            if (this.lkuCustomer.EditValue == null)
            {
                MessageUtil.ShowClaim("请选择客户");
                return;
            }

            int customerId = Convert.ToInt32(this.lkuCustomer.EditValue);
            var data = BusinessFactory<CargoBusiness>.Instance.GetByCustomer(customerId);

            if (this.cmbContract.EditValue != null && (int)this.cmbContract.EditValue != 0)
            {
                data = data.Where(r => r.ContractId == (int)this.cmbContract.EditValue).ToList();
            }

            this.cgList.DataSource = data;
        }
        
        /// <summary>
        /// 查询库存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindStore_Click(object sender, EventArgs e)
        {
            var cargo = this.cgList.GetCurrentSelect();
            if (cargo == null)
            {
                MessageUtil.ShowClaim("请选择货品");
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            var data = BusinessFactory<StoreBusiness>.Instance.GetByCargo(cargo.Id, true);
            this.sgList.DataSource = data;

            this.Cursor = Cursors.Default;
        }
        #endregion //Event
    }
}
