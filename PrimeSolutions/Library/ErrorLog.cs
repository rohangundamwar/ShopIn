using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeSolutions.Library
{
    class ErrorLog
    {
        SQLHelper _objSQLHelper = new SQLHelper();

        public void AddException(Exception ex, string form)
        {
            string str;
            string a = ex.Message.ToString();
            string msg = a.Replace("'", " ");
            string time = DateTime.Now.ToString();
            string line = Convert.ToString(GetLineNumber(ex));
            string Function = ex.TargetSite.ToString();
            string company = _objSQLHelper.ExecuteScalar("select Name from CompanyMaster");
            string stack = ex.StackTrace;
            str = "Insert into ErrorLog(ErrorMessage,Time,Line,Form,status,CompanyName,Method,Stack) values ('" + msg + "','" + time + "','" + line + "','" + form + "','0','" + company + "','" + Function + "','" + stack + "')";
            _objSQLHelper.ExecuteScalar(str);

        }

        public int GetLineNumber(Exception ex)
        {
            var lineNumber = 0;
            const string lineSearch = ":line ";
            var index = ex.StackTrace.LastIndexOf(lineSearch);
            if (index != -1)
            {
                var lineNumberText = ex.StackTrace.Substring(index + lineSearch.Length);
                if (int.TryParse(lineNumberText, out lineNumber))
                {
                }
            }
            return lineNumber;
        }
    }
}
