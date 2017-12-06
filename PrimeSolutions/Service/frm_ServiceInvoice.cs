using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;
using PrimeSolutions.Common;
using PrimeSolutions.PaymentOption;

namespace PrimeSolutions.Service
{
    public partial class frm_ServiceInvoice : Form
    {
        cls_ServiceCommon _service = new cls_ServiceCommon();
        clsCommon _common = new clsCommon();
        ErrorLog _error = new ErrorLog();
        Simplevalidations _Valid = new Simplevalidations();
        public delegate void SendData(string BillNO, string type);
        SaleCommon _Sale = new SaleCommon();
        AllClassFile _a = new AllClassFile();
        SettingValue dtSett;
        string VouchertypeID = "0";
        string VouchertypeIDPayment = "0";
        public int[] PaymentIDs = new int[2];

        string JobNo = "";

        public frm_ServiceInvoice()
        {
            InitializeComponent();
        }

        public frm_ServiceInvoice(string JobID)
        {
            InitializeComponent();
            JobNo = JobID;
            cmb_ServiceId.Text = JobNo;
            DataTable Cust = _service.GetCustFromServiceId(JobNo);
            txt_name.Text = Cust.Rows[0]["CustomerName"].ToString();
            txt_address.Text = Cust.Rows[0]["Address"].ToString() + ", " + Cust.Rows[0]["City"].ToString() + ", " + Cust.Rows[0]["State"].ToString();
            txt_Contact.Text = Cust.Rows[0]["ContactNo"].ToString();
            lbl_CustID.Text = Cust.Rows[0]["CustId"].ToString();

        }

        private void frm_ServiceInvoice_Load(object sender, EventArgs e)
        {
            if (JobNo == "")
            {
                cmb_ServiceId.DataSource = _service.GetServiceId();
            }

        }

        private void cmb_ServiceId_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Cust = _service.GetCustFromServiceId(cmb_ServiceId.Text);
            txt_name.Text = Cust.Rows[0]["CustomerName"].ToString();
            txt_address.Text = Cust.Rows[0]["Address"].ToString() + "," + Cust.Rows[0]["City"].ToString() + "," + Cust.Rows[0]["State"].ToString();
            txt_Contact.Text = Cust.Rows[0]["ContactNo"].ToString();
        }

