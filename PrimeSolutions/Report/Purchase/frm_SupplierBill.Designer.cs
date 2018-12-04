namespace PrimeSolutions.Report.Purchase
{
    partial class frm_SupplierBill
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
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.bttn_excel = new System.Windows.Forms.Button();
            this.bttn_close = new System.Windows.Forms.Button();
            this.dgv_SupplierBill = new System.Windows.Forms.DataGridView();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.bttn_Generate = new System.Windows.Forms.Button();
            this.Bttn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefrenceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SupplierBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_to
            // 
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(173, 42);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(101, 20);
            this.dtp_to.TabIndex = 0;
            // 
            // bttn_excel
            // 
            this.bttn_excel.Location = new System.Drawing.Point(532, 43);
            this.bttn_excel.Name = "bttn_excel";
            this.bttn_excel.Size = new System.Drawing.Size(107, 23);
            this.bttn_excel.TabIndex = 1;
            this.bttn_excel.Text = "Export To Excel";
            this.bttn_excel.UseVisualStyleBackColor = true;
            this.bttn_excel.Click += new System.EventHandler(this.bttn_excel_Click);
            // 
            // bttn_close
            // 
            this.bttn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_close.ForeColor = System.Drawing.Color.White;
            this.bttn_close.Location = new System.Drawing.Point(878, 42);
            this.bttn_close.Name = "bttn_close";
            this.bttn_close.Size = new System.Drawing.Size(75, 23);
            this.bttn_close.TabIndex = 2;
            this.bttn_close.Text = "Close";
            this.bttn_close.UseVisualStyleBackColor = false;
            this.bttn_close.Click += new System.EventHandler(this.bttn_close_Click);
            // 
            // dgv_SupplierBill
            // 
            this.dgv_SupplierBill.AllowUserToAddRows = false;
            this.dgv_SupplierBill.AllowUserToDeleteRows = false;
            this.dgv_SupplierBill.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_SupplierBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SupplierBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chk,
            this.SrNo,
            this.Name,
            this.BillNo,
            this.RefrenceNo,
            this.Date,
            this.BillAmt,
            this.CGST,
            this.SGST,
            this.IGST,
            this.TotalAmt});
            this.dgv_SupplierBill.Location = new System.Drawing.Point(11, 87);
            this.dgv_SupplierBill.Name = "dgv_SupplierBill";
            this.dgv_SupplierBill.Size = new System.Drawing.Size(1023, 279);
            this.dgv_SupplierBill.TabIndex = 3;
            this.dgv_SupplierBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SupplierBill_CellContentClick);
            // 
            // dtp_from
            // 
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(21, 43);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(101, 20);
            this.dtp_from.TabIndex = 4;
            // 
            // bttn_Generate
            // 
            this.bttn_Generate.BackColor = System.Drawing.Color.Green;
            this.bttn_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Generate.ForeColor = System.Drawing.Color.White;
            this.bttn_Generate.Location = new System.Drawing.Point(366, 43);
            this.bttn_Generate.Name = "bttn_Generate";
            this.bttn_Generate.Size = new System.Drawing.Size(75, 23);
            this.bttn_Generate.TabIndex = 5;
            this.bttn_Generate.Text = "Generate";
            this.bttn_Generate.UseVisualStyleBackColor = false;
            this.bttn_Generate.Click += new System.EventHandler(this.bttn_Generate_Click);
            // 
            // Bttn_delete
            // 
            this.Bttn_delete.BackColor = System.Drawing.Color.Red;
            this.Bttn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_delete.ForeColor = System.Drawing.Color.White;
            this.Bttn_delete.Location = new System.Drawing.Point(748, 43);
            this.Bttn_delete.Name = "Bttn_delete";
            this.Bttn_delete.Size = new System.Drawing.Size(75, 23);
            this.Bttn_delete.TabIndex = 6;
            this.Bttn_delete.Text = "Delete";
            this.Bttn_delete.UseVisualStyleBackColor = false;
            this.Bttn_delete.Click += new System.EventHandler(this.Bttn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(174, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "From";
            // 
            // Chk
            // 
            this.Chk.FillWeight = 30F;
            this.Chk.HeaderText = "Chk";
            this.Chk.Name = "Chk";
            this.Chk.Width = 30;
            // 
            // SrNo
            // 
            this.SrNo.FillWeight = 50F;
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.Width = 50;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // BillNo
            // 
            this.BillNo.HeaderText = "BillNo";
            this.BillNo.Name = "BillNo";
            // 
            // RefrenceNo
            // 
            this.RefrenceNo.HeaderText = "RefrenceNo";
            this.RefrenceNo.Name = "RefrenceNo";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // BillAmt
            // 
            this.BillAmt.HeaderText = "BillAmt";
            this.BillAmt.Name = "BillAmt";
            // 
            // CGST
            // 
            this.CGST.HeaderText = "CGST";
            this.CGST.Name = "CGST";
            // 
            // SGST
            // 
            this.SGST.HeaderText = "SGST";
            this.SGST.Name = "SGST";
            // 
            // IGST
            // 
            this.IGST.HeaderText = "IGST";
            this.IGST.Name = "IGST";
            // 
            // TotalAmt
            // 
            this.TotalAmt.HeaderText = "TotalAmt";
            this.TotalAmt.Name = "TotalAmt";
            // 
            // frm_SupplierBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bttn_delete);
            this.Controls.Add(this.bttn_Generate);
            this.Controls.Add(this.dtp_from);
            this.Controls.Add(this.dgv_SupplierBill);
            this.Controls.Add(this.bttn_close);
            this.Controls.Add(this.bttn_excel);
            this.Controls.Add(this.dtp_to);
            this.KeyPreview = true;
            this.Text = "Supplier Bill";
            this.Load += new System.EventHandler(this.frm_SupplierBill_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_SupplierBill_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SupplierBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.Button bttn_excel;
        private System.Windows.Forms.Button bttn_close;
        private System.Windows.Forms.DataGridView dgv_SupplierBill;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Button bttn_Generate;
        private System.Windows.Forms.Button Bttn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefrenceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmt;
    }
}