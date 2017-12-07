namespace PrimeSolutions.Report.Purchase
{
    partial class frm_SupplierBalance
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
            this.dgv_Balance = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_customer = new System.Windows.Forms.ComboBox();
            this.bttn_Find = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.bttn_close = new System.Windows.Forms.Button();
            this.bttn_Excel = new System.Windows.Forms.Button();
            this.bttn_reset = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.bttn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Balance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Balance
            // 
            this.dgv_Balance.AllowUserToAddRows = false;
            this.dgv_Balance.AllowUserToDeleteRows = false;
            this.dgv_Balance.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dgv_Balance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Balance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.TotalPurchase,
            this.NoOfBill,
            this.TotalPaid,
            this.TotalBalance});
            this.dgv_Balance.Location = new System.Drawing.Point(12, 68);
            this.dgv_Balance.Name = "dgv_Balance";
            this.dgv_Balance.ReadOnly = true;
            this.dgv_Balance.Size = new System.Drawing.Size(643, 196);
            this.dgv_Balance.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.FillWeight = 200F;
            this.Name.HeaderText = "SupplierName";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 200;
            // 
            // TotalPurchase
            // 
            this.TotalPurchase.HeaderText = "TotalPurchase";
            this.TotalPurchase.Name = "TotalPurchase";
            this.TotalPurchase.ReadOnly = true;
            // 
            // NoOfBill
            // 
            this.NoOfBill.HeaderText = "NoOfBill";
            this.NoOfBill.Name = "NoOfBill";
            this.NoOfBill.ReadOnly = true;
            // 
            // TotalPaid
            // 
            this.TotalPaid.HeaderText = "TotalPaid";
            this.TotalPaid.Name = "TotalPaid";
            this.TotalPaid.ReadOnly = true;
            // 
            // TotalBalance
            // 
            this.TotalBalance.HeaderText = "TotalBalance";
            this.TotalBalance.Name = "TotalBalance";
            this.TotalBalance.ReadOnly = true;
            // 
            // cmb_customer
            // 
            this.cmb_customer.DisplayMember = "Name";
            this.cmb_customer.FormattingEnabled = true;
            this.cmb_customer.Location = new System.Drawing.Point(118, 25);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.Size = new System.Drawing.Size(254, 21);
            this.cmb_customer.TabIndex = 1;
            this.cmb_customer.ValueMember = "Name";
            // 
            // bttn_Find
            // 
            this.bttn_Find.ForeColor = System.Drawing.Color.Green;
            this.bttn_Find.Location = new System.Drawing.Point(396, 24);
            this.bttn_Find.Name = "bttn_Find";
            this.bttn_Find.Size = new System.Drawing.Size(75, 23);
            this.bttn_Find.TabIndex = 2;
            this.bttn_Find.Text = "Find";
            this.bttn_Find.UseVisualStyleBackColor = true;
            this.bttn_Find.Click += new System.EventHandler(this.bttn_Find_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 29);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(76, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Supplier Name";
            // 
            // bttn_close
            // 
            this.bttn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttn_close.ForeColor = System.Drawing.Color.Red;
            this.bttn_close.Location = new System.Drawing.Point(580, 280);
            this.bttn_close.Name = "bttn_close";
            this.bttn_close.Size = new System.Drawing.Size(75, 23);
            this.bttn_close.TabIndex = 4;
            this.bttn_close.Text = "Close";
            this.bttn_close.UseVisualStyleBackColor = true;
            // 
            // bttn_Excel
            // 
            this.bttn_Excel.ForeColor = System.Drawing.Color.Blue;
            this.bttn_Excel.Location = new System.Drawing.Point(490, 24);
            this.bttn_Excel.Name = "bttn_Excel";
            this.bttn_Excel.Size = new System.Drawing.Size(75, 23);
            this.bttn_Excel.TabIndex = 5;
            this.bttn_Excel.Text = "Excel";
            this.bttn_Excel.UseVisualStyleBackColor = true;
            this.bttn_Excel.Click += new System.EventHandler(this.bttn_Excel_Click);
            // 
            // bttn_reset
            // 
            this.bttn_reset.ForeColor = System.Drawing.Color.Yellow;
            this.bttn_reset.Location = new System.Drawing.Point(580, 25);
            this.bttn_reset.Name = "bttn_reset";
            this.bttn_reset.Size = new System.Drawing.Size(75, 23);
            this.bttn_reset.TabIndex = 6;
            this.bttn_reset.Text = "Reset";
            this.bttn_reset.UseVisualStyleBackColor = true;
            this.bttn_reset.Click += new System.EventHandler(this.bttn_reset_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(15, 280);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_date.TabIndex = 7;
            // 
            // bttn_Print
            // 
            this.bttn_Print.ForeColor = System.Drawing.Color.Blue;
            this.bttn_Print.Location = new System.Drawing.Point(490, 280);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(75, 23);
            this.bttn_Print.TabIndex = 8;
            this.bttn_Print.Text = "Print";
            this.bttn_Print.UseVisualStyleBackColor = true;
            this.bttn_Print.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_SupplierBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttn_close;
            this.ClientSize = new System.Drawing.Size(667, 315);
            this.Controls.Add(this.bttn_Print);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.bttn_reset);
            this.Controls.Add(this.bttn_Excel);
            this.Controls.Add(this.bttn_close);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.bttn_Find);
            this.Controls.Add(this.cmb_customer);
            this.Controls.Add(this.dgv_Balance);
            this.Text = "Supplier Balance";
            this.Load += new System.EventHandler(this.frm_CustomerBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Balance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Balance;
        private System.Windows.Forms.ComboBox cmb_customer;
        private System.Windows.Forms.Button bttn_Find;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button bttn_close;
        private System.Windows.Forms.Button bttn_Excel;
        private System.Windows.Forms.Button bttn_reset;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBalance;
        private System.Windows.Forms.Button bttn_Print;
    }
}