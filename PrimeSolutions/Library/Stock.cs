using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PrimeSolutions.Library
{
    class Stock
    {
        SQLHelper _sql = new SQLHelper();
        DataTable  category, subcategory, size;
        public DataTable GetStock()
        {
            DataTable dt1, dt2, dt3;
            DataTable dt4 = new DataTable();
            dt4.Columns.Add("category");
            dt4.Columns.Add("SubCategory");
            dt4.Columns.Add("size");
            dt4.Columns.Add("Quantity");
            
            dt1 = GetCategory();
            dt2 = GetSubCategory();
            dt3 = GetSize();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                dt4.Rows.Add(dt1.Rows[i]["category"]);

                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    dt4.Rows[j]["SubCategory"] = dt2.Rows[j]["sub_category"];
                    for (int k = 0; k < dt3.Rows.Count; k++)
                    {
                        dt4.Rows[k]["size"] = dt3.Rows[k]["size"];
                    }
                }

            }
            return dt4;
        }

        public DataTable GetCategory()
        {
            string str1 = "select distinct category from BillItem where type = 'Purchase'";
            category = _sql.GetDataTable(str1);
            return category;
        }

        public DataTable GetSubCategory()
        {
            string str1 = "select distinct sub_category from BillItem where type = 'Purchase'";
            subcategory = _sql.GetDataTable(str1);
            return subcategory;
        }

        public DataTable GetSize()
        {
            string str1 = "select distinct size from BillItem where type = 'Purchase'";
            size = _sql.GetDataTable(str1);
            return size;
        }

    }
}
