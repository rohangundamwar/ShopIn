using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;

namespace PrimeSolutions.Report
{
    public partial class frm_Stock : Form
    {
        public frm_Stock()
        {
            InitializeComponent();
        }
        clsCommon _common = new clsCommon();
        AllClassFile _objstock = new AllClassFile();
        ExportToExcel _e = new ExportToExcel();
        
        private void frm_Stock_Load(object sender, EventArgs e)
        {

            DataTable dt3 = _objstock.FillCategory(); //Category
            cmb_category.DataSource = dt3;
            cmb_category.SelectedIndex = -1;

            DataTable dt2 = _objstock.FillSubCategory();
            cmb_SubCategory.DataSource = dt2;
            cmb_SubCategory.SelectedIndex = -1;

            dgv_stock.Rows.Clear();
            stock();

        }

        private void stock()
        {
            DataTable cat = _objstock.FillCategory(); //Category
            //DataTable SubCat = _objstock.GetSubCategoryByCategory(cmb_category.Text);
            DataTable SubCat = new DataTable(); //SubCategory
            string a;
            int x = 0, gcount = 0;
            dgv_stock.Rows.Clear();
            for (int i = 0; i < cat.Rows.Count; i++)
            {
                SubCat = _objstock.GetSubCategoryByCategory(cat.Rows[i]["category"].ToString());
                for (int j = 0; j < SubCat.Rows.Count; j++)
                {
                    dgv_stock.Rows.Add();
                    x = x + 1;
                    dgv_stock.Rows[gcount].Cells["SrNo"].Value = Convert.ToString(x);
                    dgv_stock.Rows[gcount].Cells["Category"].Value = cat.Rows[i]["category"].ToString();
                    dgv_stock.Rows[gcount].Cells["SubCategory"].Value = SubCat.Rows[j]["subcategory"].ToString();
                    dgv_stock.Rows[gcount].Cells["Size"].Value = SubCat.Rows[j]["size"].ToString();
                    a = Convert.ToString(_objstock.getQty(cat.Rows[i]["category"].ToString(), SubCat.Rows[j]["subcategory"].ToString(), SubCat.Rows[j]["Size"].ToString()));
                    if (Convert.ToDouble(a.Remove(a.Length - 4)) <= 5)
                    {
                        dgv_stock.Rows[gcount].DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                        
                    dgv_stock.Rows[gcount].Cells["Quantity"].Value = a.ToString();
                    gcount = gcount + 1;
                }

            }
        }
           
       
        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_Excel_Click(object sender, EventArgs e)
        {
            _e.exporttoexcel(dgv_stock, "Stock", dtp_Date.Value.ToString("dd_MM_yyyy"));
        }

        private void bttn_Sort_Click(object sender, EventArgs e)
        {
            
            if (cmb_category.Text != "" || cmb_category.Text != string.Empty)
            {
                DataTable SubCat = _objstock.GetSubCategoryByCategory(cmb_category.Text);
                dgv_stock.Rows.Clear();
                for (int i = 0; i < SubCat.Rows.Count; i++)
                {
                    dgv_stock.Rows.Add();
                    dgv_stock.Rows[i].Cells["SrNo"].Value = (i + 1).ToString();
                    dgv_stock.Rows[i].Cells["Category"].Value = cmb_category.Text;
                    dgv_stock.Rows[i].Cells["SubCategory"].Value = SubCat.Rows[i]["SubCategory"].ToString();
                    dgv_stock.Rows[i].Cells["Size"].Value = SubCat.Rows[i]["Size"].ToString();
                    dgv_stock.Rows[i].Cells["Quantity"].Value = _objstock.getQty(cmb_category.Text, SubCat.Rows[i]["SubCategory"].ToString(), SubCat.Rows[i]["Size"].ToString());

                }

            }
            else if (cmb_category.Text == "" || cmb_category.Text == string.Empty)
            {
                DataTable Cat = _objstock.GetCategoryBySubCategory(cmb_SubCategory.Text);
                dgv_stock.Rows.Clear();
                for (int i = 0; i < Cat.Rows.Count; i++)
                {
                    dgv_stock.Rows.Add();
                    dgv_stock.Rows[i].Cells["SrNo"].Value = i + 1.ToString();
                    dgv_stock.Rows[i].Cells["Category"].Value = Cat.Rows[i]["Category"].ToString();
                    dgv_stock.Rows[i].Cells["SubCategory"].Value = cmb_SubCategory.Text;
                    dgv_stock.Rows[i].Cells["Size"].Value = Cat.Rows[i]["Size"].ToString();
                    dgv_stock.Rows[i].Cells["Quantity"].Value = _objstock.getQty(Cat.Rows[i]["Category"].ToString(), cmb_SubCategory.Text, Cat.Rows[i]["Size"].ToString());
                }
            }
                 
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable SubCat = _objstock.GetSubCategoryByCategory(cmb_category.Text);
            cmb_SubCategory.DataSource = SubCat;
            cmb_SubCategory.SelectedIndex = -1;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            frm_Stock_Load(sender, e);
        }
    }
}

