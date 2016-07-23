﻿namespace Phoebe.FormClient
{
    partial class ContractForm
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
            this.btnForceDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ctList = new Phoebe.FormClient.ContractGrid();
            this.bsContract = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsContract)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnForceDelete);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(931, 110);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "操作";
            // 
            // btnForceDelete
            // 
            this.btnForceDelete.Location = new System.Drawing.Point(383, 43);
            this.btnForceDelete.Name = "btnForceDelete";
            this.btnForceDelete.Size = new System.Drawing.Size(90, 40);
            this.btnForceDelete.TabIndex = 4;
            this.btnForceDelete.Text = "强制删除合同";
            this.btnForceDelete.Click += new System.EventHandler(this.btnForceDelete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(266, 43);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除合同";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(149, 43);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 40);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "编辑合同";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加合同";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ctList);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 110);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(931, 425);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "合同列表";
            // 
            // ctList
            // 
            this.ctList.DataSource = null;
            this.ctList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctList.Location = new System.Drawing.Point(2, 21);
            this.ctList.Name = "ctList";
            this.ctList.Size = new System.Drawing.Size(927, 402);
            this.ctList.TabIndex = 1;
            // 
            // bsContract
            // 
            this.bsContract.DataSource = typeof(Phoebe.Model.Contract);
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 535);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "ContractForm";
            this.Text = "合同列表";
            this.Load += new System.EventHandler(this.ContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsContract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource bsContract;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnForceDelete;
        private ContractGrid ctList;
    }
}