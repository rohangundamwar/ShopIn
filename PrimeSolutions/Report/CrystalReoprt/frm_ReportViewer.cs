using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using CrystalDecisions.CrystalReports.Engine;
using PrimeSolutions.Library;

namespace PrimeSolutions.Report.CrystalReport
{
    public partial class frm_ReportViewer : Form
    {
        public bool printresult { get; set; }
        SQLHelper _objsqlhelper = new SQLHelper();
        clsCommon _objCommon = new clsCommon();
        PrinterSetting _objPrinterSetting = new PrinterSetting();
        clsCommon _common = new clsCommon();
        SaleCommon _sales = new SaleCommon();
        AllClassFile _a = new AllClassFile();
        
        //
        public frm_ReportViewer()
        {
            InitializeComponent();
        }

        public Int32 GetPaperSize(String sPrinterName, String sPaperSizeName)
        {
            PrintDocument docPrintDoc = new PrintDocument();
            docPrintDoc.PrinterSettings.PrinterName = sPrinterName;
            for (int i = 0; i < docPrintDoc.PrinterSettings.PaperSizes.Count; i++)
            {
                int raw = docPrintDoc.PrinterSettings.PaperSizes[i].RawKind;
                if (docPrintDoc.PrinterSettings.PaperSizes[i].PaperName == sPaperSizeName)
                {
                    return raw;
                }
            }
            return 0;
        }
        /// <summary>
        

   
        public void CustomerBill(string BillNo)
        {
            string crname;
            crname = "Select SaleBill from CrystalReport Where srno='1'";
            DataTable dt_crname = _objsqlhelper.GetDataTable(crname);
            ReportDocument _objReport = new ReportDocument();

            _objReport.Load(Environment.CurrentDirectory + "\\" + dt_crname.Rows[0]["SaleBill"].ToString());
            
            string BillDetails = "Select * from CustomerBill Where BillNo='" + BillNo + "'";
            
            string company = "SELECT * from CompanyMaster";

            DataTable dt_ItemsDetails = _sales.GetBillItem(BillNo);
            _objReport.Database.Tables[0].SetDataSource(dt_ItemsDetails);

            DataTable dt_CompanyInfo = _objsqlhelper.GetDataTable(company);
            _objReport.Database.Tables["CompanyInfo"].SetDataSource(dt_CompanyInfo);

            DataTable dt_BillingDetails = _objsqlhelper.GetDataTable(BillDetails);
            _objReport.Database.Tables["CustomerBill"].SetDataSource(dt_BillingDetails);

            DataTable dt_CustomerInfo = _sales.GetCustomerByBill(BillNo);
            _objReport.Database.Tables["CustomerDetails"].SetDataSource(dt_CustomerInfo);

            DataTable dt_PayDetails = _a.getpaymentdetails(dt_CustomerInfo.Rows[0]["CustId"].ToString(), dt_ItemsDetails.Rows[0]["SaleDate"].ToString());
            _objReport.Database.Tables["Payment"].SetDataSource(dt_PayDetails);


            if (_objPrinterSetting.ShowDialog() == DialogResult.OK)
            {
                try
                { 
                    //string inwordsString = _objCommon.NumberToWords(Convert.ToInt32(dt_BillingDetails.Rows[0]["Amount"].ToString())).ToUpper();
                    //_objReport.SetParameterValue("inwords", inwordsString);

                    _objReport.PrintOptions.PrinterName = _objPrinterSetting.PrinterName;
                   
                    _objReport.PrintToPrinter(1, true, 0, 0);
                    printresult = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                if (printresult == true)
                {
                    printresult = false;
                }
            }
            else
            {
                crReportViewer.ReportSource = _objReport;
                return;
            }
        }
        
       
        private void frm_ReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}

