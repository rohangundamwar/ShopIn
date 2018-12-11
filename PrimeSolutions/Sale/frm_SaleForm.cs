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
using PrimeSolutions.Report.Sale;

namespace PrimeSolutions

{
    public partial class frm_SaleForm : Form
    {
        public delegate void SendData(string BillNO,string type);
        Simplevalidations _objSimpal = new Simplevalidations();
        SQLHelper _objSQLHelper = new SQLHelper();
        clsCommon _common = new clsCommon();
        SaleCommon _Sale = new SaleCommon();
        CustomerCommon _Cust = new CustomerCommon();
        ErrorLog _error = new ErrorLog();
        AllClassFile _a = new AllClassFile();
        cls_ServiceCommon _Service = new cls_ServiceCommon();
        SettingValue dtSett;
        string Customerexs = "No";
        string state ;
        public int[] PaymentIDs = new int[2];
        string VouchertypeID = "0";
        string VouchertypeIDPayment = "0";
        string VouchertypeIDMod = "0";
        string VouchertypeIDModPayment = "0";
        DataTable dt_cust;
        string BillType { get; set; }
        DataTable Payment;
        DateTime Date { get; set; }
        DataTable CustomerBill;
        DataTable offer;
        bin.Debug.cls_ThermalBill _Bill;


        public frm_SaleForm()
        {
            dtSett = new SettingValue();
            dtSett = _common.getSettingValue();
            InitializeComponent();
            state = _a.GetState();
            VouchertypeID = _common.getALLTableDetails(sTableName: TableNames.VoucherType, sColomnName: "VoucherTypeName", sColumnValue: "Sales Invoice GST").Rows[0]["VoucherTypeID"].ToString();
            VouchertypeIDPayment = _common.getALLTableDetails(sTableName: TableNames.VoucherType, sColomnName: "VoucherTypeName", sColumnValue: "Sales Receipt Voucher").Rows[0]["VoucherTypeID"].ToString();
            BillType = "New";
        }

        public frm_SaleForm(string BillNo, string Status)
        {
            BillType = Status;
            dtSett = new SettingValue();
            dtSett = _common.getSettingValue();
            InitializeComponent();
            VouchertypeID = _common.getALLTableDetails(sTableName: TableNames.VoucherType, sColomnName: "VoucherTypeName", sColumnValue: "Sales Invoice GST").Rows[0]["VoucherTypeID"].ToString();
            VouchertypeIDPayment = _common.getALLTableDetails(sTableName: TableNames.VoucherType, sColomnName: "VoucherTypeName", sColumnValue: "Sales Receipt Voucher").Rows[0]["VoucherTypeID"].ToString();
            getBillDetails(BillNo,Status);

        }

        private void frm_PurchaseForm_Load(object sender, EventArgs e)
        {
            cmb_Category.DataSource = _a.FillCategory();
            cmb_PayMode.SelectedIndex = 0;
            if (BillType == "Update")
            {
                pnl_Old.Visible = true;
                Date = Convert.ToDateTime(CustomerBill.Rows[0]["Date"].ToString());
                dtp_Date.Value = Date;
            }
            else
            {
                dt_cust = _Cust.GetCustomerDeatils();
                this.BringToFront();
                cmb_Name.DataSource = dt_cust;
                cmb_SalesPerson.DataSource = _common.GetSalesPerson();
                cmb_Name.Select();

                if ( BillType != "Deleted")
                {
                    Clear(); Masterclear();
                }
               
            }
            
        }

        private void Masterclear()
        {
            dtp_Date.ResetText();
            
            txt_BillNo.Text = _objSQLHelper.GetMaxID("S", "0");
            txt_AccNo.Text = _objSQLHelper.GetMaxID("C", "0");
            cmb_Name.SelectedIndex = -1;
            cmb_PayMode.SelectedIndex = 0;
            cmb_State.Text = state;
            txt_PanNo.Text = "";
            txt_GSTIN.ResetText();
            txt_BalanceAmt.Text = "0";
            txt_Extra.Text = "0";
            txt_CashDisc.Text = "0";
            txt_Discount.Text = "0";
            txt_Balance.Text = "0";
            txt_Narration.Text = "";
            txt_PaidAmt.Text = "0";
            txt_BillAmt.Text = "0";
            txt_Address.ResetText();
            txt_City.ResetText();
            txt_ContactNo.ResetText();
            txt_NetAmt.Text = "0";
            txt_TotalAmt.Text = "0";
            lbl_Total.Text = "0";
            lbl_CGSTValue.Text = "0";
            lbl_SGSTValue.Text = "0";
            lbl_IGSTValue.Text = "0";
            dgv_ItemInfo.Rows.Clear();
            bttn_Sale.Enabled = false;
            cmb_Name.Enabled = true;
            cmb_Name.Select();
            txt_maintain.Text = "0";
            if (dtSett.Maintenance == "Yes")
            {
                lbl_maintain.Visible = true;
                txt_maintain.Visible = true;
            }
            pnl_Old.Visible = false;
            
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
            txt_DiscPer.Text = "0";
            txt_DiscAmt.Text = "0";
            txt_GSTper.Text = "0";
            lbl_GSTAmt.Text = "0";
        }

