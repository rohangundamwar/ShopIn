using PrimeSolutions.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions.Report.Customer
{
    public partial class frm_TotalCustomerGST : Form
    {
        SaleCommon _sale = new SaleCommon();
        clsCommon _common = new clsCommon();
        ExportToExcel _excel = new ExportToExcel();
        ErrorLog _error = new ErrorLog();
        public delegate void SendData(DataTable DT, string type,string from,string to);
        DataTable GST = new DataTable();

        public frm_TotalCustomerGST()
        {
            InitializeComponent();
        }

        private void bttn_Generate_Click(object sender, EventArgs e)
        {
            dgv_GST.Rows.Clear();
            int i = 0;
            DataTable dt1 = _sale.GetCsutomerDetail(dtp_From.Value.ToString("dd/MM/yyyy"), dtp_to.Value.ToString("dd/MM/yyyy"));
            for ( i=0 ; i < dt1.Rows.Count; i++)
            {
                //For 0%
                DataTable ZeroPer = _sale.CustomerGSTReportZeroPer(dtp_From.Value.ToString("dd/MM/yyyy"), dtp_to.Value.ToString("dd/MM/yyyy"), dt1.Rows[i]["CustomerName"].ToString(),"0","0");
                //Rest of Slab
                DataTable FivePer = _sale.CustomerGSTReport(dtp_From.Value.ToString("dd/MM/yyyy"), dtp_to.Value.ToString("dd/MM/yyyy"), dt1.Rows[i]["CustomerName"].ToString(), "2.5", "5");
                DataTable TwelvePer = _sale.CustomerGSTReport(dtp_From.Value.ToString("dd/MM/yyyy"), dtp_to.Value.ToString("dd/MM/yyyy"), dt1.Rows[i]["CustomerName"].ToString(), "6", "12");
                DataTable EighteenPer = _sale.CustomerGSTReport(dtp_From.Value.ToString("dd/MM/yyyy"), dtp_to.Value.ToString("dd/MM/yyyy"), dt1.Rows[i]["CustomerName"].ToString(), "9", "18");
                DataTable TwentyEtPer = _sale.CustomerGSTReport(dtp_From.Value.ToString("dd/MM/yyyy"), dtp_to.Value.ToString("dd/MM/yyyy"), dt1.Rows[i]["CustomerName"].ToString(), "14", "28");
                
                dgv_GST.Rows.Add(i + 1,dt1.Rows[i]["CustomerName"], dt1.Rows[i]["GSTIN"]);

                dgv_GST.Rows[i].Cells[3].Value = ZeroPer.Rows[0]["Taxable"];

                dgv_GST.Rows[i].Cells[4].Value = FivePer.Rows[0]["Taxable"];
                dgv_GST.Rows[i].Cells[5].Value = FivePer.Rows[0]["CGST"];
                dgv_GST.Rows[i].Cells[6].Value = FivePer.Rows[0]["SGST"];
                dgv_GST.Rows[i].Cells[7].Value = FivePer.Rows[0]["IGST"];

                dgv_GST.Rows[i].Cells[8].Value = TwelvePer.Rows[0]["Taxable"];
                dgv_GST.Rows[i].Cells[9].Value = TwelvePer.Rows[0]["CGST"];
                dgv_GST.Rows[i].Cells[10].Value = TwelvePer.Rows[0]["SGST"];
                dgv_GST.Rows[i].Cells[11].Value = TwelvePer.Rows[0]["IGST"];

                dgv_GST.Rows[i].Cells[12].Value = EighteenPer.Rows[0]["Taxable"];
                dgv_GST.Rows[i].Cells[13].Value = EighteenPer.Rows[0]["CGST"];
                dgv_GST.Rows[i].Cells[14].Value = EighteenPer.Rows[0]["SGST"];
                dgv_GST.Rows[i].Cells[15].Value = EighteenPer.Rows[0]["IGST"];

                dgv_GST.Rows[i].Cells[16].Value = TwentyEtPer.Rows[0]["Taxable"];
                dgv_GST.Rows[i].Cells[17].Value = TwentyEtPer.Rows[0]["CGST"];
                dgv_GST.Rows[i].Cells[18].Value = TwentyEtPer.Rows[0]["SGST"];
                dgv_GST.Rows[i].Cells[19].Value = TwentyEtPer.Rows[0]["IGST"];
                
            }

            dgv_GST.Rows.Add(2);
            int j = i + 1;
            dgv_GST.Rows[j].Cells[2].Value = "Total";

            dgv_GST.Rows[j].Cells[3].Value = _common.sumGridViewColumn(dgv_GST, "AmountZero");

            dgv_GST.Rows[j].Cells[4].Value = _common.sumGridViewColumn(dgv_GST, "Amt5per");
            dgv_GST.Rows[j].Cells[5].Value = _common.sumGridViewColumn(dgv_GST, "SGST5per");
            dgv_GST.Rows[j].Cells[6].Value = _common.sumGridViewColumn(dgv_GST, "CGST5per");
            dgv_GST.Rows[j].Cells[7].Value = _common.sumGridViewColumn(dgv_GST, "IGST5per");

            dgv_GST.Rows[j].Cells[8].Value = _common.sumGridViewColumn(dgv_GST, "Amt12per");
            dgv_GST.Rows[j].Cells[9].Value = _common.sumGridViewColumn(dgv_GST, "SGST12per");
            dgv_GST.Rows[j].Cells[10].Value = _common.sumGridViewColumn(dgv_GST, "CGST12per");
            dgv_GST.Rows[j].Cells[11].Value = _common.sumGridViewColumn(dgv_GST, "IGST12per");

            dgv_GST.Rows[j].Cells[12].Value = _common.sumGridViewColumn(dgv_GST, "Amt18per");
            dgv_GST.Rows[j].Cells[13].Value = _common.sumGridViewColumn(dgv_GST, "SGST18per");
            dgv_GST.Rows[j].Cells[14].Value = _common.sumGridViewColumn(dgv_GST, "CGST18per");
            dgv_GST.Rows[j].Cells[15].Value = _common.sumGridViewColumn(dgv_GST, "IGST18per");

            dgv_GST.Rows[j].Cells[16].Value = _common.sumGridViewColumn(dgv_GST, "Amt28per");
            dgv_GST.Rows[j].Cells[17].Value = _common.sumGridViewColumn(dgv_GST, "SGST28per");
            dgv_GST.Rows[j].Cells[18].Value = _common.sumGridViewColumn(dgv_GST, "CGST28per");
            dgv_GST.Rows[j].Cells[19].Value = _common.sumGridViewColumn(dgv_GST, "IGST28per");

            GST = _common.DataGridView2DataTable(dgv_GST, "GST", 0);
        }

        private void bttn_Excel_Click(object sender, EventArgs e)
        {
            _excel.exporttoexcel(dgv_GST, "TotalCustomerGST", dtp_to.Value.ToString("dd_MM_yyyy"));
        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                Report.CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new Report.CrystalReport.frm_ReportViewer();
                SendData _obj = new SendData(_objfrm_ReportViewer.GSTReport);
                _obj(GST, "Customer", dtp_From.Value.ToString("dd/MM/yyyy"), dtp_to.Value.ToString("dd/MM/yyyy"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _error.AddException(ex, "Supplier GST Report");
            }
        }
    }
}
