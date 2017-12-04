using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions.Common
{
    public partial class Uc_MultiItem : UserControl
    {
        DataTable item;
        public Uc_MultiItem(DataTable dt)
        {
            item = dt;
            InitializeComponent();
        }

        private void Uc_MultiItem_Load(object sender, EventArgs e)
        {
            dgv_item.Rows.Clear();
            for (int i = 0; i < item.Rows.Count; i++)
            {
                dgv_item.Rows.Add();
                dgv_item.Rows[i].Cells["SubCategory"].Value = item.Rows[i]["SubCategory"].ToString();
            }
            
        }
    }
}
