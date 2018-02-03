namespace PrimeSolutions.Report
{
    partial class frm_MonthlyGSTReport
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
            this.cmb_month = new System.Windows.Forms.ComboBox();
            this.bttn_Generate = new System.Windows.Forms.Button();
            this.dgv_purchase = new System.Windows.Forms.DataGridView();
            this.GSTPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taxable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_sale = new System.Windows.Forms.DataGridView();
            this.GSTper2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taxable2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGST2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttn_print = new System.Windows.Forms.Button();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_sale = new System.Windows.Forms.Label();
            this.lbl_Purchase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sale)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_month
            // 
            this.cmb_month.DisplayMember = "Collection";
            this.cmb_month.FormattingEnabled = true;
            this.cmb_month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmb_month.Location = new System.Drawing.Point(55, 38);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.Size = new System.Drawing.Size(128, 21);
            this.cmb_month.TabIndex = 0;
            this.cmb_month.ValueMember = "Collection";
            this.cmb_month.TextChanged += new System.EventHandler(this.cmb_month_TextChanged);
            // 
            // bttn_Generate
            // 
            this.bttn_Generate.Location = new System.Drawing.Point(316, 37);
            this.bttn_Generate.Name = "bttn_Generate";
            this.bttn_Generate.Size = new System.Drawing.Size(75, 23);
            this.bttn_Generate.TabIndex = 1;
            this.bttn_Generate.Text = "Generate";
            this.bttn_Generate.UseVisualStyleBackColor = true;
            this.bttn_Generate.Click += new System.EventHandler(this.bttn_Generate_Click);
            // 
            // dgv_purchase
            // 
            this.dgv_purchase.AllowUserToAddRows = false;
            this.dgv_purchase.AllowUserToDeleteRows = false;
            this.dgv_purchase.BackgroundColor = System.Drawing.Color.Snow;
            this.dgv_purchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_purchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GSTPer,
            this.Taxable,
            this.SGST,
            this.CGST,
            this.IGST});
            this.dgv_purchase.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgv_purchase.Location = new System.Drawing.Point(13, 106);
            this.dgv_purchase.Name = "dgv_purchase";
            this.dgv_purchase.ReadOnly = true;
            this.dgv_purchase.Size = new System.Drawing.Size(543, 180);
            this.dgv_purchase.TabIndex = 2;
            // 
            // GSTPer
            // 
            this.GSTPer.HeaderText = "GST%";
            this.GSTPer.Name = "GSTPer";
            this.GSTPer.ReadOnly = true;
            // 
            // Taxable
            // 
            this.Taxable.HeaderText = "Taxable";
            this.Taxable.Name = "Taxable";
            this.Taxable.ReadOnly = true;
            // 
            // SGST
            // 
            this.SGST.HeaderText = "SGST";
            this.SGST.Name = "SGST";
            this.SGST.ReadOnly = true;
            // 
            // CGST
            // 
            this.CGST.HeaderText = "CGST";
            this.CGST.Name = "CGST";
            this.CGST.ReadOnly = true;
            // 
            // IGST
            // 
            this.IGST.HeaderText = "IGST";
            this.IGST.Name = "IGST";
            this.IGST.ReadOnly = true;
            // 
            // dgv_sale
            // 
            this.dgv_sale.AllowUserToAddRows = false;
            this.dgv_sale.AllowUserToDeleteRows = false;
            this.dgv_sale.BackgroundColor = System.Drawing.Color.Snow;
            this.dgv_sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GSTper2,
            this.Taxable2,
            this.SGST2,
            this.CGST2,
            this.IGST2});
            this.dgv_sale.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgv_sale.Location = new System.Drawing.Point(12, 337);
            this.dgv_sale.Name = "dgv_sale";
            this.dgv_sale.ReadOnly = true;
            this.dgv_sale.Size = new System.Drawing.Size(543, 180);
            this.dgv_sale.TabIndex = 3;
            // 
            // GSTper2
            // 
            this.GSTper2.HeaderText = "GST%";
            this.GSTper2.Name = "GSTper2";
            this.GSTper2.ReadOnly = true;
            // 
            // Taxable2
            // 
            this.Taxable2.HeaderText = "Taxable";
            this.Taxable2.Name = "Taxable2";
            this.Taxable2.ReadOnly = true;
            // 
            // SGST2
            // 
            this.SGST2.HeaderText = "SGST";
            this.SGST2.Name = "SGST2";
            this.SGST2.ReadOnly = true;
            // 
            // CGST2
            // 
            this.CGST2.HeaderText = "CGST";
            this.CGST2.Name = "CGST2";
            this.CGST2.ReadOnly = true;
            // 
            // IGST2
            // 
            this.IGST2.HeaderText = "IGST";
            this.IGST2.Name = "IGST2";
            this.IGST2.ReadOnly = true;
            // 
            // bttn_print
            // 
            this.bttn_print.BackColor = System.Drawing.Color.Green;
            this.bttn_print.ForeColor = System.Drawing.Color.White;
            this.bttn_print.Location = new System.Drawing.Point(415, 37);
            this.bttn_print.Name = "bttn_print";
            this.bttn_print.Size = new System.Drawing.Size(75, 23);
            this.bttn_print.TabIndex = 4;
            this.bttn_print.Text = "Print";
            this.bttn_print.UseVisualStyleBackColor = false;
            this.bttn_print.Click += new System.EventHandler(this.bttn_print_Click);
            // 
            // cmb_year
            // 
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019"});
            this.cmb_year.Location = new System.Drawing.Point(207, 38);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(85, 21);
            this.cmb_year.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(189, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Purchase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(209, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sale";
            // 
            // lbl_sale
            // 
            this.lbl_sale.AutoSize = true;
            this.lbl_sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sale.ForeColor = System.Drawing.Color.Red;
            this.lbl_sale.Location = new System.Drawing.Point(272, 304);
            this.lbl_sale.Name = "lbl_sale";
            this.lbl_sale.Size = new System.Drawing.Size(84, 20);
            this.lbl_sale.TabIndex = 8;
            this.lbl_sale.Text = "Purchase";
            // 
            // lbl_Purchase
            // 
            this.lbl_Purchase.AutoSize = true;
            this.lbl_Purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase.ForeColor = System.Drawing.Color.Green;
            this.lbl_Purchase.Location = new System.Drawing.Point(272, 81);
            this.lbl_Purchase.Name = "lbl_Purchase";
            this.lbl_Purchase.Size = new System.Drawing.Size(84, 20);
            this.lbl_Purchase.TabIndex = 9;
            this.lbl_Purchase.Text = "Purchase";
            // 
            // frm_MonthlyGSTReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 529);
            this.Controls.Add(this.lbl_Purchase);
            this.Controls.Add(this.lbl_sale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_year);
            this.Controls.Add(this.bttn_print);
            this.Controls.Add(this.dgv_sale);
            this.Controls.Add(this.dgv_purchase);
            this.Controls.Add(this.bttn_Generate);
            this.Controls.Add(this.cmb_month);
            this.Name = "frm_MonthlyGSTReport";
            this.Text = "frm_MonthlyGSTReport";
            this.Load += new System.EventHandler(this.frm_MonthlyGSTReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_month;
        private System.Windows.Forms.Button bttn_Generate;
        private System.Windows.Forms.DataGridView dgv_purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn GSTPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taxable;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGST;
        private System.Windows.Forms.DataGridView dgv_sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn GSTper2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taxable2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGST2;
        private System.Windows.Forms.Button bttn_print;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_sale;
        private System.Windows.Forms.Label lbl_Purchase;
    }
}