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
    public partial class frm_SupplierGSTReport : Form
    {
        public frm_SupplierGSTReport()
        {
            InitializeComponent();
        }

        PurchaseCommon _p = new PurchaseCommon();
        ExportToExcel _e = new ExportToExcel();
        clsCommon _common = new clsCommon();
        ErrorLog _error = new ErrorLog();


        private void frm_SupplierBill_Load(object sender, EventArgs e)
        {
        }


        private void GetReport()
        {
            int i = 0;
            DataTable Bill = _p.GetSupplierGSTBill(dtp_from.Value.ToString("dd/MM/yyyy"), dtp_to.Value.ToString("dd/MM/yyyy"));
            dgv_SupplierBill.Rows.Clear();
            dgv_SupplierBill.Rows.Add();
            if (Bill.Rows.Count > 0)
            {
                for (i = 0; i < Bill.Rows.Count; i++)
                {
                    dgv_SupplierBill.Rows[i].Cells["SrNo"].Value = Convert.ToString(i + 1);
                    dgv_SupplierBill.Rows[i].Cells["BillNo"].Value = Bill.Rows[i]["BillNo"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["Date"].Value = Bill.Rows[i]["Date"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["SupplierName"].Value = Bill.Rows[i]["Name"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["GSTIN"].Value = Bill.Rows[i]["GSTIN"].ToString();
                    string HSN = _p.GetAllHSNPurchase(Bill.Rows[i]["RefrenceNo"].ToString());
                    dgv_SupplierBill.Rows[i].Cells["HSNCode"].Value = HSN;
                    dgv_SupplierBill.Rows[i].Cells["BillAmt"].Value = Bill.Rows[i]["Amount"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["CGST"].Value = Bill.Rows[i]["CGST"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["SGST"].Value = Bill.Rows[i]["SGST"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["IGST"].Value = Bill.Rows[i]["IGST"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["TotalAmt"].Value = Bill.Rows[i]["GrandTotal"].ToString();
                    dgv_SupplierBill.Rows.Add();
                }

            }


            int j = i + 1;
            dgv_SupplierBill.Rows.Add();
            dgv_SupplierBill.Rows[j].Cells["HSNCode"].Value = "Total";
            dgv_SupplierBill.Rows[j].Cells["BillAmt"].Value = _common.sumGridViewColumn(dgv_SupplierBill, "BillAmt");
            dgv_SupplierBill.Rows[j].Cells["CGST"].Value = _common.sumGridViewColumn(dgv_SupplierBill, "CGST");
            dgv_SupplierBill.Rows[j].Cells["SGST"].Value = _common.sumGridViewColumn(dgv_SupplierBill, "SGST");
            dgv_SupplierBill.Rows[j].Cells["IGST"].Value = _common.sumGridViewColumn(dgv_SupplierBill, "IGST");
            dgv_SupplierBill.Rows[j].Cells["TotalAmt"].Value = _common.sumGridViewColumn(dgv_SupplierBill, "TotalAmt");
        }

        private void bttn_excel_Click(object sender, EventArgs e)
        {
            _e.exporttoexcel(dgv_SupplierBill, "SupplierGSTReport", dtp_from.Value.ToString("dd_MM") + "TO" + dtp_to.Value.ToString("dd_MM"));
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
            GetReport();
        }
    }
}
