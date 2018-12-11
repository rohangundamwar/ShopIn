using System;
using System.Data;
using System.Windows.Forms;
using PrimeSolutions.Library;
using PrimeSolutions.Report.CrystalReport;

namespace PrimeSolutions.Report.Sale
{
    public partial class frm_PurchaseDuplicateBill : Form
    {
        public frm_PurchaseDuplicateBill()
        {
            InitializeComponent();
        }

        SaleCommon _s = new SaleCommon();
        PurchaseCommon _p = new PurchaseCommon();
        AllClassFile _a = new AllClassFile();
        public delegate void SendData(string BillNO,string Type);
        frm_ReportViewer _r = new frm_ReportViewer();
        DataTable dt;
        DataTable dt1;

        private void frm_DuplicateBill_Load(object sender, EventArgs e)
        {
            dt = _a.getSupplierName();
            cmb_customer.DataSource = dt;
        }

        private void bttn_print_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_type.Text == "GST")
                {
                    CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                    SendData _obj = new SendData(_objfrm_ReportViewer.SupplierBill);
                    _obj(txt_ref.Text, "Print");
                }
                else if (txt_type.Text == "Estimate")
                {
                    CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                    SendData _obj = new SendData(_objfrm_ReportViewer.SupplierBillEst);
                    _obj(txt_ref.Text, "Print");
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
            dt1= _p.GetSupplierBill(dt.Rows[Convert.ToInt32(id)]["SupplierNo"].ToString());
            dgv_Bill.Rows.Clear();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                dgv_Bill.Rows.Add();
                dgv_Bill.Rows[i].Cells["Date"].Value = dt1.Rows[i]["Date"].ToString();
                dgv_Bill.Rows[i].Cells["BillNo"].Value = dt1.Rows[i]["BillNo"].ToString();
                dgv_Bill.Rows[i].Cells["Amount"].Value = dt1.Rows[i]["Amount"].ToString();
                dgv_Bill.Rows[i].Cells["RefrenceNo"].Value = dt1.Rows[i]["RefrenceNo"].ToString();

            }

        }

        private void dgv_Bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bill.Text= dgv_Bill.Rows[e.RowIndex].Cells["BillNo"].Value.ToString();
            txt_type.Text = dt1.Rows[e.RowIndex]["Type"].ToString();
            txt_ref.Text=  dt1.Rows[e.RowIndex]["RefrenceNo"].ToString();

        }

        private void bttn_view_Click(object sender, EventArgs e)
        {
            if (txt_type.Text == "GST")
            {
                CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                SendData _obj = new SendData(_objfrm_ReportViewer.SupplierBill);
                _obj(txt_ref.Text, "View");
                _objfrm_ReportViewer.Show();
            }
            else if (txt_type.Text == "Estimate")
            {
                CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                SendData _obj = new SendData(_objfrm_ReportViewer.SupplierBillEst);
                _obj(txt_ref.Text, "View");
                _objfrm_ReportViewer.Show();
            }


        }
    }
}
