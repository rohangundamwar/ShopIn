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
            int j=0;
            try
            {
                DataTable Bill = _p.GetPurchaseBill();
                if (Bill.Rows.Count > 0)
                    for (j = 0; j < Bill.Rows.Count; j++)
                    {
                        string HSNAll = _p.GetAllHSN(Bill.Rows[j]["BillNo"].ToString(), "Purchase");
                        DataTable Supplier = _p.GetSupplierDetailsFromBill(Bill.Rows[j]["BillNo"].ToString());
                        if (Supplier.Rows.Count != 0)
                        {
                            dgv_SupplierBill.Rows.Add();
                            dgv_SupplierBill.Rows[j].Cells["SrNo"].Value = Convert.ToString(j + 1);
                            dgv_SupplierBill.Rows[j].Cells["BillNo"].Value = Supplier.Rows[0]["BillNo"].ToString();
                            dgv_SupplierBill.Rows[j].Cells["Date"].Value = Supplier.Rows[0]["Date"].ToString();
                            dgv_SupplierBill.Rows[j].Cells["SupplierName"].Value = Supplier.Rows[0]["Name"].ToString();
                            dgv_SupplierBill.Rows[j].Cells["GSTIN"].Value = Supplier.Rows[0]["GSTIN"].ToString();
                            dgv_SupplierBill.Rows[j].Cells["HSNCode"].Value = HSNAll;
                            dgv_SupplierBill.Rows[j].Cells["BillAmt"].Value = Supplier.Rows[0]["Amount"].ToString();
                            dgv_SupplierBill.Rows[j].Cells["CGST"].Value = Supplier.Rows[0]["CGST"].ToString();
                            dgv_SupplierBill.Rows[j].Cells["SGST"].Value = Supplier.Rows[0]["SGST"].ToString();
                            dgv_SupplierBill.Rows[j].Cells["IGST"].Value = Supplier.Rows[0]["IGST"].ToString();
                            dgv_SupplierBill.Rows[j].Cells["TotalAmt"].Value = Supplier.Rows[0]["GrandTotal"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Supplier Details Missing");
                        }
                    }
                j = j + 1;
                dgv_SupplierBill.Rows.Add();
                dgv_SupplierBill.Rows[j].Cells["HSNCode"].Value = "Total";
                dgv_SupplierBill.Rows[j].Cells["BillAmt"].Value = _common.sumGridViewColumn(dgv_SupplierBill, "BillAmt");
                dgv_SupplierBill.Rows[j].Cells["CGST"].Value = _common.sumGridViewColumn(dgv_SupplierBill, "CGST");
                dgv_SupplierBill.Rows[j].Cells["SGST"].Value = _common.sumGridViewColumn(dgv_SupplierBill, "SGST");
                dgv_SupplierBill.Rows[j].Cells["IGST"].Value = _common.sumGridViewColumn(dgv_SupplierBill, "IGST");
                dgv_SupplierBill.Rows[j].Cells["TotalAmt"].Value = _common.sumGridViewColumn(dgv_SupplierBill, "TotalAmt");
            }
            catch (Exception ex)
            {
                _error.AddException(ex, "SupplierGSTReport");
            }
            

        }

        private void bttn_excel_Click(object sender, EventArgs e)
        {
            _e.exporttoexcel(dgv_SupplierBill, "SupplierGSTReport", dtp1.Value.ToString("dd_MM_yyyy"));
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
