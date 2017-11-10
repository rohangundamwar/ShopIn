using PrimeSolutions.Accounting;
using PrimeSolutions.Common;
using PrimeSolutions.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions.PaymentOption
{
    public partial class frm_PaymentOptionForPaymentVoucher : Form
    {
        Cls_paymentoption _objclspaymentoption = new Cls_paymentoption();
        clsCommon _objCommon = new clsCommon();
        Cls_BalanceSheet _objCreditDebit = new Cls_BalanceSheet();
        Validation _objvalidation = new Validation();
        public string TransactionLedgerID { get; set; }
        public bool ReturnStatus { get; set; }

        string Receivedamt;
        string bill_no;
        //string date;

        string paymode, Acc_no, date;
        CustomerType frm_form;

        public int[] PaymentIDs = new int[2];
        public OperationType _operationType;
        string bankname, card_cheque_no, Narration, CashAmount;
        double OtherTransactionAmount;
        string ColumnName = "";
        bool accountWiseInsert = false;
        string VoucherTypeName = "";
        string VoucherTypeId = "";
        string VoucherId = "";

        //delegate for report
        public delegate void SendData(string BillNO, string AccNo, string type);
        public delegate void sendData1(string BillNO, string AccNo);

        public frm_PaymentOptionForPaymentVoucher(string Amountpaid, string billno, String Accountno, String Date, CustomerType CustomerType, OperationType OperationType, string VoucherTypeId = "", string VoucherId = "")
        {
            InitializeComponent();
            Receivedamt = Amountpaid;
            bill_no = billno;
            Acc_no = Accountno;
            dtp_Date.Text = Date;

            this.VoucherTypeId = VoucherTypeId;
            this.VoucherId = VoucherId;
            frm_form = CustomerType;
            _operationType = OperationType;
            accountWiseInsert = true;

            switch (frm_form)
            {
                case CustomerType.VyapariGST:
                case CustomerType.VyapariVAT:
                    ColumnName = "VBillID";
                    VoucherTypeName = "Sales Receipt Voucher";
                    break;
                case CustomerType.CustomerSaleGST:
                case CustomerType.CustomerVAT:
                case CustomerType.CustomerReceiptGST:
                    ColumnName = "SBillID";
                    VoucherTypeName = "Sales Receipt Voucher";
                    break;

                case CustomerType.CustomerOrder:
                    ColumnName = "OrderID";
                    VoucherTypeName = "Sales Receipt Voucher";
                    break;

                case CustomerType.SupplierPurchaseGST:
                case CustomerType.SupplierPurchaseJobWork:
                case CustomerType.SupplierPurchaseVAT:
                    ColumnName = "PBillID";
                    VoucherTypeName = "Purchase Receipt Voucher";
                    break;

                case CustomerType.ImitationPurchase:
                    ColumnName = "IMBillID";
                    VoucherTypeName = "Purchase Receipt Voucher";
                    break;
                case CustomerType.ImitationSales:
                    ColumnName = "ISBillID";
                    VoucherTypeName = "Sales Receipt Voucher";
                    break;

                case CustomerType.DiamondPurchaseGST:
                    ColumnName = "DPBillID";
                    VoucherTypeName = "Purchase Receipt Voucher";
                    break;

                case CustomerType.DiamondSaleGST:
                    ColumnName = "DSBillID";
                    VoucherTypeName = "Sales Receipt Voucher";
                    break;

                case CustomerType.ReceiptVoucher:
                    ColumnName = "VoucherId";
                    VoucherTypeName = "Receipt Voucher";
                    break;

                case CustomerType.ModEntry:
                    ColumnName = "VoucherId";
                    VoucherTypeName = "Mod Invoice GST";
                    break;
            }

            if (OperationType == OperationType.Edit)
            {
                FillDetails(ColumnName);
            }
            else
            {
                tbc_PaymentDetails.SelectedIndex = 0;
            }
        }

        private void FillDetails(string columnName)
        {
            string PaymentType = "";
            DataTable dtr = _objCommon.getALLTableDetails(sTableName: TableNames.PaymentDetail, sColomnName: "VoucherTypeId", sColumnValue: VoucherTypeId);
            if (dtr.Rows.Count > 0)
            {
                var data = dtr.Select().Where(a => a.Field<int?>("VoucherId") == Convert.ToInt32(VoucherId)).ToList();
                if (data.Count != 0)
                {
                    dtr = data.CopyToDataTable();
                    if (dtr.Rows.Count > 1)
                        PaymentType = "PARTIAL";
                    else
                        PaymentType = dtr.Rows[0]["Payment_Type"].ToString();

                    switch (PaymentType)
                    {
                        case "CASH":
                            tbc_PaymentDetails.SelectedIndex = 0;
                            lblcashamt.Text = dtr.Rows[0]["Received_Amount"].ToString();

                            break;
                        case "CARD":
                            tbc_PaymentDetails.SelectedIndex = 1;

                            txtnarrationCard.Text = dtr.Rows[0]["Narration"].ToString();
                            lblcardamt.Text = dtr.Rows[0]["Received_Amount"].ToString();
                            break;
                        case "CHEQUE":
                            tbc_PaymentDetails.SelectedIndex = 2;

                            txtchequeno.Text = dtr.Rows[0]["Card_chequeno"].ToString();
                            txtnarrationcheque.Text = dtr.Rows[0]["Narration"].ToString();
                            lblchequeamt.Text = dtr.Rows[0]["Received_Amount"].ToString();
                            break;
                        case "RTGS":
                            tbc_PaymentDetails.SelectedIndex = 3;
                            txtbankname_RTGS.SelectedItem = dtr.Rows[0]["Bank_name"].ToString();
                            txt_cheque_rtgs.Text = dtr.Rows[0]["Card_chequeno"].ToString();
                            txtnarration_rtgs.Text = dtr.Rows[0]["Narration"].ToString();
                            lblamount_rtgs.Text = dtr.Rows[0]["Received_Amount"].ToString();
                            break;
                        case "NEFT":
                            tbc_PaymentDetails.SelectedIndex = 4;
                            cmb_BankNameNEFT.SelectedItem = dtr.Rows[0]["Bank_name"].ToString();
                            txt_ChequeNEFT.Text = dtr.Rows[0]["Card_chequeno"].ToString();
                            txt_NarrationNEFT.Text = dtr.Rows[0]["Narration"].ToString();
                            lbl_amountNEFT.Text = dtr.Rows[0]["Received_Amount"].ToString();
                            break;
                        case "PARTIAL":
                            tbc_PaymentDetails.SelectedIndex = 5;
                            if (dtr.Rows[1]["Payment_Type"].ToString() == "CARD")
                            {
                                tbc_PaymentDetails.SelectedIndex = 1;

                                txtnarrationCard.Text = dtr.Rows[1]["Narration"].ToString();
                                lblcardamt.Text = dtr.AsEnumerable().Sum(a => Convert.ToDouble(a.Field<string>("Received_Amount"))).ToString();
                                chk_PartialCard.Checked = true;
                                txt_PartialAmountCard.Text = dtr.Rows[0]["Received_Amount"].ToString();
                            }

                            if (dtr.Rows[1]["Payment_Type"].ToString() == "CHEQUE")
                            {
                                tbc_PaymentDetails.SelectedIndex = 2;

                                txtchequeno.Text = dtr.Rows[1]["Card_chequeno"].ToString();
                                txtnarrationcheque.Text = dtr.Rows[1]["Narration"].ToString();
                                lblchequeamt.Text = dtr.AsEnumerable().Sum(a => Convert.ToDouble(a.Field<string>("Received_Amount"))).ToString();
                                chk_PartialCheque.Checked = true;
                                txt_PartialAmountCheque.Text = dtr.Rows[0]["Received_Amount"].ToString();
                            }

                            if (dtr.Rows[1]["Payment_Type"].ToString() == "RTGS")
                            {
                                tbc_PaymentDetails.SelectedIndex = 3;
                                txtbankname_RTGS.SelectedItem = dtr.Rows[1]["Bank_name"].ToString();
                                txt_cheque_rtgs.Text = dtr.Rows[1]["Card_chequeno"].ToString();
                                txtnarration_rtgs.Text = dtr.Rows[1]["Narration"].ToString();
                                lblamount_rtgs.Text = dtr.AsEnumerable().Sum(a => Convert.ToDouble(a.Field<string>("Received_Amount"))).ToString();
                                chk_PartialRTGS.Checked = true;
                                txt_PartialAmountRTGS.Text = dtr.Rows[0]["Received_Amount"].ToString();
                            }

                            if (dtr.Rows[1]["Payment_Type"].ToString() == "NEFT")
                            {
                                tbc_PaymentDetails.SelectedIndex = 4;
                                cmb_BankNameNEFT.SelectedItem = dtr.Rows[1]["Bank_name"].ToString();
                                txt_ChequeNEFT.Text = dtr.Rows[1]["Card_chequeno"].ToString();
                                txt_NarrationNEFT.Text = dtr.Rows[1]["Narration"].ToString();
                                lbl_amountNEFT.Text = dtr.AsEnumerable().Sum(a => Convert.ToDouble(a.Field<string>("Received_Amount"))).ToString();
                                chkPartialNEFT.Checked = true;
                                txt_PartialAmountNEFT.Text = dtr.Rows[0]["Received_Amount"].ToString();
                            }
                            break;
                        default:
                            tbc_PaymentDetails.SelectedIndex = 0;
                            lblcashamt.Text = dtr.Rows[0]["Received_Amount"].ToString();
                            break;
                    }
                }
            }
            else
            {
                fillDefaultdebitComboBox();
            }
        }



        private void frm_PaymentOption_Load(object sender, EventArgs e)
        {
            fillDefaultdebitComboBox();

        }

        private void fillDefaultdebitComboBox()
        {
            lblcashamt.Text = Receivedamt;
            lblcardamt.Text = Receivedamt;
            lblchequeamt.Text = Receivedamt;
            lblamount_rtgs.Text = Receivedamt;
            lbl_amountNEFT.Text = Receivedamt;
            DataTable dtLedgerCash = _objCreditDebit.getAcountLedgerFromgroup("Cash-In-Hand");
            cmbDebitCash.DataSource = dtLedgerCash;
            DataTable dtLedgerBank = _objCreditDebit.getAcountLedgerFromgroup("Bank Account", "Bank OD A/C");
            cmbDebitPayByCard.DataSource = dtLedgerBank;
            CmbDebitToCheque.DataSource = dtLedgerBank;
            CmbDebitToNEFT.DataSource = dtLedgerBank;
            CmbDebitToRTGS.DataSource = dtLedgerBank;
        }




        private void bttn_Close_Click(object sender, EventArgs e)
        {
            ReturnStatus = false;
            this.Close();
        }

        private void bttn_Save_Click(object sender, EventArgs e)
        {

            string Pay_date = DateTime.Now.ToString("dd/MM/yyyy");
            if (check1())
            {
                if (_operationType == OperationType.Create)
                {
                    if (OtherTransactionAmount != 0)
                    {
                        PaymentIDs[0] = _objclspaymentoption.cashsave
                             (
                           billno: bill_no,
                           paytype: "CASH",
                           amount: CashAmount,
                           pay_datetime: Pay_date,
                           bankname: "",
                           cashchequeno: "",
                           Narration: "",
                           sCustomerType: frm_form,
                           AccountNo: Acc_no
                           );
                        PaymentIDs[1] = _objclspaymentoption.cashsave
                            (
                          billno: bill_no,
                          paytype: paymode,
                          amount: OtherTransactionAmount.ToString(),
                          pay_datetime: Pay_date,
                          bankname: bankname,
                          cashchequeno: card_cheque_no,
                          Narration: Narration,
                          sCustomerType: frm_form,
                          AccountNo: Acc_no
                          );
                    }
                    else
                    {
                        PaymentIDs[0] = _objclspaymentoption.cashsave
                             (
                           billno: bill_no,
                           paytype: paymode,
                           amount: Receivedamt,
                           pay_datetime: Pay_date,
                           bankname: bankname,
                           cashchequeno: card_cheque_no,
                           Narration: Narration,
                           sCustomerType: frm_form,
                           AccountNo: Acc_no
                           );
                    }

                    MessageBox.Show("Payment Details Saved");
                    ReturnStatus = true;
                    clear();
                }
                else if (_operationType == OperationType.Edit)
                {

                    // string sBillNo = _objCommon.getALLTableDetails(sTableName: TableName, sColomnName: ColumnName, sColumnValue: bill_no).Rows[0]["BillNo"].ToString(); //_objCustomerSale.GetBillNoFromSalesBBillMasterBysBillID(bill_no);
                    _objCommon.UpdatePaymentDetailsToPermanentDelete(VoucherTypeId: VoucherTypeId, VoucherId: VoucherId);

                    if (OtherTransactionAmount != 0)
                    {
                        PaymentIDs[0] = _objclspaymentoption.cashsave
                             (
                           billno: bill_no,
                           paytype: "CASH",
                           amount: CashAmount,
                           pay_datetime: Pay_date,
                           bankname: "",
                           cashchequeno: "",
                           Narration: "",
                           sCustomerType: frm_form,
                            AccountNo: Acc_no
                           );


                        _objCommon.updatePaymentDetailByPaymentID(ColumnName: "VoucherTypeId", columnValue: VoucherTypeId, paymentid: PaymentIDs[0]);
                        _objCommon.updatePaymentDetailByPaymentID(ColumnName: "VoucherId", columnValue: VoucherId.ToString(), paymentid: PaymentIDs[0]);


                        PaymentIDs[1] = _objclspaymentoption.cashsave
                            (
                          billno: bill_no,
                          paytype: paymode,
                          amount: OtherTransactionAmount.ToString(),
                          pay_datetime: Pay_date,
                          bankname: bankname,
                          cashchequeno: card_cheque_no,
                          Narration: Narration,
                          sCustomerType: frm_form,
                              AccountNo: Acc_no
                          );

                        _objCommon.updatePaymentDetailByPaymentID(ColumnName: "VoucherTypeId", columnValue: VoucherTypeId, paymentid: PaymentIDs[1]);
                        _objCommon.updatePaymentDetailByPaymentID(ColumnName: "VoucherId", columnValue: VoucherId.ToString(), paymentid: PaymentIDs[1]);

                    }
                    else
                    {
                        PaymentIDs[0] = _objclspaymentoption.cashsave
                          (
                                billno: bill_no,
                                paytype: paymode,
                                amount: Receivedamt,
                                pay_datetime: Pay_date,
                                bankname: bankname,
                                cashchequeno: card_cheque_no,
                                Narration: Narration,
                                sCustomerType: frm_form,
                                AccountNo: Acc_no
                        );

                        _objCommon.updatePaymentDetailByPaymentID(ColumnName: "VoucherTypeId", columnValue: VoucherTypeId, paymentid: PaymentIDs[0]);
                        _objCommon.updatePaymentDetailByPaymentID(ColumnName: "VoucherId", columnValue: VoucherId.ToString(), paymentid: PaymentIDs[0]);

                    }

                    MessageBox.Show("Payment Details Saved");
                    ReturnStatus = true;
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Enter Proper details...");
                ReturnStatus = false;
                return;
            }
            this.Close();
        }

        private void clear()
        {

            txtbankname_RTGS.ResetText();
            cmb_BankNameNEFT.ResetText();
            txtchequeno.ResetText();

            txt_cheque_rtgs.ResetText();
            txt_ChequeNEFT.ResetText();
            txtnarrationCard.ResetText();
            txtnarrationcheque.ResetText();
            txtnarration_rtgs.ResetText();
            txt_NarrationNEFT.ResetText();

        }



        private void txtnarrationCard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //bttn_Save.Focus();
            }
        }

        private void txtnarrationcheque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //bttn_Save.Focus();
            }
        }

        private void rbtRTGS_CheckedChanged(object sender, EventArgs e)
        {
            lblerrbanknamertgs.Visible = false;
        }


        private void txt_cheque_rtgs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtnarration_rtgs.Focus();
            }
        }


        private void txtbankname_RTGS_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_cheque_rtgs.Focus();
            }
        }

        private void txt_bankname_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtchequeno.Focus();
            }
        }

        private void txt_cardno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtnarrationCard.Focus();
            }
        }

        private void txtchequeno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtnarrationcheque.Focus();
            }
        }

        private void rbt_NEFT_CheckedChanged(object sender, EventArgs e)
        {
            lbl_error_BankNameNEFT.Visible = false;
        }



        private void cmb_BankNameNEFT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ChequeNEFT.Focus();
            }
        }

        private void txt_ChequeNEFT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_NarrationNEFT.Focus();
            }
        }

        public bool check1()
        {
            bool Status = false;
            if (tbc_PaymentDetails.SelectedTab == tb_PayByCash)
            {
                Status = AssignData(payMod: "CASH", transactionLedgerID: cmbDebitCash.SelectedValue.ToString());
            }
            if (tbc_PaymentDetails.SelectedTab == tb_PayByCard)
            {
                if (cmbDebitPayByCard.SelectedValue != null)
                {
                    Status = AssignData(payMod: "CARD", bankName: "", cardOrChequeNo: "", narration: txtnarrationCard.Text, cashAmount: (chk_PartialCard.Checked == true) ? txt_PartialAmountCard.Text : lblcardamt.Text, otherTransactionAmount: (chk_PartialCard.Checked == true) ? lbl_PartialAmountCard.Text : null, transactionLedgerID: cmbDebitPayByCard.SelectedValue.ToString());
                }

            }
            if (tbc_PaymentDetails.SelectedTab == tb_Cheque)
            {
                if (CmbDebitToCheque.SelectedValue != null)
                {
                    Status = AssignData(payMod: "CHEQUE", bankName: "", cardOrChequeNo: txtchequeno.Text, narration: txtnarrationcheque.Text, cashAmount: (chk_PartialCheque.Checked == true) ? txt_PartialAmountCheque.Text : lblchequeamt.Text, otherTransactionAmount: (chk_PartialCheque.Checked == true) ? lbl_BalanceAmountCheque.Text : null, transactionLedgerID: CmbDebitToCheque.SelectedValue.ToString());

                }
            }
            if (tbc_PaymentDetails.SelectedTab == tb_RTGS)
            {
                if (CmbDebitToRTGS.SelectedValue != null)
                {
                    Status = AssignData(payMod: "RTGS", bankName: txtbankname_RTGS.Text, cardOrChequeNo: txt_cheque_rtgs.Text, narration: txtnarration_rtgs.Text, cashAmount: (chk_PartialRTGS.Checked == true) ? txt_PartialAmountRTGS.Text : lblamount_rtgs.Text, otherTransactionAmount: (chk_PartialRTGS.Checked == true) ? lbl_BalanceAmountRTGS.Text : null, transactionLedgerID: CmbDebitToRTGS.SelectedValue.ToString());
                }

            }
            if (tbc_PaymentDetails.SelectedTab == tb_NEFT)
            {
                if (CmbDebitToNEFT.SelectedValue != null)
                {
                    Status = AssignData(payMod: "NEFT", bankName: cmb_BankNameNEFT.Text, cardOrChequeNo: txt_ChequeNEFT.Text, narration: txt_NarrationNEFT.Text, cashAmount: (chkPartialNEFT.Checked == true) ? txt_PartialAmountNEFT.Text : lbl_amountNEFT.Text, otherTransactionAmount: (chkPartialNEFT.Checked == true) ? lbl_BalanceAmountNEFT.Text : null, transactionLedgerID: CmbDebitToNEFT.SelectedValue.ToString());
                }

            }

            return Status;
        }

        private void chk_PartialCard_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_PartialCard.Checked == false)
            {
                txt_PartialAmountCard.Text = "0";
                lbl_PartialAmountCard.Text = "0";
                txtnarrationCard.ResetText();
                txt_PartialAmountCard.Enabled = false;
            }
            else
            {
                txt_PartialAmountCard.Enabled = true;

            }

        }


        private void chk_PartialCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_PartialCheque.Checked == false)
            {
                txt_PartialAmountCheque.Text = "0";
                lbl_BalanceAmountCheque.Text = "0";
                txtnarrationcheque.ResetText();
                txt_PartialAmountCheque.Enabled = false;
            }
            else
            {
                txt_PartialAmountCheque.Enabled = true;
            }
        }

        private void chk_PartialRTGS_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_PartialRTGS.Checked == false)
            {
                txt_PartialAmountRTGS.Text = "0";
                lbl_BalanceAmountRTGS.Text = "0";
                txtnarration_rtgs.ResetText();
                txt_PartialAmountRTGS.Enabled = false;
            }
            else
            {
                txt_PartialAmountRTGS.Enabled = true;
            }
        }

        private void chkPartialNEFT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPartialNEFT.Checked == false)
            {
                txt_PartialAmountNEFT.Text = "0";
                lbl_BalanceAmountNEFT.Text = "0";
                txt_NarrationNEFT.ResetText();
                txt_PartialAmountNEFT.Enabled = false;
            }
            else
            {
                txt_PartialAmountNEFT.Enabled = true;
            }
        }

        private void EventOpenAccountLedgerForm(object sender, EventArgs e)
        {
            frmAccountLedger _accountLedgerForm = new frmAccountLedger();
            _accountLedgerForm.ShowDialog();
            fillDefaultdebitComboBox();
        }

        private void CmbDebitToCheque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtchequeno.Focus();
            }
        }

        private void txtnarration_rtgs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CmbDebitToRTGS.Focus();
            }
        }

        private void txt_NarrationNEFT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CmbDebitToNEFT.Focus();
            }
        }

        private void txt_PartialAmountCard_TextChanged(object sender, EventArgs e)
        {
            if (txt_PartialAmountCard.Text != "")
            {
                lbl_PartialAmountCard.Text = Math.Round(Convert.ToDouble(lblcardamt.Text) - Convert.ToDouble(txt_PartialAmountCard.Text)).ToString();
                txtnarrationCard.Text = "Cash-" + txt_PartialAmountCard.Text + "/- & CARD-" + lbl_PartialAmountCard.Text + "/- Paid";
            };
        }


        private void txt_PartialAmountCheque_TextChanged(object sender, EventArgs e)
        {
            if (txt_PartialAmountCheque.Text != "")
            {
                lbl_BalanceAmountCheque.Text = Math.Round(Convert.ToDouble(lblchequeamt.Text) - Convert.ToDouble(txt_PartialAmountCheque.Text)).ToString();
                txtnarrationcheque.Text = "Cash-" + txt_PartialAmountCheque.Text + "/- & CHEQUE-" + lbl_BalanceAmountCheque.Text + "/- Paid";

            };
        }

        private void txt_PartialAmountRTGS_TextChanged(object sender, EventArgs e)
        {
            if (txt_PartialAmountRTGS.Text != "")
            {
                lbl_BalanceAmountRTGS.Text = Math.Round(Convert.ToDouble(lblamount_rtgs.Text) - Convert.ToDouble(txt_PartialAmountRTGS.Text)).ToString();
                txtnarration_rtgs.Text = "Cash-" + txt_PartialAmountRTGS.Text + "/- & RTGS-" + lbl_BalanceAmountRTGS.Text + "/- Paid";

            };
        }

        private void txt_PartialAmountNEFT_TextChanged(object sender, EventArgs e)
        {
            if (txt_PartialAmountNEFT.Text != "")
            {
                lbl_BalanceAmountNEFT.Text = Math.Round(Convert.ToDouble(lbl_amountNEFT.Text) - Convert.ToDouble(txt_PartialAmountNEFT.Text)).ToString();
                txt_NarrationNEFT.Text = "Cash-" + txt_PartialAmountNEFT.Text + "/- & NEFT-" + lbl_BalanceAmountNEFT.Text + "/- Paid";

            };
        }

        private bool AssignData(string narration = "", string bankName = "", string cardOrChequeNo = "", string payMod = "", string cashAmount = "0", string otherTransactionAmount = "0", string transactionLedgerID = null)
        {
            Narration = narration;

            card_cheque_no = cardOrChequeNo.Trim();
            paymode = payMod;
            CashAmount = cashAmount;
            OtherTransactionAmount = Convert.ToDouble(otherTransactionAmount);
            TransactionLedgerID = transactionLedgerID;
            return true;
        }
    }
}
