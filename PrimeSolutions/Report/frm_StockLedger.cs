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
    public partial class frm_StockLedger : Form
    {
        public frm_StockLedger()
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

        }

        private void stock()
        {
            DataTable dt3 = _objstock.FillCategory(); //Category
            DataTable dt2 = _objstock.GetSubCategoryByCategory(cmb_category.Text);
            DataTable dt1 = new DataTable(); //SubCategory
            string a;
            int x = 0, gcount = 0;
            dgv_stock.Rows.Clear();
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                dt1 = _objstock.GetSubCategoryByCategory(dt3.Rows[i]["category"].ToString());
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    dgv_stock.Rows.Add();
                    x = x + 1;
                    dgv_stock.Rows[gcount].Cells["SrNo"].Value = Convert.ToString(x);
                    dgv_stock.Rows[gcount].Cells["Category"].Value = dt3.Rows[i]["category"].ToString();
                    dgv_stock.Rows[gcount].Cells["SubCategory"].Value = dt1.Rows[j]["subcategory"].ToString();
                    dgv_stock.Rows[gcount].Cells["Size"].Value = dt1.Rows[j]["Size"].ToString();
                    a = Convert.ToString(_objstock.getQty(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["subcategory"].ToString(), dt1.Rows[j]["Size"].ToString()));
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
            _e.exporttoexcel(dgv_stock, "StckLdgr", dtp_from.Value.ToString("dd_MM_yyyy")+"to"+dtp_To.Value.ToString("dd_MM_yyyy"));
        }

        private void bttn_Sort_Click(object sender, EventArgs e)
        {
            int x=0,i;
            Tuple<DataTable,DataTable> Stock = _objstock.GetStock(dtp_from.Value.ToString("dd/MM/yyyy"),dtp_To.Value.ToString("dd/MM/yyyy"));
            
            DataTable Purchase = Stock.Item1;
            DataTable Sale = Stock.Item2;

            dgv_stock.Rows.Clear();

            //Purchase
            dgv_stock.Rows.Add("Purchase");
            for (i = 0; i < Purchase.Rows.Count; i++)
            {
                dgv_stock.Rows.Add();
                dgv_stock.Rows[i+1].Cells["SrNo"].Value = (i + 1).ToString();
                dgv_stock.Rows[i+1].Cells["Category"].Value = Purchase.Rows[i]["Category"].ToString();
                dgv_stock.Rows[i+1].Cells["SubCategory"].Value = Purchase.Rows[i]["SubCategory"].ToString();
                dgv_stock.Rows[i+1].Cells["Size"].Value = Purchase.Rows[i]["Size"].ToString();
                dgv_stock.Rows[i+1].Cells["Quantity"].Value= Purchase.Rows[i]["Qty"].ToString();
                dgv_stock.Rows[i + 1].Cells["BillNo"].Value = Purchase.Rows[i]["BillNo"].ToString();
                dgv_stock.Rows[i + 1].Cells["Date"].Value = Purchase.Rows[i]["Date"].ToString();
            }

            //sale

            dgv_stock.Rows.Add("Sale");
            for (int j = 0; j < Sale.Rows.Count; j++)
            {
                dgv_stock.Rows.Add();
                dgv_stock.Rows[j + i + 2].Cells["SrNo"].Value = (j + 1).ToString();
                dgv_stock.Rows[j + i + 2].Cells["Category"].Value = Sale.Rows[j]["Category"].ToString();
                dgv_stock.Rows[j + i + 2].Cells["SubCategory"].Value = Sale.Rows[j]["SubCategory"].ToString();
                dgv_stock.Rows[j + i + 2].Cells["Size"].Value = Sale.Rows[j]["Size"].ToString();
                dgv_stock.Rows[j + i + 2].Cells["Quantity"].Value = Sale.Rows[j]["Qty"].ToString();
                dgv_stock.Rows[j + i + 2].Cells["BillNo"].Value = Sale.Rows[j]["BillNo"].ToString();
                dgv_stock.Rows[j + i + 2].Cells["Date"].Value = Sale.Rows[j]["Date"].ToString();
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

