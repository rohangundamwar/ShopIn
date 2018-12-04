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
        public string type { get; set; }

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
            DataTable user = _common.GetPassword(txt_UserId.Text);
            try
            {
                if (user.Rows.Count == 0)
                {
                    lbl_message.Text = "MSG: Invalid User ID";
                    lbl_message.Visible = true;
                    clear();
                }
                else
            if (user.Rows[0]["Password"].ToString() == txt_Password.Text)
                {
                    result = true;
                    this.Close();
                }

                else
                {
                    lbl_message.Text = "Incorrect Password";
                    lbl_message.Visible = true;
                    clear();
                }
                if (user.Rows.Count > 0)
                {
                    type = user.Rows[0]["Type"].ToString();
                }
    
            }

            catch (Exception ex)
            {
                string X = ex.Message;
            }
            
            
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            clear();
        }

        
    }
}
