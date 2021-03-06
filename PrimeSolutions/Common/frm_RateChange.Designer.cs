﻿namespace PrimeSolutions.Common
{
    partial class frm_RateChange
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NewRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Button();
            this.cmb_size = new System.Windows.Forms.ComboBox();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.cmb_SubCategory = new System.Windows.Forms.ComboBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_SubCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_OldRate = new System.Windows.Forms.Label();
            this.lbl_OldGST = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NewGST = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(526, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Stock";
            // 
            // txt_NewRate
            // 
            this.txt_NewRate.Location = new System.Drawing.Point(105, 95);
            this.txt_NewRate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NewRate.Name = "txt_NewRate";
            this.txt_NewRate.Size = new System.Drawing.Size(85, 22);
            this.txt_NewRate.TabIndex = 28;
            this.txt_NewRate.TextChanged += new System.EventHandler(this.txt_Rate_TextChanged);
            this.txt_NewRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Rate_KeyDown);
            this.txt_NewRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Rate_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(19, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "New Rate";
            // 
            // btn_Change
            // 
            this.btn_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.Location = new System.Drawing.Point(290, 139);
            this.btn_Change.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(95, 27);
            this.btn_Change.TabIndex = 29;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = false;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // cmb_size
            // 
            this.cmb_size.AllowDrop = true;
            this.cmb_size.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_size.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_size.DisplayMember = "Size";
            this.cmb_size.FormattingEnabled = true;
            this.cmb_size.Location = new System.Drawing.Point(576, 15);
            this.cmb_size.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(71, 24);
            this.cmb_size.TabIndex = 58;
            this.cmb_size.ValueMember = "Size";
            this.cmb_size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_size_KeyDown);
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Size.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Size.Location = new System.Drawing.Point(526, 19);
            this.lbl_Size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(38, 16);
            this.lbl_Size.TabIndex = 57;
            this.lbl_Size.Text = "Size";
            // 
            // cmb_SubCategory
            // 
            this.cmb_SubCategory.AllowDrop = true;
            this.cmb_SubCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_SubCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_SubCategory.DisplayMember = "subcategory";
            this.cmb_SubCategory.FormattingEnabled = true;
            this.cmb_SubCategory.Location = new System.Drawing.Point(368, 15);
            this.cmb_SubCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_SubCategory.Name = "cmb_SubCategory";
            this.cmb_SubCategory.Size = new System.Drawing.Size(146, 24);
            this.cmb_SubCategory.TabIndex = 56;
            this.cmb_SubCategory.ValueMember = "SubCategory";
            this.cmb_SubCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SubCategory_SelectedIndexChanged);
            this.cmb_SubCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_SubCategory_KeyDown);
            // 
            // cmb_Category
            // 
            this.cmb_Category.AllowDrop = true;
            this.cmb_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Category.DisplayMember = "Category";
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(100, 15);
            this.cmb_Category.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(146, 24);
            this.cmb_Category.TabIndex = 55;
            this.cmb_Category.ValueMember = "Category";
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            this.cmb_Category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Category_KeyDown);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Category.Location = new System.Drawing.Point(17, 19);
            this.lbl_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(71, 16);
            this.lbl_Category.TabIndex = 53;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_SubCategory
            // 
            this.lbl_SubCategory.AutoSize = true;
            this.lbl_SubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubCategory.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_SubCategory.Location = new System.Drawing.Point(259, 19);
            this.lbl_SubCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SubCategory.Name = "lbl_SubCategory";
            this.lbl_SubCategory.Size = new System.Drawing.Size(98, 16);
            this.lbl_SubCategory.TabIndex = 54;
            this.lbl_SubCategory.Text = "SubCategory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(606, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Old Rate";
            // 
            // lbl_OldRate
            // 
            this.lbl_OldRate.AutoSize = true;
            this.lbl_OldRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OldRate.ForeColor = System.Drawing.Color.Black;
            this.lbl_OldRate.Location = new System.Drawing.Point(95, 61);
            this.lbl_OldRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OldRate.Name = "lbl_OldRate";
            this.lbl_OldRate.Size = new System.Drawing.Size(18, 16);
            this.lbl_OldRate.TabIndex = 61;
            this.lbl_OldRate.Text = "--";
            // 
            // lbl_OldGST
            // 
            this.lbl_OldGST.AutoSize = true;
            this.lbl_OldGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OldGST.ForeColor = System.Drawing.Color.Black;
            this.lbl_OldGST.Location = new System.Drawing.Point(335, 61);
            this.lbl_OldGST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OldGST.Name = "lbl_OldGST";
            this.lbl_OldGST.Size = new System.Drawing.Size(18, 16);
            this.lbl_OldGST.TabIndex = 63;
            this.lbl_OldGST.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(259, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "Old GST";
            // 
            // txt_NewGST
            // 
            this.txt_NewGST.Location = new System.Drawing.Point(339, 95);
            this.txt_NewGST.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NewGST.Name = "txt_NewGST";
            this.txt_NewGST.Size = new System.Drawing.Size(85, 22);
            this.txt_NewGST.TabIndex = 65;
            this.txt_NewGST.TextChanged += new System.EventHandler(this.txt_NewGST_TextChanged);
            this.txt_NewGST.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NewGST_KeyDown);
            this.txt_NewGST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NewGST_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(259, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 64;
            this.label7.Text = "New GST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(198, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(432, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 67;
            this.label8.Text = "*";
            // 
            // frm_RateChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(663, 183);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NewGST);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_OldGST);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_OldRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_size);
            this.Controls.Add(this.lbl_Size);
            this.Controls.Add(this.cmb_SubCategory);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_SubCategory);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.txt_NewRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_RateChange";
            this.Text = "Fix Rate";
            this.Load += new System.EventHandler(this.Fix_Rate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NewRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.ComboBox cmb_size;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.ComboBox cmb_SubCategory;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_SubCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_OldRate;
        private System.Windows.Forms.Label lbl_OldGST;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_NewGST;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}