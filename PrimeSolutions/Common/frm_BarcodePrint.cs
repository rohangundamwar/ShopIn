
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
        AllClassFile _objBarcode = new AllClassFile();
        PurchaseCommon _p = new PurchaseCommon();
        frm_ReportViewer _crt = new frm_ReportViewer();
        cls_Barcode _barcode = new cls_Barcode();
        clsCommon _common = new clsCommon();
        DataTable Bill ;
        AllClassFile _objCustmor = new AllClassFile();
        SQLHelper _sql = new SQLHelper();
        Simplevalidations _valid = new Simplevalidations();
        DataTable Supplier; 

        public frm_BarcodePrint()
        {
            InitializeComponent();
            Supplier = _objCustmor.GetAllSupplier();
        }
        
       
        
        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {
            DataTable bar = new DataTable();
            int BarcodeCount = _objBarcode.getbarcode();
            DataTable dtsett = _objBarcode.getallssetting();
            bar.Columns.Add("Category");
            bar.Columns.Add("SubCategory");
            bar.Columns.Add("SellingAmt");
            bar.Columns.Add("Barcode");
            bar.Columns.Add("Size");
            bar.Columns.Add("Qty");

            for (int i = 0; i < dgv_BarcodeDetail.Rows.Count; i++)
            {
                if (dgv_BarcodeDetail.Rows[i].Cells["Chk"].Value.ToString() == Convert.ToString(true))
                {   
                    string category = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["Category"].Value);
                    string subcategory = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["SubCategory"].Value);
                    string sellingamt = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["SellingAmt"].Value);
                    string barcode = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["Barcode"].Value);
                    string Size = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["size"].Value);
                    string Qty = Convert.ToString(dgv_BarcodeDetail.Rows[i].Cells["Qty"].Value);
                    bar.Rows.Add(category, subcategory, sellingamt, barcode, Size,Qty);
                }

            }
            _common.InsertIntoTemp(bar);

            if (dtsett.Rows[0]["BarcodeType"].ToString() == "Thermal")
            {
                if (BarcodeCount == 1)
                {
                    _barcode.PrintBarcode(1);
                }
                else if (BarcodeCount == 2)
                {
                    _barcode.PrintBarcode(2);
                }
            }
            
            else if (dtsett.Rows[0]["BarcodeType"].ToString() == "Laser")
            {
                _barcode.PrintBarcodeA4(1);
            }

            _common.DeleteTemp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_BarcodeDetail.Rows.Clear();
            DataTable dt = _objBarcode.getBarcodeItemByRefrence(txt_Refrence.Text);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgv_BarcodeDetail.Rows.Add();
                    dgv_BarcodeDetail.Rows[i].Cells["SrNo"].Value = i + 1;
                    dgv_BarcodeDetail.Rows[i].Cells["Chk"].Value = true;
                    dgv_BarcodeDetail.Rows[i].Cells["Barcode"].Value = dt.Rows[i]["Barcode"].ToString();
                    dgv_BarcodeDetail.Rows[i].Cells["Category"].Value = dt.Rows[i]["category"].ToString();
                    dgv_BarcodeDetail.Rows[i].Cells["SubCategory"].Value = dt.Rows[i]["SubCategory"].ToString();
                    dgv_BarcodeDetail.Rows[i].Cells["SellingAmt"].Value = dt.Rows[i]["SellingPrice"].ToString();
                    dgv_BarcodeDetail.Rows[i].Cells["Size"].Value = dt.Rows[i]["Size"].ToString();
                    dgv_BarcodeDetail.Rows[i].Cells["Qty"].Value = dt.Rows[i]["Qty"].ToString();
                }
            }
            

        }

        private void Add()
        {
            string Barcode = _sql.GetMaxID("B", "0");
            string gst = Convert.ToString(Convert.ToInt32(txt_GST.Text) / 2);
            _p.InsertItem(Barcode, cmb_category.Text, cmb_SubCategory.Text, cmb_Size.Text, "", "Barcode", "", gst, "", gst, "", "", "", "", "", "", txt_SellingPrice.Text, "", "", "", "");
            dgv_BarcodeDetail.Rows.Add(true, dgv_BarcodeDetail.Rows.Count + 1, "", cmb_category.Text, cmb_SubCategory.Text, txt_SellingPrice.Text, cmb_Size.Text, txt_Qty.Text);
            cmb_category.Focus();
        }

        private void frm_BarcodePrint_Load(object sender, EventArgs e)
        {
            Clear();
            
        }

        private void Reset()
        {
            cmb_Supplier.DataSource = _objCustmor.GetAllSupplier();
            cmb_category.DataSource = _objCustmor.FillCategory();
            txt_GST.ResetText();
            txt_SellingPrice.ResetText();
            txt_Qty.ResetText();
            cmb_category.Select();
        }

        private void Clear()
        {
            Reset();
            dgv_BarcodeDetail.Rows.Clear();
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

            if (e.KeyCode == Keys.Add)
            {
               Add();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bill = _p.GetSupplierBill(Supplier.Rows[cmb_Supplier.SelectedIndex]["SupplierNo"].ToString());
            cmb_PBillNo.DataSource = Bill;
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            Add();
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
                txt_SellingPrice.Focus();
            }
        }

        private void txt_SellingPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Qty.Focus();
            }
        }

        private void txt_GST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Add.Focus();
            }
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            dgv_BarcodeDetail.Rows.RemoveAt(dgv_BarcodeDetail.CurrentCell.RowIndex);
        }

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_SubCategory.DataSource = _objCustmor.GetSubCategoryByCategoryNotStock(cmb_category.Text);
        }

        private void cmb_SubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Size.DataSource = _objCustmor.GetSizeByCatAndSubCat(cmb_category.Text, cmb_SubCategory.Text);
        }

        private void txt_SellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            _valid.ValidationDigitWithPoint(e, txt_SellingPrice.Text);
        }

        private void txt_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            _valid.ValidationDigitWithPoint(e,txt_Qty.Text);
        }

        private void txt_GST_KeyPress(object sender, KeyPressEventArgs e)
        {
            _valid.ValidationDigitOnly(e);
        }

        private void txt_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_GST.Focus();
            }
        }

        private void cmb_PBillNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Refrence = Bill.Rows[Convert.ToInt32(cmb_PBillNo.SelectedIndex)]["RefrenceNo"].ToString();
            txt_Refrence.Text = Refrence;
        }
    }

}
