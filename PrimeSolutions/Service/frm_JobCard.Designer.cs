namespace PrimeSolutions.Service
{
    partial class frm_JobCard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.bttn_generate = new System.Windows.Forms.Button();
            this.dgv_Job = new System.Windows.Forms.DataGridView();
            this.lbl_Instruction = new System.Windows.Forms.Label();
            this.bttn_PrintSheet = new System.Windows.Forms.Button();
            this.bttn_PrintCard = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Job)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_from
            // 
            this.dtp_from.Location = new System.Drawing.Point(114, 25);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(104, 20);
            this.dtp_from.TabIndex = 0;
            // 
            // dtp_to
            // 
            this.dtp_to.Location = new System.Drawing.Point(301, 25);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(104, 20);
            this.dtp_to.TabIndex = 1;
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(33, 29);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(30, 13);
            this.lbl_from.TabIndex = 2;
            this.lbl_from.Text = "From";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(263, 29);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(20, 13);
            this.lbl_To.TabIndex = 3;
            this.lbl_To.Text = "To";
            // 
            // bttn_generate
            // 
            this.bttn_generate.BackColor = System.Drawing.Color.YellowGreen;
            this.bttn_generate.Location = new System.Drawing.Point(461, 24);
            this.bttn_generate.Name = "bttn_generate";
            this.bttn_generate.Size = new System.Drawing.Size(75, 23);
            this.bttn_generate.TabIndex = 4;
            this.bttn_generate.Text = "Generate";
            this.bttn_generate.UseVisualStyleBackColor = false;
            this.bttn_generate.Click += new System.EventHandler(this.bttn_generate_Click);
            // 
            // dgv_Job
            // 
            this.dgv_Job.AllowUserToAddRows = false;
            this.dgv_Job.AllowUserToDeleteRows = false;
            this.dgv_Job.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgv_Job.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Job.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Date,
            this.Name,
            this.Address,
            this.MobileNo,
            this.Model,
            this.ServiceID,
            this.Maintenance});
            this.dgv_Job.Location = new System.Drawing.Point(9, 67);
            this.dgv_Job.Name = "dgv_Job";
            this.dgv_Job.Size = new System.Drawing.Size(873, 303);
            this.dgv_Job.TabIndex = 5;
            this.dgv_Job.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Job_CellDoubleClick);
            // 
            // lbl_Instruction
            // 
            this.lbl_Instruction.AutoSize = true;
            this.lbl_Instruction.Location = new System.Drawing.Point(12, 386);
            this.lbl_Instruction.Name = "lbl_Instruction";
            this.lbl_Instruction.Size = new System.Drawing.Size(501, 13);
            this.lbl_Instruction.TabIndex = 6;
            this.lbl_Instruction.Text = "* Double Click the Job to Generate Service Invoice OR Else Generate Job Sheet for" +
    " all using Select Tool\r\n";
            // 
            // bttn_PrintSheet
            // 
            this.bttn_PrintSheet.BackColor = System.Drawing.Color.MidnightBlue;
            this.bttn_PrintSheet.ForeColor = System.Drawing.Color.White;
            this.bttn_PrintSheet.Location = new System.Drawing.Point(744, 14);
            this.bttn_PrintSheet.Name = "bttn_PrintSheet";
            this.bttn_PrintSheet.Size = new System.Drawing.Size(66, 42);
            this.bttn_PrintSheet.TabIndex = 7;
            this.bttn_PrintSheet.Text = "Print Sheet";
            this.bttn_PrintSheet.UseVisualStyleBackColor = false;
            this.bttn_PrintSheet.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttn_PrintCard
            // 
            this.bttn_PrintCard.BackColor = System.Drawing.Color.MidnightBlue;
            this.bttn_PrintCard.ForeColor = System.Drawing.Color.White;
            this.bttn_PrintCard.Location = new System.Drawing.Point(604, 15);
            this.bttn_PrintCard.Name = "bttn_PrintCard";
            this.bttn_PrintCard.Size = new System.Drawing.Size(75, 40);
            this.bttn_PrintCard.TabIndex = 8;
            this.bttn_PrintCard.Text = "Print Job Card";
            this.bttn_PrintCard.UseVisualStyleBackColor = false;
            this.bttn_PrintCard.Click += new System.EventHandler(this.bttn_PrintCard_Click);
            // 
            // Select
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = false;
            this.Select.DefaultCellStyle = dataGridViewCellStyle1;
            this.Select.FalseValue = "false";
            this.Select.FillWeight = 30F;
            this.Select.HeaderText = "Chk";
            this.Select.Name = "Select";
            this.Select.TrueValue = "true";
            this.Select.Width = 30;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Width = 150;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.Width = 150;
            // 
            // MobileNo
            // 
            this.MobileNo.HeaderText = "MobileNo";
            this.MobileNo.Name = "MobileNo";
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // ServiceID
            // 
            this.ServiceID.HeaderText = "ServiceID";
            this.ServiceID.Name = "ServiceID";
            // 
            // Maintenance
            // 
            this.Maintenance.HeaderText = "Maintenance";
            this.Maintenance.Name = "Maintenance";
            // 
            // frm_JobCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 417);
            this.Controls.Add(this.bttn_PrintCard);
            this.Controls.Add(this.bttn_PrintSheet);
            this.Controls.Add(this.lbl_Instruction);
            this.Controls.Add(this.dgv_Job);
            this.Controls.Add(this.bttn_generate);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.dtp_from);
            this.Text = "Generate JobCard";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Job)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Button bttn_generate;
        private System.Windows.Forms.DataGridView dgv_Job;
        private System.Windows.Forms.Label lbl_Instruction;
        private System.Windows.Forms.Button bttn_PrintSheet;
        private System.Windows.Forms.Button bttn_PrintCard;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maintenance;
    }
}