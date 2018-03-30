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
    public partial class frm_ExecuteQuery : Form
    {
        SQLHelper _sql = new SQLHelper();

        public frm_ExecuteQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = _sql.GetDataTable(txt_query.Text);
            DGV.DataSource = dt;
            lbl_message.Text = _sql.msg;
        }
    }
}
