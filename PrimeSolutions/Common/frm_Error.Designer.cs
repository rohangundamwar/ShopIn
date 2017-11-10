namespace PrimeSolutions.Common
{
    partial class frm_Error
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
            this.dgv_error = new System.Windows.Forms.DataGridView();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.bttn_Excel = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_error)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_error
            // 
            this.dgv_error.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_error.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ErrorMessage,
            this.Form,
            this.Time,
            this.Line,
            this.Method,
            this.Stack});
            this.dgv_error.Location = new System.Drawing.Point(12, 69);
            this.dgv_error.Name = "dgv_error";
            this.dgv_error.Size = new System.Drawing.Size(894, 274);
            this.dgv_error.TabIndex = 0;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(13, 25);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_date.TabIndex = 1;
            // 
            // bttn_Excel
            // 
            this.bttn_Excel.Location = new System.Drawing.Point(616, 25);
            this.bttn_Excel.Name = "bttn_Excel";
            this.bttn_Excel.Size = new System.Drawing.Size(128, 23);
            this.bttn_Excel.TabIndex = 2;
            this.bttn_Excel.Text = "Export To Excel";
            this.bttn_Excel.UseVisualStyleBackColor = true;
            this.bttn_Excel.Click += new System.EventHandler(this.bttn_Excel_Click);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.HeaderText = "ErrorMessage";
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Width = 200;
            // 
            // Form
            // 
            this.Form.HeaderText = "Form";
            this.Form.Name = "Form";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // Line
            // 
            this.Line.HeaderText = "Line";
            this.Line.Name = "Line";
            // 
            // Method
            // 
            this.Method.HeaderText = "Method";
            this.Method.Name = "Method";
            this.Method.Width = 150;
            // 
            // Stack
            // 
            this.Stack.FillWeight = 200F;
            this.Stack.HeaderText = "Stack";
            this.Stack.Name = "Stack";
            this.Stack.Width = 200;
            // 
            // frm_Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 355);
            this.Controls.Add(this.bttn_Excel);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.dgv_error);
            this.Name = "frm_Error";
            this.Text = "frm_Error";
            this.Load += new System.EventHandler(this.frm_Error_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_error;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Button bttn_Excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Form;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stack;
    }
}