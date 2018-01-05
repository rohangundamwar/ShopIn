
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;
using System.IO;

namespace PrimeSolutions.Common
{
    public partial class frm_Setting : Form
    {
        public frm_Setting()
        {
            InitializeComponent();
        }

        AllClassFile _a = new AllClassFile();
        ClsFinancialYear _f = new ClsFinancialYear();

        private void frm_Setting_Load(object sender, EventArgs e)
        {
            DataTable dt = _a.getallssetting();

            // Get crystal report list

            DirectoryInfo DirInfo = new DirectoryInfo(Environment.CurrentDirectory);

            foreach (FileInfo fi in DirInfo.GetFiles("*.rpt"))
            {
                cmb_SaleBill.Items.Add(fi.Name);
                cmb_estimate.Items.Add(fi.Name);
                cmb_PurchaseBill.Items.Add(fi.Name);
                cmb_ServiceInc.Items.Add(fi.Name);
            }

            //2 Barcode
            txt_barcode.Text = dt.Rows[0]["BarcodeCount"].ToString();
            //4 Bill Count
            txt_print.Text = dt.Rows[0]["BillCount"].ToString();
            //1 Barcode Check
            if (dt.Rows[0]["Barcode"].ToString() == "Yes")
                rbt_yes1.Checked = true;
            else
                rbt_No1.Checked = true;
            //3 Barcode Type
            cmb_BarcodeType.Text = dt.Rows[0]["BarcodeType"].ToString();

            //Bill Type
            cmb_BillType.Text = dt.Rows[0]["BillType"].ToString();

            //4 maintain
            cmb_maintain.Text = dt.Rows[0]["Maintenance"].ToString();

            //5 Set Crystal Report
            cmb_SaleBill.Text = _a.GetSaleBillName().Rows[0]["SaleBill"].ToString();
            cmb_estimate.Text = _a.GetSaleBillName().Rows[1]["SaleBill"].ToString();
            cmb_PurchaseBill.Text = _a.GetSaleBillName().Rows[2]["SaleBill"].ToString();
            cmb_ServiceInc.Text = _a.GetSaleBillName().Rows[3]["SaleBill"].ToString();

            //6 payment form

            if (dt.Rows[0]["PaymentForm"].ToString() == "1")
                rbt_PaymentYes.Checked = true;
            else
                rbt_PaymentNo.Checked = true;

            //7 Get Financial Year
            DataTable yr = _f.getFinancialYear();
            string start = yr.Rows[0]["startyear"].ToString();
            string end = yr.Rows[0]["endyear"].ToString();

            dtp_start.Value = Convert.ToDateTime(start);
            dtp_end.Value = Convert.ToDateTime(end);

            //8 Estimate Payment Form
            if (dt.Rows[0]["EstimatePayment"].ToString() == "1")
                rbt_EstPayYes.Checked = true;
            else
                rbt_EstPayNo.Checked = true;





        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            string barcode;
            string payment;
            string StartDate;
            string EndDate;
            string Estpayment;

            if (rbt_yes1.Checked == true)
            {
                barcode = "Yes";
            }
            else
            {
                barcode = "No";
            }
            if (rbt_PaymentYes.Checked == true)
            {
                payment = "1";
            }
            else
            {
                payment = "0";
            }

            if (rbt_EstPayYes.Checked == true)
            {
                Estpayment = "1";
            }
            else
            {
                Estpayment = "0";
            }

            
            StartDate = dtp_start.Value.ToString("dd/MM/yyyy");
            EndDate = dtp_end.Value.ToString("dd/MM/yyyy");

            _a.SetAllssetting(txt_barcode.Text, txt_print.Text,barcode,cmb_BarcodeType.Text,payment, Estpayment,cmb_SaleBill.Text, cmb_PurchaseBill.Text,cmb_estimate.Text, StartDate, EndDate,cmb_maintain.Text,cmb_ServiceInc.Text,cmb_BillType.Text);

            MessageBox.Show("Setting Saved");
        }
    }
}
