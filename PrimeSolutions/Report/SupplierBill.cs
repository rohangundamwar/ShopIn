﻿
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
        DataTable Supplier,Bill; 
        
        public SupplierBill()
        {
            InitializeComponent();
            Supplier = _C.getSupplierName();
        }

        private void SupplierBill_Load(object sender, EventArgs e)
        {
            cmb_Name.DataSource = Supplier;
        }

        private void cmb_BillNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_BillItem.Rows.Clear();
            DataTable SupplierItem = _p.GetPurchaseBillItem(Bill.Rows[cmb_BillNo.SelectedIndex]["RefrenceNo"].ToString());
            for (int i = 0; i < SupplierItem.Rows.Count; i++)
            {
                dgv_BillItem.Rows.Add();
                dgv_BillItem.Rows[i].Cells["Category"].Value = SupplierItem.Rows[i]["Category"].ToString();
                dgv_BillItem.Rows[i].Cells["SubCategory"].Value = SupplierItem.Rows[i]["SubCategory"].ToString();
                dgv_BillItem.Rows[i].Cells["Size"].Value = SupplierItem.Rows[i]["Size"].ToString();

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

        private void cmb_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bill= _p.GetSupplierBill(Supplier.Rows[cmb_Name.SelectedIndex]["SupplierNo"].ToString());
            cmb_BillNo.DataSource = Bill;
        }
    }
}
