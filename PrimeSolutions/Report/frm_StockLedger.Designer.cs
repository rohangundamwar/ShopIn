namespace PrimeSolutions.Report
{
    partial class frm_StockLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StockLedger));
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_StockDetail = new System.Windows.Forms.Label();
            this.bttn_Excel = new System.Windows.Forms.Button();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.cmb_SubCategory = new System.Windows.Forms.ComboBox();
            this.bttn_Sort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_stock
            // 
            this.dgv_stock.AllowUserToAddRows = false;
            this.dgv_stock.AllowUserToDeleteRows = false;
            this.dgv_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_stock.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.Date,
            this.BillNo,
            this.Category,
            this.SubCategory,
            this.Size,
            this.Quantity});
            this.dgv_stock.Location = new System.Drawing.Point(0, 233);
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.ReadOnly = true;
            this.dgv_stock.Size = new System.Drawing.Size(740, 303);
            this.dgv_stock.TabIndex = 0;
            // 
            // bttn_Close
            // 
            this.bttn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Close.Location = new System.Drawing.Point(636, 10);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(75, 24);
            this.bttn_Close.TabIndex = 1;
            this.bttn_Close.Text = "Close";
            this.bttn_Close.UseVisualStyleBackColor = true;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.Crimson;
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 558);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(744, 44);
            this.pnl_Bottom.TabIndex = 12;
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.SandyBrown;
            this.pnl_Top.Controls.Add(this.dtp_Date);
            this.pnl_Top.Controls.Add(this.lbl_Date);
            this.pnl_Top.Controls.Add(this.lbl_StockDetail);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(744, 44);
            this.pnl_Top.TabIndex = 13;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(607, 10);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(104, 22);
            this.dtp_Date.TabIndex = 10;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(553, 15);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(30, 13);
            this.lbl_Date.TabIndex = 9;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_StockDetail
            // 
            this.lbl_StockDetail.AutoSize = true;
            this.lbl_StockDetail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_StockDetail.ForeColor = System.Drawing.Color.White;
            this.lbl_StockDetail.Location = new System.Drawing.Point(317, 12);
            this.lbl_StockDetail.Name = "lbl_StockDetail";
            this.lbl_StockDetail.Size = new System.Drawing.Size(111, 19);
            this.lbl_StockDetail.TabIndex = 0;
            this.lbl_StockDetail.Text = "Stock Ledger";
            // 
            // bttn_Excel
            // 
            this.bttn_Excel.BackColor = System.Drawing.Color.Crimson;
            this.bttn_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Excel.ForeColor = System.Drawing.Color.White;
            this.bttn_Excel.Location = new System.Drawing.Point(505, 201);
            this.bttn_Excel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttn_Excel.Name = "bttn_Excel";
            this.bttn_Excel.Size = new System.Drawing.Size(104, 26);
            this.bttn_Excel.TabIndex = 11;
            this.bttn_Excel.Text = "Excel";
            this.bttn_Excel.UseVisualStyleBackColor = false;
            this.bttn_Excel.Click += new System.EventHandler(this.bttn_Excel_Click);
            // 
            // cmb_category
            // 
            this.cmb_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_category.DisplayMember = "category";
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(26, 162);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(163, 21);
            this.cmb_category.TabIndex = 14;
            this.cmb_category.ValueMember = "category";
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            // 
            // cmb_SubCategory
            // 
            this.cmb_SubCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_SubCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_SubCategory.DisplayMember = "SubCategory";
            this.cmb_SubCategory.FormattingEnabled = true;
            this.cmb_SubCategory.Location = new System.Drawing.Point(262, 162);
            this.cmb_SubCategory.Name = "cmb_SubCategory";
            this.cmb_SubCategory.Size = new System.Drawing.Size(163, 21);
            this.cmb_SubCategory.TabIndex = 15;
            this.cmb_SubCategory.ValueMember = "SubCategory";
            // 
            // bttn_Sort
            // 
            this.bttn_Sort.BackColor = System.Drawing.Color.DarkGreen;
            this.bttn_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Sort.ForeColor = System.Drawing.Color.White;
            this.bttn_Sort.Location = new System.Drawing.Point(139, 201);
            this.bttn_Sort.Name = "bttn_Sort";
            this.bttn_Sort.Size = new System.Drawing.Size(104, 26);
            this.bttn_Sort.TabIndex = 16;
            this.bttn_Sort.Text = "Sort";
            this.bttn_Sort.UseVisualStyleBackColor = false;
            this.bttn_Sort.Click += new System.EventHandler(this.bttn_Sort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "SubCategory";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(321, 201);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(104, 26);
            this.btn_reset.TabIndex = 19;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "From";
            // 
            // dtp_To
            // 
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_To.Location = new System.Drawing.Point(170, 103);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(115, 20);
            this.dtp_To.TabIndex = 22;
            // 
            // dtp_from
            // 
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(26, 103);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(110, 20);
            this.dtp_from.TabIndex = 23;
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // BillNo
            // 
            this.BillNo.HeaderText = "BillNo";
            this.BillNo.Name = "BillNo";
            this.BillNo.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // SubCategory
            // 
            this.SubCategory.HeaderText = "SubCategory";
            this.SubCategory.Name = "SubCategory";
            this.SubCategory.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // frm_StockLedger
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(744, 602);
            this.Controls.Add(this.dtp_from);
            this.Controls.Add(this.dtp_To);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttn_Sort);
            this.Controls.Add(this.cmb_SubCategory);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.bttn_Excel);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.dgv_stock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_StockLedger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.frm_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_stock;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label lbl_StockDetail;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Button bttn_Excel;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.ComboBox cmb_SubCategory;
        private System.Windows.Forms.Button bttn_Sort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}