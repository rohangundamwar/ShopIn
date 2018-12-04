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
        DataTable dtsupplier, dtsupplierBill, dtsupplierpay;
        clsCommon _c = new clsCommon();
        public delegate void SendData(DataTable dtCustBill, DataTable dtpay, string sale, string paid, string bal);
        public delegate void ViewData(string BillNo, string type);

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
            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.PurchaseLedger);
            _obj(dtsupplierBill, dtsupplierpay, txt_Bill.Text, txt_payment.Text, txt_balance.Text);
            _objfrm_ReportViewer.Show();
        }


        private void search()
        {
            int index = cmb_supplier.SelectedIndex;
            string supplierid = dtsupplier.Rows[index]["SupplierNo"].ToString();
            dtsupplierBill = _p.GetSupplierFromAccNo(supplierid);
            dgv_Bill.Rows.Clear();
            if (dtsupplier.Rows.Count>0)
                for (int i = 0; i < dtsupplierBill.Rows.Count; i++)
                {

                    dgv_Bill.Rows.Add();
                    dgv_Bill.Rows[i].Cells["Date"].Value = dtsupplierBill.Rows[i]["Date"].ToString();
                    dgv_Bill.Rows[i].Cells["BillNo"].Value = dtsupplierBill.Rows[i]["BillNo"].ToString();
                    dgv_Bill.Rows[i].Cells["Amount"].Value = dtsupplierBill.Rows[i]["GrandTotal"].ToString();
                    //RefrenceNo
                    dgv_Bill.Rows[i].Cells["RefrenceNo"].Value = dtsupplierBill.Rows[i]["RefrenceNo"].ToString();

                }
            dtsupplierpay = _p.GetSupplierPaymentByAccNo(supplierid);
            dgv_Payment.Rows.Clear();
            if (dtsupplierpay.Rows.Count > 0)
                for (int i = 0; i < dtsupplierpay.Rows.Count; i++)
                {
                    dgv_Payment.Rows.Add();
                    dgv_Payment.Rows[i].Cells["PayDate"].Value = dtsupplierpay.Rows[i]["Date"].ToString();
                    dgv_Payment.Rows[i].Cells["ReceiptNo"].Value = dtsupplierpay.Rows[i]["BillNo"].ToString();
                    dgv_Payment.Rows[i].Cells["PaidAmt"].Value = dtsupplierpay.Rows[i]["Amt"].ToString();
                    dgv_Payment.Rows[i].Cells["PayType"].Value = dtsupplierpay.Rows[i]["Paymode"].ToString();
                }
            string TotalBill =Convert.ToString(Math.Round(_c.sumGridViewColumn(dgv_Bill, "Amount"),2) );
            string TotalPaid = Convert.ToString(Math.Round(_c.sumGridViewColumn(dgv_Payment, "PaidAmt"),2) );
            string Balance = Convert.ToString(Math.Round(Convert.ToDouble(TotalBill) - Convert.ToDouble(TotalPaid), 2)) ;

            txt_Bill.Text = TotalBill;
            txt_payment.Text = TotalPaid;
            txt_balance.Text = Balance;
            cmb_supplier.Focus();
        }

        private void dgv_Bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_Bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string BillNo = dgv_Bill.Rows[e.RowIndex].Cells["RefrenceNo"].Value.ToString();
            {

            }
            if (BillNo[1] == 'R')
            {
                CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                ViewData _obj = new ViewData(_objfrm_ReportViewer.SupplierBill);
                _obj(BillNo, "View");
                _objfrm_ReportViewer.Show();


            }
            else if (BillNo[1] == 'E')
            {
                CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                ViewData _obj = new ViewData(_objfrm_ReportViewer.SupplierBillEst);
                _obj(BillNo, "View");
                _objfrm_ReportViewer.Show();
            }
        }

        private void frm_PurchaseLedger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_search.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            print();
        }
    }
}
