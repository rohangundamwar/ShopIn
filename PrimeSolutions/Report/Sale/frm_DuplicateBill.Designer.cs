namespace PrimeSolutions.Report.Sale
{
    partial class frm_DuplicateBill
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
            this.cmb_customer = new System.Windows.Forms.ComboBox();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.dgv_Bill = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Bill = new System.Windows.Forms.Label();
            this.bttn_print = new System.Windows.Forms.Button();
            this.bttn_view = new System.Windows.Forms.Button();
            this.bttn_close = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_customer
            // 
            this.cmb_customer.DisplayMember = "CustomerName";
            this.cmb_customer.FormattingEnabled = true;
            this.cmb_customer.Location = new System.Drawing.Point(105, 32);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.Size = new System.Drawing.Size(225, 21);
            this.cmb_customer.TabIndex = 0;
            this.cmb_customer.ValueMember = "CustomerName";
            this.cmb_customer.SelectedIndexChanged += new System.EventHandler(this.cmb_customer_SelectedIndexChanged);
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Location = new System.Drawing.Point(17, 35);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(82, 13);
            this.lbl_customer.TabIndex = 1;
            this.lbl_customer.Text = "Customer Name";
            // 
            // dgv_Bill
            // 
            this.dgv_Bill.AllowUserToAddRows = false;
            this.dgv_Bill.AllowUserToDeleteRows = false;
            this.dgv_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.BillNo,
            this.Amount});
            this.dgv_Bill.Location = new System.Drawing.Point(15, 88);
            this.dgv_Bill.Name = "dgv_Bill";
            this.dgv_Bill.ReadOnly = true;
            this.dgv_Bill.Size = new System.Drawing.Size(323, 150);
            this.dgv_Bill.TabIndex = 2;
            this.dgv_Bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Bill_CellClick);
            // 
            // Date
            // 
            this.Date.FillWeight = 80F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 80;
            // 
            // BillNo
            // 
            this.BillNo.HeaderText = "BillNo";
            this.BillNo.Name = "BillNo";
            this.BillNo.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // lbl_Bill
            // 
            this.lbl_Bill.AutoSize = true;
            this.lbl_Bill.Location = new System.Drawing.Point(19, 66);
            this.lbl_Bill.Name = "lbl_Bill";
            this.lbl_Bill.Size = new System.Drawing.Size(37, 13);
            this.lbl_Bill.TabIndex = 3;
            this.lbl_Bill.Text = "Bill No";
            // 
            // bttn_print
            // 
            this.bttn_print.Location = new System.Drawing.Point(139, 248);
            this.bttn_print.Name = "bttn_print";
            this.bttn_print.Size = new System.Drawing.Size(75, 23);
            this.bttn_print.TabIndex = 4;
            this.bttn_print.Text = "PRINT";
            this.bttn_print.UseVisualStyleBackColor = true;
            this.bttn_print.Click += new System.EventHandler(this.bttn_print_Click);
            // 
            // bttn_view
            // 
            this.bttn_view.ForeColor = System.Drawing.Color.Green;
            this.bttn_view.Location = new System.Drawing.Point(16, 248);
            this.bttn_view.Name = "bttn_view";
            this.bttn_view.Size = new System.Drawing.Size(75, 23);
            this.bttn_view.TabIndex = 5;
            this.bttn_view.Text = "VIEW";
            this.bttn_view.UseVisualStyleBackColor = true;
            this.bttn_view.Click += new System.EventHandler(this.bttn_view_Click);
            // 
            // bttn_close
            // 
            this.bttn_close.ForeColor = System.Drawing.Color.Red;
            this.bttn_close.Location = new System.Drawing.Point(262, 248);
            this.bttn_close.Name = "bttn_close";
            this.bttn_close.Size = new System.Drawing.Size(75, 23);
            this.bttn_close.TabIndex = 6;
            this.bttn_close.Text = "CLOSE";
            this.bttn_close.UseVisualStyleBackColor = true;
            this.bttn_close.Click += new System.EventHandler(this.button2_Click);
            // 
            // bill
            // 
            this.bill.AutoSize = true;
            this.bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.bill.Location = new System.Drawing.Point(108, 66);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(0, 13);
            this.bill.TabIndex = 7;
            // 
            // frm_DuplicateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 283);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.bttn_close);
            this.Controls.Add(this.bttn_view);
            this.Controls.Add(this.bttn_print);
            this.Controls.Add(this.lbl_Bill);
            this.Controls.Add(this.dgv_Bill);
            this.Controls.Add(this.lbl_customer);
            this.Controls.Add(this.cmb_customer);
            this.Name = "frm_DuplicateBill";
            this.Text = "Duplicate Bill";
            this.Load += new System.EventHandler(this.frm_DuplicateBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_customer;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.DataGridView dgv_Bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label lbl_Bill;
        private System.Windows.Forms.Button bttn_print;
        private System.Windows.Forms.Button bttn_view;
        private System.Windows.Forms.Button bttn_close;
        private System.Windows.Forms.Label bill;
    }
}