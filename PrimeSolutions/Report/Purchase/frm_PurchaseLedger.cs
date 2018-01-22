using PrimeSolutions.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions.Report.Purchase
{
    public partial class frm_PurchaseLedger : Form
    {
        AllClassFile _a = new AllClassFile();
        PurchaseCommon _p = new PurchaseCommon();
        DataTable dtsupplier;
        clsCommon _c = new clsCommon();

        public frm_PurchaseLedger()
        {
            InitializeComponent();
        }

        private void frm_PurchaseLedger_Load(object sender, EventArgs e)
        {
            dtsupplier = _a.getSupplierName();
            cmb_supplier.DataSource = dtsupplier;
            txt_balance.Text = "";
            txt_Bill.Text = "";
            txt_payment.Text = "";
        }

        private void bttn_search_Click(object sender, EventArgs e)
        {
            search(); 
        }
        private void print()
        {

        }


        private void search()
        {
            int index = cmb_supplier.SelectedIndex;
            string supplierid = dtsupplier.Rows[index]["SupplierNo"].ToString();
            DataTable dtsupplierBill = _p.GetSupplierFromAccNo(supplierid);
            dgv_Bill.Rows.Clear();
            if (dtsupplier.Rows.Count>0)
            for (int i = 0; i < dtsupplierBill.Rows.Count; i++)
            {
                    
                dgv_Bill.Rows.Add();
                dgv_Bill.Rows[i].Cells["Date"].Value = dtsupplierBill.Rows[i]["Date"].ToString();
                dgv_Bill.Rows[i].Cells["BillNo"].Value = dtsupplierBill.Rows[i]["BillNo"].ToString();
                dgv_Bill.Rows[i].Cells["Amount"].Value = dtsupplierBill.Rows[i]["GrandTotal"].ToString();
            }
            DataTable dtsupplierpay = _p.GetSupplierPaymentByAccNo(supplierid);
            dgv_Payment.Rows.Clear();
            if (dtsupplierpay.Rows.Count > 0)
            for (int i = 0; i < dtsupplierpay.Rows.Count; i++)
            {
                    
                dgv_Payment.Rows.Add();
                dgv_Payment.Rows[i].Cells["PayDate"].Value = dtsupplierpay.Rows[i]["Date"].ToString();
                dgv_Payment.Rows[i].Cells["PaidAmt"].Value = dtsupplierpay.Rows[i]["Amt"].ToString();
                dgv_Payment.Rows[i].Cells["PayType"].Value = dtsupplierpay.Rows[i]["Paymode"].ToString();
            }

            string TotalBill =Convert.ToString(_c.sumGridViewColumn(dgv_Bill, "Amount"));
            string TotalPaid = Convert.ToString(_c.sumGridViewColumn(dgv_Payment, "PaidAmt"));
            string Balance = Convert.ToString(Convert.ToDouble(TotalBill) - Convert.ToDouble(TotalPaid));

            txt_Bill.Text = TotalBill;
            txt_payment.Text = TotalPaid;
            txt_balance.Text = Balance;
            cmb_supplier.Focus();
        }

        private void frm_PurchaseLedger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            print();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
