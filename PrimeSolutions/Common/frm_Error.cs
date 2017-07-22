using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;

namespace PrimeSolutions.Common
{
    public partial class frm_Error : Form
    {
        public frm_Error()
        {
            InitializeComponent();
        }

        ExportToExcel _e = new ExportToExcel();
        AllClassFile _a = new  AllClassFile();

        private void bttn_Excel_Click(object sender, EventArgs e)
        {
            _e.exporttoexcel(dgv_error, "Error Report", dtp_date.Value.ToString("dd_MM_yyyy"));
        }

        private void frm_Error_Load(object sender, EventArgs e)
        {
            DataTable dt = _a.GetError();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv_error.Rows.Add();
                dgv_error.Rows[i].Cells["ErrorMessage"].Value = dt.Rows[i]["ErrorMessage"].ToString();
                dgv_error.Rows[i].Cells["Form"].Value = dt.Rows[i]["Form"].ToString();
                dgv_error.Rows[i].Cells["Time"].Value = dt.Rows[i]["Time"].ToString();
                dgv_error.Rows[i].Cells["Line"].Value = dt.Rows[i]["Line"].ToString();
                dgv_error.Rows[i].Cells["Method"].Value = dt.Rows[i]["Method"].ToString();
                dgv_error.Rows[i].Cells["Stack"].Value = dt.Rows[i]["Stack"].ToString();
            }
        }
    }
}
