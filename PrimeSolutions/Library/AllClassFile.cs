using PrimeSolutions.Library;
using System;
using System.Data;
using BarTender;

namespace PrimeSolutions.Library
{

    public class AllClassFile
    {
        SQLHelper _objsqlhelper = new SQLHelper();
        //BarTender.ApplicationClass btApp;
        //BarTender.Format btFormat;
        //BarTender.Messages btMsgs;
        
        //public void printBarcode(string barcode, string category, string subcategory, string purchaseamt, string sellingamt, string size, string total, int i)
        //{
        //    btApp = new BarTender.ApplicationClass();
        //    btFormat = btApp.Formats.Open(Environment.CurrentDirectory + "\\Barcode.btw", false, "");
        //    try
        //    {
        //        btFormat.SetNamedSubStringValue("barcode", barcode);

        //    }
        //    catch { }
        //    try
        //    {
        //        btFormat.SetNamedSubStringValue("category", category);

        //    }
        //    catch { }
        //    try
        //    {
        //        btFormat.SetNamedSubStringValue("size", size);

        //    }
        //    catch { }
        //    try
        //    {
        //        btFormat.SetNamedSubStringValue("subcategory", subcategory);

        //    }
        //    catch { }

        //    try
        //    {
        //        btFormat.SetNamedSubStringValue("sellingamt", sellingamt);

        //    }
        //    catch { }

        //    btFormat.Print("Job" + (i + 1), false, -1, out btMsgs);
        //}

        //public void printBarcode(string barcode1, string barcode2, string category1, string category2, string subcategory1, string subcategory2, string sellingamt1, string sellingamt2, string size1, string size2, int i)
        //{
        //    btApp = new BarTender.ApplicationClass();
        //    btFormat = btApp.Formats.Open(System.Windows.Forms.Application.StartupPath + "\\Barcode2.btw", false, "");
        //    try
        //    {
        //        btFormat.SetNamedSubStringValue("barcode1", barcode1);
        //        btFormat.SetNamedSubStringValue("barcode2", barcode2);

        //    }
        //    catch { }
        //    try
        //    {
        //        btFormat.SetNamedSubStringValue("category1", category1);
        //        btFormat.SetNamedSubStringValue("category2", category2);

        //    }
        //    catch { }
        //    try
        //    {
        //        btFormat.SetNamedSubStringValue("subcategory1", subcategory1);
        //        btFormat.SetNamedSubStringValue("subcategory2", subcategory2);

        //    }
        //    catch { }

        //    try
        //    {
        //        btFormat.SetNamedSubStringValue("sellingamt1", sellingamt1);
        //        btFormat.SetNamedSubStringValue("sellingamt2", sellingamt2);

        //    }
        //    catch { }
        //    try
        //    {
        //        btFormat.SetNamedSubStringValue("size1", size1);
        //        btFormat.SetNamedSubStringValue("size2", size2);

        //    }
        //    catch { }
        //    btFormat.Print("Job" + (i + 1), false, -1, out btMsgs);

        //}

        internal string GetState()
        {
            string str = "select state from companymaster";
            string state = _objsqlhelper.ExecuteScalar(str);
            return state;
        }

        internal object GetSubCategoryStock(string category)
        {
            string str1 = "SELECT  sub_category FROM BillItem Where category = '" + category + "'AND type = 'Purchase' ";
            DataTable dt1 = _objsqlhelper.GetDataTable(str1);

            return dt1.Rows[0]["sub_category"];
        }

        internal string getQty(string category, string subcategory)
        {
            string Qty;

            string purchase = "SELECT   FROM BillItem Where type = 'Purchase' AND category = '" + category + "' AND subcategory = '" + subcategory + "' and (PermanentDelete = 0 or PermanentDelete is Null) ";
            string sale = "SELECT  Sum(Convert(Decimal,qty)) FROM BillItem Where type = 'Sale' AND category = '" + category + "' AND subcategory = '" + subcategory + "'and (PermanentDelete = 0 or PermanentDelete is Null) ";
            string QtyPurchase = _objsqlhelper.ExecuteScalar(purchase);
            string QtySale = _objsqlhelper.ExecuteScalar(sale);
            if (GetalooseItem(category))
            {
                double PurchaseQty = Math.Round(Convert.ToDouble(QtyPurchase), 3);
                double SaleQty = Math.Round(Convert.ToDouble(QtyPurchase), 3);
                Qty = Convert.ToString(PurchaseQty - SaleQty);
                Qty = Qty + "  Kg";
            }
            else
            {
                double PurchaseQty = Convert.ToInt32(QtyPurchase);
                double SaleQty = Convert.ToInt32(QtyPurchase);
                Qty = Convert.ToString(PurchaseQty - SaleQty);
                Qty = Qty + "  nos.";
            }
            return (Qty);
        }

