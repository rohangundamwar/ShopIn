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
    public partial class frm_CustomerContact : Form
    {
        public frm_CustomerContact()
        {
            InitializeComponent();
        }

        CustomerCommon _C = new CustomerCommon();
        ExportToExcel _e = new ExportToExcel();

        private void frm_CustomerContact_Load(object sender, EventArgs e)
        {
           DataTable dt = _C.GetCustomerDeatils();
            for (int i=0;i<dt.Rows.Count;i++)
            {
                dgv_Customer.Rows.Add();
                dgv_Customer.Rows[i].Cells["CustomerName"].Value = dt.Rows[i]["Name"].ToString();
                dgv_Customer.Rows[i].Cells["ContactNo"].Value = dt.Rows[i]["ContactNo"].ToString();
                dgv_Customer.Rows[i].Cells["Address"].Value = dt.Rows[i]["Address"].ToString();
                DataTable dt1 = _C.GetCustomerItemDeatils(dt.Rows[i]["CustId"].ToString());
                //get from Bill iTem
                dgv_Customer.Rows[i].Cells["Item"].Value = dt1.Rows[0]["category"].ToString();

            }
            
        }

        private void frm_CustomerContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_Excel_Click(object sender, EventArgs e)
        {
            _e.exporttoexcel(dgv_Customer, "Customer List", dtp1.Value.ToString("dd_MM_yyyy"));
        }
    }
}
