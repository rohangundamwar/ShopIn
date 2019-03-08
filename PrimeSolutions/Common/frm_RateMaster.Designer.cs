namespace PrimeSolutions.Common
{
    partial class frm_RateMaster
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
            this.dgv_Rate = new System.Windows.Forms.DataGridView();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.cmb_SubCategory = new System.Windows.Forms.ComboBox();
            this.cmb_Size = new System.Windows.Forms.ComboBox();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.lbl_Barcode = new System.Windows.Forms.Label();
            this.txt_Barcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GST = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_OldRAte = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_OldGSt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Rate
            // 
            this.dgv_Rate.AllowUserToAddRows = false;
            this.dgv_Rate.AllowUserToDeleteRows = false;
            this.dgv_Rate.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv_Rate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rate.Location = new System.Drawing.Point(12, 135);
            this.dgv_Rate.Name = "dgv_Rate";
            this.dgv_Rate.ReadOnly = true;
            this.dgv_Rate.Size = new System.Drawing.Size(744, 401);
            this.dgv_Rate.TabIndex = 0;
            this.dgv_Rate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Rate_CellClick);
            // 
            // cmb_Category
            // 
            this.cmb_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Category.DisplayMember = "Category";
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(254, 28);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(121, 21);
            this.cmb_Category.TabIndex = 1;
            this.cmb_Category.ValueMember = "Category";
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            this.cmb_Category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Category_KeyDown);
            // 
            // cmb_SubCategory
            // 
            this.cmb_SubCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_SubCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_SubCategory.DisplayMember = "SubCategory";
            this.cmb_SubCategory.FormattingEnabled = true;
            this.cmb_SubCategory.Location = new System.Drawing.Point(461, 28);
            this.cmb_SubCategory.Name = "cmb_SubCategory";
            this.cmb_SubCategory.Size = new System.Drawing.Size(175, 21);
            this.cmb_SubCategory.TabIndex = 2;
            this.cmb_SubCategory.ValueMember = "SubCategory";
            this.cmb_SubCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SubCategory_SelectedIndexChanged);
            this.cmb_SubCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_SubCategory_KeyDown);
            // 
            // cmb_Size
            // 
            this.cmb_Size.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Size.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Size.DisplayMember = "Size";
            this.cmb_Size.FormattingEnabled = true;
            this.cmb_Size.Location = new System.Drawing.Point(681, 28);
            this.cmb_Size.Name = "cmb_Size";
            this.cmb_Size.Size = new System.Drawing.Size(66, 21);
            this.cmb_Size.TabIndex = 3;
            this.cmb_Size.ValueMember = "Size";
            this.cmb_Size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Size_KeyDown);
            // 
            // txt_Rate
            // 
            this.txt_Rate.Location = new System.Drawing.Point(254, 74);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(100, 20);
            this.txt_Rate.TabIndex = 4;
            // 
            // lbl_Barcode
            // 
            this.lbl_Barcode.AutoSize = true;
            this.lbl_Barcode.Location = new System.Drawing.Point(8, 32);
            this.lbl_Barcode.Name = "lbl_Barcode";
            this.lbl_Barcode.Size = new System.Drawing.Size(47, 13);
            this.lbl_Barcode.TabIndex = 5;
            this.lbl_Barcode.Text = "Barcode";
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.Location = new System.Drawing.Point(64, 28);
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.Size = new System.Drawing.Size(123, 20);
            this.txt_Barcode.TabIndex = 6;
            this.txt_Barcode.TextChanged += new System.EventHandler(this.txt_Barcode_TextChanged);
            this.txt_Barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Barcode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SubCategory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(645, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "New Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "New GST";
            // 
            // txt_GST
            // 
            this.txt_GST.Location = new System.Drawing.Point(635, 74);
            this.txt_GST.Name = "txt_GST";
            this.txt_GST.Size = new System.Drawing.Size(100, 20);
            this.txt_GST.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Old GST";
            // 
            // lbl_OldRAte
            // 
            this.lbl_OldRAte.AutoSize = true;
            this.lbl_OldRAte.Location = new System.Drawing.Point(118, 78);
            this.lbl_OldRAte.Name = "lbl_OldRAte";
            this.lbl_OldRAte.Size = new System.Drawing.Size(13, 13);
            this.lbl_OldRAte.TabIndex = 14;
            this.lbl_OldRAte.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Old Rate";
            // 
            // lbl_OldGSt
            // 
            this.lbl_OldGSt.AutoSize = true;
            this.lbl_OldGSt.Location = new System.Drawing.Point(520, 78);
            this.lbl_OldGSt.Name = "lbl_OldGSt";
            this.lbl_OldGSt.Size = new System.Drawing.Size(13, 13);
            this.lbl_OldGSt.TabIndex = 16;
            this.lbl_OldGSt.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(347, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_RateMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(766, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_OldGSt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_OldRAte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_GST);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Barcode);
            this.Controls.Add(this.lbl_Barcode);
            this.Controls.Add(this.txt_Rate);
            this.Controls.Add(this.cmb_Size);
            this.Controls.Add(this.cmb_SubCategory);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.dgv_Rate);
            this.Name = "frm_RateMaster";
            this.Text = "Rate Master";
            this.Load += new System.EventHandler(this.frm_RateMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Rate;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.ComboBox cmb_SubCategory;
        private System.Windows.Forms.ComboBox cmb_Size;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.Label lbl_Barcode;
        private System.Windows.Forms.TextBox txt_Barcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_GST;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_OldRAte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_OldGSt;
        private System.Windows.Forms.Button button1;
    }
}