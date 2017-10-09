using PrimeSolutions.Common;
using PrimeSolutions.Library;
using PrimeSolutions.PaymentOption;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions.Accounting
{
    public partial class frmReceiptVoucher : Form
    {
        SettingValue datasv;
        ErrorLog _error = new ErrorLog();
        string FormName;
        public int[] PaymentIDs = new int[2];
        public frmReceiptVoucher()
        {
            datasv = new SettingValue();
            datasv = _objCommon.getSettingValue();
            InitializeComponent();
        }

        clsCommon _objCommon = new clsCommon();
        Simplevalidations _objSimplevalidations = new Simplevalidations();
        Cls_BalanceSheet _objCreditDebit = new Cls_BalanceSheet();
        SaleCommon _ObjSalesCommon = new SaleCommon();
        Validation _objValidation = new Validation();
        private void frmReceiptVoucher_Load(object sender, EventArgs e)
        {
            try
            {
                MasterClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PV40:" + ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool check()
        {
            if (_objValidation.IsNotEmpty(txtReceiptNo.Text))
            {
                if (CmbAccountLedger.SelectedValue != null)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Please Select Account Ledger First...!");
                    CmbAccountLedger.Select();
                    return false;
                }
            }
            else { MessageBox.Show("Receipt No Can`t Be Blank...!"); return false; }
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (check())
            {
                try
                {
                    string VouchertypeID = _objCommon.getALLTableDetails(sTableName: TableNames.VoucherType, sColomnName: "VoucherTypeName", sColumnValue: "Receipt Voucher").Rows[0]["VoucherTypeID"].ToString();

                    string TransactionLedgerID = null;
                    bool Payformstatus = true;
                    if (Convert.ToDouble(txtAmount.Text) > 0)
                    {
                        DialogResult dr = MessageBox.Show("Amount to be Payed :" + txtAmount.Text + "\n\n Do You Want To Continue", "JMS Says ", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            if (datasv.PaymentForm == "1")
                            {
                                frm_PaymentOptionForReceiptVoucher form = new frm_PaymentOptionForReceiptVoucher
                                    (
                                   Amountpaid: txtAmount.Text,
                                   billno: txtReceiptNo.Text,
                                   Accountno: "",
                                   Date: txtDate.Text,
                                   CustomerType: CustomerType.ReceiptVoucher,
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
                            else if (datasv.PaymentForm == "0")
                            {
                                Payformstatus = true;
                            }
                        }
                        else if (dr == DialogResult.No)
                        {
                            Payformstatus = false;
                        }
                    }

                    int ReceiptMasterID = _objCreditDebit.addReceiptVoucher
                   (
                    ReceiptNo: txtReceiptNo.Text,
                    Date: txtDate.Text,
                    CashOrBankID: TransactionLedgerID.ToString(),
                    AccountLedgerID: CmbAccountLedger.SelectedValue.ToString(),
                    Amount: txtAmount.Text,
                    Narration: txtNarration.Text
                   );


                    if (txtAmount.Text != "" && txtAmount.Text != "0")
                    {
                        _objCommon.updatePaymentDetailByPaymentID(ColumnName: "VoucherTypeId", columnValue: VouchertypeID, paymentid: PaymentIDs[0]);
                        _objCommon.updatePaymentDetailByPaymentID(ColumnName: "VoucherId", columnValue: ReceiptMasterID.ToString(), paymentid: PaymentIDs[0]);

                        if (PaymentIDs[1] != 0)
                        {
                            _objCommon.updatePaymentDetailByPaymentID(ColumnName: "VoucherTypeId", columnValue: VouchertypeID, paymentid: PaymentIDs[1]);
                            _objCommon.updatePaymentDetailByPaymentID(ColumnName: "VoucherId", columnValue: ReceiptMasterID.ToString(), paymentid: PaymentIDs[1]);
                        }

                        //acount ledger creditdebit  With payment by cash /bank
                        _ObjSalesCommon.insertcreditDebitWithPayment(customerLedgerID: CmbAccountLedger.SelectedValue.ToString(), VouchertypeID: VouchertypeID, sbillno: ReceiptMasterID.ToString(), transactionLedgerID: TransactionLedgerID, AmountPaid: txtAmount.Text, Narration: "", Date: txtDate.Text, name: CmbAccountLedger.Text.Trim());

                    }

                    MessageBox.Show("Data Inserted...!");
                    MasterClear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    _error.AddException(ex, FormName);

                }
            }
            else
            {

            }

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            MasterClear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string sReceiptNo = txtReceiptID.Text.Trim();
            DialogResult dr = MessageBox.Show("Are you sure want to delete Bill No : " + txtReceiptNo.Text, "Delete Bill", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {

                _objCommon.UpdatePermanentDeleteTrue(sColumnValue: sReceiptNo, sColomnName: "ReceiptMasterID", sTableName: TableNames.ReceiptMaster);
                
                string VouchertypeID = _objCommon.getALLTableDetails(sTableName: TableNames.VoucherType, sColomnName: "VoucherTypeName", sColumnValue: "Receipt Voucher").Rows[0]["VoucherTypeID"].ToString();
                _objCommon.UpdatePaymentDetailsToPermanentDelete(VouchertypeID, sReceiptNo);
                _objCreditDebit.deleteDebitCreditbybillno(sReceiptNo, VouchertypeID);
                MessageBox.Show("Bill Deleted");
                MasterClear();
            }
            else
            {
                MessageBox.Show("Bill Delete cancelled");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AccountLedgerComboFill()
        {
            try
            {
                DataTable dt_AccountLedger = _objCommon.getALLTableDetails
                 (
                 sTableName: TableNames.AccountLedger
                 );

                CmbAccountLedger.DataSource = dt_AccountLedger;
                CmbAccountLedger.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        public void MasterClear()
        {
            Clear();
            fillDataGridView(_objCreditDebit.getAllReceiptMasterData());
            FillComboBox();
        }

        public void Clear()
        {
            txtReceiptNo.ResetText();
            CmbAccountLedger.SelectedIndex = -1;
            txtAmount.Text = "0";
            txtNarration.ResetText();
            txtDate.ResetText();
            CmbAccountLedger.Select();
            btn_Save.Enabled = true;
            btnUpdate.Enabled = false;
            btn_Delete.Enabled = false;
        }

        public void fillDataGridView(DataTable dt)
        {
            dgv_ReceiptVoucher.Rows.Clear();
            int i = 0;
            foreach (DataRow dtr in dt.Rows)
            {
                dgv_ReceiptVoucher.Rows.Add();
                dgv_ReceiptVoucher.Rows[i].Cells["ReceiptMasterID"].Value = dtr["ReceiptMasterID"];
                dgv_ReceiptVoucher.Rows[i].Cells["ReceiptNo"].Value = dtr["ReceiptNo"];
                dgv_ReceiptVoucher.Rows[i].Cells["Date"].Value = dtr["Date"];
                dgv_ReceiptVoucher.Rows[i].Cells["CashOrBankID"].Value = dtr["CashOrBankID"];
                dgv_ReceiptVoucher.Rows[i].Cells["CashOrBankName"].Value = dtr["CashOrBankName"];
                dgv_ReceiptVoucher.Rows[i].Cells["AccountLedgerID"].Value = dtr["AccountLedgerID"];
                dgv_ReceiptVoucher.Rows[i].Cells["AccountLedgerName"].Value = dtr["AccountLedgerName"];
                dgv_ReceiptVoucher.Rows[i].Cells["Amount"].Value = dtr["Amount"];
                dgv_ReceiptVoucher.Rows[i].Cells["Narration"].Value = dtr["Narration"];

                i++;
            }
        }


        public void FillComboBox()
        {
            AccountLedgerComboFill();
            GetReceiptNo();
            SearchByAccLedger();
            SearchByAccGroup();
        }

        public void SearchByAccLedger()
        {
            var dt_SearchByAccLedger = _objCommon.DataGridView2DataTable(dgv_ReceiptVoucher, "DataTable_SearchByAccLedger").AsEnumerable().Select(a => a.Field<string>("AccountLedgerName")).AsParallel().Distinct().ToList();
            if (dt_SearchByAccLedger.Count > 0)
            {
                dt_SearchByAccLedger.Add("All");
                cmbSearchByAccLedger.DataSource = dt_SearchByAccLedger;
                cmbSearchByAccLedger.SelectedIndex = -1;
            }
        }

        public void SearchByAccGroup()
        {
            var dt_SearchByAccGroup = _objCommon.DataGridView2DataTable(dgv_ReceiptVoucher, "DataTable_SearchByAccGroup").AsEnumerable().Select(a => a.Field<string>("CashOrBankName")).AsParallel().Distinct().ToList();
            if (dt_SearchByAccGroup.Count > 0)
            {
                dt_SearchByAccGroup.Add("All");
                cmbSearchByAccGroup.DataSource = dt_SearchByAccGroup;
                cmbSearchByAccGroup.SelectedIndex = -1;
            }
        }

        public void GetReceiptNo()
        {
            txtReceiptNo.Text = _objCreditDebit.getReceiptNoFromReceiptMaster();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txtAmount.Text);
        }

        private void cmbCashOrBank_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CmbAccountLedger.Focus();
            }
        }

        private void CmbAccountLedger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAmount.Focus();
            }
        }



        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Save.Focus();
            }
        }

        private void btnLedgerAdd_Click(object sender, EventArgs e)
        {
            frmAccountLedger _objAccountLedger = new frmAccountLedger();
            _objAccountLedger.FormClosed += new FormClosedEventHandler(_objUpdate_FormClosed);
            _objAccountLedger.ShowDialog();
        }

        void _objUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                AccountLedgerComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtReceiptNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CmbAccountLedger.Focus();
            }
        }


        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAmount.Text == "" || txtAmount.Text == "0")
                {
                    return;
                }
                else
                {
                    txtDate.Focus();
                }
            }
        }

        private void dgv_ReceiptVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex >= -1)
                {
                    btn_Delete.Enabled = true;
                    btnUpdate.Enabled = true;
                    btn_Save.Enabled = false;

                    txtReceiptID.Text = dgv_ReceiptVoucher.Rows[dgv_ReceiptVoucher.CurrentRow.Index].Cells["ReceiptMasterID"].Value.ToString();
                    txtDate.Text = dgv_ReceiptVoucher.Rows[dgv_ReceiptVoucher.CurrentRow.Index].Cells["Date"].Value.ToString();
                    txtReceiptNo.Text = dgv_ReceiptVoucher.Rows[dgv_ReceiptVoucher.CurrentRow.Index].Cells["ReceiptNo"].Value.ToString();
                    CmbAccountLedger.SelectedValue = dgv_ReceiptVoucher.Rows[dgv_ReceiptVoucher.CurrentRow.Index].Cells["AccountLedgerID"].Value;
                    txtAmount.Text = dgv_ReceiptVoucher.Rows[dgv_ReceiptVoucher.CurrentRow.Index].Cells["Amount"].Value.ToString();
                    txtNarration.Text = dgv_ReceiptVoucher.Rows[dgv_ReceiptVoucher.CurrentRow.Index].Cells["Narration"].Value.ToString();

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                _error.AddException(ex, FormName);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string VouchertypeID = _objCommon.getALLTableDetails(sTableName: TableNames.VoucherType, sColomnName: "VoucherTypeName", sColumnValue: "Receipt Voucher").Rows[0]["VoucherTypeID"].ToString();

                string TransactionLedgerID = null;
                bool Payformstatus = true;
                if (Convert.ToDouble(txtAmount.Text) > 0)
                {
                    DialogResult dr = MessageBox.Show("Amount to be Payed :" + txtAmount.Text + "\n\n Do You Want To Continue", "JMS Says ", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        if (datasv.PaymentForm == "1")
                        {
                            frm_PaymentOptionForReceiptVoucher form = new frm_PaymentOptionForReceiptVoucher
                                (
                               Amountpaid: txtAmount.Text,
                               VoucherId: txtReceiptID.Text,
                               billno: txtReceiptNo.Text,
                               VoucherTypeId: VouchertypeID,
                               Accountno: "",
                               Date: txtDate.Text,

                               CustomerType: CustomerType.ReceiptVoucher,
                               OperationType: OperationType.Edit
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
                        else if (datasv.PaymentForm == "0")
                        {
                            Payformstatus = true;
                        }
                    }
                    else if (dr == DialogResult.No)
                    {
                        Payformstatus = false;
                    }
                }

                int ReceiptMasterID = _objCreditDebit.updateReceiptVoucher
               (
                    ReceiptID: txtReceiptID.Text,
                ReceiptNo: txtReceiptNo.Text,
                Date: txtDate.Text,
                CashOrBankID: TransactionLedgerID.ToString(),
                AccountLedgerID: CmbAccountLedger.SelectedValue.ToString(),
                Amount: txtAmount.Text,
                Narration: txtNarration.Text
               );


                if (txtAmount.Text != "" && txtAmount.Text != "0")
                {
                    //acount ledger creditdebit  With payment by cash /bank
                    _objCreditDebit.deleteDebitCreditbybillno(txtReceiptID.Text, VouchertypeID);
                    _ObjSalesCommon.insertcreditDebitWithPayment(customerLedgerID: CmbAccountLedger.SelectedValue.ToString(), VouchertypeID: VouchertypeID, sbillno: ReceiptMasterID.ToString(), transactionLedgerID: TransactionLedgerID, AmountPaid: txtAmount.Text, Narration: "", Date: txtDate.Text, name: CmbAccountLedger.Text.Trim());
                }

                MessageBox.Show("Data Updated...!");
                MasterClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _error.AddException(ex, FormName);

            }
        }

        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNarration.Focus();
            }
        }

        private void cmbSearchByAccGroup_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbSearchByAccGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt_getAllReceiptMasterData = new DataTable();
            if (cmbSearchByAccGroup.Text.Trim() == "All")
            {
                dt_getAllReceiptMasterData = _objCreditDebit.getAllReceiptMasterData();
            }
            else
            {
                if (cmbSearchByAccGroup.Text != "")
                {
                    dt_getAllReceiptMasterData = _objCreditDebit.getAllReceiptMasterData().Select().Where(j => j.Field<string>("CashOrBankName").Contains(cmbSearchByAccGroup.Text.Trim())).CopyToDataTable();
                }
            }
            if (dt_getAllReceiptMasterData.Rows.Count > 0)
            {
                fillDataGridView(dt_getAllReceiptMasterData);
            }
        }

        private void cmbSearchByAccLedger_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt_getAllReceiptMasterData = new DataTable();
            if (cmbSearchByAccLedger.Text.Trim() == "All")
            {
                dt_getAllReceiptMasterData = _objCreditDebit.getAllReceiptMasterData();
            }
            else
            {
                if (cmbSearchByAccLedger.Text != "")
                {
                    dt_getAllReceiptMasterData = _objCreditDebit.getAllReceiptMasterData().Select().Where(j => j.Field<string>("AccountLedgerName").Contains(cmbSearchByAccLedger.Text.Trim())).CopyToDataTable();

                }
            }
            if (dt_getAllReceiptMasterData.Rows.Count > 0)
            {
                fillDataGridView(dt_getAllReceiptMasterData);
            }
        }
    }
}