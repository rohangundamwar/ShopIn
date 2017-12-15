using PrimeSolutions.Library;
using PrimeSolutions.Report;
using PrimeSolutions.Report.CrystalReport;
using System;
using System.Data;
using System.Windows.Forms;

namespace PrimeSolutions.Service
{
    public partial class frm_JobCard : Form
    {
        cls_ServiceCommon _service = new cls_ServiceCommon();
        clsCommon _common = new clsCommon();
        PrinterSetting _objPrinterSetting = new PrinterSetting();

        public delegate void SendData(DataTable Table, string From, string To);

        public frm_JobCard()
        {
            InitializeComponent();
        }

        private void bttn_generate_Click(object sender, EventArgs e)
        {
            DataTable dt = _service.GetService(dtp_from.Value.ToString("dd/MM/yyyy"), dtp_to.Value.ToString("dd/MM/yyyy"));
            dgv_Job.Rows.Clear();
            if (dt.Rows.Count > 0)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgv_Job.Rows.Add();
                    dgv_Job.Rows[i].Cells["Date"].Value = dt.Rows[i]["Date"];
                    dgv_Job.Rows[i].Cells["Name"].Value = dt.Rows[i]["CustomerName"];
                    dgv_Job.Rows[i].Cells["Address"].Value = dt.Rows[i]["Address"] + "," + dt.Rows[i]["City"] + "," + dt.Rows[i]["State"];
                    dgv_Job.Rows[i].Cells["MobileNo"].Value = dt.Rows[i]["ContactNo"];
                    dgv_Job.Rows[i].Cells["Model"].Value = dt.Rows[i]["Item"];
                    dgv_Job.Rows[i].Cells["ServiceID"].Value = dt.Rows[i]["ServiceID"];
                    dgv_Job.Rows[i].Cells["Maintenance"].Value = dt.Rows[i]["MaintainDate"];

                }
        }

        private void dgv_Job_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dgv_Job.Rows[e.RowIndex].Cells["ServiceID"].Value.ToString();
            frm_ServiceInvoice _ServiceInvoice = new frm_ServiceInvoice(ID);
            _ServiceInvoice.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = _common.DataGridView2DataTable(dgv_Job, "JobSheet", 0);
            string From = dtp_from.Value.ToString("dd/MM/yyyy");
            string To = dtp_to.Value.ToString("dd/MM/yyyy");
            frm_ReportViewer _objfrm_ReportViewer = new frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.JobCardList);
            _obj(dt, From, To);
        }

        private void bttn_PrintCard_Click(object sender, EventArgs e)
        {
            DataRow foundRows;
            DataTable NewDt = new DataTable();

            DataTable table = _common.DataGridView2DataTable(dgv_Job, "JobList", 0);
            // Presuming the DataTable has a column named Date.
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["Select"].ToString() == "false")
                {
                    foundRows = table.Rows[i];
                    table.Rows[i].Delete();
                }
            }
            
            try
            {
                int Copies = _objPrinterSetting.copies;
                Report.CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new Report.CrystalReport.frm_ReportViewer();
                SendData _obj = new SendData(_objfrm_ReportViewer.JobCard);
                _obj(table, "Print", "");
            }
            catch (Exception ex)
            {
            }


        }
    }
}
