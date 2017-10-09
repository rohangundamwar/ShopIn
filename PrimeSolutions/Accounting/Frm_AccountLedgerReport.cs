
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Common;
using PrimeSolutions.Library;

namespace PrimeSolutions.Accounting
{
    public partial class Frm_AccountLedgerReport : Form
    {
        clsCommon _objCommon = new clsCommon();
        SaleCommon _objsale = new SaleCommon();
        ExportToExcel _objExportToExcel = new ExportToExcel();

        public Frm_AccountLedgerReport()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            FillGrid();
        }
        public void FillGrid()
        {
            try
            {
                string GroupID = "";
                string LedgerID = "";
                if (cmb_AccountGroup.Text == "All" && cmb_AccountLedger.Text == "")
                {
                    GroupID = cmb_AccountGroup.Text;
                    LedgerID = "All";
                }
                else if (cmb_AccountGroup.Text != "All" && cmb_AccountLedger.Text == "")
                {
                    GroupID = cmb_AccountGroup.SelectedValue.ToString();
                    LedgerID = "All";
                }
                else if(cmb_AccountGroup.Text!="All" && cmb_AccountLedger.Text!="")
                {
                    GroupID = cmb_AccountGroup.SelectedValue.ToString();
                    LedgerID = cmb_AccountLedger.Text;
                }
                else
                {
                    GroupID = cmb_AccountGroup.Text;
                    LedgerID = cmb_AccountLedger.Text;
                }

                dgv_AccountLedgerReport.Rows.Clear();
                int j = 1;

                DataTable dt = _objsale.selectAccountLedgerDetail(dtp_FromDate.Text, dtp_ToDate.Text, GroupID, LedgerID);

             
                if (dt.Rows.Count > 0)
                {

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgv_AccountLedgerReport.Rows.Add();
                        dgv_AccountLedgerReport.Rows[i].Cells["SrNo"].Value = j;
                        j++;
                        dgv_AccountLedgerReport.Rows[i].Cells["Date"].Value = dt.Rows[i]["Date"].ToString();
                        dgv_AccountLedgerReport.Rows[i].Cells["AccountLedger"].Value = dt.Rows[i]["Name"].ToString();

                        dgv_AccountLedgerReport.Rows[i].Cells["OpeningBalance"].Value = dt.Rows[i]["OpeningBal"].ToString();
     
                        DataTable dt_CreditDebitDetail = _objCommon.getALLTableDetails(sTableName: TableNames.CreditDebitDetails,sColomnName:"ledgerId",sColumnValue: dt.Rows[i]["ledgerId"].ToString());
                      var sumCredit= dt_CreditDebitDetail.Rows.OfType<DataRow>().Sum(dr => dr.Field<decimal>("credit"));
                        var SumDebit = dt_CreditDebitDetail.Rows.OfType<DataRow>().Sum(dr => dr.Field<decimal>("debit"));
                        dgv_AccountLedgerReport.Rows[i].Cells["Credit"].Value = sumCredit;
                        dgv_AccountLedgerReport.Rows[i].Cells["Debit"].Value = SumDebit;
                         var sumClosingAmount=  Convert.ToDecimal(dgv_AccountLedgerReport.Rows[i].Cells["OpeningBalance"].Value) + SumDebit - sumCredit;
                        if (sumClosingAmount >= 0)
                        {
                            dgv_AccountLedgerReport.Rows[i].Cells["ClosingBalance"].Value = sumClosingAmount +"  "+"Dr";
                        }
                        else
                        {
                            dgv_AccountLedgerReport.Rows[i].Cells["ClosingBalance"].Value = sumClosingAmount +"  "+"Cr";
                        }
                        



                    }
                    
                }
            }
            catch
            {

            }
        }

        private void Frm_AccountLedgerReport_Load(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            //cmb_AccountGroupId
            dgv_AccountLedgerReport.Rows.Clear();
            DataTable dtblAccountGroup = new DataTable();

            dtblAccountGroup = _objCommon.getALLTableDetails(sTableName: TableNames.AccountNature);
            DataRow dr = dtblAccountGroup.NewRow();
            dr[1] = "All";
            dtblAccountGroup.Rows.InsertAt(dr, 0);
            cmb_AccountGroup.DataSource = dtblAccountGroup;

            cmb_AccountGroup.ValueMember = "accountGroupId";
            cmb_AccountGroup.DisplayMember = "Under";
            cmb_AccountGroup.SelectedIndex = 0;

            //cmb_AccountLedger

            dtp_ToDate.Text = DateTime.Now.ToString();
            dtp_FromDate.Text = DateTime.Now.ToString();
            cmb_AccountLedger.DataSource = _objCommon.getALLTableDetails(sTableName: TableNames.AccountLedger);
           cmb_AccountLedger.SelectedIndex = -1;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgv_AccountLedgerReport.Rows.Count > 0)
            {
                _objExportToExcel.exporttoexcel(dgv_AccountLedgerReport, "Account Ledger",dtp_FromDate.Value.ToString("dd_MM_yyyy"));
            }
            else
            {
                MessageBox.Show("No Data Present");
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {

        }
    }
}
