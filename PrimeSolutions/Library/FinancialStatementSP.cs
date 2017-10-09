using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PrimeSolutions.Library
{
    class FinancialStatementSP
    {
        public SqlConnection sqlcon;
        SQLHelper _objSqlhelper = new SQLHelper();
        public FinancialStatementSP()
        {
            sqlcon = new SqlConnection(clsVariable.ConnectionString);
        }

        internal DataSet TrialBalance(string fromDate, string toDate, decimal decAccountGroupId)
        {

            DataSet ds = new DataSet();
            try
            {


                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("Trialbalance", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.VarChar).Value = fromDate;
                sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.VarChar).Value = toDate;
                sqlda.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal).Value = decAccountGroupId;
                sqlda.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ds;
        }

        public DataSet ProfitAndLossAnalysisUpToaDateForBalansheet(string fromDate, string toDate)
        {
            DataSet dset = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProfitAndLossAnalysisUpToaDateForBalansheet", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter prm = new SqlParameter();
                prm = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.VarChar);
                prm.Value = fromDate;
                prm = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.VarChar);
                prm.Value = toDate;
                sdaadapter.Fill(dset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return dset;
        }

        public DataSet BalanceSheet(DateTime fromDate, DateTime toDate)
        {
            DataSet dset = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BalanceSheet", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter prm = new SqlParameter();
                prm = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                prm.Value = fromDate;
                prm = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                prm.Value = toDate;
                sdaadapter.Fill(dset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return dset;
        }

        internal DataSet ProfitAndLossAnalysis(object dtFromdate, object dtTodate)
        {
            DataSet dset = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("ProfitAndLossAnalysis", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
                sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtTodate;
                sqlda.Fill(dset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return dset;
        }

        public DataSet ProfitAndLossAnalysisUpToaDateForPreviousYears(string toDate)
        {
            DataSet dset = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProfitAndLossAnalysisUpToaDateForPreviousYears", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter prm = new SqlParameter();
                prm = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.VarChar);
                prm.Value = toDate;
                sdaadapter.Fill(dset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return dset;
        }
    }
}
