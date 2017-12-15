using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;

namespace PrimeSolutions.Report.Customer
{
    public partial class frm_CustomerBalance : Form
    {
        
        public frm_CustomerBalance()
        {
            InitializeComponent();
        }

        AllClassFile _a = new AllClassFile();
        clsCommon _common = new clsCommon();
        SaleCommon _s = new SaleCommon();
        DataTable cust;
        CustomerCommon _Cust = new CustomerCommon();
        ExportToExcel _e = new ExportToExcel();
        public delegate void SendData(DataTable dt,string Type,string Date);


        private void frm_CustomerBalance_Load(object sender, EventArgs e)
        {
            cmb_customer.SelectedIndex = -1;
            cust = _s.GetCustomer();
            cmb_customer.DataSource = cust;
            dgv_Balance.Rows.Clear();
            for (int i = 0; i < cust.Rows.Count; i++)
            {
                dgv_Balance.Rows.Add();
                dgv_Balance.Rows[i].Cells["Name"].Value = cust.Rows[i]["CustomerName"].ToString();
                string CustId = cust.Rows[i]["CustId"].ToString();
                dgv_Balance.Rows[i].Cells["TotalPurchase"].Value = _s.GetTotalPurchase(CustId,"Sale");
                DataTable count = _s.GetCustomerBill(CustId);
                dgv_Balance.Rows[i].Cells["NoOfBill"].Value = count.Rows.Count;
                dgv_Balance.Rows[i].Cells["TotalPaid"].Value = _s.GetTotalPaid(CustId);
                dgv_Balance.Rows[i].Cells["TotalBalance"].Value = Convert.ToString(_s.GetBalance(CustId, "Sale"));

            }
             
        }

        private void bttn_Find_Click(object sender, EventArgs e)
        {
            dgv_Balance.Rows.Clear();
            dgv_Balance.Rows.Add();
            dgv_Balance.Rows[0].Cells["Name"].Value = cmb_customer.Text;
            string CustId = cust.Rows[cmb_customer.SelectedIndex]["CustId"].ToString();
            dgv_Balance.Rows[0].Cells["TotalPurchase"].Value = _s.GetTotalPurchase(CustId,"Sale");
            DataTable count = _s.GetCustomerBill(CustId);
            dgv_Balance.Rows[0].Cells["NoOfBill"].Value = count.Rows.Count;
            dgv_Balance.Rows[0].Cells["TotalPaid"].Value = _s.GetTotalPaid(CustId);
            dgv_Balance.Rows[0].Cells["TotalBalance"].Value = Convert.ToString(_s.GetBalance(CustId,"Sale"));
        }

        private void bttn_reset_Click(object sender, EventArgs e)
        {
            frm_CustomerBalance_Load(sender,e);
        }

        private void bttn_Excel_Click(object sender, EventArgs e)
        {
            _e.exporttoexcel(dgv_Balance,"CustomerBalance", dtp_date.Value.ToString("dd_MM_yyyy"));
            
        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {
            DataTable DT = _common.DataGridView2DataTable(dgv_Balance,"Balance",0);
            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.Balance);
            _obj(DT, "Customer",dtp_date.Value.ToString("dd/MM/yyyy"));
        }
    }
}