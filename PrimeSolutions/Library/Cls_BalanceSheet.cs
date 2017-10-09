using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions.Library
{
    class Cls_BalanceSheet
    {
        FinancialStatementSP spFinancialStatement = new FinancialStatementSP();
        SQLHelper _objdb = new SQLHelper();

        public bool IsDefault { get; private set; }

        public DataTable getgroups()
        {
            string str = "SELECT  Under, srno FROM   AccountNature";
            DataTable dt = _objdb.GetDataTable(str);
            return dt;
        }

        public DataTable getAllAccountNature()
        {
            string str = "SELECT srno, Under, Nature, Visibility, EffectTo, opening_balance FROM AccountNature";
            DataTable dt = _objdb.GetDataTable(str);
            return dt;
        }

        public DataTable getallAccountLedgerDetailsByLedgerId(string LedgerId)
        {
            string str = "SELECT AccountLedger.ledgerId AS Id, AccountNature.Under AS [Account Group], AccountLedger.name AS Name, AccountLedger.openingBal AS [Opening Balance], AccountLedger.CreditOrDebit AS [Credit/Debit],  AccountLedger.narration AS Narration,  AccountLedger.accno AS [Acc No] FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId Where AccountLedger.ledgerId=N'" + LedgerId + "'";
            return _objdb.GetDataTable(str);
        }

        public int addReceiptVoucher(string ReceiptNo, string Date, string CashOrBankID, string AccountLedgerID, string Amount, string Narration)
        {
            string str = "Insert into ReceiptMaster (ReceiptNo, Date, CashOrBankID, AccountLedgerID, Amount, Narration) OUTPUT INSERTED.ReceiptMasterID Values ('" + ReceiptNo + "','" + Date + "','" + CashOrBankID + "','" + AccountLedgerID + "','" + Amount + "','" + Narration + "')";
            return Convert.ToInt32(_objdb.ExecuteScalar(str));
        }

        public int addPaymentVoucher(string PaymentNo, string Date, string CashOrBankID, string AccountLedgerID, string Amount, string Narration)
        {
            string str = "Insert into PaymentMaster (PaymentNo, Date, CashOrBankID, AccountLedgerID, Amount, Narration) OUTPUT INSERTED.PaymentMasterID Values ('" + PaymentNo + "','" + Date + "','" + CashOrBankID + "','" + AccountLedgerID + "','" + Amount + "','" + Narration + "')";
            return Convert.ToInt32(_objdb.ExecuteScalar(str));
        }

        public int updateReceiptVoucher(string ReceiptID, string ReceiptNo, string Date, string CashOrBankID, string AccountLedgerID, string Amount, string Narration)
        {
            string str = "Update ReceiptMaster SET  Date= '" + Date + "', CashOrBankID= '" + CashOrBankID + "', AccountLedgerID = '" + AccountLedgerID + "', Amount= '" + Amount + "', Narration= '" + Narration + "' OUTPUT INSERTED.ReceiptMasterID Where (ReceiptMasterID= '" + ReceiptID + "') AND (PermanentDelete = 0)";
            return Convert.ToInt32(_objdb.ExecuteScalar(str));
        }

        public DataSet ProfitAndLossAnalysis(DateTime dtFromdate, DateTime dtTodate)
        {
            DataSet dset = new DataSet();
            try
            {
                dset = spFinancialStatement.ProfitAndLossAnalysis(dtFromdate, dtTodate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FS2:" + ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dset;
        }

        public int updatePaymentVoucher(string PaymentID, string PaymentNo, string Date, string CashOrBankID, string AccountLedgerID, string Amount, string Narration)
        {
            string str = "Update PaymentMaster SET  Date= '" + Date + "', CashOrBankID= '" + CashOrBankID + "', AccountLedgerID = '" + AccountLedgerID + "', Amount= '" + Amount + "', Narration= '" + Narration + "' OUTPUT INSERTED.PaymentMasterID Where (PaymentMasterID= '" + PaymentID + "') AND (PermanentDelete = 0)";
            return Convert.ToInt32(_objdb.ExecuteScalar(str));
        }




        public string getnaturefromunder(string underid)
        {
            string str = "SELECT  Nature FROM  AccountNature WHERE  (id = '" + Convert.ToInt32(underid) + "')";
            string nature = _objdb.ExecuteScalar(str);
            return nature;
        }
        public string getMasterFromMasterid(string masterID)
        {
            string str = " SELECT Narration FROM  CreditDebitMaster where CreditDebitmasterid=" + masterID + "";
            return _objdb.ExecuteScalar(str);
        }

        public DataTable getTotalCreditDebit(string id)
        {
            string str = "SELECT   CreditDebitDetails.date,     AccountLedger.name, CreditDebitDetails.credit, CreditDebitDetails.debit, CreditDebitDetails.ledgerId FROM            AccountLedger INNER JOIN CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE        (CreditDebitDetails.ledgerId =" + id + ")";
            return _objdb.GetDataTable(str);
        }

        public DataTable getallCustomerSaleInfo(string start, string end)
        {
            string str = "SELECT     SalesBPayMaster.Date,SalesBPayMaster.BillNo, SalesBPayMaster.AmountGiven, SalesBMaster.FullName, BillItemMaster.MetalID, BillItemMaster.itemId, BillItemMaster.FineWT, BillItemMaster.CustomerType FROM SalesBPayMaster INNER JOIN  BillItemMaster ON SalesBPayMaster.BillNo = BillItemMaster.BillNO INNER JOIN  SalesBMaster ON SalesBPayMaster.AccNo = SalesBMaster.AccNo Where (CONVERT(DateTime, SalesBPayMaster.date, 103) >= CONVERT(DateTime,  '" + start + "', 103)) AND (CONVERT(DateTime, SalesBPayMaster.date, 103) <=  CONVERT(DateTime, '" + end + "' , 103) AND SalesBPayMaster.PermanentDelete = 'false' AND (SalesBPayMaster.PermanentDelete='" + false + "') AND SalesBPayMaster.comment ='Bill')";
            return _objdb.GetDataTable(str);
        }

        public DataSet TrialBalance(string fromDate, string toDate, decimal decAccountGroupId)
        {
            DataSet dset = new DataSet();
            try
            {
                dset = spFinancialStatement.TrialBalance(fromDate, toDate, decAccountGroupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FS12:" + ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dset;
        }
        public DataSet ProfitAndLossAnalysisUpToaDateForBalansheet(string fromDate, string toDate)
        {
            DataSet dset = new DataSet();
            try
            {
                dset = spFinancialStatement.ProfitAndLossAnalysisUpToaDateForBalansheet(fromDate, toDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FS4:" + ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dset;
        }

        public DataSet BalanceSheet(DateTime fromDate, DateTime toDate)
        {
            DataSet dset = new DataSet();
            try
            {
                dset = spFinancialStatement.BalanceSheet(fromDate, toDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FS2:" + ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dset;
        }

        public DataSet ProfitAndLossAnalysisUpToaDateForPreviousYears(string toDate)
        {
            DataSet dset = new DataSet();
            try
            {
                dset = spFinancialStatement.ProfitAndLossAnalysisUpToaDateForPreviousYears(toDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FS5:" + ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dset;

        }
        public DataTable gettotalDEBIT(string ID)
        {
            string STR = "SELECT        Date,Name, Expense_Amount,Status, Comment, under, nature, narration, nameofbank, chequeno, accno, id,   Nameid FROM            Daily_Expenses_Master WHERE        (Nameid = " + ID + ")";
            return _objdb.GetDataTable(STR);
        }
        public DataTable gettotalCREDITbydate(string startdate, string enddate)
        {
            string str = "SELECT        Date, Name, Amount, under, nature, narration, nameofbank, chequeno, accno, id, Status, Nameid FROM OtherAmountAdd WHERE ((CONVERT(DateTime, Date, 103) >= CONVERT(DateTime,  '" + startdate + "', 103)) AND (CONVERT(DateTime, Date, 103) <=  CONVERT(DateTime, '" + enddate + "' , 103)))";
            return _objdb.GetDataTable(str);
        }

        public DataTable gettotalDEBITbydate(string startdate, string enddate)
        {
            string STR = "SELECT        Date,Name, Expense_Amount, Comment, under, nature, narration, nameofbank, chequeno, accno, id, Status, Nameid FROM            Daily_Expenses_Master WHERE       ((CONVERT(DateTime, Date, 103) >= CONVERT(DateTime,  '" + startdate + "', 103)) AND (CONVERT(DateTime, Date, 103) <=  CONVERT(DateTime, '" + enddate + "' , 103)))";
            return _objdb.GetDataTable(STR);
        }
        public DataTable getgroupandnature(string id)
        {
            string str = "SELECT        count(*) FROM     OtherAmountAdd WHERE        (Status = 'OpeningBalance' and Nameid = " + id + ")";
            int i = Convert.ToInt32(_objdb.ExecuteScalar(str));
            if (i > 0)
            {
                string str1 = "SELECT        Date, Name, Amount, under, nature, narration, nameofbank, chequeno, accno, id, Status, Nameid FROM OtherAmountAdd WHERE (Nameid = " + id + " and Status='OpeningBalance')";
                return _objdb.GetDataTable(str1);
            }
            else
            {
                string STR2 = "SELECT        Date, Expense_Amount, Comment, under, nature, narration, nameofbank, chequeno, accno, id, Name, Status, Nameid FROM            Daily_Expenses_Master WHERE        (Nameid = " + id + " and Status='OpeningBalance')";
                return _objdb.GetDataTable(STR2);
            }
        }

        public void deletecredit(string id)
        {
            string str = "DELETE FROM OtherAmountAdd WHERE        (id = " + id + ")";
            _objdb.ExecuteSql(str);
        }

        public void deletedebit(string id)
        {
            string str = "DELETE FROM Daily_Expenses_Master WHERE        (id = " + id + ")";
            _objdb.ExecuteSql(str);
        }

        public DataTable getAccountGroupDetailsFromAccountName(string account_group_name)
        {
            string str = "SELECT srno, Under, Nature, Visibility, EffectTo, opening_balance FROM AccountNature WHERE (Under = N'" + account_group_name + "')";
            return _objdb.GetDataTable(str);
        }

        public DataTable getAllReceiptMasterData()
        {
            string str = "SELECT RM.ReceiptMasterID, RM.ReceiptNo, RM.Date, RM.CashOrBankID, AN.Under AS CashOrBankName, RM.AccountLedgerID, AL.Name AS AccountLedgerName, RM.Amount, RM.Narration FROM dbo.AccountNature AS AN INNER JOIN dbo.ReceiptMaster AS RM ON AN.accountGroupId = RM.CashOrBankID INNER JOIN dbo.AccountLedger AS AL ON RM.AccountLedgerID = AL.ledgerId WHERE (RM.PermanentDelete = 0)";
            return _objdb.GetDataTable(str);
        }

        public DataTable getAllPaymentMasterData()
        {
            string str = "SELECT PM.PaymentMasterID, PM.PaymentNo, PM.Date, PM.CashOrBankID, AN.Under AS CashOrBankName, PM.AccountLedgerID, AL.Name AS AccountLedgerName, PM.Amount, PM.Narration FROM dbo.AccountNature AS AN INNER JOIN dbo.PaymentMaster AS PM ON AN.accountGroupId = PM.CashOrBankID INNER JOIN dbo.AccountLedger AS AL ON PM.AccountLedgerID = AL.ledgerId WHERE (PM.PermanentDelete = 0)";
            return _objdb.GetDataTable(str);
        }

        public string insertAccountLedger(string name, string account_groupId, string opning_bal, string transaction_type, string narration, string BankAccNo, string NameOfBranch, string BranchCode, string AccNo, string Date, int financialYearId, string VoucherTypeID)
        {
            string str = "INSERT INTO AccountLedger (accGroupId, name, openingBal, CreditOrDebit,narration,BankAccNo,NameOfBranch,BranchCode,accno,Date,financialYearId,VoucherTypeID) OUTPUT Inserted.ledgerid VALUES (" + account_groupId + ", N'" + name + "', " + opning_bal + ", N'" + transaction_type + "',N'" + narration + "',N'" + BankAccNo + "',N'" + NameOfBranch + "','" + BranchCode + "','" + AccNo + "','" + Date + "'," + financialYearId + ",'" + VoucherTypeID + "')";
            string id = _objdb.ExecuteScalar(str);
            return id.ToString();
        }



        public DataTable getallAccountLedgerDetailsDebit()
        {
            string str = "SELECT  AccountNature.Under, AccountLedger.name, CreditDebitDetails.credit, CreditDebitDetails.CreditDebitmasterid,CreditDebitDetails.chequeno, CreditDebitDetails.chequedate,CreditDebitDetails.debit,CreditDebitDetails.FromAccount,CreditDebitDetails.narration, CreditDebitDetails.date FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN   CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountNature.Under = N'Cash-In-Hand') And (CreditDebitDetails.Type='Dr') ";
            return _objdb.GetDataTable(str);
        }
        public DataTable getallAccountLedgerDetailsCredit()
        {
            string str = "SELECT  AccountNature.Under, AccountLedger.name, CreditDebitDetails.credit,CreditDebitDetails.CreditDebitmasterid,CreditDebitDetails.chequeno, CreditDebitDetails.chequedate,CreditDebitDetails.debit,CreditDebitDetails.FromAccount,CreditDebitDetails.narration, CreditDebitDetails.date FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN   CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountNature.Under = N'Cash-In-Hand') And (CreditDebitDetails.Type='Cr') ";
            return _objdb.GetDataTable(str);
        }


        public DataTable getallAccountLedgerDetailsDebit(string StartDate, string EndDate)
        {
            string str = "SELECT  AccountNature.Under, AccountLedger.name, CreditDebitDetails.credit, CreditDebitDetails.CreditDebitmasterid,CreditDebitDetails.chequeno, CreditDebitDetails.chequedate,CreditDebitDetails.debit,CreditDebitDetails.FromAccount, CreditDebitDetails.date FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN   CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountNature.Under = N'Cash-In-Hand') And (CreditDebitDetails.Type='Dr') AND (CONVERT(DateTime, CreditDebitDetails.date, 103) >= CONVERT(DateTime,  '" + StartDate + "', 103)) AND (CONVERT(DateTime, CreditDebitDetails.date, 103) <=  CONVERT(DateTime, '" + EndDate + "' , 103))";
            return _objdb.GetDataTable(str);
        }
        public DataTable getallAccountLedgerDetailsCredit(string StartDate, string EndDate)
        {
            string str = "SELECT  AccountNature.Under, AccountLedger.name, CreditDebitDetails.credit,CreditDebitDetails.CreditDebitmasterid,CreditDebitDetails.chequeno, CreditDebitDetails.chequedate,CreditDebitDetails.debit,CreditDebitDetails.FromAccount, CreditDebitDetails.date FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN   CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountNature.Under = N'Cash-In-Hand') And (CreditDebitDetails.Type='Cr') AND (CONVERT(DateTime, CreditDebitDetails.date, 103) >= CONVERT(DateTime,  '" + StartDate + "', 103)) AND (CONVERT(DateTime, CreditDebitDetails.date, 103) <=  CONVERT(DateTime, '" + EndDate + "' , 103))";
            return _objdb.GetDataTable(str);
        }

        //New added sale
        public DataTable getCustomerItemDetails(string Startdate, string enddate)
        {
            string querry = "SELECT     BillItemMaster.*,SalesBBillMaster.vat,SalesBBillMaster.Date,SalesBBillMaster.CBillNo, SalesBBillMaster.NewBillNo FROM BillItemMaster INNER JOIN SalesBBillMaster ON BillItemMaster.BillNO = SalesBBillMaster.BillNo where (CONVERT(DateTime,BillItemMaster.Date, 103) >= CONVERT(DateTime, '" + Startdate + "', 103))  AND (CONVERT(DateTime, BillItemMaster.Date, 103) <= CONVERT(DateTime, '" + enddate + "', 103) AND CustomerType ='Customer') AND (BillItemMaster.CompanyId='1') AND (BillItemMaster.PermanentDelete='" + false + "') AND (BillItemMaster.PermanentDelete='False') and (SalesBBillMaster.CustomerType='CustomerGST') ORDER BY CONVERT(DateTime, BillItemMaster.Date, 103) ";
            DataTable dt = _objdb.GetDataTable(querry);
            return dt;
        }


        public DataTable getCustomerDetails(string startdate, string enddate)
        {
            string querry = "SELECT SalesBMaster.FullName AS Name, SalesBBillMaster.PayMode, SalesBBillMaster.date,SalesBBillMaster.CBillNo,SalesBBillMaster.NewBillNo, SalesBBillMaster.BillNo, SalesBBillMaster.TotalAmount,    SalesBBillMaster.totalGold, SalesBBillMaster.BalanceAmount, SalesBBillMaster.balanceGold, SalesBBillMaster.PayByCheque,         ChequeMaster.ChequeNo AS ChequeId, SalesBBillMaster.payByCash FROM    SalesBBillMaster INNER JOIN         SalesBMaster ON SalesBBillMaster.AccNo = SalesBMaster.AccNo LEFT OUTER JOIN        ChequeMaster ON SalesBBillMaster.chequeId = ChequeMaster.ChequeId  where SalesBBillMaster.PermanentDelete = 'false' AND  (CONVERT(DateTime,SalesBBillMaster.date, 103) >= CONVERT(DateTime, '" + startdate + "', 103))  AND (CONVERT(DateTime, SalesBBillMaster.date, 103) <= CONVERT(DateTime, '" + enddate + "', 103)) AND (SalesBBillMaster.comment<>'Opening Balance Created') and (SalesBBillMaster.CustomerType='CustomerGST')  ORDER BY CONVERT(DateTime, dbo.SalesBBillMaster.date, 103)";
            DataTable dt = _objdb.GetDataTable(querry);
            return dt;

        }






        //k
        public DataTable getallAccountLedgerDetailsIndividualCredit(string StartDate, string EndDate, string Lid)
        {
            string str = "SELECT  AccountNature.Under, AccountLedger.name, CreditDebitDetails.credit,CreditDebitDetails.CreditDebitmasterid,CreditDebitDetails.chequeno, CreditDebitDetails.chequedate,CreditDebitDetails.debit,CreditDebitDetails.FromAccount, CreditDebitDetails.date FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN   CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountNature.Under = N'Cash-In-Hand') And (CreditDebitDetails.Type='Cr') AND (CONVERT(DateTime, CreditDebitDetails.date, 103) >= CONVERT(DateTime,  '" + StartDate + "', 103)) AND (CONVERT(DateTime, CreditDebitDetails.date, 103) <=  CONVERT(DateTime, '" + EndDate + "' , 103) and AccountLedger.ledgerId='" + Lid + "')";
            return _objdb.GetDataTable(str);
        }

        public DataTable getallAccountLedgerDetailsIndividualDebit(string StartDate, string EndDate, string Lid)
        {
            string str = "SELECT  AccountNature.Under, AccountLedger.name, CreditDebitDetails.credit, CreditDebitDetails.CreditDebitmasterid,CreditDebitDetails.chequeno, CreditDebitDetails.chequedate,CreditDebitDetails.debit,CreditDebitDetails.FromAccount, CreditDebitDetails.date FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN   CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountNature.Under = N'Cash-In-Hand') And (CreditDebitDetails.Type='Dr') AND (CONVERT(DateTime, CreditDebitDetails.date, 103) >= CONVERT(DateTime,  '" + StartDate + "', 103)) AND (CONVERT(DateTime, CreditDebitDetails.date, 103) <=  CONVERT(DateTime, '" + EndDate + "' , 103) and AccountLedger.ledgerId='" + Lid + "')";
            return _objdb.GetDataTable(str);
        }

        //


        public DataTable getallAccountLedgerDetails()
        {
            string str = "SELECT ROW_NUMBER() Over (Order by AccountLedger.Name) As [SL.NO], AccountLedger.Date,  AccountLedger.ledgerId, AccountLedger.Name AS ledgerName, AccountLedger.OpeningBal AS openingBalance, AccountNature.Under AS accountGroupName, AccountLedger.CreditOrDebit AS crOrDr, AccountLedger.Date FROM AccountLedger INNER JOIN   AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId";
            return _objdb.GetDataTable(str);
        }



        public DataTable getallAccountLedgerDetailsByAccountNature(string accountnature)
        {
            string str = "SELECT AccountLedger.ledgerId AS Id, AccountNature.Under AS [Account Group], AccountLedger.name AS Name, AccountLedger.openingBal AS [Opening Balance], AccountLedger.CreditOrDebit AS [Credit/Debit],  AccountLedger.narration AS Narration, AccountLedger.nameofbank AS [Bank Name], AccountLedger.chequeno AS [Cheque No], AccountLedger.accno AS [Acc No] FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId Where AccountNature.Under=N'" + accountnature + "'";
            return _objdb.GetDataTable(str);
        }

        public string insertCreditDebitmaster(string totalamount, string narration, string date, int financialdateid)
        {
            string str = "INSERT INTO CreditDebitMaster(totalamount, narration, date, financialyearid) OUTPUT Inserted.CreditDebitmasterid VALUES (" + totalamount + ", '" + narration + "', " + date + ", " + financialdateid + ")";
            string id = _objdb.ExecuteScalar(str);
            return id.ToString();
        }

        public string UpdateCreditDebitMaster(string amount, string narration, DateTime date, string MasterId)
        {
            string str = "Update CreditDebitMaster SET totalamount = '" + amount + "', narration = '" + narration + "', date = '" + date + "' WHERE CreditDebitmasterid='" + MasterId + "' ";
            string id = _objdb.ExecuteScalar(str);
            return id.ToString();
        }

        public void insertCreditDebitDetails(string legderid, string debit, string credit, string ChequeNo, string chequeDate, string date, string type, string FromAccount, string Narration, string VoucherTypeID, string VoucherNo)
        {
            string str = "INSERT INTO CreditDebitDetails ( ledgerId,debit, credit ,chequeno, chequedate,  date,Type,FromAccount, narration,VoucherTypeID,VoucherNo)  VALUES ( " + legderid + ", " + debit + ", " + credit + ",'" + ChequeNo + "', '" + chequeDate + "','" + date + "','" + type + "',N'" + FromAccount + "','" + Narration + "','" + VoucherTypeID + "','" + VoucherNo + "')";
            int id = _objdb.ExecuteSql(str);

        }

        public string UpdateCreditDebitDetails(string date, string amount, string type, string chequeDate, string chequeNo, string narration, string MasterId)
        {
            string str = "Update CreditDebitDetails SET date = '" + date + "', narration = '" + narration + "', chequedate='" + chequeDate + "', chequeno='" + chequeNo + "' WHERE CreditDebitmasterid='" + MasterId + "' AND Type='" + type + "' ";
            string id = _objdb.ExecuteScalar(str);
            return id.ToString();
        }

        public string insertDebitmaster(string totalamount, string narration, string date, string financialdateid)
        {
            string str = "INSERT INTO DebitMaster (totalamount, narration, date, financialyearid) VALUES (" + totalamount + ", '" + narration + "', " + date + ", " + financialdateid + "); Select Scope_Identity()";
            int id = _objdb.ExecuteSql(str);
            return id.ToString();
        }

        public void insertDebitDetails(string debitmasterid, string legderid, string credit, string debit, string chequedate, string chequeno, string date)
        {
            string str = "INSERT INTO DebitDetails  (debitmasterid, ledgerId, credit, debit, chequedate, chequeno, date) VALUES (" + debitmasterid + ", " + legderid + ", " + credit + ", " + debit + ", " + chequedate + ", " + chequeno + ", " + date + ")";
            int id = _objdb.ExecuteSql(str);

        }

        public DataTable getAllDebitDetails(string ledgerid)
        {
            string str = "SELECT debitdetailId, debitmasterid, ledgerId, credit, debit, chequedate, chequeno, date FROM DebitDetails WHERE (ledgerId = " + ledgerid + ")";
            return _objdb.GetDataTable(str);
        }

        public DataTable getAllCreditDebitDetails(string ledgerid)
        {
            string str = "SELECT CreditDebitdetailId, CreditDebitmasterid, ledgerId, credit, debit, chequedate, chequeno, date FROM CreditDebitDetails WHERE (ledgerId = " + ledgerid + ")";
            return _objdb.GetDataTable(str);
        }



        public DataTable getTrialBalance(string nature)
        {
            string str = null;
            if (nature == "Current Assets")
            {
                str = "SELECT AccountNature.accountGroupId, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under <> N'Fixed Assests') AND (AccountNature.Under <> N'Cash-In-Hand')";
            }
            if (nature == "Current Liabilities")
            {
                str = "SELECT AccountNature.accountGroupId, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND ((AccountNature.Under <> N'Capital Account')  AND (AccountNature.Under <> N'Loans'))";

            }
            if (nature == "Capital Account")
            {
                str = "SELECT AccountNature.accountGroupId, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'Capital Account')";
            }
            if (nature == "Loans")
            {
                str = "SELECT AccountNature.accountGroupId, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'Loans')";
            }
            if (nature == "Fixed Assests")
            {
                str = "SELECT AccountNature.accountGroupId, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under = N'Fixed Assests')";
            }
            if (nature == "Direct Expenses" || nature == "Direct Income" || nature == "Indirect Income" || nature == "Indirect Expenses")
            {
                str = "SELECT AccountNature.accountGroupId, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Under = N'" + nature + "')";
            }


            return _objdb.GetDataTable(str);
        }

        public DataTable getOpeningLedger(string nature)
        {
            string str = null;
            if (nature == "Current Assets")
            {
                str = "SELECT AccountLedger.accGroupId, AccountLedger.openingBal,AccountLedger.CreditOrDebit,AccountNature.Nature ,AccountLedger.date FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under <> N'Fixed Assests') AND (AccountNature.Under <> N'Cash-In-Hand')";
            }
            if (nature == "Current Liabilities")
            {
                str = "SELECT AccountLedger.accGroupId, AccountLedger.openingBal,AccountLedger.CreditOrDebit, AccountNature.Nature FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId WHERE (AccountNature.Nature = N'Liabilities') AND ((AccountNature.Under <> N'Capital Account') AND (AccountNature.Under <> N'Loans'))";

            }
            if (nature == "Capital Account")
            {
                str = "SELECT AccountLedger.accGroupId, AccountLedger.openingBal,AccountLedger.CreditOrDebit, AccountNature.Nature FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'Capital Account')";

            }
            if (nature == "Loans")
            {
                str = "SELECT AccountLedger.accGroupId, AccountLedger.openingBal,AccountLedger.CreditOrDebit, AccountNature.Nature FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'Loans')";

            }
            if (nature == "Fixed Assests")
            {
                str = "SELECT AccountLedger.accGroupId, AccountLedger.openingBal,AccountLedger.CreditOrDebit, AccountNature.Nature FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under = N'Fixed Assests')";

            }

            if (nature == "Direct Expenses" || nature == "Direct Income" || nature == "Indirect Income" || nature == "Indirect Expenses")
            {
                str = "SELECT AccountLedger.accGroupId, AccountLedger.openingBal,AccountLedger.CreditOrDebit, AccountNature.Nature FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId WHERE (AccountNature.Under = N'" + nature + "')";

            }
            if (nature == "Cash-In-Hand")
            {
                str = "SELECT AccountLedger.accGroupId, AccountLedger.openingBal,AccountLedger.CreditOrDebit,AccountNature.Nature ,AccountLedger.date FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId WHERE  (AccountNature.Under = N'Cash-In-Hand')";

            }

            //for balance sheet under view
            if (nature == "CurrentAssetsAll")
            {
                str = "SELECT Under from AccountNature WHERE (Nature = N'Assets') AND (Under <> N'Fixed Assests')";
            }

            if (nature == "OnlyFixedAssest")
            {
                str = "SELECT Under from AccountNature WHERE (Nature = N'Assets') AND (Under = N'Fixed Assests')";

            }
            if (nature == "onlyCurrentLiabilities")
            {
                str = "SELECT Under from AccountNature WHERE (AccountNature.Nature = N'Liabilities') AND ((AccountNature.Under <> N'Capital Account')  AND (AccountNature.Under <> N'Loans'))";

            }
            if (nature == "onlyCapitalAccount")
            {
                str = "SELECT Under from AccountNature WHERE (Nature = N'Liabilities') AND (Under = N'Capital Liabilities')";

            }
            if (nature == "onlyLoans")
            {
                str = "SELECT Under from AccountNature WHERE (Nature = N'Liabilities') AND (Under = N'Loans')";

            }

            return _objdb.GetDataTable(str);
        }

        public void updateLedger(string ledgerid, string name, string account_groupId, string opning_bal, string transaction_type, string narration, string BankAccNo, string NameOfBranch, string BranchCode, string AccNo, string Date, int financialYearId, string VoucherTypeID)
        {
            string str = "UPDATE  AccountLedger SET date='" + Date + "',  name = N'" + name + "', accGroupId=" + account_groupId + ",openingBal = " + opning_bal + ", CreditOrDebit = '" + transaction_type + "', narration = N'" + narration + "', BankAccNo = N'" + BankAccNo + "', NameOfBranch = N'" + NameOfBranch + "',BranchCode='" + BranchCode + "' WHERE     (ledgerId = " + ledgerid + ")";
            _objdb.ExecuteSql(str);
        }

        public DataTable getAsset(string under)
        {
            string str = str = "SELECT AccountNature.accountGroupId, AccountLedger.ledgerId, AccountNature.Nature,AccountNature.Under, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under <> N'Fixed Assests') ";
            DataTable dt = _objdb.GetDataTable(str);
            return dt;
        }


        public DataTable getbalanceTrailflow(string Under, string nature)
        {
            string query = null;
            if (nature == "Current Assets")
            {
                query = "SELECT AccountNature.accountGroupId, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under <> N'Fixed Assests') AND (AccountNature.Under = N'" + Under + "')";
            }
            if (nature == "Fixed Assets")
            {
                query = "SELECT AccountNature.accountGroupId, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under = N'Fixed Assests') AND (AccountNature.Under = N'" + Under + "')";
            }

            if (nature == "Current Liabilities")
            {
                query = "SELECT AccountNature.accountGroupId, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'" + Under + "')";
            }
            if (nature == "Capital Liabilities")
            {
                query = "SELECT AccountNature.accountGroupId, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'Capital Liabilities') AND (AccountNature.Under = N'" + Under + "')";
            }
            if (nature == "Loans")
            {
                query = "SELECT AccountNature.accountGroupId, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'Loans') AND (AccountNature.Under = N'" + Under + "')";
            }
            return _objdb.GetDataTable(query);
        }

        public DataTable getBalanceCashflow(string Under)
        {
            string str = "SELECT  AccountLedger.name, CreditDebitDetails.credit, CreditDebitDetails.debit,AccountLedger.ledgerId FROM   AccountLedger INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountLedger.name = N'" + Under + "')";
            return _objdb.GetDataTable(str);
        }

        public DataTable getAcountLedgerFromgroup(string under1, string under2 = null)
        {
            string str = "SELECT  AccountLedger.ledgerId, AccountLedger.name FROM  AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId WHERE  (AccountNature.Under = N'" + under1 + "') OR (AccountNature.Under = N'" + under2 + "')";
            return _objdb.GetDataTable(str);
        }

        public DataTable getAcountLedgerByGroupSrNo()
        {
            string str = "SELECT AN.srno, AL.Name FROM dbo.AccountLedger AS AL INNER JOIN dbo.AccountNature AS AN ON AL.accGroupId = AN.srno WHERE (AN.srno = 1) OR (AN.srno = 4)";
            return _objdb.GetDataTable(str);
        }

        public string getReceiptNoFromReceiptMaster()
        {
            string str = "Select ISNULL(Max(ReceiptNo)+1,1) As ReceiptNo From ReceiptMaster where PermanentDelete = '0'";
            return _objdb.ExecuteScalar(str);
        }

        public string getPaymentNoFromPaymentMaster()
        {
            string str = "Select ISNULL(Max(PaymentNo)+1,1) As PaymentNo From PaymentMaster where PermanentDelete = '0'";
            return _objdb.ExecuteScalar(str);
        }

        public void deleteDebitCredit(string id)
        {
            string strDebitCredit = "DELETE FROM CreditDebitDetails WHERE     (CreditDebitmasterid = " + id + ")";
            string strMaster = "DELETE FROM CreditDebitMaster WHERE     (CreditDebitmasterid = " + id + ")";

            _objdb.ExecuteSql(strMaster);
            _objdb.ExecuteSql(strDebitCredit);


        }


        public DataTable getallDebitDetailsOnDate(string Date)
        {
            string str = "SELECT  AccountNature.Under, AccountLedger.name, CreditDebitDetails.credit, CreditDebitDetails.CreditDebitmasterid,CreditDebitDetails.chequeno, CreditDebitDetails.chequedate,CreditDebitDetails.debit,CreditDebitDetails.FromAccount, CreditDebitDetails.date FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN   CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountNature.Under = N'Cash-In-Hand') And (CreditDebitDetails.Type='Dr') and (CreditDebitDetails.date='" + Date + "')";
            return _objdb.GetDataTable(str);
        }
        public DataTable getallCreditDetailsOnDate(string Date)
        {
            string str = "SELECT  AccountNature.Under, AccountLedger.name, CreditDebitDetails.credit,CreditDebitDetails.CreditDebitmasterid,CreditDebitDetails.chequeno, CreditDebitDetails.chequedate,CreditDebitDetails.debit,CreditDebitDetails.FromAccount, CreditDebitDetails.date FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.accountGroupId INNER JOIN   CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountNature.Under = N'Cash-In-Hand') And (CreditDebitDetails.Type='Cr') and (CreditDebitDetails.date='" + Date + "')";
            return _objdb.GetDataTable(str);
        }


        //k
        public string getLedgerid(string ledgerid)
        {
            string str = "SELECT ledgerId FROM AccountLedger WHERE (ledgerId = '" + ledgerid + "') ";
            DataTable ret = _objdb.GetDataTable(str);
            return ret.Rows[0]["ledgerId"].ToString();
        }

        public void DeleteLedgerid(string ledgerid)
        {
            string str1 = "select count(*) from AccountLedger where ledgerId='" + ledgerid + "'and IsDefault = 'False'"; //Check the IsDefault value is False
            int i = Convert.ToInt32(_objdb.ExecuteScalar(str1));

            if (i > 0) // To check values in table
            {
                string str2 = "Delete from CreditDebitDetails where ledgerId='" + ledgerid + "'";
                _objdb.ExecuteSql(str2);

                string str3 = "Delete from AccountLedger where ledgerId='" + ledgerid + "' and IsDefault = 'False' ";
                _objdb.ExecuteSql(str3);
            }
            else
            {
                MessageBox.Show("This Account Ledger is not Deleted");
            }
        }

        public void deleteDebitCreditbybillno(string sSBillID, string Vouchertypeid)
        {
            string strDebitCredit = "DELETE FROM CreditDebitDetails WHERE     (VoucherNo = '" + sSBillID + "' and VouchertypeId='" + Vouchertypeid + "')";
            _objdb.ExecuteSql(strDebitCredit);
        }
    }
}
