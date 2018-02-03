using PrimeSolutions.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions.Report.Profit_Loss
{
    public partial class frm_profit_loss : Form
    {

        clsCommon _common = new clsCommon();

        public frm_profit_loss()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            int i;
            dgv_Expense.Rows.Clear();
            dgv_Income.Rows.Clear();
            
            Tuple < DataTable ,DataTable,DataTable > ProfitLoss = _common.ProfitLoss(dtp_from.Value.ToString("dd/MM/yyyy"), dtp_to.Value.ToString("dd/MM/yyyy"));
            DataTable income = ProfitLoss.Item1;
            DataTable ExpensesPay = ProfitLoss.Item2;
            DataTable expenses = ProfitLoss.Item3;
            
            dgv_Expense.Rows.Add("Supplier Payment");
            for (i = 1; i < ExpensesPay.Rows.Count; i++)
            {
                dgv_Expense.Rows.Add();
                dgv_Expense.Rows[i].Cells["Date"].Value = ExpensesPay.Rows[i]["Date"].ToString();
                dgv_Expense.Rows[i].Cells["Expence_Name"].Value = ExpensesPay.Rows[i]["Type"].ToString();
                dgv_Expense.Rows[i].Cells["Amount"].Value = ExpensesPay.Rows[i]["Amt"].ToString();

            }
            dgv_Expense.Rows.Add();

            dgv_Expense.Rows.Add("Other Expenses");
            int X = 0;
            for (int j = i+2; j < expenses.Rows.Count+ExpensesPay.Rows.Count+2; j++)
            {
                dgv_Expense.Rows.Add();
                dgv_Expense.Rows[j].Cells["Date"].Value = expenses.Rows[X]["Date"].ToString();
                dgv_Expense.Rows[j].Cells["Expence_Name"].Value = expenses.Rows[X]["Expense"].ToString();
                dgv_Expense.Rows[j].Cells["Amount"].Value = expenses.Rows[X]["Amount"].ToString();
                X=X+1;
            }

            dgv_Expense.Rows.Add("","Total",_common.sumGridViewColumn(dgv_Expense,"Amount"));

            for (i = 0; i < income.Rows.Count; i++)
            {
                dgv_Income.Rows.Add();
                dgv_Income.Rows[i].Cells["Date_Income"].Value = income.Rows[i]["Date"].ToString();
                dgv_Income.Rows[i].Cells["Income_Type"].Value = income.Rows[i]["Type"].ToString();
                dgv_Income.Rows[i].Cells["Amount_Income"].Value = income.Rows[i]["Amt"].ToString();
            }

            dgv_Income.Rows.Add("", "Total", _common.sumGridViewColumn(dgv_Income, "Amount_Income"));
        }
    }
}
