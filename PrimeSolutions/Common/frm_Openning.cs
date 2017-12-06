using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;

namespace PrimeSolutions.Common
{
    public partial class frm_Openning : Form
    {
        public frm_Openning()
        {
            InitializeComponent();
        }

        SaleCommon _s = new SaleCommon();
        SQLHelper _sql = new SQLHelper();
        CustomerCommon _Cust = new CustomerCommon();
        string CustomerEx = "No";


        private void bttn_Save_Click(object sender, EventArgs e)
        {
            if (CustomerEx == "No")
            {
                _Cust.AddCustomerDetails(txt_AccNo.Text, cmb_Name.Text, txt_Address.Text, txt_ContactNo.Text, txt_PanNo.Text, txt_GSTIN.Text, cmb_State.Text, txt_City.Text, txt_Opening.Text);
                MessageBox.Show("Customer Added Successfully");
            }
            else
            {
                _Cust.UpdateCustomer(txt_AccNo.Text, cmb_Name.Text, txt_Address.Text, txt_ContactNo.Text, txt_PanNo.Text, txt_GSTIN.Text, cmb_State.Text, txt_City.Text, txt_Opening.Text);
                MessageBox.Show("Customer Details Updated Successfully");
            }
            
            MasterClear();
        }

        private void cmb_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable customer = _s.GetCustomerDetails(cmb_Name.Text);
                if (customer.Rows.Count > 0)
                {
                    CustomerEx = "Yes";
                    txt_AccNo.Text = customer.Rows[0]["CustId"].ToString();
                    txt_Address.Text = customer.Rows[0]["Address"].ToString();
                    cmb_State.Text = customer.Rows[0]["State"].ToString();
                    txt_City.Text = customer.Rows[0]["City"].ToString();
                    txt_ContactNo.Text = customer.Rows[0]["ContactNo"].ToString();
                    txt_PanNo.Text = customer.Rows[0]["PanNo"].ToString();
                    txt_GSTIN.Text = customer.Rows[0]["GSTIN"].ToString();
                    txt_Opening.Text = customer.Rows[0]["Opening"].ToString();
                }
                else
                {
                    CustomerEx = "No";
                    cmb_State.Select();
                }

            }

        }

        private void frm_Openning_Load(object sender, EventArgs e)
        {
            cmb_Name.DataSource = _Cust.GetCustomerDeatils();
            txt_AccNo.Text = _sql.GetMaxID("C", "0");
            cmb_Name.SelectedIndex = -1;
        }
        private void MasterClear()
        {
            txt_AccNo.Text = _sql.GetMaxID("C", "0");
            txt_Address.Text = "";
            cmb_State.Text = "";
            txt_City.Text = "";
            txt_ContactNo.Text = "";
            txt_PanNo.Text = "";
            txt_GSTIN.Text = "";
            txt_Opening.Text = "";
        }

        private void Bttn_Reset_Click(object sender, EventArgs e)
        {
            MasterClear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_State_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Address.Focus();
            }
        }

        private void txt_Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_City.Focus();
            }
        }

        private void txt_City_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ContactNo.Focus();
            }
        }

        private void txt_ContactNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PanNo.Focus();
            }
        }

        private void txt_PanNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_GSTIN.Focus();
            }
        }

        private void txt_GSTIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Opening.Focus();
            }
        }

        private void txt_Opening_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Save.Focus();
            }
        }
    }
}
