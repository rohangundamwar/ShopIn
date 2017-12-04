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
    public partial class frm_DeleteData : Form
    {
        SQLHelper _sql = new SQLHelper();
        ErrorLog _error = new ErrorLog();
        public frm_DeleteData()
        {
            InitializeComponent();
        }

        private void bttn_yes_Click(object sender, EventArgs e)
        {
            try
            {
                string script = File.ReadAllText(Environment.CurrentDirectory + "/Scripts/" + "Delete Query.sql");
                _sql.ExecuteScalar(script);
                MessageBox.Show("Data Deleted Succesfully");
                this.Close();
            }
            catch (Exception ex)
            {
                _error.AddException(ex, "Delete Data");
                MessageBox.Show(ex.Message);
            }
            
        }

        private void bttn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
