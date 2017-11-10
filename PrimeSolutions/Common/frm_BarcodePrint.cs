
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;
using PrimeSolutions.Report.CrystalReport;

namespace PrimeSolutions.Common
{
    public partial class frm_BarcodePrint : Form
    {
        public frm_BarcodePrint()
        {
            InitializeComponent();
        }
        AllClassFile _objBarcode = new AllClassFile();
        PurchaseCommon _p = new PurchaseCommon();
        frm_ReportViewer _crt = new frm_ReportViewer();
        cls_Barcode _barcode = new cls_Barcode();

        
        private void bttn_View_Click(object sender, EventArgs e)
        {
           // int j = 1;
           // dgv_BarcodeDetail.Rows.Clear();
           //// DataTable dt = _objBarcode.getBarcodeItem(dtp_Start.Value.ToString("dd/MM/yyyy"), dtp_End.Value.ToString("dd/MM/yyyy"));
           // for (int i = 0; i < dt.Rows.Count; i++)
           // {
           //     dgv_BarcodeDetail.Rows.Add();
           //     dgv_BarcodeDetail.Rows[i].Cells["SrNo"].Value = j;
           //     dgv_BarcodeDetail.Rows[i].Cells["Chk"].Value = true;
           //     dgv_BarcodeDetail.Rows[i].Cells["Barcode"].Value = dt.Rows[i]["Barcode"].ToString();
           //     dgv_BarcodeDetail.Rows[i].Cells["Category"].Value = dt.Rows[i]["category"].ToString();
           //     dgv_BarcodeDetail.Rows[i].Cells["SubCategory"].Value = dt.Rows[i]["sub_category"].ToString();
           //     dgv_BarcodeDetail.Rows[i].Cells["PurchaseAmt"].Value = dt.Rows[i]["purchase_amt"].ToString();
           //     dgv_BarcodeDetail.Rows[i].Cells["SellingAmt"].Value = dt.Rows[i]["sale_amt"].ToString();
           //     dgv_BarcodeDetail.Rows[i].Cells["Qty"].Value = dt.Rows[i]["qty"].ToString();
           //     dgv_BarcodeDetail.Rows[i].Cells["Size"].Value = dt.Rows[i]["size"].ToString();
           //     dgv_BarcodeDetail.Rows[i].Cells["Total"].Value = dt.Rows[i]["Total"].ToString();
           //     j++;
           // }


        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {
            int p = 0;
            int BarcodeCount = _objBarcode.getbarcode();
            DataTable dtsett = _objBarcode.getallssetting();
            if (dtsett.Rows[0]["BarcodeType"].ToString() == "Thermal")
            {
                if (BarcodeCount == 1)
                {
                    for (int i = 0; i < dgv_BarcodeDetail.Rows.Count; i++)
                    {
                        if (dgv_BarcodeDetail.Rows[i].Cells["Chk"].Value.ToString() == Convert.ToString(true))
                        {

                            string category = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["Category"].Value);
                            string subcategory = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["SubCategory"].Value);
                            string purchaseamt = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["PurchaseAmt"].Value);
                            string sellingamt = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["SellingAmt"].Value);
                            string Total = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["Total"].Value);
                            string barcode = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["Barcode"].Value);
                            string size = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["size"].Value);
                            //_p.printBarcode(barcode, category, subcategory, purchaseamt, sellingamt, size, Total, i);
                        }

                    }
                }

                else if (BarcodeCount == 2)
                {
                    for (int i = 0; i < dgv_BarcodeDetail.Rows.Count; i++)
                    {
                        if (dgv_BarcodeDetail.Rows[i].Cells["Chk"].Value.ToString() == Convert.ToString(true))
                        {
                            string barcode2 = "";
                            string category2 = "";
                            string subcategory2 = "";
                            string sellingamt2 = "";
                            string size2 = "";
                            string purchaseamt2 = "";
                            string Total2 = "";
                            barcode2 = "";
                            string category1 = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["Category"].Value);
                            string subcategory1 = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["SubCategory"].Value);
                            string purchaseamt1 = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["PurchaseAmt"].Value);
                            string sellingamt1 = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["SellingAmt"].Value);
                            string Total1 = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["Total"].Value);
                            string size1 = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["size"].Value);
                            string barcode1 = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["Barcode"].Value);
                            category2 = Convert.ToString(dgv_BarcodeDetail.Rows[i + 1].Cells["Category"].Value);
                            subcategory2 = Convert.ToString(dgv_BarcodeDetail.Rows[i + 1].Cells["SubCategory"].Value);
                            purchaseamt2 = Convert.ToString(dgv_BarcodeDetail.Rows[i + 1].Cells["PurchaseAmt"].Value);
                            sellingamt2 = Convert.ToString(dgv_BarcodeDetail.Rows[i + 1].Cells["SellingAmt"].Value);
                            Total2 = Convert.ToString(dgv_BarcodeDetail.Rows[i + 1].Cells["Total"].Value);
                            size2 = Convert.ToString(dgv_BarcodeDetail.Rows[i + 1].Cells["size"].Value);
                            barcode2 = Convert.ToString(dgv_BarcodeDetail.Rows[i + 1].Cells["Barcode"].Value);
                            i++;
                            //_objBarcode.printBarcode(barcode1, barcode2, category1, category2, subcategory1, subcategory2, sellingamt1, sellingamt2, size1, size2, i);
                        }
                    }
                }
            }

            else if (dtsett.Rows[0]["BarcodeType"].ToString() == "Laser")
            {
                _barcode.PrintBarcodeA4(txt_PBillNo.Text, p);
            }
                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j = 1;
            dgv_BarcodeDetail.Rows.Clear();
            DataTable dt = _objBarcode.getBarcodeItemByBilNo(txt_PBillNo.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv_BarcodeDetail.Rows.Add();
                dgv_BarcodeDetail.Rows[i].Cells["SrNo"].Value = j;
                dgv_BarcodeDetail.Rows[i].Cells["Chk"].Value = true;
                dgv_BarcodeDetail.Rows[i].Cells["Barcode"].Value = dt.Rows[i]["Barcode"].ToString();
                dgv_BarcodeDetail.Rows[i].Cells["Category"].Value = dt.Rows[i]["category"].ToString();
                dgv_BarcodeDetail.Rows[i].Cells["SubCategory"].Value = dt.Rows[i]["SubCategory"].ToString();
                //dgv_BarcodeDetail.Rows[i].Cells["PurchaseAmt"].Value = dt.Rows[i]["purchase_amt"].ToString();
                dgv_BarcodeDetail.Rows[i].Cells["SellingAmt"].Value = dt.Rows[i]["SellingPrice"].ToString();
                dgv_BarcodeDetail.Rows[i].Cells["Qty"].Value = dt.Rows[i]["qty"].ToString();
                //dgv_BarcodeDetail.Rows[i].Cells["Size"].Value = dt.Rows[i]["size"].ToString();
                //dgv_BarcodeDetail.Rows[i].Cells["Total"].Value = dt.Rows[i]["Total"].ToString();
                j++;
            }

        }

        private void frm_BarcodePrint_Load(object sender, EventArgs e)
        {
            DataTable dt = _p.GetSupplierBillNo();
            txt_PBillNo.DataSource = dt;
        }

        private void dgv_BarcodeDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (dgv_BarcodeDetail.CurrentCell.Value.ToString() == Convert.ToString(true))
                {
                    dgv_BarcodeDetail.CurrentCell.Value = false;
                }
                else if (dgv_BarcodeDetail.CurrentCell.Value.ToString() ==Convert.ToString(false))
                {
                    dgv_BarcodeDetail.CurrentCell.Value = true;
                }

            }
        }

        private void frm_BarcodePrint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
