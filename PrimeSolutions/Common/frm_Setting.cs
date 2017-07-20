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
            txt_print.Text = dt.Rows[0]["PrintCount"].ToString();
            txt_tax.Text = dt.Rows[0]["Tax"].ToString();
            txt_TaxPer.Text= dt.Rows[0]["TaxPer"].ToString();
        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            _a.SetAllssetting(txt_barcode.Text, txt_print.Text, txt_tax.Text, txt_TaxPer.Text);
        }
    }
}
