using System;
using System.Windows.Forms;
using System.Data;
using PrimeSolutions.Library;


namespace PrimeSolutions.Common
{
    public partial class frm_UpdateQuery : Form
    {
        SQLHelper _objSqlHelper = new SQLHelper();

        public frm_UpdateQuery()
        {
            InitializeComponent();
        }

        private void frm_UpdateQuery_Load(object sender, EventArgs e)
        {
            FillGrid();
            dgv_UpdateQuery.Columns["Query"].Visible = false;
        }


        private void btn_Execute_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_UpdateQuery.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgv_UpdateQuery.Rows[i].Cells["Select"].Value.ToString()) == true)
                {
                    try
                    {
                        string query = dgv_UpdateQuery.Rows[i].Cells["Query"].Value.ToString();
                        _objSqlHelper.ExecuteSql(query);
                    }
                    catch (Exception ex)
                    {
                    }

                }

            }

            MessageBox.Show("Done");
            FillGrid();
        }

        public void FillGrid()
        {
            dgv_UpdateQuery.Rows.Clear();
            string Date = DateTime.UtcNow.ToString();

            string A = "Temp Table";
            string query1 = "CREATE TABLE Temp(Barcode varchar(max), Category nvarchar(max), SubCategory nvarchar(max), SellingAmt nvarchar(max),Size nvarchar(max))";
            dgv_UpdateQuery.Rows.Add(false, A, query1);


            string B = "Activation Table";
            string query2 = "CREATE TABLE Activation (StartDate varchar(max),Validity nvarchar(max))";
            dgv_UpdateQuery.Rows.Add(false, B, query2);

            string C = "SalesmanMaster";
            string query3 = "CREATE TABLE SalesmanMaster([SrNo] [int] IDENTITY(1,1) NOT NULL,[ID] [nvarchar](max) NULL,[Name] [nvarchar](max) NULL,[Address] [nvarchar](max) NULL,[ContactNo] [nvarchar](max) NULL,[IDProof] [nvarchar](max) NULL,[IDNo] [nvarchar](max) NULL) ON [PRIMARY]";
            dgv_UpdateQuery.Rows.Add(false, C, query3);


            string D = "Supplier Refrence No";
            string query4 = "ALTER TABLE SupplierBill ADD RefrenceNo nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, D, query4);
            // 

            string E = "PurchaseRef No";
            string query5 = "ALTER TABLE BillItem ADD PurchaseRef nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, E, query5);

            string F = "Maintainence For Item";
            string query6 = "ALTER TABLE Setting ADD Maintenance nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, F, query6);

            string G = "SalesPerson and Maintainence for Item";
            string query7 = "ALTER TABLE BillItem ADD SalesPerson nvarchar(MAX),Maintain nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, G, query7);

            string H = "Maintainence";
            string query8 = "CREATE TABLE [dbo].[Maintenance]([Date] [nvarchar](max) NULL,[CustomerId] [nvarchar](max) NULL,[SrNo] [int] IDENTITY(1,1) NOT NULL,[Maintain] [nvarchar](max) NULL,[Item] [nvarchar](max) NULL,[MaintainDate] [nvarchar](max) NULL)";
            dgv_UpdateQuery.Rows.Add(false, H, query8);

            string I = "BillItem Permanent delete";
            string query9 = "ALTER TABLE BillItem ADD [PermanentDelete] [bit] NOT NULL CONSTRAINT [DF_BillItem_PermanentDelete]  DEFAULT ((0))";
            dgv_UpdateQuery.Rows.Add(false, I, query9);

            string J = "CustomerBill Permanent delete";
            string query10 = "ALTER TABLE CustomerBill ADD [PermanentDelete] [bit] NOT NULL CONSTRAINT [DF_CustomerBill_PermanentDelete]  DEFAULT ((0))";
            dgv_UpdateQuery.Rows.Add(false, J, query10);

            string K = "SupplierBill Permanent delete";
            string query11 = "ALTER TABLE SupplierBill ADD [PermanentDelete] [bit] NOT NULL CONSTRAINT [DF_SupplierBill_PermanentDelete]  DEFAULT ((0))";
            dgv_UpdateQuery.Rows.Add(false, K, query11);

            string L = "Login";
            string query12 = "CREATE TABLE [dbo].[Login]([UserID] [nvarchar](max) NULL,[Password] [nvarchar](max) NULL,[Type] [nvarchar](max) NULL)";
            dgv_UpdateQuery.Rows.Add(false, L, query12);
            
            string M = "Extra Charges";
            string query13 = "ALTER TABLE CustomerBill ADD ExtraCharges nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, M, query13);

            string N = "Narration for Bill";
            string query14 = "ALTER TABLE CustomerBill ADD Narration nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, N, query14);

            string O = "Add Bill Type";
            string query15 = "ALTER TABLE setting ADD BillType NVARCHAR(MAX)";
            dgv_UpdateQuery.Rows.Add(false, O, query15);

            string P = "Update Opening";
            string query16 = "update CustomerMaster set Opening = '0' where Opening = '' ";
            dgv_UpdateQuery.Rows.Add(false, P, query16);

            string Q = "Add Payment Permanentdelete";
            string query17 = "ALTER TABLE Payment ADD [PermanentDelete] [bit] NOT NULL CONSTRAINT [DF_Payment_PermanentDelete]  DEFAULT ((0))";
            dgv_UpdateQuery.Rows.Add(false, Q, query17);

            string R = "Add SrNo to Payment";
            string query18 = "alter table payment add	[SrNo] [int] IDENTITY(1,1) NOT NULL";
            dgv_UpdateQuery.Rows.Add(false, R, query18);

            string S = "Coulmns For Discount Per Item";
            string query19 = "Alter Table Billitem Add [FinalAmount] [nvarchar](max) NOT NULL CONSTRAINT [DF_BillItem_FinalAmount]  DEFAULT ((0)),[ActualPrice] [nvarchar](max) NOT NULL CONSTRAINT [DF_BillItem_TotalBase]  DEFAULT ((0)),[DiscPer] [nvarchar](max) NOT NULL CONSTRAINT [DF_BillItem_DiscPer]  DEFAULT ((0)),[DiscAmt] [nvarchar](max) NOT NULL CONSTRAINT [DF_BillItem_DiscAmt]  DEFAULT ((0))";
            dgv_UpdateQuery.Rows.Add(false, S, query19);

            string T = "Add SrNo to Payment";
            string query20 = "alter table CustomerBill Add [CashDiscount] [nvarchar](max) NOT NULL CONSTRAINT [DF_BillItem_CashDiscount]  DEFAULT ((0))";
            dgv_UpdateQuery.Rows.Add(false, T, query20);

            string U = "update CrystalReport  for GST(Interstate)";
            string query21 = "update CrystalReport set  Type='GST_Interstate' where Type='GST'";
            dgv_UpdateQuery.Rows.Add(false, U, query21);

            string V = "update CrystalReport  for GST(OtherState)";
            string query22 = "Insert into CrystalReport values('BillA4LndScp(OtherState).rpt','7','GST_OtherState')";
            dgv_UpdateQuery.Rows.Add(false, V, query22);

            string W = "Add Bill Type";
            string query23 = "ALTER TABLE setting Add [ExtraChargesInc] [nvarchar](max) NOT NULL CONSTRAINT [DF_Setting_ExtraCharges]  DEFAULT (('No'))";
            dgv_UpdateQuery.Rows.Add(false, W, query23);

        }

        private void chk_selectall_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_selectall.Checked == true)
            {
                for (int i = 0; i < dgv_UpdateQuery.Rows.Count; i++)
                {
                    dgv_UpdateQuery.Rows[i].Cells[0].Value = true;
                }
            }

            else
            {
                for (int i = 0; i < dgv_UpdateQuery.Rows.Count; i++)
                {
                    dgv_UpdateQuery.Rows[i].Cells[0].Value = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ReceiptNo
            string sql1 = "select count(BillNo) from Payment where type ='Customer' and BillNo=''";
            string sql2 = "select count(BillNo) from Payment where type ='Supplier' and BillNo=''";
            string X = _objSqlHelper.ExecuteScalar(sql1);
            string Y = _objSqlHelper.ExecuteScalar(sql2);
            int Xcount = Convert.ToInt32(X);
            for (int i = 0; i < Xcount; i++)
            {
                string queryX = "Update top(1) Payment set BillNo='"+_objSqlHelper.GetMaxID("R","0")+"' where BillNo='' and Type='Customer'";
                _objSqlHelper.ExecuteScalar(queryX);
            }

            int Ycount = Convert.ToInt32(Y);
            for (int i = 0; i < Ycount; i++)
            {
                string queryY = "Update top(1) Payment set BillNo='" + _objSqlHelper.GetMaxID("X", "0") + "' where BillNo='' and Type='Supplier'";
                _objSqlHelper.ExecuteScalar(queryY);
            }

            if (Xcount == 0 && Ycount == 0)
            {
                MessageBox.Show("Already Updated");
            }
            else
            {
                MessageBox.Show("Updated Successfully");
            }
            
        }
    }

}
