namespace PrimeSolutions.Accounting
{
    partial class Frm_AccountLedgerReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AccountLedgerReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExport = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_accountledger = new System.Windows.Forms.Label();
            this.dtp_vyapariSale = new System.Windows.Forms.DateTimePicker();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.grp_accountLedger = new System.Windows.Forms.GroupBox();
            this.dtp_ToDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_FromDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.cmb_AccountLedger = new System.Windows.Forms.ComboBox();
            this.dgv_AccountLedgerReport = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LedgerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountLedger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpeningBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClosingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_AccountGroup = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_Header.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.grp_accountLedger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccountLedgerReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport.BackgroundImage")));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(594, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 1314;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Print.BackgroundImage")));
            this.btn_Print.FlatAppearance.BorderSize = 0;
            this.btn_Print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(497, 1);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(85, 27);
            this.btn_Print.TabIndex = 1313;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Header.Controls.Add(this.lbl_accountledger);
            this.pnl_Header.Controls.Add(this.dtp_vyapariSale);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(791, 35);
            this.pnl_Header.TabIndex = 1324;
            // 
            // lbl_accountledger
            // 
            this.lbl_accountledger.AutoSize = true;
            this.lbl_accountledger.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accountledger.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_accountledger.Location = new System.Drawing.Point(353, 3);
            this.lbl_accountledger.Name = "lbl_accountledger";
            this.lbl_accountledger.Size = new System.Drawing.Size(108, 16);
            this.lbl_accountledger.TabIndex = 4;
            this.lbl_accountledger.Text = "Account Ledger";
            // 
            // dtp_vyapariSale
            // 
            this.dtp_vyapariSale.Location = new System.Drawing.Point(1114, 6);
            this.dtp_vyapariSale.Name = "dtp_vyapariSale";
            this.dtp_vyapariSale.Size = new System.Drawing.Size(85, 20);
            this.dtp_vyapariSale.TabIndex = 3;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Bottom.Controls.Add(this.btn_Close);
            this.pnl_Bottom.Controls.Add(this.btn_Print);
            this.pnl_Bottom.Controls.Add(this.btnExport);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 606);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(791, 35);
            this.pnl_Bottom.TabIndex = 1325;
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(685, 1);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(85, 27);
            this.btn_Close.TabIndex = 1315;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // grp_accountLedger
            // 
            this.grp_accountLedger.Controls.Add(this.dtp_ToDate);
            this.grp_accountLedger.Controls.Add(this.dtp_FromDate);
            this.grp_accountLedger.Controls.Add(this.btn_Search);
            this.grp_accountLedger.Controls.Add(this.btn_Reset);
            this.grp_accountLedger.Controls.Add(this.cmb_AccountLedger);
            this.grp_accountLedger.Controls.Add(this.dgv_AccountLedgerReport);
            this.grp_accountLedger.Controls.Add(this.label6);
            this.grp_accountLedger.Controls.Add(this.cmb_AccountGroup);
            this.grp_accountLedger.Controls.Add(this.label8);
            this.grp_accountLedger.Controls.Add(this.label5);
            this.grp_accountLedger.Controls.Add(this.label4);
            this.grp_accountLedger.Location = new System.Drawing.Point(0, 41);
            this.grp_accountLedger.Name = "grp_accountLedger";
            this.grp_accountLedger.Size = new System.Drawing.Size(791, 559);
            this.grp_accountLedger.TabIndex = 1326;
            this.grp_accountLedger.TabStop = false;
            // 
            // dtp_ToDate
            // 
            this.dtp_ToDate.Location = new System.Drawing.Point(576, 5);
            this.dtp_ToDate.Name = "dtp_ToDate";
            this.dtp_ToDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_ToDate.TabIndex = 1330;
            // 
            // dtp_FromDate
            // 
            this.dtp_FromDate.Location = new System.Drawing.Point(138, 5);
            this.dtp_FromDate.Name = "dtp_FromDate";
            this.dtp_FromDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_FromDate.TabIndex = 1329;
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(138, 59);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(85, 27);
            this.btn_Search.TabIndex = 1322;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Reset.BackgroundImage")));
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(231, 59);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(85, 27);
            this.btn_Reset.TabIndex = 1323;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // cmb_AccountLedger
            // 
            this.cmb_AccountLedger.DisplayMember = "Name";
            this.cmb_AccountLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AccountLedger.FormattingEnabled = true;
            this.cmb_AccountLedger.Location = new System.Drawing.Point(576, 32);
            this.cmb_AccountLedger.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmb_AccountLedger.Name = "cmb_AccountLedger";
            this.cmb_AccountLedger.Size = new System.Drawing.Size(200, 21);
            this.cmb_AccountLedger.TabIndex = 1321;
            this.cmb_AccountLedger.ValueMember = "accGroupId";
            // 
            // dgv_AccountLedgerReport
            // 
            this.dgv_AccountLedgerReport.AllowUserToAddRows = false;
            this.dgv_AccountLedgerReport.AllowUserToDeleteRows = false;
            this.dgv_AccountLedgerReport.AllowUserToResizeRows = false;
            this.dgv_AccountLedgerReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AccountLedgerReport.BackgroundColor = System.Drawing.Color.White;
            this.dgv_AccountLedgerReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_AccountLedgerReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_AccountLedgerReport.ColumnHeadersHeight = 35;
            this.dgv_AccountLedgerReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_AccountLedgerReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.Date,
            this.LedgerId,
            this.AccountLedger,
            this.OpeningBalance,
            this.Debit,
            this.Credit,
            this.ClosingBalance});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_AccountLedgerReport.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_AccountLedgerReport.EnableHeadersVisualStyles = false;
            this.dgv_AccountLedgerReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_AccountLedgerReport.Location = new System.Drawing.Point(15, 92);
            this.dgv_AccountLedgerReport.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.dgv_AccountLedgerReport.Name = "dgv_AccountLedgerReport";
            this.dgv_AccountLedgerReport.ReadOnly = true;
            this.dgv_AccountLedgerReport.RowHeadersVisible = false;
            this.dgv_AccountLedgerReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AccountLedgerReport.Size = new System.Drawing.Size(761, 456);
            this.dgv_AccountLedgerReport.TabIndex = 1328;
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "Sl.No";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            this.SrNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // LedgerId
            // 
            this.LedgerId.HeaderText = "Ledger Id";
            this.LedgerId.Name = "LedgerId";
            this.LedgerId.ReadOnly = true;
            this.LedgerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LedgerId.Visible = false;
            // 
            // AccountLedger
            // 
            this.AccountLedger.HeaderText = "Account Ledger";
            this.AccountLedger.Name = "AccountLedger";
            this.AccountLedger.ReadOnly = true;
            this.AccountLedger.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OpeningBalance
            // 
            this.OpeningBalance.HeaderText = "Opening Balance";
            this.OpeningBalance.Name = "OpeningBalance";
            this.OpeningBalance.ReadOnly = true;
            this.OpeningBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Debit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Debit.DefaultCellStyle = dataGridViewCellStyle2;
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            this.Debit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Credit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Credit.DefaultCellStyle = dataGridViewCellStyle3;
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClosingBalance
            // 
            this.ClosingBalance.HeaderText = "Closing Balance";
            this.ClosingBalance.Name = "ClosingBalance";
            this.ClosingBalance.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(465, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 1327;
            this.label6.Text = "Account Ledger";
            // 
            // cmb_AccountGroup
            // 
            this.cmb_AccountGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AccountGroup.FormattingEnabled = true;
            this.cmb_AccountGroup.Location = new System.Drawing.Point(138, 32);
            this.cmb_AccountGroup.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmb_AccountGroup.Name = "cmb_AccountGroup";
            this.cmb_AccountGroup.Size = new System.Drawing.Size(200, 21);
            this.cmb_AccountGroup.TabIndex = 1320;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(16, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 1324;
            this.label8.Text = "From Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(16, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 1326;
            this.label5.Text = "Account group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(465, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1325;
            this.label4.Text = "To Date";
            // 
            // Frm_AccountLedgerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 641);
            this.Controls.Add(this.grp_accountLedger);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Header);
            this.Name = "Frm_AccountLedgerReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AccountLedgerReport";
            this.Load += new System.EventHandler(this.Frm_AccountLedgerReport_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.grp_accountLedger.ResumeLayout(false);
            this.grp_accountLedger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccountLedgerReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_accountledger;
        private System.Windows.Forms.DateTimePicker dtp_vyapariSale;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.GroupBox grp_accountLedger;
        private System.Windows.Forms.DateTimePicker dtp_ToDate;
        private System.Windows.Forms.DateTimePicker dtp_FromDate;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.ComboBox cmb_AccountLedger;
        private System.Windows.Forms.DataGridView dgv_AccountLedgerReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_AccountGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn LedgerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountLedger;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpeningBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosingBalance;
    }
}