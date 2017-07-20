namespace PrimeSolutions.Common
{
    partial class frm_Setting
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
            this.lbl_barcode = new System.Windows.Forms.Label();
            this.lbl_TaxPer = new System.Windows.Forms.Label();
            this.lbl_Tax = new System.Windows.Forms.Label();
            this.lbl_print = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.txt_TaxPer = new System.Windows.Forms.TextBox();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.txt_print = new System.Windows.Forms.TextBox();
            this.bttn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_barcode
            // 
            this.lbl_barcode.AutoSize = true;
            this.lbl_barcode.Location = new System.Drawing.Point(24, 26);
            this.lbl_barcode.Name = "lbl_barcode";
            this.lbl_barcode.Size = new System.Drawing.Size(78, 13);
            this.lbl_barcode.TabIndex = 0;
            this.lbl_barcode.Text = "Barcode Count";
            // 
            // lbl_TaxPer
            // 
            this.lbl_TaxPer.AutoSize = true;
            this.lbl_TaxPer.Location = new System.Drawing.Point(24, 137);
            this.lbl_TaxPer.Name = "lbl_TaxPer";
            this.lbl_TaxPer.Size = new System.Drawing.Size(36, 13);
            this.lbl_TaxPer.TabIndex = 1;
            this.lbl_TaxPer.Text = "Tax %";
            // 
            // lbl_Tax
            // 
            this.lbl_Tax.AutoSize = true;
            this.lbl_Tax.Location = new System.Drawing.Point(24, 100);
            this.lbl_Tax.Name = "lbl_Tax";
            this.lbl_Tax.Size = new System.Drawing.Size(52, 13);
            this.lbl_Tax.TabIndex = 2;
            this.lbl_Tax.Text = "Tax Type";
            // 
            // lbl_print
            // 
            this.lbl_print.AutoSize = true;
            this.lbl_print.Location = new System.Drawing.Point(24, 63);
            this.lbl_print.Name = "lbl_print";
            this.lbl_print.Size = new System.Drawing.Size(59, 13);
            this.lbl_print.TabIndex = 3;
            this.lbl_print.Text = "Print Count";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(107, 22);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(100, 20);
            this.txt_barcode.TabIndex = 4;
            // 
            // txt_TaxPer
            // 
            this.txt_TaxPer.Location = new System.Drawing.Point(107, 133);
            this.txt_TaxPer.Name = "txt_TaxPer";
            this.txt_TaxPer.Size = new System.Drawing.Size(100, 20);
            this.txt_TaxPer.TabIndex = 5;
            // 
            // txt_tax
            // 
            this.txt_tax.Location = new System.Drawing.Point(107, 96);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(100, 20);
            this.txt_tax.TabIndex = 6;
            // 
            // txt_print
            // 
            this.txt_print.Location = new System.Drawing.Point(107, 59);
            this.txt_print.Name = "txt_print";
            this.txt_print.Size = new System.Drawing.Size(100, 20);
            this.txt_print.TabIndex = 7;
            // 
            // bttn_save
            // 
            this.bttn_save.Location = new System.Drawing.Point(77, 185);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(75, 23);
            this.bttn_save.TabIndex = 8;
            this.bttn_save.Text = "Save";
            this.bttn_save.UseVisualStyleBackColor = true;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // frm_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 247);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.txt_print);
            this.Controls.Add(this.txt_tax);
            this.Controls.Add(this.txt_TaxPer);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.lbl_print);
            this.Controls.Add(this.lbl_Tax);
            this.Controls.Add(this.lbl_TaxPer);
            this.Controls.Add(this.lbl_barcode);
            this.Name = "frm_Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.frm_Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_barcode;
        private System.Windows.Forms.Label lbl_TaxPer;
        private System.Windows.Forms.Label lbl_Tax;
        private System.Windows.Forms.Label lbl_print;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.TextBox txt_TaxPer;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.TextBox txt_print;
        private System.Windows.Forms.Button bttn_save;
    }
}