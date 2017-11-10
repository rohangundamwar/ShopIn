namespace PrimeSolutions.Accounting
{
    partial class frmAccountLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountLedger));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvAccountLedger = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtLedgerNameSearch = new System.Windows.Forms.TextBox();
            this.lblLedgerNameSearch = new System.Windows.Forms.Label();
            this.cmbGroupSearch = new System.Windows.Forms.ComboBox();
            this.lblGroupSearch = new System.Windows.Forms.Label();
            this.tbMainDetails = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalaryTypeValidator = new System.Windows.Forms.Label();
            this.btnAccountGroupAdd = new System.Windows.Forms.Button();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.txtLedgerName = new System.Windows.Forms.TextBox();
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.txtBranchCode = new System.Windows.Forms.TextBox();
            this.lblBranchCode = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.txtAcNo = new System.Windows.Forms.TextBox();
            this.lblACNo = new System.Windows.Forms.Label();
            this.lblNarration = new System.Windows.Forms.Label();
            this.cmbOpeningBalanceCrOrDr = new System.Windows.Forms.ComboBox();
            this.lblOpeningBalance = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbctrlLedger = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountLedger)).BeginInit();
            this.tbMainDetails.SuspendLayout();
            this.gbxDetails.SuspendLayout();
            this.tbctrlLedger.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(659, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvAccountLedger
            // 
            this.dgvAccountLedger.AllowUserToAddRows = false;
            this.dgvAccountLedger.AllowUserToDeleteRows = false;
            this.dgvAccountLedger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountLedger.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccountLedger.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountLedger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccountLedger.ColumnHeadersHeight = 25;
            this.dgvAccountLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccountLedger.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccountLedger.EnableHeadersVisualStyles = false;
            this.dgvAccountLedger.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAccountLedger.Location = new System.Drawing.Point(38, 396);
            this.dgvAccountLedger.MultiSelect = false;
            this.dgvAccountLedger.Name = "dgvAccountLedger";
            this.dgvAccountLedger.ReadOnly = true;
            this.dgvAccountLedger.RowHeadersVisible = false;
            this.dgvAccountLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountLedger.Size = new System.Drawing.Size(724, 153);
            this.dgvAccountLedger.TabIndex = 39;
            this.dgvAccountLedger.TabStop = false;
            this.dgvAccountLedger.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountLedger_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(568, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(659, 249);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(386, 249);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(477, 249);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtLedgerNameSearch
            // 
            this.txtLedgerNameSearch.Location = new System.Drawing.Point(131, 13);
            this.txtLedgerNameSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtLedgerNameSearch.Name = "txtLedgerNameSearch";
            this.txtLedgerNameSearch.Size = new System.Drawing.Size(200, 20);
            this.txtLedgerNameSearch.TabIndex = 0;
            this.txtLedgerNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLedgerNameSearch_KeyDown);
            // 
            // lblLedgerNameSearch
            // 
            this.lblLedgerNameSearch.AutoSize = true;
            this.lblLedgerNameSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLedgerNameSearch.Location = new System.Drawing.Point(21, 17);
            this.lblLedgerNameSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblLedgerNameSearch.Name = "lblLedgerNameSearch";
            this.lblLedgerNameSearch.Size = new System.Drawing.Size(35, 13);
            this.lblLedgerNameSearch.TabIndex = 171;
            this.lblLedgerNameSearch.Text = "Name";
            // 
            // cmbGroupSearch
            // 
            this.cmbGroupSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupSearch.FormattingEnabled = true;
            this.cmbGroupSearch.Location = new System.Drawing.Point(453, 13);
            this.cmbGroupSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbGroupSearch.Name = "cmbGroupSearch";
            this.cmbGroupSearch.Size = new System.Drawing.Size(200, 21);
            this.cmbGroupSearch.TabIndex = 1;
            this.cmbGroupSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGroupSearch_KeyDown);
            // 
            // lblGroupSearch
            // 
            this.lblGroupSearch.AutoSize = true;
            this.lblGroupSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGroupSearch.Location = new System.Drawing.Point(343, 17);
            this.lblGroupSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblGroupSearch.Name = "lblGroupSearch";
            this.lblGroupSearch.Size = new System.Drawing.Size(36, 13);
            this.lblGroupSearch.TabIndex = 169;
            this.lblGroupSearch.Text = "Group";
            // 
            // tbMainDetails
            // 
            this.tbMainDetails.BackColor = System.Drawing.Color.White;
            this.tbMainDetails.Controls.Add(this.label1);
            this.tbMainDetails.Controls.Add(this.lblSalaryTypeValidator);
            this.tbMainDetails.Controls.Add(this.btnAccountGroupAdd);
            this.tbMainDetails.Controls.Add(this.txtOpeningBalance);
            this.tbMainDetails.Controls.Add(this.txtNarration);
            this.tbMainDetails.Controls.Add(this.txtLedgerName);
            this.tbMainDetails.Controls.Add(this.gbxDetails);
            this.tbMainDetails.Controls.Add(this.lblNarration);
            this.tbMainDetails.Controls.Add(this.cmbOpeningBalanceCrOrDr);
            this.tbMainDetails.Controls.Add(this.lblOpeningBalance);
            this.tbMainDetails.Controls.Add(this.cmbGroup);
            this.tbMainDetails.Controls.Add(this.lblGroup);
            this.tbMainDetails.Controls.Add(this.lblName);
            this.tbMainDetails.Location = new System.Drawing.Point(4, 22);
            this.tbMainDetails.Margin = new System.Windows.Forms.Padding(5);
            this.tbMainDetails.Name = "tbMainDetails";
            this.tbMainDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbMainDetails.Size = new System.Drawing.Size(716, 185);
            this.tbMainDetails.TabIndex = 0;
            this.tbMainDetails.Text = "Main Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(328, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "*";
            // 
            // lblSalaryTypeValidator
            // 
            this.lblSalaryTypeValidator.AutoSize = true;
            this.lblSalaryTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryTypeValidator.Location = new System.Drawing.Point(328, 26);
            this.lblSalaryTypeValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalaryTypeValidator.Name = "lblSalaryTypeValidator";
            this.lblSalaryTypeValidator.Size = new System.Drawing.Size(11, 13);
            this.lblSalaryTypeValidator.TabIndex = 175;
            this.lblSalaryTypeValidator.Text = "*";
            // 
            // btnAccountGroupAdd
            // 
            this.btnAccountGroupAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccountGroupAdd.BackgroundImage")));
            this.btnAccountGroupAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccountGroupAdd.FlatAppearance.BorderSize = 0;
            this.btnAccountGroupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountGroupAdd.Location = new System.Drawing.Point(344, 46);
            this.btnAccountGroupAdd.Name = "btnAccountGroupAdd";
            this.btnAccountGroupAdd.Size = new System.Drawing.Size(20, 20);
            this.btnAccountGroupAdd.TabIndex = 4;
            this.btnAccountGroupAdd.UseVisualStyleBackColor = true;
            this.btnAccountGroupAdd.Click += new System.EventHandler(this.btnAccountGroupAdd_Click);
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.Location = new System.Drawing.Point(120, 73);
            this.txtOpeningBalance.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtOpeningBalance.MaxLength = 13;
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.Size = new System.Drawing.Size(146, 20);
            this.txtOpeningBalance.TabIndex = 2;
            this.txtOpeningBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOpeningBalance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOpeningBalance_KeyDown);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(120, 98);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 70);
            this.txtNarration.TabIndex = 4;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            // 
            // txtLedgerName
            // 
            this.txtLedgerName.Location = new System.Drawing.Point(120, 22);
            this.txtLedgerName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtLedgerName.Name = "txtLedgerName";
            this.txtLedgerName.Size = new System.Drawing.Size(200, 20);
            this.txtLedgerName.TabIndex = 0;
            this.txtLedgerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLedgerName_KeyDown);
            // 
            // gbxDetails
            // 
            this.gbxDetails.Controls.Add(this.txtBranchCode);
            this.gbxDetails.Controls.Add(this.lblBranchCode);
            this.gbxDetails.Controls.Add(this.txtBranchName);
            this.gbxDetails.Controls.Add(this.lblBranchName);
            this.gbxDetails.Controls.Add(this.txtAcNo);
            this.gbxDetails.Controls.Add(this.lblACNo);
            this.gbxDetails.ForeColor = System.Drawing.Color.Black;
            this.gbxDetails.Location = new System.Drawing.Point(374, 22);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(324, 146);
            this.gbxDetails.TabIndex = 6;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "Details";
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.Location = new System.Drawing.Point(105, 92);
            this.txtBranchCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtBranchCode.MaxLength = 18;
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Size = new System.Drawing.Size(200, 20);
            this.txtBranchCode.TabIndex = 2;
            // 
            // lblBranchCode
            // 
            this.lblBranchCode.AutoSize = true;
            this.lblBranchCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBranchCode.Location = new System.Drawing.Point(17, 95);
            this.lblBranchCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblBranchCode.Name = "lblBranchCode";
            this.lblBranchCode.Size = new System.Drawing.Size(69, 13);
            this.lblBranchCode.TabIndex = 149;
            this.lblBranchCode.Text = "Branch Code";
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(105, 67);
            this.txtBranchName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(200, 20);
            this.txtBranchName.TabIndex = 1;
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBranchName.Location = new System.Drawing.Point(17, 71);
            this.lblBranchName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(72, 13);
            this.lblBranchName.TabIndex = 147;
            this.lblBranchName.Text = "Branch Name";
            // 
            // txtAcNo
            // 
            this.txtAcNo.Location = new System.Drawing.Point(105, 42);
            this.txtAcNo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtAcNo.MaxLength = 18;
            this.txtAcNo.Name = "txtAcNo";
            this.txtAcNo.Size = new System.Drawing.Size(200, 20);
            this.txtAcNo.TabIndex = 0;
            // 
            // lblACNo
            // 
            this.lblACNo.AutoSize = true;
            this.lblACNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblACNo.Location = new System.Drawing.Point(17, 45);
            this.lblACNo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblACNo.Name = "lblACNo";
            this.lblACNo.Size = new System.Drawing.Size(48, 13);
            this.lblACNo.TabIndex = 145;
            this.lblACNo.Text = "Ac / No.";
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(10, 98);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 161;
            this.lblNarration.Text = "Narration";
            // 
            // cmbOpeningBalanceCrOrDr
            // 
            this.cmbOpeningBalanceCrOrDr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpeningBalanceCrOrDr.FormattingEnabled = true;
            this.cmbOpeningBalanceCrOrDr.Items.AddRange(new object[] {
            "Dr",
            "Cr"});
            this.cmbOpeningBalanceCrOrDr.Location = new System.Drawing.Point(270, 73);
            this.cmbOpeningBalanceCrOrDr.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbOpeningBalanceCrOrDr.Name = "cmbOpeningBalanceCrOrDr";
            this.cmbOpeningBalanceCrOrDr.Size = new System.Drawing.Size(51, 21);
            this.cmbOpeningBalanceCrOrDr.TabIndex = 3;
            this.cmbOpeningBalanceCrOrDr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOpeningBalanceCrOrDr_KeyDown);
            // 
            // lblOpeningBalance
            // 
            this.lblOpeningBalance.AutoSize = true;
            this.lblOpeningBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOpeningBalance.Location = new System.Drawing.Point(11, 77);
            this.lblOpeningBalance.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblOpeningBalance.Name = "lblOpeningBalance";
            this.lblOpeningBalance.Size = new System.Drawing.Size(89, 13);
            this.lblOpeningBalance.TabIndex = 145;
            this.lblOpeningBalance.Text = "Opening Balance";
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(120, 47);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbGroup.TabIndex = 1;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            this.cmbGroup.SelectedValueChanged += new System.EventHandler(this.cmbGroup_SelectedValueChanged);
            this.cmbGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGroup_KeyDown);
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGroup.Location = new System.Drawing.Point(11, 51);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 139;
            this.lblGroup.Text = "Group";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(11, 26);
            this.lblName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 136;
            this.lblName.Text = "Name";
            // 
            // tbctrlLedger
            // 
            this.tbctrlLedger.Controls.Add(this.tbMainDetails);
            this.tbctrlLedger.Location = new System.Drawing.Point(20, 32);
            this.tbctrlLedger.Name = "tbctrlLedger";
            this.tbctrlLedger.SelectedIndex = 0;
            this.tbctrlLedger.Size = new System.Drawing.Size(724, 211);
            this.tbctrlLedger.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.tbctrlLedger);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(18, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Ledger";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.txtLedgerNameSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.lblLedgerNameSearch);
            this.groupBox2.Controls.Add(this.cmbGroupSearch);
            this.groupBox2.Controls.Add(this.lblGroupSearch);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(18, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Date.Location = new System.Drawing.Point(64, 8);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(37, 16);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.Location = new System.Drawing.Point(130, 8);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(177, 20);
            this.dtp_Date.TabIndex = 3;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.Controls.Add(this.dtp_Date);
            this.pnl_Header.Controls.Add(this.lbl_Date);
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(800, 33);
            this.pnl_Header.TabIndex = 165;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 33);
            this.panel1.TabIndex = 165;
            // 
            // frmAccountLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.dgvAccountLedger);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAccountLedger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Ledger";
            this.Load += new System.EventHandler(this.frmAccountLedger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountLedger)).EndInit();
            this.tbMainDetails.ResumeLayout(false);
            this.tbMainDetails.PerformLayout();
            this.gbxDetails.ResumeLayout(false);
            this.gbxDetails.PerformLayout();
            this.tbctrlLedger.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvAccountLedger;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtLedgerNameSearch;
        private System.Windows.Forms.Label lblLedgerNameSearch;
        private System.Windows.Forms.ComboBox cmbGroupSearch;
        private System.Windows.Forms.Label lblGroupSearch;
        private System.Windows.Forms.TabPage tbMainDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSalaryTypeValidator;
        private System.Windows.Forms.Button btnAccountGroupAdd;
        private System.Windows.Forms.TextBox txtOpeningBalance;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.GroupBox gbxDetails;
        private System.Windows.Forms.TextBox txtBranchCode;
        private System.Windows.Forms.Label lblBranchCode;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.TextBox txtAcNo;
        private System.Windows.Forms.Label lblACNo;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.ComboBox cmbOpeningBalanceCrOrDr;
        private System.Windows.Forms.Label lblOpeningBalance;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabControl tbctrlLedger;
        private System.Windows.Forms.TextBox txtLedgerName;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel panel1;
    }
}