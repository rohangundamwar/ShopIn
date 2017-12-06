using PrimeSolutions.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions.Report.Purchase
{
    public partial class TotalGSTReport : Form
    {
        PurchaseCommon _purchase = new PurchaseCommon();
        public TotalGSTReport()
        {
            InitializeComponent();
        }

        private void TotalGSTReport_Load(object sender, EventArgs e)
        {
            DataTable dt = _purchase.GetSupplierBill("01/11/20017","31/11/2017");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataTable dt1 =_purchase.GetBillItemAmount(dt.Rows[i]["RefrenceNo"].ToString());
                if(dt1.Rows.Count>0)
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[j].Cells["SupplierName"].Value = dt.Rows[i]["Name"].ToString();
                        dataGridView1.Rows[j].Cells["GSTIN"].Value = dt.Rows[i]["GSTIN"].ToString();
                        dataGridView1.Rows[j].Cells["GST5"].Value = dt1.Rows[j]["CGST"].ToString();
                        dataGridView1.Rows[j].Cells["SGST5"].Value = dt1.Rows[j]["SGST"].ToString();
                        dataGridView1.Rows[j].Cells["IGST5"].Value = dt1.Rows[j]["IGST"].ToString();
                        dataGridView1.Rows[j].Cells["TaxableAmt"].Value = dt1.Rows[j]["Price"].ToString();



                    }
                
            }
            
        }
    }
}
