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
            this.cmb_month.Location = new System.Drawing.Point(151, 36);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.Size = new System.Drawing.Size(128, 21);
            this.cmb_month.TabIndex = 0;
            this.cmb_month.ValueMember = "Collection";
            // 
            // bttn_Generate
            // 
            this.bttn_Generate.Location = new System.Drawing.Point(308, 36);
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
            this.dgv_purchase.Location = new System.Drawing.Point(12, 83);
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
            this.dgv_sale.Location = new System.Drawing.Point(12, 304);
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
            this.bttn_print.Location = new System.Drawing.Point(415, 36);
            this.bttn_print.Name = "bttn_print";
            this.bttn_print.Size = new System.Drawing.Size(75, 23);
            this.bttn_print.TabIndex = 4;
            this.bttn_print.Text = "Print";
            this.bttn_print.UseVisualStyleBackColor = false;
            this.bttn_print.Click += new System.EventHandler(this.bttn_print_Click);
            // 
            // frm_MonthlyGSTReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 502);
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
    }
}