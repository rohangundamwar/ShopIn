﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using PrimeSolutions.Common;

namespace PrimeSolutions.Library
{
    class PurchaseCommon
    {
        SQLHelper _sql = new SQLHelper();
        clsCommon _objCommon = new clsCommon();
        Cls_BalanceSheet _objCeditDebit = new Cls_BalanceSheet();   


        public void insertcreditDebitPurchaseWithPayment(string customerLedgerID, string VouchertypeID, string sbillno, string transactionLedgerID, string PaidAmount, string Date, string narration, string SupplierName)
        {
            _objCeditDebit.insertCreditDebitDetails(legderid: customerLedgerID, debit: PaidAmount, credit: "0", ChequeNo: null, chequeDate: null, date: Date, type: "Dr", FromAccount: "Cash/Bank", Narration: narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
            _objCeditDebit.insertCreditDebitDetails(legderid: transactionLedgerID, debit: "0", credit: PaidAmount, ChequeNo: null, chequeDate: null, date: Date, type: "Cr", FromAccount: SupplierName, Narration: narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
        }

        public void insertcreditDebitPurchaseWithPaymentLessThanZero(string customerLedgerID, string VouchertypeID, string sbillno, string transactionLedgerID, string PaidAmount, string Date, string narration, string SupplierName)
        {
            _objCeditDebit.insertCreditDebitDetails(legderid: customerLedgerID, debit: "0", credit: PaidAmount, ChequeNo: null, chequeDate: null, date: Date, type: "Cr", FromAccount: "Cash/Bank", Narration: narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
            _objCeditDebit.insertCreditDebitDetails(legderid: transactionLedgerID, debit: PaidAmount, credit: "0", ChequeNo: null, chequeDate: null, date: Date, type: "Dr", FromAccount: SupplierName, Narration: narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
        }


        public void InsertCreditDebitInPurchaseAccount(string customerLedgerID, string VouchertypeID, string sbillno, string CurrentAmount, string Date, string date, string SupplierName, string Narration)
        {
            string TransactionSalesAccount = _objCommon.getALLTableDetails(sTableName: TableNames.AccountLedger, sColomnName: "Name", sColumnValue: "Purchase Account").Rows[0]["ledgerId"].ToString();
            _objCeditDebit.insertCreditDebitDetails(legderid: TransactionSalesAccount, debit: CurrentAmount, credit: "0", ChequeNo: null, chequeDate: null, date: date, type: "Dr", FromAccount: SupplierName, Narration: Narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
            _objCeditDebit.insertCreditDebitDetails(legderid: customerLedgerID, debit: "0", credit: CurrentAmount, ChequeNo: null, chequeDate: null, date: date, type: "Cr", FromAccount: "Purchase Account", Narration: Narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
        }


        public string insertAcountLedgerDetailPurchase(string Vouchertypeid, string SupplierName, string AccNo, string Date, string narration, string openingbalance = "0")
        {
            DataTable dtAcountLedger = _objCommon.getALLTableDetails(sTableName: TableNames.AccountLedger, sColomnName: "Name", sColumnValue: SupplierName);

            string sundrydebitor = _objCommon.getALLTableDetails(sTableName: TableNames.AccountNature, sColomnName: "Under", sColumnValue: "Sundry Creditors").Rows[0]["accountGroupId"].ToString();
            if (dtAcountLedger.Rows.Count == 0)
            {
                return _objCeditDebit.insertAccountLedger(name: SupplierName, account_groupId: sundrydebitor, opning_bal: openingbalance, transaction_type: "Dr", narration: narration, BankAccNo: null, NameOfBranch: null, BranchCode: null, AccNo: AccNo, Date: Date, financialYearId: 1, VoucherTypeID: Vouchertypeid);
            }
            else
            {
                return dtAcountLedger.Rows[0]["ledgerid"].ToString();
            }
        }
        public DataTable GetStock()
        {
        string str = "Select Distinct category,sub_category,purchase_amt,sale_amt,size from BillItem Where type= 'Purchase'";
            DataTable d1 =  _sql.GetDataTable(str);
            return d1;
        }

        public void InsertSupplierInfo(string accno, string name,string state,string add, string city, string contact, string PAN,string GSTIN, string date)
        {
            string str = " INSERT INTO SupplierMaster (SupplierNo, name,state,address, city, ContactNo,PanNo,GSTIN,Date) VALUES('" + accno + "','" + name + "','" + state + "','" + add + "','" + city + "','" + contact + "','"+PAN+"','" + GSTIN + "','" + date + "')";
            _sql.ExecuteScalar(str);
        }

        internal void InsertItem(string barcode,string category, string subcategory,string size, string Pbill,string type,string Qty,string CGST,string CGSTAmt, string SGST, string SGSTAmt, string IGST, string IGSTAmt,string purchaseamt, string total, string BatchNo,string sellingamt,string HSN,string date, string BarcodePrint,string PurchaseRef)
        {
            string str = "INSERT INTO BillItem (Barcode,Category, SubCategory,size,PurchaseBillNo,Type,Qty,CGST, CGSTAmt, SGST,SGSTAmt,IGST,IGSTAmt,Price,TotalPrice,BatchNo,SellingPrice,HSN,PurchaseDate,BarcodePrint,PurchaseRef) VALUES ('" + barcode + "','" + category + "','" + subcategory + "','"+size+"','" + Pbill + "','"+type+"','"+Qty+"','" + CGST + "','" + CGSTAmt + "','" + SGST + "','" + SGSTAmt + "','"+IGST+"','" + IGSTAmt + "','" + purchaseamt + "','"+total+"','"+BatchNo+"','"+sellingamt+"','"+HSN+"','"+date+ "','"+BarcodePrint+"','"+ PurchaseRef + "')";
            _sql.ExecuteScalar(str);
        }
        

        public DataTable GetSupplierBillNo()
        {
            DataTable dt;
            string str = "select distinct BillNo,RefrenceNo from SupplierBill";
            dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetSupplierBill(string ID)
        {
            DataTable dt;
            string str = "select BillNo,Amount,Date,Type,RefrenceNo from SupplierBill Where SupplierNo='"+ID+"'";
            dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetSupplierDetail(string from,string to)
        {
            string str = "SELECT distinct dbo.SupplierMaster.Name,dbo.SupplierMaster.GSTIN,dbo.SupplierMaster.state FROM dbo.SupplierMaster INNER JOIN dbo.SupplierBill ON dbo.SupplierMaster.SupplierNo = dbo.SupplierBill.SupplierNo WHERE(CONVERT(DateTime, dbo.SupplierBill.Date, 103) >= CONVERT(DateTime, '" + from + "', 103)) AND(CONVERT(DateTime, dbo.SupplierBill.Date, 103) <= CONVERT(DateTime, '" + to + "', 103)) AND (dbo.SupplierBill.permanentdelete = 0) AND (dbo.SupplierBill.Type = 'GST')";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }


        //Suppier Specific All Slab
        public DataTable SupplierGSTReport(string from, string to, string supplier,string Sper, string Iper)
        {
            string str = "SELECT SUM(CONVERT(Decimal(10, 2), dbo.BillItem.TotalPrice)) AS Taxable, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.CGSTAmt)) AS CGST, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.SGSTAmt)) AS SGST, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.IGSTAmt)) AS IGST FROM dbo.BillItem INNER JOIN dbo.SupplierBill ON dbo.BillItem.PurchaseRef = dbo.SupplierBill.RefrenceNo INNER JOIN dbo.SupplierMaster ON dbo.SupplierBill.SupplierNo = dbo.SupplierMaster.SupplierNo WHERE ((dbo.SupplierMaster.Name = '" + supplier + "') AND(CONVERT(DateTime, dbo.SupplierBill.Date, 103) >= CONVERT(DateTime, '" + from + "', 103)) AND(CONVERT(DateTime, dbo.SupplierBill.Date,103) <= CONVERT(DateTime, '" + to + "', 103))) AND ((dbo.BillItem.CGST='" + Sper + "') or  (dbo.BillItem.IGST='" + Iper + "')) AND(dbo.SupplierBill.permanentdelete = 0) AND (dbo.SupplierBill.Type = 'GST')";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        //Suppier Specific Zero Slab
        public DataTable SupplierGSTReportZerPer(string from, string to, string supplier, string Sper, string Iper)
        {
            string str = "SELECT SUM(CONVERT(Decimal(10, 2), dbo.BillItem.TotalPrice)) AS Taxable, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.CGSTAmt)) AS CGST, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.SGSTAmt)) AS SGST, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.IGSTAmt)) AS IGST FROM dbo.BillItem INNER JOIN dbo.SupplierBill ON dbo.BillItem.PurchaseRef = dbo.SupplierBill.RefrenceNo INNER JOIN dbo.SupplierMaster ON dbo.SupplierBill.SupplierNo = dbo.SupplierMaster.SupplierNo WHERE ((dbo.SupplierMaster.Name = '" + supplier + "') AND(CONVERT(DateTime, dbo.SupplierBill.Date, 103) >= CONVERT(DateTime, '" + from + "', 103)) AND(CONVERT(DateTime, dbo.SupplierBill.Date,103) <= CONVERT(DateTime, '" + to + "', 103))) AND ((dbo.BillItem.CGST='" + Sper + "') AND  (dbo.BillItem.IGST='" + Iper + "')) AND(dbo.SupplierBill.permanentdelete = 0) AND (dbo.SupplierBill.Type = 'GST')";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        //Total GST All Slab
        public DataTable SupplierGSTReport(string from, string to, string Sper, string Iper)
        {
            string str = "SELECT SUM(CONVERT(Decimal(10, 2), dbo.BillItem.TotalPrice)) AS Taxable, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.CGSTAmt)) AS CGST, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.SGSTAmt)) AS SGST,  SUM(CONVERT(Decimal(10, 2), dbo.BillItem.IGSTAmt)) AS IGST FROM dbo.BillItem INNER JOIN dbo.SupplierBill ON dbo.BillItem.PurchaseRef = dbo.SupplierBill.RefrenceNo WHERE((CONVERT(DateTime, dbo.SupplierBill.Date, 103) >= CONVERT(DateTime, '" + from+"', 103)) AND(CONVERT(DateTime, dbo.SupplierBill.Date, 103) <= CONVERT(DateTime, '"+to+"', 103))) AND((dbo.BillItem.CGST = '"+Sper+"') or (dbo.BillItem.IGST = '"+Iper+"')) AND (dbo.SupplierBill.permanentdelete = 0) AND(dbo.SupplierBill.Type = 'GST')";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }


        //Total GST Zero Slab
        public DataTable SupplierGSTReportZerPer(string from, string to, string Sper, string Iper)
        {
            string str = "SELECT SUM(CONVERT(Decimal(10, 2), dbo.BillItem.TotalPrice)) AS Taxable, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.CGSTAmt)) AS CGST, SUM(CONVERT(Decimal(10, 2), dbo.BillItem.SGSTAmt)) AS SGST,  SUM(CONVERT(Decimal(10, 2), dbo.BillItem.IGSTAmt)) AS IGST FROM dbo.BillItem INNER JOIN dbo.SupplierBill ON dbo.BillItem.PurchaseRef = dbo.SupplierBill.RefrenceNo WHERE((CONVERT(DateTime, dbo.SupplierBill.Date, 103) >= CONVERT(DateTime, '" + from + "', 103)) AND(CONVERT(DateTime, dbo.SupplierBill.Date, 103) <= CONVERT(DateTime, '" + to + "', 103))) AND((dbo.BillItem.CGST = '" + Sper + "') AND (dbo.BillItem.IGST = '" + Iper + "')) AND(dbo.SupplierBill.permanentdelete = 0) AND(dbo.SupplierBill.Type = 'GST')";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetSupplierBill(string from, string to)
        {
            DataTable dt;
            string str = "SELECT dbo.SupplierMaster.Name, dbo.SupplierMaster.GSTIN, dbo.SupplierBill.RefrenceNo,dbo.SupplierBill.BillNo, dbo.SupplierBill.Amount,dbo.SupplierBill.Date, dbo.SupplierBill.CGST, dbo.SupplierBill.SGST, dbo.SupplierBill.IGST, dbo.SupplierBill.GrandTotal, dbo.SupplierBill.State FROM dbo.SupplierMaster INNER JOIN dbo.SupplierBill ON dbo.SupplierMaster.SupplierNo = dbo.SupplierBill.SupplierNo WHERE(CONVERT(DateTime, dbo.SupplierBill.Date, 103) >= CONVERT(DateTime, '" + from+"', 103)) AND(CONVERT(DateTime, dbo.SupplierBill.Date, 103) <= CONVERT(DateTime, '"+to+ "', 103)) AND (dbo.SupplierBill.permanentdelete = 0) GROUP BY dbo.SupplierMaster.Name, dbo.SupplierMaster.GSTIN, dbo.SupplierBill.RefrenceNo, dbo.SupplierBill.Amount, dbo.SupplierBill.CGST, dbo.SupplierBill.SGST, dbo.SupplierBill.IGST, dbo.SupplierBill.GrandTotal, dbo.SupplierBill.State,dbo.SupplierBill.BillNo,dbo.SupplierBill.Date";
            dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetSupplierGSTBill(string from, string to)
        {
            DataTable dt;
            string str = "SELECT dbo.SupplierMaster.Name, dbo.SupplierMaster.GSTIN, dbo.SupplierBill.RefrenceNo,dbo.SupplierBill.BillNo, dbo.SupplierBill.Amount,dbo.SupplierBill.Date, dbo.SupplierBill.CGST, dbo.SupplierBill.SGST, dbo.SupplierBill.IGST, dbo.SupplierBill.GrandTotal, dbo.SupplierBill.State FROM dbo.SupplierMaster INNER JOIN dbo.SupplierBill ON dbo.SupplierMaster.SupplierNo = dbo.SupplierBill.SupplierNo WHERE(CONVERT(DateTime, dbo.SupplierBill.Date, 103) >= CONVERT(DateTime, '" + from + "', 103)) AND(CONVERT(DateTime, dbo.SupplierBill.Date, 103) <= CONVERT(DateTime, '" + to + "', 103)) AND (dbo.SupplierBill.permanentdelete = 0) AND (dbo.SupplierBill.Type= 'GST') GROUP BY dbo.SupplierMaster.Name, dbo.SupplierMaster.GSTIN, dbo.SupplierBill.RefrenceNo, dbo.SupplierBill.Amount, dbo.SupplierBill.CGST, dbo.SupplierBill.SGST, dbo.SupplierBill.IGST, dbo.SupplierBill.GrandTotal, dbo.SupplierBill.State,dbo.SupplierBill.BillNo,dbo.SupplierBill.Date";
            dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetBillItem(string RefrenceNO)
        {
            DataTable dt = _sql.GetDataTable("select * from BillItem Where PurchaseRef ='" + RefrenceNO + "'");
            return dt;
        }

        public DataTable GetBillItemAmount(string RefrenceNO)
        {
            DataTable dt = _sql.GetDataTable("SELECT SUM(CONVERT(Decimal, dbo.BillItem.CGSTAmt)) AS CGST, SUM(CONVERT(Decimal, dbo.BillItem.SGSTAmt)) AS SGST, SUM(CONVERT(Decimal, dbo.BillItem.IGSTAmt)) AS IGST,  SUM(CONVERT(Decimal, dbo.BillItem.SellingPrice)) AS Selling, SUM(CONVERT(Decimal, dbo.BillItem.Price)) AS Price FROM dbo.BillItem INNER JOIN dbo.SupplierBill ON dbo.BillItem.PurchaseRef = dbo.SupplierBill.RefrenceNo INNER JOIN dbo.SupplierMaster ON dbo.SupplierBill.SupplierNo = dbo.SupplierMaster.SupplierNo WHERE(dbo.SupplierBill.RefrenceNo = '"+RefrenceNO+"')");
            return dt;
        }

        public DataTable GetPurchaseBillItem(string RefrenceNo)
        {
            DataTable dt;
            string str = "select Category,SubCategory,Size,Qty from BillItem where PurchaseRef = '" + RefrenceNo+ "' and PermanentDelete='0' ";
            dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetPurchaseBill()
        {
            DataTable dt;
            string str = "SELECT dbo.SupplierMaster.SupplierNo, dbo.SupplierBill.BillNo, dbo.SupplierBill.Date, dbo.SupplierBill.Amount, dbo.SupplierBill.CGST, dbo.SupplierBill.SGST, dbo.SupplierBill.IGST, dbo.SupplierBill.GrandTotal, dbo.SupplierBill.State,   dbo.SupplierBill.RefrenceNo, dbo.SupplierMaster.Name FROM dbo.SupplierBill INNER JOIN dbo.SupplierMaster ON dbo.SupplierBill.SupplierNo = dbo.SupplierMaster.SupplierNo WHERE(dbo.SupplierBill.Type = 'GST')";
            dt = _sql.GetDataTable(str);
            return dt;
        }
       

        public string GetAllHSNPurchase(string Refrence)
        {
            string AllHSN = "";
            string str = "Select  distinct HSN from BillItem where PurchaseRef = '" + Refrence + "'";
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

        public DataTable GetSupplierDetailsFromBill(string BillNo)
        {
            DataTable dt;
            string str = "SELECT dbo.SupplierBill.BillNo, dbo.SupplierBill.Date, dbo.SupplierBill.Amount, dbo.SupplierBill.CGST, dbo.SupplierBill.SGST, dbo.SupplierMaster.Name, dbo.SupplierMaster.state, dbo.SupplierMaster.ContactNo, dbo.SupplierMaster.Address, dbo.SupplierMaster.PanNo, dbo.SupplierMaster.GSTIN, dbo.SupplierMaster.City, dbo.SupplierBill.IGST, dbo.SupplierBill.State AS Expr1, dbo.SupplierBill.GrandTotal FROM dbo.SupplierMaster INNER JOIN dbo.SupplierBill ON dbo.SupplierMaster.SupplierNo = dbo.SupplierBill.SupplierNo WHERE(dbo.SupplierBill.RefrenceNo = '" + BillNo + "')";
            dt = _sql.GetDataTable(str);
            return dt; 
        }

        public DataTable GetPurchaseBillByAccNo(string Accno)
        {
            DataTable dt;
            string str = "select * from SupplierBill where SupplierNo='"+Accno+"'";
            dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetSupplierFromBillNo(string BillNo)
        {
            DataTable dt;
            string str = "SELECT dbo.SupplierBill.SupplierNo, dbo.SupplierMaster.Name, dbo.SupplierMaster.SupplierNo AS Expr1, dbo.SupplierMaster.state, dbo.SupplierMaster.Address, dbo.SupplierMaster.ContactNo, dbo.SupplierMaster.PanNo, dbo.SupplierMaster.GSTIN, dbo.SupplierMaster.City FROM dbo.SupplierBill INNER JOIN dbo.SupplierMaster ON dbo.SupplierBill.SupplierNo = dbo.SupplierMaster.SupplierNo where dbo.SupplierBill.BillNo='" + BillNo+"'";
            dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetSupplierFromAccNo(string AccNo)
        {

            DataTable dt;
            string str1 = "Select * from SupplierBill where SupplierNo='"+AccNo+"'";
            dt = _sql.GetDataTable(str1);
            return dt;
        }

        public DataTable GetSupplierPaymentByAccNo(string AccNo)
        {

            DataTable dt;
            string str1 = "Select * from Payment where Type='Supplier' and Id='"+AccNo+"'";
            dt = _sql.GetDataTable(str1);
            return dt;
        }

    }
}
