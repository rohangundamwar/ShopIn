namespace PrimeSolutions.Report.Purchase
{
    partial class PurchaseReport
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
            this.dgv_supplier = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.bttn_generate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_supplier
            // 
            this.dgv_supplier.AllowUserToDeleteRows = false;
            this.dgv_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_supplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Supplier,
            this.Amount,
            this.PaymentStatus});
            this.dgv_supplier.Location = new System.Drawing.Point(30, 83);
            this.dgv_supplier.Name = "dgv_supplier";
            this.dgv_supplier.ReadOnly = true;
            this.dgv_supplier.Size = new System.Drawing.Size(493, 332);
            this.dgv_supplier.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            this.Supplier.Width = 150;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.HeaderText = "PaymentStatus";
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.ReadOnly = true;
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(121, 22);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(96, 20);
            this.dtp_start.TabIndex = 1;
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(314, 22);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(97, 20);
            this.dtp_end.TabIndex = 2;
            // 
            // bttn_generate
            // 
            this.bttn_generate.Location = new System.Drawing.Point(311, 54);
            this.bttn_generate.Name = "bttn_generate";
            this.bttn_generate.Size = new System.Drawing.Size(101, 23);
            this.bttn_generate.TabIndex = 3;
            this.bttn_generate.Text = "button1";
            this.bttn_generate.UseVisualStyleBackColor = true;
            // 
            // PurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 441);
            this.Controls.Add(this.bttn_generate);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.dgv_supplier);
            this.Name = "PurchaseReport";
            this.Text = "PurchaseReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Button bttn_generate;
    }
}