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
    public partial class frm_SupplierBill : Form
    {
        public frm_SupplierBill()
        {
            InitializeComponent();
        }

        PurchaseCommon _p = new PurchaseCommon();
        ExportToExcel _e = new ExportToExcel();

        private void frm_SupplierBill_Load(object sender, EventArgs e)
        {
            DataTable dt = _p.GetPurchaseBill();
            if(dt.Rows.Count>0)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgv_SupplierBill.Rows.Add();
                    dgv_SupplierBill.Rows[i].Cells["SrNo"].Value = i+1;
                    dgv_SupplierBill.Rows[i].Cells["Name"].Value = dt.Rows[i]["Name"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["BillNo"].Value = dt.Rows[i]["BillNo"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["Date"].Value = dt.Rows[i]["Date"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["BillAmt"].Value = dt.Rows[i]["Amount"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["CGST"].Value = dt.Rows[i]["CGST"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["SGST"].Value = dt.Rows[i]["SGST"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["IGST"].Value = dt.Rows[i]["IGST"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["TotalAmt"].Value = dt.Rows[i]["GrandTotal"].ToString();

                }
        }

        private void bttn_excel_Click(object sender, EventArgs e)
        {
            _e.exporttoexcel(dgv_SupplierBill, "SupplierBillList", dtp1.Value.ToString("dd_MM_yyyy"));
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

        private void dgv_SupplierBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
