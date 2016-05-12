﻿namespace Phoebe.FormClient
{
    partial class StoreForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chkStoreInReady = new DevExpress.XtraEditors.CheckEdit();
            this.chkStoreOut = new DevExpress.XtraEditors.CheckEdit();
            this.chkStoreIn = new DevExpress.XtraEditors.CheckEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtCategoryName = new DevExpress.XtraEditors.TextEdit();
            this.txtCategoryNumber = new DevExpress.XtraEditors.TextEdit();
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgcStore = new DevExpress.XtraGrid.GridControl();
            this.bsStore = new System.Windows.Forms.BindingSource(this.components);
            this.dgvStore = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStoreCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStoreWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalVolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStoreVolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoveTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpecification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOriginPlace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShelfLife = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDestination = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkStoreInReady.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStoreOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStoreIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryNumber.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(678, 194);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "操作";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chkStoreInReady);
            this.layoutControl1.Controls.Add(this.chkStoreOut);
            this.layoutControl1.Controls.Add(this.chkStoreIn);
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.txtCategoryName);
            this.layoutControl1.Controls.Add(this.txtCategoryNumber);
            this.layoutControl1.Controls.Add(this.txtCustomerName);
            this.layoutControl1.Controls.Add(this.txtCustomerNumber);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(674, 171);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkStoreInReady
            // 
            this.chkStoreInReady.Location = new System.Drawing.Point(181, 55);
            this.chkStoreInReady.Name = "chkStoreInReady";
            this.chkStoreInReady.Properties.Caption = "准备入库";
            this.chkStoreInReady.Size = new System.Drawing.Size(82, 19);
            this.chkStoreInReady.StyleController = this.layoutControl1;
            this.chkStoreInReady.TabIndex = 11;
            // 
            // chkStoreOut
            // 
            this.chkStoreOut.Location = new System.Drawing.Point(131, 55);
            this.chkStoreOut.Name = "chkStoreOut";
            this.chkStoreOut.Properties.Caption = "出库";
            this.chkStoreOut.Size = new System.Drawing.Size(46, 19);
            this.chkStoreOut.StyleController = this.layoutControl1;
            this.chkStoreOut.TabIndex = 10;
            // 
            // chkStoreIn
            // 
            this.chkStoreIn.Location = new System.Drawing.Point(7, 55);
            this.chkStoreIn.Name = "chkStoreIn";
            this.chkStoreIn.Properties.Caption = "在库";
            this.chkStoreIn.Size = new System.Drawing.Size(120, 19);
            this.chkStoreIn.StyleController = this.layoutControl1;
            this.chkStoreIn.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(267, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(400, 22);
            this.btnSearch.StyleController = this.layoutControl1;
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(318, 31);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(349, 20);
            this.txtCategoryName.StyleController = this.layoutControl1;
            this.txtCategoryName.TabIndex = 7;
            // 
            // txtCategoryNumber
            // 
            this.txtCategoryNumber.Location = new System.Drawing.Point(58, 31);
            this.txtCategoryNumber.Name = "txtCategoryNumber";
            this.txtCategoryNumber.Size = new System.Drawing.Size(205, 20);
            this.txtCategoryNumber.StyleController = this.layoutControl1;
            this.txtCategoryNumber.TabIndex = 6;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(318, 7);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(349, 20);
            this.txtCustomerName.StyleController = this.layoutControl1;
            this.txtCustomerName.TabIndex = 5;
            // 
            // txtCustomerNumber
            // 
            this.txtCustomerNumber.Location = new System.Drawing.Point(58, 7);
            this.txtCustomerNumber.Name = "txtCustomerNumber";
            this.txtCustomerNumber.Size = new System.Drawing.Size(205, 20);
            this.txtCustomerNumber.StyleController = this.layoutControl1;
            this.txtCustomerNumber.TabIndex = 4;
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
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(674, 171);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCustomerNumber;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(260, 24);
            this.layoutControlItem1.Text = "客户代码";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtCustomerName;
            this.layoutControlItem2.Location = new System.Drawing.Point(260, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(404, 24);
            this.layoutControlItem2.Text = "客户名称";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtCategoryNumber;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(260, 24);
            this.layoutControlItem3.Text = "类别代码";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtCategoryName;
            this.layoutControlItem4.Location = new System.Drawing.Point(260, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(404, 24);
            this.layoutControlItem4.Text = "类别名称";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnSearch;
            this.layoutControlItem5.Location = new System.Drawing.Point(260, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(404, 113);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.chkStoreIn;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(124, 113);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.chkStoreOut;
            this.layoutControlItem7.Location = new System.Drawing.Point(124, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(50, 113);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.chkStoreInReady;
            this.layoutControlItem8.Location = new System.Drawing.Point(174, 48);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(86, 113);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // groupControl2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupControl2, 3);
            this.groupControl2.Controls.Add(this.dgcStore);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 203);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1078, 346);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "库存数据";
            // 
            // dgcStore
            // 
            this.dgcStore.DataSource = this.bsStore;
            this.dgcStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcStore.Location = new System.Drawing.Point(2, 21);
            this.dgcStore.MainView = this.dgvStore;
            this.dgcStore.Name = "dgcStore";
            this.dgcStore.Size = new System.Drawing.Size(1074, 323);
            this.dgcStore.TabIndex = 0;
            this.dgcStore.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvStore});
            // 
            // bsStore
            // 
            this.bsStore.DataSource = typeof(Phoebe.Model.Store);
            // 
            // dgvStore
            // 
            this.dgvStore.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colWarehouseNumber,
            this.colTotalCount,
            this.colStoreCount,
            this.colTotalWeight,
            this.colStoreWeight,
            this.colTotalVolume,
            this.colStoreVolume,
            this.colInTime,
            this.colOutTime,
            this.colMoveTime,
            this.colSpecification,
            this.colOriginPlace,
            this.colShelfLife,
            this.colSource,
            this.colDestination,
            this.colUserId,
            this.colRemark,
            this.colStatus});
            this.dgvStore.GridControl = this.dgcStore;
            this.dgvStore.Name = "dgvStore";
            this.dgvStore.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.dgvStore.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.dgvStore.OptionsBehavior.Editable = false;
            this.dgvStore.OptionsFind.AlwaysVisible = true;
            this.dgvStore.OptionsView.ShowGroupPanel = false;
            this.dgvStore.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.dgvStore_CustomColumnDisplayText);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colWarehouseNumber
            // 
            this.colWarehouseNumber.Caption = "仓库编号";
            this.colWarehouseNumber.FieldName = "WarehouseNumber";
            this.colWarehouseNumber.Name = "colWarehouseNumber";
            this.colWarehouseNumber.Visible = true;
            this.colWarehouseNumber.VisibleIndex = 0;
            // 
            // colTotalCount
            // 
            this.colTotalCount.Caption = "总数量";
            this.colTotalCount.FieldName = "TotalCount";
            this.colTotalCount.Name = "colTotalCount";
            this.colTotalCount.Visible = true;
            this.colTotalCount.VisibleIndex = 1;
            // 
            // colStoreCount
            // 
            this.colStoreCount.Caption = "在库数量";
            this.colStoreCount.FieldName = "StoreCount";
            this.colStoreCount.Name = "colStoreCount";
            this.colStoreCount.Visible = true;
            this.colStoreCount.VisibleIndex = 2;
            // 
            // colTotalWeight
            // 
            this.colTotalWeight.Caption = "总重量(t)";
            this.colTotalWeight.FieldName = "TotalWeight";
            this.colTotalWeight.Name = "colTotalWeight";
            this.colTotalWeight.Visible = true;
            this.colTotalWeight.VisibleIndex = 3;
            // 
            // colStoreWeight
            // 
            this.colStoreWeight.Caption = "在库重量(t)";
            this.colStoreWeight.FieldName = "StoreWeight";
            this.colStoreWeight.Name = "colStoreWeight";
            this.colStoreWeight.Visible = true;
            this.colStoreWeight.VisibleIndex = 4;
            // 
            // colTotalVolume
            // 
            this.colTotalVolume.Caption = "总体积(立方)";
            this.colTotalVolume.FieldName = "TotalVolume";
            this.colTotalVolume.Name = "colTotalVolume";
            this.colTotalVolume.Visible = true;
            this.colTotalVolume.VisibleIndex = 5;
            // 
            // colStoreVolume
            // 
            this.colStoreVolume.Caption = "在库体积(立方)";
            this.colStoreVolume.FieldName = "StoreVolume";
            this.colStoreVolume.Name = "colStoreVolume";
            this.colStoreVolume.Visible = true;
            this.colStoreVolume.VisibleIndex = 6;
            // 
            // colInTime
            // 
            this.colInTime.Caption = "入库时间";
            this.colInTime.FieldName = "InTime";
            this.colInTime.Name = "colInTime";
            this.colInTime.Visible = true;
            this.colInTime.VisibleIndex = 7;
            // 
            // colOutTime
            // 
            this.colOutTime.Caption = "出库时间";
            this.colOutTime.FieldName = "OutTime";
            this.colOutTime.Name = "colOutTime";
            this.colOutTime.Visible = true;
            this.colOutTime.VisibleIndex = 8;
            // 
            // colMoveTime
            // 
            this.colMoveTime.Caption = "移入时间";
            this.colMoveTime.FieldName = "MoveTime";
            this.colMoveTime.Name = "colMoveTime";
            this.colMoveTime.Visible = true;
            this.colMoveTime.VisibleIndex = 9;
            // 
            // colSpecification
            // 
            this.colSpecification.Caption = "规格";
            this.colSpecification.FieldName = "Specification";
            this.colSpecification.Name = "colSpecification";
            this.colSpecification.Visible = true;
            this.colSpecification.VisibleIndex = 10;
            // 
            // colOriginPlace
            // 
            this.colOriginPlace.Caption = "产地";
            this.colOriginPlace.FieldName = "OriginPlace";
            this.colOriginPlace.Name = "colOriginPlace";
            this.colOriginPlace.Visible = true;
            this.colOriginPlace.VisibleIndex = 11;
            // 
            // colShelfLife
            // 
            this.colShelfLife.Caption = "保质期(月)";
            this.colShelfLife.FieldName = "ShelfLife";
            this.colShelfLife.Name = "colShelfLife";
            this.colShelfLife.Visible = true;
            this.colShelfLife.VisibleIndex = 12;
            // 
            // colSource
            // 
            this.colSource.AppearanceHeader.Options.UseTextOptions = true;
            this.colSource.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSource.Caption = "来源";
            this.colSource.FieldName = "Source";
            this.colSource.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colSource.Name = "colSource";
            this.colSource.Visible = true;
            this.colSource.VisibleIndex = 13;
            // 
            // colDestination
            // 
            this.colDestination.AppearanceHeader.Options.UseTextOptions = true;
            this.colDestination.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDestination.Caption = "目的地";
            this.colDestination.FieldName = "Destination";
            this.colDestination.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDestination.Name = "colDestination";
            this.colDestination.Visible = true;
            this.colDestination.VisibleIndex = 14;
            // 
            // colUserId
            // 
            this.colUserId.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUserId.Caption = "操作人";
            this.colUserId.FieldName = "UserId";
            this.colUserId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colUserId.Name = "colUserId";
            this.colUserId.Visible = true;
            this.colUserId.VisibleIndex = 15;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.OptionsFilter.AllowFilter = false;
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 16;
            // 
            // colStatus
            // 
            this.colStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.colStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatus.Caption = "状态";
            this.colStatus.FieldName = "Status";
            this.colStatus.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 552);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StoreForm";
            this.Text = "库存记录";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkStoreInReady.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStoreOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStoreIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryNumber.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.TextEdit txtCustomerNumber;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtCategoryName;
        private DevExpress.XtraEditors.TextEdit txtCategoryNumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl dgcStore;
        private System.Windows.Forms.BindingSource bsStore;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvStore;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCount;
        private DevExpress.XtraGrid.Columns.GridColumn colStoreCount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colStoreWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalVolume;
        private DevExpress.XtraGrid.Columns.GridColumn colStoreVolume;
        private DevExpress.XtraGrid.Columns.GridColumn colInTime;
        private DevExpress.XtraGrid.Columns.GridColumn colOutTime;
        private DevExpress.XtraGrid.Columns.GridColumn colMoveTime;
        private DevExpress.XtraGrid.Columns.GridColumn colSpecification;
        private DevExpress.XtraGrid.Columns.GridColumn colOriginPlace;
        private DevExpress.XtraGrid.Columns.GridColumn colShelfLife;
        private DevExpress.XtraGrid.Columns.GridColumn colSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDestination;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.CheckEdit chkStoreInReady;
        private DevExpress.XtraEditors.CheckEdit chkStoreOut;
        private DevExpress.XtraEditors.CheckEdit chkStoreIn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}