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
            string crname;
            crname = "Select SaleBill from CrystalReport Where Type='GST'";
            string str_crname = _objsqlhelper.ExecuteScalar(crname);
            ReportDocument _objReport = new ReportDocument();

            _objReport.Load(Environment.CurrentDirectory + "\\" + str_crname);

            string company = "SELECT * from CompanyMaster";
            DataTable dt_CompanyInfo = _objsqlhelper.GetDataTable(company);
            _objReport.Database.Tables["CompanyInfo"].SetDataSource(dt_CompanyInfo);

            string BillingDetails = "Select * from CustomerBill Where BillNo='" + BillNo + "'";
            DataTable dt_BillingDetails = _objsqlhelper.GetDataTable(BillingDetails);
            _objReport.Database.Tables["CustomerBill"].SetDataSource(dt_BillingDetails);

            DataTable dt_CustomerInfo = _sales.GetCustomerByBill(BillNo);
            _objReport.Database.Tables["CustomerDetails"].SetDataSource(dt_CustomerInfo);

            DataTable dt_ItemsDetails = _sales.GetBillItem(BillNo,"Sale");
            _objReport.Database.Tables["BillItem"].SetDataSource(dt_ItemsDetails);
            string qty = Convert.ToString(_common.sumDataTableColumn(dt_ItemsDetails, "Qty")); 

            DataTable dt_Payment = _a.getpaymentByBill(BillNo, "Sale");
            _objReport.Database.Tables["Payment"].SetDataSource(dt_Payment);

            try
            {
                string Balance = Convert.ToString(_sales.GetBalance(dt_CustomerInfo.Rows[0]["CustomerName"].ToString(),"Sale"));
                _objReport.SetParameterValue("Balance", Balance);
            }
            catch (Exception ex)
            {
                _error.AddException(ex, "ReportViewer");
                MessageBox.Show(ex.ToString());
            }

            try
            {
                double inword = Convert.ToDouble(dt_BillingDetails.Rows[0]["BillAmount"].ToString());
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

            try
            {   
                _objReport.SetParameterValue("Qty", qty);
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
                        int Copies = _objPrinterSetting.copies;

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

        public void ServiceInvoice(string ServiceID, string Type)
        {
            string crname;
            crname = "Select SaleBill from CrystalReport Where Type='ServiceInvoice'";
            string  dt_crname = _objsqlhelper.ExecuteScalar(crname);
            ReportDocument _objReport = new ReportDocument();

            _objReport.Load(Environment.CurrentDirectory + "\\" + dt_crname);

            string company = "SELECT * from CompanyMaster";
            DataTable dt_CompanyInfo = _objsqlhelper.GetDataTable(company);
            _objReport.Database.Tables["CompanyInfo"].SetDataSource(dt_CompanyInfo);

            string BillingDetails = "Select * from CustomerBill Where BillNo='" + ServiceID + "'";
            DataTable dt_BillingDetails = _objsqlhelper.GetDataTable(BillingDetails);
            _objReport.Database.Tables["CustomerBill"].SetDataSource(dt_BillingDetails);

            DataTable dt_CustomerInfo = _sales.GetCustomerByBill(ServiceID);
            _objReport.Database.Tables["CustomerDetails"].SetDataSource(dt_CustomerInfo);

            DataTable dt_ItemsDetails = _sales.GetBillItem(ServiceID, "Sale");
            _objReport.Database.Tables["BillItem"].SetDataSource(dt_ItemsDetails);
            string qty = Convert.ToString(_common.sumDataTableColumn(dt_ItemsDetails, "Qty"));


            DataTable dt_Payment = _a.getpaymentByBill(ServiceID, "Sale");
            _objReport.Database.Tables["Payment"].SetDataSource(dt_Payment);

            
                _objReport.SetParameterValue("Balance", "0");


            try
            {
                double inword = Convert.ToDouble(dt_BillingDetails.Rows[0]["BillAmount"].ToString());
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

            try
            {
                _objReport.SetParameterValue("Qty", qty);
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
                        int Copies = _objPrinterSetting.copies;

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

        public void CustomerBillEst(string BillNo, string Type)
        {
            string crname;
            crname = "Select SaleBill from CrystalReport Where Type='Estimate'";
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

            DataTable dt_ItemsDetails = _sales.GetBillItem(BillNo,"Sale");
            _objReport.Database.Tables["BillItem"].SetDataSource(dt_ItemsDetails);
            string qty = Convert.ToString(_common.sumDataTableColumn(dt_ItemsDetails, "Qty"));


            DataTable dt_Payment = _a.getpaymentByBill(BillNo, "Sale");
            _objReport.Database.Tables["Payment"].SetDataSource(dt_Payment);

            try
            {
                string Balance = Convert.ToString(_sales.GetBalance(dt_CustomerInfo.Rows[0]["CustomerName"].ToString(),"Sale"));
                _objReport.SetParameterValue("Balance", Balance);
            }
            catch (Exception ex)
            {
                _error.AddException(ex, "ReportViewer");
                MessageBox.Show(ex.ToString());
            }

            try
            {
                double inword = Convert.ToDouble(dt_BillingDetails.Rows[0]["BillAmount"].ToString());
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

            try
            {
                _objReport.SetParameterValue("Qty", qty);
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
                        int Copies = _objPrinterSetting.copies;

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

        public void SupplierBill(string RefrenceNo, string Type)
        {
            string SqlCrname;
            SqlCrname = "Select SaleBill from CrystalReport Where Type='SupplierPurchase'";
            string crname = _objsqlhelper.ExecuteScalar(SqlCrname);
            ReportDocument _objReport = new ReportDocument();

            _objReport.Load(Environment.CurrentDirectory + "\\" + crname);

            string company = "SELECT * from CompanyMaster";
            DataTable dt_CompanyInfo = _objsqlhelper.GetDataTable(company);
            _objReport.Database.Tables["CompanyInfo"].SetDataSource(dt_CompanyInfo);

            string BillingDetails = "Select * from SupplierBill Where RefrenceNo='" + RefrenceNo + "'";
            DataTable dt_BillingDetails = _objsqlhelper.GetDataTable(BillingDetails);
            _objReport.Database.Tables["SupplierBill"].SetDataSource(dt_BillingDetails);

            DataTable dt_Supplier_Info = _sales.GetSupplierByBill(RefrenceNo);
            _objReport.Database.Tables["SupplierDetails"].SetDataSource(dt_Supplier_Info);

            DataTable dt_ItemsDetails = _sales.GetBillItem(dt_BillingDetails.Rows[0]["BillNo"].ToString(), "Purchase");
            _objReport.Database.Tables["BillItem"].SetDataSource(dt_ItemsDetails);
            string qty = Convert.ToString(_common.sumDataTableColumn(dt_ItemsDetails, "Qty"));

            DataTable dt_Payment = _a.getpaymentByBill(RefrenceNo, "Supplier");
            _objReport.Database.Tables["Payment"].SetDataSource(dt_Payment);

            try
            {
                string Balance = Convert.ToString(_sales.GetBalance(dt_Supplier_Info.Rows[0]["Name"].ToString(),"Purchase"));
                _objReport.SetParameterValue("Balance", Balance);
            }
            catch (Exception ex)
            {
                _error.AddException(ex, "ReportViewer");
                MessageBox.Show(ex.ToString());
            }

            try
            {
                double inword = Convert.ToDouble(dt_BillingDetails.Rows[0]["Amount"].ToString());
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

            try
            {
                _objReport.SetParameterValue("Qty", qty);
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
                        int Copies = _objPrinterSetting.copies;

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

        

        public void SaleLedger(DataTable sale,DataTable pay,string Bill,string payment,string balance)
        {
            ReportDocument _objReport = new ReportDocument();
            _objReport.Load(Environment.CurrentDirectory + "\\SaleLedger.rpt" );

            string company = "SELECT * from CompanyMaster";
            DataTable dt_CompanyInfo = _objsqlhelper.GetDataTable(company);
            _objReport.Database.Tables["CompanyInfo"].SetDataSource(dt_CompanyInfo);

            string BillNo = sale.Rows[0]["BillNo"].ToString();
            DataTable dt_CustomerInfo = _sales.GetCustomerByBill(BillNo);
            _objReport.Database.Tables["CustomerDetails"].SetDataSource(dt_CustomerInfo);

            //saleBillLedger
            _objReport.Subreports["SaleBillLedger.rpt"].Database.Tables["sale"].SetDataSource(sale);

            //PayLedger
            _objReport.Subreports["PayLedger.rpt"].Database.Tables["Payment"].SetDataSource(pay);

            //parameters
            _objReport.SetParameterValue("TotalSale", Bill);
            _objReport.SetParameterValue("TotalPay", payment);
            _objReport.SetParameterValue("Balance", balance);

            crReportViewer.ReportSource = _objReport;
            crReportViewer.Show();
        }
        

        private void frm_ReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
    }


