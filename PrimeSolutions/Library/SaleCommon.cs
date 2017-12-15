using System;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using PrimeSolutions.Report;
using System.IO;
using System.Collections.Generic;
using PrimeSolutions.Common;

namespace PrimeSolutions.Library
{
    public class SaleCommon
    {
        SQLHelper _sql = new SQLHelper();
        AllClassFile _a = new AllClassFile();
        DataTable dtSett;
        clsCommon _common = new clsCommon();

        Cls_BalanceSheet _objCeditDebit = new Cls_BalanceSheet();
        string BillNo;

        public void AddBillDetails(string BillNo, string CustomerId, string date, string amount, string CGST, string SGST, string IGST, string GrandAmt, string State,string BillAmt,string Dissount,string Type,string Extra,string Narration)
        {
            string str = "Insert into CustomerBill(BillNo,CustId,Date,Amount,CGST,SGST,IGST,GrandAmt,State,BillAmount,Discount,Type,ExtraCharges,Narration)Values('" + BillNo + "','" + CustomerId + "','" + date + "','" + amount + "','" + CGST + "','" + SGST + "','" + IGST + "','" + GrandAmt + "','" + State + "','"+BillAmt+"','"+Dissount+"','"+Type+"','"+Extra+"','"+Narration+"')";
            _sql.ExecuteSql(str);
        }

        public void UpdateItem(string ItemId, string SaleBill, string date)
        {
            string str = "Update BillItem Set Type= 'Sale',SaleBillNo='" + SaleBill + "',SaleDate='" + date + "' Where Barcode='" + ItemId + "' and PermananetDelete = false ";
            _sql.ExecuteSql(str);
        }

        public void AddItemDetails(string Category, string SubCategory,string size, string BillNo, string type, string date, string price, string Qty, string CGST, string CGSTAmt, string SGST, string SGSTAmt, string IGST, string IGSTAmt, string totalAmt, string batch, string HSN,string TotalPrice,string SalesPerson,string maintain)
        {
            string str = "Insert into BillItem(Category,SubCategory,Size,SaleBillNo,Type,SaleDate,Price,Qty,CGST,CGSTAmt,SGST,SGSTAmt,IGST,IGSTAmt,TotalPrice,BatchNo,HSN,SellingPrice,SalesPerson,Maintain) Values('" + Category + "','" + SubCategory + "','"+size+"','" + BillNo + "','" + type + "','" + date + "','" + price + "','" + Qty + "','" + CGST + "','" + CGSTAmt + "','" + SGST + "','" + SGSTAmt + "','" + IGSTAmt + "','" + IGSTAmt + "','" + totalAmt + "','" + batch + "','" + HSN + "','"+TotalPrice+"','"+SalesPerson+"','"+maintain+"') ";
            _sql.ExecuteSql(str);
        }

        public void DeleteBillItem(string BillNo)
        {
            string str = "Update BillItem Set PermanentDelete = 1 Where SaleBillNo ='" + BillNo + "'";
        }

        public void DeleteBillDetails(string BillNo)
        {
            string str = "Update CustomerBill Set permanentDelete = 1 Where BillNo ='" + BillNo + "'";
        }


