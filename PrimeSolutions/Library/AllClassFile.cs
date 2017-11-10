using PrimeSolutions.Library;
using System;
using System.Data;
using BarTender;

namespace PrimeSolutions.Library
{

    public class AllClassFile
    {
        SQLHelper _objsqlhelper = new SQLHelper();
        BarTender.ApplicationClass btApp;
        BarTender.Format btFormat;
        BarTender.Messages btMsgs;

        public DataTable getStock()
        {
            string str = "SELECT  Distinct   category FROM BillItem Where type = 'Purchase' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);
          
            return dt;
        }

        public void printBarcode(string barcode, string category, string subcategory, string purchaseamt, string sellingamt, string size, string total, int i)
        {
            btApp = new BarTender.ApplicationClass();
            btFormat = btApp.Formats.Open(Environment.CurrentDirectory + "\\Barcode.btw", false, "");
            try
            {
                btFormat.SetNamedSubStringValue("barcode", barcode);

            }
            catch { }
            try
            {
                btFormat.SetNamedSubStringValue("category", category);

            }
            catch { }
            try
            {
                btFormat.SetNamedSubStringValue("size", size);

            }
            catch { }
            try
            {
                btFormat.SetNamedSubStringValue("subcategory", subcategory);

            }
            catch { }

            try
            {
                btFormat.SetNamedSubStringValue("sellingamt", sellingamt);

            }
            catch { }

            btFormat.Print("Job" + (i + 1), false, -1, out btMsgs);
        }

        public void printBarcode(string barcode1, string barcode2, string category1, string category2, string subcategory1, string subcategory2, string sellingamt1, string sellingamt2, string size1, string size2, int i)
        {
            btApp = new BarTender.ApplicationClass();
            btFormat = btApp.Formats.Open(System.Windows.Forms.Application.StartupPath + "\\Barcode2.btw", false, "");
            try
            {
                btFormat.SetNamedSubStringValue("barcode1", barcode1);
                btFormat.SetNamedSubStringValue("barcode2", barcode2);

            }
            catch { }
            try
            {
                btFormat.SetNamedSubStringValue("category1", category1);
                btFormat.SetNamedSubStringValue("category2", category2);

            }
            catch { }
            try
            {
                btFormat.SetNamedSubStringValue("subcategory1", subcategory1);
                btFormat.SetNamedSubStringValue("subcategory2", subcategory2);

            }
            catch { }

            try
            {
                btFormat.SetNamedSubStringValue("sellingamt1", sellingamt1);
                btFormat.SetNamedSubStringValue("sellingamt2", sellingamt2);

            }
            catch { }
            try
            {
                btFormat.SetNamedSubStringValue("size1", size1);
                btFormat.SetNamedSubStringValue("size2", size2);

            }
            catch { }
            btFormat.Print("Job" + (i + 1), false, -1, out btMsgs);

        }

        internal string GetState()
        {
            string str = "select state from companymaster";
            string state = _objsqlhelper.ExecuteScalar(str);
            return state;
        }

        internal object GetSubCategoryStock(string  category)
        {
            string str1 = "SELECT  sub_category FROM BillItem Where category = '"+category+"'AND type = 'Purchase' ";
            DataTable dt1 = _objsqlhelper.GetDataTable(str1);
            
            return  dt1.Rows[0]["sub_category"];
        }

        internal string getQty(string category, string subcategory)
        {
            string Qty;
            string purchase = "SELECT  qty FROM BillItem Where type = 'Purchase' AND category = '" + category + "' AND subcategory = '" + subcategory + "' ";
            string sale = "SELECT  qty FROM BillItem Where type = 'Sale' AND category = '" + category + "' AND subcategory = '" + subcategory + "' ";
            DataTable DtPurchase = _objsqlhelper.GetDataTable(purchase);
            DataTable DtSale = _objsqlhelper.GetDataTable(sale);
            if (GetalooseItem(category))
            {
                double PurchaseQty = Math.Round(Convert.ToDouble(sumDataTableColumn(DtPurchase, "qty")), 3);
                double SaleQty = Math.Round(Convert.ToDouble(sumDataTableColumn(DtSale, "qty")), 3);
                Qty =Convert.ToString(PurchaseQty - SaleQty);
                Qty = Qty + "  Kg";
            }
            else
            {
                double PurchaseQty =Convert.ToInt32 (sumDataTableColumn(DtPurchase, "qty"));
                double SaleQty = Convert.ToInt32(sumDataTableColumn(DtSale, "qty"));
                Qty = Convert.ToString(PurchaseQty - SaleQty);
                Qty = Qty + "  nos.";
            }
            return (Qty);
        }

