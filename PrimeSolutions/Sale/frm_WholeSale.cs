using PrimeSolutions.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.PaymentOption;
using PrimeSolutions.Common;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PrimeSolutions

{
    public partial class frm_WholeSale : Form
    {
        public delegate void SendData(string BillNO,string type);
        Simplevalidations _objSimpal = new Simplevalidations();
        SQLHelper _objSQLHelper = new SQLHelper();
        clsCommon _common = new clsCommon();
        SaleCommon _Sale = new SaleCommon();
        CustomerCommon _Cust = new CustomerCommon();
        ErrorLog _error = new ErrorLog();
        AllClassFile _a = new AllClassFile();
        SettingValue dtSett;
        string Customerexs = "No";
        string state ;
        public int[] PaymentIDs = new int[2];
        string VouchertypeID = "0";
        string VouchertypeIDPayment = "0";
        string VouchertypeIDMod = "0";
        string VouchertypeIDModPayment = "0";
        DataTable dt_cust;
        DataView dw;

        public frm_WholeSale()
        {
            dtSett = new SettingValue();
            dtSett = _common.getSettingValue();
            InitializeComponent();
            state = _a.GetState();
            VouchertypeID = _common.getALLTableDetails(sTableName: TableNames.VoucherType, sColomnName: "VoucherTypeName", sColumnValue: "Sales Invoice GST").Rows[0]["VoucherTypeID"].ToString();
            VouchertypeIDPayment = _common.getALLTableDetails(sTableName: TableNames.VoucherType, sColomnName: "VoucherTypeName", sColumnValue: "Sales Receipt Voucher").Rows[0]["VoucherTypeID"].ToString();

        }

        private void frm_PurchaseForm_Load(object sender, EventArgs e)
        {
            dt_cust = _Cust.GetCustomerDeatils();
            this.BringToFront();
            cmb_Category.DataSource = _a.FillCategory();
            cmb_SubCategory.DataSource = _a.FillSubCategory();
            cmb_Name.DataSource = dt_cust;
            cmb_Name.Select();
            Clear();
            Masterclear();
        }

        private void Masterclear()
        {
            txt_BillNo.Text = _objSQLHelper.GetMaxID("W", "0");
            txt_AccNo.Text = _objSQLHelper.GetMaxID("C", "0");
            
            cmb_Name.SelectedIndex = -1;
            cmb_PayMode.SelectedIndex = 0;
            cmb_State.Text = state;
            txt_PanNo.Text = "";
            txt_GSTIN.Text = "";
            txt_BalanceAmt.Text="0";
            txt_Balance.Text = "0";
            txt_BillAmt.Text = "0";
            txt_Address.ResetText();
            txt_City.ResetText();
            txt_ContactNo.ResetText();
            txt_NetAmt.Text="0";
            txt_TotalAmt.Text = "0";
            txt_PaidAmt.Text = "0";
            dgv_ItemInfo.Rows.Clear();
            bttn_Sale.Enabled = false;
            cmb_Name.Select();
            
            
        }

        private void Clear()
        {
            txt_BarcodeNo.ResetText();
            cmb_size.ResetText();
            txt_HSN.ResetText();
            txt_BatchNo.ResetText();
            txt_Qty.Text = "1";
            txt_Amt.Text = "0";
            txt_CGSTper.Text = "0";
            txt_SGSTper.Text = "0";
            txt_IGSTper.Text = "0";
            lbl_BasePrice.Text = "0";
            txt_SellingAmt.Text = "0";
        }

        private void cmb_Name_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                new CultureInfo("en-US", false).TextInfo.ToTitleCase(Regex.Replace(cmb_Name.Text, @"\s+", " ").Trim() as String);

                if (findCustomer() == 1)
                {
                    cmb_State.Enabled = false;
                    cmb_Category.Focus();
                    string balance = Convert.ToString(_Sale.GetBalance(cmb_Name.Text,"Sale"));
                    if (balance != "" || balance != string.Empty)
                    {
                        txt_Balance.Text = balance;
                        txt_BalanceAmt.Text = balance;
                    }
                    else
                    {
                        txt_Balance.Text = "0";
                        txt_BalanceAmt.Text = "0";
                    }
                }
                else
                {
                    Customerexs = "No";
                    txt_Balance.Text = "0";
                    txt_BalanceAmt.Text = "0";
                    cmb_State.Enabled = true;
                    cmb_State.Focus();
                    txt_AccNo.Text = _objSQLHelper.GetMaxID("C", "0");
                    txt_Address.Text = "";
                    cmb_State.Text = _a.GetState();
                    txt_City.Text = "";
                    txt_ContactNo.Text = "";
                    txt_PanNo.Text = "";
                    txt_GSTIN.Text = "";
                }
            }
            
        }

        private void searchCustomer()
        {
            dw = new DataView(dt_cust);
            dw.RowFilter = string.Format("CustomerName LIKE '%{0}%'", cmb_Name.Text);
            dt_cust = dw.ToTable();
            cmb_Name.DataSource = dw;
            if (dt_cust.Rows.Count > 0)
            {
                cmb_Name.DroppedDown = true;
            }
        }

        private int findCustomer()
        {
            DataTable dt = _Sale.GetCustomerDetails(cmb_Name.Text);
            int i = 0;
            if (dt.Rows.Count > 0)
            {
                Customerexs = "Yes";
                txt_AccNo.Text = dt.Rows[0]["CustId"].ToString();
                txt_Address.Text = dt.Rows[0]["Address"].ToString();
                cmb_State.Text = dt.Rows[0]["State"].ToString();
                txt_City.Text = dt.Rows[0]["City"].ToString();
                txt_ContactNo.Text = dt.Rows[0]["ContactNo"].ToString();
                txt_PanNo.Text = dt.Rows[0]["PanNo"].ToString();
                txt_GSTIN.Text = dt.Rows[0]["GSTIN"].ToString();
                return i = 1;
            }
            else
                return i;

        }

        private void fillitem()
        {
            if (txt_BarcodeNo.Text != "" || txt_BarcodeNo.Text != string.Empty)
            {
                DataTable GST = _Sale.GetItemDetailsByBarcode(txt_BarcodeNo.Text);
                if (GST.Rows.Count > 0)
                {
                    try
                    {
                        cmb_Category.Text = GST.Rows[0]["Category"].ToString();
                        cmb_SubCategory.Text = GST.Rows[0]["SubCategory"].ToString();
                        txt_HSN.Text = GST.Rows[0]["HSN"].ToString();
                        txt_BatchNo.Text = GST.Rows[0]["BatchNo"].ToString();
                        txt_SellingAmt.Text = GST.Rows[0]["SellingPrice"].ToString();
                        Double TotalGST = Convert.ToDouble(GST.Rows[0]["CGST"].ToString()) + Convert.ToDouble(GST.Rows[0]["SGST"].ToString()) + Convert.ToDouble(GST.Rows[0]["IGST"].ToString());
                        if (cmb_State.Text == state)
                        {
                            txt_CGSTper.Text = Convert.ToString(TotalGST / 2);
                            txt_SGSTper.Text = Convert.ToString(TotalGST / 2);
                        }
                        else
                        {
                            txt_IGSTper.Text = Convert.ToString(TotalGST);
                        }
                    }
                    catch { }
                    
                }
            }
            if (txt_BarcodeNo.Text == "" || txt_BarcodeNo.Text == string.Empty)
            {
                DataTable GST = _Sale.GetItemDetailsByCategoySubCategorySize(cmb_Category.Text, cmb_SubCategory.Text,cmb_size.Text);
                if (GST.Rows.Count > 0)
                {
                    try
                    {
                        cmb_Category.Text = GST.Rows[0]["Category"].ToString();
                        cmb_SubCategory.Text= GST.Rows[0]["SubCategory"].ToString();
                        txt_HSN.Text = GST.Rows[0]["HSN"].ToString();
                        txt_BatchNo.Text = GST.Rows[0]["BatchNo"].ToString();
                        txt_SellingAmt.Text = GST.Rows[0]["SellingPrice"].ToString();
                        Double TotalGST = Convert.ToDouble(GST.Rows[0]["CGST"].ToString()) + Convert.ToDouble(GST.Rows[0]["SGST"].ToString()) + Convert.ToDouble(GST.Rows[0]["IGST"].ToString());
                        if (cmb_State.Text == state)
                        {
                            txt_CGSTper.Text = Convert.ToString(TotalGST / 2);
                            txt_SGSTper.Text = Convert.ToString(TotalGST / 2);
                        }
                        else
                        {
                            txt_IGSTper.Text = Convert.ToString(TotalGST);
                        }
                    }
                    catch { }

                }
            }
            CalculateBase();
            CalculateGST();
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

        private void txt_MobileNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_BarcodeNo.Focus();
            }
        }

        private void txt_BillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Category.Focus();
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
               txt_Discount.Focus();
            }
        }

        private void cmb_SubCategory_KeyDown(object sender, KeyEventArgs e)

        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_size.Select();
            }
        }

       

        private void txt_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_CGSTper.Enabled == true)
                    txt_CGSTper.Focus();
                else
                    txt_IGSTper.Focus();
            }
            
        }
        
        private void bttn_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_TotalAmt.Focus();
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

       

        private void txt_BalAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Sale.Focus();
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
                try
                {
                    if (txt_BarcodeNo.Text != "")
                    {
                        fillitem();
                    }

                }
                catch { }
                if (txt_BarcodeNo.Text == "" || txt_BarcodeNo.Text==string.Empty)
                {
                    cmb_Category.Focus();
                }
            }
        }

        private void txt_SellingAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Qty.Focus();
            }
        }

        private void txt_Amt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Add.Focus();
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
            _objSimpal.ValidationCharDigitOnly(e);
        }

        private void txt_PurchaseAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharDigitOnly(e);
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

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            txt_Amt.Text = "";
            try
            {
                if (txt_SellingAmt.Text != "" || txt_SellingAmt.Text != string.Empty)
                    if (txt_Qty.Text != "" || txt_Qty.Text != string.Empty)
                        txt_Amt.Text = Convert.ToString(Math.Round(Convert.ToDouble(txt_SellingAmt.Text) * Convert.ToDouble(txt_Qty.Text),2));
            }
            catch { }
            CalculateGST();
            CalculateTotalBase();
        }

        private void txt_BarcodeNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            try
            {
                dgv_ItemInfo.Rows.Add(txt_BarcodeNo.Text, cmb_Category.Text, cmb_SubCategory.Text, txt_HSN.Text, txt_BatchNo.Text, lbl_BasePrice.Text, txt_Qty.Text, lbl_TotalPrice.Text, txt_CGSTper.Text, lbl_CGSTAmt.Text, txt_SGSTper.Text, lbl_SGSTAmt.Text, txt_IGSTper.Text, lbl_IGSTAmt.Text, txt_Amt.Text);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Calculate();
            bttn_Sale.Enabled = true;
            cmb_Category.Focus();
        }
        

        private void CalculateGST()
        {
            if (lbl_CGSTAmt.Text != "" || lbl_CGSTAmt.Text != string.Empty)
            {
                if(txt_CGSTper.Text != "" || txt_CGSTper.Text != string.Empty)
                lbl_CGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_CGSTper.Text) * 0.01) * (Convert.ToDouble(lbl_BasePrice.Text)* Convert.ToDouble(txt_Qty.Text)), 2));

                if (lbl_SGSTAmt.Text != "" || lbl_SGSTAmt.Text != string.Empty )
                {
                    if (txt_SGSTper.Text != "" || txt_SGSTper.Text != string.Empty)
                    lbl_SGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_SGSTper.Text) * 0.01) * (Convert.ToDouble(lbl_BasePrice.Text) * Convert.ToDouble(txt_Qty.Text)), 2));

                    if (lbl_IGSTAmt.Text != "" || lbl_IGSTAmt.Text != string.Empty)
                    {
                        if(txt_IGSTper.Text != "" || txt_IGSTper.Text != string.Empty)
                        lbl_IGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_IGSTper.Text) * 0.01) * (Convert.ToDouble(lbl_BasePrice.Text) * Convert.ToDouble(txt_Qty.Text)), 2));
                    }
                }
            }
        }

        private void calculatetotal()
        {
            double total;
            double CGSTAmt = 0;
            double SGSTAmt = 0;
            double IGSTAmt = 0;
            if (lbl_CGSTAmt.Text != "" || lbl_CGSTAmt.Text != string.Empty)
            {
                CGSTAmt = Convert.ToDouble(lbl_CGSTAmt.Text);
                if (lbl_SGSTAmt.Text != "" || lbl_SGSTAmt.Text != string.Empty)
                {
                    SGSTAmt = Convert.ToDouble(lbl_SGSTAmt.Text);
                    if (lbl_IGSTAmt.Text != "" || lbl_IGSTAmt.Text != string.Empty)
                    {
                        IGSTAmt = Convert.ToDouble(lbl_IGSTAmt.Text);
                    }
                }
            }

            total = Convert.ToDouble(lbl_BasePrice.Text) + CGSTAmt + SGSTAmt + IGSTAmt;
            txt_Amt.Text = total.ToString();
        }

        private void CalculateBase()
        {
            lbl_BasePrice.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_SellingAmt.Text) * 100) / (100 + Convert.ToDouble(txt_CGSTper.Text) + Convert.ToDouble(txt_SGSTper.Text) + Convert.ToDouble(txt_IGSTper.Text)), 2)) ;
         
        }

        private void CalculateTotalBase()
        {
            if (lbl_BasePrice.Text != "" || txt_Qty.Text != "" || lbl_BasePrice.Text != string.Empty || txt_Qty.Text != string.Empty)
                lbl_TotalPrice.Text = Convert.ToString(Math.Round(Convert.ToDouble(lbl_BasePrice.Text) * Convert.ToDouble(txt_Qty.Text),2));
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
                    total +=Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value),2);
                    CGSTAmt += Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["CGST"].Value),2);
                    SGSTAmt += Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["SGST"].Value),2);
                    IGSTAmt += Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["IGST"].Value),2);
                }

                txt_TotalAmt.Text = total.ToString();
                lbl_CGSTValue.Text = CGSTAmt.ToString();
                lbl_SGSTValue.Text = SGSTAmt.ToString();
                lbl_IGSTValue.Text = IGSTAmt.ToString();

                txt_NetAmt.Text = txt_BillAmt.Text =Convert.ToString(_common.sumGridViewColumn(dgv_ItemInfo, "TotalPrice"));

            }
            catch (Exception ex)
            {
                _error.AddException(ex, "Purchase");
            }
        }

        private void calculateDiscount()
        {
            if ((txt_Discount.Text != "" || txt_Discount.Text != string.Empty) || txt_Discount.Text != " ")
            {
                double NetAmt = Convert.ToDouble(txt_NetAmt.Text);
                double Discount = Convert.ToDouble(txt_Discount.Text);
                double BillAmt = NetAmt - Discount;
                txt_BillAmt.Text = Convert.ToString(BillAmt);
            }
                
        }

        private void bttn_Sale_Click(object sender, EventArgs e)
        {
            string BillNo = txt_BillNo.Text;
            string TransactionLedgerID = null;

            MessageBox.Show("Do you Want to Continue With Bill Amount of ₹ " + txt_NetAmt.Text.ToString());
            
            if (cmb_Name.Text != "" || txt_ContactNo.Text != "")
            {
                if(Customerexs=="No")
                {
                    _Cust.AddCustomerDetails(txt_AccNo.Text, cmb_Name.Text, txt_Address.Text, txt_ContactNo.Text,txt_PanNo.Text,txt_GSTIN.Text,cmb_State.Text,txt_City.Text,"");
                }
            }
            try
            {

                for (int i = 0; i < dgv_ItemInfo.Rows.Count; i++)
                {
                    string barcode = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["BarcodeNo"].Value);
                    string category = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value);
                    string subcategory = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SubCategory"].Value);
                    string HSN = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["HSN"].Value);
                    string BatchNo = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["BatchNo"].Value);
                    string Qty = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Qty"].Value);
                    string price = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Rate"].Value);
                    string CGSTper = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["CGSTper"].Value);
                    string CGST = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["CGST"].Value);
                    string SGSTper = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SGSTper"].Value);
                    string SGST = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SGST"].Value);
                    string IGSTper = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["IGSTper"].Value);
                    string IGST = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["IGST"].Value);
                    string TotalAmount = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                    string TotalPrice = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalPrice"].Value);
                    string PBillNo = txt_BillNo.Text;
                    string SalesPerson = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Sales"].Value);
                    string Maintain = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Maintain"].Value);

                    if (dgv_ItemInfo.Rows[i].Cells["BarcodeNo"].Value.ToString() == "" ||dgv_ItemInfo.Rows[i].Cells["BarcodeNo"].Value.ToString() == string.Empty)
                        
                    {
                        _Sale.AddItemDetails(category,subcategory,"Size",txt_BillNo.Text,"Sale",dtp_Date.Value.ToString("dd/MM/yyyy"),price,Qty,CGSTper,CGST,SGSTper,SGST,IGSTper,IGST, TotalAmount, BatchNo, HSN, TotalPrice,SalesPerson,Maintain,"0","0","0", "0", "0");
                    }

                    else
                    {
                        _Sale.UpdateItem(Convert.ToString(dgv_ItemInfo.Rows[i].Cells["BarcodeNo"].Value), txt_BillNo.Text,dtp_Date.Value.ToString("dd/MM/yyyy"));
                    }

                }
            }
        
            catch (Exception ex)
            {
                _error.AddException(ex, "Sale");
            }
            try
            {
                 
            _Sale.AddBillDetails(txt_BillNo.Text, txt_AccNo.Text, dtp_Date.Value.ToString("dd/MM/yyyy"), txt_TotalAmt.Text, lbl_CGSTValue.Text, lbl_SGSTValue.Text, lbl_IGSTValue.Text, txt_NetAmt.Text, cmb_State.Text,txt_BillAmt.Text,txt_Discount.Text,"WholeSale",txt_Extra.Text,"","0");

            if (txt_PaidAmt.Text != "" || txt_PaidAmt.Text != "0" || txt_PaidAmt.Text == string.Empty)
            {
                _a.InsertPaymentDetails("Sale", txt_BillAmt.Text, cmb_PayMode.Text, txt_AccNo.Text, dtp_Date.Value.ToString("dd/MM/yyyy"), txt_BillNo.Text);
            }
                //create account ledger
                string ledgerId;
                ledgerId = _Sale.insertAcountLedgerDetail(Vouchertypeid: VouchertypeID, AccNo: lbl_AccNo.Text, Name: cmb_Name.Text, Narration: "", Date: dtp_Date.Text);

                bool Payformstatus = true;
                if (Convert.ToInt32(txt_PaidAmt.Text) == 0)
                {
                    DialogResult dr1 = MessageBox.Show("Save with Zero Amount :" + txt_PaidAmt.Text + "\n\n Do You Want To Continue", "ShopIn Says ", MessageBoxButtons.YesNo);
                    if (dr1 == DialogResult.No)
                    {
                        Payformstatus = false;
                    }
                }

                else if (Convert.ToInt32(txt_PaidAmt.Text) > 0 )

                {
                    DialogResult dr = MessageBox.Show("Amount to be Payed :" + txt_PaidAmt.Text + "\n\n Do You Want To Continue", "ShopIn Says ", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        if (dtSett.PaymentForm == "1")
                        {
                            frm_PaymentOptionForReceiptVoucher form = new frm_PaymentOptionForReceiptVoucher
                                (
                               Amountpaid: txt_PaidAmt.Text,
                               billno: txt_BillNo.Text,
                               Accountno: txt_AccNo.Text,
                               Date: dtp_Date.Text,

                               CustomerType: CustomerType.CustomerSaleGST,
                               OperationType: OperationType.Create
                                );

                            form.ShowDialog();
                            Payformstatus = true;
                            TransactionLedgerID = form.TransactionLedgerID;
                            PaymentIDs = form.PaymentIDs;
                            if (form.ReturnStatus == false)
                            {
                                Payformstatus = false;
                            }
                        }
                        else if (dtSett.PaymentForm == "0")
                        {
                            Payformstatus = true;
                        }
                    }
                    else if (dr == DialogResult.No)
                    {
                        Payformstatus = false;
                    }
                }
                _Sale.InsertCreditDebitInSalesAccount(customerLedgerID: ledgerId, VouchertypeID: VouchertypeID, sbillno: txt_AccNo.Text.ToString(), Name: cmb_Name.Text, Amount: txt_PaidAmt.Text, Narration: "", Date: dtp_Date.Text);

            }

            
            catch (Exception ex)
            {
                _error.AddException(ex, "Sale/AddBillDetails");
            }
            try
            {
                Report.CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new Report.CrystalReport.frm_ReportViewer();
                SendData _obj = new SendData(_objfrm_ReportViewer.CustomerBill);
                _obj(txt_BillNo.Text,"Print");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _error.AddException(ex, "Sale/PrintBill");
            }
            //_Sale.PrintBillThermal(BillNo);

            MessageBox.Show("Sale Successfully Done");
            Masterclear();
            Clear();
            this.BringToFront();
            
            
        }

        private void frm_SaleForm_KeyDown(object sender, KeyEventArgs e)
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
                txt_Discount.Focus();
            }
        }
        

        private void dgv_ItemInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex >= -1)
                {
                    bttn_Delete.Enabled = true;
                    bttn_Update.Enabled = true;
                    bttn_Add.Enabled = false;
                    cmb_Category.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Category"].Value.ToString();
                    cmb_SubCategory.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SubCategory"].Value.ToString();
                    txt_SellingAmt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Rate"].Value.ToString();
                    txt_Qty.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Qty"].Value.ToString();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                _error.AddException(ex, "Sale");
            }
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            try
            {

                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Category"].Value = cmb_Category.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SubCategory"].Value = cmb_SubCategory.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Rate"].Value = txt_SellingAmt.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Qty"].Value = txt_Qty.Text;
                Calculate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable To Update", "Application says", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _error.AddException(ex, "sale");
            }
            bttn_Add.Enabled = true;
            Clear();
            Calculate();
            txt_NetAmt.Text = Convert.ToString(Convert.ToInt32(txt_TotalAmt.Text));
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
                _error.AddException(ex, "Sale");
            }
            bttn_Add.Enabled = true;
            Clear();

        }

        private void txt_SellingAmt_TextChanged(object sender, EventArgs e)
        {
            //txt_Amt.Text = "";
            if (lbl_BasePrice.Text!="" || txt_Qty.Text!="" || lbl_BasePrice.Text != string.Empty || txt_Qty.Text != string.Empty)
                txt_Amt.Text = Convert.ToString(Math.Round(Convert.ToDouble(txt_SellingAmt.Text) * Convert.ToDouble(txt_Qty.Text),2));
            CalculateBase();
            CalculateGST();
            CalculateTotalBase();
            //calculatetotal();
        }
        
        private void bttn_All_Click(object sender, EventArgs e)
        {
            dgv_ItemInfo.Rows.Clear();
        }

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmb_State_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Address.Focus();
            }
        }

        private void txt_GSTIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_BarcodeNo.Focus();
            }
        }

        private void txt_HSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_BatchNo.Focus();
            }
        }

        private void txt_BatchNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_SellingAmt.Focus();
            }
            
        }

        private void txt_CGSTper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_SGSTper.Focus();
            }
        }

        private void txt_SGSTper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add();
            }
        }

        private void cmb_State_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_State.Text == state)
            {
                txt_IGSTper.Enabled = false;
                txt_CGSTper.Enabled = true;
                txt_SGSTper.Enabled = true;
            }
            else
            {
                txt_IGSTper.Enabled = true;
                txt_CGSTper.Enabled = false;
                txt_SGSTper.Enabled = false;

            }
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_SubCategory.DataSource = _a.GetSubCategoryByCategory(cmb_Category.Text);
        }

        private void txt_CGSTper_TextChanged(object sender, EventArgs e)
        {
            
            if (txt_CGSTper.Text != "")
            {
                lbl_CGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_CGSTper.Text)*0.01)*Convert.ToDouble(txt_Amt.Text),2));
            }
            CalculateBase();
            CalculateGST();
            CalculateTotalBase();
        }

        private void txt_SGSTper_TextChanged(object sender, EventArgs e)
        {
            
            if (txt_SGSTper.Text != "")
            {
                lbl_SGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_SGSTper.Text) * 0.01) * Convert.ToDouble(txt_Amt.Text),2));
            }
            CalculateBase();
            CalculateGST();
            CalculateTotalBase();
        }

        private void txt_IGSTper_TextChanged(object sender, EventArgs e)
        {
            
            if (txt_IGSTper.Text != "")
            {
                lbl_IGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_IGSTper.Text) * 0.01) * Convert.ToDouble(txt_Amt.Text),2));
            }
            CalculateBase();
            CalculateGST();
            CalculateTotalBase();
        }

        private void txt_IGSTper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add();
            }
        }

        private void txt_PaidAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_PaidAmt.Text == "" || txt_PaidAmt.Text == "0" || txt_PaidAmt.Text == string.Empty)
                    bttn_Sale.Focus();
                else
                    cmb_PayMode.Focus();
            }
            
        }

        private void txt_ContactNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PanNo.Focus();
            }
        }

        private void txt_PanNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_GSTIN.Focus();
            }
        }

        private void txt_PanNo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmb_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_BasePrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalBase();
        }

        private void txt_Discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PaidAmt.Focus();
            }
        }

        private void txt_Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_Discount.Text);
        }

        private void txt_Discount_TextChanged(object sender, EventArgs e)
        {
            calculateDiscount();
        }

        private void txt_CGSTper_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_Discount.Text);
        }

        private void txt_SGSTper_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_Discount.Text);
        }

        private void txt_IGSTper_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_Discount.Text);
        }

        private void txt_PaidAmt_TextChanged(object sender, EventArgs e)
        {
            if (txt_Balance.Text != "" || txt_Balance.Text != "0" || txt_Balance.Text != string.Empty)
                if (txt_BillAmt.Text != "" || txt_BillAmt.Text != "0" || txt_BillAmt.Text != string.Empty)
                    if (txt_PaidAmt.Text != "" || txt_PaidAmt.Text != "0" || txt_PaidAmt.Text != string.Empty)
                        txt_BalanceAmt.Text = Convert.ToString((Convert.ToDouble(txt_Balance.Text) + Convert.ToDouble(txt_BillAmt.Text)) - Convert.ToDouble(txt_PaidAmt.Text)); 
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
                bttn_Sale.Focus();
            }
        }

        private void cmb_SubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = _a.GetSizeByCatAndSubCat(cmb_Category.Text, cmb_SubCategory.Text);
            cmb_size.DataSource = dt;
        }

        private void cmb_size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txt_HSN.Focus();
                if (cmb_SubCategory.Text != "" || cmb_SubCategory.Text != string.Empty)
                {
                    fillitem();
                }
            }
        }

        private void cmb_size_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Name_TextChanged(object sender, EventArgs e)
        {
           //earchCustomer();
        }

        private void cmb_Name_Enter(object sender, EventArgs e)
        {
            cmb_Name.DroppedDown = true;
        }
    }
}
