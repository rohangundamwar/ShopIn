using PrimeSolutions.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions.Common
{
    public partial class frm_Offer : Form
    {
        AllClassFile _a = new AllClassFile();


        public frm_Offer()
        {
            InitializeComponent();
        }

        private void frm_Offer_Load(object sender, EventArgs e)
        {
            cmb_category.DataSource = _a.FillCategory();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgv_Offers.Rows.Clear();
            DataTable dt = _a.GetAllOffer();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv_Offers.Rows.Add();
                dgv_Offers.Rows[i].Cells["Category"].Value = dt.Rows[i]["Category"].ToString();
                dgv_Offers.Rows[i].Cells["SubCategory"].Value = dt.Rows[i]["SubCategory"].ToString();
                dgv_Offers.Rows[i].Cells["Size"].Value = dt.Rows[i]["Size"].ToString();
                dgv_Offers.Rows[i].Cells["SrNo"].Value = dt.Rows[i]["SrNo"].ToString();
                dgv_Offers.Rows[i].Cells["DiscPer"].Value = dt.Rows[i]["DiscPer"].ToString();
                dgv_Offers.Rows[i].Cells["MinQty"].Value = dt.Rows[i]["MinQty"].ToString();
                dgv_Offers.Rows[i].Cells["Comment"].Value = dt.Rows[i]["Comment"].ToString();
            }
        }

        private void Bttn_add_Click(object sender, EventArgs e)
        {
            _a.InsertOffer(cmb_category.Text, cmb_SubCategory.Text, cmb_Size.Text, txt_DiscPer.Text, txt_MinQty.Text, txt_Comment.Text);
            RefreshGrid();
        }

        private void bttn_delete_Click(object sender, EventArgs e)
        {
            _a.DeleteOffer(lbl_SrNo.Text);
            RefreshGrid();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmb_category.Text = dgv_Offers.Rows[e.RowIndex].Cells["Category"].Value.ToString();
            cmb_SubCategory.Text = dgv_Offers.Rows[e.RowIndex].Cells["SubCategory"].Value.ToString();
            cmb_Size.Text = dgv_Offers.Rows[e.RowIndex].Cells["Size"].Value.ToString();
            txt_DiscPer.Text = dgv_Offers.Rows[e.RowIndex].Cells["DiscPer"].Value.ToString();
            txt_MinQty.Text = dgv_Offers.Rows[e.RowIndex].Cells["MinQty"].Value.ToString();
            txt_Comment.Text = dgv_Offers.Rows[e.RowIndex].Cells["Comment"].Value.ToString();
            lbl_SrNo.Text= dgv_Offers.Rows[e.RowIndex].Cells["SrNo"].Value.ToString();
        }

        private void cmb_category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_SubCategory.Focus();
            }
        }

        private void cmb_SubCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Size.Focus();
            }
        }

        private void cmb_Size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_DiscPer.Focus();
            }
        }

        private void txt_DiscPer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_MinQty.Focus();
            }
        }

        private void txt_MinQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Comment.Focus();
            }
        }

        private void txt_Comment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Bttn_add.Focus();
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmb_SubCategory.DataSource = _a.GetSubCategoryByCategory(cmb_category.Text);
        }

        private void cmb_SubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Size.DataSource = _a.GetSizeByCatAndSubCat(cmb_category.Text, cmb_SubCategory.Text);
        }
    }
}