        internal string getQty(string category, string subcategory,string price)
        {
            string Qty;
            string purchase = "SELECT  qty FROM BillItem Where type = 'Purchase' AND category = '" + category + "' AND subcategory = '" + subcategory + "'AND sellingprice='"+price+"' ";
            string sale = "SELECT  qty FROM BillItem Where type = 'Sale' AND category = '" + category + "' AND subcategory = '" + subcategory + "'AND sellingprice='" + price + "' ";
            DataTable DtPurchase = _objsqlhelper.GetDataTable(purchase);
            DataTable DtSale = _objsqlhelper.GetDataTable(sale);
            if (GetalooseItem(category))
            {
                double PurchaseQty = Math.Round(Convert.ToDouble(sumDataTableColumn(DtPurchase, "qty")), 3);
                double SaleQty = Math.Round(Convert.ToDouble(sumDataTableColumn(DtSale, "qty")), 3);
                Qty = Convert.ToString(PurchaseQty - SaleQty);
                Qty = Qty + "  Kg";
            }
            else
            {
                double PurchaseQty = Convert.ToInt32(sumDataTableColumn(DtPurchase, "qty"));
                double SaleQty = Convert.ToInt32(sumDataTableColumn(DtSale, "qty"));
                Qty = Convert.ToString(PurchaseQty - SaleQty);
                Qty = Qty + "  nos.";
            }
            return (Qty);
        }

        internal int getQtySupplier(string category, string subcategory, string BillNo)
        {
            string str1 = "SELECT  qty FROM BillItem Where category = '" + category + "' AND SubCategory = '" + subcategory + "' AND PurchaseBillNo='" + BillNo + "' ";
            DataTable dt1 = _objsqlhelper.GetDataTable(str1);
            int Qty = Convert.ToInt32(sumDataTableColumn(dt1, "qty"));
            return Qty;
        }

        internal bool GetalooseItem(string looseItem)
        {
            string str = "SELECT count (*) FROM  LooseItem WHERE (LooseItem = '" + looseItem + "') ";
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
            string str = "Select  * From BillItem Where (Barcode != '') AND PurchaseBillNo = '" + PBillNo + "' And type = 'Purchase'";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }


        internal DataTable GetCategoryBySubCategory(string SubCategory)
        {
            string str = "select Distinct Category,SellingPrice from BillItem where type='purchase' and SubCategory = '" + SubCategory + "' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        //For Printing Barcode
        

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
            string str = "SELECT  Distinct SubCategory FROM BillItem Where type = 'Purchase'" ;
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }


