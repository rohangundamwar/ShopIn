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
                    dgv_SupplierBill.Rows[i].Cells["SrNo"].Value = dt.Rows[i]["SrNo"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["BillAmt"].Value = dt.Rows[i]["BillAmt"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["Vatper"].Value = dt.Rows[i]["Vatper"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["VAT"].Value = dt.Rows[i]["VAT"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["TotalAmt"].Value = dt.Rows[i]["TotalAmt"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["PaidAmt"].Value = dt.Rows[i]["PaidAmt"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["BalanceAmt"].Value = dt.Rows[i]["BalanceAmt"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["Date"].Value = dt.Rows[i]["SoftDate"].ToString();
                    dgv_SupplierBill.Rows[i].Cells["BillNo"].Value = dt.Rows[i]["BillNo"].ToString();
                }
        }

        private void bttn_excel_Click(object sender, EventArgs e)
        {
            DataTable dt = _p.GetSupplierFromBillNo(dgv_SupplierBill.Rows[0].Cells["BillNo"].Value.ToString());
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
    }
}
