using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace PrimeSolutions.Library
{
    class PurchaseCommon
    {
        SQLHelper _sql = new SQLHelper();
        public DataTable GetStock()
        {
        string str = "Select Distinct category,sub_category,purchase_amt,sale_amt,size from BillItem Where type= 'Purchase'";
            DataTable d1 =  _sql.GetDataTable(str);
            return d1;
        }

        public DataTable GetSupplierBillNo()
        {
            DataTable dt;
            string str = "select distinct BillNo from PurchaseBillMaster";
            dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetPurchaseBillItem(string BillNo)
        {
            DataTable dt;
            string str = "select distinct Category,Sub_Category,Size from BillItem where PurchaseBill = '"+BillNo+"'";
            dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetPurchaseBill()
        {
            DataTable dt;
            string str = "select * from PurchaseBillMaster ";
            dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetSupplierFromBillNo(string BillNo)
        {

            DataTable dt;
            string str = "select AccNo from PurchaseBillMaster where BillNo='"+BillNo+"'";
            string str1 = "Select * from SupplierMaster where AccNO='" + _sql.ExecuteScalar(str) + "'";
            dt = _sql.GetDataTable(str1);
            return dt;
        }

        public DataTable GetSupplierFromAccNo(string AccNo)
        {

            DataTable dt;
            string str1 = "Select * from SupplierMaster where AccNO='"+AccNo+"'";
            dt = _sql.GetDataTable(str1);
            return dt;
        }


    }
}