        public DataTable GetSizeByCatAndSubCat(string category,string SubCategory)
        {
            string str = "SELECT  Distinct size FROM BillItem Where type = 'Purchase'and category='" + category + "' and subcategory ='" + SubCategory + "' ";
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
            string str = "SELECT  Distinct SubCategory,SellingPrice FROM BillItem Where type = 'Purchase' AND category = '" + category+"' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        public DataTable GetSubCategoryByCategoryNotStock(string category)
        {
            string str = "SELECT  Distinct SubCategory FROM BillItem Where category = '" + category + "' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
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
            string str = "SELECT Category,SellingPrice,Qty FROM BillItem Where type = 'Purchase' AND SubCategory = '" + subcategory + "' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);

            return dt;
        }


        //Insert Into Master
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

        public void InsertLooseItem(string LooseItem)
        {
            string str = "Insert Into LooseItem(LooseItem) values ('" + LooseItem + "')";
            _objsqlhelper.ExecuteScalar(str);
        }

        //Update Master
        internal void updateCategory(string SrNo, string name)
        {
            string str = "Update CategoryMaster Set Category = '" + name + "' Where SrNo = '" + SrNo + "' ";
            _objsqlhelper.ExecuteScalar(str);
        }
        internal void updateSubCategory(string SrNo, string name)
        {
            string str = "Update SubCategoryMaster Set SubCategory = '" + name + "' Where SrNo = '" + SrNo + "' ";
            _objsqlhelper.ExecuteScalar(str);
        }
        internal void updateLooseItem(string SrNo, string name)
        {
            string str = "Update LooseItem Set LooseItem = '" + name + "' Where SrNo = '" + SrNo + "' ";
            _objsqlhelper.ExecuteScalar(str);
        }

        //Delete Master
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

        internal void DeleteLooseItem(string srno)
        {
            string str = "Delete  From LooseItem Where SrNo = '" + srno + "' ";
            _objsqlhelper.ExecuteScalar(str);
        }

        public DataTable getSupplierName()
        {
            string str = "SELECT * From SupplierMaster";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        internal void InsertBillDetail(string accno, string BillNo, string date, string billamt, string CGST, string SGST, string IGST, string Total, string State,string Type,string RefNo)
        {
            string str = "INSERT INTO SupplierBill (SupplierNo, BillNo, Date, Amount, CGST, SGST, IGST,GrandTotal,State,Type,RefrenceNo) VALUES('" + accno + "','" + BillNo + "','" + date + "','" + billamt + "','" + CGST + "','" + SGST + "','" + IGST + "','" + Total + "','"+State+"','"+Type+"','"+ RefNo + "')";
            _objsqlhelper.ExecuteScalar(str);
        }

        internal void InsertPaymentDetails(string type,string Amt,string paymode,string id,string date,string BillNo)
        {
            string str = "Insert Into Payment(Type,Amt,Paymode,Id,Date,BillNo) VALUES('"+type+"','"+Amt+"','"+paymode+"','"+id+"','"+date+"','"+BillNo+"') ";
            _objsqlhelper.ExecuteScalar(str);
        }

        internal DataTable getpaymentdetails(string id, string date)
        {
            string str = "select * from Payment where id='"+id+ "' and Date='"+date+"'";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        internal DataTable getpaymentByBill(string BillNo,string type)
        {
            string str = "select * from Payment where BillNo='" + BillNo + "' and type='"+type+"'";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        public DataTable GetSupplier( string name)
        {
            string str = "Select * From SupplierMaster where name = '"+name+"'";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        public DataTable GetAllSupplier()
        {
            string str = "Select * From SupplierMaster";
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
            string str = "SELECT count (*) FROM  CategoryMaster WHERE (Category = '" + Category + "') ";
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

        internal bool ItemSubCategory(string SubCategory)
        {
            string str = "SELECT count (*) FROM  SubCategoryMaster WHERE (SubCategory = '" + SubCategory + "') ";
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

        public string GetSaleBillName()
        {
            string str = "SELECT SaleBill FROM CrystalReport where SrNo='1'";
            string crt = _objsqlhelper.ExecuteScalar(str);
            return crt;
        }

        public void SetAllssetting(string bar,string print,string barcode,string BarcodeType,string payment,string EstPay,string SaleBill,string start,string end)
        {
            string str = "Update Setting set BarcodeCount= '" + bar + "', BillCount='" + print + "', barcode='" + barcode + "',BarcodeType='" + BarcodeType + "',PaymentForm='" + payment + "',EstimatePayment='" + EstPay + "'";
            _objsqlhelper.ExecuteScalar(str);

            string str2 = "Update CrystalReport set SaleBill= '" + SaleBill + "'";
            _objsqlhelper.ExecuteScalar(str);

            string str3 = "Update FinancialYearMaster set startyear= '" + start + "', endyear= '" + end + "', ";
            _objsqlhelper.ExecuteScalar(str);



        }

        public DataTable GetSaleBill()
        {
            string str = "Select distinct BillNo from SaleBillMaster";
            DataTable BillNo =_objsqlhelper.GetDataTable(str);
            return BillNo;
        }


        //Fill Master
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

        public DataTable FillLooseItem()
        {
            string str = "select * from LooseItem";
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
