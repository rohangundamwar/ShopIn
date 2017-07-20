using PrimeSolutions.ClassFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions.Common
{
    public partial class frm_Setting : Form
    {
        public frm_Setting()
        {
            InitializeComponent();
        }

        AllClassFile _a = new AllClassFile();

        private void frm_Setting_Load(object sender, EventArgs e)
        {
            DataTable dt = _a.getallssetting();
            txt_barcode.Text = dt.Rows[0]["BarcodeCount"].ToString();
            txt_print.Text = dt.Rows[0]["BillCount"].ToString();
            //Barcode Check
            if (dt.Rows[0]["Barcode"].ToString() == "Yes")
                rbt_yes1.Checked = true;
            
            else
                rbt_No1.Checked = true;
            
        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            string barcode;
            if (rbt_yes1.Checked == true)
            {
                barcode = "Yes";
            }
            else
            {
                barcode = "No";
            }
            _a.SetAllssetting(txt_barcode.Text, txt_print.Text,barcode);
        }
    }
}
