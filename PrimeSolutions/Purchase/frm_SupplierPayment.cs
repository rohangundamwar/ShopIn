using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;

namespace PrimeSolutions.Purchase
{
    public partial class frm_SupplierPayment : Form
    {
        CustomerCommon _cust = new CustomerCommon();
        DataTable Supplier;
        AllClassFile _a = new AllClassFile();
        ErrorLog _e = new ErrorLog();
        SQLHelper _sql = new SQLHelper();

        

        public frm_SupplierPayment()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            cmb_name.ResetText();
            txt_Amount.Text = "";
            cmb_name.Focus();
            txt_ReceiptNo.Text = _sql.GetMaxID("X", "0");
            cmb_PaymentType.SelectedIndex = 0;

        }
        private void frm_CustomerPayment_Load(object sender, EventArgs e)
        {
            Clear();
            Supplier = _a.getSupplierName();
            cmb_name.DataSource = Supplier;

        }

        private void cmb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id =  cmb_name.SelectedIndex.ToString();
            lbl_id.Text = Supplier.Rows[Convert.ToInt32(id)]["SupplierNo"].ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                _a.InsertPaymentDetails("Supplier", txt_Amount.Text, cmb_PaymentType.Text , lbl_id.Text, dtp_Date.Value.ToString("dd/MM/yyyy"),txt_ReceiptNo.Text);
                MessageBox.Show("Payment Saved");
                Clear();
            }
            catch(Exception ex)
            {
                _e.AddException(ex,"Supplier Payment");
            }
            
        }

        private void cmb_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Amount.Focus();
            }
        }

        private void txt_Amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save.Focus();
            }
        }
    }
}
