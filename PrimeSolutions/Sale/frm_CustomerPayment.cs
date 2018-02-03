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
    public partial class frm_CustomerPayment : Form
    {
        CustomerCommon _cust = new CustomerCommon();
        DataTable cust;
        AllClassFile _a = new AllClassFile();
        ErrorLog _e = new ErrorLog();
        SQLHelper _sql = new SQLHelper();
        public delegate void SendData(string BillNO, string type);

        public frm_CustomerPayment()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            cmb_name.ResetText();
            txt_Amount.Text = "";
            cmb_name.Focus();
            cmb_PaymentType.SelectedIndex = 0;
            txt_ReceiptNo.Text = _sql.GetMaxID("R","0");

        }
        private void frm_CustomerPayment_Load(object sender, EventArgs e)
        {
            Clear();
            cust = _cust.GetCustomerDeatils();
            cmb_name.DataSource = cust;
        }

        private void cmb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id =  cmb_name.SelectedIndex.ToString();
            lbl_id.Text = cust.Rows[Convert.ToInt32(id)]["CustId"].ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                _a.InsertPaymentDetails("Customer", txt_Amount.Text, cmb_PaymentType.Text, lbl_id.Text, dtp_Date.Value.ToString("dd/MM/yyyy"), txt_ReceiptNo.Text);
                MessageBox.Show("Payment Saved");
            }
            catch(Exception ex)
            {
                _e.AddException(ex,"Customer Payment");
            }

            try
            {
                DialogResult dr = MessageBox.Show("Do You want to print Receipt", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Report.CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new Report.CrystalReport.frm_ReportViewer();
                    SendData _obj = new SendData(_objfrm_ReportViewer.PaymentReceipt);
                    _obj(txt_ReceiptNo.Text, "Customer");
                }
            }
            catch (Exception ex)
            {
                _e.AddException(ex, "Customer Payment/Print");
            }
            MessageBox.Show("Done");
            Clear();
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
