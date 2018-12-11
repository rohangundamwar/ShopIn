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
    public partial class frm_SaleEstimate : Form
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
        DataTable dt_cust;
        string BillType { get; set; }
        DataTable Payment = new DataTable();
        DateTime Date { get; set;}
        DataTable CustomerBill;

        public frm_SaleEstimate()
        {
            dtSett = new SettingValue();
            dtSett = _common.getSettingValue();
            InitializeComponent();
            state = _a.GetState();
            BillType = "New";
        }

        public frm_SaleEstimate(string BillNo, string status)
        {
            BillType = "Update";
            dtSett = new SettingValue();
            dtSett = _common.getSettingValue();
            InitializeComponent();
            getBillDetails(BillNo,status);
             
        }

        private void frm_PurchaseForm_Load(object sender, EventArgs e)
        {
            cmb_Category.DataSource = _a.FillCategory();
            cmb_PayMode.SelectedIndex = 0;
            if (BillType == "Update")
            {
                pnl_OldPay.Visible = true;
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
                Clear();
                Masterclear();
            }
           
        }

        private void Masterclear()
        {
            txt_BillNo.Text = _objSQLHelper.GetMaxID("T", "0");
            txt_AccNo.Text = _objSQLHelper.GetMaxID("C", "0");
            cmb_Name.SelectedIndex = 0;
            cmb_PayMode.SelectedIndex = 0;
            cmb_Name.ResetText();
            cmb_State.Text = state;
            txt_PanNo.Text = "";
            txt_GSTIN.Text = "";
            txt_BalanceAmt.Text = "0";
            txt_Balance.Text = "0";
            txt_BillAmt.Text = "0";
            txt_Address.ResetText();
            txt_City.ResetText();
            txt_ContactNo.ResetText();
            txt_NetAmt.Text = "0";
            txt_TotalAmt.Text = "0";
            txt_PaidAmt.Text = "0";
            dgv_ItemInfo.Rows.Clear();
            bttn_Sale.Enabled = false;
            cmb_Name.Select();
        }

        private void Clear()
        {
            txt_BarcodeNo.ResetText();
            txt_HSN.ResetText();
            txt_BatchNo.ResetText();
            txt_Qty.Text = "1";
            txt_Amt.Text = "0";
            lbl_BasePrice.Text = "0";
            txt_SellingAmt.Text = "0";
        }

        private void getBillDetails(string billNo,string  status)
        {
            txt_BillNo.Text = billNo.ToString();
            //CustomerDetsils
            DataTable Cust = _Sale.GetCustomerByBill(billNo);
            cmb_Name.Text = Cust.Rows[0]["CustomerName"].ToString();
            if (status == "Update")
            {
                cmb_Name.Enabled = false;
                cmb_State.Enabled = false;
            }
            
            txt_AccNo.Text = Cust.Rows[0]["CustId"].ToString();
            cmb_State.Text = Cust.Rows[0]["State"].ToString();
            
            txt_PanNo.Text = Cust.Rows[0]["PanNo"].ToString();
            txt_GSTIN.Text = Cust.Rows[0]["GSTIN"].ToString();
            txt_ContactNo.Text = Cust.Rows[0]["ContactNo"].ToString();
            txt_Address.Text = Cust.Rows[0]["Address"].ToString();
            txt_City.Text = Cust.Rows[0]["City"].ToString();

            //CustomerBill
            CustomerBill = _Sale.GetBillDetails(billNo);
            txt_TotalAmt.Text = CustomerBill.Rows[0]["Amount"].ToString();
            txt_NetAmt.Text = CustomerBill.Rows[0]["GrandAmt"].ToString();
            txt_Discount.Text = CustomerBill.Rows[0]["Discount"].ToString();
            txt_BillAmt.Text = CustomerBill.Rows[0]["BillAmount"].ToString();

            //PaymentDetails
            Payment = _a.getpaymentByBill(billNo, "Sale","0");
            if (Payment.Rows.Count > 0)
            {
                cmb_PayMode.Text = Payment.Rows[0]["Paymode"].ToString();
                txt_OldPaid.Text = Payment.Rows[0]["Amt"].ToString();

            }

            //BillItem
            DataTable BillItem = _Sale.GetBillItem(billNo, "Sale");
            for (int i = 0; i < BillItem.Rows.Count; i++)
            {
                string barcode = BillItem.Rows[i]["Barcode"].ToString();
                string category = BillItem.Rows[i]["Category"].ToString();
                string SubCategory = BillItem.Rows[i]["SubCategory"].ToString();
                string Size = BillItem.Rows[i]["Size"].ToString();
                string HSN = BillItem.Rows[i]["HSN"].ToString();
                string BatchNo = BillItem.Rows[i]["BatchNo"].ToString();
                string Rate = BillItem.Rows[i]["Price"].ToString();
                string qty = BillItem.Rows[i]["Qty"].ToString();
                string Total = BillItem.Rows[i]["TotalPrice"].ToString();
                string Selling = BillItem.Rows[i]["SellingPrice"].ToString();
                string Sales = BillItem.Rows[i]["SalesPerson"].ToString();
                string Maintain = BillItem.Rows[i]["Maintain"].ToString();
                dgv_ItemInfo.Rows.Add(barcode, category, SubCategory, Size, HSN, BatchNo, Rate, qty, Total, Selling,Sales,Maintain );

            }
        }

        private void cmb_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                new CultureInfo("en-US", false).TextInfo.ToTitleCase(Regex.Replace(cmb_Name.Text, @"\s+", " ").Trim() as String);

                if (findCustomer() == 1)
                {
                    cmb_State.Enabled = false;
                    txt_BarcodeNo.Focus();
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
                txt_Balance.Text = _Sale.GetBalance(txt_AccNo.Text, "Sale").ToString();
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
                        cmb_size.Text= GST.Rows[0]["size"].ToString(); 
                        txt_HSN.Text = GST.Rows[0]["HSN"].ToString();
                        txt_BatchNo.Text = GST.Rows[0]["BatchNo"].ToString();

                        if (Rate.Rows.Count > 0)
                        {
                            txt_SellingAmt.Text = Rate.Rows[0]["SellingPrice"].ToString();
                        }
                        else
                            txt_SellingAmt.Text = GST.Rows[0]["SellingPrice"].ToString();

                        txt_Qty.Focus();
                    }
                    catch { }
                    
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
                        cmb_size.Text = GST.Rows[0]["size"].ToString();
                        txt_HSN.Text = GST.Rows[0]["HSN"].ToString();
                        txt_BatchNo.Text = GST.Rows[0]["BatchNo"].ToString();
                        if (Rate.Rows.Count > 0)
                        {
                            txt_SellingAmt.Text = Rate.Rows[0]["SellingPrice"].ToString();
                        }
                        else
                            txt_SellingAmt.Text = GST.Rows[0]["SellingPrice"].ToString();
                
                        txt_Qty.Focus();
                        
                    }
                    catch { }

                }
            }
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
               txt_Extra.Focus();
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
                cmb_SalesPerson.Focus();
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
            if (e.KeyCode == Keys.End)
            {
                txt_Extra.Focus();
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
                dgv_ItemInfo.Rows.Add(txt_BarcodeNo.Text, cmb_Category.Text, cmb_SubCategory.Text,cmb_size.Text, txt_HSN.Text, txt_BatchNo.Text, lbl_BasePrice.Text, txt_Qty.Text, lbl_TotalPrice.Text, txt_Amt.Text,cmb_SalesPerson.Text,txt_maintain.Text);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            bttn_Sale.Enabled = true;
            txt_BarcodeNo.Focus();
            calculatetotal();
            Calculate();
        }

        private void Calculate()
        {
            double total = 0;
            
            try
            {


                for (int i = 0; i < dgv_ItemInfo.Rows.Count; i++)
                {
                    total += Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value), 2);
                }

                txt_TotalAmt.Text = total.ToString();

                txt_NetAmt.Text = txt_BillAmt.Text = Convert.ToString(_common.sumGridViewColumn(dgv_ItemInfo, "TotalPrice"));

            }
            catch (Exception ex)
            {
                _error.AddException(ex, "Sale");
            }
        }

        private void calculatetotal()
        {
            double total;
            double CGSTAmt = 0;
            double SGSTAmt = 0;
            double IGSTAmt = 0;
           
            total = Convert.ToDouble(lbl_BasePrice.Text) + CGSTAmt + SGSTAmt + IGSTAmt;
            txt_Amt.Text = total.ToString();
        }

        private void CalculateBase()
        {
            lbl_BasePrice.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_SellingAmt.Text) * 100) / (100 + Convert.ToDouble(0) + Convert.ToDouble(0) + Convert.ToDouble(0)), 2)) ;
        }

        private void CalculateTotalBase()
        {
            if (lbl_BasePrice.Text != "" || txt_Qty.Text != "" || lbl_BasePrice.Text != string.Empty || txt_Qty.Text != string.Empty)
                lbl_TotalPrice.Text = Convert.ToString(Math.Round(Convert.ToDouble(lbl_BasePrice.Text) * Convert.ToDouble(txt_Qty.Text),2));
        }
       
        private void calculateDiscount()
        {
            if (txt_Discount.Text != "" || txt_Discount.Text != string.Empty || txt_Discount.Text != " ")
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
            if (BillType == "Update")
            {
                _Sale.DeleteBillDetails(BillNo,"Sale");
                _Sale.DeleteBillItem(BillNo,"Sale");
            }

            MessageBox.Show("Do you Want to Continue With Bill Amount of ₹ " + txt_NetAmt.Text.ToString());

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
                    string TotalAmount = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                    string TotalPrice = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalPrice"].Value);
                    string SalesPerson =Convert.ToString(cmb_SalesPerson.SelectedIndex + 1);
                    string Maintain = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Maintain"].Value);
                    string size= Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Size"].Value);
                    string PBillNo = txt_BillNo.Text;
                    
                    _Sale.AddItemDetails(category,subcategory, size,txt_BillNo.Text,"Sale",dtp_Date.Value.ToString("dd/MM/yyyy"),price,Qty,"0", "0", "0", "0", "0", "0", TotalAmount, BatchNo, HSN, TotalPrice,SalesPerson,Maintain,"0","0","0", "0", "0");
                    
                }
            }
        
            catch (Exception ex)
            {
                _error.AddException(ex, "Sale/Item");
            }
            try
            {
                _Sale.AddBillDetails(txt_BillNo.Text, txt_AccNo.Text, dtp_Date.Value.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), txt_TotalAmt.Text, "0", "0", "0" , txt_NetAmt.Text, cmb_State.Text, txt_BillAmt.Text, txt_Discount.Text, "Estimate",txt_Extra.Text,txt_Narration.Text,"0");


                //payment
                if (txt_PaidAmt.Text != null || txt_PaidAmt.Text != "")
                {
                    int paid = Convert.ToInt32(txt_PaidAmt.Text);

                    if (paid != 0)
                    {
                        _a.InsertPaymentDetails("Sale", txt_PaidAmt.Text, cmb_PayMode.Text, txt_AccNo.Text, dtp_Date.Value.ToString("dd/MM/yyyy"), txt_BillNo.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                _error.AddException(ex, "Sale/BillDetails");
            }
            try
            {
                Report.CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new Report.CrystalReport.frm_ReportViewer();
                SendData _obj = new SendData(_objfrm_ReportViewer.CustomerBillEst);
                _obj(txt_BillNo.Text,"Print");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _error.AddException(ex, "Sale/Print");
            }
            //_Sale.PrintBillThermal(BillNo);

            MessageBox.Show("Sale Successfully Done");
            Masterclear();
            Clear();
            if (bttn_Sale.Text == "Update")
            {
                this.Close();
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
                Add(); ;
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
                    txt_BarcodeNo.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["BarcodeNo"].Value.ToString();
                    cmb_Category.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Category"].Value.ToString();
                    cmb_SubCategory.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SubCategory"].Value.ToString();
                    cmb_size.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["size"].Value.ToString();
                    txt_SellingAmt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Rate"].Value.ToString();
                    txt_Qty.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Qty"].Value.ToString();
                    txt_HSN.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["HSN"].Value.ToString();
                    txt_BatchNo.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["BatchNo"].Value.ToString();
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
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["size"].Value = cmb_size.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["HSN"].Value = txt_HSN.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["BatchNo"].Value = txt_BatchNo.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Rate"].Value = txt_SellingAmt.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Qty"].Value = txt_Qty.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable To Update", "Application says", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _error.AddException(ex, "sale");
            }
            bttn_Add.Enabled = true;
            Clear();
            txt_NetAmt.Text = Convert.ToString(Convert.ToDouble(txt_TotalAmt.Text));
            Calculate();
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_ItemInfo.Rows.RemoveAt(dgv_ItemInfo.CurrentCell.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable To Delete", "Application says", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _error.AddException(ex, "Sale");
            }
            bttn_Add.Enabled = true;
            Clear();
            calculatetotal();
            Calculate();

        }

        private void txt_SellingAmt_TextChanged(object sender, EventArgs e)
        {
            //txt_Amt.Text = "";
            if (lbl_BasePrice.Text!="" || txt_Qty.Text!="" || lbl_BasePrice.Text != string.Empty || txt_Qty.Text != string.Empty)
                txt_Amt.Text = Convert.ToString(Math.Round(Convert.ToDouble(txt_SellingAmt.Text) * Convert.ToDouble(txt_Qty.Text),2));
            CalculateBase();
            CalculateTotalBase();
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

        

        private void txt_SGSTper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add();
            }
        }

        private void cmb_State_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_SubCategory.DataSource=_a.GetSubCategoryByCategory(cmb_Category.Text);
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
                txt_Narration.Focus();
            }
        }

        private void cmb_size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmb_SubCategory.Text != "" || cmb_SubCategory.Text != string.Empty)
                {   
                    fillitem();
                }
            }
        }

        private void cmb_SubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = _a.GetSizeByCatAndSubCat(cmb_Category.Text, cmb_SubCategory.Text);
            cmb_size.DataSource = dt;
        }

        private void txt_Extra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Discount.Focus();
            }
        }

        private void txt_Narration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Sale.Focus();
            }
        }

        private void cmb_SalesPerson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_maintain.Visible == true)
                {
                    txt_maintain.Focus();
                }
                else
                {
                    Add();
                }

            }
        }

        private void txt_maintain_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_maintain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add();
            }
        }
    }
}
