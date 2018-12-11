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
    public partial class frm_DeletedBill : Form
    {
        SaleCommon _sale = new SaleCommon();
        ErrorLog _error = new ErrorLog();

        public frm_DeletedBill()
        {
            InitializeComponent();
        }

        private void frm_DeletedBill_Load(object sender, EventArgs e)
        {
            DataTable Bill = _sale.GetDeletedBill();
            dgv_Bill.DataSource = Bill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            
        }

        private void bttn_Edit_Click(object sender, EventArgs e)
        {
            string BillNo = dgv_Bill.Rows[dgv_Bill.CurrentRow.Index].Cells["BillNo"].Value.ToString();
            string type = dgv_Bill.Rows[dgv_Bill.CurrentRow.Index].Cells["Type"].Value.ToString();
            string SrNo = dgv_Bill.Rows[dgv_Bill.CurrentRow.Index].Cells["SrNo"].Value.ToString();
            _sale.DeleteBillRecord(SrNo,BillNo);

            try
            {
                if (type == "GST")
                {
                    frm_SaleForm _form = new frm_SaleForm(BillNo, "Deleted");
                    _form.ShowDialog();
                }

                if (type == "Estimate")
                {
                    frm_SaleEstimate _form = new frm_SaleEstimate(BillNo, "Deleted" );
                    _form.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                _error.AddException(ex, "ChangeBill");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