        public void getBillDetails(string billNo,string status)
        {
            txt_BillNo.Text = billNo;

            if (status == "Update")
            {
                txt_BillNo.Text = billNo.ToString();

                //CustomerDetsils
                DataTable Cust = _Sale.GetCustomerByBill(billNo);

                cmb_Name.Text = Cust.Rows[0]["CustomerName"].ToString();
               
                cmb_Name.Enabled = false;
                cmb_State.Enabled = false;
              

                txt_AccNo.Text = Cust.Rows[0]["CustId"].ToString();
                cmb_State.Text = Cust.Rows[0]["State"].ToString();

                txt_PanNo.Text = Cust.Rows[0]["PanNo"].ToString();
                txt_GSTIN.Text = Cust.Rows[0]["GSTIN"].ToString();
                txt_ContactNo.Text = Cust.Rows[0]["ContactNo"].ToString();
                txt_Address.Text = Cust.Rows[0]["Address"].ToString();
                txt_City.Text = Cust.Rows[0]["City"].ToString();

                //PaymentDetails
                Payment = _a.getpaymentByBill(billNo, "Sale", "0");
                if (Payment.Rows.Count > 0)
                {
                    cmb_PayMode.Text = Payment.Rows[0]["Paymode"].ToString();
                    txt_OldPaid.Text = Payment.Rows[0]["Amt"].ToString();

                }

                //CustomerBill
                CustomerBill = _Sale.GetBillDetails(billNo);
                txt_TotalAmt.Text = CustomerBill.Rows[0]["Amount"].ToString();
                lbl_CGSTValue.Text = CustomerBill.Rows[0]["CGST"].ToString();
                lbl_SGSTValue.Text = CustomerBill.Rows[0]["SGST"].ToString();
                lbl_IGSTValue.Text = CustomerBill.Rows[0]["IGST"].ToString();
                txt_NetAmt.Text = CustomerBill.Rows[0]["GrandAmt"].ToString();
                txt_Discount.Text = CustomerBill.Rows[0]["Discount"].ToString();
                txt_BillAmt.Text = CustomerBill.Rows[0]["BillAmount"].ToString();
                txt_Extra.Text = CustomerBill.Rows[0]["ExtraCharges"].ToString();
                txt_CashDisc.Text = CustomerBill.Rows[0]["CashDiscount"].ToString();


                //BillItem
                DataTable BillItem = _Sale.GetBillItem(billNo, "Sale");
                for (int i = 0; i < BillItem.Rows.Count; i++)
                {
                    /*1*/
                    string barcode = BillItem.Rows[i]["Barcode"].ToString();
                    /*2*/
                    string category = BillItem.Rows[i]["Category"].ToString();
                    /*3*/
                    string SubCategory = BillItem.Rows[i]["SubCategory"].ToString();
                    /*4*/
                    string Size = BillItem.Rows[i]["Size"].ToString();
                    /*5*/
                    string HSN = BillItem.Rows[i]["HSN"].ToString();
                    /*6*/
                    string BatchNo = BillItem.Rows[i]["BatchNo"].ToString();
                    /*7*/
                    string Rate = BillItem.Rows[i]["Price"].ToString();
                    /*8*/
                    string qty = BillItem.Rows[i]["Qty"].ToString();
                    /*9*/
                    string Total = BillItem.Rows[i]["TotalAmount"].ToString();
                    /*10*/
                    string DiscPer = BillItem.Rows[i]["DiscPer"].ToString();
                    /*11*/
                    string DiscAmt = BillItem.Rows[i]["DiscAmt"].ToString();
                    /*12*/
                    string CGST = BillItem.Rows[i]["CGST"].ToString();
                    /*13*/
                    string CGSTAmt = BillItem.Rows[i]["CGSTAmt"].ToString();
                    /*14*/
                    string SGST = BillItem.Rows[i]["SGST"].ToString();
                    /*15*/
                    string SGSTAmt = BillItem.Rows[i]["SGSTAmt"].ToString();
                    /*16*/
                    string IGST = BillItem.Rows[i]["IGST"].ToString();
                    /*17*/
                    string IGSTAmt = BillItem.Rows[i]["IGSTAmt"].ToString();
                    /*18*/
                    string Selling = BillItem.Rows[i]["SellingPrice"].ToString();
                    /*19*/
                    /*20*/
                    string sales = BillItem.Rows[i]["SalesPerson"].ToString();
                    /*21*/
                    string maintain = BillItem.Rows[i]["Maintain"].ToString();
                    /*22*/
                    string ActualPrice = BillItem.Rows[i]["ActualPrice"].ToString();
                    /*23*/
                    string FinalAmount = BillItem.Rows[i]["FinalAmount"].ToString();

                    dgv_ItemInfo.Rows.Add(barcode, category, SubCategory, Size, HSN, BatchNo, Rate, qty, Total, DiscPer, DiscAmt, CGST, CGSTAmt, SGST, SGSTAmt, IGST, IGSTAmt, Selling, "", sales, maintain, ActualPrice, FinalAmount);

                }
            }

            
            
            
        }

