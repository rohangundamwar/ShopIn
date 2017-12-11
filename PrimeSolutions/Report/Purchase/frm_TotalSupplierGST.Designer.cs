namespace PrimeSolutions.Report.Purchase
{
    partial class frm_TotalSupplierGST
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
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.bttn_Generate = new System.Windows.Forms.Button();
            this.dgv_GST = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GSTIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountZero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amt5per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST5per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST5per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGST5per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amt12per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST12per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST12per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGST12per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amt18per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST18per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST18per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGST18per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amt28per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST28per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST28per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGST28per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_Excel = new System.Windows.Forms.Button();
            this.bttn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GST)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_to
            // 
            this.dtp_to.Location = new System.Drawing.Point(271, 46);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(200, 20);
            this.dtp_to.TabIndex = 0;
            // 
            // dtp_From
            // 
            this.dtp_From.Location = new System.Drawing.Point(45, 46);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(200, 20);
            this.dtp_From.TabIndex = 0;
            // 
            // bttn_Generate
            // 
            this.bttn_Generate.Location = new System.Drawing.Point(520, 47);
            this.bttn_Generate.Name = "bttn_Generate";
            this.bttn_Generate.Size = new System.Drawing.Size(75, 23);
            this.bttn_Generate.TabIndex = 1;
            this.bttn_Generate.Text = "Generate";
            this.bttn_Generate.UseVisualStyleBackColor = true;
            this.bttn_Generate.Click += new System.EventHandler(this.bttn_Generate_Click);
            // 
            // dgv_GST
            // 
            this.dgv_GST.AllowUserToAddRows = false;
            this.dgv_GST.AllowUserToDeleteRows = false;
            this.dgv_GST.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgv_GST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.Name,
            this.GSTIN,
            this.AmountZero,
            this.Amt5per,
            this.SGST5per,
            this.CGST5per,
            this.IGST5per,
            this.Amt12per,
            this.SGST12per,
            this.CGST12per,
            this.IGST12per,
            this.Amt18per,
            this.SGST18per,
            this.CGST18per,
            this.IGST18per,
            this.Amt28per,
            this.SGST28per,
            this.CGST28per,
            this.IGST28per});
            this.dgv_GST.Location = new System.Drawing.Point(12, 82);
            this.dgv_GST.Name = "dgv_GST";
            this.dgv_GST.ReadOnly = true;
            this.dgv_GST.Size = new System.Drawing.Size(1232, 392);
            this.dgv_GST.TabIndex = 2;
            // 
            // SrNo
            // 
            this.SrNo.FillWeight = 50F;
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            this.SrNo.Width = 50;
            // 
            // Name
            // 
            this.Name.FillWeight = 150F;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 150;
            // 
            // GSTIN
            // 
            this.GSTIN.FillWeight = 150F;
            this.GSTIN.HeaderText = "GSTIN";
            this.GSTIN.Name = "GSTIN";
            this.GSTIN.ReadOnly = true;
            this.GSTIN.Width = 150;
            // 
            // AmountZero
            // 
            this.AmountZero.HeaderText = "0%Amount";
            this.AmountZero.Name = "AmountZero";
            this.AmountZero.ReadOnly = true;
            // 
            // Amt5per
            // 
            this.Amt5per.HeaderText = "Amt5%";
            this.Amt5per.Name = "Amt5per";
            this.Amt5per.ReadOnly = true;
            // 
            // SGST5per
            // 
            this.SGST5per.HeaderText = "SGST5%";
            this.SGST5per.Name = "SGST5per";
            this.SGST5per.ReadOnly = true;
            // 
            // CGST5per
            // 
            this.CGST5per.HeaderText = "CGST5%";
            this.CGST5per.Name = "CGST5per";
            this.CGST5per.ReadOnly = true;
            // 
            // IGST5per
            // 
            this.IGST5per.HeaderText = "IGST5%";
            this.IGST5per.Name = "IGST5per";
            this.IGST5per.ReadOnly = true;
            // 
            // Amt12per
            // 
            this.Amt12per.HeaderText = "Amt12%";
            this.Amt12per.Name = "Amt12per";
            this.Amt12per.ReadOnly = true;
            // 
            // SGST12per
            // 
            this.SGST12per.HeaderText = "SGST12%";
            this.SGST12per.Name = "SGST12per";
            this.SGST12per.ReadOnly = true;
            // 
            // CGST12per
            // 
            this.CGST12per.HeaderText = "CGST12%";
            this.CGST12per.Name = "CGST12per";
            this.CGST12per.ReadOnly = true;
            // 
            // IGST12per
            // 
            this.IGST12per.HeaderText = "IGST12%";
            this.IGST12per.Name = "IGST12per";
            this.IGST12per.ReadOnly = true;
            // 
            // Amt18per
            // 
            this.Amt18per.HeaderText = "Amt18%";
            this.Amt18per.Name = "Amt18per";
            this.Amt18per.ReadOnly = true;
            // 
            // SGST18per
            // 
            this.SGST18per.HeaderText = "SGST18%";
            this.SGST18per.Name = "SGST18per";
            this.SGST18per.ReadOnly = true;
            // 
            // CGST18per
            // 
            this.CGST18per.HeaderText = "CGST18%";
            this.CGST18per.Name = "CGST18per";
            this.CGST18per.ReadOnly = true;
            // 
            // IGST18per
            // 
            this.IGST18per.HeaderText = "IGST18%";
            this.IGST18per.Name = "IGST18per";
            this.IGST18per.ReadOnly = true;
            // 
            // Amt28per
            // 
            this.Amt28per.HeaderText = "Amt28%";
            this.Amt28per.Name = "Amt28per";
            this.Amt28per.ReadOnly = true;
            // 
            // SGST28per
            // 
            this.SGST28per.HeaderText = "SGST28%";
            this.SGST28per.Name = "SGST28per";
            this.SGST28per.ReadOnly = true;
            // 
            // CGST28per
            // 
            this.CGST28per.HeaderText = "CGST28%";
            this.CGST28per.Name = "CGST28per";
            this.CGST28per.ReadOnly = true;
            // 
            // IGST28per
            // 
            this.IGST28per.HeaderText = "IGST28%";
            this.IGST28per.Name = "IGST28per";
            this.IGST28per.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1025, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "* For printing Legal size paper is recommended";
            // 
            // bttn_Excel
            // 
            this.bttn_Excel.ForeColor = System.Drawing.Color.Blue;
            this.bttn_Excel.Location = new System.Drawing.Point(631, 47);
            this.bttn_Excel.Name = "bttn_Excel";
            this.bttn_Excel.Size = new System.Drawing.Size(75, 23);
            this.bttn_Excel.TabIndex = 4;
            this.bttn_Excel.Text = "Excel";
            this.bttn_Excel.UseVisualStyleBackColor = true;
            this.bttn_Excel.Click += new System.EventHandler(this.bttn_Excel_Click);
            // 
            // bttn_Print
            // 
            this.bttn_Print.ForeColor = System.Drawing.Color.Crimson;
            this.bttn_Print.Location = new System.Drawing.Point(737, 47);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(75, 23);
            this.bttn_Print.TabIndex = 5;
            this.bttn_Print.Text = "Print";
            this.bttn_Print.UseVisualStyleBackColor = true;
            this.bttn_Print.Click += new System.EventHandler(this.bttn_Print_Click);
            // 
            // frm_TotalSupplierGST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 486);
            this.Controls.Add(this.bttn_Print);
            this.Controls.Add(this.bttn_Excel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_GST);
            this.Controls.Add(this.bttn_Generate);
            this.Controls.Add(this.dtp_From);
            this.Controls.Add(this.dtp_to);
            this.Text = "TotalSupplierGST";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.Button bttn_Generate;
        private System.Windows.Forms.DataGridView dgv_GST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_Excel;
        private System.Windows.Forms.Button bttn_Print;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn GSTIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountZero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amt5per;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST5per;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST5per;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGST5per;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amt12per;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST12per;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST12per;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGST12per;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amt18per;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST18per;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST18per;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGST18per;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amt28per;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST28per;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST28per;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGST28per;
    }
}