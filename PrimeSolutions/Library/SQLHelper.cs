using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace PrimeSolutions.Library
{
   
    public class SQLHelper
    {

        public SQLHelper()
        {
            ConStingfinder();
        }
  
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;



        public void ConStingfinder()
        {

            string line;
            

            // Read the file and display it line by line.
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(Environment.CurrentDirectory + "\\ConnectionString.txt");
                while ((line = file.ReadLine()) != null)
                {
                    clsVariable.ConnectionString = line;
                    con = new SqlConnection(line);
                    clsVariable.DatabaseName = con.Database;
                    clsVariable.ConnectionDatabase = con.Database;
                }

                file.Close();
            }
            catch { }

            // Suspend the screen.

        }


        public string GetConSting()
        {

            string line="";

            // Read the file and display it line by line.
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(Environment.CurrentDirectory + "\\ConnectionString.txt");
                while ((line = file.ReadLine()) != null)
                {
                    clsVariable.DatabaseName = line;
                }
                
                file.Close();
            }
            catch { }
            return line;
            
        }
        #region new Connection
        #region Class Level Variable


        #endregion

        #region Openconnection Function
        public void OpenConnection()
        {
            try
            {
                if (con == null)
                {
                    //String cnnStr = "Server=localhost;Attachdbfilename="+Environment.CurrentDirectory+"\\"+clsVariable.ConnectionString+"";
                    String cnnStr = clsVariable.ConnectionString.ToString();
                    con = new SqlConnection(cnnStr);
                    clsVariable.DatabaseName = con.Database;
                    clsVariable.ConnectionDatabase = con.Database;
                }

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = new SqlCommand();
                cmd.Connection = con;
            }
            catch(Exception ex)
            {
                Application.Exit();
            }

        }
        #endregion

        #region CloseConnection Function
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        #endregion

        #region DisposeConnection Function

        public void DisposeConnection()
        {
            if (con != null)
            {
                con.Dispose();
                con = null;
            }
        }
        #endregion


        #region ExecuteSql Method

        public int ExecuteSql(string strsql)
        {
            OpenConnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strsql;
            int intresult;
            intresult = cmd.ExecuteNonQuery();
            CloseConnection();
            DisposeConnection();
            return intresult;
        }
        #endregion

        #region GetDataTable Method

        public DataTable GetDataTable(string strsql)
        {
            OpenConnection();
            da = new SqlDataAdapter(strsql, con);
            DataTable dt = new DataTable();

            da.Fill(dt);
           
            da.Dispose();
            CloseConnection();
            DisposeConnection();
            return dt;
        }
       
        #endregion

        #region GetDataSet Method

        public DataSet GetDataSet(string strsql)
        {
            OpenConnection();
            da = new SqlDataAdapter(strsql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            da.Dispose();
            CloseConnection();
            DisposeConnection();
            return ds;
        }
        #endregion


        #region GetDataReader Method

        public SqlDataReader GetDataReader(string strsql)
        {
            OpenConnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strsql;
            SqlDataReader dr;
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
        #endregion

        //#region GetDataReader Method

        //public SqlDataReader GetDataReader(string strsql)
        //{
        //    OpenConnection();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = strsql;
        //    SqlDataReader dr;
        //    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        //    return dr;
        //}
        //#endregion

        #region IsExist Method

        public Boolean IsExist(string strsql)
        {
            OpenConnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strsql;
            int intresult = 0;
            try
            {
                intresult = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                intresult = 0;
            }
            CloseConnection();
            DisposeConnection();

            if (intresult > 0)
            {
                return true;
            }
            else
            {
                return false;

            }

        }
        #endregion

        #region ExecuteScalar Function

        public string ExecuteScalar(string strsql)
        {
            OpenConnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strsql;
            string strresult;


            strresult = Convert.ToString(cmd.ExecuteScalar());
            CloseConnection();
            DisposeConnection();
            return strresult;


        }
        #endregion

        public DataSet collect(string str)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();
            OpenConnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = str;
            adp.SelectCommand = cmd;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            adp.Fill(ds);
            CloseConnection();
            DisposeConnection();
            return ds;


        }


        #region gmGetMstID Function
        public string GetMaxID(string MstType, string MstDesc)
        {
            string SQL = "";

            string MCODE = "";


            //MstDesc = MstDesc.Trim() + "00";
            MstDesc = MstDesc.Trim() + "00";



            switch (MstType)
            {
                case "A":

                    SQL = "Select Max(Right(AccNo,4))+1 As MaxID From vypariMaster Where Right(Left(AccNo,1),1)= 'A'";
                    break;

                case "B":

                    SQL = "Select Max(Right(Barcode,4))+1 As MaxID From BillItem Where Right(Left(Barcode,1),1)= 'B'";
                    break;

                case "C":

                    SQL = "Select Max(Right(CustId,4))+1 As MaxID From CustomerMaster Where Right(Left(CustId,1),1)= 'C'";
                    break;
              

                case "D":

                    SQL = "Select Max(Right(BillNo,4))+1 As MaxID From tblImitationBillMaster Where Right(Left(BillNo,1),1)= 'D'";
                    break;


                case "Y":

                    SQL = "Select Max(Right(BillNo,4))+1 As MaxID From tbl_DiamondSalesBillMaster Where Right(Left(BillNo,1),1)= 'Y'";

                    break;


                case "Z":

                    SQL = "Select Max(Right(InvoiceNo,4))+1 As MaxID From PurchaseBillMaster Where Right(Left(InvoiceNo,1),1)= 'Z'";
                    break;

                case "U":

                    SQL = "Select Max(Right(ItemNo,4))+1 As MaxID From tbl_DiamondItemMaster Where Right(Left(ItemNo,1),1)= 'U'";
                    break;

                //Refinery k
                case "u":
                    SQL = "Select Max(Right(SupplierId,4))+1 As MaxID From ExchangeCustomerMaster Where Right(Left(SupplierId,1),1)= 'u'";
                    break;




                case "E":

                    SQL = "Select Max(Right(ItemCode,4))+1 As MaxID From ItemMaster Where Right(Left(ItemCode,1),1)= 'E'";
                    break;

                case "F":

                    SQL = "Select Max(Right(SupplierId,4))+1 As MaxID From ImitationSupplierMaster Where Right(Left(SupplierId,1),1)= 'F'";
                    break;
                case "G":

                    SQL = "Select Max(Right(BillNo,4))+1 As MaxID From tblImitationBillMaster Where Right(Left(BillNo,1),1)= 'G'";
                    break;

                case "H":
                    //    SQL = "Select Max(Right(SupplierId,4))+1 As MaxID From SupplierMaster Where Right(Left(SupplierId,6),3)= '" + Left(MstDesc, 3) + "'";
                    SQL = "Select Max(Right(orderno,4))+1 As MaxID From VyapariOrder Where Right(Left(orderno,1),1)= 'H'";
                    break;


                case "I":

                    SQL = "Select Max(Right(InvoiceNo,4))+1 As MaxID From PurchaseBillMaster Where Right(Left(InvoiceNo,1),1)= 'I'";
                    break;

                case "J":

                    SQL = "Select Max(Right(AccNo,4))+1 As MaxID From vypariBookingMaster Where Right(Left(AccNo,1),1)= 'J'";
                    break;

                case "K":

                    SQL = "Select Max(Right(InvoiceNo,4))+1 As MaxID From SupplierBookingBillMaster Where Right(Left(InvoiceNo,1),1)= 'K'";
                    break;

                case "M":

                    SQL = "Select Max(Right(Mod_ID,4))+1 As MaxID From Mod_Entries Where Right(Left(Mod_ID,1),1)= 'M'";
                    break;


                case "m":
                    // SQL = "Select Max(Right(ItemCode,4))+1 As MaxID From ItemMaster Where Right(Left(ItemCode,6),3)= '" + Left(MstDesc, 3) + "'";
                    SQL = "Select Max(Right(ItemCode,4))+1 As MaxID From ItemMaster Where Right(Left(ItemCode,1),1)= 'm'";
                    break;

                case "N":

                    SQL = "Select Max(Right(BillNo,4))+1 As MaxID From tblImitationBillMaster Where Right(Left(BillNo,1),1)= 'N'";
                    break;

                case "O":

                    SQL = "Select Max(Right(OrderNo,4))+1 As MaxID From OrderMaster Where Right(Left(OrderNo,1),1)= 'O'";
                    break;

                case "P":

                    SQL = "Select Max(Right(SupplierNo,4))+1 As MaxID From SupplierMaster Where Right(Left(SupplierNo,1),1)= 'P'";
                    break;

                case "Q":

                    SQL = "Select Max(Right(SupplierId,4))+1 As MaxID From SupplierBookingMaster Where Right(Left(SupplierId,1),1)= 'Q'";
                    break;



                case "R":

                    SQL = "Select Max(Right(Refinery_ID,4))+1 As MaxID From Refinery_Items Where Right(Left(Refinery_ID,1),1)= 'R'";
                    break;

                case "S":

                    SQL = "Select Max(Right(BillNo,4))+1 As MaxID From CustomerBill Where Right(Left(BillNo,1),1)= 'S'";

                    break;



                case "T":

                    SQL = "Select Max(Right(ItemCode,4))+1 As MaxID From DiomondBarcodeEntry Where Right(Left(ItemCode,1),1)= 'T'";
                    break;

                case "L":

                    SQL = "Select Max(Right(BillNo,4))+1 As MaxID From SalesBBillMaster Where Right(Left(BillNo,1),1)= 'L'";

                    break;
               
               
                case "V":
                   
                   SQL = "Select Max(Right(BillNo,4))+1 As MaxID From vyapariBillMaster Where Right(Left(BillNo,1),1)= 'V'";
              
                    break;


                case "W":

                    SQL = "Select Max(Right(BillNo,4))+1 As MaxID From vyapariBookingBillMaster Where Right(Left(BillNo,1),1)= 'W'";

                    break;

                case "x":
                    SQL = "Select Max(Right(RefineID,4))+1 As MaxID From RefinedMod Where Right(Left(RefineID,1),1)= 'x'";
                    break;

                default:
                    break;
            }

                MCODE = MstType + Left(MstDesc, 3) + Right("0000" + ExecuteScalar(SQL), 4);
                if (Right(MCODE, 4) == "0000")
                {
                    MCODE = MstType + Left(MstDesc, 3) + "0001";
                }
          

            return MCODE;
        }

        public string gmGetMstIDForBooking(string MstType, string MstDesc)
        {
            string SQL = "";

            string MCODE = "";


            //MstDesc = MstDesc.Trim() + "00";
            MstDesc = MstDesc.Trim() + "00";



            switch (MstType)
            {
                case "J":

                    SQL = "Select Max(Right(AccNo,4))+1 As MaxID From vypariBookingMaster Where Right(Left(AccNo,1),1)= 'J'";
                    break;

                case "B":

                    SQL = "Select Max(Right(BarcodeId,4))+1 As MaxID From tblImitationItemMaster Where Right(Left(BarcodeId,1),1)= 'B'";
                    break;

                case "C":

                    SQL = "Select Max(Right(AccNo,4))+1 As MaxID From SalesBMaster Where Right(Left(AccNo,1),1)= 'C'";
                    break;


                case "D":

                    SQL = "Select Max(Right(BillNo,4))+1 As MaxID From tblImitationBillMaster Where Right(Left(BillNo,1),1)= 'D'";
                    break;

                case "E":

                    SQL = "Select Max(Right(ItemCode,4))+1 As MaxID From ItemMaster Where Right(Left(ItemCode,1),1)= 'E'";
                    break;

                case "F":

                    SQL = "Select Max(Right(SupplierId,4))+1 As MaxID From ImitationSupplierMaster Where Right(Left(SupplierId,1),1)= 'F'";
                    break;
                case "G":

                    SQL = "Select Max(Right(BillNo,4))+1 As MaxID From tblImitationBillMaster Where Right(Left(BillNo,1),1)= 'G'";
                    break;

                case "H":
                    //    SQL = "Select Max(Right(SupplierId,4))+1 As MaxID From SupplierMaster Where Right(Left(SupplierId,6),3)= '" + Left(MstDesc, 3) + "'";
                    SQL = "Select Max(Right(orderno,4))+1 As MaxID From VyapariOrder Where Right(Left(orderno,1),1)= 'H'";
                    break;


                case "I":

                    SQL = "Select Max(Right(InvoiceNo,4))+1 As MaxID From SupplierBookingBillMaster Where Right(Left(InvoiceNo,1),1)= 'I'";
                    break;

                case "M":

                    SQL = "Select Max(Right(Mod_ID,4))+1 As MaxID From Mod_Entries Where Right(Left(Mod_ID,1),1)= 'M'";
                    break;

                case "N":

                    SQL = "Select Max(Right(BillNo,4))+1 As MaxID From tblImitationBillMaster Where Right(Left(BillNo,1),1)= 'N'";
                    break;

                case "O":

                    SQL = "Select Max(Right(OrderNo,4))+1 As MaxID From OrderMaster Where Right(Left(OrderNo,1),1)= 'O'";
                    break;

                case "P":

                    SQL = "Select Max(Right(SupplierId,4))+1 As MaxID From SupplierBookingMaster Where Right(Left(SupplierId,1),1)= 'P'";
                    break;



                case "R":

                    SQL = "Select Max(Right(RefineID,4))+1 As MaxID From Refinery_Items Where Right(Left(RefineID,1),1)= 'R'";
                    break;

                case "S":

                    SQL = "Select Max(Right(BillNo,4))+1 As MaxID From SalesBBillMaster Where Right(Left(BillNo,1),1)= 'S'";

                    break;


                case "W":

                    SQL = "Select Max(Right(BillNo,4))+1 As MaxID From vyapariBookingBillMaster Where Right(Left(BillNo,1),1)= 'W'";

                    break;













                default:
                    break;
            }

            if (MstType == "INV" || MstType == "KHA" || MstType == "GRV" || MstType == "SUP" || MstType == "ITM" || MstType == "VPB")
            {
                MCODE = MstType + Right("0000" + ExecuteScalar(SQL), 4);
                if (Right(MCODE, 4) == "0000")
                {
                    MCODE = MstType + "0001";
                }
            }
            else
            {
                MCODE = MstType + Left(MstDesc, 3) + Right("0000" + ExecuteScalar(SQL), 4);
                if (Right(MCODE, 4) == "0000")
                {
                    MCODE = MstType + Left(MstDesc, 3) + "0001";
                }
            }

            return MCODE;
        }
        #endregion

        //Declearation\\
        public static string Left(string param, int length)
        {

            string result = param.Substring(0, length);
            //return the result of the operation
            return result;


        }
        public static string Right(string param, int length)
        {
            //string result = param.Substring(param.Length - length, length);
            ////return the result of the operation
            //return result;
            string result = param.Substring(param.Length - length, length);
            //return the result of the operation
            return result;
        }

        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            //return the result of the operation
            return result;
        }

        public static string Mid(string param, int startIndex)
        {
            string result = param.Substring(startIndex);
            //return the result of the operation
            return result;
        }

        #endregion

    }
}
