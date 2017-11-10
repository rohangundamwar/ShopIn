namespace PrimeSolutions.Report
{
    partial class PrinterSetting
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
            this.cmbPrintlist = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_copy = new System.Windows.Forms.Label();
            this.txt_copy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbPrintlist
            // 
            this.cmbPrintlist.FormattingEnabled = true;
            this.cmbPrintlist.Location = new System.Drawing.Point(81, 27);
            this.cmbPrintlist.Name = "cmbPrintlist";
            this.cmbPrintlist.Size = new System.Drawing.Size(203, 21);
            this.cmbPrintlist.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(61, 108);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(155, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Printer";
            // 
            // lbl_copy
            // 
            this.lbl_copy.AutoSize = true;
            this.lbl_copy.Location = new System.Drawing.Point(16, 72);
            this.lbl_copy.Name = "lbl_copy";
            this.lbl_copy.Size = new System.Drawing.Size(31, 13);
            this.lbl_copy.TabIndex = 4;
            this.lbl_copy.Text = "Copy";
            // 
            // txt_copy
            // 
            this.txt_copy.Location = new System.Drawing.Point(81, 68);
            this.txt_copy.Name = "txt_copy";
            this.txt_copy.Size = new System.Drawing.Size(100, 20);
            this.txt_copy.TabIndex = 5;
            this.txt_copy.TextChanged += new System.EventHandler(this.txt_copy_TextChanged);
            this.txt_copy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_copy_KeyPress);
            // 
            // PrinterSetting
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(296, 156);
            this.Controls.Add(this.txt_copy);
            this.Controls.Add(this.lbl_copy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbPrintlist);
            this.Name = "PrinterSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrinterSetting";
            this.Load += new System.EventHandler(this.PrinterSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPrintlist;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_copy;
        private System.Windows.Forms.TextBox txt_copy;
    }
}