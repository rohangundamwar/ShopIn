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
        ErrorLog _error = new ErrorLog();

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



        public void CustomerBill(string BillNo, string Type)
        {
            int Copies = _objPrinterSetting.copies; 
            string crname;
            crname = "Select SaleBill from CrystalReport Where srno='1'";
            DataTable dt_crname = _objsqlhelper.GetDataTable(crname);
            ReportDocument _objReport = new ReportDocument();

            _objReport.Load(Environment.CurrentDirectory + "\\" + dt_crname.Rows[0]["SaleBill"].ToString());

            string company = "SELECT * from CompanyMaster";
            DataTable dt_CompanyInfo = _objsqlhelper.GetDataTable(company);
            _objReport.Database.Tables["CompanyInfo"].SetDataSource(dt_CompanyInfo);

            string BillingDetails = "Select * from CustomerBill Where BillNo='" + BillNo + "'";
            DataTable dt_BillingDetails = _objsqlhelper.GetDataTable(BillingDetails);
            _objReport.Database.Tables["CustomerBill"].SetDataSource(dt_BillingDetails);

            DataTable dt_CustomerInfo = _sales.GetCustomerByBill(BillNo);
            _objReport.Database.Tables["CustomerDetails"].SetDataSource(dt_CustomerInfo);

            DataTable dt_ItemsDetails = _sales.GetBillItem(BillNo);
            _objReport.Database.Tables["BillItem"].SetDataSource(dt_ItemsDetails);


            DataTable dt_Payment = _a.getpaymentByBill(BillNo);
            _objReport.Database.Tables["Payment"].SetDataSource(dt_Payment);

            try
            {
                string Balance = Convert.ToString(_sales.GetBalance(dt_CustomerInfo.Rows[0]["CustomerName"].ToString()));
                _objReport.SetParameterValue("Balance", Balance);
            }
            catch (Exception ex)
            {
                _error.AddException(ex, "ReportViewer");
                MessageBox.Show(ex.ToString());
            }

            try
            {
                double inword = Convert.ToDouble(dt_BillingDetails.Rows[0]["GrandAmt"].ToString());
                inword = Math.Round(inword);
                int number = Convert.ToInt32(inword);
                string inwordsString = _objCommon.NumberToWords(number);
                _objReport.SetParameterValue("inwords", inwordsString);
            }
            catch (Exception ex)
            {
                _error.AddException(ex, "ReportViewer");
                MessageBox.Show(ex.ToString());
            }

            if (Type == "Print")
            {
                if (_objPrinterSetting.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _objReport.PrintOptions.PrinterName = _objPrinterSetting.PrinterName;
                        _objReport.PrintToPrinter(Copies, true, 0, 0);
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
                    crReportViewer.Show();
                    return;
                }

            }
            else
            {
                crReportViewer.ReportSource = _objReport;
                crReportViewer.Show();
                return;
            }
        }

        public void PrintBarcode(string BillNo, int i)
        {

            _objsqlhelper.ExecuteScalar("Update PrintQue SET PrintQue = '" + BillNo + "' Where SrNo='1'");
            BarTender.Application btApp;
            BarTender.Messages btMsgs;
            BarTender.Database btDb;
            // Declare a BarTender document variable
            BarTender.Format btFormat;
            // Declare a BarTender query prompt variable
            BarTender.QueryPrompt btQueryPrompt;
            // Create a new instance of BarTender
            btApp = new BarTender.Application();
            // Set the BarTender application visible
            btApp.Visible = true;
            // Open a BarTender document
            btFormat = btApp.Formats.Open(Environment.CurrentDirectory + "\\" + "BarcodeA4");
            btDb = btFormat.Databases.GetDatabase(1);
            // Select the query prompt
            btQueryPrompt = btFormat.Databases.QueryPrompts.GetQueryPrompt("Item");
            btFormat.Print("Job" + (i + 1), false, -1, out btMsgs);
            // End the BarTender process
            btApp.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges);
        } 
            private void frm_ReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
    }


