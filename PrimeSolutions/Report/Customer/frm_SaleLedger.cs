﻿using PrimeSolutions.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Report.CrystalReport;

namespace PrimeSolutions.Report.Customer
{
    public partial class frm_SaleLedger : Form
    {
        AllClassFile _a = new AllClassFile();
        SaleCommon _s = new SaleCommon();
        DataTable dtCustomer;
        frm_ReportViewer _r = new frm_ReportViewer();  
        clsCommon _c = new clsCommon();
        DataTable dtCustBill;
        DataTable dtpay;
        public delegate void SendData(DataTable dtCustBill, DataTable dtpay,string sale,string paid,string bal,string Extra);
        public delegate void ViewData(string BillNo,string Type);

        public frm_SaleLedger()
        {
            InitializeComponent();
        }

        private void frm_PurchaseLedger_Load(object sender, EventArgs e)
        {
            dtCustomer = _s.GetAllCustomer();
            cmb_supplier.DataSource = dtCustomer;

            txt_balance.Text = "";
            txt_Bill.Text = "";
            txt_payment.Text = "";
        }

        private void bttn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            int index = cmb_supplier.SelectedIndex;
            string Custid = dtCustomer.Rows[index]["CustId"].ToString();
            dtCustBill = _s.GetCustomerBill(Custid,"All");
            double Opening =  _s.GetOpening(dtCustomer.Rows[index]["CustId"].ToString());
            dgv_Bill.Rows.Clear();
            dgv_Payment.Rows.Clear();

            if (Opening != 0)
            {
                dgv_Bill.Rows.Add();
                dgv_Bill.Rows[0].Cells["Amount"].Value = Convert.ToString(Opening);
                dgv_Bill.Rows[0].Cells["BillNo"].Value = "Opening Balance";
            }
            else if (Opening == 0)
            {
                dgv_Bill.Rows.Add();
                dgv_Bill.Rows[0].Cells["Amount"].Value = 0;
                dgv_Bill.Rows[0].Cells["BillNo"].Value = "Opening Balance";
            }

                if (dtCustBill.Rows.Count > 0)
            {
                for (int i = 1; i <= dtCustBill.Rows.Count; i++)
                {
                    dgv_Bill.Rows.Add();
                    dgv_Bill.Rows[i].Cells["Date"].Value = dtCustBill.Rows[i - 1]["Date"].ToString();
                    dgv_Bill.Rows[i].Cells["BillNo"].Value = dtCustBill.Rows[i - 1]["BillNo"].ToString();
                    dgv_Bill.Rows[i].Cells["Amount"].Value = dtCustBill.Rows[i - 1]["BillAmount"].ToString();
                    dgv_Bill.Rows[i].Cells["ExtraCharges"].Value = dtCustBill.Rows[i - 1]["ExtraCharges"].ToString();
                }
            }
            

            dtpay = _s.GetCustomerPayment(Custid);
            if (dtpay.Rows.Count > 0)
            {
                for (int i = 0; i < dtpay.Rows.Count; i++)
                {
                    dgv_Payment.Rows.Add();
                    dgv_Payment.Rows[i].Cells["PayDate"].Value = dtpay.Rows[i]["Date"].ToString();
                    dgv_Payment.Rows[i].Cells["PaidAmt"].Value = dtpay.Rows[i]["Amt"].ToString();
                    dgv_Payment.Rows[i].Cells["PayType"].Value = dtpay.Rows[i]["Paymode"].ToString();
                    dgv_Payment.Rows[i].Cells["ReceiptNo"].Value = dtpay.Rows[i]["BillNo"].ToString();

                }
            }
                
            string TotalBill =Convert.ToString(_c.sumGridViewColumn(dgv_Bill, "Amount"));
            string TotalPaid = Convert.ToString(_c.sumGridViewColumn(dgv_Payment, "PaidAmt"));
            string TotalExtra = Convert.ToString(_c.sumGridViewColumn(dgv_Bill, "ExtraCharges"));
            string Balance = Convert.ToString( (Convert.ToDouble(TotalBill) + (Convert.ToDouble(TotalExtra))) - (Convert.ToDouble(TotalPaid)));

            txt_Bill.Text = TotalBill;
            txt_Extra.Text = TotalExtra;
            txt_payment.Text = TotalPaid;
            txt_balance.Text = Balance;
            cmb_supplier.Focus();

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

        private void print()
        {
            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.SaleLedger);
            _obj(dtCustBill, dtpay, txt_Bill.Text,txt_payment.Text,txt_balance.Text,txt_Extra.Text);
            _objfrm_ReportViewer.Show();
        }

        private void dgv_Bill_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string BillNo = dgv_Bill.Rows[e.RowIndex].Cells["BillNo"].Value.ToString();
            if (BillNo[0] == 'S')
            {
                CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                ViewData _obj = new ViewData(_objfrm_ReportViewer.CustomerBill);
                _obj(BillNo,"View");
                _objfrm_ReportViewer.Show();
            }

            if (BillNo[0] == 'T')
            {
                CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                ViewData _obj = new ViewData(_objfrm_ReportViewer.CustomerBillEst);
                _obj(BillNo, "View");
                _objfrm_ReportViewer.Show();
            }



        }
    }
}
