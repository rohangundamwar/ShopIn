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
            this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttn_generate = new System.Windows.Forms.Button();
            this.bttn_Excel = new System.Windows.Forms.Button();
            this.bttn_close = new System.Windows.Forms.Button();
            this.dtp_ToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TotalSale = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Physical = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_saleBal = new System.Windows.Forms.Label();
            this.txt_Qty = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Bttn_Delete = new System.Windows.Forms.Button();
            this.bttn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_date
            // 
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(14, 38);
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
            this.Chk,
            this.Name,
            this.Type,
            this.BillNo,
            this.Date,
            this.Item,
            this.Qty,
            this.Amount,
            this.Discount,
            this.PaidAmt});
            this.dgv_CustomerItem.Location = new System.Drawing.Point(12, 82);
            this.dgv_CustomerItem.Name = "dgv_CustomerItem";
            this.dgv_CustomerItem.Size = new System.Drawing.Size(1013, 291);
            this.dgv_CustomerItem.TabIndex = 1;
            // 
            // Chk
            // 
            this.Chk.FillWeight = 30F;
            this.Chk.HeaderText = "Chk";
            this.Chk.Name = "Chk";
            this.Chk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Chk.Width = 30;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // BillNo
            // 
            this.BillNo.HeaderText = "BillNo";
            this.BillNo.Name = "BillNo";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.Width = 120;
            // 
            // Qty
            // 
            this.Qty.FillWeight = 50F;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Width = 50;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.Width = 120;
            // 
            // PaidAmt
            // 
            this.PaidAmt.HeaderText = "Paid Amount";
            this.PaidAmt.Name = "PaidAmt";
            // 
            // bttn_generate
            // 
            this.bttn_generate.Location = new System.Drawing.Point(368, 37);
            this.bttn_generate.Name = "bttn_generate";
            this.bttn_generate.Size = new System.Drawing.Size(75, 23);
            this.bttn_generate.TabIndex = 2;
            this.bttn_generate.Text = "Generate";
            this.bttn_generate.UseVisualStyleBackColor = true;
            this.bttn_generate.Click += new System.EventHandler(this.bttn_generate_Click);
            // 
            // bttn_Excel
            // 
            this.bttn_Excel.Location = new System.Drawing.Point(509, 37);
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
            this.bttn_close.Location = new System.Drawing.Point(666, 37);
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
            this.dtp_ToDate.Location = new System.Drawing.Point(191, 38);
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
            this.label3.Location = new System.Drawing.Point(15, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total \r\nSale";
            // 
            // txt_TotalSale
            // 
            this.txt_TotalSale.AutoSize = true;
            this.txt_TotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalSale.Location = new System.Drawing.Point(59, 394);
            this.txt_TotalSale.Name = "txt_TotalSale";
            this.txt_TotalSale.Size = new System.Drawing.Size(19, 20);
            this.txt_TotalSale.TabIndex = 9;
            this.txt_TotalSale.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Physical \r\nAmount";
            // 
            // txt_Physical
            // 
            this.txt_Physical.AutoSize = true;
            this.txt_Physical.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Physical.Location = new System.Drawing.Point(344, 394);
            this.txt_Physical.Name = "txt_Physical";
            this.txt_Physical.Size = new System.Drawing.Size(19, 20);
            this.txt_Physical.TabIndex = 11;
            this.txt_Physical.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sale in \r\nBalance";
            // 
            // txt_saleBal
            // 
            this.txt_saleBal.AutoSize = true;
            this.txt_saleBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_saleBal.Location = new System.Drawing.Point(625, 394);
            this.txt_saleBal.Name = "txt_saleBal";
            this.txt_saleBal.Size = new System.Drawing.Size(19, 20);
            this.txt_saleBal.TabIndex = 13;
            this.txt_saleBal.Text = "0";
            // 
            // txt_Qty
            // 
            this.txt_Qty.AutoSize = true;
            this.txt_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qty.Location = new System.Drawing.Point(823, 394);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(19, 20);
            this.txt_Qty.TabIndex = 15;
            this.txt_Qty.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(794, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Qty";
            // 
            // Bttn_Delete
            // 
            this.Bttn_Delete.BackColor = System.Drawing.Color.Coral;
            this.Bttn_Delete.Location = new System.Drawing.Point(948, 37);
            this.Bttn_Delete.Name = "Bttn_Delete";
            this.Bttn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Bttn_Delete.TabIndex = 16;
            this.Bttn_Delete.Text = "Delete";
            this.Bttn_Delete.UseVisualStyleBackColor = false;
            this.Bttn_Delete.Click += new System.EventHandler(this.Bttn_Delete_Click);
            // 
            // bttn_Print
            // 
            this.bttn_Print.BackColor = System.Drawing.Color.Blue;
            this.bttn_Print.ForeColor = System.Drawing.Color.White;
            this.bttn_Print.Location = new System.Drawing.Point(807, 37);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(75, 23);
            this.bttn_Print.TabIndex = 17;
            this.bttn_Print.Text = "Print";
            this.bttn_Print.UseVisualStyleBackColor = false;
            this.bttn_Print.Click += new System.EventHandler(this.bttn_Print_Click);
            // 
            // frm_SaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1043, 433);
            this.Controls.Add(this.bttn_Print);
            this.Controls.Add(this.Bttn_Delete);
            this.Controls.Add(this.txt_Qty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_saleBal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Physical);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TotalSale);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_TotalSale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_Physical;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt_saleBal;
        private System.Windows.Forms.Label txt_Qty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmt;
        private System.Windows.Forms.Button Bttn_Delete;
        private System.Windows.Forms.Button bttn_Print;
    }
}