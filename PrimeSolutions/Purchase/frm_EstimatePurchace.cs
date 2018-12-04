
using PrimeSolutions.Common;
using PrimeSolutions.Library;
using PrimeSolutions.Report.CrystalReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace PrimeSolutions
{
    public partial class frm_EstimatePurchace : Form
    {
        public frm_EstimatePurchace()
        {
           
            InitializeComponent();
        }

        Simplevalidations _objSimpal = new Simplevalidations();
        SQLHelper _objSQLHelper = new SQLHelper();
        Validation _objValidation = new Validation();
        AllClassFile _objCustmor = new AllClassFile();
        ErrorLog _error = new ErrorLog();
        PurchaseCommon _purchase = new PurchaseCommon();
        cls_Barcode _barcode = new cls_Barcode();
        SettingValue dtsett;
        SaleCommon _s = new SaleCommon();
        clsCommon _Common = new clsCommon();
        string supplierexs = "No";
        frm_ReportViewer _print = new frm_ReportViewer();
        cls_Barcode _Barcode = new cls_Barcode();
        public int[] PaymentIDs = new int[2];
        string Type = "Estimate";

        private void frm_PurchaseForm_Load(object sender, EventArgs e)
        {
            dtsett = new SettingValue();
            dtsett = _Common.getSettingValue();
            fillcomboox();
            Masterclear();
            Clear();
            cmb_Name.Select();
            this.BringToFront();

        }

        private void fillcomboox()
        {
            cmb_Category.DataSource = _objCustmor.FillCategory();
            cmb_SubCategory.DataSource = _objCustmor.FillSubCategory();
        }

        private void Masterclear()
        {
            cmb_Name.ResetText();
            cmb_State.SelectedIndex = 26;
            txt_Address.ResetText();
            txt_City.ResetText();
            txt_ContactNo.ResetText();
            txt_BillNo.ResetText();
            txt_PAN.ResetText();
            txt_GSTIN.ResetText();
            txt_TotalAmt.Text = "0";
            txt_NetAmt.Text = "0";
            txt_PaidAmt.Text = "0";
            txt_BalAmt.Text = "0";
            cmb_PayMode.SelectedIndex = 0;
            dgv_ItemInfo.Rows.Clear();
            Clear();
            cmb_Name.DataSource = _objCustmor.getSupplierName();
            cmb_Name.SelectedIndex = -1;
            txt_refrence.Text = _objSQLHelper.GetMaxID("PE", "0");

            try
            {
                lbl_AccNo1.Text = _objSQLHelper.GetMaxID("Q", "0");
            }
            catch (Exception ex)
            {
                _error.AddException(ex, "EstPurchase");
            }
            

        }

        private void Clear()
        {
            txt_Barcode.Text = "";
            cmb_Category.ResetText();
            cmb_SubCategory.ResetText();
            txt_HSN.Text = "";
            txt_PurchaseAmt.Text = "0";
            txt_Qty.Text = "1";
            txt_Amt.Text = "0";
            txt_BatchNo.Text = "";
            txt_SellingAmt.Text = "0";
            fillcomboox();
            cmb_size.ResetText();
        }

        private void cmb_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==  Keys.Enter)
            {
                fillSupplier();
            }

        }

        private DataTable fillSupplier()
        {
            DataTable supplier = _objCustmor.GetSupplier(cmb_Name.Text);
            if (supplier.Rows.Count > 0)
            {
                supplierexs = "Yes";
                lbl_AccNo1.Text = supplier.Rows[0]["SupplierNo"].ToString();
                cmb_State.Text = supplier.Rows[0]["state"].ToString();
                txt_Address.Text = supplier.Rows[0]["Address"].ToString();
                txt_City.Text = supplier.Rows[0]["City"].ToString();
                txt_ContactNo.Text = supplier.Rows[0]["ContactNo"].ToString();
                txt_PAN.Text = supplier.Rows[0]["PanNo"].ToString();
                txt_GSTIN.Text = supplier.Rows[0]["GSTIN"].ToString();
                txt_BillNo.Focus();
                lbl_OldBalance.Text = _s.GetBalance(lbl_AccNo1.Text, "Purchase").ToString();
            }
            else if (supplier.Rows.Count == 0)
            {
                lbl_AccNo1.Text = _objSQLHelper.GetMaxID("P", "0");
                cmb_State.SelectedIndex = 26;
                txt_Address.ResetText();
                txt_City.ResetText();
                txt_ContactNo.ResetText();
                txt_BillNo.ResetText();
                txt_PAN.ResetText();
                txt_GSTIN.ResetText();
                cmb_State.Focus();

            }
            
            return supplier;
        }

        private void txt_Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_City.Focus();
            }
        }

        private void txt_City_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ContactNo.Focus();
            }
        }

        private void txt_ContactNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_BillNo.Focus();
            }
        }

        private void txt_MobileNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_BillNo.Focus();
            }
        }

        private void txt_BillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PAN.Focus();
            }

        }

        private void cmb_Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_SubCategory.Focus();
            }
            if (e.KeyCode == Keys.End)
            {
                txt_PaidAmt.Focus();
            }

        }

        private void cmb_SubCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_size.Focus();
            }
        }

       

        private void txt_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_BatchNo.Focus();
            }
        }
        
        private void bttn_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Category.Focus();
            }
        }

        private void txt_TotalAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }

        private void txt_Vat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_NetAmt.Focus();
            }
        }

        private void txt_NetAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PaidAmt.Focus();
            }
        }

        private void txt_PaidAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_PayMode.Focus();
            }
        }

        private void txt_BalAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Purchase.Focus();
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txt_PurchaseAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Qty.Focus();
            }
        }

        private void txt_SellingAmt_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                Add();
            }
        }
        
        private void cmb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharOnly(e);
        }

        private void txt_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharDigitOnly(e);
        }

        private void txt_City_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharOnly(e);
        }

        private void txt_ContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitOnly(e);
        }

        private void txt_MobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitOnly(e);
        }

        private void txt_BillNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharDigitOnly(e);
        }

        private void cmb_Category_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharDigitSpaceOnly(e);
        }

        private void cmb_SubCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharDigitOnly(e);
        }

        private void txt_PurchaseAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_PurchaseAmt.Text);
        }

        private void txt_SellingAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_SellingAmt.Text);
        }

        private void txt_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e,txt_Qty.Text);
        }

        private void txt_Amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_Amt.Text);
        }

        private void txt_TotalAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_TotalAmt.Text);
        }
        

        private void txt_NetAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_NetAmt.Text);
        }

        private void txt_PaidAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_PaidAmt.Text);
        }

        private void txt_BalAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_BalAmt.Text);
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Amt.Text = (Convert.ToDouble(txt_PurchaseAmt.Text) * Convert.ToDouble(txt_Qty.Text)).ToString();
            }
            catch { }
        }

        private void txt_PurchaseAmt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Amt.Text = (Convert.ToDouble(txt_PurchaseAmt.Text) * Convert.ToDouble(txt_Qty.Text)).ToString();
            }
            catch (Exception ex)
            {
                _error.AddException(ex, "Estimate/Purchase");
            }
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            bool chk;
            //Insert category
            if (!_objCustmor.ItemCategory(cmb_Category.Text))
            {
                _objCustmor.InsertCategory(cmb_Category.Text);
            }

            //Insert SubCategory
            if (!_objCustmor.ItemSubCategory(cmb_SubCategory.Text))
            {
                _objCustmor.InsertSubCategory(cmb_SubCategory.Text);
            }

            if (txt_Barcode.Text == "" || (txt_Barcode.Text == string.Empty || txt_Barcode.Text == null))
            {
                chk = true;
            }
            else
            {
                chk = false;
            }
            if (cmb_Category.Text == "" || cmb_SubCategory.Text == "")
            {
                MessageBox.Show("Please Enter Item Details");
            }


            else
            {
                try
                {
                    dgv_ItemInfo.Rows.Add(chk, txt_Barcode.Text, cmb_Category.Text, cmb_SubCategory.Text,cmb_size.Text,txt_HSN.Text, txt_PurchaseAmt.Text, txt_Qty.Text, txt_Amt.Text, txt_BatchNo.Text, txt_SellingAmt.Text, "0","0","0","0","0","0");
                    Clear();
                }
                catch (Exception ex)
                {
                    _error.AddException(ex, "EstPurchase");
                }
            }
            Calculate();
            cmb_Category.Focus();
            bttn_Purchase.Enabled = true;

        }
       

        private void frm_PurchaseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.End)
            {
                txt_PaidAmt.Focus();
            }
        }

        private void Calculate()
        {
            double total = 0;
            try
            {

           
            for (int i = 0; i < dgv_ItemInfo.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                
            }

            txt_NetAmt.Text=txt_TotalAmt.Text =Convert.ToString(Math.Round(total, 2));

            }
            catch (Exception ex)
            {
                _error.AddException(ex, "EstPurchase");
            }
        }

        private void txt_VatValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PaidAmt.Focus();
            }
        }

        private void txt_BalAmt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void bttn_Purchase_Click(object sender, EventArgs e)
        {
            int p = 0;
            if (checkData())
            {
                //if (!_objCustmor.SupplierDetail(cmb_Name.Text))
                try
                {
                    if (supplierexs == "No")
                    {
                        _purchase.InsertSupplierInfo(lbl_AccNo1.Text, cmb_Name.Text, cmb_State.Text, txt_Address.Text, txt_City.Text, txt_ContactNo.Text, txt_PAN.Text, txt_GSTIN.Text, dtp_Date.Value.ToString("dd/MM/yyyy"));
                    }
                }
                catch (Exception ex)
                {
                    _error.AddException(ex, "EstPurchase_Insert_Supplier");
                }

                //try
                //{
                    for (int i = 0; i < dgv_ItemInfo.Rows.Count; i++)
                    {
                        if (_objCustmor.GetalooseItem(Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value)))
                        {

                            string category = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value);
                            string subcategory = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SubCategory"].Value);
                            string HSN = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["HSN"].Value);
                            string size = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Size"].Value);
                            string purchaseamt = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PurchaseAmt"].Value);
                            string Qty = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Qty"].Value);
                            string TotalAmt = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                            string BatchNo = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["BatchNo"].Value);
                            string SellingAmt = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SellingAmt"].Value);
                            string PBillNo = txt_BillNo.Text;

                            _purchase.InsertItem("", category, subcategory, size, PBillNo, "Purchase", Qty, "0", "0", "0", "0", "0", "0", purchaseamt, TotalAmt, BatchNo, SellingAmt, HSN, dtp_Date.Value.ToString("dd/MM/yyyy"), null, txt_refrence.Text);

                        }

                        else if (!_objCustmor.GetalooseItem(Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value)))
                        {
                            string barcode;
                            if (dgv_ItemInfo.Rows[i].Cells["Barcode"].Value == "" || dgv_ItemInfo.Rows[i].Cells[0].Value == "true")
                            {
                                barcode = _objSQLHelper.GetMaxID("B", "0");
                            }
                            else
                            {
                                barcode = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Barcode"].Value);
                            }

                            string subcategory = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SubCategory"].Value);
                            string category = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value);
                            string size = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Size"].Value);
                            string HSN = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["HSN"].Value);
                            string purchaseamt = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PurchaseAmt"].Value);
                            string qty = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Qty"].Value);
                            string TotalAmt = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                            string BatchNo = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["BatchNo"].Value);
                            string SellingAmt = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SellingAmt"].Value);
                            string BarcodePrint = dgv_ItemInfo.Rows[i].Cells["Chk"].Value.ToString();
                            string PBillNo = txt_BillNo.Text;
                            _purchase.InsertItem(barcode, category, subcategory, size, PBillNo, "Purchase", qty,"0", "0", "0", "0", "0", "0", purchaseamt, TotalAmt, BatchNo, SellingAmt, HSN, dtp_Date.Value.ToString("dd/MM/yyyy"), BarcodePrint, txt_refrence.Text);

                        }
                    }


                //}
                //catch (Exception ex)
                //{
                //    _error.AddException(ex, "EstPurchase");
                //    MessageBox.Show("Problem Inserting Item \n" + ex.Message);
                //}

                try
                {

                    if (dtsett.Barcode == "Yes")
                    {
                        _Common.InsertIntoTemp(txt_refrence.Text);
                        if (dtsett.BarcodeType == "Thermal")
                        {
                            _Barcode.PrintBarcode(Convert.ToInt32(dtsett.BarcodeCount));
                        }
                        else if (dtsett.BarcodeType == "Laser")
                        {
                            _Barcode.PrintBarcodeA4(p = 0, Convert.ToInt32(dtsett.BarcodeCount));
                        }
                    }

                    _Common.DeleteTemp();
                }
                catch (Exception ex)
                {
                    _error.AddException(ex, "Purchase/PrintBarcode");
                }

                try
                {
                    _objCustmor.InsertBillDetail(lbl_AccNo1.Text, txt_BillNo.Text, dtp_Date.Value.ToString("dd/MM/yyyy"), txt_TotalAmt.Text, "0","0","0", txt_NetAmt.Text, cmb_State.Text,Type,txt_refrence.Text);
                    if (txt_PaidAmt.Text != "0" || txt_PaidAmt.Text != "" || txt_PaidAmt.Text != string.Empty)
                    {
                        _objCustmor.InsertPaymentDetails("Supplier", txt_PaidAmt.Text, cmb_PayMode.Text, lbl_AccNo1.Text, dtp_Date.Value.ToString("dd/MM/yyyy"), txt_BillNo.Text);
                    }
                }
                catch(Exception ex)
                {
                    _error.AddException(ex, "Purchse");
                }
                
               
                Masterclear();
                MessageBox.Show("Purchased Done");
                cmb_Name.Select();
            }
        }
        private bool checkData()
        {
            if (_objValidation.IsNotEmpty(lbl_AccNo1.Text))
            {
                if (_objValidation.IsNotEmpty(cmb_Name.Text))
                {
                    if (dgv_ItemInfo.Rows.Count != 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Please enter Item Into the Cart", "ShopIn Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Supplier Details", "ShopIn Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            try {

                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Category"].Value = cmb_Category.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SubCategory"].Value = cmb_SubCategory.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["HSN"].Value = txt_HSN.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["PurchaseAmt"].Value = txt_PurchaseAmt.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Qty"].Value = txt_Qty.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["TotalAmt"].Value = txt_Amt.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["BatchNo"].Value = txt_BatchNo.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SellingAmt"].Value = txt_SellingAmt.Text;
                Calculate();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable To Edit", "Application says", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _error.AddException(ex, "EstPurchase");
            }
            bttn_Add.Enabled = true;
            Clear();

        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_ItemInfo.Rows.RemoveAt(dgv_ItemInfo.CurrentCell.RowIndex);
                Calculate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable To Delete", "Application says", MessageBoxButtons.OK, MessageBoxIcon.Error);
                int line = _error.GetLineNumber(ex);
                _error.AddException(ex, "Sale");
            }
            bttn_Add.Enabled = true;
            Clear();
        }

        private void dgv_ItemInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex >= -1 && e.ColumnIndex != 0)
                {
                    bttn_Delete.Enabled = true;
                    bttn_Update.Enabled = true;
                    bttn_Add.Enabled = false;
                    cmb_Category.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Category"].Value.ToString();
                    cmb_SubCategory.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SubCategory"].Value.ToString();
                    txt_HSN.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["HSN"].Value.ToString();
                    txt_PurchaseAmt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["PurchaseAmt"].Value.ToString();
                    txt_Qty.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Qty"].Value.ToString();
                    txt_Amt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["TotalAmt"].Value.ToString();
                    txt_BatchNo.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["BatchNo"].Value.ToString();
                    txt_SellingAmt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SellingAmt"].Value.ToString();

                }

                if (e.ColumnIndex == 0)
                {
                     if (Convert.ToString(dgv_ItemInfo.CurrentCell.Value) ==Convert.ToString(true))
                    {
                        dgv_ItemInfo.CurrentCell.Value = false;
                    }
                    else if (Convert.ToString(dgv_ItemInfo.CurrentCell.Value) == Convert.ToString(false))
                    {
                        dgv_ItemInfo.CurrentCell.Value = true;
                    }
                    
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                _error.AddException(ex, "EstPurchase");
            }
        }

        private void txt_Size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PurchaseAmt.Focus();
            }
        }

        private void cmb_State_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Address.Focus();
            }
        }

        private void txt_PAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_GSTIN.Focus();
            }
        }

        private void txt_GSTIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Barcode.Focus();
            }
            
        }

        private void txt_Barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Category.Focus();
            }
        }

        private void txt_HSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PurchaseAmt.Focus();
            }
        }

        private void txt_BatchNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_SellingAmt.Focus();
            }
            
        }
        

        private void txt_Address_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void cmb_State_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            Clear();
        }
        

        private void bttn_All_Click(object sender, EventArgs e)
        {
            dgv_ItemInfo.Rows.Clear();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_SubCategory.DataSource = _objCustmor.GetSubCategoryByCategoryNotStock(cmb_Category.Text);
        }

        private void bttn_Clear_Click(object sender, EventArgs e)
        {
            Masterclear();
            Clear();
        }

        private void cmb_PayMode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Purchase.Focus();
            }
        }

        private void dgv_ItemInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
               txt_PaidAmt.Focus();
            }
        }

        private void dgv_ItemInfo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (Convert.ToString(dgv_ItemInfo.CurrentCell.Value) == Convert.ToString(true))
                {
                    dgv_ItemInfo.CurrentCell.Value = false;
                }
                else if (Convert.ToString(dgv_ItemInfo.CurrentCell.Value) == Convert.ToString(false))
                {
                    dgv_ItemInfo.CurrentCell.Value = true;
                }

            }
        }

        private void cmb_size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_HSN.Focus();
            }
        }
        
        private void txt_PaidAmt_TextChanged(object sender, EventArgs e)
        {
            if (txt_PaidAmt.Text != null || txt_PaidAmt.Text != "")
            {
                txt_BalAmt.Text =Convert.ToString((Convert.ToInt32(lbl_OldBalance.Text) + Convert.ToInt32(txt_NetAmt.Text)) - Convert.ToInt32(txt_PaidAmt.Text))  ;
            }
            
        }
    }
}