        internal string getQty(string category, string subcategory, string size)
        {
            string purchase = "", sale = "";
            decimal PurchaseQty, SaleQty;
            string Qty;
            if (GetalooseItem(category))
            {
                purchase = "SELECT Sum(Convert(Decimal(10,2),qty)) FROM BillItem Where type = 'Purchase' AND category = '" + category + "' AND subcategory = '" + subcategory + "'and (PermanentDelete = 0 or PermanentDelete is Null)";
                sale = "SELECT Sum(Convert(Decimal(10,2),qty)) FROM BillItem Where type = 'Sale' AND category = '" + category + "' AND subcategory = '" + subcategory + "'and (PermanentDelete = 0 or PermanentDelete is Null) ";

                string QtyPurchase = _objsqlhelper.ExecuteScalar(purchase);
                string QtySale = _objsqlhelper.ExecuteScalar(sale);

                PurchaseQty = Math.Round(Convert.ToDecimal(QtyPurchase), 3);

                if (PurchaseQty == 0 || PurchaseQty == null)
                    PurchaseQty = 0;

                else
                    PurchaseQty = Convert.ToDecimal(PurchaseQty);

                if (QtySale == "" || QtySale == null)
                    SaleQty = 0;
                else
                    SaleQty = Convert.ToDecimal(QtySale);

                Qty = Convert.ToString(PurchaseQty - SaleQty);


                Qty = Qty + " Kg";

            }

            else
            {
                purchase = "SELECT  Sum(Convert(Decimal,qty)) FROM BillItem Where type = 'Purchase' AND category = '" + category + "' AND subcategory = '" + subcategory + "' AND size = '" + size + "' and (PermanentDelete = 0 or PermanentDelete is Null)";
                sale = "SELECT  Sum(Convert(Decimal,qty)) FROM BillItem Where type = 'Sale' AND category = '" + category + "' AND subcategory = '" + subcategory + "' AND size = '" + size + "' and (PermanentDelete = 0 or PermanentDelete is Null) ";

                string QtyPurchase = _objsqlhelper.ExecuteScalar(purchase);
                string QtySale = _objsqlhelper.ExecuteScalar(sale);
                

                if (QtyPurchase == "" || QtyPurchase == null)
                    PurchaseQty = 0;

                else
                    PurchaseQty = Math.Round(Convert.ToDecimal(QtyPurchase), 2);


                if (QtySale == "" || QtySale == null)
                    SaleQty = 0;
                else
                    SaleQty = Convert.ToDecimal(QtySale);

                Qty = Convert.ToString(PurchaseQty - SaleQty);
                Qty = Qty + " nos";
            }

            return (Qty);
        }


        internal string g(string from, string To, string category, string subcategory, string size)
        {
            string purchase = "", sale = "";
            decimal PurchaseQty, SaleQty;
            string Qty;

            purchase = "SELECT Sum(Convert(Decimal(10,2),qty)) FROM BillItem Where type = 'Purchase' AND category = '" + category + "' AND subcategory = '" + subcategory + "' and (Convert(datetime,PurchaseDate,103) > Convert(datetime,'" + from + "',103) and Convert(datetime,PurchaseDate,103) < Convert(datetime,'" + To + "',103)) and (PermanentDelete = 0 or PermanentDelete is Null)";
            sale = "SELECT Sum(Convert(Decimal(10,2),qty)) FROM BillItem Where type = 'Sale' AND category = '" + category + "' AND subcategory = '" + subcategory + "' and (Convert(datetime,SaleDate,103) > Convert(datetime,'" + from + "',103) and Convert(datetime,SaleDate,103) < Convert(datetime,'" + To + "',103)) and (PermanentDelete = 0 or PermanentDelete is Null) ";

            string QtyPurchase = _objsqlhelper.ExecuteScalar(purchase);
            string QtySale = _objsqlhelper.ExecuteScalar(sale);

            PurchaseQty = Math.Round(Convert.ToDecimal(QtyPurchase), 3);

            if (PurchaseQty == 0 || PurchaseQty == null)
                PurchaseQty = 0;

            else
                PurchaseQty = Convert.ToDecimal(PurchaseQty);

            if (QtySale == "" || QtySale == null)
                SaleQty = 0;
            else
                SaleQty = Convert.ToDecimal(QtySale);

            Qty = Convert.ToString(PurchaseQty - SaleQty);


            if (GetalooseItem(category))
            {
                Qty = Qty + " Kg";
            }

            else
            {
                Qty = Qty + " nos";
            }

            return (Qty);
        }

