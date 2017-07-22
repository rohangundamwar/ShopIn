using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;

namespace PrimeSolutions.Common
{
    public partial class frm_LooseItem: Form
    {
        public frm_LooseItem()
        {
            InitializeComponent();
        }
        AllClassFile _objCustmor = new AllClassFile();
        PrimeSolutions.Library.ErrorLog _error = new Library.ErrorLog();
        private void frm_Category_Load(object sender, EventArgs e)
        {
            txt_SubCategory.Select();
            FillGrid();
            bttn_Update.Enabled = false;
            bttn_Delete.Enabled = false;
            lbl_SrNo.ResetText();
            txt_SubCategory.ResetText();
        }

        private void FillGrid()
        {
            DataTable dt = _objCustmor.FillLooseItem();
             for (int i =0; i < dt.Rows.Count;i++)
                {
                    dgv_SubCategory.Rows.Add();
                    dgv_SubCategory.Rows[i].Cells["LooseItem"].Value = dt.Rows[i]["LooseItem"].ToString();
                    dgv_SubCategory.Rows[i].Cells["SrNo"].Value = dt.Rows[i]["SrNo"].ToString();
                   
                }
           
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            if (txt_SubCategory.Text != "")
            {
                _objCustmor.InsertLooseItem(txt_SubCategory.Text);
                dgv_SubCategory.Rows.Clear();
                FillGrid();
                txt_SubCategory.Select();
                txt_SubCategory.ResetText();
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
                    lbl_SrNo.Text = dgv_SubCategory.Rows[dgv_SubCategory.CurrentRow.Index].Cells["SrNo"].Value.ToString();
                    txt_SubCategory.Text = dgv_SubCategory.Rows[dgv_SubCategory.CurrentRow.Index].Cells["SubCategory"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                _error.AddException(ex,"SubCategory");
            }
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            if (txt_SubCategory.Text != "")
            {
                _objCustmor.updateLooseItem(lbl_SrNo.Text, txt_SubCategory.Text);
                dgv_SubCategory.Rows.Clear();
                FillGrid();
                txt_SubCategory.ResetText();
                lbl_SrNo.ResetText();
                MessageBox.Show("Update SuccessFully");
                bttn_Add.Enabled = true;
            }
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_SubCategory.Text != "")
            {

                _objCustmor.DeleteLooseItem(lbl_SrNo.Text);
            dgv_SubCategory.Rows.Clear();
            FillGrid();
            txt_SubCategory.ResetText();
            lbl_SrNo.ResetText();
            MessageBox.Show("Deleted SuccessFully");
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

        private void txt_SubCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Add_Click(sender, e);
            }
        }
    }
}
