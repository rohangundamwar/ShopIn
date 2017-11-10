using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;

namespace PrimeSolutions.Sale
{
    public partial class frm_UpdateBill : Form
    {
        public frm_UpdateBill()
        {
            InitializeComponent();
        }

        clsCommon _common = new clsCommon();
        DataTable dt;
        SaleCommon _sale = new SaleCommon();
        string Bill = "";
        

        private void frm_UpdateBill_Load(object sender, EventArgs e)
        {
            dt = _sale.GetCustomer();
            cmb_name.DataSource = dt;

        }

        private void cmb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cmb_name.SelectedIndex.ToString();
            DataTable  dt1 = _sale.GetCustomerBill(dt.Rows[Convert.ToInt32(id)]["CustId"].ToString());
            dgv_Bill.Rows.Clear();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                dgv_Bill.Rows.Add();
                dgv_Bill.Rows[i].Cells["Date"].Value = dt1.Rows[i]["Date"].ToString();
                dgv_Bill.Rows[i].Cells["BillNo"].Value = dt1.Rows[i]["BillNo"].ToString();
                dgv_Bill.Rows[i].Cells["Amount"].Value = dt1.Rows[i]["BillAmount"].ToString();
            }
        }

        private void dgv_Bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Bill = dgv_Bill.Rows[e.RowIndex].Cells["BillNo"].Value.ToString();
            lbl_BillNo.Text = "BillNo: " + Bill;
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            frm_SaleForm _Form = new frm_SaleForm();
            _Form.ShowDialog();
        }
    }
}
