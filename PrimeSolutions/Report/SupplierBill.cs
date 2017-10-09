
using PrimeSolutions.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions.Report
{
    public partial class SupplierBill : Form
    {
        Library.PurchaseCommon _p = new Library.PurchaseCommon();
        AllClassFile _C = new AllClassFile();
        ExportToExcel _e = new ExportToExcel();
        
        public SupplierBill()
        {
            InitializeComponent();
        }

        private void SupplierBill_Load(object sender, EventArgs e)
        {
            cmb_BillNo.DataSource = _p.GetSupplierBillNo();
            cmb_BillNo.SelectedIndex = 1;
        }

        private void cmb_BillNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_BillItem.Rows.Clear();
            DataTable SupplierItem = _p.GetPurchaseBillItem(cmb_BillNo.Text);
            for (int i = 0; i < SupplierItem.Rows.Count; i++)
            {
                dgv_BillItem.Rows.Add();
                dgv_BillItem.Rows[i].Cells["Category"].Value = SupplierItem.Rows[i]["Category"].ToString();
                dgv_BillItem.Rows[i].Cells["SubCategory"].Value = SupplierItem.Rows[i]["SubCategory"].ToString();
                int qty = _C.getQtySupplier(SupplierItem.Rows[i]["category"].ToString(), SupplierItem.Rows[i]["SubCategory"].ToString(),cmb_BillNo.Text);
                dgv_BillItem.Rows[i].Cells["Quantity"].Value = qty.ToString();

            } 
            
        }

        private void bttn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_Excel_Click(object sender, EventArgs e)
        {
            DataTable dt = _p.GetSupplierFromBillNo(cmb_BillNo.Text);
            _e.exporttoexcel(dgv_BillItem,dt,"Supplier Bill Item", dtp_date.Value.ToString("dd_MM_yyyy"));
            
        }

        private void SupplierBill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
