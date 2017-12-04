using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using PrimeSolutions.Common;

namespace PrimeSolutions.Library
{
    public class clsCommon
    {
        SQLHelper _objSqlhelper = new SQLHelper();
        //clsCommon _objCommon = new clsCommon();
        Simplevalidations _objSimplevalidations = new Simplevalidations();
        AllClassFile _objCustmor = new AllClassFile();

        public DataTable GetCategory()
        {
            string str = "SELECT  Category FROM  CategoryMaster";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt;
        }

        public DataTable GetSubCategory()
        {
            string str = "SELECT SubCategory from SubCategoryMaster ";
            DataTable dt1 = _objSqlhelper.GetDataTable(str);
            return dt1;
        }

        public DataTable GetBillItem(string BillNo, string Type)
        {
            string str = "Select * from BillItem where " + Type + "BillNo = '" + BillNo + "'";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            dt.Columns.Add("Amount");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["Amount"] = Convert.ToString(Math.Round(Convert.ToDouble(dt.Rows[i]["Price"].ToString()) * Convert.ToDouble(dt.Rows[i]["Qty"].ToString()), 2));
            }
            return dt;
        }

        public DataTable GetBillItemByRefrence(string BillNo, string Type)
        {
            string str = "Select * from BillItem where PurchaseRef = '" + BillNo + "'";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt;
        }

