namespace PrimeSolutions.Common
{
    partial class Uc_MultiItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_item
            // 
            this.dgv_item.AllowUserToAddRows = false;
            this.dgv_item.AllowUserToDeleteRows = false;
            this.dgv_item.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.SubCategory,
            this.Price});
            this.dgv_item.Location = new System.Drawing.Point(10, 39);
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.ReadOnly = true;
            this.dgv_item.Size = new System.Drawing.Size(413, 309);
            this.dgv_item.TabIndex = 0;
            // 
            // Category
            // 
            this.Category.FillWeight = 120F;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 120;
            // 
            // SubCategory
            // 
            this.SubCategory.FillWeight = 150F;
            this.SubCategory.HeaderText = "SubCategory";
            this.SubCategory.Name = "SubCategory";
            this.SubCategory.ReadOnly = true;
            this.SubCategory.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(172, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Item";
            // 
            // Uc_MultiItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_item);
            this.Name = "Uc_MultiItem";
            this.Size = new System.Drawing.Size(429, 355);
            this.Load += new System.EventHandler(this.Uc_MultiItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label1;
    }
}
