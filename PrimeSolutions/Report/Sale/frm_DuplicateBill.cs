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

        private void frm_DuplicateBill_Load(object sender, EventArgs e)
        {
           DataTable dt = _s.GetSaleBillData();
            cmb_BillNo.DataSource = dt;
        }

        private void bttn_print_Click(object sender, EventArgs e)
        {
            _s.PrintBill(cmb_BillNo.Text);
        }
    }
}
