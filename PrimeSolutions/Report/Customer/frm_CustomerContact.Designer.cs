namespace PrimeSolutions.Report.Customer
{
    partial class frm_CustomerContact
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
            this.dgv_Customer = new System.Windows.Forms.DataGridView();
            this.bttn_Excel = new System.Windows.Forms.Button();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GSTIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PANNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.AllowUserToDeleteRows = false;
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.ContactNo,
            this.Address,
            this.GSTIN,
            this.PANNo});
            this.dgv_Customer.Location = new System.Drawing.Point(12, 82);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.ReadOnly = true;
            this.dgv_Customer.Size = new System.Drawing.Size(623, 326);
            this.dgv_Customer.TabIndex = 0;
            // 
            // bttn_Excel
            // 
            this.bttn_Excel.Location = new System.Drawing.Point(456, 39);
            this.bttn_Excel.Name = "bttn_Excel";
            this.bttn_Excel.Size = new System.Drawing.Size(92, 23);
            this.bttn_Excel.TabIndex = 1;
            this.bttn_Excel.Text = "Export to Excel";
            this.bttn_Excel.UseVisualStyleBackColor = true;
            this.bttn_Excel.Click += new System.EventHandler(this.bttn_Excel_Click);
            // 
            // bttn_Close
            // 
            this.bttn_Close.BackColor = System.Drawing.Color.LightCoral;
            this.bttn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Close.ForeColor = System.Drawing.Color.White;
            this.bttn_Close.Location = new System.Drawing.Point(560, 39);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(75, 23);
            this.bttn_Close.TabIndex = 2;
            this.bttn_Close.Text = "Close";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Print_Click);
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(13, 39);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(106, 20);
            this.dtp1.TabIndex = 3;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 180;
            // 
            // ContactNo
            // 
            this.ContactNo.HeaderText = "ContactNo";
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // GSTIN
            // 
            this.GSTIN.HeaderText = "GSTIN";
            this.GSTIN.Name = "GSTIN";
            this.GSTIN.ReadOnly = true;
            // 
            // PANNo
            // 
            this.PANNo.HeaderText = "PAN No.";
            this.PANNo.Name = "PANNo";
            this.PANNo.ReadOnly = true;
            // 
            // frm_CustomerContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 429);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.bttn_Close);
            this.Controls.Add(this.bttn_Excel);
            this.Controls.Add(this.dgv_Customer);
            this.KeyPreview = true;
            this.Name = "frm_CustomerContact";
            this.Text = "frm_CustomerContact";
            this.Load += new System.EventHandler(this.frm_CustomerContact_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_CustomerContact_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Customer;
        private System.Windows.Forms.Button bttn_Excel;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn GSTIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PANNo;
    }
}