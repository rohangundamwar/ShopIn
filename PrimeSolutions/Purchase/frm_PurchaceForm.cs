﻿using PrimeSolutions.ClassFile;
using PrimeSolutions.Library;
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
    public partial class frm_PurchaseForm : Form
    {
        public frm_PurchaseForm()
        {
           
            InitializeComponent();
        }

        Simplevalidations _objSimpal = new Simplevalidations();
        SQLHelper _objSQLHelper = new SQLHelper();
        Validation _objValidation = new Validation();
        AllClassFile _objCustmor = new AllClassFile();
        ErrorLog _error = new ErrorLog();
        Setting datasv;
        DataTable dtsett = new DataTable();

        private void frm_PurchaseForm_Load(object sender, EventArgs e)
        {
            dtsett = _objCustmor.getallssetting();
            fillcomboox();
            Masterclear();
            cmb_Name.Select();
            this.BringToFront();

        }

        private void fillcomboox()
        {
            cmb_Name.DataSource = _objCustmor.getCustomerName();
            //cmb_Category.DataSource = _objCustmor.FillCategory();
            //cmb_SubCategory.DataSource = _objCustmor.FillSubCategory();
        }

        private void Masterclear()
        {
            
            cmb_Name.ResetText();
            txt_Address.ResetText();
            txt_BillNo.ResetText();
            txt_City.ResetText();
            txt_ContactNo.ResetText();
            txt_PaidAmt.Text = "0";
            txt_CGSTValue.Text = "0";
            txt_CGST.Text = "0";
            txt_Qty.Text = "1";
            txt_SellingAmt.Text = "0";
            txt_PurchaseAmt.Text = "0";
            txt_IGST.Text = "0";
            txt_TotalAmt.Text = "0";
            txt_BalAmt.Text = "0";
            txt_NetAmt.Text = "0";
            Clear();


            try
            {
                lbl_AccNo1.Text = _objSQLHelper.gmGetMstID("P", "0");
            }
            catch (Exception ex)
            {
                _error.AddException(ex, "Purchase");
            }
            

        }

        private void cmb_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==  Keys.Enter)
            {
                fillSupplier();
                cmb_State.Focus();
            }

        }

        private DataTable fillSupplier()
        {
            DataTable supplier = _objCustmor.GetSupplier(cmb_Name.Text);
            if (supplier.Rows.Count > 0)
            {
                lbl_AccNo1.Text = supplier.Rows[0]["AccNo"].ToString();
                txt_Address.Text = supplier.Rows[0]["address"].ToString();
                txt_City.Text = supplier.Rows[0]["city"].ToString();
                txt_ContactNo.Text = supplier.Rows[0]["contact_no"].ToString();
            }
            else if (supplier.Rows.Count == 0)
            {
                lbl_AccNo1.Text = _objSQLHelper.gmGetMstID("P", "0");
                txt_Address.Text = "";
                txt_City.Text = "";
                txt_ContactNo.Text = "";
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
            
        }

        private void cmb_SubCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_HSN.Focus();
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
                txt_CGSTValue.Focus();
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
                txt_BalAmt.Focus();
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
                txt_CGST.Focus();
            }
        }

        private void txt_Amt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Add_Click(sender,e);
                cmb_Category.Select();
                Clear();
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
            _objSimpal.ValidationCharOnly(e);
        }

        private void cmb_SubCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharOnly(e);
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
            _objSimpal.ValidationDigitOnly(e);
        }

        private void txt_Amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_Amt.Text);
        }

        private void txt_TotalAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_TotalAmt.Text);
        }

        private void txt_Vat_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_CGSTValue.Text);
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
            {}
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            if (cmb_Category.Text == "" || cmb_SubCategory.Text == "")
            {
                MessageBox.Show("Please Enter Item Details");
            }

            //Insert category
            if (!_objCustmor.ItemCategory(cmb_Category.Text))
            {
                _objCustmor.InsertCategory(cmb_Category.Text);
            }

            //Insert SubCategory
            if (!_objCustmor.ItemCategory(cmb_SubCategory.Text))
            {
                _objCustmor.InsertSubCategory(cmb_SubCategory.Text);
            }

            else
            {
                try
                {
                    dgv_ItemInfo.Rows.Add(true, txt_Barcode.Text, cmb_Category.Text, cmb_SubCategory.Text, txt_HSN.Text, txt_PurchaseAmt.Text, txt_Qty.Text, txt_Amt.Text, txt_BatchNo.Text, txt_SellingAmt.Text, txt_CGST.Text, lbl_AmtCGST.Text, lbl_SGST.Text, lbl_AmtSGST.Text, txt_SGST.Text, txt_IGST.Text, lbl_AmtIGST.Text);
                    Clear();
                }
                catch (Exception ex)
                {
                    _error.AddException(ex, "Purchase");
                }
            }
            //Calculate();
            cmb_Category.Focus();
            bttn_Purchase.Enabled = true;

        }
        private void Clear()
        {
            txt_Barcode.Text = "";
            txt_HSN.Text = "";
            cmb_Category.ResetText();
            cmb_SubCategory.ResetText();
            txt_PurchaseAmt.Text = "0";
            txt_Qty.Text = "1";
            txt_Amt.Text = "";
            txt_BatchNo.Text = "";
            txt_SellingAmt.Text = "0";
            txt_CGST.Text = "";
            txt_SGST.Text = "";
            txt_IGST.Text = "";
            lbl_AmtCGST.Text = "0";
            lbl_AmtSGST.Text = "0";
            lbl_AmtIGST.Text = "0";

            txt_Amt.Text = "";
        }

        private void frm_PurchaseForm_Leave(object sender, EventArgs e)
        {
            
        }

        private void frm_PurchaseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Calculate()
        {
            double total = 0;

            for (int i = 0; i < dgv_ItemInfo.Rows.Count; i++)
            {
                total += Convert.ToInt32(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
            }

            txt_TotalAmt.Text = total.ToString();
            try
            {
                if (txt_CGSTValue.Text == "")
                {
                    txt_CGSTValue.Text = "0";
                   
                }
                else
                {
                    txt_CGSTValue.Text = ((Convert.ToDouble(txt_TotalAmt.Text) * Convert.ToDouble(txt_CGSTValue.Text)) / 100).ToString();
                }
                txt_NetAmt.Text = (Convert.ToDouble(txt_TotalAmt.Text) + Convert.ToDouble(txt_CGSTValue.Text)).ToString();
                txt_BalAmt.Text = (Convert.ToDouble(txt_NetAmt.Text) - Convert.ToDouble(txt_PaidAmt.Text)).ToString();
            }
            catch (Exception ex)
            {
                _error.AddException(ex, "Purchase");
            }
        }

        private void txt_Vat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_VatValue_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txt_PaidAmt_TextChanged(object sender, EventArgs e)
        {
            Calculate();
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
            int BarcodeCount = _objCustmor.getbarcode();
            if (checkData())
            {
                if (!_objCustmor.SupplierDetail(cmb_Name.Text))
                {
                    _objCustmor.InsertCustomerInfo(lbl_AccNo1.Text, cmb_Name.Text, txt_Address.Text, txt_City.Text, txt_ContactNo.Text, txt_PAN.Text, txt_BillNo.Text, dtp_Date.Value.ToString("dd/MM/yyyy"));
                }
                else
                {
                    DataTable dt = this.fillSupplier();
                    lbl_AccNo1.Text = dt.Rows[0]["AccNo"].ToString();
                }

                for (int i = 0; i < dgv_ItemInfo.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgv_ItemInfo.Rows[i].Cells["Qty"].Value) == 1)
                    {
                        if (BarcodeCount == 1)
                        {
                            string barcode = _objSQLHelper.gmGetMstID("B", "0");
                            string category = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value);
                            string subcategory = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SubCategory"].Value);
                            string purchaseamt = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PurchaseAmt"].Value);
                            //string qty = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Qty"].Value);
                            string sellingamt = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SellingAmt"].Value);
                            string Total = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                            string PBillNo = txt_BillNo.Text;
                            string size = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["size"].Value);
                            _objCustmor.InsertItem(barcode, lbl_AccNo1.Text, category, subcategory, purchaseamt, size, "1", sellingamt, Total, dtp_Date.Value.ToString("dd/MM/yyyy"), PBillNo);

                            if (dtsett.Rows[0]["Barcode"].ToString() == "Yes")
                            {
                                if (dgv_ItemInfo.Rows[i].Cells["Chk"].Value.ToString() == Convert.ToString(true))
                                {
                                    //_ objCustmor.printBarcode(barcode, category, subcategory, purchaseamt, sellingamt, size, Total, i);

                                }
                            }
                            
                        }
                        else if (BarcodeCount == 2)
                        {
                            int Qty = Convert.ToInt32(Convert.ToInt32(dgv_ItemInfo.Rows[i].Cells["Qty"].Value));
                            for (int j = 0; j < Qty; j++)
                            {
                                string barcode2 = "";
                                string category2 = "";
                                string subcategory2 = "";
                                string sellingamt2 = "";
                                string size2 = "";
                                string barcode1 = _objSQLHelper.gmGetMstID("B", "0");
                                string category1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value);
                                string subcategory1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SubCategory"].Value);
                                string purchaseamt1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PurchaseAmt"].Value);
                                //string qty = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Qty"].Value);
                                string sellingamt1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SellingAmt"].Value);
                                string Total1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                                string PBillNo1 = txt_BillNo.Text;
                                string size1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["size"].Value);
                                _objCustmor.InsertItem(barcode1, lbl_AccNo1.Text, category1, subcategory1, purchaseamt1, size1, "1", sellingamt1, Total1, dtp_Date.Value.ToString("dd/MM/yyyy"), PBillNo1);
                                if (dtsett.Rows[0]["Barcode"].ToString() == "Yes")
                                {
                                    if (dgv_ItemInfo.Rows[i].Cells["Chk"].Value.ToString() == Convert.ToString(true))
                                    {
                                        // _objCustmor.printBarcode(barcode1, barcode2, category1, category2, subcategory1, subcategory2, sellingamt1, sellingamt2, size1, size2, j);

                                    }
                                }
                                j++;
                            }
                        }
                    }
                    else if (Convert.ToInt32(dgv_ItemInfo.Rows[i].Cells["Qty"].Value) > 1)
                    {
                        if(BarcodeCount==1)
                        { 
                        int Qty = Convert.ToInt32(Convert.ToInt32(dgv_ItemInfo.Rows[i].Cells["Qty"].Value));
                        for (int j = 0; j < Qty; j++)
                        {
                            string barcode = _objSQLHelper.gmGetMstID("B", "0");
                            string category = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value);
                            string subcategory = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SubCategory"].Value);
                            string purchaseamt = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PurchaseAmt"].Value);
                            //string qty = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Qty"].Value);
                            string sellingamt = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SellingAmt"].Value);
                            string Total = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                            string PBillNo = txt_BillNo.Text;
                            string size = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["size"].Value);
                            _objCustmor.InsertItem(barcode, lbl_AccNo1.Text, category, subcategory, purchaseamt,size, "1", sellingamt, Total, dtp_Date.Value.ToString("dd/MM/yyyy"), PBillNo);
                                if (dtsett.Rows[0]["Barcode"].ToString() == "Yes")
                                {
                                    if (dgv_ItemInfo.Rows[i].Cells["Chk"].Value.ToString() == Convert.ToString(true))
                                    {
                                        //_objCustmor.printBarcode(barcode, category, subcategory, purchaseamt, sellingamt,size,Total, i);
                                    }
                                }
                            }
                        }
                        else if (BarcodeCount == 2)
                        {
                            int Qty = Convert.ToInt32(Convert.ToInt32(dgv_ItemInfo.Rows[i].Cells["Qty"].Value));
                            for (int j = 0; j < Qty; j++)
                            {
                                string barcode2 = "";
                                string category2 = "";
                                string subcategory2 = "";
                                string sellingamt2 = "";
                                string size2 = "";
                                string barcode1 = _objSQLHelper.gmGetMstID("B", "0");
                                string category1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value);
                                string subcategory1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SubCategory"].Value);
                                string purchaseamt1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PurchaseAmt"].Value);
                                //string qty = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Qty"].Value);
                                string sellingamt1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SellingAmt"].Value);
                                string Total1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                                string PBillNo1 = txt_BillNo.Text;
                                string size1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["size"].Value);
                                _objCustmor.InsertItem(barcode1, lbl_AccNo1.Text, category1, subcategory1, purchaseamt1,size1, "1", sellingamt1, Total1, dtp_Date.Value.ToString("dd/MM/yyyy"), PBillNo1);
                                if (Qty-j>=2)
                                {
                                    barcode2 = _objSQLHelper.gmGetMstID("B", "0");
                                    category2 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value);
                                    subcategory2 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SubCategory"].Value);
                                    string purchaseamt2 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PurchaseAmt"].Value);
                                    //string qty = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Qty"].Value);
                                    sellingamt2 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SellingAmt"].Value);
                                    string Total2 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                                    string PBillNo2 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PBill"].Value);
                                    size2 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["size"].Value);
                                    _objCustmor.InsertItem(barcode2, lbl_AccNo1.Text, category2, subcategory2, purchaseamt2, size2, "1", sellingamt2, Total1, dtp_Date.Value.ToString("dd/MM/yyyy"), PBillNo1);
                                }
                                if (dtsett.Rows[0]["Barcode"].ToString() == "Yes")
                                {
                                    if (dgv_ItemInfo.Rows[i].Cells["Chk"].Value.ToString() == Convert.ToString(true))
                                    {
                                        //_objCustmor.printBarcode(barcode1, barcode2, category1, category2, subcategory1, subcategory2, sellingamt1, sellingamt2, size1, size2, j);

                                    }
                                }
                                j++;
                            }
                        }
                    }
                }
                _objCustmor.InsertBillDetail(txt_TotalAmt.Text, txt_CGSTValue.Text, txt_CGSTValue.Text, txt_NetAmt.Text, txt_PaidAmt.Text, txt_BalAmt.Text, lbl_AccNo1.Text, dtp_Date.Value.ToString("dd/MM/yyyy"), txt_BillNo.Text);
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
                        MessageBox.Show("Please enter Item Into the Cart", "Software Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }
                }
                else
                {
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
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["PurchaseAmt"].Value = txt_PurchaseAmt.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SellingAmt"].Value = txt_SellingAmt.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Qty"].Value = txt_Qty.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["TotalAmt"].Value = txt_Amt.Text;
                Calculate();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable To Delete", "Application says", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _error.AddException(ex, "Purchase");
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
                    
                    txt_PurchaseAmt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["PurchaseAmt"].Value.ToString();
                    txt_SellingAmt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SellingAmt"].Value.ToString();
                    txt_Qty.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Qty"].Value.ToString();
                    txt_Amt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["TotalAmt"].Value.ToString();
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
                _error.AddException(ex,"Purchase");
            }
        }

        private void txt_Size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PurchaseAmt.Focus();
            }
        }

        private void cmb_Category_Enter(object sender, EventArgs e)
        {
            cmb_Category.FlatStyle = System.Windows.Forms.FlatStyle.Popup ;
        }

        private void cmb_SubCategory_Enter(object sender, EventArgs e)
        {
            cmb_SubCategory.FlatStyle= System.Windows.Forms.FlatStyle.Popup;
        }

        private void cmb_Category_Leave(object sender, EventArgs e)
        {
            cmb_Category.FlatStyle = FlatStyle.Standard;
        }

        private void cmb_SubCategory_Leave(object sender, EventArgs e)
        {
            cmb_SubCategory.FlatStyle = FlatStyle.Standard;
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

        private void txt_CGST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_SGST.Focus();
            }

            if (e.KeyCode == Keys.Space)
            {
                Add();
            }

        }

        private void txt_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_IGST_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SGST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_IGST.Focus();
            }

        }

        private void txt_IGST_KeyDown(object sender, KeyEventArgs e)
        {
            Add();
        }
    }
}
