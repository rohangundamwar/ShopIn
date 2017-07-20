namespace PrimeSolutions.Common
{
    partial class frm_backup
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
            this.lbl_Message = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bttn_cancel = new System.Windows.Forms.Button();
            this.txt_DatabaseName = new System.Windows.Forms.Label();
            this.bttn_backup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Location = new System.Drawing.Point(71, 61);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(94, 13);
            this.lbl_Message.TabIndex = 0;
            this.lbl_Message.Text = "DataBase Name : ";
            // 
            // bttn_cancel
            // 
            this.bttn_cancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bttn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_cancel.ForeColor = System.Drawing.Color.OrangeRed;
            this.bttn_cancel.Location = new System.Drawing.Point(212, 144);
            this.bttn_cancel.Name = "bttn_cancel";
            this.bttn_cancel.Size = new System.Drawing.Size(87, 28);
            this.bttn_cancel.TabIndex = 1;
            this.bttn_cancel.Text = "Cancel";
            this.bttn_cancel.UseVisualStyleBackColor = false;
            // 
            // txt_DatabaseName
            // 
            this.txt_DatabaseName.AutoSize = true;
            this.txt_DatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DatabaseName.Location = new System.Drawing.Point(174, 61);
            this.txt_DatabaseName.Name = "txt_DatabaseName";
            this.txt_DatabaseName.Size = new System.Drawing.Size(61, 13);
            this.txt_DatabaseName.TabIndex = 2;
            this.txt_DatabaseName.Text = "Database";
            // 
            // bttn_backup
            // 
            this.bttn_backup.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bttn_backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_backup.ForeColor = System.Drawing.Color.LightGreen;
            this.bttn_backup.Location = new System.Drawing.Point(42, 144);
            this.bttn_backup.Margin = new System.Windows.Forms.Padding(0);
            this.bttn_backup.Name = "bttn_backup";
            this.bttn_backup.Size = new System.Drawing.Size(87, 28);
            this.bttn_backup.TabIndex = 3;
            this.bttn_backup.Text = "Backup";
            this.bttn_backup.UseVisualStyleBackColor = false;
            this.bttn_backup.Click += new System.EventHandler(this.bttn_backup_Click);
            // 
            // frm_backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 224);
            this.Controls.Add(this.bttn_backup);
            this.Controls.Add(this.txt_DatabaseName);
            this.Controls.Add(this.bttn_cancel);
            this.Controls.Add(this.lbl_Message);
            this.Name = "frm_backup";
            this.Text = "frm_backup";
            this.Load += new System.EventHandler(this.frm_backup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bttn_cancel;
        private System.Windows.Forms.Label txt_DatabaseName;
        private System.Windows.Forms.Button bttn_backup;
    }
}