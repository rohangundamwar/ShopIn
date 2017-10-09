namespace PrimeSolutions.Accounting
{
    partial class frmPaymentVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentVoucher));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_CreditDebit = new System.Windows.Forms.Label();
            this.dtp_vyapariSale = new System.Windows.Forms.DateTimePicker();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSalaryTypeValidator = new System.Windows.Forms.Label();
            this.lblVoucheNo = new System.Windows.Forms.Label();
            this.txtPaymentNo = new System.Windows.Forms.TextBox();
            this.btnLedgerAdd = new System.Windows.Forms.Button();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbAccountLedger = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dgv_PaymentVoucher = new System.Windows.Forms.DataGridView();
            this.PaymentMasterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashOrBankID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashOrBankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountLedgerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountLedgerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Narration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSearchByAccLedger = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSearchByAccGroup = new System.Windows.Forms.ComboBox();
            this.pnl_Header.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PaymentVoucher)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Header.Controls.Add(this.lbl_CreditDebit);
            this.pnl_Header.Controls.Add(this.dtp_vyapariSale);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(812, 35);
            this.pnl_Header.TabIndex = 1270;
            // 
            // lbl_CreditDebit
            // 
            this.lbl_CreditDebit.AutoSize = true;
            this.lbl_CreditDebit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreditDebit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_CreditDebit.Location = new System.Drawing.Point(348, 7);
            this.lbl_CreditDebit.Name = "lbl_CreditDebit";
            this.lbl_CreditDebit.Size = new System.Drawing.Size(120, 16);
            this.lbl_CreditDebit.TabIndex = 4;
            this.lbl_CreditDebit.Text = "Payment Voucher";
            // 
            // dtp_vyapariSale
            // 
            this.dtp_vyapariSale.Location = new System.Drawing.Point(1114, 6);
            this.dtp_vyapariSale.Name = "dtp_vyapariSale";
            this.dtp_vyapariSale.Size = new System.Drawing.Size(85, 20);
            this.dtp_vyapariSale.TabIndex = 3;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(201, 122);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 22);
            this.txtDate.TabIndex = 1255;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(83, 125);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 16);
            this.lblDate.TabIndex = 1254;
            this.lblDate.Text = "Date";
            // 
            // lblSalaryTypeValidator
            // 
            this.lblSalaryTypeValidator.AutoSize = true;
            this.lblSalaryTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryTypeValidator.Location = new System.Drawing.Point(411, 34);
            this.lblSalaryTypeValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalaryTypeValidator.Name = "lblSalaryTypeValidator";
            this.lblSalaryTypeValidator.Size = new System.Drawing.Size(13, 16);
            this.lblSalaryTypeValidator.TabIndex = 1275;
            this.lblSalaryTypeValidator.Text = "*";
            // 
            // lblVoucheNo
            // 
            this.lblVoucheNo.AutoSize = true;
            this.lblVoucheNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblVoucheNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucheNo.Location = new System.Drawing.Point(81, 32);
            this.lblVoucheNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucheNo.Name = "lblVoucheNo";
            this.lblVoucheNo.Size = new System.Drawing.Size(89, 16);
            this.lblVoucheNo.TabIndex = 1274;
            this.lblVoucheNo.Text = "Payment No.";
            // 
            // txtPaymentNo
            // 
            this.txtPaymentNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPaymentNo.Location = new System.Drawing.Point(201, 29);
            this.txtPaymentNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtPaymentNo.Name = "txtPaymentNo";
            this.txtPaymentNo.ReadOnly = true;
            this.txtPaymentNo.Size = new System.Drawing.Size(200, 22);
            this.txtPaymentNo.TabIndex = 1271;
            this.txtPaymentNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaymentNo_KeyDown);
            // 
            // btnLedgerAdd
            // 
            this.btnLedgerAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLedgerAdd.BackgroundImage")));
            this.btnLedgerAdd.Location = new System.Drawing.Point(423, 61);
            this.btnLedgerAdd.Name = "btnLedgerAdd";
            this.btnLedgerAdd.Size = new System.Drawing.Size(23, 21);
            this.btnLedgerAdd.TabIndex = 1277;
            this.btnLedgerAdd.UseVisualStyleBackColor = true;
            this.btnLedgerAdd.Click += new System.EventHandler(this.btnLedgerAdd_Click);
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Bottom.Controls.Add(this.btnUpdate);
            this.pnl_Bottom.Controls.Add(this.btn_Close);
            this.pnl_Bottom.Controls.Add(this.btn_Save);
            this.pnl_Bottom.Controls.Add(this.btn_Clear);
            this.pnl_Bottom.Controls.Add(this.btn_Delete);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 556);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(812, 41);
            this.pnl_Bottom.TabIndex = 1279;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(260, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 27);
            this.btnUpdate.TabIndex = 1268;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(566, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(85, 27);
            this.btn_Close.TabIndex = 1267;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Save.BackgroundImage")));
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(158, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(85, 27);
            this.btn_Save.TabIndex = 1264;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Clear.BackgroundImage")));
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(464, 5);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(85, 27);
            this.btn_Clear.TabIndex = 1265;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.BackgroundImage")));
            this.btn_Delete.Enabled = false;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(362, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(85, 27);
            this.btn_Delete.TabIndex = 1266;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(83, 154);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(67, 16);
            this.lblNarration.TabIndex = 1282;
            this.lblNarration.Text = "Narration";
            // 
            // txtNarration
            // 
            this.txtNarration.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNarration.Location = new System.Drawing.Point(201, 154);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 1280;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(411, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 1287;
            this.label2.Text = "*";
            // 
            // CmbAccountLedger
            // 
            this.CmbAccountLedger.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbAccountLedger.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbAccountLedger.DisplayMember = "Name";
            this.CmbAccountLedger.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.CmbAccountLedger.FormattingEnabled = true;
            this.CmbAccountLedger.Location = new System.Drawing.Point(201, 59);
            this.CmbAccountLedger.Margin = new System.Windows.Forms.Padding(5);
            this.CmbAccountLedger.Name = "CmbAccountLedger";
            this.CmbAccountLedger.Size = new System.Drawing.Size(200, 24);
            this.CmbAccountLedger.TabIndex = 1285;
            this.CmbAccountLedger.ValueMember = "ledgerId";
            this.CmbAccountLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbAccountLedger_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(83, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 1286;
            this.label3.Text = "Account Ledger";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(83, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 1289;
            this.label4.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtAmount.Location = new System.Drawing.Point(201, 92);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 22);
            this.txtAmount.TabIndex = 1288;
            this.txtAmount.Text = "0";
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // dgv_PaymentVoucher
            // 
            this.dgv_PaymentVoucher.AllowUserToAddRows = false;
            this.dgv_PaymentVoucher.AllowUserToDeleteRows = false;
            this.dgv_PaymentVoucher.AllowUserToResizeColumns = false;
            this.dgv_PaymentVoucher.AllowUserToResizeRows = false;
            this.dgv_PaymentVoucher.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_PaymentVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PaymentVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentMasterID,
            this.PaymentNo,
            this.Date,
            this.CashOrBankID,
            this.CashOrBankName,
            this.AccountLedgerID,
            this.AccountLedgerName,
            this.Amount,
            this.Narration});
            this.dgv_PaymentVoucher.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_PaymentVoucher.Location = new System.Drawing.Point(13, 319);
            this.dgv_PaymentVoucher.Name = "dgv_PaymentVoucher";
            this.dgv_PaymentVoucher.ReadOnly = true;
            this.dgv_PaymentVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PaymentVoucher.Size = new System.Drawing.Size(787, 233);
            this.dgv_PaymentVoucher.TabIndex = 1290;
            this.dgv_PaymentVoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PaymentVoucher_CellClick);
            // 
            // PaymentMasterID
            // 
            this.PaymentMasterID.HeaderText = "PaymentMasterID";
            this.PaymentMasterID.Name = "PaymentMasterID";
            this.PaymentMasterID.ReadOnly = true;
            this.PaymentMasterID.Visible = false;
            // 
            // PaymentNo
            // 
            this.PaymentNo.HeaderText = "P. No";
            this.PaymentNo.Name = "PaymentNo";
            this.PaymentNo.ReadOnly = true;
            this.PaymentNo.Width = 70;
            // 
            // Date
            // 
            this.Date.FillWeight = 70F;
            this.Date.HeaderText = "P. Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 70;
            // 
            // CashOrBankID
            // 
            this.CashOrBankID.HeaderText = "CashOrBankID";
            this.CashOrBankID.Name = "CashOrBankID";
            this.CashOrBankID.ReadOnly = true;
            this.CashOrBankID.Visible = false;
            // 
            // CashOrBankName
            // 
            this.CashOrBankName.HeaderText = "CashOrBank Name";
            this.CashOrBankName.Name = "CashOrBankName";
            this.CashOrBankName.ReadOnly = true;
            this.CashOrBankName.Width = 200;
            // 
            // AccountLedgerID
            // 
            this.AccountLedgerID.HeaderText = "Account Ledger ID";
            this.AccountLedgerID.Name = "AccountLedgerID";
            this.AccountLedgerID.ReadOnly = true;
            this.AccountLedgerID.Visible = false;
            // 
            // AccountLedgerName
            // 
            this.AccountLedgerName.HeaderText = "AccountLedger Name";
            this.AccountLedgerName.Name = "AccountLedgerName";
            this.AccountLedgerName.ReadOnly = true;
            this.AccountLedgerName.Width = 200;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Narration
            // 
            this.Narration.HeaderText = "Narration";
            this.Narration.Name = "Narration";
            this.Narration.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(411, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1292;
            this.label1.Text = "Payment ID.";
            this.label1.Visible = false;
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPaymentID.Location = new System.Drawing.Point(411, 146);
            this.txtPaymentID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.ReadOnly = true;
            this.txtPaymentID.Size = new System.Drawing.Size(87, 22);
            this.txtPaymentID.TabIndex = 1291;
            this.txtPaymentID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNarration);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtPaymentNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblVoucheNo);
            this.groupBox1.Controls.Add(this.txtPaymentID);
            this.groupBox1.Controls.Add(this.lblSalaryTypeValidator);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.btnLedgerAdd);
            this.groupBox1.Controls.Add(this.lblNarration);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.CmbAccountLedger);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(117, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 215);
            this.groupBox1.TabIndex = 1293;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(440, 291);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 1294;
            this.label5.Text = "Account Ledger";
            // 
            // cmbSearchByAccLedger
            // 
            this.cmbSearchByAccLedger.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearchByAccLedger.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearchByAccLedger.DisplayMember = "AccountLedgerName";
            this.cmbSearchByAccLedger.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbSearchByAccLedger.FormattingEnabled = true;
            this.cmbSearchByAccLedger.Location = new System.Drawing.Point(558, 287);
            this.cmbSearchByAccLedger.Margin = new System.Windows.Forms.Padding(5);
            this.cmbSearchByAccLedger.Name = "cmbSearchByAccLedger";
            this.cmbSearchByAccLedger.Size = new System.Drawing.Size(200, 24);
            this.cmbSearchByAccLedger.TabIndex = 1293;
            this.cmbSearchByAccLedger.ValueMember = "AccountLedgerName";
            this.cmbSearchByAccLedger.SelectedIndexChanged += new System.EventHandler(this.cmbSearchByAccLedger_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(42, 291);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 1296;
            this.label6.Text = "Account Group";
            // 
            // cmbSearchByAccGroup
            // 
            this.cmbSearchByAccGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearchByAccGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearchByAccGroup.DisplayMember = "CashOrBankName";
            this.cmbSearchByAccGroup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbSearchByAccGroup.FormattingEnabled = true;
            this.cmbSearchByAccGroup.Location = new System.Drawing.Point(160, 287);
            this.cmbSearchByAccGroup.Margin = new System.Windows.Forms.Padding(5);
            this.cmbSearchByAccGroup.Name = "cmbSearchByAccGroup";
            this.cmbSearchByAccGroup.Size = new System.Drawing.Size(200, 24);
            this.cmbSearchByAccGroup.TabIndex = 1295;
            this.cmbSearchByAccGroup.ValueMember = "CashOrBankName";
            this.cmbSearchByAccGroup.SelectedIndexChanged += new System.EventHandler(this.cmbSearchByAccGroup_SelectedIndexChanged);
            this.cmbSearchByAccGroup.SelectedValueChanged += new System.EventHandler(this.cmbSearchByAccGroup_SelectedValueChanged);
            // 
            // frmPaymentVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 597);
            this.Controls.Add(this.cmbSearchByAccLedger);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSearchByAccGroup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_PaymentVoucher);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Header);
            this.Name = "frmPaymentVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Voucher";
            this.Load += new System.EventHandler(this.frmPaymentVoucher_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PaymentVoucher)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label lbl_CreditDebit;
        private System.Windows.Forms.DateTimePicker dtp_vyapariSale;
        private System.Windows.Forms.Button btnLedgerAdd;
        private System.Windows.Forms.Label lblSalaryTypeValidator;
        private System.Windows.Forms.Label lblVoucheNo;
        private System.Windows.Forms.TextBox txtPaymentNo;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbAccountLedger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgv_PaymentVoucher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSearchByAccLedger;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSearchByAccGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMasterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashOrBankID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashOrBankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountLedgerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountLedgerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Narration;
    }
}