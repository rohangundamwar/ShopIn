namespace PrimeSolutions.Common
{
    partial class frm_Activation
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
            this.txt_ProductKey = new System.Windows.Forms.TextBox();
            this.lbl_Activation = new System.Windows.Forms.Label();
            this.lbl_InstallationID = new System.Windows.Forms.Label();
            this.lbl_ProductKey = new System.Windows.Forms.Label();
            this.lbl_ProductValue = new System.Windows.Forms.Label();
            this.bttn_Save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Warning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ProductKey
            // 
            this.txt_ProductKey.Location = new System.Drawing.Point(274, 132);
            this.txt_ProductKey.Name = "txt_ProductKey";
            this.txt_ProductKey.Size = new System.Drawing.Size(144, 20);
            this.txt_ProductKey.TabIndex = 1;
            this.txt_ProductKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ProductKey_KeyDown);
            // 
            // lbl_Activation
            // 
            this.lbl_Activation.AutoSize = true;
            this.lbl_Activation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Activation.ForeColor = System.Drawing.Color.Green;
            this.lbl_Activation.Location = new System.Drawing.Point(278, 12);
            this.lbl_Activation.Name = "lbl_Activation";
            this.lbl_Activation.Size = new System.Drawing.Size(88, 20);
            this.lbl_Activation.TabIndex = 2;
            this.lbl_Activation.Text = "Activation";
            // 
            // lbl_InstallationID
            // 
            this.lbl_InstallationID.AutoSize = true;
            this.lbl_InstallationID.Location = new System.Drawing.Point(206, 84);
            this.lbl_InstallationID.Name = "lbl_InstallationID";
            this.lbl_InstallationID.Size = new System.Drawing.Size(60, 26);
            this.lbl_InstallationID.TabIndex = 3;
            this.lbl_InstallationID.Text = "Installation \r\nID";
            // 
            // lbl_ProductKey
            // 
            this.lbl_ProductKey.AutoSize = true;
            this.lbl_ProductKey.Location = new System.Drawing.Point(206, 129);
            this.lbl_ProductKey.Name = "lbl_ProductKey";
            this.lbl_ProductKey.Size = new System.Drawing.Size(44, 26);
            this.lbl_ProductKey.TabIndex = 4;
            this.lbl_ProductKey.Text = "Product\r\nKey";
            // 
            // lbl_ProductValue
            // 
            this.lbl_ProductValue.AutoSize = true;
            this.lbl_ProductValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ProductValue.ForeColor = System.Drawing.Color.Red;
            this.lbl_ProductValue.Location = new System.Drawing.Point(274, 87);
            this.lbl_ProductValue.Name = "lbl_ProductValue";
            this.lbl_ProductValue.Size = new System.Drawing.Size(0, 20);
            this.lbl_ProductValue.TabIndex = 5;
            // 
            // bttn_Save
            // 
            this.bttn_Save.BackColor = System.Drawing.Color.Green;
            this.bttn_Save.ForeColor = System.Drawing.Color.White;
            this.bttn_Save.Location = new System.Drawing.Point(267, 199);
            this.bttn_Save.Name = "bttn_Save";
            this.bttn_Save.Size = new System.Drawing.Size(99, 30);
            this.bttn_Save.TabIndex = 6;
            this.bttn_Save.Text = "Save";
            this.bttn_Save.UseVisualStyleBackColor = false;
            this.bttn_Save.Click += new System.EventHandler(this.bttn_Save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrimeSolutions.Properties.Resources.unlock;
            this.pictureBox1.Location = new System.Drawing.Point(16, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Warning
            // 
            this.lbl_Warning.AutoSize = true;
            this.lbl_Warning.Location = new System.Drawing.Point(16, 17);
            this.lbl_Warning.Name = "lbl_Warning";
            this.lbl_Warning.Size = new System.Drawing.Size(210, 39);
            this.lbl_Warning.TabIndex = 8;
            this.lbl_Warning.Text = "WARNING: Product Not Activated \r\n                    Please Activate \r\n          " +
    "          Contact Your Service Provider";
            // 
            // frm_Activation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(437, 261);
            this.Controls.Add(this.lbl_Warning);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttn_Save);
            this.Controls.Add(this.lbl_ProductValue);
            this.Controls.Add(this.lbl_ProductKey);
            this.Controls.Add(this.lbl_InstallationID);
            this.Controls.Add(this.lbl_Activation);
            this.Controls.Add(this.txt_ProductKey);
            this.Name = "frm_Activation";
            this.Text = "Activation";
            this.Load += new System.EventHandler(this.frm_Activation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_ProductKey;
        private System.Windows.Forms.Label lbl_Activation;
        private System.Windows.Forms.Label lbl_InstallationID;
        private System.Windows.Forms.Label lbl_ProductKey;
        private System.Windows.Forms.Label lbl_ProductValue;
        private System.Windows.Forms.Button bttn_Save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Warning;
    }
}