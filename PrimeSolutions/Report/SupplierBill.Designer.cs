﻿namespace PrimeSolutions.Report
{
    partial class SupplierBill
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
            this.dgv_BillItem = new System.Windows.Forms.DataGridView();
            this.cmb_BillNo = new System.Windows.Forms.ComboBox();
            this.lbl_BillNo = new System.Windows.Forms.Label();
            this.bttn_close = new System.Windows.Forms.Button();
            this.bttn_Excel = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.cmb_Name = new System.Windows.Forms.ComboBox();
            this.lbl_PurchaseFrom = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BillItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_BillItem
            // 
            this.dgv_BillItem.AllowUserToDeleteRows = false;
            this.dgv_BillItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BillItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.SubCategory,
            this.Size,
            this.Quantity});
            this.dgv_BillItem.Location = new System.Drawing.Point(14, 110);
            this.dgv_BillItem.Name = "dgv_BillItem";
            this.dgv_BillItem.ReadOnly = true;
            this.dgv_BillItem.Size = new System.Drawing.Size(513, 288);
            this.dgv_BillItem.TabIndex = 0;
            // 
            // cmb_BillNo
            // 
            this.cmb_BillNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_BillNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_BillNo.DisplayMember = "BillNo";
            this.cmb_BillNo.FormattingEnabled = true;
            this.cmb_BillNo.Location = new System.Drawing.Point(383, 71);
            this.cmb_BillNo.Name = "cmb_BillNo";
            this.cmb_BillNo.Size = new System.Drawing.Size(121, 21);
            this.cmb_BillNo.TabIndex = 1;
            this.cmb_BillNo.ValueMember = "BillNo";
            this.cmb_BillNo.SelectedIndexChanged += new System.EventHandler(this.cmb_BillNo_SelectedIndexChanged);
            // 
            // lbl_BillNo
            // 
            this.lbl_BillNo.AutoSize = true;
            this.lbl_BillNo.Location = new System.Drawing.Point(290, 75);
            this.lbl_BillNo.Name = "lbl_BillNo";
            this.lbl_BillNo.Size = new System.Drawing.Size(87, 13);
            this.lbl_BillNo.TabIndex = 2;
            this.lbl_BillNo.Text = "Supplier Bill No : ";
            // 
            // bttn_close
            // 
            this.bttn_close.BackColor = System.Drawing.Color.LightCoral;
            this.bttn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_close.ForeColor = System.Drawing.Color.White;
            this.bttn_close.Location = new System.Drawing.Point(429, 13);
            this.bttn_close.Name = "bttn_close";
            this.bttn_close.Size = new System.Drawing.Size(75, 23);
            this.bttn_close.TabIndex = 3;
            this.bttn_close.Text = "Close";
            this.bttn_close.UseVisualStyleBackColor = false;
            this.bttn_close.Click += new System.EventHandler(this.bttn_close_Click);
            // 
            // bttn_Excel
            // 
            this.bttn_Excel.Location = new System.Drawing.Point(273, 13);
            this.bttn_Excel.Name = "bttn_Excel";
            this.bttn_Excel.Size = new System.Drawing.Size(104, 23);
            this.bttn_Excel.TabIndex = 4;
            this.bttn_Excel.Text = "Export To Excel";
            this.bttn_Excel.UseVisualStyleBackColor = true;
            this.bttn_Excel.Click += new System.EventHandler(this.bttn_Excel_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(24, 12);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(120, 20);
            this.dtp_date.TabIndex = 5;
            // 
            // cmb_Name
            // 
            this.cmb_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Name.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_Name.DisplayMember = "Name";
            this.cmb_Name.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmb_Name.FormattingEnabled = true;
            this.cmb_Name.Location = new System.Drawing.Point(24, 72);
            this.cmb_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_Name.Name = "cmb_Name";
            this.cmb_Name.Size = new System.Drawing.Size(259, 21);
            this.cmb_Name.TabIndex = 7;
            this.cmb_Name.ValueMember = "Name";
            this.cmb_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Name_SelectedIndexChanged);
            // 
            // lbl_PurchaseFrom
            // 
            this.lbl_PurchaseFrom.AutoSize = true;
            this.lbl_PurchaseFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold);
            this.lbl_PurchaseFrom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_PurchaseFrom.Location = new System.Drawing.Point(24, 44);
            this.lbl_PurchaseFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PurchaseFrom.Name = "lbl_PurchaseFrom";
            this.lbl_PurchaseFrom.Size = new System.Drawing.Size(104, 15);
            this.lbl_PurchaseFrom.TabIndex = 6;
            this.lbl_PurchaseFrom.Text = "Purchase From";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 150;
            // 
            // SubCategory
            // 
            this.SubCategory.HeaderText = "SubCategory";
            this.SubCategory.Name = "SubCategory";
            this.SubCategory.ReadOnly = true;
            this.SubCategory.Width = 120;
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
            // SupplierBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 413);
            this.Controls.Add(this.cmb_Name);
            this.Controls.Add(this.lbl_PurchaseFrom);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.bttn_Excel);
            this.Controls.Add(this.bttn_close);
            this.Controls.Add(this.lbl_BillNo);
            this.Controls.Add(this.cmb_BillNo);
            this.Controls.Add(this.dgv_BillItem);
            this.KeyPreview = true;
            this.Name = "SupplierBill";
            this.Text = "SupplierBill";
            this.Load += new System.EventHandler(this.SupplierBill_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SupplierBill_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BillItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_BillItem;
        private System.Windows.Forms.ComboBox cmb_BillNo;
        private System.Windows.Forms.Label lbl_BillNo;
        private System.Windows.Forms.Button bttn_close;
        private System.Windows.Forms.Button bttn_Excel;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ComboBox cmb_Name;
        private System.Windows.Forms.Label lbl_PurchaseFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}