using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;

namespace PrimeSolutions.Accounting
{
    public partial class frm_Daily_Expenses : Form
    {
        AllClassFile _a = new AllClassFile();
        SQLHelper _sql = new SQLHelper();
        
        public frm_Daily_Expenses()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckData()
        {
            bool Exist = false;
            if (cmb_Expenses.Text != "" || cmb_Expenses.Text != null)
                if (cmb_Expenses.Text != string.Empty )
                    if (txt_Amt.Text != "" || txt_Amt.Text != null)
                        if (txt_Amt.Text != string.Empty)
                        {
                            Exist = true;
                        }
            return Exist;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                _a.InsertExpenses(dtp_Date.Value.ToString("dd/MM/yyyy"), cmb_Expenses.Text, txt_Amt.Text, _sql.GetMaxID("E", "0"));
                MessageBox.Show("Done");
            }

            else
            {
                MessageBox.Show("Enter Proper Details");
            }
        }

        private void frm_Daily_Expenses_Load(object sender, EventArgs e)
        {
            cmb_Expenses.DataSource = _sql.GetDataTable("select distinct Expense from Expenses");
        }

        private void frm_Daily_Expenses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
