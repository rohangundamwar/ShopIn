using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;

namespace PrimeSolutions.Report.Purchase
{
    public partial class frm_CustomerGSTReport : Form
    {
        public frm_CustomerGSTReport()
        {
            InitializeComponent();
        }

        PurchaseCommon _p = new PurchaseCommon();
        ExportToExcel _e = new ExportToExcel();
        clsCommon _common = new clsCommon();
        ErrorLog _error = new ErrorLog();
        SaleCommon _sale = new SaleCommon(); 


        private void frm_SupplierBill_Load(object sender, EventArgs e)
        {
            
        }

        private void bttn_excel_Click(object sender, EventArgs e)
        {
            try
            {
                _e.exporttoexcel(dgv_SupplierBill, "CustomerGSTReport", dtp_from.Value.ToString("dd_MM") + "TO" + dtp_to.Value.ToString("dd_MM"));
            }
            catch { }
            
        }

        private void bttn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_SupplierBill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_SupplierBill.Rows.Clear();
            GetReport();
        }

        private void GetReport()
        {
            int j = 0;
            try
            {
                DataTable Bill = _sale.GetCustomerReport(dtp_from.Value.ToString("dd/MM/yyyy"),dtp_to.Value.ToString("dd/MM/yyyy"),"GST");
                if (Bill.Rows.Count > 0)
                    for (j = 0; j < Bill.Rows.Count; j++)
                    {
                        string HSNAll = _sale.GetAllHSNSale(Bill.Rows[j]["BillNo"].ToString());
                        if (Bill.Rows.Count != 0)
                        {
                            dgv_SupplierBill.Rows.Add();
                            dgv_SupplierBill.Rows[j].Cells["SrNo"].Value = Convert.ToString(j + 1);
                            dgv_SupplierBill.Rows[j].Cells["BillNo"].Value = Bill.Rows[j]["BillNo"].ToString();
                            dgv_SupplierBill.Rows[j].Cells["Date"].Value = Bill.Rows[j]["Date"].ToString();
                            dgv_SupplierBill.Rows[j].Cells["SupplierName"].Value = Bill.Rows[j]["CustomerName"].ToString();
                            dgv_SupplierBill.Rows[j].Cells["GSTIN"].Value = Bill.Rows[j]["GSTIN"].ToString();
                            dgv_SupplierBill.Rows[j].Cells["HSNCode"].Value = HSNAll;
                            dgv_SupplierBill.Rows[j].Cells["BillAmt"].Value = Bill.Rows[j]["Amount"].ToString();
                            dgv_SupplierBill.Rows[j].Cells["CGST"].Value = Bill.Rows[j]["CGST"].ToString();
                            dgv_SupplierBill.Rows[j].Cells["SGST"].Value = Bill.Rows[j]["SGST"].ToString();
                            dgv_SupplierBill.Rows[j].Cells["IGST"].Value = Bill.Rows[j]["IGST"].ToString();
                            dgv_SupplierBill.Rows[j].Cells["TotalAmt"].Value = Bill.Rows[j]["GrandAmt"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Customer Details Missing");
                        }
                    }
                j = j + 1;
                dgv_SupplierBill.Rows.Add(2);
                dgv_SupplierBill.Rows[j].Cells["HSNCode"].Value = "Total";
                dgv_SupplierBill.Rows[j].Cells["BillAmt"].Value = _common.sumGridViewColumn(dgv_SupplierBill, "BillAmt");
                dgv_SupplierBill.Rows[j].Cells["CGST"].Value = _common.sumGridViewColumn(dgv_SupplierBill, "CGST");
                dgv_SupplierBill.Rows[j].Cells["SGST"].Value = _common.sumGridViewColumn(dgv_SupplierBill, "SGST");
                dgv_SupplierBill.Rows[j].Cells["IGST"].Value = _common.sumGridViewColumn(dgv_SupplierBill, "IGST");
                dgv_SupplierBill.Rows[j].Cells["TotalAmt"].Value = _common.sumGridViewColumn(dgv_SupplierBill, "TotalAmt");

            }
            catch (Exception ex)
            {
                _error.AddException(ex, "CustomerGSTReport");
            }


        }
    }
}
