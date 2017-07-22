using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PrimeSolutions.Library
{
    class CustomerCommon
    {
        SQLHelper _Sql = new SQLHelper();

        public void AddCustomerDetails(string CustId,string Name,string Address,string ContactNo)
        {
            string str = "Insert into CustomerMaster(CustId,Name,Address,MobileNo,ContactNo) VALUES('"+CustId+"','"+Name+"','"+Address+"','"+ContactNo+"') ";
            _Sql.ExecuteSql(str);
        }

        public bool checkCustomerAccount(string CustName)
        {
            string str = "SELECT count (*) FROM  CustomerMaster WHERE (CustomerName = '" + CustName + "')";
            int i = Convert.ToInt32(_Sql.ExecuteScalar(str));
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public DataTable GetCustomerDeatils()
        {
            string str = "select CustomerName from CustomerMaster ";
            DataTable dt;
            dt = _Sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetCustomerItemDeatils(string CustId)
        {
            string str1 = "select BillNo from SaleBillMaster where CustomerId='" + CustId + "' ";
            string str2 = _Sql.ExecuteScalar(str1);
            string str = "select * from BillItem where SaleBillNo='"+str2+"'";
            DataTable dt = _Sql.GetDataTable(str);
            dt = _Sql.GetDataTable(str);
            return dt;
        }


    }
}
