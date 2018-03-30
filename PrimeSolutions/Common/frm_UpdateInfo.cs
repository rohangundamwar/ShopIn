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
    public partial class frm_UpdateInfo : Form
    {
        SQLHelper _sql = new SQLHelper();
        public frm_UpdateInfo()
        {
            InitializeComponent();
        }

        private void frm_UpdateInfo_Load(object sender, EventArgs e)
        {
            DataTable info = _sql.GetDataTable("select * from CompanyMaster");
            txt_name.Text = info.Rows[0]["Name"].ToString();
            txt_add.Text = info.Rows[0]["Address"].ToString();
            txt_city.Text = info.Rows[0]["City"].ToString();
            txt_district .Text = info.Rows[0]["District"].ToString();
            cmb_State.Text = info.Rows[0]["State"].ToString();
            txt_contact1.Text = info.Rows[0]["Contact1"].ToString();
            txt_contact2.Text = info.Rows[0]["Contact2"].ToString();
            txt_PAN.Text = info.Rows[0]["PANNo"].ToString();
            txt_GSTIN.Text = info.Rows[0]["GSTIN"].ToString();
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            string Update = "Update CompanyMaster set Name='" + txt_name.Text + "',Address='" + txt_add.Text + "',City='" + txt_city.Text + "',District='" + txt_district.Text + "',State='" + cmb_State.Text + "',Contact1='" + txt_contact1.Text + "',Contact2='" + txt_contact2.Text + "',GSTIN='" + txt_GSTIN.Text + "',PANNo='" + txt_PAN.Text + "'";
            _sql.ExecuteScalar(Update);
            MessageBox.Show("Updated Successfully");
        }
    }
}
