namespace PrimeSolutions.Report.Sale
{
    partial class frm_SaleReport
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
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.dgv_CustomerItem = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttn_generate = new System.Windows.Forms.Button();
            this.bttn_Excel = new System.Windows.Forms.Button();
            this.bttn_close = new System.Windows.Forms.Button();
            this.dtp_ToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Physical_Amt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_TotalSale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_date
            // 
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(12, 36);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(111, 20);
            this.dtp_date.TabIndex = 0;
            // 
            // dgv_CustomerItem
            // 
            this.dgv_CustomerItem.AllowUserToAddRows = false;
            this.dgv_CustomerItem.AllowUserToDeleteRows = false;
            this.dgv_CustomerItem.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dgv_CustomerItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustomerItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.BillNo,
            this.Date,
            this.Item,
            this.Amount,
            this.Discount,
            this.Paid_Amount});
            this.dgv_CustomerItem.Location = new System.Drawing.Point(11, 82);
            this.dgv_CustomerItem.Name = "dgv_CustomerItem";
            this.dgv_CustomerItem.ReadOnly = true;
            this.dgv_CustomerItem.Size = new System.Drawing.Size(738, 291);
            this.dgv_CustomerItem.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 160;
            // 
            // BillNo
            // 
            this.BillNo.HeaderText = "BillNo";
            this.BillNo.Name = "BillNo";
            this.BillNo.ReadOnly = true;
            this.BillNo.Width = 90;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 120;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 75;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 75;
            // 
            // Paid_Amount
            // 
            this.Paid_Amount.HeaderText = "Paid Amount";
            this.Paid_Amount.Name = "Paid_Amount";
            this.Paid_Amount.ReadOnly = true;
            this.Paid_Amount.Width = 75;
            // 
            // bttn_generate
            // 
            this.bttn_generate.Location = new System.Drawing.Point(370, 35);
            this.bttn_generate.Name = "bttn_generate";
            this.bttn_generate.Size = new System.Drawing.Size(75, 23);
            this.bttn_generate.TabIndex = 2;
            this.bttn_generate.Text = "Generate";
            this.bttn_generate.UseVisualStyleBackColor = true;
            this.bttn_generate.Click += new System.EventHandler(this.bttn_generate_Click);
            // 
            // bttn_Excel
            // 
            this.bttn_Excel.Location = new System.Drawing.Point(513, 35);
            this.bttn_Excel.Name = "bttn_Excel";
            this.bttn_Excel.Size = new System.Drawing.Size(91, 23);
            this.bttn_Excel.TabIndex = 3;
            this.bttn_Excel.Text = "Export to Excel";
            this.bttn_Excel.UseVisualStyleBackColor = true;
            this.bttn_Excel.Click += new System.EventHandler(this.bttn_Excel_Click);
            // 
            // bttn_close
            // 
            this.bttn_close.BackColor = System.Drawing.Color.Red;
            this.bttn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_close.ForeColor = System.Drawing.Color.White;
            this.bttn_close.Location = new System.Drawing.Point(672, 35);
            this.bttn_close.Margin = new System.Windows.Forms.Padding(0);
            this.bttn_close.Name = "bttn_close";
            this.bttn_close.Size = new System.Drawing.Size(75, 23);
            this.bttn_close.TabIndex = 4;
            this.bttn_close.Text = "Close";
            this.bttn_close.UseVisualStyleBackColor = false;
            this.bttn_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_ToDate
            // 
            this.dtp_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ToDate.Location = new System.Drawing.Point(191, 36);
            this.dtp_ToDate.Name = "dtp_ToDate";
            this.dtp_ToDate.Size = new System.Drawing.Size(111, 20);
            this.dtp_ToDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Physical Amount:";
            // 
            // lbl_Physical_Amt
            // 
            this.lbl_Physical_Amt.AutoSize = true;
            this.lbl_Physical_Amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Physical_Amt.Location = new System.Drawing.Point(465, 400);
            this.lbl_Physical_Amt.Name = "lbl_Physical_Amt";
            this.lbl_Physical_Amt.Size = new System.Drawing.Size(14, 13);
            this.lbl_Physical_Amt.TabIndex = 9;
            this.lbl_Physical_Amt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sale in Balance:";
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balance.Location = new System.Drawing.Point(643, 400);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(14, 13);
            this.lbl_Balance.TabIndex = 11;
            this.lbl_Balance.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Sale:";
            // 
            // lbl_TotalSale
            // 
            this.lbl_TotalSale.AutoSize = true;
            this.lbl_TotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalSale.Location = new System.Drawing.Point(84, 400);
            this.lbl_TotalSale.Name = "lbl_TotalSale";
            this.lbl_TotalSale.Size = new System.Drawing.Size(14, 13);
            this.lbl_TotalSale.TabIndex = 13;
            this.lbl_TotalSale.Text = "0";
            // 
            // frm_SaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(761, 435);
            this.Controls.Add(this.lbl_TotalSale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Physical_Amt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_ToDate);
            this.Controls.Add(this.bttn_close);
            this.Controls.Add(this.bttn_Excel);
            this.Controls.Add(this.bttn_generate);
            this.Controls.Add(this.dgv_CustomerItem);
            this.Controls.Add(this.dtp_date);
            this.KeyPreview = true;
            //this.Name = "frm_SaleReport";
            this.Text = "Daily Sale Report";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_SaleReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.DataGridView dgv_CustomerItem;
        private System.Windows.Forms.Button bttn_generate;
        private System.Windows.Forms.Button bttn_Excel;
        private System.Windows.Forms.Button bttn_close;
        private System.Windows.Forms.DateTimePicker dtp_ToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid_Amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Physical_Amt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_TotalSale;
    }
}