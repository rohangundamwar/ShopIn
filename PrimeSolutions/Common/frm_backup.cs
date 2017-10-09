using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using PrimeSolutions.Library;

namespace PrimeSolutions.Common
{
    public partial class frm_backup : Form
    {
        SQLHelper _objSqlHelper = new SQLHelper();

        public frm_backup()
        {
            InitializeComponent();
        }
        
        private void bttn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_DataBackup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frm_backup_Load(object sender, EventArgs e)
        {
            txt_DatabaseName.Text = clsVariable.ConnectionDatabase;
        }

        public void blank(string str)
        {
            if (str == "backup")
            {
                saveFileDialog1.FileName = txt_DatabaseName.Text;
                saveFileDialog1.ShowDialog();
                string s = null;
                s = saveFileDialog1.FileName;
                string stru = "Backup database " + clsVariable.ConnectionDatabase + " to disk='"+s+"'";
                _objSqlHelper.ExecuteSql(stru);

                MessageBox.Show("Your Database Backup is done");
            }
        }

        private void bttn_backup_Click(object sender, EventArgs e)
        {
            blank("backup");
        }

        private void bttn_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
