namespace PrimeSolutions.Common
{
    partial class frm_Openning
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
            this.lbl_State = new System.Windows.Forms.Label();
            this.cmb_State = new System.Windows.Forms.ComboBox();
            this.txt_GSTIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PanNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ContactNo = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.lbl_City = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.cmb_Name = new System.Windows.Forms.ComboBox();
            this.lbl_CustomerName = new System.Windows.Forms.Label();
            this.lbl_ContactNo = new System.Windows.Forms.Label();
            this.lbl_Add = new System.Windows.Forms.Label();
            this.txt_Opening = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttn_Save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Bttn_Reset = new System.Windows.Forms.Button();
            this.txt_AccNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Aadhar = new System.Windows.Forms.TextBox();
            this.lbl_Aadhar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_State.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_State.Location = new System.Drawing.Point(348, 27);
            this.lbl_State.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(40, 15);
            this.lbl_State.TabIndex = 9;
            this.lbl_State.Text = "State";
            // 
            // cmb_State
            // 
            this.cmb_State.DisplayMember = "26";
            this.cmb_State.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.cmb_State.FormattingEnabled = true;
            this.cmb_State.ItemHeight = 16;
            this.cmb_State.Items.AddRange(new object[] {
            "01-Jammu&kashmir",
            "02- Himachal Pradesh",
            "03-Punjab",
            "04-Chandigarh",
            "05-Uttaranchal",
            "06-Harayana",
            "07-Delhi",
            "08-Rajasthan",
            "09-Uttar Pradesh",
            "10-Bihar",
            "11-Sikkim",
            "12-Arunachal Pradesh",
            "13-Nagaland",
            "14-Manipur",
            "15-Mizoram",
            "16-Tripura",
            "17-Meghalaya",
            "18-Assam",
            "19-West Bengal",
            "20-Jharkhand",
            "21-Orrisa",
            "22-Chattisgarh",
            "23-Madhya Pradesh",
            "24-Gujrat",
            "25-Daman&Diu",
            "26-Dadra & Nagar Haveli",
            "27-Maharashtra",
            "28-Andra Pradesh",
            "29-Karnataka",
            "30-Goa",
            "31-Lakshwadeep",
            "32-Kerla",
            "33-Tamil Nadu",
            "34-Pondicherry",
            "35-Andaman&Nicobar Islands",
            "32-"});
            this.cmb_State.Location = new System.Drawing.Point(398, 22);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(145, 24);
            this.cmb_State.TabIndex = 17;
            this.cmb_State.ValueMember = "26";
            this.cmb_State.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_State_KeyDown);
            // 
            // txt_GSTIN
            // 
            this.txt_GSTIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_GSTIN.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_GSTIN.Location = new System.Drawing.Point(64, 106);
            this.txt_GSTIN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_GSTIN.Name = "txt_GSTIN";
            this.txt_GSTIN.Size = new System.Drawing.Size(144, 23);
            this.txt_GSTIN.TabIndex = 22;
            this.txt_GSTIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_GSTIN_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "GSTIN";
            // 
            // txt_PanNo
            // 
            this.txt_PanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_PanNo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_PanNo.Location = new System.Drawing.Point(593, 66);
            this.txt_PanNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_PanNo.Name = "txt_PanNo";
            this.txt_PanNo.Size = new System.Drawing.Size(213, 23);
            this.txt_PanNo.TabIndex = 21;
            this.txt_PanNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PanNo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(512, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pan No";
            // 
            // txt_ContactNo
            // 
            this.txt_ContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_ContactNo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_ContactNo.Location = new System.Drawing.Point(326, 66);
            this.txt_ContactNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ContactNo.Name = "txt_ContactNo";
            this.txt_ContactNo.Size = new System.Drawing.Size(159, 23);
            this.txt_ContactNo.TabIndex = 20;
            this.txt_ContactNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ContactNo_KeyDown);
            // 
            // txt_City
            // 
            this.txt_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_City.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_City.Location = new System.Drawing.Point(70, 66);
            this.txt_City.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(121, 23);
            this.txt_City.TabIndex = 19;
            this.txt_City.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_City_KeyDown);
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_City.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_City.Location = new System.Drawing.Point(13, 70);
            this.lbl_City.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(30, 15);
            this.lbl_City.TabIndex = 12;
            this.lbl_City.Text = "City";
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_Address.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Address.Location = new System.Drawing.Point(621, 23);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(186, 23);
            this.txt_Address.TabIndex = 18;
            this.txt_Address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Address_KeyDown);
            // 
            // cmb_Name
            // 
            this.cmb_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Name.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_Name.DisplayMember = "CustomerName";
            this.cmb_Name.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmb_Name.FormattingEnabled = true;
            this.cmb_Name.Location = new System.Drawing.Point(133, 24);
            this.cmb_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_Name.Name = "cmb_Name";
            this.cmb_Name.Size = new System.Drawing.Size(205, 21);
            this.cmb_Name.TabIndex = 16;
            this.cmb_Name.ValueMember = "CustomerName";
            this.cmb_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Name_KeyDown);
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AutoSize = true;
            this.lbl_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_CustomerName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_CustomerName.Location = new System.Drawing.Point(13, 27);
            this.lbl_CustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(110, 15);
            this.lbl_CustomerName.TabIndex = 13;
            this.lbl_CustomerName.Text = "Customer Name";
            // 
            // lbl_ContactNo
            // 
            this.lbl_ContactNo.AutoSize = true;
            this.lbl_ContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_ContactNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_ContactNo.Location = new System.Drawing.Point(218, 70);
            this.lbl_ContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ContactNo.Name = "lbl_ContactNo";
            this.lbl_ContactNo.Size = new System.Drawing.Size(81, 15);
            this.lbl_ContactNo.TabIndex = 14;
            this.lbl_ContactNo.Text = "Contact No.";
            // 
            // lbl_Add
            // 
            this.lbl_Add.AutoSize = true;
            this.lbl_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Add.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Add.Location = new System.Drawing.Point(553, 27);
            this.lbl_Add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Add.Name = "lbl_Add";
            this.lbl_Add.Size = new System.Drawing.Size(58, 15);
            this.lbl_Add.TabIndex = 15;
            this.lbl_Add.Text = "Address";
            // 
            // txt_Opening
            // 
            this.txt_Opening.ForeColor = System.Drawing.Color.Red;
            this.txt_Opening.Location = new System.Drawing.Point(505, 107);
            this.txt_Opening.Name = "txt_Opening";
            this.txt_Opening.Size = new System.Drawing.Size(137, 20);
            this.txt_Opening.TabIndex = 23;
            this.txt_Opening.Text = "0";
            this.txt_Opening.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Opening_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(413, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Old Balance ";
            // 
            // bttn_Save
            // 
            this.bttn_Save.ForeColor = System.Drawing.Color.Green;
            this.bttn_Save.Location = new System.Drawing.Point(180, 151);
            this.bttn_Save.Name = "bttn_Save";
            this.bttn_Save.Size = new System.Drawing.Size(75, 23);
            this.bttn_Save.TabIndex = 26;
            this.bttn_Save.Text = "Save";
            this.bttn_Save.UseVisualStyleBackColor = true;
            this.bttn_Save.Click += new System.EventHandler(this.bttn_Save_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(562, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bttn_Reset
            // 
            this.Bttn_Reset.ForeColor = System.Drawing.Color.Blue;
            this.Bttn_Reset.Location = new System.Drawing.Point(371, 151);
            this.Bttn_Reset.Name = "Bttn_Reset";
            this.Bttn_Reset.Size = new System.Drawing.Size(75, 23);
            this.Bttn_Reset.TabIndex = 28;
            this.Bttn_Reset.Text = "Reset";
            this.Bttn_Reset.UseVisualStyleBackColor = true;
            this.Bttn_Reset.Click += new System.EventHandler(this.Bttn_Reset_Click);
            // 
            // txt_AccNo
            // 
            this.txt_AccNo.AutoSize = true;
            this.txt_AccNo.Location = new System.Drawing.Point(726, 109);
            this.txt_AccNo.Name = "txt_AccNo";
            this.txt_AccNo.Size = new System.Drawing.Size(0, 13);
            this.txt_AccNo.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(649, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Acc No :";
            // 
            // txt_Aadhar
            // 
            this.txt_Aadhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_Aadhar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Aadhar.Location = new System.Drawing.Point(266, 106);
            this.txt_Aadhar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Aadhar.Name = "txt_Aadhar";
            this.txt_Aadhar.Size = new System.Drawing.Size(144, 23);
            this.txt_Aadhar.TabIndex = 32;
            // 
            // lbl_Aadhar
            // 
            this.lbl_Aadhar.AutoSize = true;
            this.lbl_Aadhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Aadhar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Aadhar.Location = new System.Drawing.Point(211, 110);
            this.lbl_Aadhar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Aadhar.Name = "lbl_Aadhar";
            this.lbl_Aadhar.Size = new System.Drawing.Size(52, 15);
            this.lbl_Aadhar.TabIndex = 31;
            this.lbl_Aadhar.Text = "Aadhar";
            // 
            // frm_Openning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(830, 191);
            this.Controls.Add(this.txt_Aadhar);
            this.Controls.Add(this.lbl_Aadhar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_AccNo);
            this.Controls.Add(this.Bttn_Reset);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bttn_Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Opening);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.cmb_State);
            this.Controls.Add(this.txt_GSTIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PanNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ContactNo);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.cmb_Name);
            this.Controls.Add(this.lbl_CustomerName);
            this.Controls.Add(this.lbl_ContactNo);
            this.Controls.Add(this.lbl_Add);
            this.Name = "frm_Openning";
            this.Text = "Customer Opening";
            this.Load += new System.EventHandler(this.frm_Openning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.TextBox txt_GSTIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PanNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ContactNo;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.ComboBox cmb_Name;
        private System.Windows.Forms.Label lbl_CustomerName;
        private System.Windows.Forms.Label lbl_ContactNo;
        private System.Windows.Forms.Label lbl_Add;
        private System.Windows.Forms.TextBox txt_Opening;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttn_Save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Bttn_Reset;
        private System.Windows.Forms.Label txt_AccNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Aadhar;
        private System.Windows.Forms.Label lbl_Aadhar;
    }
}