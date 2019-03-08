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
    public partial class frm_RateMaster : Form
    {

        AllClassFile _A = new AllClassFile();
        clsCommon _common = new clsCommon();
        SaleCommon _Sale = new SaleCommon();
        DataTable Rate = new DataTable();


        public frm_RateMaster()
        {
            InitializeComponent();
        }

        private void frm_RateMaster_Load(object sender, EventArgs e)
        {
            dgv_Rate.DataSource = _A.GetRateMaster();
            cmb_Category.DataSource = _A.FillCategory();
            
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_SubCategory.DataSource = _A.GetSubCategoryByCategory(cmb_Category.Text);
        }

        private void dgv_Rate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex >= -1)
                {
                    txt_Barcode.Text = dgv_Rate.Rows[dgv_Rate.CurrentRow.Index].Cells["Barcode"].Value.ToString();
                    cmb_Category.Text = dgv_Rate.Rows[dgv_Rate.CurrentRow.Index].Cells["Category"].Value.ToString();
                    cmb_SubCategory.Text = dgv_Rate.Rows[dgv_Rate.CurrentRow.Index].Cells["SubCategory"].Value.ToString();
                    cmb_Size.Text = dgv_Rate.Rows[dgv_Rate.CurrentRow.Index].Cells["Size"].Value.ToString();
                    txt_Rate.Text = dgv_Rate.Rows[dgv_Rate.CurrentRow.Index].Cells["SellingPrice"].Value.ToString();
                    lbl_OldRAte.Text= dgv_Rate.Rows[dgv_Rate.CurrentRow.Index].Cells["SellingPrice"].Value.ToString();
                    txt_GST.Text = dgv_Rate.Rows[dgv_Rate.CurrentRow.Index].Cells["GST"].Value.ToString();
                    lbl_OldGSt.Text= dgv_Rate.Rows[dgv_Rate.CurrentRow.Index].Cells["GST"].Value.ToString();

                }
            }
            catch (Exception ex)
            {

            }
                
            
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Rate.Text.Trim() != "" || txt_Rate.Text.Trim() != string.Empty)
            {
                if (txt_GST.Text.Trim() != "" || txt_GST.Text.Trim() != string.Empty)
                {
                    _common.ChangeRate(cmb_Category.Text, cmb_SubCategory.Text, cmb_Size.Text, txt_Rate.Text, txt_GST.Text);
                    MessageBox.Show("Updated Succesfully");
                }
                else
                {
                    MessageBox.Show("Rate and GST Cannot be Blank");
                }
            }
            else
            {
                MessageBox.Show("Rate and GST Cannot be Blank");
            }
        }

        private void txt_Barcode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_SubCategory.Focus();
            }
        }

        private void cmb_SubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Size.DataSource = _A.GetSubCategoryByCategory(cmb_Category.Text);
        }

        private void cmb_Size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Rate = _Sale.GetItemRateByCategoySubCategorySize(cmb_Category.Text, cmb_SubCategory.Text, cmb_Size.Text);
                fillitem();
            }
           
        }

        private void txt_Barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (txt_Barcode.Text != "" || txt_Barcode.Text != string.Empty)
                {
                    
                    Rate = _Sale.GetItemRateByBarcode(txt_Barcode.Text);
                    fillitem();

                }
                else
                    cmb_Category.Focus();
           
            
        }


        private void fillitem()
        {
            try
            {
                if (Rate.Rows.Count > 0)
                {
                    txt_Rate.Text = Rate.Rows[0]["SellingPrice"].ToString();
                    lbl_OldRAte.Text= Rate.Rows[0]["SellingPrice"].ToString();
                     txt_GST.Text = Rate.Rows[0]["GST"].ToString();
                    lbl_OldGSt.Text= Rate.Rows[0]["GST"].ToString();
                    cmb_Category.Text = Rate.Rows[0]["Category"].ToString();
                    cmb_SubCategory.Text = Rate.Rows[0]["SubCategory"].ToString();
                    cmb_Size.Text = Rate.Rows[0]["Size"].ToString();
                }
            }

            catch{ }
            
            txt_Rate.Focus();
        }

        private void cmb_SubCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmb_Size.Focus();
        }
    }
}
