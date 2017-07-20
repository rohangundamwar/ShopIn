namespace PrimeSolutions.Report.Sale
{
    partial class frm_DuplicateBill
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
            this.cmb_BillNo = new System.Windows.Forms.ComboBox();
            this.lbl_BillNo = new System.Windows.Forms.Label();
            this.bttn_print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_BillNo
            // 
            this.cmb_BillNo.DisplayMember = "BillNo";
            this.cmb_BillNo.FormattingEnabled = true;
            this.cmb_BillNo.Location = new System.Drawing.Point(143, 57);
            this.cmb_BillNo.Name = "cmb_BillNo";
            this.cmb_BillNo.Size = new System.Drawing.Size(138, 21);
            this.cmb_BillNo.TabIndex = 0;
            this.cmb_BillNo.ValueMember = "BillNo";
            // 
            // lbl_BillNo
            // 
            this.lbl_BillNo.AutoSize = true;
            this.lbl_BillNo.Location = new System.Drawing.Point(41, 60);
            this.lbl_BillNo.Name = "lbl_BillNo";
            this.lbl_BillNo.Size = new System.Drawing.Size(37, 13);
            this.lbl_BillNo.TabIndex = 1;
            this.lbl_BillNo.Text = "Bill No";
            // 
            // bttn_print
            // 
            this.bttn_print.Location = new System.Drawing.Point(143, 129);
            this.bttn_print.Name = "bttn_print";
            this.bttn_print.Size = new System.Drawing.Size(75, 23);
            this.bttn_print.TabIndex = 2;
            this.bttn_print.Text = "PRINT";
            this.bttn_print.UseVisualStyleBackColor = true;
            this.bttn_print.Click += new System.EventHandler(this.bttn_print_Click);
            // 
            // frm_DuplicateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 204);
            this.Controls.Add(this.bttn_print);
            this.Controls.Add(this.lbl_BillNo);
            this.Controls.Add(this.cmb_BillNo);
            this.Name = "frm_DuplicateBill";
            this.Text = "frm_DuplicateBill";
            this.Load += new System.EventHandler(this.frm_DuplicateBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_BillNo;
        private System.Windows.Forms.Label lbl_BillNo;
        private System.Windows.Forms.Button bttn_print;
    }
}