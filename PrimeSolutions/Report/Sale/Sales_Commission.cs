using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;


namespace PrimeSolutions.Report.Sale
{
    public partial class frm_Sales_Commission : Form
    {
        SaleCommon _s = new SaleCommon();
        ExportToExcel _e = new ExportToExcel();
        AllClassFile _C = new AllClassFile();
        DataTable SalesmanMaster, name;

        public frm_Sales_Commission()
        {
            InitializeComponent();
            SalesmanMaster = _s.getSalesMan();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exel_Click(object sender, EventArgs e)
        {
            _e.exporttoexcel(dvg_SalesCommision, "SalesManList", dtp_From.Value.ToString("dd_MM_yyyy"));
        }

        private void frm_Sales_Commission_Load(object sender, EventArgs e)
        {
            Cmb_Name.DataSource = SalesmanMaster;
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            dvg_SalesCommision.Rows.Clear();
            DataTable dt = _s.GetSalemanReport(dtp_From.Value.ToString("dd/MM/yyyy"), dtp_To.Value.ToString("dd/MM/yyyy"));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dvg_SalesCommision.Rows.Add();
                dvg_SalesCommision.Rows[i].Cells["Name"].Value = dt.Rows[i]["Name"].ToString();
                dvg_SalesCommision.Rows[i].Cells["Sales_Amount"].Value = dt.Rows[i]["Amount"].ToString();
            }
        }

        private void Cmb_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                SalesmanMaster = _s.getSalesMan();
                Cmb_Name.DataSource = SalesmanMaster;
        }
    }
}