        public DataTable GetCsutomerDetail(string from, string to)
        {
            string str = "SELECT distinct dbo.CustomerMaster.CustomerName,dbo.CustomerMaster.GSTIN FROM dbo.CustomerMaster INNER JOIN dbo.CustomerBill ON dbo.CustomerMaster.CustId = dbo.CustomerBill.CustId WHERE(CONVERT(DateTime, dbo.CustomerBill.Date, 103) >= CONVERT(DateTime, '" + from + "', 103)) AND(CONVERT(DateTime, dbo.CustomerBill.Date, 103) <= CONVERT(DateTime, '" + to + "', 103)) AND (dbo.CustomerBill.permanentdelete = 0) AND (dbo.CustomerBill.Type = 'GST')";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable CustomerGSTReport(string from, string to, string CustId, string Sper, string Iper)
        {
            string str = "SELECT     SUM(CONVERT(Decimal(10, 2), dbo.BillItem.Price)) AS Taxable, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.CGSTAmt)) AS CGST, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.SGSTAmt)) AS SGST, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.IGSTAmt)) AS IGST FROM dbo.CustomerMaster INNER JOIN dbo.CustomerBill ON dbo.CustomerMaster.CustId = dbo.CustomerBill.CustId INNER JOIN dbo.BillItem ON dbo.CustomerBill.BillNo = dbo.BillItem.SaleBillNo WHERE(dbo.CustomerMaster.CustomerName = '"+CustId+"') AND(CONVERT(DateTime, dbo.CustomerBill.Date, 103) >= CONVERT(DateTime, '"+from+"', 103)) AND(CONVERT(DateTime, dbo.CustomerBill.Date, 103) <= CONVERT(DateTime, '"+to+"', 103)) AND(dbo.BillItem.CGST = '"+Sper+"') OR (dbo.BillItem.IGST = '"+Iper+ "') AND(dbo.CustomerBill.permanentDelete = 0) AND (dbo.CustomerBill.Type = 'GST')";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable CustomerGSTReportZeroPer(string from, string to, string CustId, string Sper, string Iper)
        {
            string str = "SELECT     SUM(CONVERT(Decimal(10, 2), dbo.BillItem.Price)) AS Taxable, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.CGSTAmt)) AS CGST, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.SGSTAmt)) AS SGST, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.IGSTAmt)) AS IGST FROM dbo.CustomerMaster INNER JOIN dbo.CustomerBill ON dbo.CustomerMaster.CustId = dbo.CustomerBill.CustId INNER JOIN dbo.BillItem ON dbo.CustomerBill.BillNo = dbo.BillItem.SaleBillNo WHERE(dbo.CustomerMaster.CustomerName = '" + CustId + "') AND(CONVERT(DateTime, dbo.CustomerBill.Date, 103) >= CONVERT(DateTime, '" + from + "', 103)) AND(CONVERT(DateTime, dbo.CustomerBill.Date, 103) <= CONVERT(DateTime, '" + to + "', 103)) AND(dbo.BillItem.CGST = '" + Sper + "') AND (dbo.BillItem.IGST = '" + Iper + "') AND(dbo.CustomerBill.permanentDelete = 0) AND (dbo.CustomerBill.Type = 'GST')";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable CustomerGSTReport(string from, string to, string Sper, string Iper)
        {
            string str = "SELECT SUM(CONVERT(Decimal(10, 2), dbo.BillItem.Price)) AS Taxable, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.CGSTAmt)) AS CGST, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.SGSTAmt)) AS SGST,  SUM(CONVERT(Decimal(10, 2), dbo.BillItem.IGSTAmt)) AS IGST FROM dbo.BillItem INNER JOIN dbo.CustomerBill ON dbo.BillItem.SaleBillNo = dbo.CustomerBill.BillNo WHERE((CONVERT(DateTime, dbo.CustomerBill.Date, 103) >= CONVERT(DateTime, '" + from + "', 103)) AND(CONVERT(DateTime, dbo.CustomerBill.Date, 103) <= CONVERT(DateTime, '" + to + "', 103))) AND((dbo.BillItem.CGST = '" + Sper + "') OR (dbo.BillItem.IGST = '" + Iper + "')) AND (dbo.CustomerBill.permanentdelete = 0) AND(dbo.CustomerBill.Type = 'GST')";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable CustomerGSTReportZeroPer(string from, string to, string Sper, string Iper)
        {
            string str = "SELECT SUM(CONVERT(Decimal(10, 2), dbo.BillItem.Price)) AS Taxable, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.CGSTAmt)) AS CGST, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.SGSTAmt)) AS SGST,  SUM(CONVERT(Decimal(10, 2), dbo.BillItem.IGSTAmt)) AS IGST FROM dbo.BillItem INNER JOIN dbo.CustomerBill ON dbo.BillItem.SaleBillNo = dbo.CustomerBill.BillNo WHERE((CONVERT(DateTime, dbo.CustomerBill.Date, 103) >= CONVERT(DateTime, '" + from + "', 103)) AND(CONVERT(DateTime, dbo.CustomerBill.Date, 103) <= CONVERT(DateTime, '" + to + "', 103))) AND((dbo.BillItem.CGST = '" + Sper + "') AND (dbo.BillItem.IGST = '" + Iper + "')) AND (dbo.CustomerBill.permanentdelete = 0) AND(dbo.CustomerBill.Type = 'GST')";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetItemDetailsByBarcode(string Barcode)
        {
            string str = "Select * from BillItem where Barcode = '" + Barcode + "'";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public void insertcreditDebitWithPayment(string customerLedgerID, string VouchertypeID, string sbillno, string transactionLedgerID, string AmountPaid, string Narration, string Date, string name)
        {
            _objCeditDebit.insertCreditDebitDetails(legderid: customerLedgerID, debit: "0", credit: AmountPaid, ChequeNo: null, chequeDate: null, date: Date, type: "Cr", FromAccount: "Cash/Bank", Narration: Narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
            _objCeditDebit.insertCreditDebitDetails(legderid: transactionLedgerID, debit: AmountPaid, credit: "0", ChequeNo: null, chequeDate: null, date: Date, type: "Dr", FromAccount: name, Narration: Narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
        }

        public void insertcreditDebitWithPaymentForReceiptVoucher(string customerLedgerID, string VouchertypeID, string sbillno, string transactionLedgerID, string AmountPaid, string Narration, string Date, string name)
        {
            _objCeditDebit.insertCreditDebitDetails(legderid: customerLedgerID, debit: "0", credit: AmountPaid, ChequeNo: null, chequeDate: null, date: Date, type: "Cr", FromAccount: "Cash/Bank", Narration: Narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
            _objCeditDebit.insertCreditDebitDetails(legderid: transactionLedgerID, debit: AmountPaid, credit: "0", ChequeNo: null, chequeDate: null, date: Date, type: "Dr", FromAccount: name, Narration: Narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
        }


        public void insertcreditDebitWithPaymentForPaymentVoucher(string customerLedgerID, string VouchertypeID, string sbillno, string transactionLedgerID, string AmountPaid, string Narration, string Date, string name)
        {
            _objCeditDebit.insertCreditDebitDetails(legderid: customerLedgerID, debit: AmountPaid, credit: "0", ChequeNo: null, chequeDate: null, date: Date, type: "Dr", FromAccount: "Cash/Bank", Narration: Narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
            _objCeditDebit.insertCreditDebitDetails(legderid: transactionLedgerID, debit: "0", credit: AmountPaid, ChequeNo: null, chequeDate: null, date: Date, type: "Cr", FromAccount: name, Narration: Narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
        }

        public void InsertCreditDebitInSalesAccount(string customerLedgerID, string VouchertypeID, string sbillno, string Name, string Amount, string Narration, string Date)
        {
            string TransactionSalesAccount = _common.getALLTableDetails(sTableName: TableNames.AccountLedger, sColomnName: "Name", sColumnValue: "Sales Account").Rows[0]["ledgerId"].ToString();
            _objCeditDebit.insertCreditDebitDetails(legderid: TransactionSalesAccount, debit: "0", credit: Amount, ChequeNo: null, chequeDate: null, date: Date, type: "Cr", FromAccount: Name, Narration: Narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
            _objCeditDebit.insertCreditDebitDetails(legderid: customerLedgerID, debit: Amount, credit: "0", ChequeNo: null, chequeDate: null, date: Date, type: "Dr", FromAccount: "Sales Account", Narration: Narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
        }

        public void InsertCreditDebitInSalesAccountForPaymentVoucher(string customerLedgerID, string VouchertypeID, string sbillno, string Name, string Amount, string Narration, string Date)
        {
            string TransactionSalesAccount = _common.getALLTableDetails(sTableName: TableNames.AccountLedger, sColomnName: "Name", sColumnValue: "Sales Account").Rows[0]["ledgerId"].ToString();
            _objCeditDebit.insertCreditDebitDetails(legderid: TransactionSalesAccount, debit: Amount, credit: "0", ChequeNo: null, chequeDate: null, date: Date, type: "Dr", FromAccount: Name, Narration: Narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
            _objCeditDebit.insertCreditDebitDetails(legderid: customerLedgerID, debit: "0", credit: Amount, ChequeNo: null, chequeDate: null, date: Date, type: "Cr", FromAccount: "Sales Account", Narration: Narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
        }

        public string insertAcountLedgerDetail(string Vouchertypeid, string AccNo, string Name, string Narration, string Date, string openingBalance = "0")
        {
            string CustomerLedgerID = "";
            DataTable dtAcountLedger = _common.getALLTableDetails(sTableName: TableNames.AccountLedger, sColomnName: "Name", sColumnValue: Name.Trim());
            string sundrydebitor = _common.getALLTableDetails(sTableName: TableNames.AccountNature, sColomnName: "Under", sColumnValue: "Sundry Debtors").Rows[0]["accountGroupId"].ToString();
            if (dtAcountLedger.Rows.Count == 0)
            {
                CustomerLedgerID = _objCeditDebit.insertAccountLedger(name: Name, account_groupId: sundrydebitor, opning_bal: openingBalance, transaction_type: "Dr", narration: Narration, BankAccNo: null, NameOfBranch: null, BranchCode: null, AccNo: AccNo, Date: Date, financialYearId: 1, VoucherTypeID: Vouchertypeid);
            }
            else
            {
                CustomerLedgerID = dtAcountLedger.Rows[0]["ledgerid"].ToString();
            }
            return CustomerLedgerID;
        }

        public DataTable selectAccountLedgerDetail(string StartDate, string EndDate, string GroupID, string LedgerID)
        {
            string str = "";
            if (GroupID == "All" && LedgerID == "All") { str = "SELECT * from AccountLedger  where (CONVERT(DateTime, AccountLedger.Date, 103) >= CONVERT(DateTime, '" + StartDate + "', 103))  AND (CONVERT(DateTime, AccountLedger.Date, 103) <= CONVERT(DateTime, '" + EndDate + "', 103))  and AccountLedger.PermanentDelete= 0"; }
            else if (GroupID != "All" && LedgerID == "All") { str = "SELECT * from AccountLedger  where (CONVERT(DateTime, AccountLedger.Date, 103) >= CONVERT(DateTime, '" + StartDate + "', 103))  AND (CONVERT(DateTime, AccountLedger.Date, 103) <= CONVERT(DateTime, '" + EndDate + "', 103)) and AccountLedger.accGroupId='" + GroupID + "' and AccountLedger.PermanentDelete= 0"; }
            else if (GroupID != "All" && LedgerID != "All") { str = "SELECT * from AccountLedger  where (CONVERT(DateTime, AccountLedger.Date, 103) >= CONVERT(DateTime, '" + StartDate + "', 103))  AND (CONVERT(DateTime, AccountLedger.Date, 103) <= CONVERT(DateTime, '" + EndDate + "', 103)) and AccountLedger.accGroupId='" + GroupID + "' and AccountLedger.Name='" + LedgerID + "'  and AccountLedger.PermanentDelete= 0"; }
            else { str = "SELECT * from AccountLedger  where (CONVERT(DateTime, AccountLedger.Date, 103) >= CONVERT(DateTime, '" + StartDate + "', 103))  AND (CONVERT(DateTime, AccountLedger.Date, 103) <= CONVERT(DateTime, '" + EndDate + "', 103)) and  AccountLedger.Name='" + LedgerID + "'  and AccountLedger.PermanentDelete= 0"; }
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetItemDetailsByCategoySubCategory(string category, string subcategory)
        {
            string str = "Select * from BillItem where Category = '" + category + "' and SubCategory='" + subcategory + "'";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetItemDetailsByCategoySubCategorySize(string category, string subcategory,string size)
        {
            string str = "Select * from BillItem where Category = '" + category + "' and SubCategory='"+subcategory+ "' and Size = '" + size + "'";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public double GetBalance(string ID,string Type)
        {
            string str = "";
            double BillAmt = 0.0;

            string CustId = ID ;

            if (Type == "Sale")
            {
               BillAmt = GetTotalPurchase(CustId, Type);
            }
            else if (Type == "Purchase")
            {
               BillAmt = GetTotalSupplierPurchase(CustId, Type);
            }

            double PaidAmt = GetTotalPaid(CustId);
            double opening = GetOpening(CustId);
            double bal = (opening + BillAmt) - PaidAmt;
            return bal;
        }

        public Double GetTotalSupplierPurchase(string SuppId, string type)
        {
            string str1 = "Select Sum(convert(decimal,GrandTotal)) From SupplierBill where SupplierNo = '" + SuppId + "' and (PermanentDelete = 0 or PermanentDelete is Null)";
            string BillAmt = _sql.ExecuteScalar(str1);
            return Convert.ToDouble(BillAmt);
        }

        public Double GetTotalPurchase(string CustId, string type)
        {
            string str1 = "Select Sum(convert(decimal,BillAmount)) From CustomerBill where CustId = '" + CustId + "' and (PermanentDelete = 0 or PermanentDelete is Null) ";
            string BillAmt = _sql.ExecuteScalar(str1);
            if (BillAmt == null || BillAmt == "")
                return 0; 
            else
                return Convert.ToDouble(BillAmt);
        }

        public double GetTotalPaid(string CustId)
        {
            string str2 = "select Sum(convert(decimal,Amt)) from Payment where Id ='" + CustId + "'";
            string PaidAmt = _sql.ExecuteScalar(str2);
            if (PaidAmt == null || PaidAmt == "")
                return 0;
            else
                return Convert.ToDouble(PaidAmt);
        }

        public double GetOpening(string CustId)
        {
            string str1 = "Select Opening From CustomerMaster where CustId = '" + CustId + "'";
            string open = _sql.ExecuteScalar(str1);
            if (open == "" || open == "0" || open == string.Empty)
                return 0;
            else
                return Convert.ToDouble(open);
        }

        public DataTable GetBillDetails(string BillNo)
        {
            string str = "Select * from CustomerBill where BillNo = '" + BillNo + "'" ;
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetBillItem(string BillNo, string Type)
        {
            string str = "Select * from BillItem where " + Type + "BillNo = '" + BillNo + "' and (PermanentDelete = 0 or PermanentDelete is Null) ";
            DataTable dt = _sql.GetDataTable(str);
            dt.Columns.Add("Amount");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["Amount"] = Convert.ToString(Math.Round(Convert.ToDouble(dt.Rows[i]["Price"].ToString()) * Convert.ToDouble(dt.Rows[i]["Qty"].ToString()), 2));
            }
            return dt;
        }

        public DataTable GetCompanydetails()
        {
            string str = "select * from companymaster";
            DataTable company = _sql.GetDataTable(str);
            return company;
        }

        public DataTable GetCustomerByBill(string BillNo)
        {
            string str2 = "select * from CustomerMaster where CustId = (select Distinct CustId from CustomerBill where BillNo = '"+BillNo+"') ";
            DataTable dt = _sql.GetDataTable(str2);
            return dt;
        }

        public DataTable GetSupplierByBill(string BillNo)
        {
            string str = "SELECT  dbo.SupplierMaster.SupplierNo, dbo.SupplierMaster.Name, dbo.SupplierMaster.state, dbo.SupplierMaster.Address, dbo.SupplierMaster.ContactNo, dbo.SupplierMaster.PanNo,dbo.SupplierMaster.GSTIN, dbo.SupplierMaster.City FROM dbo.SupplierBill INNER JOIN dbo.SupplierMaster ON dbo.SupplierBill.SupplierNo = dbo.SupplierMaster.SupplierNo WHERE(dbo.SupplierBill.RefrenceNo = '" + BillNo+"')";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetCustomerDetails(string Name)
        {
            string str = "Select * From CustomerMaster where CustomerName = '" + Name + "'";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetCustomer()
        {
            string str = "Select * From CustomerMaster ";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetAllCustomer()
        {
            string str = "Select CustId,CustomerName From CustomerMaster ";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetCustomerBill(string id)
        {
            string str = "select BillNo,BillAmount,Date,Type from CustomerBill where CustId='" + id + "' and (PermanentDelete = 0 or PermanentDelete is Null) ";
            DataTable dt1 = _sql.GetDataTable(str);
            return dt1;
        }
        
        public DataTable GetCustomerPayment(string id)
        {
            string str = "Select * from Payment where Id='"+id+"'";
            DataTable dt1 = _sql.GetDataTable(str);
            return dt1;
        }

        //Print Thermal

        public void PrintBillThermal(string BillNO)
        {
            BillNo = BillNO;
            var doc = new PrintDocument();
            doc.PrintPage += new PrintPageEventHandler(ProvideContent);
            doc.Print();
        }

        public void ProvideContent(object sender, PrintPageEventArgs e)
        {
            string Billx = this.BillNo;
            int j;
            string CustName="" ;
            string CustCont="";
            DataTable BillDetail = GetBillDetails(Billx);
            DataTable BillItem = GetBillItem(Billx,"Sale");
            DataTable company = GetCompanydetails();
            DataTable Customer = GetCustomerByBill(Billx);
            dtSett = _a.getallssetting();

            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();
            int startX = 0;
            int startY = 0;
            int Offset = 20;
            
            //e.PageSettings.PaperSize.Width = 50;

            //Company Details//Header
            graphics.DrawString("Welcome to \n" + company.Rows[0]["Name"].ToString(), new Font("Lucida Handwriting", 10),
                                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 40;
            string underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 8),
            new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            //Customer&BillDetails
            graphics.DrawString("BillNo: " + BillDetail.Rows[0]["BillNo"].ToString(),
            new Font("Courier New", 10),
            new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            if (Customer.Rows.Count == 1)
            {
                CustName=Customer.Rows[0]["Name"].ToString();
                CustCont= Customer.Rows[0]["ContactNo"].ToString();
                graphics.DrawString("  " + CustName,new Font("Courier New", 8),
                        new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString("  " + CustCont,
                new Font("Courier New", 8),new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
            }

            graphics.DrawString(underLine, new Font("Courier New", 8),
                        new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            //BillItem
            for (int i=0;i<BillItem.Rows.Count;i++)
            {
                j = i + 1;
            graphics.DrawString( j+ ")" + BillItem.Rows[i]["category"].ToString()+"  " + BillItem.Rows[0]["sub_category"].ToString(),
            new Font("Courier New", 8),
                        new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 10;
                graphics.DrawString("₹" + BillItem.Rows[i]["sale_amt"].ToString(),
            new Font("Courier New", 8),
                        new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 15;
               
            }
            
            graphics.DrawString(underLine, new Font("Courier New", 8),
                        new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            //BillPayDetails
            graphics.DrawString("Bill Amount: ₹ " + BillDetail.Rows[0]["BillAmount"].ToString(), new Font("Courier New", 8),
                        new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString(dtSett.Rows[0]["Tax"]+"@"+ dtSett.Rows[0]["TaxPer"]+"% :" + BillDetail.Rows[0]["VAT"].ToString(), new Font("Courier New", 8),
                        new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Total Amount: ₹ " + BillDetail.Rows[0]["TotalAmount"].ToString(), new Font("Courier New", 8),
                        new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            
            graphics.DrawString(underLine, new Font("Courier New", 8),
                        new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("GST No: " + company.Rows[0]["VATNo"].ToString(), new Font("Courier New", 10),
                        new SolidBrush(Color.Black), startX, startY + Offset);
            
            Offset = Offset + 20;

            //Footer
            graphics.DrawString("      Thank You!  Visit Again !", new Font("Courier New", 8),
                        new SolidBrush(Color.Black), startX, startY + Offset);

        }

        public string GetAllHSNSale(string BillNo)
        {
            string AllHSN = "";
            string str = "Select  distinct HSN from BillItem where SaleBillNo = '" + BillNo + "'";
            DataTable dt = _sql.GetDataTable(str);
            int i = 0;

            while (dt.Rows.Count > i)
            {
                AllHSN = dt.Rows[i]["HSN"].ToString();
                AllHSN = AllHSN + ",";
                i++;
            }

            return AllHSN;
        }

        public DataTable GetCustomerReport(string from, string to)
        {
            string str = "SELECT dbo.CustomerBill.BillNo, dbo.CustomerBill.Date, dbo.CustomerBill.Amount, dbo.CustomerBill.CGST, dbo.CustomerBill.SGST, dbo.CustomerBill.IGST, dbo.CustomerBill.GrandAmt,  dbo.CustomerBill.State,dbo.CustomerBill.Discount, dbo.CustomerBill.BillAmount, dbo.CustomerMaster.CustomerName, dbo.CustomerMaster.Address, dbo.CustomerMaster.PanNo, dbo.CustomerMaster.GSTIN,  dbo.CustomerMaster.City FROM dbo.CustomerBill INNER JOIN dbo.CustomerMaster ON dbo.CustomerBill.CustId = dbo.CustomerMaster.CustId WHERE(CONVERT(DateTime, dbo.CustomerBill.Date, 103) >= CONVERT(DateTime, '" + from+"', 103)) AND(CONVERT(DateTime, dbo.CustomerBill.Date, 103) <= CONVERT(DateTime, '"+to+ "', 103)) and(PermanentDelete = 0 or PermanentDelete is Null) and (CustomerBill.Type ='GST')";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public string GetCustomerByCustid(string custid)
        {
            string str = "select CustomerName from customermaster where CustId='" + custid+"'";
            string cust = _sql.ExecuteScalar(str);
            return cust;
        }

        public DataTable GetSaleBillData()
        {
            string str = "select Distinct BillNo from CustomerBill Where PermanentDelete = 0 or PermanentDelete is Null";
            DataTable Bill = _sql.GetDataTable(str);
            return Bill;
        }

    }
}

