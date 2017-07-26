using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace PrimeSolutions.Library
{
    public class clsCommon
    {
        SQLHelper _objSqlhelper = new SQLHelper();

        //clsCommon _objCommon = new clsCommon();
        Simplevalidations _objSimplevalidations = new Simplevalidations();

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

        public DataTable getFinacialYear()
        {
            string str = "SELECT id, startyear, endyear, isSelected FROM FinancialYearMaster WHERE(isSelected = 'True')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt;
        }

        public DataTable getComment()
        {
            string str = "SELECT DISTINCT Name FROM BarcodeMaster ";
            DataTable dt1 = _objSqlhelper.GetDataTable(str);
            return dt1;
        }

        public string getMetalNameHindi(string MetalId)
        {
            string str = "SELECT  MetalHindi FROM    MetalMaster WHERE   (MetalId = '" + MetalId + "')";

            return Convert.ToString(_objSqlhelper.ExecuteScalar(str));

        }

        public string getMetalNameMarathi(string MetalId)
        {
            string str = "SELECT  MetalMarathi FROM    MetalMaster WHERE   (MetalId = '" + MetalId + "')";

            
                string str1 = Convert.ToString(_objSqlhelper.ExecuteScalar(str));
            return str1;

        }

        public object getSubMetalHindiName(string SubMetalId)
        {
            string str = "SELECT    SubMetalHindi  FROM    SubMetalMaster WHERE  (SubMetalName = '" + SubMetalId + "')";
            return Convert.ToString(_objSqlhelper.ExecuteScalar(str));
        }
        public object getSubMetalHindi(string SubMetalId)
        {
            string str = "SELECT    SubMetalHindi  FROM    SubMetalMaster WHERE  (SubMetalId = '" + SubMetalId + "')";
            return Convert.ToString(_objSqlhelper.ExecuteScalar(str));
        }
        public string getSubMetalEnglish(string SubMetalId)
        {
            string str = "SELECT    SubMetalName FROM    SubMetalMaster WHERE  (SubMetalId = '" + SubMetalId + "')";
            return Convert.ToString(_objSqlhelper.ExecuteScalar(str));
        }
        public string getMetalEnglish(string MetalId)
        {
            string str = "SELECT    MetalName FROM    MetalMaster WHERE  (MetalId = '" + MetalId + "')";
            return Convert.ToString(_objSqlhelper.ExecuteScalar(str));
        }
        public DataTable getRates()
        {
            string str = "SELECT SrNo, Gold, Silver FROM  Rates";
            DataTable dt1 = _objSqlhelper.GetDataTable(str);
            return dt1;
        }
        public bool updateRate(string gold, string silver)
        {
            string str = "UPDATE Rates SET Gold = '" + gold + "', Silver = '" + silver + "' WHERE (Rate = 'Rate')";
            int i = _objSqlhelper.ExecuteSql(str);
            if (i > 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable getBarCodeItemDetails(string itemcode)
        {
            string str = "SELECT ItemCode, Metaltype, itemtype, specify, wt, reducewt, finalwt, finalwtinpercent, currentprice, finewt, fineamount, makingcharges, quantity, netprice, comment, Date, CheckTrue, MetalId, SubMetalType, FromWhere, Barcode FROM ItemMaster WHERE (ItemCode = '" + itemcode + "')";
            return _objSqlhelper.GetDataTable(str);
        }

        public string getGold()
        {

            string gold_wt = "SELECT  FinalWt   FROM  BillItemMaster WHERE LTRIM(RTRIM(MetalID))=N'" + getMetalNameMarathi("1") + "' and (CustmerType = 'Supplier') AND (PermanantDelete='" + false + "')";
            string Gold_given = "SELECT FinalWt, MetalID, CustmerType FROM BillItemMaster WHERE (LTRIM(RTRIM(MetalID)) = N'" + getMetalNameMarathi("1") + "') AND ((CustmerType = 'Customer') OR (CustmerType = 'Vyapari')) AND (PermanantDelete='" + false + "')";// AND ( (LTRIM(RTRIM(Item_id)) != N'बार') OR (LTRIM(RTRIM(Item_id)) != N'कॅडबरी') OR  (LTRIM(RTRIM(Item_id)) != N'रवा') OR (LTRIM(RTRIM(Item_id)) != N'बिस्किट्स')  OR (LTRIM(RTRIM(Item_id)) != N'चौसा') OR (LTRIM(RTRIM(Item_id)) != N'पेटी')) )";

            DataTable dt = _objSqlhelper.GetDataTable(gold_wt);
            DataTable dt1 = _objSqlhelper.GetDataTable(Gold_given);

            double stockgold = sumDataTableColumn(dt, "FinalWt");
            double goldGiven = sumDataTableColumn(dt1, "FinalWt");

            double bgold = (stockgold - goldGiven);
            return Convert.ToString(bgold);
        }

        public string getSilver()
        {



            string gold_wt = "SELECT  FinalWt   FROM  BillItemMaster WHERE LTRIM(RTRIM(MetalID))=N'" + getMetalNameMarathi("2") + "' and (CustmerType = 'Supplier') AND (PermanantDelete='" + false + "')";
            string Gold_given = "SELECT FinalWt, MetalID, CustmerType FROM BillItemMaster WHERE (LTRIM(RTRIM(MetalID)) = N'" + getMetalNameMarathi("2") + "') AND ((CustmerType = 'Customer') OR (CustmerType = 'Vyapari')) AND (PermanantDelete='" + false + "')";// AND ( (LTRIM(RTRIM(Item_id)) != N'बार') OR (LTRIM(RTRIM(Item_id)) != N'कॅडबरी') OR  (LTRIM(RTRIM(Item_id)) != N'रवा') OR (LTRIM(RTRIM(Item_id)) != N'बिस्किट्स')  OR (LTRIM(RTRIM(Item_id)) != N'चौसा') OR (LTRIM(RTRIM(Item_id)) != N'पेटी')) )";
            DataTable dt = _objSqlhelper.GetDataTable(gold_wt);
            DataTable dt1 = _objSqlhelper.GetDataTable(Gold_given);

            double stockgold = sumDataTableColumn(dt, "FinalWt");
            double goldGiven = sumDataTableColumn(dt1, "FinalWt");

            double bgold = (stockgold - goldGiven);
            return Convert.ToString(bgold);
        }

        public string getFineGold()
        {
            decimal stockgold = 0;
            decimal goldGiven = 0;

            decimal vyaparipay = 0;
            decimal supplierpay = 0;

           
           // string gold_wt = "SELECT SM.SupplierId, SM.Owner, FSI.Final_wt as Final_wt, FSI.Date FROM FineStockItems AS FSI INNER JOIN SupplierMaster AS SM ON FSI.SupplierId = SM.SupplierId WHERE(SM.PermanantDelete = '" + false + "') AND(SM.Owner = 'True')";
            string gold_wt = "SELECT  Wt   FROM FineStockItems  WHERE LTRIM(RTRIM(Metal_Type))=N'" + getMetalNameMarathi("1") + "'";
            string Gold_given = "SELECT FineWt, MetalID, CustmerType FROM BillItemMaster WHERE (LTRIM(RTRIM(MetalID)) = N'" + getMetalNameMarathi("1") + "') AND ((CustmerType = 'CustomerFine') OR (CustmerType = 'VyapariFine')) AND (PermanantDelete='" + false + "')";

            string payVyapari = "SELECT GoldGiven FROM vyapriPayMaster WHERE (PermanantDelete='" + false + "')";
            string paySupplier = "SELECT Gold, Silver FROM SupplierPayMaster Where (forwardstatus is NULL)";


            DataTable dt = _objSqlhelper.GetDataTable(gold_wt);
            DataTable dt1 = _objSqlhelper.GetDataTable(Gold_given);
            DataTable dt2 = _objSqlhelper.GetDataTable(payVyapari);
            DataTable dt4 = _objSqlhelper.GetDataTable(paySupplier);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Wt"].ToString() != "")
                    stockgold = stockgold + Convert.ToDecimal(dt.Rows[i]["Wt"]);
            }
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                if (dt1.Rows[i]["FineWt"].ToString() != "")

                    goldGiven = goldGiven + Convert.ToDecimal(dt1.Rows[i]["FineWt"]);
            }
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (dt2.Rows[i]["GoldGiven"].ToString() != "")
                {

                    vyaparipay = vyaparipay + Convert.ToDecimal(dt2.Rows[i]["GoldGiven"]);

                }

            }
            for (int i = 0; i < dt4.Rows.Count; i++)
            {
                if (dt4.Rows[i]["Gold"].ToString() != "")
                {
                    supplierpay = supplierpay + Convert.ToDecimal(dt4.Rows[i]["Gold"]);
                }
            }
            decimal bgold = (stockgold - goldGiven + vyaparipay - supplierpay);
            return Convert.ToString(bgold);
        }

        public string getFineSilver()
        {
            decimal stockgold = 0;
            decimal goldGiven = 0;
            decimal vyaparipay = 0;
            decimal supplierpay = 0;
            decimal OwnerSum = 0;

            string gold_wt = "SELECT  Wt   FROM  FineStockItems WHERE LTRIM(RTRIM(Metal_Type))=N'" + getMetalNameMarathi("2") + "'";
            string Owner_Sum = "SELECT SM.SupplierId, SM.Owner, FSI.Final_wt as Final_wt, FSI.Date FROM FineStockItems AS FSI INNER JOIN SupplierMaster AS SM ON FSI.SupplierId = SM.SupplierId WHERE (SM.PermanantDelete='" + false + "') AND (SM.Owner= 'True')";
            string Gold_given = "SELECT FineWt, MetalID, CustmerType FROM BillItemMaster WHERE (LTRIM(RTRIM(MetalID)) = N'" + getMetalNameMarathi("2") + "') AND ((CustmerType = 'CustomerFine') OR (CustmerType = 'VyapariFine')) AND (PermanantDelete='" + false + "')";// AND ( (LTRIM(RTRIM(Item_id)) != N'बार') OR (LTRIM(RTRIM(Item_id)) != N'कॅडबरी') OR  (LTRIM(RTRIM(Item_id)) != N'रवा') OR (LTRIM(RTRIM(Item_id)) != N'बिस्किट्स')  OR (LTRIM(RTRIM(Item_id)) != N'चौसा') OR (LTRIM(RTRIM(Item_id)) != N'पेटी')) )";
            string payVyapari = "SELECT SilverGiven FROM vyapriPayMaster WHERE (PermanantDelete='" + false + "')";
            string paySupplier = "SELECT  Gold, Silver FROM  SupplierPayMaster";



            DataTable dt = _objSqlhelper.GetDataTable(gold_wt);
            DataTable dt1 = _objSqlhelper.GetDataTable(Gold_given);
            DataTable dt2 = _objSqlhelper.GetDataTable(payVyapari);
            DataTable dt4 = _objSqlhelper.GetDataTable(paySupplier);
            DataTable dt5 = _objSqlhelper.GetDataTable(Owner_Sum);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                stockgold = stockgold + Convert.ToDecimal(dt.Rows[i]["Wt"]);
            }
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                goldGiven = goldGiven + Convert.ToDecimal(dt1.Rows[i]["FineWt"]);
            }
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                vyaparipay = vyaparipay + Convert.ToDecimal(dt2.Rows[i]["SilverGiven"]);

            }
            for (int i = 0; i < dt4.Rows.Count; i++)
            {
                supplierpay = supplierpay + Convert.ToDecimal(dt4.Rows[i]["Silver"]);
            }

            for (int i = 0; i < dt5.Rows.Count; i++)
            {
                OwnerSum = OwnerSum + Convert.ToDecimal(dt5.Rows[i]["Final_wt"]);
            }

            decimal bgold = (stockgold - goldGiven - supplierpay + vyaparipay);
            return Convert.ToString(bgold);
        }

        public string getModGold()
        {
            decimal ModGold = 0;

            string strGold = "SELECT Final_WT, Status FROM Mod_Entries WHERE  MID='1' and (Status = N'MOD')";
            DataTable dt = _objSqlhelper.GetDataTable(strGold);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ModGold = ModGold + Convert.ToDecimal(dt.Rows[i]["Final_WT"]);

            }
            return ModGold.ToString();
        }

        public string getModSilver()
        {
            decimal ModSilver = 0;

            string strSilver = "SELECT Final_WT, Status FROM  Mod_Entries WHERE  MID='2' and (Status = N'MOD')";
            DataTable dt1 = _objSqlhelper.GetDataTable(strSilver);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                ModSilver = ModSilver + Convert.ToDecimal(dt1.Rows[i]["Final_WT"]);
            }
            return ModSilver.ToString();
        }

        public DataTable getsubmetaltypeMetalWise(string submetal)
        {
            if (submetal == "Stone")
            {
                string str = "SELECT srno, MetalId, SubMetalName,SubMetalHindi FROM tbl_StoneSubMetalMaster  Order By SubMetalName ASC ";
                DataTable dt1 = _objSqlhelper.GetDataTable(str);
                return dt1;
            }
            else
            {
                string str = "SELECT DISTINCT SubMetalId, MetalId, SubMetalName,SubMetalHindi FROM SubMetalMaster  Order By SubMetalName ASC ";
                DataTable dt1 = _objSqlhelper.GetDataTable(str);
                return dt1;
            }

        }

        public DataTable CalculationForItemInfoGroup(string wt, string reducewt, string finalwtper, string currentprice, string makingprgm, string making_Charges, string MakingStatus, string quantity, string finalwt)
        {

            if (wt == "")
            {
                wt = "0";
            }

            if (reducewt == "")
            {
                reducewt = "0";
            }
            if (finalwtper == "")
            {
                finalwtper = "0";
            }
            if (currentprice == "")
            {
                currentprice = "0";
            }
            if (makingprgm == "")
            {
                makingprgm = "0";
            }
            if (finalwt == "")
            {
                finalwt = "0";
            }

            double final_wt = 0, fine_wt = 0, total_fine_amt = 0, making_chargesdo = 0, net_price = 0;

            if ((makingprgm == "" || makingprgm == "0") && (making_Charges != "") && MakingStatus == "Fix")
            {
                making_chargesdo = 0 + Convert.ToDouble(making_Charges);
            }
            else if (MakingStatus == "PG")
            {
                making_chargesdo = Convert.ToDouble(finalwt) * Convert.ToDouble(makingprgm);
            }
            else
            {
                making_chargesdo = Convert.ToDouble(quantity) * Convert.ToDouble(makingprgm);
            }

            final_wt = Convert.ToDouble(wt) - Convert.ToDouble(reducewt);
            fine_wt = Math.Round((final_wt * Convert.ToDouble(finalwtper)) / 100, 3);
            total_fine_amt = Math.Round(Convert.ToDouble(currentprice) * fine_wt, 0);
            net_price = Math.Round(making_chargesdo + total_fine_amt, 0);
            making_chargesdo = Math.Round(Convert.ToDouble(making_chargesdo));

            DataTable dt = new DataTable();
            dt.Columns.Add("FinalWt");
            dt.Columns.Add("FineWt");
            dt.Columns.Add("TotalFineAmount");
            dt.Columns.Add("MakingCharges");
            dt.Columns.Add("NetPrice");

            dt.Rows.Add(final_wt.ToString(), _objSimplevalidations.Gettingdecimals(fine_wt.ToString()), total_fine_amt.ToString(), making_chargesdo.ToString(), net_price.ToString());
            return dt;
        }

     

        public DataTable getItems()
        {
            string str = "SELECT Distinct itemId FROM BillItemMaster WHERE (PermanantDelete='" + false + "')";// Where CustmerType='Supplier'
            return _objSqlhelper.GetDataTable(str);
        }

        public string getItemWt(string metal, string item)
        {
            int qty = 0;
            string str = "SELECT InitialWt FROM BillItemMaster WHERE (MetalID=N'" + metal + "') AND (itemId=N'" + item + "') AND (CustmerType='Supplier') AND (PermanantDelete='" + false + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                qty += Convert.ToInt32(dt.Rows[i]["InitialWt"].ToString());
            }
            return qty.ToString();
        }

        public object getSubMetalHindiMetalWise(string SubMetalId, string metal)
        {
            if (metal == "Stone")
            {
                string str1 = "SELECT    SubMetalHindi  FROM    tbl_StoneSubMetalMaster WHERE  (srno = '" + SubMetalId + "')";
                return Convert.ToString(_objSqlhelper.ExecuteScalar(str1));
            }
            else
            {
                string str = "SELECT    SubMetalHindi  FROM    SubMetalMaster WHERE  (SubMetalId = '" + SubMetalId + "')";
                return Convert.ToString(_objSqlhelper.ExecuteScalar(str));
            }

        }

        public DataTable getNewBillNo(string billno)
        {
            string str = "select NewBillNo,CBillNo from SalesBBillMaster where BillNo = '" + billno + "'";
            return _objSqlhelper.GetDataTable(str);
        }

        public DataTable getItemsInDetail(string metal, string item)
        {
            string str = "SELECT Item_Code, MetalID, itemId, InitialWt, ReduceWt, FinalWt, FinalWtInPercent, FineWT, CurrentPrice, TotalFineAmount, MakingCharges, Quantity, NetPrice,CustmerType,SrNo,Item_Code,MID,SID FROM BillItemMaster Where (MetalID=N'" + metal + "') AND (itemId=N'" + item + "') AND ((CustmerType='Supplier') OR (CustmerType='Vyapari') OR (CustmerType='Customer')) AND (PermanantDelete='" + false + "')";
            return _objSqlhelper.GetDataTable(str);
        }



        public string getItemGoldWt(string itemName)
        {

            string str = "SELECT FinalWt FROM BillItemMaster WHERE (MetalID=N'" + getMetalNameMarathi("1") + "') AND (itemId=N'" + itemName + "') AND (CustmerType='Supplier') AND (PermanantDelete='" + false + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            double PurchaseGoldWt = sumDataTableColumn(dt, "FinalWt");

            string str1 = "SELECT FinalWt FROM BillItemMaster WHERE (MetalID=N'" + getMetalNameMarathi("1") + "') AND (itemId=N'" + itemName + "') AND ((CustmerType='Customer') OR (CustmerType='Vyapari')) AND (PermanantDelete='" + false + "')";
            DataTable dt1 = _objSqlhelper.GetDataTable(str1);
            double SoldGoldWt = sumDataTableColumn(dt1, "FinalWt");
            return (Math.Round((PurchaseGoldWt - SoldGoldWt), 3)).ToString();

        }
        public string getItemSilverWt(string itemName)
        {

            string str = "SELECT FinalWt FROM BillItemMaster WHERE (MetalID=N'" + getMetalNameMarathi("2") + "') AND (itemId=N'" + itemName + "') AND (CustmerType='Supplier') AND (PermanantDelete='" + false + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            double PurchaseSilverWt = sumDataTableColumn(dt, "FinalWt");

            string str1 = "SELECT FinalWt FROM BillItemMaster WHERE (MetalID=N'" + getMetalNameMarathi("2") + "') AND (itemId=N'" + itemName + "') AND ((CustmerType='Customer') OR (CustmerType='Vyapari')) AND (PermanantDelete='" + false + "')";
            DataTable dt1 = _objSqlhelper.GetDataTable(str1);
            double SoldSilverWt = sumDataTableColumn(dt1, "FinalWt");

            return (PurchaseSilverWt - SoldSilverWt).ToString();
        }

        public string getItemGoldQty(string itemName)
        {
            Double PurchaseGoldWt = 0;
            string str = "SELECT Quantity FROM BillItemMaster WHERE (MetalID=N'" + getMetalNameMarathi("1") + "') AND (itemId=N'" + itemName + "') AND (CustmerType='Supplier') AND (PermanantDelete='" + false + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PurchaseGoldWt += Convert.ToDouble(dt.Rows[i]["Quantity"].ToString());
            }


            Double SoldGoldWt = 0;
            string str1 = "SELECT Quantity FROM BillItemMaster WHERE (MetalID=N'" + getMetalNameMarathi("1") + "') AND (itemId=N'" + itemName + "') AND ((CustmerType='Customer') OR (CustmerType='Vyapari')) AND (PermanantDelete='" + false + "')";
            DataTable dt1 = _objSqlhelper.GetDataTable(str1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                SoldGoldWt += Convert.ToDouble(dt1.Rows[i]["Quantity"].ToString());
            }
            return (PurchaseGoldWt - SoldGoldWt).ToString();
        }

        public string getItemSilverQty(string itemName)
        {
            Double PurchaseSilverWt = 0;
            string str = "SELECT Quantity FROM BillItemMaster WHERE (MetalID=N'" + getMetalNameMarathi("2") + "') AND (itemId=N'" + itemName + "') AND (CustmerType='Supplier') AND (PermanantDelete='" + false + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PurchaseSilverWt += Convert.ToDouble(dt.Rows[i]["Quantity"].ToString());
            }
            Double SoldSilverWt = 0;
            string str1 = "SELECT Quantity FROM BillItemMaster WHERE (MetalID=N'" + getMetalNameMarathi("2") + "') AND (itemId=N'" + itemName + "') AND ((CustmerType='Customer') OR (CustmerType='Vyapari')) AND (PermanantDelete='" + false + "')";
            DataTable dt1 = _objSqlhelper.GetDataTable(str1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                SoldSilverWt += Convert.ToDouble(dt1.Rows[i]["Quantity"].ToString());
            }
            return (PurchaseSilverWt - SoldSilverWt).ToString();
        }


        public DataTable getItemInfoFromItemNo(string ItemCode)
        {

            string str = "SELECT  ItemCode, Barcode, Metaltype, itemtype, specify, wt, reducewt, finalwt, finalwtinpercent, finewt, currentprice, fineamount, makingcharges, quantity, netprice,  comment, Date, CheckTrue,MetalID,SubMetalType,MakingChargeType,MakingUnitPrice FROM ItemMaster WHERE (ItemCode = '" + ItemCode + "') AND (FromWhere IS NULL)";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt;
        }
        //Diamond
        public DataTable getDiamondItemDetails(string itemcode)
        {
            string str = "SELECT ItemNo, Metal, item, GoldWt, GoldCarat,DiamondWt, DiamondCut, DiamondQuality, DiamondColour, Quantity, MRP, NetPrice, comment, Date, CheckTrue,status,barcodecheck,BillItemNo,bulk_item FROM tbl_DiamondItemMaster WHERE (ItemNo = '" + itemcode + "')";
            return _objSqlhelper.GetDataTable(str);
        }

        public DataTable getItemInfoFromItemNoTemp(string ItemCode)
        {
            string str = "SELECT  ItemCode, Barcode, Metaltype, itemtype, specify, wt, reducewt, finalwt, finalwtinpercent, finewt, currentprice, fineamount, makingcharges, quantity, netprice,  comment, Date, CheckTrue,MetalID,SubMetalType FROM ItemMasterNew WHERE (ItemCode = '" + ItemCode + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt;
        }

        public DataTable getItemDetailsFromStock(string metal, string item)
        {
            string cmd = "SELECT ItemCode, MetalId, Metaltype, SubMetalType, itemtype, specify, wt, reducewt, finalwt, quantity FROM  ItemMaster where (MetalId='" + metal + "') and (SubMetalType='" + item + "') and (FromWhere is NULL) ORDER BY ItemCode DESC ";
            DataTable dt = _objSqlhelper.GetDataTable(cmd);
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


        public DataTable getImitationItemDetailsFromStock(string item)
        {
            string str = "SELECT SrNo, Item, BillItemNo, Wt, PurchasePrice, Quantity, TotalPrice, SellPrice, Date, status, FromWhere, Barcode, BarcodeId FROM tblImitationItemMaster WHERE (Item = '" + item + "') AND (FromWhere!='Sale') and (barcode='true')";
            return _objSqlhelper.GetDataTable(str);
        }



        public double CalculationImitationItemInfoGroup(string amount, string Quantity)
        {
            return (Convert.ToDouble(amount) * Convert.ToDouble(Quantity));
        }

        public DataTable getAllItems()
        {
            string str = "SELECT SrNo, BillNO, Item_Code, MetalID, itemId, specify, InitialWt, ReduceWt, FinalWt, FinalWtInPercent, FineWT, CurrentPrice, TotalFineAmount, MakingCharges, Quantity, NetPrice, Date, CustmerType FROM BillItemMaster WHERE (PermanantDelete='" + false + "')";
            return _objSqlhelper.GetDataTable(str);
        }

        public DataTable getAllItems(string BillNo)
        {
            string str = "SELECT SrNo, BillNO, Item_Code, MetalID, itemId, specify, InitialWt, ReduceWt, FinalWt, FinalWtInPercent, FineWT, CurrentPrice, TotalFineAmount, MakingCharges, Quantity, NetPrice, Date, CustmerType,MakingChargeType,MakingUnitPrice FROM BillItemMaster WHERE (BillNO='" + BillNo + "') AND (PermanantDelete='" + false + "')";
            return _objSqlhelper.GetDataTable(str);
        }

        public string getSubMetalIdFromName(string SubMetalHindi)
        {
            string str = "SELECT SubMetalId FROM SubMetalMaster WHERE (SubMetalHindi = N'" + SubMetalHindi + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt.Rows[0]["SubMetalId"].ToString();
        }

        public string getMetalIdFromHindiName(string MetalHindi)
        {
            string str = "SELECT MetalId FROM MetalMaster WHERE (MetalHindi = N'" + MetalHindi + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt.Rows[0]["MetalId"].ToString();

        }



        public string getMetalIdFromMarathiName(string MetalMarathi)
        {
            string str = "SELECT MetalId FROM MetalMaster WHERE (MetalMarathi = N'" + MetalMarathi + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt.Rows[0]["MetalId"].ToString();

        }

        public object getImitationCategory()
        {
            string str = "SELECT ItemCategory FROM tblImitationItemCategoryMaster ";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt;
        }

        public object getImitationItem()
        {
            string str = "SELECT name FROM tblImitationItemSubCategoryMaster ";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt;
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

        public string setVat()
        {
            string str = "SELECT vat FROM setting_value";
            return _objSqlhelper.ExecuteScalar(str);
        }

        public string setPaymentForm()
        {
            string str = "SELECT PaymentForm FROM setting_value";
            return _objSqlhelper.ExecuteScalar(str);
        }

        public DataTable getItemDetailsFromStockBillItemMaster(string MID, string SID)
        {
            string cmd = "SELECT Item_Code, MetalId, itemId, specify, InitialWt, ReduceWt, FinalWt, Quantity FROM  BillItemMaster where (MID='" + MID + "') and (SID='" + SID + "') AND (PermanantDelete='" + false + "')";
            DataTable dt = _objSqlhelper.GetDataTable(cmd);
            return dt;

        }

        public DataTable getSoneVikrikharirdi(string MetalId, string MetalName)
        {
            string cmd = "select MetalId,MetalName,MetalHindi,MetalEnglish,MetalMarathi FROM MetalMaster where(MetalId='" + MetalId + "') AND (MetalName='" + MetalName + "')";
            DataTable dt = _objSqlhelper.GetDataTable(cmd);
            return dt;
        }





        public string getMetalIdFromEnglishName(string MetalEnglish)
        {
            string str = "SELECT MetalId FROM MetalMaster WHERE (MetalEnglish = N'" + MetalEnglish + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt.Rows[0]["MetalId"].ToString();
        }
        public string getMarathiToEnglishName(string MetalEnglish)
        {
            string str = "SELECT MetalName FROM MetalMaster WHERE (MetalId = '" + MetalEnglish + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt.Rows[0]["MetalName"].ToString();
        }
        public string getSubMetalMarathiToEnglishName(string MetalEnglish)
        {
            string str = "SELECT SubMetalName FROM SubMetalMaster WHERE (SubMetalId = '" + MetalEnglish + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt.Rows[0]["SubMetalName"].ToString();
        }

        public DataTable getContainerItems()
        {
            string str = "SELECT * FROM tbl_TrayMaster ";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt;
        }

        public string setlanguage()
        {
            string str = "SELECT language FROM setting_value";
            return _objSqlhelper.ExecuteScalar(str);
        }

        public DataTable getcontainerdata()
        {
            string str = "SELECT srno,name,qty FROM tbl_TrayMaster ";
            DataTable dt1 = _objSqlhelper.GetDataTable(str);
            return dt1;
        }

        public DataTable DeleteBarCodeData(string ItemCode)
        {
            string str = "DELETE FROM ItemMaster WHERE ItemCode=('" + ItemCode + "') ";
            DataTable dt1 = _objSqlhelper.GetDataTable(str);
            return dt1;
        }

        public DataTable getBarCodeData(string ItemCode)
        {
            //string str = "SELECT Metaltype,itemtype,wt,reducewt,finalwt,finalwtinpercent,finewt,currentprice,fineamount,makingcharges,quantity,netprice WHERE ( '" + Metaltype + "' , '" + itemtype + "' ,'" + wt + "' ,'" + reducewt + "' ,'" + finalwt + "' ,'" + finalwtinpercent + "' ,'" + finewt + "' ,'" + currentprice + "' ,'" + fineamount + "' ,'" + makingcharges + "' ,'" + quantity + "' ,'" + netprice + "')";
            //DataTable dt1 = _objSqlhelper.GetDataTable(str);
            //return dt1;  

            string str = "SELECT  ItemCode, Barcode, Metaltype, itemtype, specify, wt, reducewt, finalwt, finalwtinpercent, finewt, currentprice, fineamount, makingcharges, quantity, netprice FROM ItemMaster WHERE (ItemCode = '" + ItemCode + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt;
        }

        public object getBarCodeName(string ItemCode)
        {
            string cmd = "SELECT ItemCode FROM  ItemMaster  ";
            DataTable dt = _objSqlhelper.GetDataTable(cmd);
            DataTable dtNew = new DataTable();
            dtNew.Columns.Add("ItemCode");
            int j = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["ItemCode"].ToString().Contains(ItemCode))
                {
                    dtNew.Rows.Add();
                    dtNew.Rows[j]["ItemCode"] = dt.Rows[i]["ItemCode"].ToString();
                    j++;
                }
            }
            return dtNew;
        }



        public void addBarcode(string name)
        {
            string cmd = "INSERT INTO BarcodeMaster  (Name)  VALUES   ('" + name + "')";
            _objSqlhelper.ExecuteSql(cmd);
        }

        public DataTable fillgrid()
        {
            string str = "Select Name,Id  FROM BarcodeMaster";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt;
        }

        public void updateBarcode(string name, string Id)
        {
            string cmd = "update BarcodeMaster SET Name = '" + name + "' Where Id ='" + Id + "' ";
            _objSqlhelper.ExecuteSql(cmd);
        }

        public DataTable getSmsLink()
        {
            string str = "select * from tbl_smsLink";
            return _objSqlhelper.GetDataTable(str);
        }

        public string setsms()
        {
            string str = "SELECT sms FROM setting_value";
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
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

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

        //public SettingValue getSettingvalue()
        //{
        //    SettingValue _objsetvalue = new SettingValue();
        //    string str = "Select * from setting_value";
        //    DataTable dt = _objSqlhelper.GetDataTable(str);
        //    _objsetvalue.language = dt.Rows[0]["language"].ToString();
        //    _objsetvalue.sms = dt.Rows[0]["sms"].ToString();
        //    _objsetvalue.printt = dt.Rows[0]["printt"].ToString();
        //    _objsetvalue.vat = dt.Rows[0]["vat"].ToString();
        //    _objsetvalue.PaymentForm = dt.Rows[0]["PaymentForm"].ToString();
        //    _objsetvalue.salescount = dt.Rows[0]["salescount"].ToString();
        //    _objsetvalue.purchasecount = dt.Rows[0]["PurchaseCount"].ToString();
        //    _objsetvalue.BillType = dt.Rows[0]["BillType"].ToString();
        //    _objsetvalue.Barcode = dt.Rows[0]["BarcodePrint"].ToString();
        //    _objsetvalue.vatper = dt.Rows[0]["vatper"].ToString();


        //    return _objsetvalue;
        //}

        public void updateModBill(string itemcode, string mID, string metalid, string sID, string itemid, string wt, string reduceWt, string finalWt, string finalWTInPercent, string fineWt, string currentPrice, string totalfineAmount, string quantity, string netprice, string billNo,string Narration)
        {
            string str = "UPDATE Mod_Entries SET  Metal_Type =N'"+metalid+ "', Item_Type =N'" + itemid + "', W_T ='" + wt + "', Reduce_W_T ='" + reduceWt + "', Final_WT ='" + finalWt + "', Fine_Weight ='" + fineWt + "', Final_Weight_In_Percentage ='" + finalWTInPercent + "', Current_Price ='" + currentPrice + "', Total_Amount ='" + totalfineAmount + "', MID ='" + mID+ "', SID ='" + sID + "', Quantity ='" + quantity + "',Final_Amount ='" + netprice + "', Narration ='" +Narration  +"'  WHERE (Mod_ID = '" + billNo + "')";
            _objSqlhelper.ExecuteSql(str);
        }


        public void Printreq(string value)
        {
            string str = "UPDATE setting_value SET printt='" + value + "'";
            _objSqlhelper.ExecuteSql(str);
        }


        public void SetSalesCount(String Count)
        {
            string str1 = "UPDATE setting_value SET salescount='" + Count + "'";
            _objSqlhelper.ExecuteSql(str1);
        }

        public void SetPurchaseCount(String Count)
        {
            string str1 = "UPDATE setting_value SET purchasecount='" + Count + "'";
            _objSqlhelper.ExecuteSql(str1);
        }

        public void SetVatPer(string Per)
        {
            string str = "UPDATE setting_value SET vatper='" + Per + "'";
            _objSqlhelper.ExecuteSql(str);
        }

    }
}