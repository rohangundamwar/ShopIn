namespace PrimeSolutions.Common
{
    partial class frm_UpdateQuery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.dgv_UpdateQuery = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UpdateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Query = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_selectall = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UpdateQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Execute
            // 
            this.btn_Execute.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Execute.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Execute.ForeColor = System.Drawing.Color.Green;
            this.btn_Execute.Location = new System.Drawing.Point(657, 15);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(86, 26);
            this.btn_Execute.TabIndex = 1;
            this.btn_Execute.Text = "Execute";
            this.btn_Execute.UseVisualStyleBackColor = false;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // dgv_UpdateQuery
            // 
            this.dgv_UpdateQuery.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.dgv_UpdateQuery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_UpdateQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UpdateQuery.BackgroundColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UpdateQuery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_UpdateQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UpdateQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.UpdateName,
            this.Query});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_UpdateQuery.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_UpdateQuery.Location = new System.Drawing.Point(12, 58);
            this.dgv_UpdateQuery.Name = "dgv_UpdateQuery";
            this.dgv_UpdateQuery.Size = new System.Drawing.Size(731, 412);
            this.dgv_UpdateQuery.TabIndex = 2;
            // 
            // Select
            // 
            this.Select.FillWeight = 25F;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // UpdateName
            // 
            this.UpdateName.HeaderText = "UpdateName";
            this.UpdateName.Name = "UpdateName";
            // 
            // Query
            // 
            this.Query.HeaderText = "Query";
            this.Query.Name = "Query";
            // 
            // chk_selectall
            // 
            this.chk_selectall.AutoSize = true;
            this.chk_selectall.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chk_selectall.Location = new System.Drawing.Point(12, 21);
            this.chk_selectall.Name = "chk_selectall";
            this.chk_selectall.Size = new System.Drawing.Size(90, 23);
            this.chk_selectall.TabIndex = 3;
            this.chk_selectall.Text = "Select All";
            this.chk_selectall.UseVisualStyleBackColor = true;
            this.chk_selectall.CheckedChanged += new System.EventHandler(this.chk_selectall_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update Receipt No";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_UpdateQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(754, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chk_selectall);
            this.Controls.Add(this.dgv_UpdateQuery);
            this.Controls.Add(this.btn_Execute);
            this.Name = "frm_UpdateQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Database";
            this.Load += new System.EventHandler(this.frm_UpdateQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UpdateQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.DataGridView dgv_UpdateQuery;
        private System.Windows.Forms.CheckBox chk_selectall;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Query;
        private System.Windows.Forms.Button button1;
    }
}