        private DataTable GetStockLedger(string from, string To)
        {
            string str= " select * from Billitem Where ";
            DataTable stock=_objsqlhelper.GetDataTable(str);
            return stock;
        }



        internal int getQtySupplier(string category, string subcategory, string BillNo)
        {
            string str1 = "SELECT  Sum(Convert(Decimal,qty)) FROM BillItem Where category = '" + category + "' AND SubCategory = '" + subcategory + "' AND PurchaseBillNo='" + BillNo + "' ";
            string Qty = _objsqlhelper.ExecuteScalar(str1);
            return Convert.ToInt32(Qty);
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
            string str1 = "SELECT Sum(Convert(Decimal,qty)) FROM BillItem Where sub_category = '" + subcategory + "'AND type = 'Purchase' ";
            string Qty = _objsqlhelper.ExecuteScalar(str1);

            return Convert.ToInt32(Qty);
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

        internal DataTable getOffer(string category, string SubCategory)
        {
            string str = "Select * from Offermaster where category='" + category + "' and SubCategory='" + SubCategory + "'";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        internal DataTable GetAllOffer()
        {
            DataTable dt = _objsqlhelper.GetDataTable("select * from OfferMaster");
            return dt;
        }

        public void InsertOffer(string Category, string SubCategory, string Size, string DiscPer, string MinQty, string Comment)
        {
            string str = "Insert into OfferMaster values('" + Category + "','" + SubCategory + "','" + DiscPer + "','" + MinQty + "','" + Comment + "','" + Size + "')";
            _objsqlhelper.ExecuteScalar(str);
        }

        public void DeleteOffer(string SrNo)
        {
            string str = "Delete OfferMaster where SrNo='"+SrNo+"'";
            _objsqlhelper.ExecuteScalar(str);
        }


        internal DataTable getStockByCategory(string category)
        {
            string str = "Select * From BillItem where category = '"+category+"' AND type= 'purchase' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        internal DataTable GetSize(string Subcategory)
        {
            string str1 = "SELECT distinct size FROM BillItem Where subcategory = '" + Subcategory + "'AND type = 'Purchase' ";
            DataTable dt1 = _objsqlhelper.GetDataTable(str1);
            return dt1;
        }


        internal DataTable GetSize()
        {
            string str1 = "SELECT distinct size FROM BillItem";
            DataTable dt1 = _objsqlhelper.GetDataTable(str1);
            return dt1;
        }


        internal DataTable getBarcodeItemByRefrence(string PBillNo)
        {
            string str = "Select  * From BillItem Where (Barcode != '') AND PurchaseRef = '" + PBillNo + "' And type = 'Purchase'";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }


        internal DataTable GetCategoryBySubCategory(string SubCategory)
        {
            string str = "select Distinct Category,Size from BillItem where type='purchase' and SubCategory = '" + SubCategory + "' ";
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
            string str = "SELECT  Distinct SubCategory,Size FROM BillItem Where type = 'Purchase' AND category = '" + category+"' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        public DataTable GetSubCategoryByCategoryNotStock(string category)
        {
            string str = "SELECT  Distinct SubCategory FROM BillItem Where category = '" + category + "' ";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        // GetStock
        public Tuple<DataTable, DataTable> GetStock(string from, string to)
        {
            string strSale = "SELECT DISTINCT dbo.BillItem.Category, dbo.BillItem.SubCategory, dbo.BillItem.size, dbo.BillItem.Qty AS Qty, dbo.CustomerBill.BillNo, dbo.CustomerBill.Date, dbo.BillItem.SrNo FROM dbo.BillItem INNER JOIN dbo.CustomerBill ON dbo.BillItem.SaleDate = dbo.CustomerBill.Date AND dbo.BillItem.SaleBillNo = dbo.CustomerBill.BillNo WHERE(dbo.BillItem.Type = 'Sale') AND(CONVERT(DateTime, dbo.CustomerBill.Date, 103) >= CONVERT(DateTime, '" + from + "', 103)) AND(CONVERT(DateTime, dbo.CustomerBill.Date, 103) <= CONVERT(DateTime, '" + to + "', 103)) AND (dbo.BillItem.PermanentDelete = 0)";
            DataTable Sale = _objsqlhelper.GetDataTable(strSale);

            string strPurchase = "SELECT DISTINCT dbo.BillItem.Category, dbo.BillItem.SubCategory, dbo.BillItem.size, dbo.BillItem.Qty AS Qty, dbo.SupplierBill.BillNo, dbo.SupplierBill.Date, dbo.SupplierBill.RefrenceNo FROM dbo.BillItem INNER JOIN dbo.SupplierBill ON dbo.BillItem.PurchaseRef = dbo.SupplierBill.RefrenceNo AND dbo.BillItem.PurchaseBillNo = dbo.SupplierBill.BillNo WHERE(dbo.BillItem.Type = 'Purchase') AND(CONVERT(DateTime, dbo.SupplierBill.Date, 103) >= CONVERT(DateTime, '"+from+"', 103)) AND(CONVERT(DateTime, dbo.SupplierBill.Date, 103) <= CONVERT(DateTime, '"+to+ "',103))AND (dbo.BillItem.PermanentDelete = 0)";
            DataTable Purchase = _objsqlhelper.GetDataTable(strPurchase);
            return Tuple.Create<DataTable,DataTable>(Purchase,Sale);
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

        //Expenses
        public void InsertExpenses(string date, string Expense, string Amount, string RefrenceNo)
        {
            string str = "insert into Expenses(date,Expense,Amount,RefrenceNo) values('" + date + "','" + Expense + "','" + Amount + "','" + RefrenceNo + "')";
            _objsqlhelper.ExecuteScalar(str);
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

        public DataTable getpaymentByBill(string BillNo,string type,string Delete)
        {
            string str = "select * from Payment where BillNo='" + BillNo + "' and type='"+type+ "' and permanentdelete="+Delete+"";
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

        public DataTable GetSaleBillName()
        {
            string str = "SELECT * FROM CrystalReport ";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        public void SetAllssetting(string bar,string print,string barcode,string BarcodeType,string payment,string EstPay,string GSTInterstate,string PurchaseBill,string Estimate,string start,string end,string maintain,string ServiceInvoice,string BillType,string GSTOtherState,string ExtraCharges,string GSTRate)
        {
            string str = "Update Setting set BarcodeCount= '" + bar + "', BillCount='" + print + "', barcode='" + barcode + "',BarcodeType='" + BarcodeType + "',PaymentForm='" + payment + "',EstimatePayment='" + EstPay + "',Maintenance='" + maintain+"',BillType='"+ BillType + "',ExtraChargesInc='"+ExtraCharges+ "',GSTRate='" + GSTRate + "'";
            _objsqlhelper.ExecuteScalar(str);

            string str2 = "Update CrystalReport set SaleBill= '" + GSTInterstate + "' where type='GST_Interstate'";
            _objsqlhelper.ExecuteScalar(str2);

            string str7 = "Update CrystalReport set SaleBill= '" + GSTOtherState + "' where type='GST_Otherstate'";
            _objsqlhelper.ExecuteScalar(str7);

            string str6 = "Update CrystalReport set SaleBill= '" + ServiceInvoice + "' where type='ServiceInvoice'";
            _objsqlhelper.ExecuteScalar(str6);

            string str3 = "Update FinancialYearMaster set startyear= '" + start + "', endyear= '" + end + "' ";
            _objsqlhelper.ExecuteScalar(str3);

            string str4 = "Update CrystalReport set SaleBill= '" + PurchaseBill + "' where type='SupplierPurchase'";
            _objsqlhelper.ExecuteScalar(str4);

            string str5 = "Update CrystalReport set SaleBill= '" + Estimate + "' where type='Estimate'";
            _objsqlhelper.ExecuteScalar(str5);
            
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
