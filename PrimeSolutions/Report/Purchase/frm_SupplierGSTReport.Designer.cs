namespace PrimeSolutions.Report.Purchase
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
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_from = new System.Windows.Forms.Label();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SupplierBill)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_excel
            // 
            this.bttn_excel.BackColor = System.Drawing.Color.ForestGreen;
            this.bttn_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_excel.ForeColor = System.Drawing.Color.White;
            this.bttn_excel.Location = new System.Drawing.Point(918, 72);
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
            this.bttn_close.Location = new System.Drawing.Point(1078, 72);
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
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(189, 78);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(20, 13);
            this.lbl_to.TabIndex = 11;
            this.lbl_to.Text = "To";
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(18, 78);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(30, 13);
            this.lbl_from.TabIndex = 10;
            this.lbl_from.Text = "From";
            // 
            // dtp_from
            // 
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(73, 74);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(103, 20);
            this.dtp_from.TabIndex = 9;
            // 
            // dtp_to
            // 
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(222, 74);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(103, 20);
            this.dtp_to.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(383, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_SupplierGSTReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.dtp_from);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_SupplierBill);
            this.Controls.Add(this.bttn_close);
            this.Controls.Add(this.bttn_excel);
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
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.Button button1;
    }
}