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
        

    }

}
