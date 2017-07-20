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
            this.lbl_BarcodeComp = new System.Windows.Forms.Label();
            this.lbl_print = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.txt_print = new System.Windows.Forms.TextBox();
            this.bttn_save = new System.Windows.Forms.Button();
            this.rbt_yes1 = new System.Windows.Forms.RadioButton();
            this.rbt_No1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_barcode
            // 
            this.lbl_barcode.AutoSize = true;
            this.lbl_barcode.Location = new System.Drawing.Point(17, 70);
            this.lbl_barcode.Name = "lbl_barcode";
            this.lbl_barcode.Size = new System.Drawing.Size(78, 13);
            this.lbl_barcode.TabIndex = 0;
            this.lbl_barcode.Text = "Barcode Count";
            // 
            // lbl_BarcodeComp
            // 
            this.lbl_BarcodeComp.AutoSize = true;
            this.lbl_BarcodeComp.Location = new System.Drawing.Point(2, 25);
            this.lbl_BarcodeComp.Name = "lbl_BarcodeComp";
            this.lbl_BarcodeComp.Size = new System.Drawing.Size(104, 13);
            this.lbl_BarcodeComp.TabIndex = 2;
            this.lbl_BarcodeComp.Text = "Barcode Compulsary";
            // 
            // lbl_print
            // 
            this.lbl_print.AutoSize = true;
            this.lbl_print.Location = new System.Drawing.Point(24, 108);
            this.lbl_print.Name = "lbl_print";
            this.lbl_print.Size = new System.Drawing.Size(59, 13);
            this.lbl_print.TabIndex = 3;
            this.lbl_print.Text = "Print Count";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(107, 66);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(100, 20);
            this.txt_barcode.TabIndex = 4;
            // 
            // txt_print
            // 
            this.txt_print.Location = new System.Drawing.Point(107, 104);
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
            // rbt_yes1
            // 
            this.rbt_yes1.AutoSize = true;
            this.rbt_yes1.Location = new System.Drawing.Point(112, 23);
            this.rbt_yes1.Name = "rbt_yes1";
            this.rbt_yes1.Size = new System.Drawing.Size(43, 17);
            this.rbt_yes1.TabIndex = 9;
            this.rbt_yes1.TabStop = true;
            this.rbt_yes1.Text = "Yes";
            this.rbt_yes1.UseVisualStyleBackColor = true;
            // 
            // rbt_No1
            // 
            this.rbt_No1.AutoSize = true;
            this.rbt_No1.Location = new System.Drawing.Point(163, 23);
            this.rbt_No1.Name = "rbt_No1";
            this.rbt_No1.Size = new System.Drawing.Size(39, 17);
            this.rbt_No1.TabIndex = 10;
            this.rbt_No1.TabStop = true;
            this.rbt_No1.Text = "No";
            this.rbt_No1.UseVisualStyleBackColor = true;
            // 
            // frm_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 247);
            this.Controls.Add(this.rbt_No1);
            this.Controls.Add(this.rbt_yes1);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.txt_print);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.lbl_print);
            this.Controls.Add(this.lbl_BarcodeComp);
            this.Controls.Add(this.lbl_barcode);
            this.Name = "frm_Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.frm_Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_barcode;
        private System.Windows.Forms.Label lbl_BarcodeComp;
        private System.Windows.Forms.Label lbl_print;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.TextBox txt_print;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.RadioButton rbt_yes1;
        private System.Windows.Forms.RadioButton rbt_No1;
    }
}