
using PrimeSolutions.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace PrimeSolutions.ClassFile
{
   
    public class AllClassFile
    {
        SQLHelper _objsqlhelper = new SQLHelper();
        
        public void InsertCustomerInfo(string accno, string name, string add, string city, string contact, string contact1, string billno , string date)
        {
            string str = " INSERT INTO SupplierMaster (AccNo, name, address, city, contact_no, phone_no, status,SupplierBillNo,SoftDate) VALUES('"+accno+ "','" + name + "','" + add + "','" + city + "','" + contact + "','" + contact1 + "','Supplier','" + billno + "','" + date + "')";
            _objsqlhelper.ExecuteScalar(str);
        }

        public DataTable getStock()
        {
            string str = "SELECT  Distinct   category FROM BillItem Where type = 'Purchase' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);
          
            return dt;
        }

        

        internal object GetSubCategoryStock(string  category)
        {
            string str1 = "SELECT  sub_category FROM BillItem Where category = '"+category+"'AND type = 'Purchase' ";
            DataTable dt1 = _objsqlhelper.GetDataTable(str1);
            
            return  dt1.Rows[0]["sub_category"];
        }

        internal int getQty(string category, string subcategory,string size,string BillNo)
        {
            string str1 = "SELECT  qty FROM BillItem Where type = 'Purchase' AND category = '" + category + "' AND sub_category = '" + subcategory + "' AND size = '" + size + "' AND PurchaseBill='"+BillNo+"' ";
            DataTable dt1 = _objsqlhelper.GetDataTable(str1);
            int Qty = Convert.ToInt32(sumDataTableColumn(dt1, "qty"));
            return Qty;
        }

        internal int getQtySupplier(string category, string subcategory, string size, string BillNo)
        {
            string str1 = "SELECT  qty FROM BillItem Where category = '" + category + "' AND sub_category = '" + subcategory + "' AND size = '" + size + "' AND PurchaseBill='" + BillNo + "' ";
            DataTable dt1 = _objsqlhelper.GetDataTable(str1);
            int Qty = Convert.ToInt32(sumDataTableColumn(dt1, "qty"));
            return Qty;
        }

        internal int getQty(string category, string subcategory, string size)
        {
            string str1 = "SELECT  qty FROM BillItem Where type = 'Purchase' AND category = '" + category + "' AND sub_category = '" + subcategory + "' AND size = '" + size + "' ";
            DataTable dt1 = _objsqlhelper.GetDataTable(str1);
            int Qty = Convert.ToInt32(sumDataTableColumn(dt1, "qty"));
            return Qty;
        }

        internal object getQty(string subcategory)
        {
            string str1 = "SELECT  qty FROM BillItem Where sub_category = '" + subcategory + "'AND type = 'Purchase' ";
            DataTable dt1 = _objsqlhelper.GetDataTable(str1);
            int Qty = Convert.ToInt32(sumDataTableColumn(dt1, "qty"));
            return Qty;
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

        internal DataTable getStockByCategory(string category)
        {
            string str = "Select * From BillItem where category = '"+category+"' AND type= 'purchase' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        internal DataTable GetSize(string Subcategory)
        {
            string str1 = "SELECT distinct size FROM BillItem Where sub_category = '" + Subcategory + "'AND type = 'Purchase' ";
            DataTable dt1 = _objsqlhelper.GetDataTable(str1);
            return dt1;
        }


        internal DataTable getBarcodeItemByBilNo(string PBillNo)
        {
            string str = "Select  * From BillItem Where (Barcode != '') AND PurchaseBill = '" + PBillNo + "' And type = 'Purchase'";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }


        internal DataTable GetCategoryBySubCategory(string SubCategory)
        {
            string str = "select Distinct Category,Sub_category from BillItem where type='purchase' and sub_category = '" + SubCategory + "' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        internal DataTable GetCategory(string subcategory)
        {
            string str1 = "select distinct category from BillItem where type='purchase'";
            DataTable dt1 = _objsqlhelper.GetDataTable(str1);
            return dt1;
        }

        public DataTable GetSubCategory()
        {
            string str = "SELECT * FROM BillItem Where type = 'Purchase'";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        //For Filling Combobox

        public DataTable GetCategory()
        {
            string str = "select distinct category from BillItem where type='purchase'";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        public DataTable GetSubCategory(string category)
        {
            string str = "SELECT  Distinct sub_category FROM BillItem Where type = 'Purchase'and category='"+category+"'" ;
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }


        public DataTable GetSizeByCatAndSubCat(string category,string SubCategory)
        {
            string str = "SELECT  Distinct size FROM BillItem Where type = 'Purchase'and category='" + category + "' and sub_category ='" + SubCategory + "' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }


        internal DataTable GetAllBySize(string size)
        {
            string str = "SELECT  Distinct size FROM BillItem Where type = 'Purchase' AND size='" + size + "' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        internal DataTable getStockBySize(string size)
        {
            string str = "SELECT  Distinct sub_category,category FROM BillItem Where type = 'Purchase' AND size='"+size+"' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);

            return dt;
        }

        public DataTable GetSubCategoryByCategory(string category)
        {
            string str = "SELECT  Distinct sub_category FROM BillItem Where type = 'Purchase' AND category = '" + category+"' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);

            return dt;
        }

        internal void InsertItem(string barcode,string accno, string category, string subcategory, string purchaseamt,string size, string qty, string sellingamt, string total, string date,string Pbill)
        {
            string str = "INSERT INTO BillItem (Barcode,AccNo, category, sub_category, purchase_amt,sale_amt,size, qty, Total, type, SoftDate,PurchaseBill) VALUES ('" + barcode +"','"+accno+ "','" + category + "','" + subcategory + "','" + purchaseamt + "','" + sellingamt + "','"+size+"','" + qty + "','" + total + "','Purchase','" + date + "','"+Pbill+"')";
            _objsqlhelper.ExecuteScalar(str);
        }

        

        // GEtStock
        internal DataTable GetStockAll(string category)
        {
            string str = "select * from BillItem where type='purchase'AND category = '" + category + "' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;

        }

        internal DataTable GetStockAll(string category, string subcategory)
        {
            string str = "select * from BillItem where type='purchase'AND category = '" + category + "'AND sub_category = '" + subcategory + "' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;

        }

        internal DataTable GetStockAll(string category, string subcategory, string size)
        {
            string str = "select * from BillItem where type='purchase'AND category = '" + category + "'AND sub_category = '" + subcategory + "' AND  size='" + size + "' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;

        }

        internal DataTable GetStockAll(string subcategory, string v1, string v2, string v3)
        {
            string str = "select * from BillItem where type='purchase' AND sub_category = '" + subcategory + "'";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        //GetStockByCategory
        internal DataTable getStockBySubCategory(string subcategory)
        {
            string str = "SELECT * FROM BillItem Where type = 'Purchase' AND sub_category = '" + subcategory + "' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);

            return dt;
        }

        public void InsertCategory(string category)
        {
            string str = "Insert Into CategoryMaster (Category) values ('"+ category +"')";
            _objsqlhelper.ExecuteScalar(str);
        }

        public void InsertSubCategory(string Subcategory)
        {
            string str = "Insert Into SubCategoryMaster (SubCategory) values ('" + Subcategory + "')";
            _objsqlhelper.ExecuteScalar(str);
        }
        public object getCustomerName()
        {
            string str = "SELECT * From SupplierMaster";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        internal void updateCategory(string SrNo,string name)
        {
            string str = "Update CategoryMaster Set Category = '"+name+"' Where SrNo = '"+ SrNo + "' ";
            _objsqlhelper.ExecuteScalar(str);
        }
        internal void updateSubCategory(string SrNo, string name)
        {
            string str = "Update SubCategoryMaster Set SubCategory = '" + name + "' Where SrNo = '" + SrNo + "' ";
            _objsqlhelper.ExecuteScalar(str);
        }

        internal void DeleteCategory(string srno)
        {
            string str = "Delete  From CategoryMaster Where SrNo = '" + srno + "' ";
            _objsqlhelper.ExecuteScalar(str);
        }
        internal void DeleteSubCategory(string srno)
        {
            string str = "Delete  From SubCategoryMaster Where SrNo = '" + srno + "' ";
            _objsqlhelper.ExecuteScalar(str);
        }

        internal void InsertBillDetail(string billamt, string vatper, string vat, string totalamt, string paid, string bal, string accno,string date,string BillNo)
        {
            string str = "INSERT INTO PurchaseBillMaster (BillAmt, Vatper, VAT, TotalAmt, PaidAmt, BalanceAmt, AccNo,SoftDate,BillNo) VALUES('" + billamt + "','" + vatper + "','" + vat + "','" + totalamt + "','" + paid + "','" + bal + "','" + accno + "','" + date + "','"+BillNo+"')";
            _objsqlhelper.ExecuteScalar(str);
        }

       

        public DataTable GetSupplier( string name)
        {
            string str = "Select * From SupplierMaster where name = '"+name+"'";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        internal bool SupplierDetail(string SupplierName)
        {
            string str = "SELECT count (*) FROM  SupplierMaster WHERE (name = '" + SupplierName + "') ";
            int i = Convert.ToInt32(_objsqlhelper.ExecuteScalar(str));
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool ItemCategory(string Category)
        {
            string str = "SELECT count (*) FROM  SubCategoryMaster WHERE (SubCategory = '" + Category + "') ";
            int i = Convert.ToInt32(_objsqlhelper.ExecuteScalar(str));
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool SubItemCategory(string SubCategory)
        {
            string str = "SELECT count (*) FROM  CategoryMaster WHERE (Category = '" + SubCategory + "') ";
            int i = Convert.ToInt32(_objsqlhelper.ExecuteScalar(str));
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public int getbarcode()
        {
            string str = "Select BarcodeCount from setting";
            int barcode = Convert.ToInt32(_objsqlhelper.ExecuteScalar(str));
            return barcode;
        }

        public DataTable getallssetting()
        {
            string str = "select * from setting";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        public void SetAllssetting(string bar,string print,string barcode)
        {
            string str = "Update Setting set BarcodeCount= '" + bar + "', BillCount='" + print + "', barcode='" + barcode + "'";
            _objsqlhelper.ExecuteScalar(str);
            
        }

        public DataTable GetSaleBill()
        {
            string str = "Select distinct BillNo from SaleBillMaster";
            DataTable BillNo =_objsqlhelper.GetDataTable(str);
            return BillNo;
        }

        public DataTable FillCategory()
        {
            string str = "select * from CategoryMaster";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        public DataTable FillSubCategory()
        {
            string str = "select * from SubCategoryMaster";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        public DataTable GetError()
        {
            string str = "Select * from ErrorLog";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

    }

}
