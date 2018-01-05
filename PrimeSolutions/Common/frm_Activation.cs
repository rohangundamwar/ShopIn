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
    public partial class frm_Activation : Form
    {
        SQLHelper _sql = new SQLHelper();
        cls_Activation _act = new cls_Activation();

        public frm_Activation()
        {
            InitializeComponent();
            lbl_ProductValue.Text = _act.getMotherBoardID();
        }

        private void txt_ProductKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Save.Focus();
            }
        }

        private void bttn_Save_Click(object sender, EventArgs e)
        {
            string MBID = _act.getMotherBoardID(); 
            string Encr = _act.Encrypt(MBID);

            if (Encr == txt_ProductKey.Text)
            {
                string str = "Update Activation set SerialNo='" + txt_ProductKey.Text + "' where SrNo='1'";
                _sql.ExecuteScalar(str);
                MessageBox.Show("Activation Successfull");
                this.Close();
            }
            else
            {   
                MessageBox.Show("WRONG Product Key \n Please try Later", "Install information", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }

        private void frm_Activation_Load(object sender, EventArgs e)
        {

        }
    }
}
