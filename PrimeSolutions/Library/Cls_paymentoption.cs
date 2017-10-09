using PrimeSolutions.Common;
using System;

namespace PrimeSolutions.Library
{
    public class Cls_paymentoption
    {
        SQLHelper _objsqlhelper = new SQLHelper();

        public int cashsave(string billno, string paytype, string amount, string pay_datetime, string bankname, string cashchequeno, string Narration, CustomerType sCustomerType, string AccountNo)
        {
            string str = "insert into PaymentDetail(Bill_no,CustomerType,Payment_Type,Received_Amount,Pay_Date,Bank_name,Card_chequeno,Narration,AccountNo) output inserted.PaymentID values('" + billno + "','" + sCustomerType + "', '" + paytype + "','" + amount + "','" + pay_datetime + "','" + bankname + "','" + cashchequeno + "','" + Narration + "','" + AccountNo + "')";
            return Convert.ToInt32(_objsqlhelper.ExecuteScalar(str));
        }

        public void updatePaymentDetails(string paytype, string amount, string pay_datetime, string bankname, string cashchequeno, string Narration, string ColumnName, string ColumnValue)
        {
            string str = "Update PaymentDetail set Payment_Type = '" + paytype + "', Received_Amount = '" + amount + "', Pay_Date = '" + pay_datetime + "', Bank_name = '" + bankname + "', Card_chequeno = '" + cashchequeno + "', Narration = '" + Narration + "' where  " + ColumnName + "=" + ColumnValue + "  AND (PermanentDelete = '" + false + "')";
            _objsqlhelper.ExecuteSql(str);
        }

        public void updatePaymentDetails(string paytype, string amount, string pay_datetime, string bankname, string cashchequeno, string Narration, int? PBillID = null, int? SBillID = null, int? ISBillID = null, int? IMBillID = null)
        {
            string str = "";
            if (PBillID != null)
            {
                str = "Update PaymentDetail set Payment_Type='" + paytype + "',Received_Amount='" + amount + "',Pay_Date='" + pay_datetime + "',Bank_name='" + bankname + "',Card_chequeno='" + cashchequeno + "',Narration='" + Narration + "' where PBillID='" + PBillID + "'  AND (PermanentDelete='" + false + "')";
            }
            else if (SBillID != null)
            {
                str = "Update PaymentDetail set Payment_Type='" + paytype + "',Received_Amount='" + amount + "',Pay_Date='" + pay_datetime + "',Bank_name='" + bankname + "',Card_chequeno='" + cashchequeno + "',Narration='" + Narration + "' where SBillID='" + SBillID + "'  AND (PermanentDelete='" + false + "')";
            }
            else if (ISBillID != null)
            {
                str = "Update PaymentDetail set Payment_Type='" + paytype + "',Received_Amount='" + amount + "',Pay_Date='" + pay_datetime + "',Bank_name='" + bankname + "',Card_chequeno='" + cashchequeno + "',Narration='" + Narration + "' where ISBillID='" + ISBillID + "'  AND (PermanentDelete='" + false + "')";
            }
            else if (IMBillID != null)
            {
                str = "Update PaymentDetail set Payment_Type='" + paytype + "',Received_Amount='" + amount + "',Pay_Date='" + pay_datetime + "',Bank_name='" + bankname + "',Card_chequeno='" + cashchequeno + "',Narration='" + Narration + "' where IMBillID='" + IMBillID + "'  AND (PermanentDelete='" + false + "')";
            }
            _objsqlhelper.ExecuteSql(str);
        }

        public void updateDiamondPaymentDetails(string PBillID, string paytype, string amount, string pay_datetime, string bankname, string cashchequeno, string Narration)
        {
            string str = "Update PaymentDetail set Payment_Type='" + paytype + "',Received_Amount='" + amount + "',Pay_Date='" + pay_datetime + "',Bank_name='" + bankname + "',Card_chequeno='" + cashchequeno + "',Narration='" + Narration + "' where DPBillID='" + PBillID + "'  AND (PermanentDelete='" + false + "')";
            _objsqlhelper.ExecuteSql(str);
        }

        public void updateDiamondSalePaymentDetails(string SBillID, string paytype, string amount, string pay_datetime, string bankname, string cashchequeno, string Narration)
        {
            string str = "Update PaymentDetail set Payment_Type='" + paytype + "',Received_Amount='" + amount + "',Pay_Date='" + pay_datetime + "',Bank_name='" + bankname + "',Card_chequeno='" + cashchequeno + "',Narration='" + Narration + "' where DSBillID='" + SBillID + "'  AND (PermanentDelete='" + false + "')";
            _objsqlhelper.ExecuteSql(str);
        }

        //Imitation Payment

        public void cashsaveImitation(string billno, string paytype, string amount, string pay_datetime, string bankname, string cashchequeno, string Narration)
        {
            string str = "insert into tbl_ImitationPaymentDetail(Bill_no,Payment_Type,Received_Amount,Pay_Date,Bank_name,Card_chequeno,Narration) values('" + billno + "','" + paytype + "','" + amount + "','" + pay_datetime + "','" + bankname + "','" + cashchequeno + "','" + Narration + "')";
            _objsqlhelper.ExecuteSql(str);
        }



    }
}