        private void cmb_Name_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && cmb_Name.Text!=string.Empty)
            {
                new CultureInfo("en-US", false).TextInfo.ToTitleCase(Regex.Replace(cmb_Name.Text, @"\s+", " ").Trim() as String);

                if (findCustomer() == 1)
                {
                    cmb_State.Enabled = false;
                    txt_BarcodeNo.Focus();
                    string balance = Convert.ToString(Math.Round(_Sale.GetBalance(txt_AccNo.Text, "Sale"),2));
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
                    txt_BarcodeNo.Focus();
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
                    cmb_State.Focus();
                }
            }
            else if (e.KeyCode == Keys.F1)
            {
                txt_ContactNo.Focus();
            }
            
        }
        
        private int findCustomer()
        {
            int i=0;
            DataTable dt = new DataTable();
            if (cmb_Name.Text == "" || cmb_Name.Text == string.Empty)
            {
                dt = _Sale.GetCustomerByContact(txt_ContactNo.Text);
            }

            else
            {
                dt = _Sale.GetCustomerDetails(cmb_Name.Text);
            }
            if (dt.Rows.Count > 0)
            {
                Customerexs = "Yes";
                cmb_Name.Text = dt.Rows[0]["CustomerName"].ToString();
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
                DataTable Rate = _Sale.GetItemRateByBarcode(txt_BarcodeNo.Text);
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
                            txt_GSTper.Text = Rate.Rows[0]["GST"].ToString();
                        }
                        else
                        {
                            txt_SellingAmt.Text = GST.Rows[0]["SellingPrice"].ToString();
                            txt_GSTper.Text = Convert.ToString(Convert.ToDouble(GST.Rows[0]["CGST"]) + Convert.ToDouble(GST.Rows[0]["SGST"]) + Convert.ToDouble(GST.Rows[0]["IGST"]));
                        }
                    }
                    catch { }
                    txt_Qty.Focus();
                    
                }
            }
            if (txt_BarcodeNo.Text == "" || txt_BarcodeNo.Text == string.Empty)
            {
                DataTable GST = _Sale.GetItemDetailsByCategoySubCategorySize(cmb_Category.Text, cmb_SubCategory.Text,cmb_size.Text);
                DataTable Rate = _Sale.GetItemRateByCategoySubCategorySize(cmb_Category.Text, cmb_SubCategory.Text, cmb_size.Text);

                if (GST.Rows.Count > 0)
                {
                    try
                    {
                        cmb_Category.Text = GST.Rows[0]["Category"].ToString();
                        cmb_SubCategory.Text= GST.Rows[0]["SubCategory"].ToString();
                        txt_HSN.Text = GST.Rows[0]["HSN"].ToString();
                        txt_BatchNo.Text = GST.Rows[0]["BatchNo"].ToString();
                        if (Rate.Rows.Count > 0)
                        {
                            txt_SellingAmt.Text = Rate.Rows[0]["SellingPrice"].ToString();
                            txt_GSTper.Text = Rate.Rows[0]["GST"].ToString();
                        }
                        else
                        {
                            txt_SellingAmt.Text = GST.Rows[0]["SellingPrice"].ToString();
                            txt_GSTper.Text = Convert.ToString(Convert.ToDouble(GST.Rows[0]["CGST"]) + Convert.ToDouble(GST.Rows[0]["SGST"]) + Convert.ToDouble(GST.Rows[0]["IGST"]));
                        }
                            

                    }
                    catch { }
                    txt_Qty.Focus();
                }
            }
            
            CalculateGST();
            CalculateBase();
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
        

        private void cmb_Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                new CultureInfo("en-US", false).TextInfo.ToTitleCase(Regex.Replace(cmb_Category.Text, @"\s+", " ").Trim() as String);
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
                new CultureInfo("en-US", false).TextInfo.ToTitleCase(Regex.Replace(cmb_SubCategory.Text, @"\s+", " ").Trim() as String);
                cmb_size.Select();
            }
        }

       

        private void txt_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_DiscPer.Focus();
            }

            GetOffer();
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
                double selling = Convert.ToDouble(txt_SellingAmt.Text);
                txt_SellingAmt.Text = selling.ToString("#.##"); 
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
            _objSimpal.ValidationCharDigitSpaceOnly(e);
        }

        private void cmb_SubCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharDigitSpaceOnly(e);
        }

        private void txt_Barcode_KeyPress(object sender, KeyPressEventArgs e)
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
                    {
                        txt_Amt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_SellingAmt.Text) * Convert.ToDouble(txt_Qty.Text)), 2));
                        double DiscountPer = Convert.ToDouble(txt_DiscPer.Text) / 100;
                        lbl_FinalAmt.Text = Convert.ToString(Math.Round(Convert.ToDouble(txt_SellingAmt.Text) - (Convert.ToDouble(txt_SellingAmt.Text) * DiscountPer),2));
                        txt_Actual.Text = Convert.ToString(Convert.ToDouble(txt_SellingAmt.Text) * Convert.ToDouble(txt_Qty.Text));
                        
                        CalculateGST();
                        CalculateBase();
                        CalculateTotalBase();

                    }
                        
            }
            catch { }
            
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
                string sales = Convert.ToString(cmb_SalesPerson.Text[0]) ;
                dgv_ItemInfo.Rows.Add(txt_BarcodeNo.Text, cmb_Category.Text, cmb_SubCategory.Text,cmb_size.Text,txt_HSN.Text, txt_BatchNo.Text, lbl_BasePrice.Text, txt_Qty.Text, lbl_TotalPrice.Text,txt_DiscPer.Text,txt_DiscAmt.Text, txt_CGSTper.Text, lbl_CGSTAmt.Text, txt_SGSTper.Text, lbl_SGSTAmt.Text, txt_IGSTper.Text, lbl_IGSTAmt.Text, txt_Amt.Text, lbl_FinalAmt.Text, sales,txt_maintain.Text, txt_Actual.Text,txt_SellingAmt.Text);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (!_a.CheckRateMaster(cmb_Category.Text, cmb_SubCategory.Text,cmb_size.Text))
                _a.InsertRateMaster(txt_BarcodeNo.Text, cmb_Category.Text, cmb_SubCategory.Text, cmb_size.Text, txt_SellingAmt.Text, Convert.ToString(Convert.ToDouble(txt_CGSTper.Text) + Convert.ToDouble(txt_SGSTper.Text) + Convert.ToDouble(txt_IGSTper.Text)));

            Clear();
            Calculate();
            calculateDiscount();
            bttn_Sale.Enabled = true;
            txt_BarcodeNo.Focus();
        }
        

        private void CalculateGST()
        {
            if (dtSett.GSTInc == "1")
            {
                if (lbl_CGSTAmt.Text != "" || lbl_CGSTAmt.Text != string.Empty)
                {
                    if (txt_CGSTper.Text != "" || txt_CGSTper.Text != string.Empty)
                        lbl_CGSTAmt.Text = Convert.ToString(Math.Round(Convert.ToDouble(txt_Amt.Text) - (Convert.ToDouble(txt_Amt.Text) * (100 / (100 + Convert.ToDouble(txt_CGSTper.Text)))),1));
                        //lbl_CGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_CGSTper.Text) * 0.01) * (Convert.ToDouble(txt_Amt.Text)), 2));
                }

                if (lbl_SGSTAmt.Text != "" || lbl_SGSTAmt.Text != string.Empty)
                {
                    if (txt_SGSTper.Text != "" || txt_SGSTper.Text != string.Empty)
                        lbl_SGSTAmt.Text = Convert.ToString(Math.Round(Convert.ToDouble(txt_Amt.Text) - (Convert.ToDouble(txt_Amt.Text) * (100 / (100 + Convert.ToDouble(txt_SGSTper.Text)))),1));
                    //lbl_SGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_SGSTper.Text) * 0.01) * (Convert.ToDouble(txt_Amt.Text)), 2));
                }

                if (lbl_IGSTAmt.Text != "" || lbl_IGSTAmt.Text != string.Empty)
                {
                    if (txt_IGSTper.Text != "" || txt_IGSTper.Text != string.Empty)
                        lbl_IGSTAmt.Text = Convert.ToString(Math.Round(Convert.ToDouble(txt_Amt.Text) - (Convert.ToDouble(txt_Amt.Text) * (100 / (100 + Convert.ToDouble(txt_IGSTper.Text)))),1));
                    //lbl_IGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_IGSTper.Text) * 0.01) * (Convert.ToDouble(txt_Amt.Text)), 2));
                }

                lbl_GSTAmt.Text = Convert.ToString(Convert.ToDouble(lbl_CGSTAmt.Text) + Convert.ToDouble(lbl_SGSTAmt.Text) + Convert.ToDouble(lbl_IGSTAmt.Text));
            }
            else if (dtSett.GSTInc == "0")
            {
                if (lbl_CGSTAmt.Text != "" || lbl_CGSTAmt.Text != string.Empty)
                {
                    if (txt_CGSTper.Text != "" || txt_CGSTper.Text != string.Empty)
                        lbl_CGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_CGSTper.Text) * 0.01) * (Convert.ToDouble(txt_Actual.Text) - Convert.ToDouble(txt_DiscAmt.Text)), 2));
                }

                if (lbl_SGSTAmt.Text != "" || lbl_SGSTAmt.Text != string.Empty)
                {
                    if (txt_SGSTper.Text != "" || txt_SGSTper.Text != string.Empty)
                        lbl_SGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_CGSTper.Text) * 0.01) * (Convert.ToDouble(txt_Actual.Text) - Convert.ToDouble(txt_DiscAmt.Text)), 2));
                }

                if (lbl_IGSTAmt.Text != "" || lbl_IGSTAmt.Text != string.Empty)
                {
                    if (txt_IGSTper.Text != "" || txt_IGSTper.Text != string.Empty)
                        lbl_IGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_IGSTper.Text) * 0.01) * (Convert.ToDouble(txt_Actual.Text) - Convert.ToDouble(txt_DiscAmt.Text)), 2));
                }

                lbl_GSTAmt.Text = Convert.ToString(Convert.ToDouble(lbl_CGSTAmt.Text) + Convert.ToDouble(lbl_SGSTAmt.Text) + Convert.ToDouble(lbl_IGSTAmt.Text));

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
            if (dtSett.GSTInc == "1")
            {
                if (txt_CGSTper.Text != "" || txt_CGSTper.Text != string.Empty)
                {
                    if (txt_SGSTper.Text != "" || txt_SGSTper.Text != string.Empty)
                    {
                        if (txt_IGSTper.Text != "" || txt_IGSTper.Text != string.Empty)
                        {
                            lbl_BasePrice.Text = Convert.ToString(Math.Round((Convert.ToDouble(lbl_FinalAmt.Text))- ((Convert.ToDouble(lbl_GSTAmt.Text))/ Convert.ToDouble(txt_Qty.Text)),2));
                            
                            //lbl_BasePrice.Text = Convert.ToString(Math.Round((Convert.ToDouble(lbl_FinalAmt.Text) * 100) / (100 + Convert.ToDouble(txt_CGSTper.Text) + Convert.ToDouble(txt_SGSTper.Text) + Convert.ToDouble(txt_IGSTper.Text)), 2));
                        }
                    }
                }
            }

            if (dtSett.GSTInc == "0")
            {
                if (txt_CGSTper.Text != "" || txt_CGSTper.Text != string.Empty)
                {
                    if (txt_SGSTper.Text != "" || txt_SGSTper.Text != string.Empty)
                    {
                        if (txt_IGSTper.Text != "" || txt_IGSTper.Text != string.Empty)
                        {
                            lbl_BasePrice.Text =Convert.ToString((Convert.ToDouble(txt_Actual.Text) - Convert.ToDouble(txt_DiscAmt.Text))/ Convert.ToDouble(txt_Qty.Text))  ;
                        }
                    }
                }
            }

        }

        private void CalculateTotalBase()
        {
            if (dtSett.GSTInc == "1")
            {
                if (lbl_BasePrice.Text != "" || txt_Qty.Text != "" || lbl_BasePrice.Text != string.Empty || txt_Qty.Text != string.Empty)
                    lbl_TotalPrice.Text = Convert.ToString(Math.Round(Convert.ToDouble(lbl_BasePrice.Text) * Convert.ToDouble(txt_Qty.Text), 2));
            }
            if (dtSett.GSTInc == "0")
            {
                if (lbl_BasePrice.Text != "" || txt_Qty.Text != "" || lbl_BasePrice.Text != string.Empty || txt_Qty.Text != string.Empty)
                    lbl_TotalPrice.Text = Convert.ToString(Math.Round(Convert.ToDouble(lbl_BasePrice.Text) * Convert.ToDouble(txt_Qty.Text), 2));
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
                    total +=Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value),2);
                    CGSTAmt += Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["CGST"].Value),2);
                    SGSTAmt += Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["SGST"].Value),2);
                    IGSTAmt += Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["IGST"].Value),2);
                }

                txt_TotalAmt.Text = total.ToString();
                lbl_CGSTValue.Text = CGSTAmt.ToString();
                lbl_SGSTValue.Text = SGSTAmt.ToString();
                lbl_IGSTValue.Text = IGSTAmt.ToString();

                txt_Discount.Text = Convert.ToString(_common.sumGridViewColumn(dgv_ItemInfo, "DiscAmt"));
                txt_BillAmt.Text = Convert.ToString(_common.sumGridViewColumn(dgv_ItemInfo, "TotalPrice"));
                double Selling = _common.sumGridViewColumn(dgv_ItemInfo, "FinalAmount");
                lbl_Total.Text = Convert.ToString(Selling);

                if (dtSett.GSTInc == "1")
                {
                    txt_NetAmt.Text = Convert.ToString(_common.sumGridViewColumn(dgv_ItemInfo, "TotalPrice"));
                }

                else if (dtSett.GSTInc == "0")
                {
                    txt_NetAmt.Text =Convert.ToString(Convert.ToDouble(txt_TotalAmt.Text) + Convert.ToDouble(lbl_CGSTValue.Text) + Convert.ToDouble(lbl_SGSTValue.Text) + Convert.ToDouble(lbl_IGSTValue.Text)) ;
                }
                
            }
            catch (Exception ex)
            {
                _error.AddException(ex, "Sale");
            }
        }

        private void calculateDiscount()
        {
            if ((txt_CashDisc.Text != "" || txt_CashDisc.Text != string.Empty) )
            {
                double NetAmt = Convert.ToDouble(txt_NetAmt.Text);
                double Discount = Convert.ToDouble(txt_CashDisc.Text);
                double BillAmt = NetAmt - Discount;
                txt_BillAmt.Text = Convert.ToString(Math.Round(BillAmt,2));
            }
        }

        private void bttn_Sale_Click(object sender, EventArgs e)
        {
            string BillNo = txt_BillNo.Text;
            string TransactionLedgerID = null;

            if (BillType == "New")
            {
                if (cmb_Name.Text != "" || txt_ContactNo.Text != "")
                {
                    if (Customerexs == "No")
                    {
                        _Cust.AddCustomerDetails(txt_AccNo.Text, cmb_Name.Text, txt_Address.Text, txt_ContactNo.Text, txt_PanNo.Text, txt_GSTIN.Text, cmb_State.Text, txt_City.Text, "0");
                    }
                }
            }
            else
            {
                _Sale.DeleteBillItem(txt_BillNo.Text,"Sale");
                _Sale.DeleteBillDetails(txt_BillNo.Text,"Sale");
            }
            
            DialogResult BillSave = MessageBox.Show("Do you Want to Continue With Bill Amount of ₹:" + txt_BillAmt.Text + "\n\n Do You Want To Continue", "  ", MessageBoxButtons.YesNo);
            if (BillSave == DialogResult.Yes)
            {
                try
                {

                    for (int i = 0; i < dgv_ItemInfo.Rows.Count; i++)
                    {
                        string barcode = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["BarcodeNo"].Value);
                        string category = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value);
                        string subcategory = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SubCategory"].Value);
                        string Size = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Size"].Value);
                        string HSN = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["HSN"].Value);
                        string BatchNo = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["BatchNo"].Value);

                        string price = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Rate"].Value);
                        string Qty = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Qty"].Value);
                        string TotalAmount = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                        string CGSTper = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["CGSTper"].Value);
                        string CGST = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["CGST"].Value);
                        string SGSTper = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SGSTper"].Value);
                        string SGST = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SGST"].Value);
                        string IGSTper = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["IGSTper"].Value);
                        string IGST = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["IGST"].Value);

                        string DiscPer = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["DiscPer"].Value);
                        string DiscAmt = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["DiscAmt"].Value);

                        string TotalPrice = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalPrice"].Value);
                        string Price = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Price"].Value);
                        string FinalAmt = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["FinalAmount"].Value);
                        string Actual = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["ActualPrice"].Value);

                        string SaleBillNo = txt_BillNo.Text;
                        string SalesPerson = Convert.ToString(cmb_SalesPerson.SelectedIndex + 1);
                        string Maintain = dgv_ItemInfo.Rows[i].Cells["Maintain"].Value.ToString();
                        string MaintainDate = dtp_Date.Value.AddMonths(Convert.ToInt32(dgv_ItemInfo.Rows[i].Cells["Maintain"].Value)).ToString("dd/MM/yyyy");



                        _Sale.AddItemDetails(category, subcategory, Size, txt_BillNo.Text, "Sale", dtp_Date.Value.ToString("dd/MM/yyyy"), price, Qty, CGSTper, CGST, SGSTper, SGST, IGSTper, IGST, TotalAmount, BatchNo, HSN, TotalPrice, SalesPerson, Maintain, FinalAmt, Actual, Price, DiscPer, DiscAmt);

                        

                        if (dgv_ItemInfo.Rows[i].Cells["Maintain"].Value.ToString() != "0")
                        {
                            _Service.AddMaintain(dtp_Date.Value.ToString("dd/MM/yyyy"), category + " " + subcategory, MaintainDate, txt_AccNo.Text);
                        }

                    }
                }

                catch (Exception ex)
                {
                    _error.AddException(ex, "Sale");
                }
                try
                {

                    _Sale.AddBillDetails(txt_BillNo.Text, txt_AccNo.Text, dtp_Date.Value.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), txt_TotalAmt.Text, lbl_CGSTValue.Text, lbl_SGSTValue.Text, lbl_IGSTValue.Text, txt_NetAmt.Text, cmb_State.Text, txt_BillAmt.Text, txt_Discount.Text, "GST", txt_Extra.Text, txt_Narration.Text, txt_CashDisc.Text);


                    // "txt_PaidAmt"
                    //if (BillType == "New")
                        if (txt_PaidAmt.Text != null || txt_PaidAmt.Text != "")
                        {
                            int paid = Convert.ToInt32(txt_PaidAmt.Text);

                            if (paid != 0)
                            {
                                _a.InsertPaymentDetails("Sale", txt_PaidAmt.Text, cmb_PayMode.Text, txt_AccNo.Text, dtp_Date.Value.ToString("dd/MM/yyyy"), txt_BillNo.Text);
                            }
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


                    else if (Convert.ToInt32(txt_PaidAmt.Text) > 0)

                    {
                        DialogResult dr = MessageBox.Show("Amount to be Payed ₹:" + txt_PaidAmt.Text + "\n\n Do You Want To Continue", "ShopIn Says ", MessageBoxButtons.YesNo);
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
                    if (dtSett.BillType == "Laser")
                    {
                        Report.CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new Report.CrystalReport.frm_ReportViewer();
                        SendData _obj = new SendData(_objfrm_ReportViewer.CustomerBill);
                        _obj(txt_BillNo.Text, "Print");
                    }
                    else
                    {
                        _Bill = new bin.Debug.cls_ThermalBill(txt_BillNo.Text);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    _error.AddException(ex, "Sale/PrintBill");
                }


                MessageBox.Show("Sale Successfully Done");
                if (BillType == "Update" || BillType=="Deleted")
                {
                    this.Close();
                }
                Masterclear();
                Clear();
                this.BringToFront();
            }
                
            
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
                txt_Extra.Focus();
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
                    cmb_size.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Size"].Value.ToString();
                    txt_HSN.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["HSN"].Value.ToString();
                    txt_BatchNo.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["BatchNo"].Value.ToString();
                    txt_SellingAmt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["ActualPrice"].Value.ToString();
                    txt_Qty.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Qty"].Value.ToString();

                    
                    double GST = Convert.ToDouble(dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["CGSTper"].Value.ToString())+ Convert.ToDouble(dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SGSTper"].Value.ToString()) + Convert.ToDouble(dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["IGSTper"].Value.ToString());

                    txt_GSTper.Text =Convert.ToString(GST);

                    txt_DiscPer.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["DiscPer"].Value.ToString();
                    txt_DiscAmt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["DiscAmt"].Value.ToString();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                _error.AddException(ex, "DGV_CellClick/Sale");
            }
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["BarcodeNo"].Value = txt_BarcodeNo.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Category"].Value = cmb_Category.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SubCategory"].Value = cmb_SubCategory.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Size"].Value = cmb_size.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["HSN"].Value = txt_HSN.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["BatchNo"].Value = txt_BatchNo.Text;

                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Rate"].Value = lbl_BasePrice.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Qty"].Value = txt_Qty.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["TotalAmt"].Value = lbl_TotalPrice.Text;

                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["CGSTper"].Value = txt_CGSTper.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["CGST"].Value = lbl_CGSTAmt.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SGSTper"].Value = txt_SGSTper.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SGST"].Value = lbl_SGSTAmt.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["IGSTper"].Value = txt_IGSTper.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["IGST"].Value = lbl_IGSTAmt.Text;

                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["DiscPer"].Value = txt_DiscPer.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["DiscAmt"].Value = txt_DiscAmt.Text;

                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Sales"].Value = cmb_SalesPerson.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["MainTain"].Value = txt_maintain.Text;

                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["FinalAmount"].Value = txt_Actual.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["ActualPrice"].Value = txt_SellingAmt.Text;

                Calculate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable To Update", "Application says", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _error.AddException(ex, "UpdateItem/sale");
            }
            bttn_Add.Enabled = true;
            Clear();
            Calculate();
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            if (BillType == "Update")
            {
                bttn_Sale.Enabled = true;
            }
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
            if ((lbl_BasePrice.Text != "" || txt_Qty.Text != "") || (lbl_BasePrice.Text != string.Empty || txt_Qty.Text != string.Empty))
            {
                if (txt_SellingAmt.Text != "" || txt_SellingAmt.Text != string.Empty )
                {
                    txt_Amt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_SellingAmt.Text) * Convert.ToDouble(txt_Qty.Text)), 2));
                    double DiscountPer = Convert.ToDouble(txt_DiscPer.Text) / 100;
                    lbl_FinalAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_SellingAmt.Text) - (Convert.ToDouble(txt_SellingAmt.Text) * DiscountPer)), 2));
                    txt_Actual.Text = Convert.ToString(Math.Round(Convert.ToDouble(txt_SellingAmt.Text) * Convert.ToDouble(txt_Qty.Text), 2));
                    
                    CalculateGST();
                    CalculateBase();
                    CalculateTotalBase();

                }
                
            }
                
            //calculatetotal();
        }
        
        private void bttn_All_Click(object sender, EventArgs e)
        {
            DialogResult DGVClear = MessageBox.Show("Do you Want to Clear all Items", " Are You Sure ", MessageBoxButtons.YesNo);
            if (DGVClear == DialogResult.Yes)
            {
                dgv_ItemInfo.Rows.Clear();
            }
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
                txt_Aadhar.Focus();
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
                cmb_SalesPerson.Focus();
            }
        }
        
   
        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_SubCategory.DataSource = _a.GetSubCategoryByCategory(cmb_Category.Text);
        }

        private void txt_CGSTper_TextChanged(object sender, EventArgs e)
        {
            //if (txt_CGSTper.Text != "")
            //{
            //    lbl_CGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_CGSTper.Text)*0.01)*Convert.ToDouble(lbl_TotalPrice.Text),2));
            //}
            
            CalculateGST();
            CalculateBase();
            CalculateTotalBase();

        }

        private void txt_SGSTper_TextChanged(object sender, EventArgs e)
        {
            
            //if (txt_SGSTper.Text != "")
            //{
            //    lbl_SGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_SGSTper.Text) * 0.01) * Convert.ToDouble(lbl_TotalPrice.Text),2));
            //}
            
            CalculateGST();
            CalculateBase();
            CalculateTotalBase();

        }

        private void txt_IGSTper_TextChanged(object sender, EventArgs e)
        {
            
            //if (txt_IGSTper.Text != "")
            //{
            //    lbl_IGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_IGSTper.Text) * 0.01) * Convert.ToDouble(lbl_TotalPrice.Text),2));
            //}
            
            CalculateGST();
            CalculateBase();
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
                txt_Narration.Focus();
            }
            
        }

        private void txt_ContactNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmb_Name.Text == "" || cmb_Name.Text == string.Empty)
                {
                    findCustomer();
                }
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
            _objSimpal.ValidationDigitWithPoint(e, txt_CGSTper.Text);
        }

        private void txt_SGSTper_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_SGSTper.Text);
        }

        private void txt_IGSTper_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_IGSTper.Text);
        }

        private void txt_PaidAmt_TextChanged(object sender, EventArgs e)
        {
            if ((txt_Balance.Text != "" || txt_Balance.Text != "0") || txt_Balance.Text != string.Empty)
                if ((txt_BillAmt.Text != "" || txt_BillAmt.Text != "0") || txt_BillAmt.Text != string.Empty)
                    if ((txt_PaidAmt.Text != "" || txt_PaidAmt.Text == "0") || txt_PaidAmt.Text != string.Empty)
                        txt_BalanceAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_Balance.Text) + Convert.ToDouble(txt_BillAmt.Text)) - Convert.ToDouble(txt_PaidAmt.Text),2)); 
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
            cmb_size.DataSource = _a.GetSizeByCatAndSubCat(cmb_Category.Text, cmb_SubCategory.Text);
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
            GetOffer();
        }

        private void GetOffer()

        {
            offer = _a.getOffer(cmb_Category.Text.Trim(), cmb_SubCategory.Text.Trim());
            if (offer.Rows.Count > 0)
            {
                if (offer.Rows[0]["Size"].ToString() == "All")
                {
                    if (txt_Qty.Text.Trim() == offer.Rows[0]["MinQty"].ToString())
                    {
                        txt_DiscPer.Text = offer.Rows[0]["DiscPer"].ToString();
                    }
                }
                else if(cmb_size.Text.Trim() == offer.Rows[0]["Size"].ToString())
                {
                    if (txt_Qty.Text.Trim() == offer.Rows[0]["MinQty"].ToString())
                    {
                        txt_DiscPer.Text = offer.Rows[0]["DiscPer"].ToString();
                    }
                }

            }

        }

        

        private void cmb_SalesPerson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_maintain.Visible == true)
                    txt_maintain.Focus();
                else
                    Add();
            }
        }

        private void txt_maintain_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_maintain.Text);
        }

        private void txt_maintain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add();
            }
        }

        private void txt_Extra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CashDisc.Focus();
            }
        }

        private void txt_Narration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_PaidAmt.Text == "" || txt_PaidAmt.Text == "0" || txt_PaidAmt.Text == string.Empty)
                    bttn_Sale.Focus();
                else
                    cmb_PayMode.Focus();
            }
            
        }

        private void lbl_DiscAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DiscPer_TextChanged(object sender, EventArgs e)
        {   
            if (Convert.ToDouble(txt_DiscPer.Text) <= 100)
            {
                double total = Math.Round(Convert.ToDouble(Convert.ToDouble(txt_SellingAmt.Text) * Convert.ToDouble(txt_Qty.Text)), 2);
                double disc = Convert.ToDouble(txt_DiscPer.Text) / 100;
                txt_DiscAmt.Text = Convert.ToString(Math.Round(total*disc, 2)); 
            }
            else { MessageBox.Show("Percent Cannot Exceed 100%"); }
            
            
        }

        private void txt_DiscAmt_TextChanged(object sender, EventArgs e)
        {
            double DiscountAmt=0;
            double Selling = Convert.ToInt32(txt_SellingAmt.Text);
            if (txt_DiscPer.Text != "" || txt_DiscPer.Text != string.Empty)
            {
                if (txt_DiscAmt.Text != "" && txt_DiscAmt.Text != null)
                {
                    DiscountAmt = Convert.ToDouble(txt_DiscAmt.Text);
                }
            }
                
            double DiscountPer = Math.Round((DiscountAmt /Convert.ToDouble(txt_Actual.Text) * 100) , 2);
            lbl_FinalAmt.Text = Convert.ToString(Selling - (DiscountAmt/Convert.ToDouble(txt_Qty.Text)));
            txt_Amt.Text = Convert.ToString(Math.Round(Convert.ToDouble(lbl_FinalAmt.Text) * Convert.ToDouble(txt_Qty.Text), 2));
            CalculateGST();
            CalculateBase();
            CalculateTotalBase();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_BillAmt_TextChanged(object sender, EventArgs e)
        {
            if (BillType == "Update")
            {
                if (Payment.Rows.Count > 0)
                {
                    txt_OldPaid.Text = Payment.Rows[0]["Amt"].ToString();
                }
                else
                {
                    txt_OldPaid.Text = "0";
                }

                txt_Diff.Text = Convert.ToString(Convert.ToDouble(txt_BillAmt.Text) - Convert.ToDouble(txt_OldPaid.Text));
            }
        }

        private void txt_DiscPer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_DiscPer.Text == "" || txt_DiscPer.Text == string.Empty)
                {
                    txt_DiscPer.Text = "0";
                }

                double DiscountPer = 0;
                double Selling = Convert.ToDouble(txt_SellingAmt.Text);
                double Qty = Convert.ToDouble(txt_Qty.Text);

                if (txt_DiscPer.Text != "" && txt_DiscPer.Text != null)
                {
                    DiscountPer = Convert.ToDouble(txt_DiscPer.Text);
                }

                double discount = DiscountPer / 100;
                double DiscAmt = Math.Round((Convert.ToDouble(txt_Actual.Text) * discount), 2);
                lbl_FinalAmt.Text = Convert.ToString(Math.Round((Selling - (Selling * discount)), 2));
                txt_Amt.Text = Convert.ToString(Math.Round(Convert.ToDouble(lbl_FinalAmt.Text) * Convert.ToDouble(txt_Qty.Text), 2));

                CalculateGST();
                CalculateBase();
                CalculateTotalBase();

                txt_DiscAmt.Focus();
                //double discount1 = Convert.ToDouble(txt_DiscPer.Text) / 100;
                //double DiscAmt1 = Math.Round((Convert.ToDouble(txt_Actual.Text) * discount1), 2);
                //txt_DiscAmt.Text = DiscAmt1.ToString();
            }

        }

        private void txt_DiscPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_DiscPer.Text);
        }

        private void txt_DiscAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_GSTper.Focus();
                  
                double DiscPer =Math.Round(((Convert.ToDouble(txt_DiscAmt.Text) / Convert.ToDouble(txt_Actual.Text)) * 100),2)  ;
                txt_DiscPer.Text = DiscPer.ToString();
            }
            
        }

        private void txt_DiscAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_DiscAmt.Text);
        }

        private void txt_CashDisc_TextChanged(object sender, EventArgs e)
        {
            if (txt_CashDisc.Text != "" || txt_CashDisc.Text != null)
            {
                calculateDiscount();
                
            }
        }

        private void txt_CashDisc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PaidAmt.Focus();
            }
        }

        private void cmb_SalesPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharDigitOnly(e);
        }

        private void txt_GSTper_TextChanged(object sender, EventArgs e)
       {
            if (txt_GSTper.Text != "" || txt_GSTper.Text != string.Empty)
            {
                double GST = Convert.ToDouble(txt_GSTper.Text);

                if (cmb_State.Text == state)
                {
                    txt_CGSTper.Text = txt_SGSTper.Text= Convert.ToString(GST / 2);
                }
                else
                {
                    txt_IGSTper.Text = Convert.ToString(GST);
                }
            }

            lbl_GSTAmt.Text =Convert.ToString(Convert.ToDouble(lbl_CGSTAmt.Text) + Convert.ToDouble(lbl_SGSTAmt.Text) + Convert.ToDouble(lbl_IGSTAmt.Text));

        }

        private void txt_Aadhar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_BarcodeNo.Focus();
            }
        }

        private void txt_GSTper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_SalesPerson.Focus();
            }
        }

        private void txt_GSTper_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharDigitOnly(e);
        }

        private void txt_CashDisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e,txt_CashDisc.Text);
        }

        private void txt_Extra_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_Extra.Text);
        }
    }
}
