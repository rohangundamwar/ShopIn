using PrimeSolutions.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions.Service
{
    public partial class frm_JobCard : Form
    {
        cls_ServiceCommon _service = new cls_ServiceCommon();

        public frm_JobCard()
        {
            InitializeComponent();
        }

        private void bttn_generate_Click(object sender, EventArgs e)
        {
            DataTable dt = _service.GetService(dtp_from.Value.ToString("dd/MM/yyyy"), dtp_to.Value.ToString("dd/MM/yyyy"));
            dgv_Job.Rows.Clear();
            if(dt.Rows.Count>0)
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                    dgv_Job.Rows.Add();
                dgv_Job.Rows[i].Cells["Date"].Value = dt.Rows[i]["Date"];
                dgv_Job.Rows[i].Cells["Name"].Value = dt.Rows[i]["CustomerName"];
                dgv_Job.Rows[i].Cells["Address"].Value = dt.Rows[i]["Address"]+","+ dt.Rows[i]["City"]+"," + dt.Rows[i]["State"];
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
    }
}
