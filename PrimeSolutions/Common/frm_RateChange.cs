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
    public partial class frm_RateChange : Form
    {
        AllClassFile _a = new AllClassFile();
        SaleCommon _Sale = new SaleCommon();
        clsCommon _common = new clsCommon();

        public frm_RateChange()
        {
            InitializeComponent();
        }

        private void Fix_Rate_Load(object sender, EventArgs e)
        {
            cmb_Category.DataSource = _a.FillCategory();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_SubCategory.DataSource = _a.GetSubCategoryByCategory(cmb_Category.Text);
        }

        private void cmb_size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Rate.Focus();
                if (cmb_SubCategory.Text != "" || cmb_SubCategory.Text != string.Empty)
                {
                    DataTable GST = _Sale.GetItemDetailsByCategoySubCategorySize(cmb_Category.Text, cmb_SubCategory.Text, cmb_size.Text);
                    lbl_OldRate.Text = GST.Rows[0]["SellingPrice"].ToString();
                }
            }
        }

        private void cmb_Category_KeyDown(object sender, KeyEventArgs e)
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
                cmb_size.Focus();
            }
        }

        private void txt_Rate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Change.Focus();
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (txt_Rate.Text == "" || txt_Rate.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
            else
            {
                _common.ChangeRate(cmb_Category.Text, cmb_SubCategory.Text, cmb_size.Text, txt_Rate.Text);
                MessageBox.Show("Updated Succesfully");
                clear();
            }
        }

        private void clear()
        {
            cmb_Category.ResetText();
            cmb_SubCategory.ResetText();
            cmb_size.ResetText();
            lbl_OldRate.Text="0";
            txt_Rate.Text = "0";
            cmb_Category.Focus();
        }

        private void cmb_SubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_size.DataSource = _a.GetSizeByCatAndSubCat(cmb_Category.Text, cmb_SubCategory.Text);
        }
    }
}
