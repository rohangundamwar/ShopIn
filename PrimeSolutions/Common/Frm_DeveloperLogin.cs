using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions.Common
{
    public partial class Frm_DeveloperLogin : Form
    {
        public bool Developer_login_Result { get; set; }
        public Frm_DeveloperLogin()
        {
            InitializeComponent();
            Developer_login_Result = false;
        }

        private void bttn_login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void bttn_cancel_Click(object sender, EventArgs e)
        {
            Developer_login_Result = false;
            this.Close();
        }

        private void Frm_DeveloperLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void login()
        {
            if (txt_password.Text == "Prime@111")
            {
                Developer_login_Result = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Worng Password \n Please Try Again");
                txt_password.ResetText();
                txt_password.Focus();
            }
        }
    }
}
