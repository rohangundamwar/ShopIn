using System;
using System.Data;
using System.Windows.Forms;
using PrimeSolutions.Library;
using PrimeSolutions.Report.CrystalReport;

namespace PrimeSolutions.Report.Sale
{
    public partial class frm_DuplicateBill : Form
    {
        public frm_DuplicateBill()
        {
            InitializeComponent();
        }

        SaleCommon _s = new SaleCommon();
        public delegate void SendData(string BillNO,string Type);
        frm_ReportViewer _r = new frm_ReportViewer();
        DataTable dt;
        DataTable dt1;

        private void frm_DuplicateBill_Load(object sender, EventArgs e)
        {
            dt = _s.GetCustomer();
            cmb_customer.DataSource = dt;
        }

        private void bttn_print_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_type.Text == "GST")
                {
                    CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                    SendData _obj = new SendData(_objfrm_ReportViewer.CustomerBill);
                    _obj(bill.Text, "Print");
                }
                else if (txt_type.Text == "Estimate")
                {
                    CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                    SendData _obj = new SendData(_objfrm_ReportViewer.CustomerBillEst);
                    _obj(bill.Text, "Print");
                }

                if (txt_type.Text == "Service Invoice")
                {
                    CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                    SendData _obj = new SendData(_objfrm_ReportViewer.ServiceInvoice);
                    _obj(bill.Text, "Print");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //_s.PrintBillThermal(cmb_BillNo.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cmb_customer.SelectedIndex.ToString();
            dt1= _s.GetCustomerBill(dt.Rows[Convert.ToInt32(id)]["CustId"].ToString());
            dgv_Bill.Rows.Clear();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                dgv_Bill.Rows.Add();
                dgv_Bill.Rows[i].Cells["Date"].Value = dt1.Rows[i]["Date"].ToString();
                dgv_Bill.Rows[i].Cells["BillNo"].Value = dt1.Rows[i]["BillNo"].ToString();
                dgv_Bill.Rows[i].Cells["Amount"].Value = dt1.Rows[i]["BillAmount"].ToString();
            }

        }

        private void dgv_Bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bill.Text= dgv_Bill.Rows[e.RowIndex].Cells["BillNo"].Value.ToString();
            txt_type.Text = dt1.Rows[e.RowIndex]["Type"].ToString();

        }

        private void bttn_view_Click(object sender, EventArgs e)
        {
            if (txt_type.Text == "GST")
            {
                CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                SendData _obj = new SendData(_objfrm_ReportViewer.CustomerBill);
                _obj(bill.Text, "View");
                _objfrm_ReportViewer.Show();
            }
            else if (txt_type.Text == "Estimate")
            {
                CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                SendData _obj = new SendData(_objfrm_ReportViewer.CustomerBillEst);
                _obj(bill.Text, "View");
                _objfrm_ReportViewer.Show();
            }

            if (txt_type.Text == "Service Invoice")
            {
                CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                SendData _obj = new SendData(_objfrm_ReportViewer.ServiceInvoice);
                _obj(bill.Text, "View");
                _objfrm_ReportViewer.Show();
            }

        }
    }
}
