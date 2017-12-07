using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;


namespace PrimeSolutions.Common
{
    public partial class frm_Login : Form
    {
        clsCommon _common = new clsCommon();
        public bool result { get; set; }

        public frm_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Password.Focus();
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_login.Focus();
            }
        }

        private void clear()
        {
            txt_Password.Text=" ";
            txt_UserId.Text = " ";
            txt_UserId.Focus();
        }

        private void bttn_login_Click(object sender, EventArgs e)
        {
            string password = _common.GetPassword(txt_UserId.Text);

            if (password == string.Empty)
            {
                lbl_message.Text = "MSG: Invalid User ID";
                lbl_message.Visible = true;
                clear();
            }
            else
            if (password == txt_Password.Text)
            {
                result = true;
                this.Close();
            }

            else
            {
                MessageBox.Show("Incorrect Password \n      Please Try Again ");
                clear();
                result = false;
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            clear();
        }
    }
}
