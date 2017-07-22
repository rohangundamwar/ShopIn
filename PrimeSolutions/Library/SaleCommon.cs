using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using PrimeSolutions.Library;
namespace PrimeSolutions.Library
{
    public class SaleCommon
    {
        SQLHelper _sql = new SQLHelper();
        AllClassFile _a = new AllClassFile();
        DataTable dtSett;

        string BillNo;
        public void AddBillDetails(string BillNo, string CustomerId, string BillAmt, string VAT, string TotalAmt, string Discount, string date)
        {
            string str = "Insert into SaleBillMaster(BillNo,CustomerId,BillAmount,VAT,TotalAmount,Discount,date)Values('" + BillNo + "','" + CustomerId + "','" + BillAmt + "','" + VAT + "','" + TotalAmt + "','" + Discount + "','" + date + "')";
            _sql.ExecuteSql(str);
        }

        public void UpdateItem(string ItemId, string SaleBill)
        {
            string str = "Update BillItem Set type= 'Sale',SaleBillNo='" + SaleBill + "' Where Barcode='" + ItemId + "'";
            _sql.ExecuteSql(str);
        }

        public void AddItemDetails(string Category, string SubCategory, string Amount, string size, string narration, string BillNo, string AccNo, string date, string Sale)
        {
            string str = "Insert into BillItem(category,sub_category,sale_amt,size,narration,SaleBillNo,AccNo,SoftDate,type) Values('" + Category + "','" + SubCategory + "','" + Amount + "','" + size + "','" + narration + "','" + BillNo + "','" + AccNo + "','" + date + "','" + Sale + "') ";
            _sql.ExecuteSql(str);
        }

        public DataTable GetItemDetails(string Barcode)
        {
            string str = "Select * from BillItem where Barcode = '" + Barcode + "'";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        
         
        private DataTable GetBillDetails(string BillNo)
        {
            string str = "Select * from SaleBillMaster where BillNo = '" + BillNo + "'";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public DataTable GetBillItem(string BillNo)
        {
            string str = "Select * from BillItem where SaleBillNo = '" + BillNo + "'";
            DataTable dt = _sql.GetDataTable(str);
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
            string str1 = "select CustomerId from SaleBillMaster where BillNo = '" + BillNo + "'";
            string CustId = _sql.ExecuteScalar(str1);
            string str2 = "select * from CustomerMaster where CustId = '" + CustId + "'";
            DataTable dt = _sql.GetDataTable(str2);
            return dt;

        }

        public DataTable GetCustomer(string Name)
        {
            string str = "Select * From CustomerMaster where CustomerName = '" + Name + "'";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public void PrintBill(string BillNO)
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
            DataTable BillItem = GetBillItem(Billx);
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

        public DataTable GetCustomerReport(string from, string to)
        {
            string From = "";
            string To = "";
            DateTime date1 = Convert.ToDateTime(from);
            DateTime date2 = Convert.ToDateTime(to);

            while (From == "")
            {
                from = date1.ToString("dd/MM/yyyy");
                string str1 = "select SrNo from SaleBillMaster where date = '" + from + "'";
                From = _sql.ExecuteScalar(str1);
                date1 = date1.AddDays(1);

            }
            while (To == "")
            {
                to = date2.ToString("dd/MM/yyyy");
                string str1 = "select Max(SrNo) from SaleBillMaster where date = '" + to + "'";
                To = _sql.ExecuteScalar(str1);
                date2 = date2.AddDays(-1);
            }

            string str = "Select * From SaleBillMaster where SrNo between '"+From+"' AND '"+ To +"'";
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }

        public string GetCustomerByCustid(string custid)
        {
            string str = "select Name from customermaster where CustId='"+custid+"'";
            string cust = _sql.ExecuteScalar(str);
            return cust;
        }

        public DataTable GetSaleBillData()
        {
            string str = "select Distinct BillNo from SaleBillMaster";
            DataTable Bill = _sql.GetDataTable(str);
            return Bill;
        }

    }
}

