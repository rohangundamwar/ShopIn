namespace PrimeSolutions.Common
{
    partial class frm_Category
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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.lbl_SrNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Category = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.pnl_Button = new System.Windows.Forms.Panel();
            this.bttn_Delete = new System.Windows.Forms.Button();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).BeginInit();
            this.pnl_Button.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Top.Controls.Add(this.lbl_SrNo);
            this.pnl_Top.Controls.Add(this.label1);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(380, 46);
            this.pnl_Top.TabIndex = 1;
            // 
            // lbl_SrNo
            // 
            this.lbl_SrNo.AutoSize = true;
            this.lbl_SrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SrNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_SrNo.Location = new System.Drawing.Point(296, 15);
            this.lbl_SrNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SrNo.Name = "lbl_SrNo";
            this.lbl_SrNo.Size = new System.Drawing.Size(71, 16);
            this.lbl_SrNo.TabIndex = 12;
            this.lbl_SrNo.Text = "Category";
            this.lbl_SrNo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(95, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "CATEGORY MASTER";
            // 
            // dgv_Category
            // 
            this.dgv_Category.AllowUserToAddRows = false;
            this.dgv_Category.AllowUserToDeleteRows = false;
            this.dgv_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Category.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.Category});
            this.dgv_Category.Location = new System.Drawing.Point(0, 124);
            this.dgv_Category.Name = "dgv_Category";
            this.dgv_Category.ReadOnly = true;
            this.dgv_Category.Size = new System.Drawing.Size(380, 411);
            this.dgv_Category.TabIndex = 3;
            this.dgv_Category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Category_CellClick);
            // 
            // SrNo
            // 
            this.SrNo.FillWeight = 86.29442F;
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.FillWeight = 113.7056F;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // txt_Category
            // 
            this.txt_Category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Category.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Category.Location = new System.Drawing.Point(92, 54);
            this.txt_Category.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(275, 20);
            this.txt_Category.TabIndex = 11;
            this.txt_Category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Category_KeyDown);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Category.Location = new System.Drawing.Point(13, 54);
            this.lbl_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(71, 16);
            this.lbl_Category.TabIndex = 10;
            this.lbl_Category.Text = "Category";
            // 
            // pnl_Button
            // 
            this.pnl_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Button.Controls.Add(this.bttn_Delete);
            this.pnl_Button.Controls.Add(this.bttn_Update);
            this.pnl_Button.Controls.Add(this.bttn_Add);
            this.pnl_Button.Location = new System.Drawing.Point(0, 85);
            this.pnl_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(380, 38);
            this.pnl_Button.TabIndex = 22;
            // 
            // bttn_Delete
            // 
            this.bttn_Delete.ForeColor = System.Drawing.Color.Red;
            this.bttn_Delete.Location = new System.Drawing.Point(291, 5);
            this.bttn_Delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttn_Delete.Name = "bttn_Delete";
            this.bttn_Delete.Size = new System.Drawing.Size(76, 28);
            this.bttn_Delete.TabIndex = 16;
            this.bttn_Delete.Text = "Delete";
            this.bttn_Delete.UseVisualStyleBackColor = true;
            this.bttn_Delete.Click += new System.EventHandler(this.bttn_Delete_Click);
            // 
            // bttn_Update
            // 
            this.bttn_Update.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bttn_Update.Location = new System.Drawing.Point(151, 5);
            this.bttn_Update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttn_Update.Name = "bttn_Update";
            this.bttn_Update.Size = new System.Drawing.Size(76, 28);
            this.bttn_Update.TabIndex = 14;
            this.bttn_Update.Text = "Update";
            this.bttn_Update.UseVisualStyleBackColor = true;
            this.bttn_Update.Click += new System.EventHandler(this.bttn_Update_Click);
            // 
            // bttn_Add
            // 
            this.bttn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttn_Add.Location = new System.Drawing.Point(11, 5);
            this.bttn_Add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(76, 28);
            this.bttn_Add.TabIndex = 13;
            this.bttn_Add.Text = "Add";
            this.bttn_Add.UseVisualStyleBackColor = true;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // bttn_Close
            // 
            this.bttn_Close.ForeColor = System.Drawing.Color.Red;
            this.bttn_Close.Location = new System.Drawing.Point(151, 541);
            this.bttn_Close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(76, 28);
            this.bttn_Close.TabIndex = 23;
            this.bttn_Close.Text = "Close";
            this.bttn_Close.UseVisualStyleBackColor = true;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // frm_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(380, 569);
            this.Controls.Add(this.bttn_Close);
            this.Controls.Add(this.pnl_Button);
            this.Controls.Add(this.txt_Category);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.dgv_Category);
            this.Controls.Add(this.pnl_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Category";
            this.Load += new System.EventHandler(this.frm_Category_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Category_KeyDown);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).EndInit();
            this.pnl_Button.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.DataGridView dgv_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Button bttn_Delete;
        private System.Windows.Forms.Button bttn_Update;
        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.Label lbl_SrNo;
        private System.Windows.Forms.Button bttn_Close;
    }
}