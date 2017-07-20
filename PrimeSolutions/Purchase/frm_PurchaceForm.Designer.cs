namespace PrimeSolutions
{
    partial class frm_PurchaseForm
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
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.txt_AccNo = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Purchase = new System.Windows.Forms.Label();
            this.lbl_AccNo = new System.Windows.Forms.Label();
            this.lbl_PurchaseFrom = new System.Windows.Forms.Label();
            this.lbl_Add = new System.Windows.Forms.Label();
            this.lbl_ContactNo = new System.Windows.Forms.Label();
            this.lbl_BillNo = new System.Windows.Forms.Label();
            this.pnl_SupplierInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.txt_MobileNo = new System.Windows.Forms.TextBox();
            this.txt_BillNo = new System.Windows.Forms.TextBox();
            this.txt_ContactNo = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.lbl_City = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.cmb_Name = new System.Windows.Forms.ComboBox();
            this.pnl_ItemInfo = new System.Windows.Forms.Panel();
            this.txt_Size = new System.Windows.Forms.TextBox();
            this.lbl_size = new System.Windows.Forms.Label();
            this.pnl_Button = new System.Windows.Forms.Panel();
            this.bttn_Delete = new System.Windows.Forms.Button();
            this.bttn_Reset = new System.Windows.Forms.Button();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.txt_Amt = new System.Windows.Forms.TextBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.txt_SellingAmt = new System.Windows.Forms.TextBox();
            this.lbl_SellingAmt = new System.Windows.Forms.Label();
            this.txt_PurchaseAmt = new System.Windows.Forms.TextBox();
            this.cmb_SubCategory = new System.Windows.Forms.ComboBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_PurchaseAmt = new System.Windows.Forms.Label();
            this.lbl_SubCategory = new System.Windows.Forms.Label();
            this.dgv_ItemInfo = new System.Windows.Forms.DataGridView();
            this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_PaymentOpt = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_VatValue = new System.Windows.Forms.TextBox();
            this.chbk_barcode = new System.Windows.Forms.CheckBox();
            this.txt_BalAmt = new System.Windows.Forms.TextBox();
            this.lbl_BalanceAmt = new System.Windows.Forms.Label();
            this.txt_PaidAmt = new System.Windows.Forms.TextBox();
            this.lbl_PaidAmt = new System.Windows.Forms.Label();
            this.txt_NetAmt = new System.Windows.Forms.TextBox();
            this.lbl_NetAmount = new System.Windows.Forms.Label();
            this.txt_Vat = new System.Windows.Forms.TextBox();
            this.lbl_Vat = new System.Windows.Forms.Label();
            this.txt_TotalAmt = new System.Windows.Forms.TextBox();
            this.lbl_TotalAmt = new System.Windows.Forms.Label();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Clear = new System.Windows.Forms.Button();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.bttn_Purchase = new System.Windows.Forms.Button();
            this.pnl_Picture = new System.Windows.Forms.Panel();
            this.pnl_Main.SuspendLayout();
            this.pnl_Top.SuspendLayout();
            this.pnl_SupplierInfo.SuspendLayout();
            this.pnl_ItemInfo.SuspendLayout();
            this.pnl_Button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemInfo)).BeginInit();
            this.pnl_PaymentOpt.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.pnl_Top);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(992, 47);
            this.pnl_Main.TabIndex = 0;
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Top.Controls.Add(this.txt_AccNo);
            this.pnl_Top.Controls.Add(this.dtp_Date);
            this.pnl_Top.Controls.Add(this.lbl_Date);
            this.pnl_Top.Controls.Add(this.lbl_Purchase);
            this.pnl_Top.Controls.Add(this.lbl_AccNo);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(992, 46);
            this.pnl_Top.TabIndex = 0;
            // 
            // txt_AccNo
            // 
            this.txt_AccNo.AutoSize = true;
            this.txt_AccNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_AccNo.Location = new System.Drawing.Point(83, 12);
            this.txt_AccNo.Name = "txt_AccNo";
            this.txt_AccNo.Size = new System.Drawing.Size(54, 19);
            this.txt_AccNo.TabIndex = 9;
            this.txt_AccNo.Text = "label1";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(873, 10);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(104, 22);
            this.dtp_Date.TabIndex = 8;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Date.Location = new System.Drawing.Point(819, 12);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(44, 19);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Purchase
            // 
            this.lbl_Purchase.AutoSize = true;
            this.lbl_Purchase.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Purchase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Purchase.Location = new System.Drawing.Point(449, 10);
            this.lbl_Purchase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Purchase.Name = "lbl_Purchase";
            this.lbl_Purchase.Size = new System.Drawing.Size(94, 23);
            this.lbl_Purchase.TabIndex = 1;
            this.lbl_Purchase.Text = "Purchase";
            // 
            // lbl_AccNo
            // 
            this.lbl_AccNo.AutoSize = true;
            this.lbl_AccNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AccNo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_AccNo.Location = new System.Drawing.Point(8, 13);
            this.lbl_AccNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AccNo.Name = "lbl_AccNo";
            this.lbl_AccNo.Size = new System.Drawing.Size(54, 16);
            this.lbl_AccNo.TabIndex = 2;
            this.lbl_AccNo.Text = "AccNo";
            // 
            // lbl_PurchaseFrom
            // 
            this.lbl_PurchaseFrom.AutoSize = true;
            this.lbl_PurchaseFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PurchaseFrom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_PurchaseFrom.Location = new System.Drawing.Point(6, 10);
            this.lbl_PurchaseFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PurchaseFrom.Name = "lbl_PurchaseFrom";
            this.lbl_PurchaseFrom.Size = new System.Drawing.Size(112, 16);
            this.lbl_PurchaseFrom.TabIndex = 3;
            this.lbl_PurchaseFrom.Text = "Purchase From";
            // 
            // lbl_Add
            // 
            this.lbl_Add.AutoSize = true;
            this.lbl_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Add.Location = new System.Drawing.Point(6, 43);
            this.lbl_Add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Add.Name = "lbl_Add";
            this.lbl_Add.Size = new System.Drawing.Size(66, 16);
            this.lbl_Add.TabIndex = 4;
            this.lbl_Add.Text = "Address";
            // 
            // lbl_ContactNo
            // 
            this.lbl_ContactNo.AutoSize = true;
            this.lbl_ContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContactNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_ContactNo.Location = new System.Drawing.Point(6, 72);
            this.lbl_ContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ContactNo.Name = "lbl_ContactNo";
            this.lbl_ContactNo.Size = new System.Drawing.Size(88, 16);
            this.lbl_ContactNo.TabIndex = 5;
            this.lbl_ContactNo.Text = "Contact No.";
            // 
            // lbl_BillNo
            // 
            this.lbl_BillNo.AutoSize = true;
            this.lbl_BillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BillNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_BillNo.Location = new System.Drawing.Point(6, 101);
            this.lbl_BillNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BillNo.Name = "lbl_BillNo";
            this.lbl_BillNo.Size = new System.Drawing.Size(127, 16);
            this.lbl_BillNo.TabIndex = 6;
            this.lbl_BillNo.Text = "Purchase Bill No.";
            // 
            // pnl_SupplierInfo
            // 
            this.pnl_SupplierInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_SupplierInfo.Controls.Add(this.label1);
            this.pnl_SupplierInfo.Controls.Add(this.lbl_Balance);
            this.pnl_SupplierInfo.Controls.Add(this.txt_MobileNo);
            this.pnl_SupplierInfo.Controls.Add(this.txt_BillNo);
            this.pnl_SupplierInfo.Controls.Add(this.txt_ContactNo);
            this.pnl_SupplierInfo.Controls.Add(this.txt_City);
            this.pnl_SupplierInfo.Controls.Add(this.lbl_City);
            this.pnl_SupplierInfo.Controls.Add(this.txt_Address);
            this.pnl_SupplierInfo.Controls.Add(this.cmb_Name);
            this.pnl_SupplierInfo.Controls.Add(this.lbl_BillNo);
            this.pnl_SupplierInfo.Controls.Add(this.lbl_PurchaseFrom);
            this.pnl_SupplierInfo.Controls.Add(this.lbl_ContactNo);
            this.pnl_SupplierInfo.Controls.Add(this.lbl_Add);
            this.pnl_SupplierInfo.Location = new System.Drawing.Point(4, 51);
            this.pnl_SupplierInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_SupplierInfo.Name = "pnl_SupplierInfo";
            this.pnl_SupplierInfo.Size = new System.Drawing.Size(517, 136);
            this.pnl_SupplierInfo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(339, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "---";
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balance.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_Balance.Location = new System.Drawing.Point(334, 100);
            this.lbl_Balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(74, 20);
            this.lbl_Balance.TabIndex = 15;
            this.lbl_Balance.Text = "Balance";
            this.lbl_Balance.Visible = false;
            // 
            // txt_MobileNo
            // 
            this.txt_MobileNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MobileNo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_MobileNo.Location = new System.Drawing.Point(370, 71);
            this.txt_MobileNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_MobileNo.Name = "txt_MobileNo";
            this.txt_MobileNo.Size = new System.Drawing.Size(132, 19);
            this.txt_MobileNo.TabIndex = 14;
            this.txt_MobileNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MobileNo_KeyDown);
            this.txt_MobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MobileNo_KeyPress);
            // 
            // txt_BillNo
            // 
            this.txt_BillNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_BillNo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_BillNo.Location = new System.Drawing.Point(168, 100);
            this.txt_BillNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_BillNo.Name = "txt_BillNo";
            this.txt_BillNo.Size = new System.Drawing.Size(164, 19);
            this.txt_BillNo.TabIndex = 13;
            this.txt_BillNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_BillNo_KeyDown);
            this.txt_BillNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BillNo_KeyPress);
            // 
            // txt_ContactNo
            // 
            this.txt_ContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ContactNo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_ContactNo.Location = new System.Drawing.Point(168, 71);
            this.txt_ContactNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ContactNo.Name = "txt_ContactNo";
            this.txt_ContactNo.Size = new System.Drawing.Size(164, 19);
            this.txt_ContactNo.TabIndex = 12;
            this.txt_ContactNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ContactNo_KeyDown);
            this.txt_ContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ContactNo_KeyPress);
            // 
            // txt_City
            // 
            this.txt_City.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_City.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_City.Location = new System.Drawing.Point(370, 42);
            this.txt_City.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(132, 19);
            this.txt_City.TabIndex = 11;
            this.txt_City.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_City_KeyDown);
            this.txt_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_City_KeyPress);
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_City.Location = new System.Drawing.Point(334, 43);
            this.lbl_City.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(34, 16);
            this.lbl_City.TabIndex = 10;
            this.lbl_City.Text = "City";
            // 
            // txt_Address
            // 
            this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Address.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Address.Location = new System.Drawing.Point(168, 42);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(164, 19);
            this.txt_Address.TabIndex = 9;
            this.txt_Address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Address_KeyDown);
            this.txt_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Address_KeyPress);
            // 
            // cmb_Name
            // 
            this.cmb_Name.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_Name.DisplayMember = "name";
            this.cmb_Name.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmb_Name.FormattingEnabled = true;
            this.cmb_Name.Location = new System.Drawing.Point(168, 5);
            this.cmb_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_Name.Name = "cmb_Name";
            this.cmb_Name.Size = new System.Drawing.Size(332, 27);
            this.cmb_Name.TabIndex = 8;
            this.cmb_Name.ValueMember = "name";
            this.cmb_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Name_KeyDown);
            this.cmb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Name_KeyPress);
            // 
            // pnl_ItemInfo
            // 
            this.pnl_ItemInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_ItemInfo.Controls.Add(this.txt_Size);
            this.pnl_ItemInfo.Controls.Add(this.lbl_size);
            this.pnl_ItemInfo.Controls.Add(this.pnl_Button);
            this.pnl_ItemInfo.Controls.Add(this.txt_Amt);
            this.pnl_ItemInfo.Controls.Add(this.lbl_Amount);
            this.pnl_ItemInfo.Controls.Add(this.txt_Qty);
            this.pnl_ItemInfo.Controls.Add(this.lbl_Quantity);
            this.pnl_ItemInfo.Controls.Add(this.txt_SellingAmt);
            this.pnl_ItemInfo.Controls.Add(this.lbl_SellingAmt);
            this.pnl_ItemInfo.Controls.Add(this.txt_PurchaseAmt);
            this.pnl_ItemInfo.Controls.Add(this.cmb_SubCategory);
            this.pnl_ItemInfo.Controls.Add(this.cmb_Category);
            this.pnl_ItemInfo.Controls.Add(this.lbl_Category);
            this.pnl_ItemInfo.Controls.Add(this.lbl_PurchaseAmt);
            this.pnl_ItemInfo.Controls.Add(this.lbl_SubCategory);
            this.pnl_ItemInfo.Location = new System.Drawing.Point(4, 193);
            this.pnl_ItemInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_ItemInfo.Name = "pnl_ItemInfo";
            this.pnl_ItemInfo.Size = new System.Drawing.Size(517, 142);
            this.pnl_ItemInfo.TabIndex = 8;
            this.pnl_ItemInfo.Tag = "Item";
            // 
            // txt_Size
            // 
            this.txt_Size.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Size.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Size.Location = new System.Drawing.Point(475, 23);
            this.txt_Size.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Size.Name = "txt_Size";
            this.txt_Size.Size = new System.Drawing.Size(37, 19);
            this.txt_Size.TabIndex = 23;
            this.txt_Size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Size_KeyDown);
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_size.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_size.Location = new System.Drawing.Point(478, 5);
            this.lbl_size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(31, 13);
            this.lbl_size.TabIndex = 22;
            this.lbl_size.Text = "Size";
            // 
            // pnl_Button
            // 
            this.pnl_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Button.Controls.Add(this.bttn_Delete);
            this.pnl_Button.Controls.Add(this.bttn_Reset);
            this.pnl_Button.Controls.Add(this.bttn_Update);
            this.pnl_Button.Controls.Add(this.bttn_Add);
            this.pnl_Button.Location = new System.Drawing.Point(0, 103);
            this.pnl_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(517, 38);
            this.pnl_Button.TabIndex = 21;
            // 
            // bttn_Delete
            // 
            this.bttn_Delete.ForeColor = System.Drawing.Color.Red;
            this.bttn_Delete.Location = new System.Drawing.Point(412, 5);
            this.bttn_Delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttn_Delete.Name = "bttn_Delete";
            this.bttn_Delete.Size = new System.Drawing.Size(76, 28);
            this.bttn_Delete.TabIndex = 16;
            this.bttn_Delete.Text = "Delete";
            this.bttn_Delete.UseVisualStyleBackColor = true;
            this.bttn_Delete.Click += new System.EventHandler(this.bttn_Delete_Click);
            // 
            // bttn_Reset
            // 
            this.bttn_Reset.ForeColor = System.Drawing.Color.Blue;
            this.bttn_Reset.Location = new System.Drawing.Point(285, 5);
            this.bttn_Reset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttn_Reset.Name = "bttn_Reset";
            this.bttn_Reset.Size = new System.Drawing.Size(76, 28);
            this.bttn_Reset.TabIndex = 15;
            this.bttn_Reset.Text = "Reset";
            this.bttn_Reset.UseVisualStyleBackColor = true;
            // 
            // bttn_Update
            // 
            this.bttn_Update.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bttn_Update.Location = new System.Drawing.Point(158, 5);
            this.bttn_Update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttn_Update.Name = "bttn_Update";
            this.bttn_Update.Size = new System.Drawing.Size(76, 28);
            this.bttn_Update.TabIndex = 14;
            this.bttn_Update.Text = "Update";
            this.bttn_Update.UseVisualStyleBackColor = true;
            this.bttn_Update.Click += new System.EventHandler(this.bttn_Update_Click);
            // 
            // bttn_Add
            // 
            this.bttn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttn_Add.Location = new System.Drawing.Point(31, 5);
            this.bttn_Add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(76, 28);
            this.bttn_Add.TabIndex = 13;
            this.bttn_Add.Text = "Add";
            this.bttn_Add.UseVisualStyleBackColor = true;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // txt_Amt
            // 
            this.txt_Amt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Amt.Enabled = false;
            this.txt_Amt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Amt.Location = new System.Drawing.Point(356, 80);
            this.txt_Amt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Amt.Name = "txt_Amt";
            this.txt_Amt.Size = new System.Drawing.Size(144, 19);
            this.txt_Amt.TabIndex = 20;
            this.txt_Amt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Amt_KeyDown);
            this.txt_Amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Amt_KeyPress);
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Amount.Location = new System.Drawing.Point(257, 81);
            this.lbl_Amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(59, 16);
            this.lbl_Amount.TabIndex = 19;
            this.lbl_Amount.Text = "Amount";
            // 
            // txt_Qty
            // 
            this.txt_Qty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Qty.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Qty.Location = new System.Drawing.Point(115, 78);
            this.txt_Qty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(73, 19);
            this.txt_Qty.TabIndex = 18;
            this.txt_Qty.TextChanged += new System.EventHandler(this.txt_Qty_TextChanged);
            this.txt_Qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Qty_KeyDown);
            this.txt_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qty_KeyPress);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Quantity.Location = new System.Drawing.Point(8, 81);
            this.lbl_Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(64, 16);
            this.lbl_Quantity.TabIndex = 17;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // txt_SellingAmt
            // 
            this.txt_SellingAmt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SellingAmt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_SellingAmt.Location = new System.Drawing.Point(356, 50);
            this.txt_SellingAmt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_SellingAmt.Name = "txt_SellingAmt";
            this.txt_SellingAmt.Size = new System.Drawing.Size(144, 19);
            this.txt_SellingAmt.TabIndex = 16;
            this.txt_SellingAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SellingAmt_KeyDown);
            this.txt_SellingAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SellingAmt_KeyPress);
            // 
            // lbl_SellingAmt
            // 
            this.lbl_SellingAmt.AutoSize = true;
            this.lbl_SellingAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SellingAmt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_SellingAmt.Location = new System.Drawing.Point(257, 51);
            this.lbl_SellingAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SellingAmt.Name = "lbl_SellingAmt";
            this.lbl_SellingAmt.Size = new System.Drawing.Size(86, 16);
            this.lbl_SellingAmt.TabIndex = 15;
            this.lbl_SellingAmt.Text = "Selling Amt";
            // 
            // txt_PurchaseAmt
            // 
            this.txt_PurchaseAmt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PurchaseAmt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_PurchaseAmt.Location = new System.Drawing.Point(115, 50);
            this.txt_PurchaseAmt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_PurchaseAmt.Name = "txt_PurchaseAmt";
            this.txt_PurchaseAmt.Size = new System.Drawing.Size(137, 19);
            this.txt_PurchaseAmt.TabIndex = 14;
            this.txt_PurchaseAmt.TextChanged += new System.EventHandler(this.txt_PurchaseAmt_TextChanged);
            this.txt_PurchaseAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PurchaseAmt_KeyDown);
            this.txt_PurchaseAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PurchaseAmt_KeyPress);
            // 
            // cmb_SubCategory
            // 
            this.cmb_SubCategory.DisplayMember = "SubCategory";
            this.cmb_SubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SubCategory.FormattingEnabled = true;
            this.cmb_SubCategory.Location = new System.Drawing.Point(324, 15);
            this.cmb_SubCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_SubCategory.Name = "cmb_SubCategory";
            this.cmb_SubCategory.Size = new System.Drawing.Size(144, 27);
            this.cmb_SubCategory.TabIndex = 7;
            this.cmb_SubCategory.ValueMember = "SubCategory";
            this.cmb_SubCategory.Enter += new System.EventHandler(this.cmb_SubCategory_Enter);
            this.cmb_SubCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_SubCategory_KeyDown);
            this.cmb_SubCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_SubCategory_KeyPress);
            this.cmb_SubCategory.Leave += new System.EventHandler(this.cmb_SubCategory_Leave);
            // 
            // cmb_Category
            // 
            this.cmb_Category.AllowDrop = true;
            this.cmb_Category.BackColor = System.Drawing.Color.White;
            this.cmb_Category.DisplayMember = "Category";
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(83, 15);
            this.cmb_Category.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(137, 27);
            this.cmb_Category.TabIndex = 6;
            this.cmb_Category.ValueMember = "Category";
            this.cmb_Category.Enter += new System.EventHandler(this.cmb_Category_Enter);
            this.cmb_Category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Category_KeyDown);
            this.cmb_Category.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Category_KeyPress);
            this.cmb_Category.Leave += new System.EventHandler(this.cmb_Category_Leave);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Category.Location = new System.Drawing.Point(8, 21);
            this.lbl_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(71, 16);
            this.lbl_Category.TabIndex = 3;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_PurchaseAmt
            // 
            this.lbl_PurchaseAmt.AutoSize = true;
            this.lbl_PurchaseAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PurchaseAmt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_PurchaseAmt.Location = new System.Drawing.Point(8, 51);
            this.lbl_PurchaseAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PurchaseAmt.Name = "lbl_PurchaseAmt";
            this.lbl_PurchaseAmt.Size = new System.Drawing.Size(103, 16);
            this.lbl_PurchaseAmt.TabIndex = 5;
            this.lbl_PurchaseAmt.Text = "Purchase Amt";
            // 
            // lbl_SubCategory
            // 
            this.lbl_SubCategory.AutoSize = true;
            this.lbl_SubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubCategory.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_SubCategory.Location = new System.Drawing.Point(228, 20);
            this.lbl_SubCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SubCategory.Name = "lbl_SubCategory";
            this.lbl_SubCategory.Size = new System.Drawing.Size(98, 16);
            this.lbl_SubCategory.TabIndex = 4;
            this.lbl_SubCategory.Text = "SubCategory";
            // 
            // dgv_ItemInfo
            // 
            this.dgv_ItemInfo.AllowUserToAddRows = false;
            this.dgv_ItemInfo.AllowUserToDeleteRows = false;
            this.dgv_ItemInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ItemInfo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_ItemInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chk,
            this.Category,
            this.SubCategory,
            this.size,
            this.PurchaseAmt,
            this.Qty,
            this.SellingAmt,
            this.TotalAmt,
            this.PBill});
            this.dgv_ItemInfo.Location = new System.Drawing.Point(4, 341);
            this.dgv_ItemInfo.Name = "dgv_ItemInfo";
            this.dgv_ItemInfo.RowHeadersWidth = 30;
            this.dgv_ItemInfo.Size = new System.Drawing.Size(652, 201);
            this.dgv_ItemInfo.TabIndex = 9;
            this.dgv_ItemInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ItemInfo_CellClick);
            // 
            // Chk
            // 
            this.Chk.FillWeight = 50F;
            this.Chk.HeaderText = "Chk";
            this.Chk.Name = "Chk";
            this.Chk.ReadOnly = true;
            this.Chk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Category
            // 
            this.Category.FillWeight = 96.11028F;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // SubCategory
            // 
            this.SubCategory.FillWeight = 96.11028F;
            this.SubCategory.HeaderText = "SubCategory";
            this.SubCategory.Name = "SubCategory";
            this.SubCategory.ReadOnly = true;
            // 
            // size
            // 
            this.size.FillWeight = 49.79155F;
            this.size.HeaderText = "size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // PurchaseAmt
            // 
            this.PurchaseAmt.FillWeight = 96.11028F;
            this.PurchaseAmt.HeaderText = "PurchaseAmt";
            this.PurchaseAmt.Name = "PurchaseAmt";
            this.PurchaseAmt.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.FillWeight = 39.6059F;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // SellingAmt
            // 
            this.SellingAmt.FillWeight = 96.11028F;
            this.SellingAmt.HeaderText = "SellingAmt";
            this.SellingAmt.Name = "SellingAmt";
            this.SellingAmt.ReadOnly = true;
            // 
            // TotalAmt
            // 
            this.TotalAmt.FillWeight = 96.11028F;
            this.TotalAmt.HeaderText = "TotalAmt";
            this.TotalAmt.Name = "TotalAmt";
            this.TotalAmt.ReadOnly = true;
            // 
            // PBill
            // 
            this.PBill.HeaderText = "PBill";
            this.PBill.Name = "PBill";
            this.PBill.ReadOnly = true;
            this.PBill.Visible = false;
            // 
            // pnl_PaymentOpt
            // 
            this.pnl_PaymentOpt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_PaymentOpt.Controls.Add(this.label2);
            this.pnl_PaymentOpt.Controls.Add(this.txt_VatValue);
            this.pnl_PaymentOpt.Controls.Add(this.chbk_barcode);
            this.pnl_PaymentOpt.Controls.Add(this.txt_BalAmt);
            this.pnl_PaymentOpt.Controls.Add(this.lbl_BalanceAmt);
            this.pnl_PaymentOpt.Controls.Add(this.txt_PaidAmt);
            this.pnl_PaymentOpt.Controls.Add(this.lbl_PaidAmt);
            this.pnl_PaymentOpt.Controls.Add(this.txt_NetAmt);
            this.pnl_PaymentOpt.Controls.Add(this.lbl_NetAmount);
            this.pnl_PaymentOpt.Controls.Add(this.txt_Vat);
            this.pnl_PaymentOpt.Controls.Add(this.lbl_Vat);
            this.pnl_PaymentOpt.Controls.Add(this.txt_TotalAmt);
            this.pnl_PaymentOpt.Controls.Add(this.lbl_TotalAmt);
            this.pnl_PaymentOpt.Location = new System.Drawing.Point(661, 341);
            this.pnl_PaymentOpt.Name = "pnl_PaymentOpt";
            this.pnl_PaymentOpt.Size = new System.Drawing.Size(328, 201);
            this.pnl_PaymentOpt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(91, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 229;
            this.label2.Text = "%";
            // 
            // txt_VatValue
            // 
            this.txt_VatValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_VatValue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_VatValue.Location = new System.Drawing.Point(51, 45);
            this.txt_VatValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_VatValue.Name = "txt_VatValue";
            this.txt_VatValue.Size = new System.Drawing.Size(35, 19);
            this.txt_VatValue.TabIndex = 228;
            this.txt_VatValue.TextChanged += new System.EventHandler(this.txt_VatValue_TextChanged);
            this.txt_VatValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_VatValue_KeyDown);
            // 
            // chbk_barcode
            // 
            this.chbk_barcode.AutoSize = true;
            this.chbk_barcode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbk_barcode.ForeColor = System.Drawing.Color.Navy;
            this.chbk_barcode.Location = new System.Drawing.Point(15, 174);
            this.chbk_barcode.Name = "chbk_barcode";
            this.chbk_barcode.Size = new System.Drawing.Size(80, 20);
            this.chbk_barcode.TabIndex = 227;
            this.chbk_barcode.Text = "Barcode";
            this.chbk_barcode.UseVisualStyleBackColor = true;
            // 
            // txt_BalAmt
            // 
            this.txt_BalAmt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_BalAmt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_BalAmt.Location = new System.Drawing.Point(167, 148);
            this.txt_BalAmt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_BalAmt.Name = "txt_BalAmt";
            this.txt_BalAmt.Size = new System.Drawing.Size(144, 19);
            this.txt_BalAmt.TabIndex = 30;
            this.txt_BalAmt.TextChanged += new System.EventHandler(this.txt_BalAmt_TextChanged);
            this.txt_BalAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_BalAmt_KeyDown);
            this.txt_BalAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BalAmt_KeyPress);
            // 
            // lbl_BalanceAmt
            // 
            this.lbl_BalanceAmt.AutoSize = true;
            this.lbl_BalanceAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BalanceAmt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_BalanceAmt.Location = new System.Drawing.Point(12, 149);
            this.lbl_BalanceAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BalanceAmt.Name = "lbl_BalanceAmt";
            this.lbl_BalanceAmt.Size = new System.Drawing.Size(95, 16);
            this.lbl_BalanceAmt.TabIndex = 29;
            this.lbl_BalanceAmt.Text = "Balance Amt";
            // 
            // txt_PaidAmt
            // 
            this.txt_PaidAmt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PaidAmt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_PaidAmt.Location = new System.Drawing.Point(167, 114);
            this.txt_PaidAmt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_PaidAmt.Name = "txt_PaidAmt";
            this.txt_PaidAmt.Size = new System.Drawing.Size(144, 19);
            this.txt_PaidAmt.TabIndex = 28;
            this.txt_PaidAmt.TextChanged += new System.EventHandler(this.txt_PaidAmt_TextChanged);
            this.txt_PaidAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PaidAmt_KeyDown);
            this.txt_PaidAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PaidAmt_KeyPress);
            // 
            // lbl_PaidAmt
            // 
            this.lbl_PaidAmt.AutoSize = true;
            this.lbl_PaidAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PaidAmt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_PaidAmt.Location = new System.Drawing.Point(12, 115);
            this.lbl_PaidAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PaidAmt.Name = "lbl_PaidAmt";
            this.lbl_PaidAmt.Size = new System.Drawing.Size(74, 16);
            this.lbl_PaidAmt.TabIndex = 27;
            this.lbl_PaidAmt.Text = "Paid  Amt";
            // 
            // txt_NetAmt
            // 
            this.txt_NetAmt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NetAmt.Enabled = false;
            this.txt_NetAmt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_NetAmt.Location = new System.Drawing.Point(167, 80);
            this.txt_NetAmt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_NetAmt.Name = "txt_NetAmt";
            this.txt_NetAmt.Size = new System.Drawing.Size(144, 19);
            this.txt_NetAmt.TabIndex = 26;
            this.txt_NetAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NetAmt_KeyDown);
            this.txt_NetAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NetAmt_KeyPress);
            // 
            // lbl_NetAmount
            // 
            this.lbl_NetAmount.AutoSize = true;
            this.lbl_NetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NetAmount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_NetAmount.Location = new System.Drawing.Point(12, 81);
            this.lbl_NetAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NetAmount.Name = "lbl_NetAmount";
            this.lbl_NetAmount.Size = new System.Drawing.Size(62, 16);
            this.lbl_NetAmount.TabIndex = 25;
            this.lbl_NetAmount.Text = "Net Amt";
            // 
            // txt_Vat
            // 
            this.txt_Vat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Vat.Enabled = false;
            this.txt_Vat.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Vat.Location = new System.Drawing.Point(167, 46);
            this.txt_Vat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Vat.Name = "txt_Vat";
            this.txt_Vat.Size = new System.Drawing.Size(144, 19);
            this.txt_Vat.TabIndex = 24;
            this.txt_Vat.TextChanged += new System.EventHandler(this.txt_Vat_TextChanged);
            this.txt_Vat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Vat_KeyDown);
            this.txt_Vat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Vat_KeyPress);
            // 
            // lbl_Vat
            // 
            this.lbl_Vat.AutoSize = true;
            this.lbl_Vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Vat.Location = new System.Drawing.Point(12, 47);
            this.lbl_Vat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Vat.Name = "lbl_Vat";
            this.lbl_Vat.Size = new System.Drawing.Size(31, 16);
            this.lbl_Vat.TabIndex = 23;
            this.lbl_Vat.Text = "Vat";
            // 
            // txt_TotalAmt
            // 
            this.txt_TotalAmt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TotalAmt.Enabled = false;
            this.txt_TotalAmt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_TotalAmt.Location = new System.Drawing.Point(167, 12);
            this.txt_TotalAmt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_TotalAmt.Name = "txt_TotalAmt";
            this.txt_TotalAmt.Size = new System.Drawing.Size(144, 19);
            this.txt_TotalAmt.TabIndex = 22;
            this.txt_TotalAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TotalAmt_KeyDown);
            this.txt_TotalAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TotalAmt_KeyPress);
            // 
            // lbl_TotalAmt
            // 
            this.lbl_TotalAmt.AutoSize = true;
            this.lbl_TotalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalAmt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_TotalAmt.Location = new System.Drawing.Point(12, 13);
            this.lbl_TotalAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TotalAmt.Name = "lbl_TotalAmt";
            this.lbl_TotalAmt.Size = new System.Drawing.Size(74, 16);
            this.lbl_TotalAmt.TabIndex = 21;
            this.lbl_TotalAmt.Text = "Total Amt";
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Bottom.Controls.Add(this.bttn_Clear);
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Controls.Add(this.bttn_Purchase);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 548);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(992, 44);
            this.pnl_Bottom.TabIndex = 11;
            // 
            // bttn_Clear
            // 
            this.bttn_Clear.ForeColor = System.Drawing.Color.Blue;
            this.bttn_Clear.Location = new System.Drawing.Point(662, 8);
            this.bttn_Clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttn_Clear.Name = "bttn_Clear";
            this.bttn_Clear.Size = new System.Drawing.Size(82, 28);
            this.bttn_Clear.TabIndex = 19;
            this.bttn_Clear.Text = "Clear";
            this.bttn_Clear.UseVisualStyleBackColor = true;
            // 
            // bttn_Close
            // 
            this.bttn_Close.ForeColor = System.Drawing.Color.Red;
            this.bttn_Close.Location = new System.Drawing.Point(894, 8);
            this.bttn_Close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(82, 28);
            this.bttn_Close.TabIndex = 18;
            this.bttn_Close.Text = "Close";
            this.bttn_Close.UseVisualStyleBackColor = true;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // bttn_Purchase
            // 
            this.bttn_Purchase.Enabled = false;
            this.bttn_Purchase.ForeColor = System.Drawing.Color.OliveDrab;
            this.bttn_Purchase.Location = new System.Drawing.Point(771, 8);
            this.bttn_Purchase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttn_Purchase.Name = "bttn_Purchase";
            this.bttn_Purchase.Size = new System.Drawing.Size(96, 28);
            this.bttn_Purchase.TabIndex = 17;
            this.bttn_Purchase.Text = "Purchase";
            this.bttn_Purchase.UseVisualStyleBackColor = true;
            this.bttn_Purchase.Click += new System.EventHandler(this.bttn_Purchase_Click);
            // 
            // pnl_Picture
            // 
            this.pnl_Picture.AutoSize = true;
            this.pnl_Picture.Location = new System.Drawing.Point(528, 51);
            this.pnl_Picture.Name = "pnl_Picture";
            this.pnl_Picture.Size = new System.Drawing.Size(461, 284);
            this.pnl_Picture.TabIndex = 12;
            // 
            // frm_PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(992, 592);
            this.Controls.Add(this.pnl_Picture);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_PaymentOpt);
            this.Controls.Add(this.dgv_ItemInfo);
            this.Controls.Add(this.pnl_ItemInfo);
            this.Controls.Add(this.pnl_SupplierInfo);
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_PurchaseForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Form";
            this.Load += new System.EventHandler(this.frm_PurchaseForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PurchaseForm_KeyDown);
            this.Leave += new System.EventHandler(this.frm_PurchaseForm_Leave);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.pnl_SupplierInfo.ResumeLayout(false);
            this.pnl_SupplierInfo.PerformLayout();
            this.pnl_ItemInfo.ResumeLayout(false);
            this.pnl_ItemInfo.PerformLayout();
            this.pnl_Button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemInfo)).EndInit();
            this.pnl_PaymentOpt.ResumeLayout(false);
            this.pnl_PaymentOpt.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Purchase;
        private System.Windows.Forms.Label lbl_AccNo;
        private System.Windows.Forms.Label lbl_PurchaseFrom;
        private System.Windows.Forms.Label lbl_Add;
        private System.Windows.Forms.Label lbl_ContactNo;
        private System.Windows.Forms.Label lbl_BillNo;
        private System.Windows.Forms.Panel pnl_SupplierInfo;
        private System.Windows.Forms.TextBox txt_MobileNo;
        private System.Windows.Forms.TextBox txt_BillNo;
        private System.Windows.Forms.TextBox txt_ContactNo;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.ComboBox cmb_Name;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Panel pnl_ItemInfo;
        private System.Windows.Forms.TextBox txt_Amt;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.TextBox txt_Qty;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox txt_SellingAmt;
        private System.Windows.Forms.Label lbl_SellingAmt;
        private System.Windows.Forms.TextBox txt_PurchaseAmt;
        private System.Windows.Forms.ComboBox cmb_SubCategory;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_PurchaseAmt;
        private System.Windows.Forms.Label lbl_SubCategory;
        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.DataGridView dgv_ItemInfo;
        private System.Windows.Forms.Panel pnl_PaymentOpt;
        private System.Windows.Forms.CheckBox chbk_barcode;
        private System.Windows.Forms.TextBox txt_BalAmt;
        private System.Windows.Forms.Label lbl_BalanceAmt;
        private System.Windows.Forms.TextBox txt_PaidAmt;
        private System.Windows.Forms.Label lbl_PaidAmt;
        private System.Windows.Forms.TextBox txt_NetAmt;
        private System.Windows.Forms.Label lbl_NetAmount;
        private System.Windows.Forms.TextBox txt_Vat;
        private System.Windows.Forms.Label lbl_Vat;
        private System.Windows.Forms.TextBox txt_TotalAmt;
        private System.Windows.Forms.Label lbl_TotalAmt;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel pnl_Picture;
        private System.Windows.Forms.Label txt_AccNo;
        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.Button bttn_Delete;
        private System.Windows.Forms.Button bttn_Reset;
        private System.Windows.Forms.Button bttn_Update;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Button bttn_Purchase;
        private System.Windows.Forms.Button bttn_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_VatValue;
        private System.Windows.Forms.TextBox txt_Size;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PBill;
    }
}