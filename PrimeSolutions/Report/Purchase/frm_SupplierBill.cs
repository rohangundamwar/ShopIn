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
        SaleCommon _s = new SaleCommon();

        private void frm_SupplierBill_Load(object sender, EventArgs e)
        {

        }

        private void bttn_excel_Click(object sender, EventArgs e)
        {
            _e.exporttoexcel(dgv_SupplierBill, "SupplierBillList", dtp_to.Value.ToString("dd_MM_yyyy"));
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

        private void bttn_Generate_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void Generate()
        {
            dgv_SupplierBill.Rows.Clear();
            DataTable SupplierBill = _p.GetSupplierBill(dtp_from.Value.ToString("dd/MM/yyyy"), dtp_to.Value.ToString("dd/MM/yyyy"));
            for (int i = 0; i < SupplierBill.Rows.Count; i++)
            {
                dgv_SupplierBill.Rows.Add();
                dgv_SupplierBill.Rows[i].Cells["SrNo"].Value = i + 1;
                dgv_SupplierBill.Rows[i].Cells["Name"].Value = SupplierBill.Rows[i]["Name"].ToString();
                dgv_SupplierBill.Rows[i].Cells["BillNo"].Value = SupplierBill.Rows[i]["BillNo"].ToString();
                dgv_SupplierBill.Rows[i].Cells["RefrenceNo"].Value = SupplierBill.Rows[i]["RefrenceNo"].ToString();
                dgv_SupplierBill.Rows[i].Cells["Date"].Value = SupplierBill.Rows[i]["Date"].ToString();
                dgv_SupplierBill.Rows[i].Cells["BillAmt"].Value = SupplierBill.Rows[i]["Amount"].ToString();
                dgv_SupplierBill.Rows[i].Cells["CGST"].Value = SupplierBill.Rows[i]["CGST"].ToString();
                dgv_SupplierBill.Rows[i].Cells["SGST"].Value = SupplierBill.Rows[i]["SGST"].ToString();
                dgv_SupplierBill.Rows[i].Cells["IGST"].Value = SupplierBill.Rows[i]["IGST"].ToString();
                dgv_SupplierBill.Rows[i].Cells["TotalAmt"].Value = SupplierBill.Rows[i]["GrandTotal"].ToString();
            }
        }

        private void Bttn_delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_SupplierBill.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgv_SupplierBill.Rows[i].Cells["Chk"].Value))
                {
                    _s.DeleteBillDetails(dgv_SupplierBill.Rows[i].Cells["RefrenceNo"].Value.ToString(),"Purchase");
                    _s.DeleteBillItem(dgv_SupplierBill.Rows[i].Cells["RefrenceNo"].Value.ToString(), "Purchase");
                }
                
            }

            MessageBox.Show("Deleted Succesfully");
            Generate();
        }
    }
}
