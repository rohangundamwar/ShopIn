using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeSolutions.Library
{
    class CreditDebit
    {
        Cls_BalanceSheet _objCeditDebit = new Cls_BalanceSheet();

        public void insertcreditDebitPurchaseWithPayment(string customerLedgerID, string VouchertypeID, string sbillno, string transactionLedgerID, string PaidAmount, string Date, string narration, string SupplierName)
        {
            _objCeditDebit.insertCreditDebitDetails(legderid: customerLedgerID, debit: PaidAmount, credit: "0", ChequeNo: null, chequeDate: null, date: Date, type: "Dr", FromAccount: "Cash/Bank", Narration: narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
            _objCeditDebit.insertCreditDebitDetails(legderid: transactionLedgerID, debit: "0", credit: PaidAmount, ChequeNo: null, chequeDate: null, date: Date, type: "Cr", FromAccount: SupplierName, Narration: narration, VoucherTypeID: VouchertypeID, VoucherNo: sbillno);
        }
    }
}
