using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PrimeSolutions.Library
{
    class cls_ServiceCommon
    {
        clsCommon _common = new clsCommon();
        SaleCommon _sale = new SaleCommon();
        SQLHelper _sql = new SQLHelper();

        public DataTable GetService(string from, string to)
        {
            string str= "SELECT dbo.CustomerMaster.CustomerName, dbo.CustomerMaster.Address, dbo.CustomerMaster.ContactNo, dbo.CustomerMaster.State, dbo.CustomerMaster.City, dbo.Maintenance.Date, dbo.Maintenance.CustomerId, dbo.Maintenance.Maintain, dbo.Maintenance.Item,dbo.Maintenance.ServiceID,dbo.Maintenance.MaintainDate FROM dbo.CustomerMaster INNER JOIN dbo.Maintenance ON dbo.CustomerMaster.CustId = dbo.Maintenance.CustomerId WHERE(CONVERT(DateTime, dbo.Maintenance.MaintainDate, 103) >= CONVERT(DateTime, '" + from+"', 103)) AND(CONVERT(DateTime, dbo.Maintenance.MaintainDate, 103) <= CONVERT(DateTime, '"+to+"', 103))";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public void AddMaintain(string date, string Item, string MaintainDate,string CustId)
        {
            string ServiceId = _sql.GetMaxID("SR", "0");
            string str = "Insert Into Maintenance (CustomerId, Date, Item,MaintainDate,ServiceID) VALUES ('" + CustId + "','"+date+"','"+Item+"','"+MaintainDate+"','"+ServiceId+"')";
            _sql.ExecuteScalar(str);
        }

        public DataTable GetServiceId()
        {
            string str = "Select Distinct ServiceID from Maintenance";
            return _sql.GetDataTable(str);
        }

        public DataTable GetCustFromServiceId(string ServiceID)
        {
            string str = "SELECT dbo.CustomerMaster.CustId, dbo.CustomerMaster.CustomerName, dbo.CustomerMaster.Address, dbo.CustomerMaster.ContactNo, dbo.CustomerMaster.State, dbo.CustomerMaster.City,dbo.Maintenance.Date, dbo.Maintenance.Maintain, dbo.Maintenance.Item, dbo.Maintenance.MaintainDate, dbo.Maintenance.ServiceID, dbo.Maintenance.Status FROM dbo.CustomerMaster INNER JOIN dbo.Maintenance ON dbo.CustomerMaster.CustId = dbo.Maintenance.CustomerId WHERE(dbo.Maintenance.ServiceID = '"+ServiceID+"')";
            return _sql.GetDataTable(str);
        }
         
        
    }
}
