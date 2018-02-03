namespace PrimeSolutions.Report.Sale
{
    partial class frm_Sales_Commission
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Show = new System.Windows.Forms.Button();
            this.dvg_SalesCommision = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_exel = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_SalesCommision)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_From
            // 
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_From.Location = new System.Drawing.Point(71, 58);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(132, 20);
            this.dtp_From.TabIndex = 0;
            // 
            // dtp_To
            // 
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_To.Location = new System.Drawing.Point(284, 58);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(132, 20);
            this.dtp_To.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salesman Name:";
            // 
            // Cmb_Name
            // 
            this.Cmb_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Name.DisplayMember = "Name";
            this.Cmb_Name.FormattingEnabled = true;
            this.Cmb_Name.Location = new System.Drawing.Point(129, 20);
            this.Cmb_Name.Name = "Cmb_Name";
            this.Cmb_Name.Size = new System.Drawing.Size(290, 21);
            this.Cmb_Name.TabIndex = 3;
            this.Cmb_Name.ValueMember = "Name";
            this.Cmb_Name.SelectedIndexChanged += new System.EventHandler(this.Cmb_Name_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To:";
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.Location = new System.Drawing.Point(488, 58);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(75, 23);
            this.btn_Show.TabIndex = 6;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // dvg_SalesCommision
            // 
            this.dvg_SalesCommision.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_SalesCommision.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_SalesCommision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_SalesCommision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Sales_Amount});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_SalesCommision.DefaultCellStyle = dataGridViewCellStyle4;
            this.dvg_SalesCommision.Location = new System.Drawing.Point(20, 101);
            this.dvg_SalesCommision.Name = "dvg_SalesCommision";
            this.dvg_SalesCommision.ReadOnly = true;
            this.dvg_SalesCommision.Size = new System.Drawing.Size(543, 271);
            this.dvg_SalesCommision.TabIndex = 7;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 25;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 250;
            // 
            // Sales_Amount
            // 
            this.Sales_Amount.HeaderText = "Sales Amount";
            this.Sales_Amount.MinimumWidth = 25;
            this.Sales_Amount.Name = "Sales_Amount";
            this.Sales_Amount.ReadOnly = true;
            this.Sales_Amount.Width = 250;
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(246, 408);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 8;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_exel
            // 
            this.btn_exel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exel.Location = new System.Drawing.Point(358, 408);
            this.btn_exel.Name = "btn_exel";
            this.btn_exel.Size = new System.Drawing.Size(98, 23);
            this.btn_exel.TabIndex = 9;
            this.btn_exel.Text = "Export To Exel";
            this.btn_exel.UseVisualStyleBackColor = true;
            this.btn_exel.Click += new System.EventHandler(this.btn_exel_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(488, 408);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 10;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.button4_Click);
            // 
            // frm_Sales_Commission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 456);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_exel);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.dvg_SalesCommision);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmb_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_To);
            this.Controls.Add(this.dtp_From);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Sales Commission";
            this.Load += new System.EventHandler(this.frm_Sales_Commission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_SalesCommision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.DataGridView dvg_SalesCommision;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_exel;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_Amount;
    }
}