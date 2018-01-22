namespace PrimeSolutions.Report.Purchase
{
    partial class frm_PurchaseLedger
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
            this.cmb_supplier = new System.Windows.Forms.ComboBox();
            this.bttn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Bill = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Payment = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Bill = new System.Windows.Forms.Label();
            this.txt_payment = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payment)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_supplier
            // 
            this.cmb_supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_supplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_supplier.DisplayMember = "Name";
            this.cmb_supplier.FormattingEnabled = true;
            this.cmb_supplier.Location = new System.Drawing.Point(77, 30);
            this.cmb_supplier.Name = "cmb_supplier";
            this.cmb_supplier.Size = new System.Drawing.Size(217, 21);
            this.cmb_supplier.TabIndex = 0;
            this.cmb_supplier.ValueMember = "Name";
            // 
            // bttn_search
            // 
            this.bttn_search.Location = new System.Drawing.Point(365, 29);
            this.bttn_search.Name = "bttn_search";
            this.bttn_search.Size = new System.Drawing.Size(75, 23);
            this.bttn_search.TabIndex = 1;
            this.bttn_search.Text = "Search";
            this.bttn_search.UseVisualStyleBackColor = true;
            this.bttn_search.Click += new System.EventHandler(this.bttn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplier";
            // 
            // dgv_Bill
            // 
            this.dgv_Bill.AllowUserToAddRows = false;
            this.dgv_Bill.AllowUserToDeleteRows = false;
            this.dgv_Bill.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.BillNo,
            this.Amount});
            this.dgv_Bill.Location = new System.Drawing.Point(12, 77);
            this.dgv_Bill.Name = "dgv_Bill";
            this.dgv_Bill.ReadOnly = true;
            this.dgv_Bill.Size = new System.Drawing.Size(347, 332);
            this.dgv_Bill.TabIndex = 3;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
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
            // dgv_Payment
            // 
            this.dgv_Payment.AllowUserToAddRows = false;
            this.dgv_Payment.AllowUserToDeleteRows = false;
            this.dgv_Payment.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_Payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Payment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PayDate,
            this.Payment_No,
            this.PaidAmt,
            this.PayType});
            this.dgv_Payment.Location = new System.Drawing.Point(365, 77);
            this.dgv_Payment.Name = "dgv_Payment";
            this.dgv_Payment.ReadOnly = true;
            this.dgv_Payment.Size = new System.Drawing.Size(444, 332);
            this.dgv_Payment.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(15, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Bill :  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(362, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Payment : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(362, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Balance : ";
            // 
            // txt_Bill
            // 
            this.txt_Bill.AutoSize = true;
            this.txt_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bill.Location = new System.Drawing.Point(90, 422);
            this.txt_Bill.Name = "txt_Bill";
            this.txt_Bill.Size = new System.Drawing.Size(51, 16);
            this.txt_Bill.TabIndex = 8;
            this.txt_Bill.Text = "label5";
            // 
            // txt_payment
            // 
            this.txt_payment.AutoSize = true;
            this.txt_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment.Location = new System.Drawing.Point(475, 422);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(51, 16);
            this.txt_payment.TabIndex = 9;
            this.txt_payment.Text = "label6";
            // 
            // txt_balance
            // 
            this.txt_balance.AutoSize = true;
            this.txt_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_balance.Location = new System.Drawing.Point(475, 446);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(51, 16);
            this.txt_balance.TabIndex = 10;
            this.txt_balance.Text = "label7";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(469, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PayDate
            // 
            this.PayDate.HeaderText = "PayDate";
            this.PayDate.Name = "PayDate";
            this.PayDate.ReadOnly = true;
            // 
            // Payment_No
            // 
            this.Payment_No.HeaderText = "Payment_No";
            this.Payment_No.Name = "Payment_No";
            this.Payment_No.ReadOnly = true;
            // 
            // PaidAmt
            // 
            this.PaidAmt.HeaderText = "PaidAmt";
            this.PaidAmt.Name = "PaidAmt";
            this.PaidAmt.ReadOnly = true;
            // 
            // PayType
            // 
            this.PayType.HeaderText = "PayType";
            this.PayType.Name = "PayType";
            this.PayType.ReadOnly = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(592, 30);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 12;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frm_PurchaseLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(827, 476);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.txt_payment);
            this.Controls.Add(this.txt_Bill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Payment);
            this.Controls.Add(this.dgv_Bill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttn_search);
            this.Controls.Add(this.cmb_supplier);
            this.KeyPreview = true;
            this.Name = "frm_PurchaseLedger";
            this.Text = "Purchase Ledger";
            this.Load += new System.EventHandler(this.frm_PurchaseLedger_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PurchaseLedger_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_supplier;
        private System.Windows.Forms.Button bttn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Bill;
        private System.Windows.Forms.DataGridView dgv_Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_Bill;
        private System.Windows.Forms.Label txt_payment;
        private System.Windows.Forms.Label txt_balance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayType;
        private System.Windows.Forms.Button btn_Close;
    }
}