        private void Masterclear()
        {
            dgv_ItemInfo.Rows.Clear();
        }
        private void Add()
        {
            try
            {

                dgv_ItemInfo.Rows.Add(cmb_Category.Text, cmb_SubCategory.Text, cmb_size.Text, txt_HSN.Text, txt_BatchNo.Text, lbl_BasePrice.Text, txt_Qty.Text, lbl_TotalPrice.Text, txt_CGSTper.Text, lbl_CGSTAmt.Text, txt_SGSTper.Text, lbl_SGSTAmt.Text, txt_IGSTper.Text, lbl_IGSTAmt.Text, txt_Amt.Text, lbl_TotalPrice.Text, txt_maintain.Text);
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

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            Add();
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
                    total += Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value), 2);
                    CGSTAmt += Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["CGST"].Value), 2);
                    SGSTAmt += Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["SGST"].Value), 2);
                    IGSTAmt += Math.Round(Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["IGST"].Value), 2);
                }

                txt_TotalAmt.Text = total.ToString();
                lbl_CGSTValue.Text = CGSTAmt.ToString();
                lbl_SGSTValue.Text = SGSTAmt.ToString();
                lbl_IGSTValue.Text = IGSTAmt.ToString();

                txt_NetAmt.Text = txt_BillAmt.Text = Convert.ToString(_common.sumGridViewColumn(dgv_ItemInfo, "TotalPrice"));

            }
            catch (Exception ex)
            {
                _error.AddException(ex, "Sale");
            }
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

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            try
            {

                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Category"].Value = cmb_Category.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SubCategory"].Value = cmb_SubCategory.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Rate"].Value = txt_SellingAmt.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Qty"].Value = txt_Qty.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Size"].Value = cmb_size.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["HSN"].Value = txt_HSN.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["BatchNo"].Value = txt_BatchNo.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["CGSTper"].Value = txt_CGSTper.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["CGST"].Value = lbl_CGSTAmt.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SGSTper"].Value = txt_SGSTper.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SGST"].Value = lbl_SGSTAmt.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["IGSTper"].Value = txt_IGSTper.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["IGST"].Value = lbl_IGSTAmt.Text;


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

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bttn_All_Click(object sender, EventArgs e)
        {
            dgv_ItemInfo.Rows.Clear();
        }

        private void txt_HSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Valid.ValidationDigitWithPoint(e, txt_HSN.Text);
        }

        private void txt_BatchNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Valid.ValidationDigitWithPoint(e, txt_BatchNo.Text);
        }

        private void txt_SellingAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Valid.ValidationDigitWithPoint(e, txt_SellingAmt.Text);
        }

        private void txt_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Valid.ValidationDigitWithPoint(e, txt_Qty.Text);
        }

        private void txt_CGSTper_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Valid.ValidationDigitWithPoint(e, txt_CGSTper.Text);
        }
        private void txt_SGSTper_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Valid.ValidationDigitWithPoint(e, txt_SGSTper.Text);
        }

        private void txt_IGSTper_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Valid.ValidationDigitWithPoint(e, txt_IGSTper.Text);
        }

        private void txt_maintain_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Valid.ValidationDigitWithPoint(e, txt_maintain.Text);
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
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
                cmb_size.Focus();
            }
        }

        private void cmb_size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_HSN.Focus();
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

        private void txt_SellingAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Qty.Focus();
            }
        }

        private void txt_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CGSTper.Focus();
            }
        }

        private void txt_SGSTper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_IGSTper.Focus();
            }
        }

        private void txt_IGSTper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_maintain.Focus();
            }
        }

        private void txt_CGSTper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_SGSTper.Focus();
            }
        }

        private void txt_maintain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add();
            }
        }

        private void txt_SellingAmt_TextChanged(object sender, EventArgs e)
        {
            if (lbl_BasePrice.Text != "" || txt_Qty.Text != "" || lbl_BasePrice.Text != string.Empty || txt_Qty.Text != string.Empty)
                txt_Amt.Text = Convert.ToString(Math.Round(Convert.ToDouble(txt_SellingAmt.Text) * Convert.ToDouble(txt_Qty.Text), 2));
            CalculateBase();
            CalculateGST();
            CalculateTotalBase();
        }

        private void CalculateBase()
        {
            lbl_BasePrice.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_SellingAmt.Text) * 100) / (100 + Convert.ToDouble(txt_CGSTper.Text) + Convert.ToDouble(txt_SGSTper.Text) + Convert.ToDouble(txt_IGSTper.Text)), 2));

        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            txt_Amt.Text = "";
            try
            {
                if (txt_SellingAmt.Text != "" || txt_SellingAmt.Text != string.Empty)
                    if (txt_Qty.Text != "" || txt_Qty.Text != string.Empty)
                        txt_Amt.Text = Convert.ToString(Math.Round(Convert.ToDouble(txt_SellingAmt.Text) * Convert.ToDouble(txt_Qty.Text), 2));
            }
            catch { }
            CalculateGST();
            CalculateTotalBase();
        }

        private void CalculateGST()
        {
            if (lbl_CGSTAmt.Text != "" || lbl_CGSTAmt.Text != string.Empty)
            {
                if (txt_CGSTper.Text != "" || txt_CGSTper.Text != string.Empty)
                    lbl_CGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_CGSTper.Text) * 0.01) * (Convert.ToDouble(lbl_BasePrice.Text) * Convert.ToDouble(txt_Qty.Text)), 2));

                if (lbl_SGSTAmt.Text != "" || lbl_SGSTAmt.Text != string.Empty)
                {
                    if (txt_SGSTper.Text != "" || txt_SGSTper.Text != string.Empty)
                        lbl_SGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_SGSTper.Text) * 0.01) * (Convert.ToDouble(lbl_BasePrice.Text) * Convert.ToDouble(txt_Qty.Text)), 2));

                    if (lbl_IGSTAmt.Text != "" || lbl_IGSTAmt.Text != string.Empty)
                    {
                        if (txt_IGSTper.Text != "" || txt_IGSTper.Text != string.Empty)
                            lbl_IGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_IGSTper.Text) * 0.01) * (Convert.ToDouble(lbl_BasePrice.Text) * Convert.ToDouble(txt_Qty.Text)), 2));
                    }
                }
            }
        }

        private void CalculateTotalBase()
        {
            if (lbl_BasePrice.Text != "" || txt_Qty.Text != "" || lbl_BasePrice.Text != string.Empty || txt_Qty.Text != string.Empty)
                lbl_TotalPrice.Text = Convert.ToString(Math.Round(Convert.ToDouble(lbl_BasePrice.Text) * Convert.ToDouble(txt_Qty.Text), 2));
        }

        private void txt_CGSTper_TextChanged(object sender, EventArgs e)
        {
            if (txt_CGSTper.Text != "")
            {
                lbl_CGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_CGSTper.Text) * 0.01) * Convert.ToDouble(txt_Amt.Text), 2));
            }
            CalculateBase();
            CalculateGST();
            CalculateTotalBase();
        }

        private void txt_SGSTper_TextChanged(object sender, EventArgs e)
        {
            if (txt_SGSTper.Text != "")
            {
                lbl_SGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_SGSTper.Text) * 0.01) * Convert.ToDouble(txt_Amt.Text), 2));
            }
            CalculateBase();
            CalculateGST();
            CalculateTotalBase();
        }

        private void txt_IGSTper_TextChanged(object sender, EventArgs e)
        {
            if (txt_IGSTper.Text != "")
            {
                lbl_IGSTAmt.Text = Convert.ToString(Math.Round((Convert.ToDouble(txt_IGSTper.Text) * 0.01) * Convert.ToDouble(txt_Amt.Text), 2));
            }
            CalculateBase();
            CalculateGST();
            CalculateTotalBase();
        }

        private void txt_Discount_TextChanged(object sender, EventArgs e)
        {
            calculateDiscount();


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

        private void txt_PaidAmt_TextChanged(object sender, EventArgs e)
        {
            if (txt_NetAmt.Text != "" || txt_NetAmt.Text != "0" || txt_NetAmt.Text != string.Empty)
                if (txt_BillAmt.Text != "" || txt_BillAmt.Text != "0" || txt_BillAmt.Text != string.Empty)
                    if (txt_PaidAmt.Text != "" || txt_PaidAmt.Text != "0" || txt_PaidAmt.Text != string.Empty)
                        txt_BalanceAmt.Text = Convert.ToString((Convert.ToDouble(txt_NetAmt.Text) + Convert.ToDouble(txt_BillAmt.Text)) - Convert.ToDouble(txt_PaidAmt.Text));
        }

        private void txt_Discount_KeyDown(object sender, KeyEventArgs e)
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

        private void cmb_PayMode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Other.Focus();
            }
        }

        private void txt_Other_KeyDown(object sender, KeyEventArgs e)
        {
            bttn_Sale.Focus();
        }

        private void bttn_Sale_Click(object sender, EventArgs e)
        {
            string BillNo = cmb_ServiceId.Text;

            string TransactionLedgerID = null;

            try
            {

                for (int i = 0; i < dgv_ItemInfo.Rows.Count; i++)
                {
                    //string barcode = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["BarcodeNo"].Value);
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
                    string Size = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Size"].Value);
                    string PBillNo = BillNo;
                    //string SalesPerson = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Sales"].Value);
                    string Maintain = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Maintain"].Value);
                    
                    _Sale.AddItemDetails(category, subcategory, Size, cmb_ServiceId.Text, "Service Invoice", dtp_Date.Value.ToString("dd/MM/yyyy"), price, Qty, CGSTper, CGST, SGSTper, SGST, IGSTper, IGST, TotalAmount, BatchNo, HSN, TotalPrice, "", Maintain);
                    

                    if (dgv_ItemInfo.Rows[i].Cells["Maintain"].Value.ToString() != "0")
                    {
                        _service.AddMaintain(dtp_Date.Value.ToString("dd/MM/yyyy"), category + " " + subcategory, dtp_Date.Value.AddMonths(Convert.ToInt32(Maintain)).ToString("dd/MM/yyyy"), lbl_CustID.Text);
                    }
                }
            }

            catch (Exception ex)
            {
                _error.AddException(ex, "Service Invoice");
            }

            try
            {

                _Sale.AddBillDetails(cmb_ServiceId.Text, lbl_CustID.Text, dtp_Date.Value.ToString("dd/MM/yyyy"), txt_TotalAmt.Text, lbl_CGSTValue.Text, lbl_SGSTValue.Text, lbl_IGSTValue.Text, txt_NetAmt.Text,"", txt_BillAmt.Text, txt_Discount.Text, "Service Invoice");

                if (txt_PaidAmt.Text != "" || txt_PaidAmt.Text != "0" || txt_PaidAmt.Text == string.Empty)
                {
                    _a.InsertPaymentDetails("Sale", txt_PaidAmt.Text, cmb_PayMode.Text, lbl_CustID.Text, dtp_Date.Value.ToString("dd/MM/yyyy"), cmb_ServiceId.Text);
                }
                //create account ledger
                string ledgerId;
                ledgerId = _Sale.insertAcountLedgerDetail(Vouchertypeid: VouchertypeID, AccNo: lbl_CustID.Text, Name: txt_name.Text, Narration: "", Date: dtp_Date.Text);

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
                    DialogResult dr = MessageBox.Show("Amount to be Payed :" + txt_PaidAmt.Text + "\n\n Do You Want To Continue", "ShopIn Says ", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        if (dtSett.PaymentForm == "1")
                        {
                            frm_PaymentOptionForReceiptVoucher form = new frm_PaymentOptionForReceiptVoucher
                                (
                               Amountpaid: txt_PaidAmt.Text,
                               billno: cmb_ServiceId.Text,
                               Accountno: lbl_CustID.Text,
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
                _Sale.InsertCreditDebitInSalesAccount(customerLedgerID: ledgerId, VouchertypeID: VouchertypeID, sbillno: lbl_CustID.Text.ToString(), Name: txt_name.Text, Amount: txt_PaidAmt.Text, Narration: "", Date: dtp_Date.Text);

            }


            catch (Exception ex)
            {
                _error.AddException(ex, "Sale/AddBillDetails");
            }
            try
            {
                Report.CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new Report.CrystalReport.frm_ReportViewer();
                SendData _obj = new SendData(_objfrm_ReportViewer.ServiceInvoice);
                _obj(cmb_ServiceId.Text, "Print");
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

    }
}