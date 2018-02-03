using PrimeSolutions.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions.Report
{
    public partial class frm_MonthlyGSTReport : Form
    {
        clsCommon _common = new clsCommon();
        PurchaseCommon _purchase = new PurchaseCommon();
        SaleCommon _sale = new SaleCommon();
        ErrorLog _error = new ErrorLog();
        public delegate void SendData(DataTable Sale,DataTable Purchase,string Month);

        string first;
        string last;

        DataTable Sale, Purchase;

        public frm_MonthlyGSTReport()
        {
            InitializeComponent();
            
        }

        private void bttn_Generate_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.ParseExact(cmb_month.Text, "MMMM", CultureInfo.InvariantCulture);
            var firstDayOfMonth = new DateTime(Convert.ToInt32(cmb_year.Text), date.Month , 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            first = firstDayOfMonth.ToString("dd/MM/yyyy");
            last = lastDayOfMonth.ToString("dd/MM/yyyy");
            dgv_purchase.Rows.Clear();
            dgv_sale.Rows.Clear();
            GeneratePurchase();
            generateSale();
            Sale = _common.DataGridView2DataTable(dgv_sale, "Sale", 0);
            Purchase = _common.DataGridView2DataTable(dgv_purchase, "Purchase", 0);
        }

        private void frm_MonthlyGSTReport_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int Inow = now.Month;
            if (Inow < 2)
            {
                cmb_month.SelectedIndex = 12-Inow;
            }
            else
            cmb_month.SelectedIndex = Inow-2;
        }

        private void generateSale()
        {
            DataTable DTSale0per = _sale.CustomerGSTReportZeroPer(first, last, "0", "0");
            //For Rest of 
            DataTable DTSale5per = _sale.CustomerGSTReport(first, last, "2.5", "5");
            DataTable DTSale12per = _sale.CustomerGSTReport(first, last, "6", "12");
            DataTable DTSale18per = _sale.CustomerGSTReport(first, last, "9", "18");
            DataTable DTSale28per = _sale.CustomerGSTReport(first, last, "14", "28");

            dgv_sale.Rows.Add(5);

            dgv_sale.Rows[0].Cells["GSTper2"].Value = "0%";
            dgv_sale.Rows[0].Cells["Taxable2"].Value = DTSale0per.Rows[0]["Taxable"];
            dgv_sale.Rows[0].Cells["SGST2"].Value = DTSale0per.Rows[0]["SGST"];
            dgv_sale.Rows[0].Cells["CGST2"].Value = DTSale0per.Rows[0]["CGST"];
            dgv_sale.Rows[0].Cells["IGST2"].Value = DTSale0per.Rows[0]["IGST"];

            dgv_sale.Rows[1].Cells["GSTper2"].Value = "5%";
            dgv_sale.Rows[1].Cells["Taxable2"].Value = DTSale5per.Rows[0]["Taxable"];
            dgv_sale.Rows[1].Cells["SGST2"].Value = DTSale5per.Rows[0]["SGST"];
            dgv_sale.Rows[1].Cells["CGST2"].Value = DTSale5per.Rows[0]["CGST"];
            dgv_sale.Rows[1].Cells["IGST2"].Value = DTSale5per.Rows[0]["IGST"];

            dgv_sale.Rows[2].Cells["GSTper2"].Value = "12%";
            dgv_sale.Rows[2].Cells["Taxable2"].Value = DTSale12per.Rows[0]["Taxable"];
            dgv_sale.Rows[2].Cells["SGST2"].Value = DTSale12per.Rows[0]["SGST"];
            dgv_sale.Rows[2].Cells["CGST2"].Value = DTSale12per.Rows[0]["CGST"];
            dgv_sale.Rows[2].Cells["IGST2"].Value = DTSale12per.Rows[0]["IGST"];

            dgv_sale.Rows[3].Cells["GSTper2"].Value = "18%";
            dgv_sale.Rows[3].Cells["Taxable2"].Value = DTSale18per.Rows[0]["Taxable"];
            dgv_sale.Rows[3].Cells["SGST2"].Value = DTSale18per.Rows[0]["SGST"];
            dgv_sale.Rows[3].Cells["CGST2"].Value = DTSale18per.Rows[0]["CGST"];
            dgv_sale.Rows[3].Cells["IGST2"].Value = DTSale18per.Rows[0]["IGST"];

            dgv_sale.Rows[4].Cells["GSTper2"].Value = "28%";
            dgv_sale.Rows[4].Cells["Taxable2"].Value = DTSale28per.Rows[0]["Taxable"];
            dgv_sale.Rows[4].Cells["SGST2"].Value = DTSale28per.Rows[0]["SGST"];
            dgv_sale.Rows[4].Cells["CGST2"].Value = DTSale28per.Rows[0]["CGST"];
            dgv_sale.Rows[4].Cells["IGST2"].Value = DTSale28per.Rows[0]["IGST"];
        }

        private void GeneratePurchase()
        {
            //for zero
            DataTable DTPurchase0per = _purchase.SupplierGSTReportZerPer(first, last, "0", "0");
            //For Rest of 
            DataTable DTPurchase5per = _purchase.SupplierGSTReport(first, last, "2.5", "5");
            DataTable DTPurchase12per = _purchase.SupplierGSTReport(first, last, "6", "12");
            DataTable DTPurchase18per = _purchase.SupplierGSTReport(first, last, "9", "18");
            DataTable DTPurchase28per = _purchase.SupplierGSTReport(first, last, "14", "28");

            dgv_purchase.Rows.Add(5);

            dgv_purchase.Rows[0].Cells["GSTper"].Value = "0%";
            dgv_purchase.Rows[0].Cells["Taxable"].Value = DTPurchase0per.Rows[0]["Taxable"];
            dgv_purchase.Rows[0].Cells["SGST"].Value = DTPurchase0per.Rows[0]["SGST"];
            dgv_purchase.Rows[0].Cells["CGST"].Value = DTPurchase0per.Rows[0]["CGST"];
            dgv_purchase.Rows[0].Cells["IGST"].Value = DTPurchase0per.Rows[0]["IGST"];

            dgv_purchase.Rows[1].Cells["GSTper"].Value = "5%";
            dgv_purchase.Rows[1].Cells["Taxable"].Value = DTPurchase5per.Rows[0]["Taxable"];
            dgv_purchase.Rows[1].Cells["SGST"].Value = DTPurchase5per.Rows[0]["SGST"];
            dgv_purchase.Rows[1].Cells["CGST"].Value = DTPurchase5per.Rows[0]["CGST"];
            dgv_purchase.Rows[1].Cells["IGST"].Value = DTPurchase5per.Rows[0]["IGST"];

            dgv_purchase.Rows[2].Cells["GSTper"].Value = "12%";
            dgv_purchase.Rows[2].Cells["Taxable"].Value = DTPurchase12per.Rows[0]["Taxable"];
            dgv_purchase.Rows[2].Cells["SGST"].Value = DTPurchase12per.Rows[0]["SGST"];
            dgv_purchase.Rows[2].Cells["CGST"].Value = DTPurchase12per.Rows[0]["CGST"];
            dgv_purchase.Rows[2].Cells["IGST"].Value = DTPurchase12per.Rows[0]["IGST"];

            dgv_purchase.Rows[3].Cells["GSTper"].Value = "18%";
            dgv_purchase.Rows[3].Cells["Taxable"].Value = DTPurchase18per.Rows[0]["Taxable"];
            dgv_purchase.Rows[3].Cells["SGST"].Value = DTPurchase18per.Rows[0]["SGST"];
            dgv_purchase.Rows[3].Cells["CGST"].Value = DTPurchase18per.Rows[0]["CGST"];
            dgv_purchase.Rows[3].Cells["IGST"].Value = DTPurchase18per.Rows[0]["IGST"];

            dgv_purchase.Rows[4].Cells["GSTper"].Value = "28%";
            dgv_purchase.Rows[4].Cells["Taxable"].Value = DTPurchase28per.Rows[0]["Taxable"];
            dgv_purchase.Rows[4].Cells["SGST"].Value = DTPurchase28per.Rows[0]["SGST"];
            dgv_purchase.Rows[4].Cells["CGST"].Value = DTPurchase28per.Rows[0]["CGST"];
            dgv_purchase.Rows[4].Cells["IGST"].Value = DTPurchase28per.Rows[0]["IGST"];
            

        }

        private void cmb_month_TextChanged(object sender, EventArgs e)
        {
            lbl_Purchase.Text = cmb_month.Text;
            lbl_sale.Text = cmb_month.Text;
        }

        private void bttn_print_Click(object sender, EventArgs e)
        {
            try
            {
                Report.CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new Report.CrystalReport.frm_ReportViewer();
                SendData _obj = new SendData(_objfrm_ReportViewer.MonthlyGST);
                _obj(Sale,Purchase,cmb_month.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _error.AddException(ex, "Supplier GST Report");
            }
        }
    }
}
