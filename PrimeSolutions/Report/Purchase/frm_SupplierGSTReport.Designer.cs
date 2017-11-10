﻿namespace PrimeSolutions.Report.Purchase
{
    partial class frm_SupplierGSTReport
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
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.bttn_excel = new System.Windows.Forms.Button();
            this.bttn_close = new System.Windows.Forms.Button();
            this.dgv_SupplierBill = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GSTIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSNCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SupplierBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(12, 69);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(103, 20);
            this.dtp1.TabIndex = 0;
            // 
            // bttn_excel
            // 
            this.bttn_excel.BackColor = System.Drawing.Color.ForestGreen;
            this.bttn_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_excel.ForeColor = System.Drawing.Color.White;
            this.bttn_excel.Location = new System.Drawing.Point(577, 70);
            this.bttn_excel.Name = "bttn_excel";
            this.bttn_excel.Size = new System.Drawing.Size(108, 25);
            this.bttn_excel.TabIndex = 1;
            this.bttn_excel.Text = "Export To Excel";
            this.bttn_excel.UseVisualStyleBackColor = false;
            this.bttn_excel.Click += new System.EventHandler(this.bttn_excel_Click);
            // 
            // bttn_close
            // 
            this.bttn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_close.ForeColor = System.Drawing.Color.White;
            this.bttn_close.Location = new System.Drawing.Point(1078, 69);
            this.bttn_close.Name = "bttn_close";
            this.bttn_close.Size = new System.Drawing.Size(75, 25);
            this.bttn_close.TabIndex = 2;
            this.bttn_close.Text = "Close";
            this.bttn_close.UseVisualStyleBackColor = false;
            this.bttn_close.Click += new System.EventHandler(this.bttn_close_Click);
            // 
            // dgv_SupplierBill
            // 
            this.dgv_SupplierBill.AllowUserToDeleteRows = false;
            this.dgv_SupplierBill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_SupplierBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SupplierBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.BillNo,
            this.Date,
            this.SupplierName,
            this.GSTIN,
            this.HSNCode,
            this.BillAmt,
            this.CGST,
            this.SGST,
            this.IGST,
            this.TotalAmt});
            this.dgv_SupplierBill.Location = new System.Drawing.Point(10, 127);
            this.dgv_SupplierBill.Name = "dgv_SupplierBill";
            this.dgv_SupplierBill.ReadOnly = true;
            this.dgv_SupplierBill.Size = new System.Drawing.Size(1143, 279);
            this.dgv_SupplierBill.TabIndex = 3;
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // BillNo
            // 
            this.BillNo.HeaderText = "BillNo";
            this.BillNo.Name = "BillNo";
            this.BillNo.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "Supplier Name";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // GSTIN
            // 
            this.GSTIN.HeaderText = "GSTIN";
            this.GSTIN.Name = "GSTIN";
            this.GSTIN.ReadOnly = true;
            // 
            // HSNCode
            // 
            this.HSNCode.HeaderText = "HSN Code";
            this.HSNCode.Name = "HSNCode";
            this.HSNCode.ReadOnly = true;
            // 
            // BillAmt
            // 
            this.BillAmt.HeaderText = "BillAmt";
            this.BillAmt.Name = "BillAmt";
            this.BillAmt.ReadOnly = true;
            // 
            // CGST
            // 
            this.CGST.HeaderText = "CGST";
            this.CGST.Name = "CGST";
            this.CGST.ReadOnly = true;
            // 
            // SGST
            // 
            this.SGST.HeaderText = "SGST";
            this.SGST.Name = "SGST";
            this.SGST.ReadOnly = true;
            // 
            // IGST
            // 
            this.IGST.HeaderText = "IGST";
            this.IGST.Name = "IGST";
            this.IGST.ReadOnly = true;
            // 
            // TotalAmt
            // 
            this.TotalAmt.HeaderText = "TotalAmt";
            this.TotalAmt.Name = "TotalAmt";
            this.TotalAmt.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Supplier GST Report";
            // 
            // frm_SupplierGSTReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_SupplierBill);
            this.Controls.Add(this.bttn_close);
            this.Controls.Add(this.bttn_excel);
            this.Controls.Add(this.dtp1);
            this.KeyPreview = true;
            this.Name = "frm_SupplierGSTReport";
            this.Text = "Supplier GST Report";
            this.Load += new System.EventHandler(this.frm_SupplierBill_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_SupplierBill_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SupplierBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button bttn_excel;
        private System.Windows.Forms.Button bttn_close;
        private System.Windows.Forms.DataGridView dgv_SupplierBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GSTIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSNCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmt;
        private System.Windows.Forms.Label label1;
    }
}