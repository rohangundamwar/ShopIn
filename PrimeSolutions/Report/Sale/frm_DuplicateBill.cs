using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;

namespace PrimeSolutions.Report.Sale
{
    public partial class frm_DuplicateBill : Form
    {
        public frm_DuplicateBill()
        {
            InitializeComponent();
        }

        SaleCommon _s = new SaleCommon();
        public delegate void SendData(string BillNO);

        private void frm_DuplicateBill_Load(object sender, EventArgs e)
        {
           DataTable dt = _s.GetSaleBillData();
            cmb_BillNo.DataSource = dt;
        }

        private void bttn_print_Click(object sender, EventArgs e)
        {
            try
            {
                Report.CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new Report.CrystalReport.frm_ReportViewer();
                SendData _obj = new SendData(_objfrm_ReportViewer.CustomerBill);
                _obj(cmb_BillNo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //_s.PrintBillThermal(cmb_BillNo.Text);
        }
    }
}
