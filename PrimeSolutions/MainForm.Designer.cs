namespace PrimeSolutions
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barcodeEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDailyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDatatabseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierDailyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierBillDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefrencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_developer = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.accountingToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(138, 351);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.saleToolStripMenuItem.Image = global::PrimeSolutions.Properties.Resources.cart_5;
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(125, 44);
            this.saleToolStripMenuItem.Text = "  Sale";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierToolStripMenuItem,
            this.barcodeEntryToolStripMenuItem});
            this.purchaseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.purchaseToolStripMenuItem.Image = global::PrimeSolutions.Properties.Resources.cart_13;
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(125, 44);
            this.purchaseToolStripMenuItem.Text = "  Purchase";
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Image = global::PrimeSolutions.Properties.Resources.delivery_cart;
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.supplierToolStripMenuItem.Text = "Supplier Purchase";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // barcodeEntryToolStripMenuItem
            // 
            this.barcodeEntryToolStripMenuItem.Image = global::PrimeSolutions.Properties.Resources.barcode;
            this.barcodeEntryToolStripMenuItem.Name = "barcodeEntryToolStripMenuItem";
            this.barcodeEntryToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.barcodeEntryToolStripMenuItem.Text = "Barcode Reprint";
            // 
            // accountingToolStripMenuItem
            // 
            this.accountingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openingBalanceToolStripMenuItem,
            this.creditToolStripMenuItem,
            this.debitToolStripMenuItem,
            this.balanceSheetToolStripMenuItem});
            this.accountingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accountingToolStripMenuItem.Image = global::PrimeSolutions.Properties.Resources.rich;
            this.accountingToolStripMenuItem.Name = "accountingToolStripMenuItem";
            this.accountingToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.accountingToolStripMenuItem.Size = new System.Drawing.Size(125, 44);
            this.accountingToolStripMenuItem.Text = " Accounting";
            // 
            // openingBalanceToolStripMenuItem
            // 
            this.openingBalanceToolStripMenuItem.Name = "openingBalanceToolStripMenuItem";
            this.openingBalanceToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.openingBalanceToolStripMenuItem.Text = "Opening Balance";
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.creditToolStripMenuItem.Text = "Credit";
            // 
            // debitToolStripMenuItem
            // 
            this.debitToolStripMenuItem.Name = "debitToolStripMenuItem";
            this.debitToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.debitToolStripMenuItem.Text = "Debit";
            // 
            // balanceSheetToolStripMenuItem
            // 
            this.balanceSheetToolStripMenuItem.Name = "balanceSheetToolStripMenuItem";
            this.balanceSheetToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.balanceSheetToolStripMenuItem.Text = "Balance Sheet";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleToolStripMenuItem1,
            this.purchaseToolStripMenuItem1,
            this.duplicateBillToolStripMenuItem,
            this.stockCheckToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.reportToolStripMenuItem.Image = global::PrimeSolutions.Properties.Resources.presentation;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(125, 44);
            this.reportToolStripMenuItem.Text = "  Report";
            // 
            // saleToolStripMenuItem1
            // 
            this.saleToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerDailyReportToolStripMenuItem,
            this.customerDatatabseToolStripMenuItem});
            this.saleToolStripMenuItem1.Name = "saleToolStripMenuItem1";
            this.saleToolStripMenuItem1.Size = new System.Drawing.Size(166, 24);
            this.saleToolStripMenuItem1.Text = "Sale";
            // 
            // customerDailyReportToolStripMenuItem
            // 
            this.customerDailyReportToolStripMenuItem.Name = "customerDailyReportToolStripMenuItem";
            this.customerDailyReportToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.customerDailyReportToolStripMenuItem.Text = "Customer Daily Report";
            this.customerDailyReportToolStripMenuItem.Click += new System.EventHandler(this.customerDailyReportToolStripMenuItem_Click);
            // 
            // customerDatatabseToolStripMenuItem
            // 
            this.customerDatatabseToolStripMenuItem.Name = "customerDatatabseToolStripMenuItem";
            this.customerDatatabseToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.customerDatatabseToolStripMenuItem.Text = "Customer Datatabse";
            this.customerDatatabseToolStripMenuItem.Click += new System.EventHandler(this.customerDatatabseToolStripMenuItem_Click);
            // 
            // purchaseToolStripMenuItem1
            // 
            this.purchaseToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierDailyReportToolStripMenuItem,
            this.supplierBillDetailsToolStripMenuItem});
            this.purchaseToolStripMenuItem1.Name = "purchaseToolStripMenuItem1";
            this.purchaseToolStripMenuItem1.Size = new System.Drawing.Size(166, 24);
            this.purchaseToolStripMenuItem1.Text = "Purchase";
            // 
            // supplierDailyReportToolStripMenuItem
            // 
            this.supplierDailyReportToolStripMenuItem.Name = "supplierDailyReportToolStripMenuItem";
            this.supplierDailyReportToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.supplierDailyReportToolStripMenuItem.Text = "Supplier Item Details Report";
            this.supplierDailyReportToolStripMenuItem.Click += new System.EventHandler(this.supplierDailyReportToolStripMenuItem_Click);
            // 
            // supplierBillDetailsToolStripMenuItem
            // 
            this.supplierBillDetailsToolStripMenuItem.Name = "supplierBillDetailsToolStripMenuItem";
            this.supplierBillDetailsToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.supplierBillDetailsToolStripMenuItem.Text = "Supplier Bill Details";
            this.supplierBillDetailsToolStripMenuItem.Click += new System.EventHandler(this.supplierBillDetailsToolStripMenuItem_Click);
            // 
            // duplicateBillToolStripMenuItem
            // 
            this.duplicateBillToolStripMenuItem.Name = "duplicateBillToolStripMenuItem";
            this.duplicateBillToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.duplicateBillToolStripMenuItem.Text = "Duplicate Bill";
            this.duplicateBillToolStripMenuItem.Click += new System.EventHandler(this.duplicateBillToolStripMenuItem_Click);
            // 
            // stockCheckToolStripMenuItem
            // 
            this.stockCheckToolStripMenuItem.Name = "stockCheckToolStripMenuItem";
            this.stockCheckToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.stockCheckToolStripMenuItem.Text = "Stock Check";
            this.stockCheckToolStripMenuItem.Click += new System.EventHandler(this.stockCheckToolStripMenuItem_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.subCategoryToolStripMenuItem});
            this.masterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterToolStripMenuItem.Image = global::PrimeSolutions.Properties.Resources.Applications;
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(125, 44);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // subCategoryToolStripMenuItem
            // 
            this.subCategoryToolStripMenuItem.Name = "subCategoryToolStripMenuItem";
            this.subCategoryToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.subCategoryToolStripMenuItem.Text = "Sub Category";
            this.subCategoryToolStripMenuItem.Click += new System.EventHandler(this.subCategoryToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prefrencesToolStripMenuItem,
            this.backUpDataToolStripMenuItem,
            this.errorReportToolStripMenuItem});
            this.settingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingToolStripMenuItem.Image = global::PrimeSolutions.Properties.Resources.Settings;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(125, 44);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // prefrencesToolStripMenuItem
            // 
            this.prefrencesToolStripMenuItem.Name = "prefrencesToolStripMenuItem";
            this.prefrencesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.prefrencesToolStripMenuItem.Text = "Prefrences";
            this.prefrencesToolStripMenuItem.Click += new System.EventHandler(this.prefrencesToolStripMenuItem_Click);
            // 
            // backUpDataToolStripMenuItem
            // 
            this.backUpDataToolStripMenuItem.Name = "backUpDataToolStripMenuItem";
            this.backUpDataToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.backUpDataToolStripMenuItem.Text = "BackUp Data";
            this.backUpDataToolStripMenuItem.Click += new System.EventHandler(this.backUpDataToolStripMenuItem_Click);
            // 
            // errorReportToolStripMenuItem
            // 
            this.errorReportToolStripMenuItem.Name = "errorReportToolStripMenuItem";
            this.errorReportToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.errorReportToolStripMenuItem.Text = "Error Report";
            this.errorReportToolStripMenuItem.Click += new System.EventHandler(this.errorReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.Image = global::PrimeSolutions.Properties.Resources.Close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(138, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 351);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 271);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lbl_developer);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(257, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 62);
            this.panel3.TabIndex = 6;
            // 
            // lbl_developer
            // 
            this.lbl_developer.AutoSize = true;
            this.lbl_developer.Location = new System.Drawing.Point(3, 3);
            this.lbl_developer.Name = "lbl_developer";
            this.lbl_developer.Size = new System.Drawing.Size(83, 26);
            this.lbl_developer.TabIndex = 6;
            this.lbl_developer.Text = "Developed and \r\nMaintained by";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::PrimeSolutions.Properties.Resources.Prime_logo;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(92, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(669, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customerDailyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supplierDailyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barcodeEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prefrencesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_developer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem stockCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDatatabseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierBillDetailsToolStripMenuItem;
    }
}

