﻿namespace Phoebe.FormClient
{
    partial class SettleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSettle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtLastTo = new DevExpress.XtraEditors.TextEdit();
            this.txtLastFrom = new DevExpress.XtraEditors.TextEdit();
            this.dpTo = new DevExpress.XtraEditors.DateEdit();
            this.dpFrom = new DevExpress.XtraEditors.DateEdit();
            this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.txtCustomerNumber = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.clcCustomer = new Phoebe.FormClient.CustomerListControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgcBilling = new DevExpress.XtraGrid.GridControl();
            this.bsBilling = new System.Windows.Forms.BindingSource(this.components);
            this.dgvBilling = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStockInId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHandlingUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHandlingPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreezeUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreezePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisposePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackingPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRentPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtherPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 607);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Controls.Add(this.clcCustomer);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(924, 174);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "选择";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSettle);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.txtLastTo);
            this.layoutControl1.Controls.Add(this.txtLastFrom);
            this.layoutControl1.Controls.Add(this.dpTo);
            this.layoutControl1.Controls.Add(this.dpFrom);
            this.layoutControl1.Controls.Add(this.txtCustomerName);
            this.layoutControl1.Controls.Add(this.txtCustomerNumber);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(700, 151);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSettle
            // 
            this.btnSettle.Location = new System.Drawing.Point(512, 60);
            this.btnSettle.Name = "btnSettle";
            this.btnSettle.Size = new System.Drawing.Size(176, 22);
            this.btnSettle.StyleController = this.layoutControl1;
            this.btnSettle.TabIndex = 11;
            this.btnSettle.Text = "开始结算";
            this.btnSettle.Click += new System.EventHandler(this.btnSettle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(169, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(151, 14);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "上期结算";
            // 
            // txtLastTo
            // 
            this.txtLastTo.Location = new System.Drawing.Point(563, 36);
            this.txtLastTo.Name = "txtLastTo";
            this.txtLastTo.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtLastTo.Properties.Appearance.Options.UseBackColor = true;
            this.txtLastTo.Properties.ReadOnly = true;
            this.txtLastTo.Size = new System.Drawing.Size(125, 20);
            this.txtLastTo.StyleController = this.layoutControl1;
            this.txtLastTo.TabIndex = 9;
            // 
            // txtLastFrom
            // 
            this.txtLastFrom.Location = new System.Drawing.Point(375, 36);
            this.txtLastFrom.Name = "txtLastFrom";
            this.txtLastFrom.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtLastFrom.Properties.Appearance.Options.UseBackColor = true;
            this.txtLastFrom.Properties.ReadOnly = true;
            this.txtLastFrom.Size = new System.Drawing.Size(133, 20);
            this.txtLastFrom.StyleController = this.layoutControl1;
            this.txtLastFrom.TabIndex = 8;
            // 
            // dpTo
            // 
            this.dpTo.EditValue = null;
            this.dpTo.Location = new System.Drawing.Point(563, 12);
            this.dpTo.Name = "dpTo";
            this.dpTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpTo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dpTo.Size = new System.Drawing.Size(125, 20);
            this.dpTo.StyleController = this.layoutControl1;
            this.dpTo.TabIndex = 7;
            // 
            // dpFrom
            // 
            this.dpFrom.EditValue = null;
            this.dpFrom.Location = new System.Drawing.Point(375, 12);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dpFrom.Size = new System.Drawing.Size(133, 20);
            this.dpFrom.StyleController = this.layoutControl1;
            this.dpFrom.TabIndex = 6;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(220, 12);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtCustomerName.Properties.Appearance.Options.UseBackColor = true;
            this.txtCustomerName.Properties.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.StyleController = this.layoutControl1;
            this.txtCustomerName.TabIndex = 5;
            // 
            // txtCustomerNumber
            // 
            this.txtCustomerNumber.Location = new System.Drawing.Point(63, 12);
            this.txtCustomerNumber.Name = "txtCustomerNumber";
            this.txtCustomerNumber.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtCustomerNumber.Properties.Appearance.Options.UseBackColor = true;
            this.txtCustomerNumber.Size = new System.Drawing.Size(102, 20);
            this.txtCustomerNumber.StyleController = this.layoutControl1;
            this.txtCustomerNumber.TabIndex = 4;
            this.txtCustomerNumber.EditValueChanged += new System.EventHandler(this.txtCustomerNumber_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(700, 151);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCustomerNumber;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(157, 74);
            this.layoutControlItem1.Text = "客户代码";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtCustomerName;
            this.layoutControlItem2.Location = new System.Drawing.Point(157, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(155, 24);
            this.layoutControlItem2.Text = "客户名称";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dpFrom;
            this.layoutControlItem3.Location = new System.Drawing.Point(312, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(188, 24);
            this.layoutControlItem3.Text = "开始日期";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dpTo;
            this.layoutControlItem4.Location = new System.Drawing.Point(500, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(180, 24);
            this.layoutControlItem4.Text = "结束日期";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtLastFrom;
            this.layoutControlItem5.Location = new System.Drawing.Point(312, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(188, 50);
            this.layoutControlItem5.Text = "开始日期";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtLastTo;
            this.layoutControlItem6.Location = new System.Drawing.Point(500, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(180, 24);
            this.layoutControlItem6.Text = "结束日期";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.labelControl1;
            this.layoutControlItem7.Location = new System.Drawing.Point(157, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 6, 2);
            this.layoutControlItem7.Size = new System.Drawing.Size(155, 50);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnSettle;
            this.layoutControlItem8.Location = new System.Drawing.Point(500, 48);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(180, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 74);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(680, 57);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // clcCustomer
            // 
            this.clcCustomer.Dock = System.Windows.Forms.DockStyle.Right;
            this.clcCustomer.Location = new System.Drawing.Point(702, 21);
            this.clcCustomer.Name = "clcCustomer";
            this.clcCustomer.Size = new System.Drawing.Size(220, 151);
            this.clcCustomer.TabIndex = 0;
            this.clcCustomer.CustomerItemSelected += new Phoebe.FormClient.CustomerListControl.ItemSelectHandle(this.clcCustomer_CustomerItemSelected);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgcBilling);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 183);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(924, 107);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "基本费用";
            // 
            // dgcBilling
            // 
            this.dgcBilling.DataSource = this.bsBilling;
            this.dgcBilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcBilling.Location = new System.Drawing.Point(2, 21);
            this.dgcBilling.MainView = this.dgvBilling;
            this.dgcBilling.Name = "dgcBilling";
            this.dgcBilling.Size = new System.Drawing.Size(920, 84);
            this.dgcBilling.TabIndex = 0;
            this.dgcBilling.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvBilling});
            // 
            // bsBilling
            // 
            this.bsBilling.DataSource = typeof(Phoebe.Model.Billing);
            // 
            // dgvBilling
            // 
            this.dgvBilling.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStockInId,
            this.colContractId,
            this.colUnitPrice,
            this.colHandlingUnitPrice,
            this.colHandlingPrice,
            this.colFreezeUnitPrice,
            this.colFreezePrice,
            this.colDisposePrice,
            this.colPackingPrice,
            this.colRentPrice,
            this.colOtherPrice,
            this.colTotalPrice,
            this.colRemark,
            this.colStatus});
            this.dgvBilling.GridControl = this.dgcBilling;
            this.dgvBilling.Name = "dgvBilling";
            this.dgvBilling.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvBilling.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvBilling.OptionsBehavior.Editable = false;
            this.dgvBilling.OptionsCustomization.AllowFilter = false;
            this.dgvBilling.OptionsCustomization.AllowGroup = false;
            this.dgvBilling.OptionsCustomization.AllowQuickHideColumns = false;
            this.dgvBilling.OptionsFilter.AllowFilterEditor = false;
            this.dgvBilling.OptionsFind.AllowFindPanel = false;
            this.dgvBilling.OptionsMenu.EnableColumnMenu = false;
            this.dgvBilling.OptionsMenu.EnableGroupPanelMenu = false;
            this.dgvBilling.OptionsView.ShowFooter = true;
            this.dgvBilling.OptionsView.ShowGroupPanel = false;
            this.dgvBilling.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.dgvBilling_CustomColumnDisplayText);
            // 
            // colStockInId
            // 
            this.colStockInId.FieldName = "StockInId";
            this.colStockInId.Name = "colStockInId";
            // 
            // colContractId
            // 
            this.colContractId.Caption = "合同名称";
            this.colContractId.FieldName = "ContractId";
            this.colContractId.Name = "colContractId";
            this.colContractId.Visible = true;
            this.colContractId.VisibleIndex = 0;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "冷藏费单价";
            this.colUnitPrice.DisplayFormat.FormatString = "0.##";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 1;
            // 
            // colHandlingUnitPrice
            // 
            this.colHandlingUnitPrice.Caption = "装卸费单价";
            this.colHandlingUnitPrice.DisplayFormat.FormatString = "0.##";
            this.colHandlingUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHandlingUnitPrice.FieldName = "HandlingUnitPrice";
            this.colHandlingUnitPrice.Name = "colHandlingUnitPrice";
            this.colHandlingUnitPrice.Visible = true;
            this.colHandlingUnitPrice.VisibleIndex = 2;
            // 
            // colHandlingPrice
            // 
            this.colHandlingPrice.Caption = "装卸费(元)";
            this.colHandlingPrice.DisplayFormat.FormatString = "0.##";
            this.colHandlingPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHandlingPrice.FieldName = "HandlingPrice";
            this.colHandlingPrice.Name = "colHandlingPrice";
            this.colHandlingPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HandlingPrice", "合计={0:0.##}")});
            this.colHandlingPrice.Visible = true;
            this.colHandlingPrice.VisibleIndex = 3;
            // 
            // colFreezeUnitPrice
            // 
            this.colFreezeUnitPrice.Caption = "结冻费单价";
            this.colFreezeUnitPrice.DisplayFormat.FormatString = "0.##";
            this.colFreezeUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFreezeUnitPrice.FieldName = "FreezeUnitPrice";
            this.colFreezeUnitPrice.Name = "colFreezeUnitPrice";
            this.colFreezeUnitPrice.Visible = true;
            this.colFreezeUnitPrice.VisibleIndex = 4;
            // 
            // colFreezePrice
            // 
            this.colFreezePrice.Caption = "结冻费(元)";
            this.colFreezePrice.DisplayFormat.FormatString = "0.##";
            this.colFreezePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFreezePrice.FieldName = "FreezePrice";
            this.colFreezePrice.Name = "colFreezePrice";
            this.colFreezePrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FreezePrice", "合计={0:0.##}")});
            this.colFreezePrice.Visible = true;
            this.colFreezePrice.VisibleIndex = 5;
            // 
            // colDisposePrice
            // 
            this.colDisposePrice.Caption = "处置费(元)";
            this.colDisposePrice.DisplayFormat.FormatString = "0.##";
            this.colDisposePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDisposePrice.FieldName = "DisposePrice";
            this.colDisposePrice.Name = "colDisposePrice";
            this.colDisposePrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DisposePrice", "合计={0:0.##}")});
            this.colDisposePrice.Visible = true;
            this.colDisposePrice.VisibleIndex = 6;
            // 
            // colPackingPrice
            // 
            this.colPackingPrice.Caption = "包装费(元)";
            this.colPackingPrice.DisplayFormat.FormatString = "0.##";
            this.colPackingPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPackingPrice.FieldName = "PackingPrice";
            this.colPackingPrice.Name = "colPackingPrice";
            this.colPackingPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PackingPrice", "合计={0:0.##}")});
            this.colPackingPrice.Visible = true;
            this.colPackingPrice.VisibleIndex = 7;
            // 
            // colRentPrice
            // 
            this.colRentPrice.Caption = "租赁费(元)";
            this.colRentPrice.DisplayFormat.FormatString = "0.##";
            this.colRentPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRentPrice.FieldName = "RentPrice";
            this.colRentPrice.Name = "colRentPrice";
            this.colRentPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RentPrice", "合计={0:0.##}")});
            this.colRentPrice.Visible = true;
            this.colRentPrice.VisibleIndex = 8;
            // 
            // colOtherPrice
            // 
            this.colOtherPrice.Caption = "其它费用(元)";
            this.colOtherPrice.DisplayFormat.FormatString = "0.##";
            this.colOtherPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOtherPrice.FieldName = "OtherPrice";
            this.colOtherPrice.Name = "colOtherPrice";
            this.colOtherPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OtherPrice", "合计={0:0.##}")});
            this.colOtherPrice.Visible = true;
            this.colOtherPrice.VisibleIndex = 9;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "费用总计(元)";
            this.colTotalPrice.DisplayFormat.FormatString = "0.##";
            this.colTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "合计={0:0.##}")});
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 10;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 11;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // groupControl3
            // 
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 296);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(924, 107);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "冷藏费用";
            // 
            // SettleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 607);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SettleForm";
            this.Text = "结算管理";
            this.Load += new System.EventHandler(this.SettleForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtLastTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtLastTo;
        private DevExpress.XtraEditors.TextEdit txtLastFrom;
        private DevExpress.XtraEditors.DateEdit dpTo;
        private DevExpress.XtraEditors.DateEdit dpFrom;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.TextEdit txtCustomerNumber;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private CustomerListControl clcCustomer;
        private DevExpress.XtraEditors.SimpleButton btnSettle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgcBilling;
        private System.Windows.Forms.BindingSource bsBilling;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvBilling;
        private DevExpress.XtraGrid.Columns.GridColumn colStockInId;
        private DevExpress.XtraGrid.Columns.GridColumn colContractId;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colHandlingUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colHandlingPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colFreezeUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colFreezePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDisposePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPackingPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colRentPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colOtherPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.GroupControl groupControl3;
    }
}