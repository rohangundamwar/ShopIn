using PrimeSolutions.Library;
using System;
using System.Data;
using System.Windows.Forms;
using PrimeSolutions.Common;

namespace PrimeSolutions

{
    public partial class frm_ViewGSTBill : Form
    {
        
        clsCommon _common = new clsCommon();
        SaleCommon _Sale = new SaleCommon();
        SettingValue dtSett;
        AllClassFile _a = new AllClassFile();
        DataTable Payment,CustomerBill;
        DateTime Date { get; set; }
        string BillType { get; set; }


        public frm_ViewGSTBill()
        {
            
        }

        public frm_ViewGSTBill(string BillNo)
        {
            BillType = "Update";
            dtSett = new SettingValue();
            dtSett = _common.getSettingValue();
            InitializeComponent();
            getBillDetails(BillNo);
        }

        private void frm_ViewGSTBill_load(object sender, EventArgs e)
        {
           
        }
        
        

        public void getBillDetails(string billNo)
        {
            txt_BillNo.Text = billNo.ToString();

            Date = Convert.ToDateTime(CustomerBill.Rows[0]["Date"].ToString());
            dtp_Date.Value = Date;

            //CustomerDetsils
            DataTable Cust = _Sale.GetCustomerByBill(billNo);

            cmb_Name.Text = Cust.Rows[0]["CustomerName"].ToString();
            cmb_Name.Enabled = false;
            txt_AccNo.Text = Cust.Rows[0]["CustId"].ToString();
            cmb_State.Text = Cust.Rows[0]["State"].ToString();
            cmb_State.Enabled = false;
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
                txt_PaidAmt.Text = Payment.Rows[0]["Amt"].ToString();
                
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
            txt_Extra.Text= CustomerBill.Rows[0]["ExtraCharges"].ToString();
            txt_CashDisc.Text = CustomerBill.Rows[0]["CashDiscount"].ToString();


            //BillItem
            DataTable BillItem = _Sale.GetBillItem(billNo, "Sale");
            for (int i = 0; i < BillItem.Rows.Count; i++)
            {
                /*1*/ string barcode = BillItem.Rows[i]["Barcode"].ToString();
                /*2*/ string category = BillItem.Rows[i]["Category"].ToString();
                /*3*/string SubCategory = BillItem.Rows[i]["SubCategory"].ToString();
                /*4*/string Size = BillItem.Rows[i]["Size"].ToString();
                /*5*/string HSN = BillItem.Rows[i]["HSN"].ToString();
                /*6*/string BatchNo = BillItem.Rows[i]["BatchNo"].ToString();
                /*7*/string Rate = BillItem.Rows[i]["Price"].ToString();
                /*8*/string qty = BillItem.Rows[i]["Qty"].ToString();
                /*9*/string Total = BillItem.Rows[i]["TotalAmount"].ToString();
                /*10*/string DiscPer = BillItem.Rows[i]["DiscPer"].ToString();
                /*11*/string DiscAmt = BillItem.Rows[i]["DiscAmt"].ToString();
                /*12*/string CGST = BillItem.Rows[i]["CGST"].ToString();
                /*13*/string CGSTAmt = BillItem.Rows[i]["CGSTAmt"].ToString();
                /*14*/string SGST = BillItem.Rows[i]["SGST"].ToString();
                /*15*/string SGSTAmt = BillItem.Rows[i]["SGSTAmt"].ToString();
                /*16*/string IGST = BillItem.Rows[i]["IGST"].ToString();
                /*17*/string IGSTAmt = BillItem.Rows[i]["IGSTAmt"].ToString();
                /*18*/string Selling = BillItem.Rows[i]["SellingPrice"].ToString();
                /*19*/string XX;
                /*20*/string sales = BillItem.Rows[i]["SalesPerson"].ToString();
                /*21*/string maintain = BillItem.Rows[i]["Maintain"].ToString();
                /*22*/string ActualPrice = BillItem.Rows[i]["ActualPrice"].ToString();
                /*23*/string FinalAmount = BillItem.Rows[i]["FinalAmount"].ToString();
                
                dgv_ItemInfo.Rows.Add( barcode, category,  SubCategory,  Size,  HSN, BatchNo, Rate, qty,Total,DiscPer,DiscAmt,CGST, CGSTAmt, SGST,  SGSTAmt, IGST,  IGSTAmt,  Selling,"",sales, maintain, ActualPrice,FinalAmount);
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_SaleForm_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        
    }
}
