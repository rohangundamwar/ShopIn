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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.DiscPer,
            this.MinQty,
            this.Comment});
            this.dataGridView1.Location = new System.Drawing.Point(12, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_DiscPer
            // 
            this.txt_DiscPer.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_DiscPer.Location = new System.Drawing.Point(84, 40);
            this.txt_DiscPer.Name = "txt_DiscPer";
            this.txt_DiscPer.Size = new System.Drawing.Size(100, 20);
            this.txt_DiscPer.TabIndex = 1;
            // 
            // txt_MinQty
            // 
            this.txt_MinQty.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_MinQty.Location = new System.Drawing.Point(282, 40);
            this.txt_MinQty.Name = "txt_MinQty";
            this.txt_MinQty.Size = new System.Drawing.Size(100, 20);
            this.txt_MinQty.TabIndex = 2;
            // 
            // txt_Comment
            // 
            this.txt_Comment.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Comment.Location = new System.Drawing.Point(84, 85);
            this.txt_Comment.Name = "txt_Comment";
            this.txt_Comment.Size = new System.Drawing.Size(421, 20);
            this.txt_Comment.TabIndex = 3;
            // 
            // lbl_DiscPer
            // 
            this.lbl_DiscPer.AutoSize = true;
            this.lbl_DiscPer.Location = new System.Drawing.Point(12, 44);
            this.lbl_DiscPer.Name = "lbl_DiscPer";
            this.lbl_DiscPer.Size = new System.Drawing.Size(60, 13);
            this.lbl_DiscPer.TabIndex = 4;
            this.lbl_DiscPer.Text = "Discount %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Min. Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Comment or \r\nOffer Details";
            // 
            // Bttn_add
            // 
            this.Bttn_add.ForeColor = System.Drawing.Color.Green;
            this.Bttn_add.Location = new System.Drawing.Point(12, 124);
            this.Bttn_add.Name = "Bttn_add";
            this.Bttn_add.Size = new System.Drawing.Size(75, 23);
            this.Bttn_add.TabIndex = 7;
            this.Bttn_add.Text = "Add";
            this.Bttn_add.UseVisualStyleBackColor = true;
            // 
            // Bttn_Update
            // 
            this.Bttn_Update.ForeColor = System.Drawing.Color.Blue;
            this.Bttn_Update.Location = new System.Drawing.Point(151, 124);
            this.Bttn_Update.Name = "Bttn_Update";
            this.Bttn_Update.Size = new System.Drawing.Size(75, 23);
            this.Bttn_Update.TabIndex = 8;
            this.Bttn_Update.Text = "Update";
            this.Bttn_Update.UseVisualStyleBackColor = true;
            // 
            // bttn_delete
            // 
            this.bttn_delete.ForeColor = System.Drawing.Color.Orange;
            this.bttn_delete.Location = new System.Drawing.Point(290, 124);
            this.bttn_delete.Name = "bttn_delete";
            this.bttn_delete.Size = new System.Drawing.Size(75, 23);
            this.bttn_delete.TabIndex = 9;
            this.bttn_delete.Text = "Delete";
            this.bttn_delete.UseVisualStyleBackColor = true;
            // 
            // bttn_Close
            // 
            this.bttn_Close.ForeColor = System.Drawing.Color.Red;
            this.bttn_Close.Location = new System.Drawing.Point(429, 124);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(75, 23);
            this.bttn_Close.TabIndex = 10;
            this.bttn_Close.Text = "Close";
            this.bttn_Close.UseVisualStyleBackColor = true;
            // 
            // SrNo
            // 
            this.SrNo.FillWeight = 50F;
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            this.SrNo.Width = 50;
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
            // frm_Offer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 419);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Offer";
            this.Text = "Offers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}