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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_BarcodeType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_CRT = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbt_EstPayNo = new System.Windows.Forms.RadioButton();
            this.rbt_EstPayYes = new System.Windows.Forms.RadioButton();
            this.lbl_EstimatePay = new System.Windows.Forms.Label();
            this.rbt_PaymentNo = new System.Windows.Forms.RadioButton();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.rbt_PaymentYes = new System.Windows.Forms.RadioButton();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_estimate = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_barcode
            // 
            this.lbl_barcode.AutoSize = true;
            this.lbl_barcode.Location = new System.Drawing.Point(10, 58);
            this.lbl_barcode.Name = "lbl_barcode";
            this.lbl_barcode.Size = new System.Drawing.Size(78, 13);
            this.lbl_barcode.TabIndex = 0;
            this.lbl_barcode.Text = "Barcode Count";
            // 
            // lbl_BarcodeComp
            // 
            this.lbl_BarcodeComp.AutoSize = true;
            this.lbl_BarcodeComp.Location = new System.Drawing.Point(10, 26);
            this.lbl_BarcodeComp.Name = "lbl_BarcodeComp";
            this.lbl_BarcodeComp.Size = new System.Drawing.Size(104, 13);
            this.lbl_BarcodeComp.TabIndex = 2;
            this.lbl_BarcodeComp.Text = "Barcode Compulsary";
            // 
            // lbl_print
            // 
            this.lbl_print.AutoSize = true;
            this.lbl_print.Location = new System.Drawing.Point(10, 26);
            this.lbl_print.Name = "lbl_print";
            this.lbl_print.Size = new System.Drawing.Size(59, 13);
            this.lbl_print.TabIndex = 3;
            this.lbl_print.Text = "Print Count";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(104, 54);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(65, 20);
            this.txt_barcode.TabIndex = 4;
            // 
            // txt_print
            // 
            this.txt_print.Location = new System.Drawing.Point(104, 22);
            this.txt_print.Name = "txt_print";
            this.txt_print.Size = new System.Drawing.Size(65, 20);
            this.txt_print.TabIndex = 7;
            // 
            // bttn_save
            // 
            this.bttn_save.Location = new System.Drawing.Point(267, 274);
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
            this.rbt_yes1.Location = new System.Drawing.Point(123, 24);
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
            this.rbt_No1.Location = new System.Drawing.Point(174, 24);
            this.rbt_No1.Name = "rbt_No1";
            this.rbt_No1.Size = new System.Drawing.Size(39, 17);
            this.rbt_No1.TabIndex = 10;
            this.rbt_No1.TabStop = true;
            this.rbt_No1.Text = "No";
            this.rbt_No1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_BarcodeType);
            this.groupBox1.Controls.Add(this.lbl_BarcodeComp);
            this.groupBox1.Controls.Add(this.rbt_No1);
            this.groupBox1.Controls.Add(this.rbt_yes1);
            this.groupBox1.Controls.Add(this.txt_barcode);
            this.groupBox1.Controls.Add(this.lbl_barcode);
            this.groupBox1.Location = new System.Drawing.Point(22, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 121);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barcode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Barcode Type";
            // 
            // cmb_BarcodeType
            // 
            this.cmb_BarcodeType.FormattingEnabled = true;
            this.cmb_BarcodeType.Items.AddRange(new object[] {
            "Laser",
            "Thermal"});
            this.cmb_BarcodeType.Location = new System.Drawing.Point(104, 86);
            this.cmb_BarcodeType.Name = "cmb_BarcodeType";
            this.cmb_BarcodeType.Size = new System.Drawing.Size(121, 21);
            this.cmb_BarcodeType.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmb_estimate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmb_CRT);
            this.groupBox2.Controls.Add(this.lbl_print);
            this.groupBox2.Controls.Add(this.txt_print);
            this.groupBox2.Location = new System.Drawing.Point(22, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 117);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill Print";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "GST Bill";
            // 
            // cmb_CRT
            // 
            this.cmb_CRT.DisplayMember = "FilePath";
            this.cmb_CRT.FormattingEnabled = true;
            this.cmb_CRT.Location = new System.Drawing.Point(104, 52);
            this.cmb_CRT.Name = "cmb_CRT";
            this.cmb_CRT.Size = new System.Drawing.Size(155, 21);
            this.cmb_CRT.TabIndex = 8;
            this.cmb_CRT.ValueMember = "FilePath";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbt_PaymentNo);
            this.groupBox3.Controls.Add(this.dtp_end);
            this.groupBox3.Controls.Add(this.rbt_PaymentYes);
            this.groupBox3.Controls.Add(this.dtp_start);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(319, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 122);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment";
            // 
            // rbt_EstPayNo
            // 
            this.rbt_EstPayNo.AutoSize = true;
            this.rbt_EstPayNo.Location = new System.Drawing.Point(493, 143);
            this.rbt_EstPayNo.Name = "rbt_EstPayNo";
            this.rbt_EstPayNo.Size = new System.Drawing.Size(39, 17);
            this.rbt_EstPayNo.TabIndex = 21;
            this.rbt_EstPayNo.TabStop = true;
            this.rbt_EstPayNo.Text = "No";
            this.rbt_EstPayNo.UseVisualStyleBackColor = true;
            // 
            // rbt_EstPayYes
            // 
            this.rbt_EstPayYes.AutoSize = true;
            this.rbt_EstPayYes.Location = new System.Drawing.Point(442, 143);
            this.rbt_EstPayYes.Name = "rbt_EstPayYes";
            this.rbt_EstPayYes.Size = new System.Drawing.Size(43, 17);
            this.rbt_EstPayYes.TabIndex = 20;
            this.rbt_EstPayYes.TabStop = true;
            this.rbt_EstPayYes.Text = "Yes";
            this.rbt_EstPayYes.UseVisualStyleBackColor = true;
            // 
            // lbl_EstimatePay
            // 
            this.lbl_EstimatePay.AutoSize = true;
            this.lbl_EstimatePay.Location = new System.Drawing.Point(329, 145);
            this.lbl_EstimatePay.Name = "lbl_EstimatePay";
            this.lbl_EstimatePay.Size = new System.Drawing.Size(91, 13);
            this.lbl_EstimatePay.TabIndex = 22;
            this.lbl_EstimatePay.Text = "Estimate Payment";
            // 
            // rbt_PaymentNo
            // 
            this.rbt_PaymentNo.AutoSize = true;
            this.rbt_PaymentNo.Location = new System.Drawing.Point(174, 19);
            this.rbt_PaymentNo.Name = "rbt_PaymentNo";
            this.rbt_PaymentNo.Size = new System.Drawing.Size(39, 17);
            this.rbt_PaymentNo.TabIndex = 15;
            this.rbt_PaymentNo.TabStop = true;
            this.rbt_PaymentNo.Text = "No";
            this.rbt_PaymentNo.UseVisualStyleBackColor = true;
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(104, 90);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(155, 20);
            this.dtp_end.TabIndex = 19;
            // 
            // rbt_PaymentYes
            // 
            this.rbt_PaymentYes.AutoSize = true;
            this.rbt_PaymentYes.Location = new System.Drawing.Point(123, 19);
            this.rbt_PaymentYes.Name = "rbt_PaymentYes";
            this.rbt_PaymentYes.Size = new System.Drawing.Size(43, 17);
            this.rbt_PaymentYes.TabIndex = 14;
            this.rbt_PaymentYes.TabStop = true;
            this.rbt_PaymentYes.Text = "Yes";
            this.rbt_PaymentYes.UseVisualStyleBackColor = true;
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(104, 64);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(155, 20);
            this.dtp_start.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(10, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "End";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(10, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Financial Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Payment Form";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Estimate Bill";
            // 
            // cmb_estimate
            // 
            this.cmb_estimate.DisplayMember = "FilePath";
            this.cmb_estimate.FormattingEnabled = true;
            this.cmb_estimate.Location = new System.Drawing.Point(104, 84);
            this.cmb_estimate.Name = "cmb_estimate";
            this.cmb_estimate.Size = new System.Drawing.Size(155, 21);
            this.cmb_estimate.TabIndex = 10;
            this.cmb_estimate.ValueMember = "FilePath";
            // 
            // frm_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 322);
            this.Controls.Add(this.rbt_EstPayNo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rbt_EstPayYes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_EstimatePay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bttn_save);
            this.Name = "frm_Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.frm_Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_BarcodeType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_CRT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.RadioButton rbt_PaymentNo;
        private System.Windows.Forms.RadioButton rbt_PaymentYes;
        private System.Windows.Forms.RadioButton rbt_EstPayNo;
        private System.Windows.Forms.RadioButton rbt_EstPayYes;
        private System.Windows.Forms.Label lbl_EstimatePay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_estimate;
    }
}