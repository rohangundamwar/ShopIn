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
        Simplevalidations _objSimpal = new Simplevalidations();

        public frm_RateChange()
        {
            InitializeComponent();
        }

        private void Fix_Rate_Load(object sender, EventArgs e)
        {
            cmb_Category.DataSource = _a.FillCategory();
            clear();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_SubCategory.DataSource = _a.GetSubCategoryByCategory(cmb_Category.Text);
        }

        private void cmb_size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_NewRate.Focus();
                if (cmb_SubCategory.Text != "" || cmb_SubCategory.Text != string.Empty)
                {
                    
                    DataTable Item = _Sale.GetItemRateByCategoySubCategorySize(cmb_Category.Text, cmb_SubCategory.Text, cmb_size.Text);
                    if (Item.Rows.Count > 0)
                    {
                        lbl_OldRate.Text = Item.Rows[0]["SellingPrice"].ToString();
                        lbl_OldGST.Text = Convert.ToString(Convert.ToDouble(Item.Rows[0]["GST"]));
                        
                    }
                   

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
                txt_NewGST.Focus();
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (txt_NewRate.Text != "" || txt_NewRate.Text != string.Empty)
            {
                if (txt_NewGST.Text != "" || txt_NewGST.Text != string.Empty)
                {
                    _common.ChangeRate(cmb_Category.Text, cmb_SubCategory.Text, cmb_size.Text, txt_NewRate.Text, txt_NewGST.Text);
                    MessageBox.Show("Updated Succesfully");
                    clear();
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

        private void clear()
        {
            lbl_OldRate.Text="0";
            txt_NewRate.Text = "0";
            txt_NewGST.Text = "0";
            btn_Change.Enabled = false;
            cmb_size.ResetText();
            cmb_SubCategory.ResetText();
            cmb_Category.ResetText();
            cmb_Category.Focus();
        }

        private void cmb_SubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_size.DataSource = _a.GetSizeByCatAndSubCat(cmb_Category.Text, cmb_SubCategory.Text);
        }

        private void txt_NewGST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Change.Focus();
            }
        }

        private void txt_Rate_TextChanged(object sender, EventArgs e)
        {
            btn_Change.Enabled = true;
        }

        private void txt_NewGST_TextChanged(object sender, EventArgs e)
        {
            btn_Change.Enabled = true;
        }

        private void txt_NewGST_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_NewGST.Text);
        }

        private void txt_Rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_NewRate.Text);
        }
    }
}
