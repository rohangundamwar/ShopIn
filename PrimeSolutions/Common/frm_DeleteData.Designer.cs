namespace PrimeSolutions.Common
{
    partial class frm_DeleteData
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
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_yes = new System.Windows.Forms.Button();
            this.bttn_no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure\r\n\r\nYou Want to Delete Data ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttn_yes
            // 
            this.bttn_yes.BackColor = System.Drawing.Color.Red;
            this.bttn_yes.ForeColor = System.Drawing.Color.White;
            this.bttn_yes.Location = new System.Drawing.Point(56, 166);
            this.bttn_yes.Name = "bttn_yes";
            this.bttn_yes.Size = new System.Drawing.Size(75, 23);
            this.bttn_yes.TabIndex = 1;
            this.bttn_yes.Text = "Yes";
            this.bttn_yes.UseVisualStyleBackColor = false;
            this.bttn_yes.Click += new System.EventHandler(this.bttn_yes_Click);
            // 
            // bttn_no
            // 
            this.bttn_no.BackColor = System.Drawing.Color.Green;
            this.bttn_no.ForeColor = System.Drawing.Color.White;
            this.bttn_no.Location = new System.Drawing.Point(170, 166);
            this.bttn_no.Name = "bttn_no";
            this.bttn_no.Size = new System.Drawing.Size(75, 23);
            this.bttn_no.TabIndex = 2;
            this.bttn_no.Text = "No";
            this.bttn_no.UseVisualStyleBackColor = false;
            this.bttn_no.Click += new System.EventHandler(this.bttn_no_Click);
            // 
            // frm_DeleteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 232);
            this.Controls.Add(this.bttn_no);
            this.Controls.Add(this.bttn_yes);
            this.Controls.Add(this.label1);
            this.Name = "frm_DeleteData";
            this.Text = "frm_DeleteData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_yes;
        private System.Windows.Forms.Button bttn_no;
    }
}