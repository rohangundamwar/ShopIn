namespace PrimeSolutions.Common
{
    partial class frm_Offer
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
            this.dgv_Offers = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_DiscPer = new System.Windows.Forms.TextBox();
            this.txt_MinQty = new System.Windows.Forms.TextBox();
            this.txt_Comment = new System.Windows.Forms.TextBox();
            this.lbl_DiscPer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bttn_add = new System.Windows.Forms.Button();
            this.Bttn_Update = new System.Windows.Forms.Button();
            this.bttn_delete = new System.Windows.Forms.Button();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_SubCategory = new System.Windows.Forms.ComboBox();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.cmb_Size = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Sr = new System.Windows.Forms.Label();
            this.lbl_SrNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Offers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Offers
            // 
            this.dgv_Offers.AllowUserToAddRows = false;
            this.dgv_Offers.AllowUserToDeleteRows = false;
            this.dgv_Offers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Offers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Offers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.Category,
            this.SubCategory,
            this.Size,
            this.DiscPer,
            this.MinQty,
            this.Comment});
            this.dgv_Offers.Location = new System.Drawing.Point(12, 155);
            this.dgv_Offers.Name = "dgv_Offers";
            this.dgv_Offers.ReadOnly = true;
            this.dgv_Offers.Size = new System.Drawing.Size(844, 255);
            this.dgv_Offers.TabIndex = 0;
            this.dgv_Offers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // SrNo
            // 
            this.SrNo.FillWeight = 50F;
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            this.SrNo.Width = 50;
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
            // DiscPer
            // 
            this.DiscPer.HeaderText = "DiscPer";
            this.DiscPer.Name = "DiscPer";
            this.DiscPer.ReadOnly = true;
            // 
            // MinQty
            // 
            this.MinQty.HeaderText = "MinQty";
            this.MinQty.Name = "MinQty";
            this.MinQty.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.FillWeight = 250F;
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 250;
            // 
            // txt_DiscPer
            // 
            this.txt_DiscPer.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_DiscPer.Location = new System.Drawing.Point(87, 75);
            this.txt_DiscPer.Name = "txt_DiscPer";
            this.txt_DiscPer.Size = new System.Drawing.Size(100, 20);
            this.txt_DiscPer.TabIndex = 1;
            this.txt_DiscPer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_DiscPer_KeyDown);
            // 
            // txt_MinQty
            // 
            this.txt_MinQty.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_MinQty.Location = new System.Drawing.Point(263, 75);
            this.txt_MinQty.Name = "txt_MinQty";
            this.txt_MinQty.Size = new System.Drawing.Size(100, 20);
            this.txt_MinQty.TabIndex = 2;
            this.txt_MinQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MinQty_KeyDown);
            // 
            // txt_Comment
            // 
            this.txt_Comment.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Comment.Location = new System.Drawing.Point(459, 75);
            this.txt_Comment.Name = "txt_Comment";
            this.txt_Comment.Size = new System.Drawing.Size(396, 20);
            this.txt_Comment.TabIndex = 3;
            this.txt_Comment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Comment_KeyDown);
            // 
            // lbl_DiscPer
            // 
            this.lbl_DiscPer.AutoSize = true;
            this.lbl_DiscPer.Location = new System.Drawing.Point(12, 79);
            this.lbl_DiscPer.Name = "lbl_DiscPer";
            this.lbl_DiscPer.Size = new System.Drawing.Size(60, 13);
            this.lbl_DiscPer.TabIndex = 4;
            this.lbl_DiscPer.Text = "Discount %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Min. Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Comment or \r\nOffer Details";
            // 
            // Bttn_add
            // 
            this.Bttn_add.ForeColor = System.Drawing.Color.Green;
            this.Bttn_add.Location = new System.Drawing.Point(12, 116);
            this.Bttn_add.Name = "Bttn_add";
            this.Bttn_add.Size = new System.Drawing.Size(75, 23);
            this.Bttn_add.TabIndex = 7;
            this.Bttn_add.Text = "Add";
            this.Bttn_add.UseVisualStyleBackColor = true;
            this.Bttn_add.Click += new System.EventHandler(this.Bttn_add_Click);
            // 
            // Bttn_Update
            // 
            this.Bttn_Update.ForeColor = System.Drawing.Color.Blue;
            this.Bttn_Update.Location = new System.Drawing.Point(268, 116);
            this.Bttn_Update.Name = "Bttn_Update";
            this.Bttn_Update.Size = new System.Drawing.Size(75, 23);
            this.Bttn_Update.TabIndex = 8;
            this.Bttn_Update.Text = "Update";
            this.Bttn_Update.UseVisualStyleBackColor = true;
            // 
            // bttn_delete
            // 
            this.bttn_delete.ForeColor = System.Drawing.Color.Orange;
            this.bttn_delete.Location = new System.Drawing.Point(524, 116);
            this.bttn_delete.Name = "bttn_delete";
            this.bttn_delete.Size = new System.Drawing.Size(75, 23);
            this.bttn_delete.TabIndex = 9;
            this.bttn_delete.Text = "Delete";
            this.bttn_delete.UseVisualStyleBackColor = true;
            this.bttn_delete.Click += new System.EventHandler(this.bttn_delete_Click);
            // 
            // bttn_Close
            // 
            this.bttn_Close.ForeColor = System.Drawing.Color.Red;
            this.bttn_Close.Location = new System.Drawing.Point(780, 116);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(75, 23);
            this.bttn_Close.TabIndex = 10;
            this.bttn_Close.Text = "Close";
            this.bttn_Close.UseVisualStyleBackColor = true;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "SubCategory";
            // 
            // cmb_SubCategory
            // 
            this.cmb_SubCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_SubCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_SubCategory.DisplayMember = "SubCategory";
            this.cmb_SubCategory.FormattingEnabled = true;
            this.cmb_SubCategory.Location = new System.Drawing.Point(365, 27);
            this.cmb_SubCategory.Name = "cmb_SubCategory";
            this.cmb_SubCategory.Size = new System.Drawing.Size(166, 21);
            this.cmb_SubCategory.TabIndex = 13;
            this.cmb_SubCategory.ValueMember = "SubCategory";
            this.cmb_SubCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SubCategory_SelectedIndexChanged);
            this.cmb_SubCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_SubCategory_KeyDown);
            // 
            // cmb_category
            // 
            this.cmb_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_category.DisplayMember = "Category";
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(92, 27);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(149, 21);
            this.cmb_category.TabIndex = 14;
            this.cmb_category.ValueMember = "Category";
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            this.cmb_category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_category_KeyDown);
            // 
            // cmb_Size
            // 
            this.cmb_Size.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Size.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Size.DisplayMember = "Size";
            this.cmb_Size.FormattingEnabled = true;
            this.cmb_Size.Location = new System.Drawing.Point(614, 27);
            this.cmb_Size.Name = "cmb_Size";
            this.cmb_Size.Size = new System.Drawing.Size(84, 21);
            this.cmb_Size.TabIndex = 16;
            this.cmb_Size.ValueMember = "Size";
            this.cmb_Size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Size_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Size";
            // 
            // lbl_Sr
            // 
            this.lbl_Sr.AutoSize = true;
            this.lbl_Sr.Location = new System.Drawing.Point(725, 31);
            this.lbl_Sr.Name = "lbl_Sr";
            this.lbl_Sr.Size = new System.Drawing.Size(31, 13);
            this.lbl_Sr.TabIndex = 17;
            this.lbl_Sr.Text = "SrNo";
            // 
            // lbl_SrNo
            // 
            this.lbl_SrNo.AutoSize = true;
            this.lbl_SrNo.Location = new System.Drawing.Point(810, 31);
            this.lbl_SrNo.Name = "lbl_SrNo";
            this.lbl_SrNo.Size = new System.Drawing.Size(13, 13);
            this.lbl_SrNo.TabIndex = 18;
            this.lbl_SrNo.Text = "--";
            // 
            // frm_Offer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 419);
            this.Controls.Add(this.lbl_SrNo);
            this.Controls.Add(this.lbl_Sr);
            this.Controls.Add(this.cmb_Size);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.cmb_SubCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttn_Close);
            this.Controls.Add(this.bttn_delete);
            this.Controls.Add(this.Bttn_Update);
            this.Controls.Add(this.Bttn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_DiscPer);
            this.Controls.Add(this.txt_Comment);
            this.Controls.Add(this.txt_MinQty);
            this.Controls.Add(this.txt_DiscPer);
            this.Controls.Add(this.dgv_Offers);
            this.Name = "frm_Offer";
            this.Text = "Offers";
            this.Load += new System.EventHandler(this.frm_Offer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Offers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Offers;
        private System.Windows.Forms.TextBox txt_DiscPer;
        private System.Windows.Forms.TextBox txt_MinQty;
        private System.Windows.Forms.TextBox txt_Comment;
        private System.Windows.Forms.Label lbl_DiscPer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Bttn_add;
        private System.Windows.Forms.Button Bttn_Update;
        private System.Windows.Forms.Button bttn_delete;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_SubCategory;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.ComboBox cmb_Size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.Label lbl_Sr;
        private System.Windows.Forms.Label lbl_SrNo;
    }
}