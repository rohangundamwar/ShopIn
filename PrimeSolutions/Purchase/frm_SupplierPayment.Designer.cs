namespace PrimeSolutions.Purchase
{
    partial class frm_SupplierPayment
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
            this.cmb_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_PaymentType = new System.Windows.Forms.ComboBox();
            this.txt_ReceiptNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_name
            // 
            this.cmb_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_name.DisplayMember = "Name";
            this.cmb_name.FormattingEnabled = true;
            this.cmb_name.Location = new System.Drawing.Point(95, 66);
            this.cmb_name.Name = "cmb_name";
            this.cmb_name.Size = new System.Drawing.Size(232, 21);
            this.cmb_name.TabIndex = 0;
            this.cmb_name.ValueMember = "Name";
            this.cmb_name.SelectedIndexChanged += new System.EventHandler(this.cmb_name_SelectedIndexChanged);
            this.cmb_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_name_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supplier Name";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(155, 30);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(13, 13);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "0";
            this.lbl_id.Visible = false;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(12, 109);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(43, 13);
            this.lbl_Amount.TabIndex = 3;
            this.lbl_Amount.Text = "Amount";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(95, 106);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(100, 20);
            this.txt_Amount.TabIndex = 4;
            this.txt_Amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Amount_KeyDown);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(132, 195);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(253, 12);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(89, 20);
            this.dtp_Date.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pay Type";
            // 
            // cmb_PaymentType
            // 
            this.cmb_PaymentType.FormattingEnabled = true;
            this.cmb_PaymentType.Items.AddRange(new object[] {
            "Cash",
            "RTGS",
            "DD",
            "Cheque",
            "Card"});
            this.cmb_PaymentType.Location = new System.Drawing.Point(95, 145);
            this.cmb_PaymentType.Name = "cmb_PaymentType";
            this.cmb_PaymentType.Size = new System.Drawing.Size(73, 21);
            this.cmb_PaymentType.TabIndex = 13;
            // 
            // txt_ReceiptNo
            // 
            this.txt_ReceiptNo.AutoSize = true;
            this.txt_ReceiptNo.Location = new System.Drawing.Point(95, 30);
            this.txt_ReceiptNo.Name = "txt_ReceiptNo";
            this.txt_ReceiptNo.Size = new System.Drawing.Size(13, 13);
            this.txt_ReceiptNo.TabIndex = 12;
            this.txt_ReceiptNo.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Receipt No";
            // 
            // frm_SupplierPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(354, 239);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_PaymentType);
            this.Controls.Add(this.txt_ReceiptNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_name);
            this.Name = "frm_SupplierPayment";
            this.Text = "Supplier Payment";
            this.Load += new System.EventHandler(this.frm_CustomerPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_PaymentType;
        private System.Windows.Forms.Label txt_ReceiptNo;
        private System.Windows.Forms.Label label2;
    }
}