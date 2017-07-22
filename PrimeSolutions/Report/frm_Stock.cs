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
            dgv_stock.Rows.Clear();
            stock();
        }

        private void stock()
        {
            
            DataTable dt3 = _objstock.GetCategory(); //Category
            DataTable dt1 = new DataTable(); //SubCategory
            DataTable dt2 = new DataTable(); // Size
            string a;
            int x = 0, gcount = 0;

            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                dt1 = _objstock.GetSubCategoryByCategory(dt3.Rows[i]["category"].ToString());
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    dt2 = _objstock.GetSizeByCatAndSubCat(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString());
                    for (int k = 0; k < dt2.Rows.Count; k++)
                    {
                        
                        dgv_stock.Rows.Add();
                        x = x + 1;
                        dgv_stock.Rows[gcount].Cells["SrNo"].Value = Convert.ToString(x);
                        dgv_stock.Rows[gcount].Cells["Category"].Value = dt3.Rows[i]["category"].ToString();
                        dgv_stock.Rows[gcount].Cells["SubCategory"].Value = dt1.Rows[j]["sub_category"].ToString();
                        //DataTable X = _objstock.GetSizeByCatAndSubCat(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString());
                        dgv_stock.Rows[gcount].Cells["Size"].Value = dt2.Rows[k]["size"].ToString();
                        //DataTable Q = _objstock.GetSizeByCatAndSubCat(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString());

                        if (dt2.Rows.Count > 0)
                        {
                            a = Convert.ToString(_objstock.getQty(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString(), dt2.Rows[k]["size"].ToString()));
                            dgv_stock.Rows[gcount].Cells["Quantity"].Value = a.ToString();
                        }
                        else
                        {
                            a = Convert.ToString(_objstock.getQty(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString(), ""));
                            dgv_stock.Rows[gcount].Cells["Quantity"].Value = a.ToString();
                        }
                        gcount = gcount + 1;
                    }

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
    }
}