        public void InsertIntoTemp(string BillNo)
        {
            DataTable dt = GetBillItemByRefrence(BillNo, "Purchase");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!_objCustmor.GetalooseItem(Convert.ToString(dt.Rows[i]["Category"])))
                {
                    if (Convert.ToBoolean(dt.Rows[i]["BarcodePrint"]))
                    {
                        string barcode;
                        if (Convert.ToString(dt.Rows[i]["Barcode"]) == "" || Convert.ToString(dt.Rows[i]["Barcode"]) == string.Empty)
                        {
                            barcode = _objSqlhelper.GetMaxID("B", "0");
                        }
                        else
                        {
                            barcode = Convert.ToString(dt.Rows[i]["Barcode"]);
                        }
                        int Qty = Convert.ToInt32(dt.Rows[i]["Qty"]);
                        string Category = Convert.ToString(dt.Rows[i]["Category"]);
                        string subcategory = Convert.ToString(dt.Rows[i]["SubCategory"]);
                        string SellingAmt = Convert.ToString(dt.Rows[i]["SellingPrice"]);
                        for (int j = 0; j < Qty; j++)
                        {
                            string str = "insert into Temp values('" + barcode + "','" + Category + "','" + subcategory + "','" + SellingAmt + "') ";
                            _objSqlhelper.ExecuteScalar(str);
                        }
                    }
                }
            }
            //DeleteTemp();

        }

        public void InsertIntoTemp(DataTable dt)
        {

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!_objCustmor.GetalooseItem(Convert.ToString(dt.Rows[i]["Category"])))
                {
                    if (Convert.ToBoolean(dt.Rows[i]["BarcodePrint"]))
                    {
                        string barcode;
                        if (Convert.ToString(dt.Rows[i]["Barcode"]) == "" || Convert.ToString(dt.Rows[i]["Barcode"]) == string.Empty)
                        {
                            barcode = _objSqlhelper.GetMaxID("B", "0");
                        }
                        else
                        {
                            barcode = Convert.ToString(dt.Rows[i]["Barcode"]);
                        }
                        int Qty = Convert.ToInt32(dt.Rows[i]["Qty"]);
                        string Category = Convert.ToString(dt.Rows[i]["Category"]);
                        string subcategory = Convert.ToString(dt.Rows[i]["SubCategory"]);
                        string SellingAmt = Convert.ToString(dt.Rows[i]["SellingAmt"]);
                        for (int j = 0; j < Qty; j++)
                        {
                            string str = "insert into Temp values('" + barcode + "','" + Category + "','" + subcategory + "','" + SellingAmt + "') ";
                            _objSqlhelper.ExecuteScalar(str);
                        }
                    }
                }
            }
            //DeleteTemp();

        }


        public void DeleteTemp()
        {
            string str = "delete from temp";
            _objSqlhelper.ExecuteScalar(str);
        }
        public void setBillNo(string Change)
        {
            string str = "update PrintQue set PrintQue='" + Change + "'";
            _objSqlhelper.ExecuteScalar(str);
        }

        public string GetChangeBillNo()
        {
            string str = "select PrintQue from PrintQue where SrNo='2'";
            return _objSqlhelper.ExecuteScalar(str);
        }

        public string CheckValidity()
        {
            string str = "SELECT * from Activation";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            DateTime start = Convert.ToDateTime(dt.Rows[0]["StartDate"]);
            int ValidDays = Convert.ToInt32(dt.Rows[0]["Validity"]);
            DateTime ValidTo = start.AddDays(ValidDays);
            DateTime CurrentDate = DateTime.Now;
            if (CurrentDate < ValidTo)
            {
                if (ValidTo.AddDays(-15) < CurrentDate)
                {
                    string days = Convert.ToString((ValidTo.Date - CurrentDate.Date).Days);
                    return days ;
                }
                else
                return "Valid";
            }
            
            else
                return "Invalid";

        }

        public DataTable GetSalesPerson()
        {
            string sql = "select id+name as SalesPerson from SalesmanMaster";
            return _objSqlhelper.GetDataTable(sql);

        }
        public void UpdatePaymentDetailsToPermanentDelete(string VoucherTypeId, string VoucherId)
        {
            string str = "UPDATE " + TableNames.PaymentDetail + " SET PermanentDelete= 1 WHERE VoucherTypeId='" + VoucherTypeId + "' and  VoucherId='" + VoucherId + "' AND (PermanentDelete=0)";
            _objSqlhelper.ExecuteSql(str);
        }

        public void updatePaymentDetailByPaymentID(string ColumnName, string columnValue, int paymentid)
        {
            string str = "Update PaymentDetail set " + ColumnName + "='" + columnValue + "' where PaymentID='" + paymentid + "'  AND PermanentDelete = 'false'";
            _objSqlhelper.ExecuteSql(str);
        }
        

        public void UpdatePermanentDeleteTrue(string sColumnValue, string sColomnName, TableNames sTableName)
        {
            string str = "UPDATE " + sTableName + " SET PermanentDelete= 1 WHERE  (" + sColomnName + " = '" + sColumnValue + "') AND (PermanentDelete=0)";
            _objSqlhelper.ExecuteSql(str);
        }

        public DataTable getprint()
        {
            string str = "SELECT  * from setting_value where printt='1' ";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt;
        }
        public DataTable getData()
        {
            string str = "SELECT * FROM  tbl_OpnenigLedger";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt;
        }

        public double GetTax()
        {
            string str = " Select TaxPer from setting";
            double tax = Convert.ToDouble(_objSqlhelper.ExecuteScalar(str));
            return tax; 
        }

        public DataTable getALLTableDetails(TableNames sTableName, string sBillNoInitial = null, string sConcatColumn = null, string sCustomerType = null, string sColumnValue = null, string sColomnName = null)
        {
            string str = "SELECT * " + ((sBillNoInitial == null && sBillNoInitial == null) ? "" : ", { fn CONCAT('" + sBillNoInitial + "-', CAST(" + sConcatColumn + " AS varchar)) } AS GeneratedBillNo ") + "  FROM " + sTableName + " where (PermanentDelete = 0) " + ((sColomnName == null) ? "" : " and (" + sColomnName + " = '" + sColumnValue + "') ") + " " + ((sCustomerType == null) ? "" : " and ( CustomerType = '" + sCustomerType + "')");
            return _objSqlhelper.GetDataTable(str);
        }


        public void insertServerData( string user, string password)
        {
            string str = "Insert InTo ServerUpload (userId , password) Values ('" + user + "','" + password + "')";
            _objSqlhelper.ExecuteScalar(str);
        }

        public void UpdateReportColumn(object srno, object reportname,int value)
        {
            string str = "UPDATE    tbl_OpnenigLedger SET  CheckBox=" + value + " where SrNo=" + srno + " ";
            _objSqlhelper.ExecuteSql(str);
        }
        
        public SettingValue getSettingValue()
        {
            SettingValue _objsetvalue = new SettingValue();
            string str = "Select * from setting";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            _objsetvalue.Barcode = dt.Rows[0]["Barcode"].ToString();
            _objsetvalue.BillCount = dt.Rows[0]["BillCount"].ToString();
            _objsetvalue.BarcodeCount = dt.Rows[0]["BarcodeCount"].ToString();
            _objsetvalue.BarcodeType = dt.Rows[0]["BarcodeType"].ToString();
            _objsetvalue.PaymentForm = dt.Rows[0]["PaymentForm"].ToString();
            _objsetvalue.EstimatePayment = dt.Rows[0]["EstimatePayment"].ToString();
            _objsetvalue.Maintenance = dt.Rows[0]["Maintenance"].ToString();

            return _objsetvalue;
        }

        public DataTable getFinacialYear()
        {
            string str = "SELECT id, startyear, endyear, isSelected FROM FinancialYearMaster WHERE(isSelected = 'True')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt;
        }
        
        
        public DataTable DataGridView2DataTable(DataGridView dgv, String tblName, int minRow = 0)
        {

            DataTable dt = new DataTable(tblName);

            // Header columns
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                DataColumn dc = new DataColumn(column.Name.ToString());
                dt.Columns.Add(dc);
            }

            // Data cells
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataGridViewRow row = dgv.Rows[i];
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    dr[j] = (row.Cells[j].Value == null) ? "" : row.Cells[j].Value.ToString();
                }
                dt.Rows.Add(dr);
            }

            // Related to the bug arround min size when using ExcelLibrary for export
            for (int i = dgv.Rows.Count; i < minRow; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    dr[j] = "  ";
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
       
        public DataTable GetContentAsDataTable(DataGridView dgv,bool IgnoreHideColumns = true)
        {
            try
            {
                if (dgv.ColumnCount == 0) return null;
                DataTable dtSource = new DataTable();
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (IgnoreHideColumns & !col.Visible) continue;
                    if (col.Name == string.Empty) continue;
                    dtSource.Columns.Add(col.Name);
                    dtSource.Columns[col.Name].Caption = col.HeaderText;
                }
                if (dtSource.Columns.Count == 0) return null;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    DataRow drNewRow = dtSource.NewRow();
                    foreach (DataColumn col in dtSource.Columns)
                    {
                        drNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                    }
                    dtSource.Rows.Add(drNewRow);
                }
                return dtSource;
            }
            catch { return null; }
        }
        public DataTable DataGridView2DataTableSelected(DataGridView dgv, String tblName, int minRow = 0)
        {

            DataTable dt = new DataTable(tblName);

            // Header columns
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                DataColumn dc = new DataColumn(column.Name.ToString());
                dt.Columns.Add(dc);
            }

            // Data cells
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataGridViewRow row = dgv.Rows[i];
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    dr[j] = (row.Cells[j].Value == null) ? "" : row.Cells[j].Value.ToString();
                }
                if (Convert.ToBoolean(dgv.Rows[i].Cells[0].Value.ToString()) == true)
                {
                    dt.Rows.Add(dr);
                }
            }

            // Related to the bug arround min size when using ExcelLibrary for export
            for (int i = dgv.Rows.Count; i < minRow; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    dr[j] = "  ";
                }
                if (Convert.ToBoolean(dgv.Rows[i].Cells[0].Value.ToString()) == true)
                {
                    dt.Rows.Add(dr);
                }
            }
            return dt;

        }

        public double sumGridViewColumn(DataGridView dtGrid, string columnName)
        {
            int columnIndex = 0;
            double sum = 0;
            int count = 0;
            try
            {
                for (int i = 0; i < dtGrid.Columns.Count; i++)
                {
                    if (dtGrid.Columns[i].Name == columnName)
                    {
                        columnIndex = i;
                        count++;
                    }
                }
                if (columnIndex != 0)
                {
                    for (int i = 0; i < dtGrid.Rows.Count; i++)
                    {
                        try
                        {
                            sum += Convert.ToDouble(dtGrid.Rows[i].Cells[columnIndex].Value.ToString());
                        }
                        catch
                        {
                        }
                    }
                }

            }
            catch
            {

            }
            return sum;
        }

        public double sumDataTableColumn(DataTable dtGrid, string columnName)
        {
            int columnIndex = 0;
            int count = 0;
            double sum = 0;
            try
            {
                for (int i = 0; i < dtGrid.Columns.Count; i++)
                {
                    if (dtGrid.Columns[i].ColumnName == columnName)
                    {
                        columnIndex = i;
                        count++;
                    }
                }
                if (count != 0)
                {
                    for (int i = 0; i < dtGrid.Rows.Count; i++)
                    {
                        try
                        {
                            sum += Convert.ToDouble(dtGrid.Rows[i][columnIndex].ToString());
                        }
                        catch
                        {
                        }
                    }
                }


            }
            catch
            {

            }
            return sum;
        }
        
        public void addSmsLink(string linkpart1, string linkpart2, string linkpart3)
        {
            string str = "Update tbl_smsLink  Set linkpart1='" + linkpart1 + "', linkpart2= '" + linkpart2 + "', linkpart3='" + linkpart3 + "' WHERE (srno='1')";
            int x = _objSqlhelper.ExecuteSql(str);
        }

        public DataTable getCompanyDetails()
        {
            string str = "SELECT * from CompanyMaster";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt;
        }

        public DataTable mergeTwoDataGrid(DataTable FirstDatatable, DataTable SecondDatatable)
        {
            DataTable dtmerge = new DataTable();
            int max, min;
            string datagrid;
            if (FirstDatatable.Rows.Count > SecondDatatable.Rows.Count)
            {
                max = FirstDatatable.Rows.Count;
                min = SecondDatatable.Rows.Count;
                datagrid = "data";

            }
            else
            {
                max = SecondDatatable.Rows.Count;
                min = FirstDatatable.Rows.Count;
                datagrid = "data1";
            }

            int grid1columnCount = FirstDatatable.Columns.Count;
            int grid2columnCount = SecondDatatable.Columns.Count;

            for (int i = 0; i < grid1columnCount; i++)
            {
                dtmerge.Columns.Add(FirstDatatable.Columns[i].ColumnName);
            }
            for (int i = 0; i < grid2columnCount; i++)
            {
                dtmerge.Columns.Add(SecondDatatable.Columns[i].ColumnName);
            }

            int columnMergeCount = dtmerge.Columns.Count;

            for (int i = 0; i < min; i++)
            {
                dtmerge.Rows.Add();
                int j;
                for (j = 0; j < grid1columnCount; j++)
                {
                    dtmerge.Rows[i][j] = FirstDatatable.Rows[i][j].ToString();
                }
                int l = 0;
                for (int k = j; k < grid2columnCount + j; k++)
                {
                    dtmerge.Rows[i][k] = SecondDatatable.Rows[i][l].ToString();
                    l++;
                }

            }
            //if (min != 0)
            //{
            for (int i = min; i < max; i++)
            {
                if (datagrid == "data")
                {
                    dtmerge.Rows.Add();
                    int j;
                    for (j = 0; j < grid1columnCount; j++)
                    {
                        dtmerge.Rows[i][j] = FirstDatatable.Rows[i][j].ToString();
                    }
                    for (int k = j; k < grid2columnCount + j; k++)
                    {
                        dtmerge.Rows[i][k] = "";
                    }
                }
                if (datagrid == "data1")
                {
                    dtmerge.Rows.Add();
                    int j;
                    for (j = 0; j < grid1columnCount; j++)
                    {
                        dtmerge.Rows[i][j] = "";
                    }
                    int l = 0;
                    for (int k = j; k < grid2columnCount + j; k++)
                    {
                        dtmerge.Rows[i][k] = SecondDatatable.Rows[i][l].ToString();
                        l++;
                    }
                }
            }
            //}

            return dtmerge;
        }
        

        public string setPaymentForm()
        {
            string str = "SELECT PaymentForm FROM Setting";
            return _objSqlhelper.ExecuteScalar(str);
        }
        

        public string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 10000000) > 0)
            {
                words += NumberToWords(number / 10000000) + " Crore ";
                number %= 10000000;
            }
            if ((number / 100000) > 0)
            {
                words += NumberToWords(number / 100000) + " Lakh ";
                number %= 100000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }

        

    }
}