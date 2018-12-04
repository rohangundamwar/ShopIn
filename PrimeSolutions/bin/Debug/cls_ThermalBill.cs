using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;
using PrimeSolutions.Library;
using System.Data;

namespace PrimeSolutions.bin.Debug
{
    class cls_ThermalBill
    {
        string BillNo;
        SaleCommon _Sale = new SaleCommon();
        Setting_Value _s = new Setting_Value();
        AllClassFile _a = new AllClassFile();
        DataTable dtSett;

        public cls_ThermalBill(string Bill)
        {
            BillNo = Bill;
            PrintBillThermal(BillNo);
        }

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
            string CustName = "";
            string CustCont = "";
            DataTable BillDetail = _Sale.GetBillDetails(Billx);
            DataTable BillItem = _Sale.GetBillItem(Billx, "Sale");
            DataTable company = _Sale.GetCompanydetails();
            DataTable Customer = _Sale.GetCustomerByBill(Billx);
            dtSett = _a.getallssetting();

            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 10);
            float fontHeight = font.GetHeight();
            int startX = 0;
            int startY = 0;
            int Offset = 20;

            //e.PageSettings.PaperSize.Width = 50;

            //Company Details//Header
            graphics.DrawString(company.Rows[0]["Name"].ToString(), new Font("Arial", 10,FontStyle.Bold),
                                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("  GST No: " + company.Rows[0]["GSTIN"].ToString(), new Font("Arial",8),
                        new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 15;

            string underLine = "---------------------------------------------";
            graphics.DrawString(underLine, new Font("Arial", 8),
            new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 15;
            //Customer&BillDetails
            graphics.DrawString("   BillNo: " + BillDetail.Rows[0]["BillNo"].ToString(),
            new Font("Arial", 8),
            new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 15;
            if (Customer.Rows.Count == 1)
            {
                CustName = Customer.Rows[0]["CustomerName"].ToString();
                CustCont = Customer.Rows[0]["ContactNo"].ToString();
                string Cust = CustName + " \n " + CustCont;
                //graphics.DrawString("  " + CustName, new Font("Arial", 8),
                //        new SolidBrush(Color.Black), startX, startY + Offset);
                //Offset = Offset + 20;
                graphics.DrawString("   " + Cust, new Font("Arial", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
            }

            graphics.DrawString(underLine, new Font("Arial", 8),new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString(" Item Desc \n Rate     Qty     SubTotal     Disc", new Font("Arial", 8), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 30;

            //BillItem
            for (int i = 0; i < BillItem.Rows.Count; i++)
            {
                j = i + 1;
                graphics.DrawString(j + ") " + BillItem.Rows[i]["Category"].ToString() + " " + BillItem.Rows[i]["SubCategory"].ToString(),
                new Font("Arial", 8),new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 10;
                graphics.DrawString("₹" + BillItem.Rows[i]["FinalAmount"].ToString()+ "       " + BillItem.Rows[i]["Qty"].ToString()+ "       ₹" + BillItem.Rows[i]["ActualPrice"].ToString() +"      "+ BillItem.Rows[i]["DiscPer"].ToString() + "%", new Font("Arial", 8),new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 10;
                if (Convert.ToDecimal(BillItem.Rows[i]["Discper"]) > 0)
                {
                    graphics.DrawString("₹(" + BillItem.Rows[i]["TotalPrice"].ToString()+"+"+BillItem.Rows[i]["CGSTAmt"].ToString()+ "+" + BillItem.Rows[i]["SGSTAmt"].ToString() + ")     D:₹" + BillItem.Rows[i]["DiscAmt"].ToString() + "        ₹" + BillItem.Rows[i]["SellingPrice"].ToString(), new Font("Arial", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                    Offset = Offset + 15;
                }
                
            }

            graphics.DrawString(underLine, new Font("Arial", 8),
                        new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            //BillPayDetails
            graphics.DrawString("Bill Amount: ₹ " + BillDetail.Rows[0]["Amount"].ToString(), new Font("Arial", 8),
                        new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 12;
            graphics.DrawString("CGST: ₹" + BillDetail.Rows[0]["CGST"].ToString()+ "   "+ "SGST: ₹" + BillDetail.Rows[0]["SGST"].ToString(), new Font("Arial", 8),new SolidBrush(Color.Black), startX, startY + Offset);
            
            Offset = Offset + 12;

            graphics.DrawString("Rounding Off: ₹ " + BillDetail.Rows[0]["CashDiscount"].ToString(), new Font("Arial", 8),
                        new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 12;

            graphics.DrawString("Total Amount: ₹ " + BillDetail.Rows[0]["BillAmount"].ToString(), new Font("Arial", 8),
                        new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 12;

            graphics.DrawString(underLine, new Font("Arial", 8),
                        new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 12;

            //Footer
            graphics.DrawString("      Thank You!  Visit Again !", new Font("Arial", 8),
                        new SolidBrush(Color.Black), startX, startY + Offset);

        }
    }
}
