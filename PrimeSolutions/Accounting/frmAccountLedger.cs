
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions;
using PrimeSolutions.Library;
using PrimeSolutions.Common;
using PrimeSolutions.Transaction;

namespace PrimeSolutions.Accounting
{
    public partial class frmAccountLedger : Form
    {
        Cls_BalanceSheet _objDebitCredit = new Cls_BalanceSheet();
        clsCommon _objCommon = new clsCommon();
        # region Public Variables
        /// <summary>
        ///  public variable declaration part
        /// </summary>
        string strGroup;
        string strBankAccount;
        string strGroupName;
        bool isSundryDebtorOrCreditor = false; // To indicate whether the selected accontgroup is under sundrydebtor or creditor
        bool isBankAccount = false; // To indicate whether the selected accontgroup is under BankAccount or BankODAccount
        decimal decLedgerId;
        decimal decLedger;
        decimal decAccountLedgerId;
        int inNarrationCount = 0;
        bool isGrid = false;
        bool isDefault;
        decimal decIdForOtherForms = 0;
        string strComboTypes = string.Empty;
        #endregion
        public frmAccountLedger()
        {
            InitializeComponent();
        }

        private void frmAccountLedger_Load(object sender, EventArgs e)
        {
            AccountGroupComboFill();
            AccountGroupComboFillSearch();

            FillGrid();

            Clear();
        }

