namespace PrimeSolutions.Common
{
    partial class frm_BarcodePrint
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
            this.pnl_Date = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bttn_Reset = new System.Windows.Forms.Button();
            this.bttn_Delete = new System.Windows.Forms.Button();
            this.txt_GST = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.txt_SellingPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Size = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_SubCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Ref = new System.Windows.Forms.Label();
            this.txt_Refrence = new System.Windows.Forms.Label();
            this.bttn_BillNoView = new System.Windows.Forms.Button();
            this.lbl_BillNo = new System.Windows.Forms.Label();
            this.lbl_Supplier = new System.Windows.Forms.Label();
            this.cmb_Supplier = new System.Windows.Forms.ComboBox();
            this.cmb_PBillNo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bttn_Print = new System.Windows.Forms.Button();
            this.dgv_BarcodeDetail = new System.Windows.Forms.DataGridView();
            this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Date.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BarcodeDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Date
            // 
            this.pnl_Date.BackColor = System.Drawing.Color.Moccasin;
            this.pnl_Date.Controls.Add(this.groupBox2);
            this.pnl_Date.Controls.Add(this.groupBox1);
            this.pnl_Date.Controls.Add(this.button1);
            this.pnl_Date.Controls.Add(this.bttn_Print);
            this.pnl_Date.Location = new System.Drawing.Point(4, 4);
            this.pnl_Date.Name = "pnl_Date";
            this.pnl_Date.Size = new System.Drawing.Size(846, 511);
            this.pnl_Date.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Qty);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.bttn_Reset);
            this.groupBox2.Controls.Add(this.bttn_Delete);
            this.groupBox2.Controls.Add(this.txt_GST);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.bttn_Add);
            this.groupBox2.Controls.Add(this.cmb_category);
            this.groupBox2.Controls.Add(this.txt_SellingPrice);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmb_Size);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmb_SubCategory);
            this.groupBox2.Location = new System.Drawing.Point(8, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 147);
            this.groupBox2.TabIndex = 370;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Barcode Entry";
            // 
            // txt_Qty
            // 
            this.txt_Qty.Location = new System.Drawing.Point(390, 66);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(66, 20);
            this.txt_Qty.TabIndex = 376;
            this.txt_Qty.Text = " 1";
            this.txt_Qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Qty_KeyDown);
            this.txt_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qty_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 375;
            this.label6.Text = "Qty";
            // 
            // bttn_Reset
            // 
            this.bttn_Reset.BackColor = System.Drawing.Color.MidnightBlue;
            this.bttn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bttn_Reset.ForeColor = System.Drawing.Color.White;
            this.bttn_Reset.Location = new System.Drawing.Point(435, 105);
            this.bttn_Reset.Name = "bttn_Reset";
            this.bttn_Reset.Size = new System.Drawing.Size(79, 29);
            this.bttn_Reset.TabIndex = 374;
            this.bttn_Reset.Text = "Reset";
            this.bttn_Reset.UseVisualStyleBackColor = false;
            this.bttn_Reset.Click += new System.EventHandler(this.bttn_Reset_Click);
            // 
            // bttn_Delete
            // 
            this.bttn_Delete.BackColor = System.Drawing.Color.Red;
            this.bttn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bttn_Delete.ForeColor = System.Drawing.Color.White;
            this.bttn_Delete.Location = new System.Drawing.Point(274, 105);
            this.bttn_Delete.Name = "bttn_Delete";
            this.bttn_Delete.Size = new System.Drawing.Size(79, 29);
            this.bttn_Delete.TabIndex = 373;
            this.bttn_Delete.Text = "Delete";
            this.bttn_Delete.UseVisualStyleBackColor = false;
            this.bttn_Delete.Click += new System.EventHandler(this.bttn_Delete_Click);
            // 
            // txt_GST
            // 
            this.txt_GST.Location = new System.Drawing.Point(509, 66);
            this.txt_GST.Name = "txt_GST";
            this.txt_GST.Size = new System.Drawing.Size(71, 20);
            this.txt_GST.TabIndex = 372;
            this.txt_GST.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_GST_KeyDown);
            this.txt_GST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GST_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 371;
            this.label5.Text = "GST";
            // 
            // bttn_Add
            // 
            this.bttn_Add.BackColor = System.Drawing.Color.Green;
            this.bttn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bttn_Add.ForeColor = System.Drawing.Color.White;
            this.bttn_Add.Location = new System.Drawing.Point(96, 105);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(79, 29);
            this.bttn_Add.TabIndex = 370;
            this.bttn_Add.Text = "Add";
            this.bttn_Add.UseVisualStyleBackColor = false;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // cmb_category
            // 
            this.cmb_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_category.DisplayMember = "Category";
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(86, 29);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(191, 21);
            this.cmb_category.TabIndex = 361;
            this.cmb_category.ValueMember = "Category";
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            this.cmb_category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_category_KeyDown);
            // 
            // txt_SellingPrice
            // 
            this.txt_SellingPrice.Location = new System.Drawing.Point(232, 66);
            this.txt_SellingPrice.Name = "txt_SellingPrice";
            this.txt_SellingPrice.Size = new System.Drawing.Size(111, 20);
            this.txt_SellingPrice.TabIndex = 369;
            this.txt_SellingPrice.Text = " 0.0";
            this.txt_SellingPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SellingPrice_KeyDown);
            this.txt_SellingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SellingPrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 362;
            this.label1.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 368;
            this.label4.Text = "Price";
            // 
            // cmb_Size
            // 
            this.cmb_Size.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Size.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Size.DisplayMember = "Size";
            this.cmb_Size.FormattingEnabled = true;
            this.cmb_Size.Location = new System.Drawing.Point(86, 66);
            this.cmb_Size.Name = "cmb_Size";
            this.cmb_Size.Size = new System.Drawing.Size(92, 21);
            this.cmb_Size.TabIndex = 363;
            this.cmb_Size.ValueMember = "Size";
            this.cmb_Size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Size_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 366;
            this.label3.Text = "SubCategory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 364;
            this.label2.Text = "Size";
            // 
            // cmb_SubCategory
            // 
            this.cmb_SubCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_SubCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_SubCategory.DisplayMember = "SubCategory";
            this.cmb_SubCategory.FormattingEnabled = true;
            this.cmb_SubCategory.Location = new System.Drawing.Point(389, 29);
            this.cmb_SubCategory.Name = "cmb_SubCategory";
            this.cmb_SubCategory.Size = new System.Drawing.Size(191, 21);
            this.cmb_SubCategory.TabIndex = 365;
            this.cmb_SubCategory.ValueMember = "SubCategory";
            this.cmb_SubCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SubCategory_SelectedIndexChanged);
            this.cmb_SubCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_SubCategory_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Ref);
            this.groupBox1.Controls.Add(this.txt_Refrence);
            this.groupBox1.Controls.Add(this.bttn_BillNoView);
            this.groupBox1.Controls.Add(this.lbl_BillNo);
            this.groupBox1.Controls.Add(this.lbl_Supplier);
            this.groupBox1.Controls.Add(this.cmb_Supplier);
            this.groupBox1.Controls.Add(this.cmb_PBillNo);
            this.groupBox1.Location = new System.Drawing.Point(629, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 149);
            this.groupBox1.TabIndex = 360;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Old Bill";
            // 
            // lbl_Ref
            // 
            this.lbl_Ref.AutoSize = true;
            this.lbl_Ref.Location = new System.Drawing.Point(114, 67);
            this.lbl_Ref.Name = "lbl_Ref";
            this.lbl_Ref.Size = new System.Drawing.Size(68, 13);
            this.lbl_Ref.TabIndex = 361;
            this.lbl_Ref.Text = "Refrence No";
            // 
            // txt_Refrence
            // 
            this.txt_Refrence.AutoSize = true;
            this.txt_Refrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Refrence.ForeColor = System.Drawing.Color.Red;
            this.txt_Refrence.Location = new System.Drawing.Point(114, 90);
            this.txt_Refrence.Name = "txt_Refrence";
            this.txt_Refrence.Size = new System.Drawing.Size(15, 13);
            this.txt_Refrence.TabIndex = 360;
            this.txt_Refrence.Text = "--";
            // 
            // bttn_BillNoView
            // 
            this.bttn_BillNoView.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_BillNoView.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bttn_BillNoView.Location = new System.Drawing.Point(46, 115);
            this.bttn_BillNoView.Name = "bttn_BillNoView";
            this.bttn_BillNoView.Size = new System.Drawing.Size(112, 23);
            this.bttn_BillNoView.TabIndex = 353;
            this.bttn_BillNoView.Text = "BillNo Wise View";
            this.bttn_BillNoView.UseVisualStyleBackColor = true;
            this.bttn_BillNoView.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_BillNo
            // 
            this.lbl_BillNo.AutoSize = true;
            this.lbl_BillNo.Location = new System.Drawing.Point(17, 67);
            this.lbl_BillNo.Name = "lbl_BillNo";
            this.lbl_BillNo.Size = new System.Drawing.Size(37, 13);
            this.lbl_BillNo.TabIndex = 359;
            this.lbl_BillNo.Text = "Bill No";
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.Location = new System.Drawing.Point(17, 21);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(76, 13);
            this.lbl_Supplier.TabIndex = 358;
            this.lbl_Supplier.Text = "Supplier Name";
            // 
            // cmb_Supplier
            // 
            this.cmb_Supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Supplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Supplier.DisplayMember = "Name";
            this.cmb_Supplier.FormattingEnabled = true;
            this.cmb_Supplier.Location = new System.Drawing.Point(17, 40);
            this.cmb_Supplier.Name = "cmb_Supplier";
            this.cmb_Supplier.Size = new System.Drawing.Size(173, 21);
            this.cmb_Supplier.TabIndex = 357;
            this.cmb_Supplier.ValueMember = "Name";
            this.cmb_Supplier.SelectedIndexChanged += new System.EventHandler(this.cmb_Supplier_SelectedIndexChanged);
            // 
            // cmb_PBillNo
            // 
            this.cmb_PBillNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_PBillNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_PBillNo.DisplayMember = "BillNo";
            this.cmb_PBillNo.FormattingEnabled = true;
            this.cmb_PBillNo.Location = new System.Drawing.Point(17, 86);
            this.cmb_PBillNo.Name = "cmb_PBillNo";
            this.cmb_PBillNo.Size = new System.Drawing.Size(80, 21);
            this.cmb_PBillNo.TabIndex = 354;
            this.cmb_PBillNo.ValueMember = "BillNo";
            this.cmb_PBillNo.SelectedIndexChanged += new System.EventHandler(this.cmb_PBillNo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(465, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 356;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bttn_Print
            // 
            this.bttn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Print.ForeColor = System.Drawing.Color.Green;
            this.bttn_Print.Location = new System.Drawing.Point(302, 475);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(75, 25);
            this.bttn_Print.TabIndex = 355;
            this.bttn_Print.Text = "Print";
            this.bttn_Print.UseVisualStyleBackColor = true;
            this.bttn_Print.Click += new System.EventHandler(this.bttn_Print_Click);
            // 
            // dgv_BarcodeDetail
            // 
            this.dgv_BarcodeDetail.AllowUserToAddRows = false;
            this.dgv_BarcodeDetail.AllowUserToDeleteRows = false;
            this.dgv_BarcodeDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BarcodeDetail.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_BarcodeDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BarcodeDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chk,
            this.SrNo,
            this.Barcode,
            this.Category,
            this.SubCategory,
            this.SellingAmt,
            this.Size,
            this.Qty});
            this.dgv_BarcodeDetail.Location = new System.Drawing.Point(3, 167);
            this.dgv_BarcodeDetail.Name = "dgv_BarcodeDetail";
            this.dgv_BarcodeDetail.Size = new System.Drawing.Size(847, 300);
            this.dgv_BarcodeDetail.TabIndex = 1;
            this.dgv_BarcodeDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BarcodeDetail_CellContentClick);
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
            // SrNo
            // 
            this.SrNo.FillWeight = 85.27919F;
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.FillWeight = 85.27919F;
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.FillWeight = 85.27919F;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // SubCategory
            // 
            this.SubCategory.FillWeight = 85.27919F;
            this.SubCategory.HeaderText = "SubCategory";
            this.SubCategory.Name = "SubCategory";
            this.SubCategory.ReadOnly = true;
            // 
            // SellingAmt
            // 
            this.SellingAmt.FillWeight = 85.27919F;
            this.SellingAmt.HeaderText = "SellingAmt";
            this.SellingAmt.Name = "SellingAmt";
            this.SellingAmt.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.FillWeight = 85.27919F;
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.FillWeight = 85.27919F;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // frm_BarcodePrint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(854, 519);
            this.Controls.Add(this.dgv_BarcodeDetail);
            this.Controls.Add(this.pnl_Date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frm_BarcodePrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Print";
            this.Load += new System.EventHandler(this.frm_BarcodePrint_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_BarcodePrint_KeyDown);
            this.pnl_Date.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BarcodeDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Date;
        private System.Windows.Forms.DataGridView dgv_BarcodeDetail;
        private System.Windows.Forms.Button bttn_BillNoView;
        private System.Windows.Forms.ComboBox cmb_PBillNo;
        private System.Windows.Forms.Button bttn_Print;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_BillNo;
        private System.Windows.Forms.Label lbl_Supplier;
        private System.Windows.Forms.ComboBox cmb_Supplier;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.TextBox txt_SellingPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_SubCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.TextBox txt_GST;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttn_Delete;
        private System.Windows.Forms.Button bttn_Reset;
        private System.Windows.Forms.TextBox txt_Qty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.Label lbl_Ref;
        private System.Windows.Forms.Label txt_Refrence;
    }
}