
using PrimeSolutions.Common;
using PrimeSolutions.Library;
using PrimeSolutions.Report.CrystalReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace PrimeSolutions
{
    public partial class frm_PurchaseForm : Form
    {
        public frm_PurchaseForm()
        {
           
            InitializeComponent();
        }

        public delegate void SendData(string RefrenceNo, string type);
        Simplevalidations _objSimpal = new Simplevalidations();
        SQLHelper _objSQLHelper = new SQLHelper();
        Validation _objValidation = new Validation();
        AllClassFile _objCustmor = new AllClassFile();
        ErrorLog _error = new ErrorLog();
        PurchaseCommon _purchase = new PurchaseCommon();
        SaleCommon _sale = new SaleCommon();
        SettingValue dtsett;
        clsCommon _Common = new clsCommon();
        cls_Barcode _Barcode = new cls_Barcode();
        string supplierexs = "No";
        public int[] PaymentIDs = new int[2];
        string VouchertypeID = "0";
        string Type = "GST";
        string CustomerLedgerID = null;

        private void frm_PurchaseForm_Load(object sender, EventArgs e)
        {
            dtsett = new SettingValue();
            dtsett = _Common.getSettingValue();
            Masterclear();
            Clear();
            fillcomboox();
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
            txt_CGSTValue.Text = "";
            txt_SGSTValue.Text = "";
            txt_IGSTValue.Text = "";
            txt_NetAmt.Text = "0";
            txt_PaidAmt.Text = "0";
            txt_BalAmt.Text = "0";
            txt_OtherCharges.Text = "0";
            cmb_PayMode.SelectedIndex = 0;
            dgv_ItemInfo.Rows.Clear();
            Clear();
            cmb_Name.DataSource = _objCustmor.getSupplierName();
            cmb_Name.SelectedIndex = -1;
            txt_PurchaseRef.Text= _objSQLHelper.GetMaxID("PR", "0");

            try
            {
                lbl_AccNo1.Text = _objSQLHelper.GetMaxID("P", "0");
            }
            catch (Exception ex)
            {
                _error.AddException(ex, "Purchase");
            }
            

        }

        private void Clear()
        {
            txt_Barcode.Text = "";
            cmb_Category.ResetText();
            cmb_SubCategory.ResetText();
            cmb_size.ResetText();
            txt_HSN.Text = "";
            txt_PurchaseAmt.Text = "0";
            txt_Qty.Text = "1";
            txt_Amt.Text = "0";
            txt_BatchNo.Text = "";
            txt_SellingAmt.Text = "0";
            txt_CGST.Text = "0";
            lbl_AmtCGST.Text = "0";
            txt_SGST.Text = "0";
            lbl_AmtSGST.Text = "0";
            txt_IGST.Text = "0";
            lbl_AmtIGST.Text = "0";
            fillcomboox();
        }

        private void cmb_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==  Keys.Enter)
            {
                new CultureInfo("en-US", false).TextInfo.ToTitleCase(Regex.Replace(cmb_Name.Text, @"\s+", " ").Trim() as String);
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
                txt_OldBalance.Text = _sale.GetBalance(lbl_AccNo1.Text, "Purchase").ToString();
                cmb_State.Text = supplier.Rows[0]["state"].ToString();
                txt_Address.Text = supplier.Rows[0]["Address"].ToString();
                txt_City.Text = supplier.Rows[0]["City"].ToString();
                txt_ContactNo.Text = supplier.Rows[0]["ContactNo"].ToString();
                txt_PAN.Text = supplier.Rows[0]["PanNo"].ToString();
                txt_GSTIN.Text = supplier.Rows[0]["GSTIN"].ToString();
                txt_BillNo.Focus();
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
                txt_PAN.Focus();
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
                txt_Barcode.Focus();
            }

        }

        private void cmb_Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                new CultureInfo("en-US", false).TextInfo.ToTitleCase(Regex.Replace(cmb_Category.Text, @"\s+", " ").Trim() as String);
                cmb_SubCategory.Focus();
            }
        }

        private void cmb_SubCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                new CultureInfo("en-US", false).TextInfo.ToTitleCase(Regex.Replace(cmb_SubCategory.Text, @"\s+", " ").Trim() as String);
                cmb_size.Focus();
            }
        }

       

        private void txt_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PurchaseAmt.Focus();
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
                txt_BatchNo.Focus();
            }
        }

        private void txt_SellingAmt_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_CGST.Enabled == true)
                {
                    txt_CGST.Focus();
                }
                else
                {
                    txt_IGST.Focus();
                }
               
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
            _objSimpal.ValidationCharDigitOnly(e);
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
            //_objSimpal.ValidationDigitWithPoint(e, txt_BalAmt.Text);
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_PurchaseAmt.Text = Math.Round((Convert.ToDouble(txt_Amt.Text) / Convert.ToDouble(txt_Qty.Text)), 2).ToString();
            }
            catch { }
        }

        private void txt_PurchaseAmt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            bool chk;
            //Insert category
            //if (!_objCustmor.ItemCategory(cmb_Category.Text))
            //{
            //    _objCustmor.InsertCategory(cmb_Category.Text);
            //}

            ////Insert SubCategory
            //if (!_objCustmor.ItemSubCategory(cmb_SubCategory.Text))
            //{
            //    _objCustmor.InsertSubCategory(cmb_SubCategory.Text);
            //}
            
            if (txt_Barcode.Text == "" || txt_Barcode.Text == string.Empty)
            {
                chk = true;
            }
            else
            {
                chk = false;
            }

            if (cmb_Category.Text == "" || cmb_SubCategory.Text == "")
            {
                if (cmb_Category.Text == string.Empty || cmb_SubCategory.Text == string.Empty)
                    MessageBox.Show("Please Enter Item Details");
            }

            else
            {
                try
                {
                    dgv_ItemInfo.Rows.Add(chk, txt_Barcode.Text, cmb_Category.Text, cmb_SubCategory.Text,cmb_size.Text,txt_HSN.Text, txt_PurchaseAmt.Text, txt_Qty.Text, txt_Amt.Text, txt_BatchNo.Text, txt_SellingAmt.Text, txt_CGST.Text, lbl_AmtCGST.Text, txt_SGST.Text, lbl_AmtSGST.Text, txt_IGST.Text, lbl_AmtIGST.Text);
                    Clear();
                }
                catch (Exception ex)
                {
                    _error.AddException(ex, "Purchase");
                }
            }
            if (!_objCustmor.CheckRateMaster(cmb_Category.Text, cmb_SubCategory.Text, cmb_size.Text))
                _objCustmor.InsertRateMaster(txt_Barcode.Text, cmb_Category.Text, cmb_SubCategory.Text, cmb_size.Text, txt_SellingAmt.Text, Convert.ToString(Convert.ToDouble(txt_CGST.Text) + Convert.ToDouble(txt_SGST.Text) + Convert.ToDouble(txt_IGST.Text)));

            Calculate();
            txt_Barcode.Focus();
            bttn_Purchase.Enabled = true;

        }
       

        private void frm_PurchaseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Add)
            {
                Add();
            }
            if (e.KeyCode == Keys.End)
            {
                txt_OtherCharges.Focus();
            }

        }

        private void Calculate()
        {
            double total = 0;
            double CGSTAmt = 0;
            double SGSTAmt = 0;
            double IGSTAmt = 0;
            try
            {

           
            for (int i = 0; i < dgv_ItemInfo.Rows.Count; i++)
            {
                total += Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value),2);
                CGSTAmt += Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["CGST"].Value),2) ;
                SGSTAmt += Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["SGST"].Value),2);
                IGSTAmt +=Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["IGST"].Value),2) ;
            }

            txt_TotalAmt.Text = total.ToString();
            txt_CGSTValue.Text = CGSTAmt.ToString();
            txt_SGSTValue.Text = SGSTAmt.ToString();
            txt_IGSTValue.Text = IGSTAmt.ToString();

            txt_NetAmt.Text =Convert.ToString(total + CGSTAmt + SGSTAmt + IGSTAmt); 

            }
            catch (Exception ex)
            {
                _error.AddException(ex, "Purchase");
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
            int BarcodeCount =Convert.ToInt32(dtsett.BarcodeCount);
            string TransactionLedgerID = null;


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
                    _error.AddException(ex, "Purchase");
                }

                try
                {
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
                            string CGSTper = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["CGSTper"].Value);
                            string CGST = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["CGST"].Value);
                            string SGSTper = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SGSTper"].Value);
                            string SGST = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SGST"].Value);
                            string IGSTper = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["IGSTper"].Value);
                            string IGST = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["IGST"].Value);
                            string PBillNo = txt_BillNo.Text;

                            _purchase.InsertItem("", category, subcategory, size, PBillNo, "Purchase", Qty, CGSTper, CGST, SGSTper, SGST, IGSTper, IGST, purchaseamt, TotalAmt, BatchNo, SellingAmt, HSN, dtp_Date.Value.ToString("dd/MM/yyyy"), null,txt_PurchaseRef.Text);

                        }

                        else if (!_objCustmor.GetalooseItem(Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value)))
                        {
                            string barcode;
                            if (dgv_ItemInfo.Rows[i].Cells["Barcode"].Value == "" || dgv_ItemInfo.Rows[i].Cells["Barcode"].Value == string.Empty)
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
                            string CGSTper = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["CGSTper"].Value);
                            string CGST = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["CGST"].Value);
                            string SGSTper = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SGSTper"].Value);
                            string SGST = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SGST"].Value);
                            string IGSTper = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["IGSTper"].Value);
                            string IGST = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["IGST"].Value);
                            string BarcodePrint = dgv_ItemInfo.Rows[i].Cells["Chk"].Value.ToString();
                            string PBillNo = txt_BillNo.Text;
                            _purchase.InsertItem(barcode, category, subcategory, size, PBillNo, "Purchase", qty, CGSTper, CGST, SGSTper, SGST, IGSTper, IGST, purchaseamt, TotalAmt, BatchNo, SellingAmt, HSN, dtp_Date.Value.ToString("dd/MM/yyyy"), BarcodePrint,txt_PurchaseRef.Text);
                            
                        }
                    }
                }
                
                catch (Exception ex)
                {
                    _error.AddException(ex, "Purchase/InsetItem");
                }
                try
                {
                    
                    if (dtsett.Barcode == "Yes")
                    {
                        //insert Into Temp Table
                        _Common.InsertIntoTemp(txt_PurchaseRef.Text);

                        if (dtsett.BarcodeType == "Thermal")
                        {
                            _Barcode.PrintBarcode(Convert.ToInt32(dtsett.BarcodeCount));
                        }
                        else if (dtsett.BarcodeType == "Laser")
                        {   
                            _Barcode.PrintBarcodeA4(p = 0,Convert.ToInt32(dtsett.BarcodeCount));
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
                    
                    _objCustmor.InsertBillDetail(lbl_AccNo1.Text, txt_BillNo.Text, dtp_Date.Value.ToString("dd/MM/yyyy"), txt_TotalAmt.Text, txt_CGSTValue.Text, txt_SGSTValue.Text, txt_IGSTValue.Text, txt_NetAmt.Text, cmb_State.Text,Type,txt_PurchaseRef.Text);
                    if(txt_PaidAmt.Text != "0" || txt_PaidAmt.Text != "" || txt_PaidAmt.Text != string.Empty)
                    {
                        _objCustmor.InsertPaymentDetails("Supplier", txt_PaidAmt.Text, cmb_PayMode.Text, lbl_AccNo1.Text, dtp_Date.Value.ToString("dd/MM/yyyy"), txt_BillNo.Text);
                    }
                }
                catch(Exception ex)
                {
                    _error.AddException(ex, "Purchse");
                }

                try
                {
                    CustomerLedgerID = _purchase.insertAcountLedgerDetailPurchase(Vouchertypeid: VouchertypeID, SupplierName: cmb_Name.Text, AccNo: lbl_AccNo1.Text, Date: dtp_Date.Text, narration: "");
                    string VouchertypeIDPayment = _Common.getALLTableDetails(sTableName: TableNames.VoucherType, sColomnName: "VoucherTypeName", sColumnValue: "Purchase Receipt Voucher").Rows[0]["VoucherTypeID"].ToString();
                    bool Payformstatus = true;
                    if (Convert.ToDouble(txt_PaidAmt.Text) == 0)
                    {
                        DialogResult dr1 = MessageBox.Show("Save with Zero Amount :" + txt_PaidAmt.Text + "\n\n Do You Want To Continue", "JMS Says ", MessageBoxButtons.YesNo);
                        if (dr1 == DialogResult.No)
                        {
                            Payformstatus = false;
                        }
                    }
                    else if (Convert.ToDouble(txt_PaidAmt.Text) > 0)
                    {
                        DialogResult dr = MessageBox.Show("Amount to be Payed : " + txt_PaidAmt.Text + "\n\n Do You Want To Continue", "JMS Says ", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            if (dtsett.PaymentForm == "1")
                            {
                                PaymentOption.frm_PaymentOptionForPaymentVoucher form = new PaymentOption.frm_PaymentOptionForPaymentVoucher(txt_PaidAmt.Text, txt_BillNo.Text, lbl_AccNo1.Text, dtp_Date.Text, CustomerType.SupplierPurchaseGST, OperationType.Create);
                                form.ShowDialog();
                                PaymentIDs = form.PaymentIDs;
                                Payformstatus = true;
                                TransactionLedgerID = form.TransactionLedgerID;
                                if (form.ReturnStatus == false)
                                {
                                    Payformstatus = false;
                                }
                            }
                            else if (dtsett.PaymentForm == "0")
                            {
                                Payformstatus = true;
                            }
                        }
                        else if (dr == DialogResult.No)
                        {
                            Payformstatus = false;
                        }
                    }
                    _purchase.InsertCreditDebitInPurchaseAccount(customerLedgerID: CustomerLedgerID, VouchertypeID: VouchertypeID, sbillno: txt_BillNo.Text, CurrentAmount: txt_PaidAmt.Text, date: dtp_Date.Text, Date: dtp_Date.Text, SupplierName: cmb_Name.Text, Narration: "");
                }
                catch (Exception ex)
                {
                    _error.AddException(ex, "Purchse");
                }
                try
                {
                    Report.CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new Report.CrystalReport.frm_ReportViewer();
                    SendData _obj = new SendData(_objfrm_ReportViewer.SupplierBill);
                    _obj(txt_PurchaseRef.Text, "Print");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    _error.AddException(ex, "Purchacse/BillPrint");
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
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["CGST"].Value = lbl_AmtCGST.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["CGSTper"].Value = txt_CGST.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SGST"].Value = lbl_AmtSGST.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SGSTper"].Value = txt_SGST.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["IGST"].Value = lbl_AmtIGST.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["IGSTper"].Value = txt_IGST.Text;
                Calculate();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable To Edit", "Application says", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    txt_HSN.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["HSN"].Value.ToString();
                    txt_PurchaseAmt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["PurchaseAmt"].Value.ToString();
                    txt_Qty.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Qty"].Value.ToString();
                    txt_Amt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["TotalAmt"].Value.ToString();
                    txt_BatchNo.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["BatchNo"].Value.ToString();
                    txt_SellingAmt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SellingAmt"].Value.ToString();
                    lbl_AmtCGST.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["CGST"].Value.ToString();
                    txt_CGST.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["CGSTper"].Value.ToString();
                    lbl_AmtSGST.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SGST"].Value.ToString();
                    txt_SGST.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SGSTper"].Value.ToString();
                    lbl_AmtIGST.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["IGST"].Value.ToString();
                    txt_IGST.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["IGSTper"].Value.ToString();

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
                txt_BillNo.Focus();
            }
            
        }

        private void txt_Barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_Barcode.Text != "")
                {
                    if (fillitem())
                    {
                        txt_Amt.Focus();
                    }
                    else
                    {
                        cmb_Category.Focus();
                    }
                }
                else if (txt_Barcode.Text == "" || txt_Barcode.Text == string.Empty)
                {
                    cmb_Category.Focus();
                }

            }
        }

        private bool fillitem()
        {
            DataTable GST = new DataTable();
            DataTable Rate = new DataTable();
            bool i = false;

            if (txt_Barcode.Text != "" || txt_Barcode.Text != string.Empty)
            {
                GST = _sale.GetItemDetailsByBarcode(txt_Barcode.Text);
                Rate = _sale.GetItemRateByBarcode(txt_Barcode.Text);

                if (GST.Rows.Count > 0)
                {
                    try
                    {
                        cmb_Category.Text = GST.Rows[0]["Category"].ToString();
                        cmb_SubCategory.Text = GST.Rows[0]["SubCategory"].ToString();
                        cmb_size.Text = GST.Rows[0]["size"].ToString();
                        txt_HSN.Text = GST.Rows[0]["HSN"].ToString();
                        txt_BatchNo.Text = GST.Rows[0]["BatchNo"].ToString();

                        if (Rate.Rows.Count > 0)
                        {
                            txt_SellingAmt.Text = Rate.Rows[0]["SellingPrice"].ToString();

                            if (txt_IGST.Enabled == true)
                            {
                                txt_IGST.Text = Convert.ToString(Convert.ToDouble(Rate.Rows[0]["GST"]));
                            }
                            else
                            {
                                double CGST = Convert.ToDouble(Rate.Rows[0]["GST"]) / 2;
                                txt_CGST.Text = CGST.ToString();
                                double SGST = Convert.ToDouble(Rate.Rows[0]["GST"]) / 2;
                                txt_SGST.Text = SGST.ToString();
                            }

                        }
                        else
                        {
                            txt_SellingAmt.Text = GST.Rows[0]["SellingPrice"].ToString();

                            if (txt_IGST.Enabled == true)
                            {
                                txt_IGST.Text = Convert.ToString(Convert.ToDouble(GST.Rows[0]["CGST"]) + Convert.ToDouble(GST.Rows[0]["SGST"]) + Convert.ToDouble(GST.Rows[0]["IGST"]));
                            }
                            else
                            {
                                double CGST = (Convert.ToDouble(GST.Rows[0]["CGST"]) + Convert.ToDouble(GST.Rows[0]["SGST"]) + Convert.ToDouble(GST.Rows[0]["IGST"])) / 2;
                                txt_SGST.Text = txt_CGST.Text = CGST.ToString();
                                
                            }
                        }
                       
                       
                    }
                    catch { }
                    i = true;
                }
            }

            if (txt_Barcode.Text == "" || txt_Barcode.Text == string.Empty)
            {
                GST = _sale.GetItemDetailsByCategoySubCategorySize(cmb_Category.Text, cmb_SubCategory.Text, cmb_size.Text);
                Rate = _sale.GetItemRateByCategoySubCategorySize(cmb_Category.Text, cmb_SubCategory.Text, cmb_size.Text);

                if (GST.Rows.Count > 0)
                {
                    try
                    {
                        cmb_Category.Text = GST.Rows[0]["Category"].ToString();
                        cmb_SubCategory.Text = GST.Rows[0]["SubCategory"].ToString();
                        txt_HSN.Text = GST.Rows[0]["HSN"].ToString();
                        txt_BatchNo.Text = GST.Rows[0]["BatchNo"].ToString();

                        if (Rate.Rows.Count > 0)
                        {
                            txt_SellingAmt.Text = Rate.Rows[0]["SellingPrice"].ToString();

                            if (txt_IGST.Enabled == true)
                            {
                                txt_IGST.Text = Convert.ToString(Convert.ToDouble(Rate.Rows[0]["GST"]));
                            }
                            else
                            {
                                double CGST = Convert.ToDouble(Rate.Rows[0]["GST"]) / 2;
                                txt_CGST.Text = CGST.ToString();
                                double SGST = Convert.ToDouble(Rate.Rows[0]["GST"]) / 2;
                                txt_SGST.Text = SGST.ToString();
                            }

                        }
                        else
                        {
                            txt_SellingAmt.Text = GST.Rows[0]["SellingPrice"].ToString();

                            if (txt_IGST.Enabled == true)
                            {
                                txt_IGST.Text = Convert.ToString(Convert.ToDouble(GST.Rows[0]["CGST"]) + Convert.ToDouble(GST.Rows[0]["SGST"]) + Convert.ToDouble(GST.Rows[0]["IGST"]));
                            }
                            else
                            {
                                double CGST = (Convert.ToDouble(GST.Rows[0]["CGST"]) + Convert.ToDouble(GST.Rows[0]["SGST"]) + Convert.ToDouble(GST.Rows[0]["IGST"])) / 2;
                                txt_SGST.Text = txt_CGST.Text = CGST.ToString();

                            }
                        }
                    }
                    catch { }
                    i = true;
                }
            }
            return i;
        }

        private void txt_HSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Amt.Focus();
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
        
        private void txt_SGST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add();
            }

        }
        

        private void txt_CGST_TextChanged(object sender, EventArgs e)
        {
            lbl_AmtCGST.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_Amt.Text) * (Convert.ToDouble(txt_CGST.Text) * 0.01)), 2));
        }

        private void txt_SGST_TextChanged(object sender, EventArgs e)
        {
            lbl_AmtSGST.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_Amt.Text) * (Convert.ToDouble(txt_SGST.Text) * 0.01)), 2));
        }

        private void txt_IGST_TextChanged(object sender, EventArgs e)
        {
            lbl_AmtIGST.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_Amt.Text) * (Convert.ToDouble(txt_IGST.Text) * 0.01)), 2));
        }

        private void cmb_State_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_State.Text == _objCustmor.GetState())
            {
                txt_IGST.Enabled = false;
                txt_CGST.Enabled = true;
                txt_SGST.Enabled = true;
            }
            else
            {
                txt_IGST.Enabled = true;
                txt_CGST.Enabled = false;
                txt_SGST.Enabled = false;

            }
        }

        private void txt_CGST_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_CGST.Text);
        }

        private void txt_SGST_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_SGST.Text);
        }

        private void txt_IGST_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_IGST.Text);
        }

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txt_IGST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add();
            }
        }

        private void bttn_All_Click(object sender, EventArgs e)
        {
            DialogResult DGVClear = MessageBox.Show("Do you Want to Clear all Items", " Are You Sure ", MessageBoxButtons.YesNo);
            if (DGVClear == DialogResult.Yes)
            {
                dgv_ItemInfo.Rows.Clear();
            }
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bttn_Clear_Click(object sender, EventArgs e)
        {
            Masterclear();
            Clear();
        }

        private void cmb_size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (fillitem())
                {
                    txt_Amt.Focus();
                }
                else
                {
                    txt_HSN.Focus();
                }
                
            }
        }

        private void txt_PaidAmt_TextChanged(object sender, EventArgs e)
        {
            if ((txt_OldBalance.Text != "" || txt_OldBalance.Text != "0") || txt_OldBalance.Text != string.Empty)
                if ((txt_NetAmt.Text != "" || txt_NetAmt.Text != "0") || txt_NetAmt.Text != string.Empty)
                    if ((txt_PaidAmt.Text != "" || txt_PaidAmt.Text != "0") || txt_PaidAmt.Text != string.Empty)
                        txt_BalAmt.Text = Convert.ToString((Convert.ToDouble(txt_OldBalance.Text) + Convert.ToDouble(txt_NetAmt.Text)) - Convert.ToDouble(txt_PaidAmt.Text));
        }

        private void cmb_PayMode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Purchase.Focus();
            }
        }

        private void txt_NetAmt_TextChanged(object sender, EventArgs e)
        {
            ChangeTotalBill();
        }

        private void ChangeTotalBill()
        {
            if ((txt_NetAmt.Text != "" || txt_NetAmt.Text != string.Empty) && (txt_OtherCharges.Text != "" || txt_OtherCharges.Text != string.Empty))
            {
                int Total = Convert.ToInt32(Convert.ToDecimal(txt_NetAmt.Text) + Convert.ToDecimal(txt_OtherCharges.Text));
                txt_TotalBill.Text = "₹" + txt_NetAmt.Text + "+" + "₹" + txt_OtherCharges.Text + '\n' + "₹" + Convert.ToString(Total);
            }
            
        }

        private void txt_OtherCharges_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PaidAmt.Focus();
            }
        }

        private void txt_OtherCharges_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Total = Convert.ToInt32(Convert.ToDecimal(txt_NetAmt.Text) + Convert.ToDecimal(txt_OtherCharges.Text));
                txt_TotalBill.Text = "₹" + txt_NetAmt.Text + "+" + "₹" + txt_OtherCharges.Text + '\n' + "₹" + Convert.ToString(Total);
            }
            catch { }
           
        }

        private void txt_Amt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_PurchaseAmt.Text = Math.Round((Convert.ToDouble(txt_Amt.Text) / Convert.ToDouble(txt_Qty.Text)),2).ToString();
            }
            catch { }
        }

        private void txt_Amt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Qty.Focus();
            }
        }

        private void cmb_SubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_size.DataSource = _objCustmor.GetSize();
        }
    }
}