        private void Clear()
        {
            try
            {

                txtAcNo.Clear();

                txtBranchName.Clear();
                txtBranchCode.Clear();

                txtLedgerName.Clear();
                txtLedgerNameSearch.Clear();

                txtNarration.Clear();

                //  cmbArea.SelectedIndex =0;

                cmbGroup.SelectedIndex = -1;

                txtOpeningBalance.Text = "0.00";

                cmbOpeningBalanceCrOrDr.Text = "Dr";
                btnSave.Text = "Save";
                txtLedgerName.ReadOnly = false;
                btnDelete.Enabled = false;
                tbctrlLedger.SelectedTab = tbMainDetails;
                isSundryDebtorOrCreditor = false;
                isBankAccount = false;
                cmbGroupSearch.SelectedIndex = 0;
                cmbGroup.Enabled = true;
                // GridFill();
                FillGrid();
                txtLedgerName.Select();
                gbxDetails.Visible = false;
                txtOpeningBalance.Enabled = true;
                cmbOpeningBalanceCrOrDr.Enabled = true;
                btnAccountGroupAdd.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL13:" + ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //private void GridFill()
        //{
        //    try
        //    {

        //        DataTable dtblAccountLedger = new DataTable();

        //        dtblAccountLedger = _objDebitCredit.getallAccountLedgerDetails();
        //        dgvAccountLedger.DataSource = dtblAccountLedger;


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("AL14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        public void FillGrid()
        {
            int i = 0;
            DataTable dtAccountLedger = _objCommon.getALLTableDetails(sTableName: TableNames.AccountLedger);
            DataTable dtAccountNature = _objCommon.getALLTableDetails(sTableName: TableNames.AccountNature);
            DataTable dtCreditdebit = _objCommon.getALLTableDetails(sTableName: TableNames.CreditDebitDetails);
            dtAccountLedger = dtAccountLedger.Rows.OfType<DataRow>().Where(dr => dr.Field<decimal>("accGroupId") != 22 && dr.Field<decimal>("accGroupId") != 26).CopyToDataTable();

            dtAccountLedger.Columns.Add("SrNo");
            dtAccountLedger.Columns.Add("BalanceAmount");
            dtAccountLedger.Columns.Add("under");
          

            foreach (DataRow dtr in dtAccountLedger.Rows)
            {
                decimal sumCredit = dtCreditdebit.Select().Where(a => a.Field<decimal>("LedgerId") == Convert.ToDecimal(dtr["LedgerId"])).Sum(a => a.Field<decimal>("credit"));
                decimal sumDebit = dtCreditdebit.Select().Where(a => a.Field<decimal>("LedgerId") == Convert.ToDecimal(dtr["LedgerId"])).Sum(a => a.Field<decimal>("debit"));
                string AccountNature = dtAccountNature.Select().Where(a => a.Field<decimal>("accountGroupId") == Convert.ToDecimal(dtr["accGroupId"])).FirstOrDefault()["Under"].ToString();
                dtAccountLedger.Rows[i]["SrNo"] = i + 1;
                dtAccountLedger.Rows[i]["under"] = AccountNature;
               
                dtAccountLedger.Rows[i]["BalanceAmount"]= Convert.ToDecimal(dtr["OpeningBal"]) + sumDebit - sumCredit;
                i++;
            }

            dgvAccountLedger.DataSource = dtAccountLedger;
            
            foreach(DataGridViewColumn dc in dgvAccountLedger.Columns)
            {
                if (dc.Name.ToString() != "SrNo" && dc.Name.ToString() != "Name" && dc.Name.ToString() != "ledgerId" && dc.Name.ToString() != "OpeningBal" && dc.Name.ToString() != "CreditOrDebit" && dc.Name.ToString() != "under" && dc.Name.ToString() != "BalanceAmount" && dc.Name != "Date")
                {
                    dc.Visible = false;
                }
            }

        }


        private void AccountGroupComboFillSearch()
        {
            try
            {

                DataTable dtblAcccountGroup = new DataTable();

                dtblAcccountGroup = _objCommon.getALLTableDetails(sTableName: TableNames.AccountNature);
                DataRow dr = dtblAcccountGroup.NewRow();
                dr[1] = "All";
                dtblAcccountGroup.Rows.InsertAt(dr, 0);
                cmbGroupSearch.DataSource = dtblAcccountGroup;

                cmbGroupSearch.ValueMember = "accountGroupId";
                cmbGroupSearch.DisplayMember = "Under";
                cmbGroupSearch.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL9:" + ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to save account ledger
        /// </summary>
        /// 
        public void AccountGroupComboFill()
        {
            try
            {

                DataTable ListObj = new DataTable();
                ListObj = _objCommon.getALLTableDetails(sTableName: TableNames.AccountNature);

                cmbGroup.DataSource = ListObj;
                cmbGroup.ValueMember = "accountGroupId";
                cmbGroup.DisplayMember = "Under";

            }
            catch (Exception ex)
            {
                MessageBox.Show("AL8:" + ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbGroup.SelectedValue != null)
                {
                    DataTable ListObj = new DataTable();
                    ListObj.Columns.Add("Bank");
                    ListObj.Rows.Add(1);
                    ListObj.Rows.Add(2);

                    isBankAccount = false;


                    for (int ini = 0; ini < ListObj.Rows.Count; ini++)
                    {
                        strBankAccount = ListObj.Rows[ini].ItemArray[0].ToString();
                        if (strBankAccount == cmbGroup.SelectedValue.ToString())
                        {
                            isBankAccount = true;
                        }
                    }
                    if (!isBankAccount)
                    {
                        gbxDetails.Visible = false;
                    }
                    else
                    {
                        gbxDetails.Visible = true;
                    }
                    if (cmbGroup.SelectedIndex > 0)
                    {
                        DataTable ListObjCrDr = new DataTable();
                        string strNature = _objCommon.getALLTableDetails(sTableName: TableNames.AccountNature, sColomnName: "accountGroupId", sColumnValue: cmbGroup.SelectedValue.ToString()).Rows[0]["Nature"].ToString();
                        if (strNature == "Assets" || strNature == "Expenses")
                        {
                            strNature = "Dr";
                        }
                        else
                        {
                            strNature = "Cr";
                        }
                        cmbOpeningBalanceCrOrDr.Text = strNature.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL48:" + ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvAccountLedger_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    decAccountLedgerId = Convert.ToDecimal(dgvAccountLedger.Rows[e.RowIndex].Cells["LedgerId"].Value.ToString());

                    Clear();
                    FillControls();
                    btnDelete.Enabled = true;
                    btnSave.Text = "Update";
                    txtLedgerName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL49:" + ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FillControls()
        {
            DataTable LedgerDetail = _objCommon.getALLTableDetails(sTableName: TableNames.AccountLedger, sColomnName: "LedgerId", sColumnValue: decAccountLedgerId.ToString());

            txtLedgerName.Text = LedgerDetail.Rows[0]["Name"].ToString();
            cmbGroup.SelectedValue = LedgerDetail.Rows[0]["accGroupId"].ToString();
            txtOpeningBalance.Text = LedgerDetail.Rows[0]["OpeningBal"].ToString();
            cmbOpeningBalanceCrOrDr.Text = LedgerDetail.Rows[0]["CreditOrDebit"].ToString();
            txtNarration.Text = LedgerDetail.Rows[0]["Narration"].ToString();
            txtAcNo.Text = LedgerDetail.Rows[0]["BankAccNo"].ToString();
            txtBranchName.Text = LedgerDetail.Rows[0]["NameOfBranch"].ToString();
            txtBranchCode.Text = LedgerDetail.Rows[0]["BranchCode"].ToString();
            dtp_Date.Text = LedgerDetail.Rows[0]["Date"].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                SaveOrEdit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AL46:" + ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SaveOrEdit()
        {
            try
            {

                if (txtLedgerName.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter ledger name");
                    txtLedgerName.Focus();
                    tbctrlLedger.SelectedTab = tbMainDetails;
                }
                else if (cmbGroup.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Select group name");
                    cmbGroup.Focus();
                    tbctrlLedger.SelectedTab = tbMainDetails;
                }
                else
                {
                    if (btnSave.Text == "Save")
                    {
                        if (Messages.SaveConfirmation())
                        {
                            SaveFunction();
                        }





                    }
                    else
                    {
                        if (Messages.UpdateConfirmation())
                        {

                            EditFunction();


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL3:" + ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EditFunction()
        {
            _objDebitCredit.updateLedger(ledgerid: decAccountLedgerId.ToString(), name: txtLedgerName.Text, account_groupId: cmbGroup.SelectedValue.ToString(), opning_bal: txtOpeningBalance.Text, transaction_type: cmbOpeningBalanceCrOrDr.Text, narration: txtNarration.Text, BankAccNo: txtAcNo.Text, NameOfBranch: txtBranchName.Text, BranchCode: txtBranchCode.Text, AccNo: null, Date: dtp_Date.Text, financialYearId: 1, VoucherTypeID: null);
            Clear();
        }

        private void SaveFunction()
        {
            _objDebitCredit.insertAccountLedger(name: txtLedgerName.Text, account_groupId: cmbGroup.SelectedValue.ToString(), opning_bal: txtOpeningBalance.Text, transaction_type: cmbOpeningBalanceCrOrDr.Text, narration: txtNarration.Text, BankAccNo: txtAcNo.Text, NameOfBranch: txtBranchName.Text, BranchCode: txtBranchCode.Text, AccNo: null, Date: dtp_Date.Text, financialYearId: 1, VoucherTypeID: null);
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _objDebitCredit.DeleteLedgerid(decAccountLedgerId.ToString());
            // GridFill(); // Fill the grid after delete
            FillGrid();
            Clear(); // Clear the text field after delete
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccountGroupAdd_Click(object sender, EventArgs e)
        {

        }

        private void txtLedgerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbGroup.Focus();
            }
        }

        private void cmbGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtOpeningBalance.Focus();
            }
        }

        private void txtOpeningBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbOpeningBalanceCrOrDr.Focus();
            }
        }

        private void cmbOpeningBalanceCrOrDr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNarration.Focus();
            }
        }

        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void txtLedgerNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbGroupSearch.Focus();
            }
        }

        private void cmbGroupSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.Focus();
            }
        }

        private void dgvAccountLedger_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_Credit_DebitEntry Entry = new Frm_Credit_DebitEntry();
            Entry.Show();
        }
    }
}
