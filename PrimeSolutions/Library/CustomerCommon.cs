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

        public void AddCustomerDetails(string CustId,string Name,string Address,string ContactNo,string Pan,string Gstin, string state,string city,string Opening)
        {
            string str = "Insert into CustomerMaster(CustId,CustomerName,Address,ContactNo,PanNo,GSTIN,State,City,Opening) VALUES('" + CustId+"','"+Name+"','"+Address+"','"+ContactNo+"','"+Pan+"','"+Gstin+"','"+state+"','"+city+"','"+Opening+"') ";
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
            string str = "select * from CustomerMaster ";
            DataTable dt;
            dt = _Sql.GetDataTable(str);
            return dt;
        }

        public string GetCustomerId(string Custname)
        {
            string str = "select CustId from CustomerMaster where CustomerName='" + Custname + "'";
            string name = _Sql.ExecuteScalar(str);
            return name;
        }

        public void SetOpening(string CustId, string Opening)
        {
            string str = "Update CustomerMaster set Opening='" + Opening + "'where CustId='" + CustId + "'";
            _Sql.ExecuteScalar(str);
        }

        public void UpdateCustomer(string AccNo,string Name,string Address,string ContactNo,string PanNo,string GSTIN,string State,string City,string Opening)
        {
            string str = "Update CustomerMaster set Opening='" + Opening + "',CustomerName='"+Name+ "',Address='"+Address+ "',ContactNo='"+ContactNo+ "',PanNo='"+PanNo+ "',GSTIN='"+GSTIN+ "',State='"+State+ "',City='"+City+"' where CustId='" + AccNo + "'";
            _Sql.ExecuteScalar(str);
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
