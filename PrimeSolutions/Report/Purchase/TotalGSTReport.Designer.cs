namespace PrimeSolutions.Report.Purchase
{
    partial class TotalGSTReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GSTIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GST5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGST5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxableAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierName,
            this.GSTIN,
            this.GST5,
            this.SGST5,
            this.IGST5,
            this.TaxableAmt,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(951, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "SupplierName";
            this.SupplierName.Name = "SupplierName";
            // 
            // GSTIN
            // 
            this.GSTIN.HeaderText = "GSTIN";
            this.GSTIN.Name = "GSTIN";
            // 
            // GST5
            // 
            this.GST5.HeaderText = "GST5";
            this.GST5.Name = "GST5";
            // 
            // SGST5
            // 
            this.SGST5.HeaderText = "SGST5";
            this.SGST5.Name = "SGST5";
            // 
            // IGST5
            // 
            this.IGST5.HeaderText = "IGST5";
            this.IGST5.Name = "IGST5";
            // 
            // TaxableAmt
            // 
            this.TaxableAmt.HeaderText = "TaxableAmt";
            this.TaxableAmt.Name = "TaxableAmt";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // TotalGSTReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 363);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TotalGSTReport";
            this.Text = "TotalGSTReport";
            this.Load += new System.EventHandler(this.TotalGSTReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GSTIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GST5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGST5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxableAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}