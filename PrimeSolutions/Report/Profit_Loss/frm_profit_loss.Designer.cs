namespace PrimeSolutions.Report.Profit_Loss
{
    partial class frm_profit_loss
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
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_exel = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.dgv_Expense = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expence_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Income = new System.Windows.Forms.DataGridView();
            this.Date_Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Income_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Income)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_from
            // 
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(199, 21);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(132, 20);
            this.dtp_from.TabIndex = 0;
            // 
            // dtp_to
            // 
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(375, 21);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(132, 20);
            this.dtp_to.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Show.Location = new System.Drawing.Point(517, 20);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(75, 23);
            this.btn_Show.TabIndex = 4;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_print.Location = new System.Drawing.Point(177, 425);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 6;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Visible = false;
            // 
            // btn_exel
            // 
            this.btn_exel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_exel.Location = new System.Drawing.Point(327, 425);
            this.btn_exel.Name = "btn_exel";
            this.btn_exel.Size = new System.Drawing.Size(94, 23);
            this.btn_exel.TabIndex = 7;
            this.btn_exel.Text = "Expot To Exel";
            this.btn_exel.UseVisualStyleBackColor = true;
            this.btn_exel.Visible = false;
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Close.Location = new System.Drawing.Point(496, 425);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // dgv_Expense
            // 
            this.dgv_Expense.AllowUserToAddRows = false;
            this.dgv_Expense.AllowUserToDeleteRows = false;
            this.dgv_Expense.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Expense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Expense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Expence_Name,
            this.Amount});
            this.dgv_Expense.Location = new System.Drawing.Point(16, 58);
            this.dgv_Expense.Name = "dgv_Expense";
            this.dgv_Expense.ReadOnly = true;
            this.dgv_Expense.Size = new System.Drawing.Size(343, 348);
            this.dgv_Expense.TabIndex = 9;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Expence_Name
            // 
            this.Expence_Name.HeaderText = "Expence Name";
            this.Expence_Name.Name = "Expence_Name";
            this.Expence_Name.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // dgv_Income
            // 
            this.dgv_Income.AllowUserToAddRows = false;
            this.dgv_Income.AllowUserToDeleteRows = false;
            this.dgv_Income.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Income.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Income.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date_Income,
            this.Income_Type,
            this.Amount_Income});
            this.dgv_Income.Location = new System.Drawing.Point(387, 58);
            this.dgv_Income.Name = "dgv_Income";
            this.dgv_Income.ReadOnly = true;
            this.dgv_Income.Size = new System.Drawing.Size(343, 348);
            this.dgv_Income.TabIndex = 10;
            // 
            // Date_Income
            // 
            this.Date_Income.HeaderText = "Date";
            this.Date_Income.Name = "Date_Income";
            this.Date_Income.ReadOnly = true;
            // 
            // Income_Type
            // 
            this.Income_Type.HeaderText = "Income Type";
            this.Income_Type.Name = "Income_Type";
            this.Income_Type.ReadOnly = true;
            // 
            // Amount_Income
            // 
            this.Amount_Income.HeaderText = "Amount";
            this.Amount_Income.Name = "Amount_Income";
            this.Amount_Income.ReadOnly = true;
            // 
            // frm_profit_loss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(748, 460);
            this.Controls.Add(this.dgv_Income);
            this.Controls.Add(this.dgv_Expense);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_exel);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.dtp_from);
            this.Name = "frm_profit_loss";
            this.Text = "Profit Loss";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Income)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_exel;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridView dgv_Expense;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expence_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridView dgv_Income;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Income;
        private System.Windows.Forms.DataGridViewTextBoxColumn Income_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_Income;
    }
}