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
    public partial class frm_SupplierBalance : Form
    {
        public frm_SupplierBalance()
        {
            InitializeComponent();
        }

        AllClassFile _a = new AllClassFile();
        SaleCommon _s = new SaleCommon();
        PurchaseCommon _Purchase = new PurchaseCommon();
        DataTable cust;
        CustomerCommon _Cust = new CustomerCommon();
        ExportToExcel _e = new ExportToExcel();
       

        private void frm_CustomerBalance_Load(object sender, EventArgs e)
        {
            cmb_customer.SelectedIndex = -1;
            cust = _a.getSupplierName();
            cmb_customer.DataSource = cust;
            dgv_Balance.Rows.Clear();
            for (int i = 0; i < cust.Rows.Count; i++)
            {
                dgv_Balance.Rows.Add();
                dgv_Balance.Rows[i].Cells["CustomerName"].Value = cust.Rows[i]["Name"].ToString();
                string CustId = cust.Rows[i]["SupplierNo"].ToString();
                dgv_Balance.Rows[i].Cells["TotalPurchase"].Value = _s.GetTotalSupplierPurchase(CustId, "Purchase");
                DataTable count = _Purchase.GetSupplierBill(CustId);
                dgv_Balance.Rows[i].Cells["NoOfBill"].Value = count.Rows.Count;
                dgv_Balance.Rows[i].Cells["TotalPaid"].Value = _s.GetTotalPaid(CustId);
                dgv_Balance.Rows[i].Cells["TotalBalance"].Value = Convert.ToString(_s.GetBalance(CustId, "Purchase"));

            }
             
        }

        private void bttn_Find_Click(object sender, EventArgs e)
        {
            dgv_Balance.Rows.Clear();
            dgv_Balance.Rows.Add();
            dgv_Balance.Rows[0].Cells["CustomerName"].Value = cmb_customer.Text;
            string CustId = cust.Rows[cmb_customer.SelectedIndex]["SupplierNo"].ToString();
            dgv_Balance.Rows[0].Cells["TotalPurchase"].Value = _s.GetTotalSupplierPurchase(CustId,"Purchase");
            DataTable count = _Purchase.GetSupplierBill(CustId);
            dgv_Balance.Rows[0].Cells["NoOfBill"].Value = count.Rows.Count;
            dgv_Balance.Rows[0].Cells["TotalPaid"].Value = _s.GetTotalPaid(CustId);
            dgv_Balance.Rows[0].Cells["TotalBalance"].Value = Convert.ToString(_s.GetBalance(CustId, "Purchase"));
        }

        private void bttn_reset_Click(object sender, EventArgs e)
        {
            frm_CustomerBalance_Load(sender,e);
        }

        private void bttn_Excel_Click(object sender, EventArgs e)
        {
            _e.exporttoexcel(dgv_Balance,"SupplierBalance", dtp_date.Value.ToString("dd_MM_yyyy"));
            
        }
    }
}
