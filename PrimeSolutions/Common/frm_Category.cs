﻿using PrimeSolutions.Library;
using System;
using System.Data;
using System.Windows.Forms;

namespace PrimeSolutions.Common
{
    public partial class frm_Category : Form
    {
        public frm_Category()
        {
            InitializeComponent();
        }
        
        
        ErrorLog _e = new ErrorLog();
        AllClassFile _objCustomer = new AllClassFile();

        private void frm_Category_Load(object sender, EventArgs e)
        {
            txt_Category.Select();
            FillGrid();
            bttn_Update.Enabled = false;
            bttn_Delete.Enabled = false;
            lbl_SrNo.ResetText();
            txt_Category.ResetText();

        }

        private void FillGrid()
        {
            DataTable dt = _objCustomer.FillCategory();
             for (int i =0; i < dt.Rows.Count;i++)
                {
                    dgv_Category.Rows.Add();
                    dgv_Category.Rows[i].Cells["Category"].Value = dt.Rows[i]["Category"].ToString();
                    dgv_Category.Rows[i].Cells["SrNo"].Value = dt.Rows[i]["SrNo"].ToString();
                   
                }
           
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Category.Text != "")
            {
                _objCustomer.InsertCategory(txt_Category.Text);
                dgv_Category.Rows.Clear();
                FillGrid();
                txt_Category.Select();
                txt_Category.ResetText();
            }
            else
            {
                MessageBox.Show("Insert Category");
            }
        }

        private void dgv_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bttn_Update.Enabled = true;
                bttn_Delete.Enabled = true;
                bttn_Add.Enabled = false;
                if (e.RowIndex > -1 && e.ColumnIndex >= -1)
                {
                    lbl_SrNo.Text = dgv_Category.Rows[dgv_Category.CurrentRow.Index].Cells["SrNo"].Value.ToString();
                    txt_Category.Text = dgv_Category.Rows[dgv_Category.CurrentRow.Index].Cells["Category"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                _e.AddException(ex, "Category");
            }
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            if (txt_Category.Text != "")
            {
                _objCustomer.updateCategory(lbl_SrNo.Text, txt_Category.Text);
                dgv_Category.Rows.Clear();
                FillGrid();
                txt_Category.ResetText();
                lbl_SrNo.ResetText();
                MessageBox.Show("Update SuccessFully");
            }
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_Category.Text != "")
            {

                _objCustomer.DeleteCategory(lbl_SrNo.Text);
            dgv_Category.Rows.Clear();
            FillGrid();
            txt_Category.ResetText();
            lbl_SrNo.ResetText();
            MessageBox.Show("Deleted SuccessFully");
                bttn_Add.Enabled = true;
            }
        }

        private void frm_Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Add_Click(sender, e);
            }
        }
    }
}
