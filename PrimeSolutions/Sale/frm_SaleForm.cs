
using PrimeSolutions.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace PrimeSolutions
{
    public partial class frm_SaleForm : Form
    {

        Simplevalidations _objSimpal = new Simplevalidations();
        SQLHelper _objSQLHelper = new SQLHelper();
        clsCommon _common = new clsCommon();
        SaleCommon _Sale = new SaleCommon();
        CustomerCommon _Cust = new CustomerCommon();
        ErrorLog _error = new ErrorLog();
        AllClassFile _a = new AllClassFile();
        DataTable dtSett = new DataTable();

        public frm_SaleForm()
        {
            InitializeComponent();
            dtSett = _a.getallssetting();
        }

        
 
        private void frm_PurchaseForm_Load(object sender, EventArgs e)
        {
            Masterclear();
            this.BringToFront();
            Clear();
            cmb_Category.DataSource = _a.FillCategory();
            cmb_SubCategory.DataSource = _a.FillSubCategory();
            cmb_Name.Select();

        }

        private void Masterclear()
        {
            txt_BillNo.Text = _objSQLHelper.gmGetMstID("S", "0");
            txt_AccNo.Text = _objSQLHelper.gmGetMstID("C", "0");
            cmb_Name.ResetText();
            cmb_State.SelectedIndex = 26;
            txt_Address.ResetText();
            txt_City.ResetText();
            txt_ContactNo.ResetText();

            txt_NetAmt.Text="0";
            txt_TotalAmt.Text = "0";
            txt_PaidAmt.Text = "0";
            dgv_ItemInfo.Rows.Clear();
            bttn_Sale.Enabled = false;
            cmb_Name.Select();
            
        }
        
        private void cmb_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==  Keys.Enter)
            {   
                findCustomer();
                if (findCustomer() == 1)
                    cmb_Category.Focus();
                else
                cmb_State.Focus();
            }

            if (e.KeyCode == Keys.Tab)
            {
                txt_BarcodeNo.Focus();
            }

        }

        private int findCustomer()
        {
            DataTable dt = _Sale.GetCustomer(cmb_Name.Text);
            if (dt.Rows.Count > 0)
            {
                txt_AccNo.Text = dt.Rows[0]["CustId"].ToString();
                txt_Address.Text = dt.Rows[0]["Address"].ToString();
                cmb_State.Text = dt.Rows[0]["State"].ToString();
                txt_City.Text = dt.Rows[0]["City"].ToString();
                txt_ContactNo.Text = dt.Rows[0]["ContactNo"].ToString();
                lbl_AccNo.Text = dt.Rows[0]["PanNo"].ToString();
                lbl_AccNo.Text = dt.Rows[0]["GSTIN"].ToString();
                return 1;
            }
            else
                return 0;
        }

        private void txt_Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_City.Focus();
            }
        }

        private void txt_City_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ContactNo.Focus();
            }
        }

        private void txt_MobileNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_BarcodeNo.Focus();
            }
        }

        private void txt_BillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Category.Focus();
            }

        }

        private void cmb_Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_SubCategory.Focus();
            }
        }

        private void cmb_SubCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_HSN.Select();
            }
        }

       

        private void txt_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_CGSTper.Enabled == true)
                    txt_CGSTper.Focus();
                else
                    txt_IGSTper.Focus();
            }
            
        }
        
        private void bttn_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_TotalAmt.Focus();
            }
        }

        

        private void txt_Vat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_NetAmt.Focus();
            }
        }

        private void txt_NetAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PaidAmt.Focus();
            }
        }

       

        private void txt_BalAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Sale.Focus();
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_PurchaseAmt_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            { 
            try
            {
                    if (txt_BarcodeNo.Text != "")
                    {
                        DataTable dt = _Sale.GetItemDetails(txt_BarcodeNo.Text);
                        if (Convert.ToString(dt.Rows[0]["type"]) == "Purchase")
                        {
                            cmb_Category.Text = dt.Rows[0]["category"].ToString();
                            cmb_SubCategory.Text = dt.Rows[0]["sub_category"].ToString();
                            txt_SellingAmt.Text = dt.Rows[0]["sale_amt"].ToString();
                            txt_Amt.Text = (Convert.ToDouble(txt_SellingAmt.Text) * Convert.ToDouble(txt_Qty.Text)).ToString();
                            bttn_Add_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Item Already Sale'd");
                        }
                    }
                   
            }
            catch { }
                if (txt_BarcodeNo.Text == "")
                {
                    cmb_Category.Focus();
                }
            }
        }

        private void txt_SellingAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Qty.Focus();
            }
        }

        private void txt_Amt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Add.Focus();
            }
        }

        private void cmb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharOnly(e);
        }

        private void txt_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharDigitOnly(e);
        }

        private void txt_City_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharOnly(e);
        }

        private void txt_ContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitOnly(e);
        }

        private void txt_MobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitOnly(e);
        }

        private void txt_BillNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharDigitOnly(e);
        }

        private void cmb_Category_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharOnly(e);
        }

        private void cmb_SubCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharOnly(e);
        }

        private void txt_PurchaseAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharDigitOnly(e);
        }

        private void txt_SellingAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_SellingAmt.Text);
        }

        private void txt_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitOnly(e);
        }

        private void txt_Amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_Amt.Text);
        }

        private void txt_TotalAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_TotalAmt.Text);
        }
        

        private void txt_NetAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_NetAmt.Text);
        }

        private void txt_PaidAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_PaidAmt.Text);
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Amt.Text = (Convert.ToDouble(txt_SellingAmt.Text) * Convert.ToDouble(txt_Qty.Text)).ToString();
            }
            catch { }
        }

        private void txt_BarcodeNo_TextChanged(object sender, EventArgs e)
        {
            //if (txt_BarcodeNo.Text != "")
            //{
            //    DataTable dt = _Sale.GetItemDetails(txt_BarcodeNo.Text);
            //    cmb_Category.Text = dt.Rows[0]["category"].ToString();
            //    cmb_SubCategory.Text = dt.Rows[0]["sub_category"].ToString();
            //    txt_SellingAmt.Text = dt.Rows[0]["sale_amt"].ToString();
            //    txt_Size.Text = dt.Rows[0]["size"].ToString();
            //    txt_Amt.Text = (Convert.ToDouble(txt_SellingAmt.Text) * Convert.ToDouble(txt_Qty.Text)).ToString();
            //    bttn_Add_Click(sender, e);
            //}
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            try
            {
                dgv_ItemInfo.Rows.Add(txt_BarcodeNo.Text, cmb_Category.Text, cmb_SubCategory.Text, txt_HSN.Text, txt_BatchNo.Text, txt_SellingAmt.Text, txt_Qty.Text, txt_CGSTper.Text, lbl_CGSTAmt.Text, txt_SGSTper.Text, lbl_SGSTAmt.Text, txt_IGSTper.Text, lbl_IGSTAmt.Text, txt_Amt.Text);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Calculate();
            bttn_Sale.Enabled = true;
            cmb_Category.Focus();
        }
        private void Clear()
        {
            txt_BarcodeNo.ResetText();
            txt_HSN.ResetText();
            txt_BatchNo.ResetText();
            txt_Qty.Text = "1";
            txt_SellingAmt.Text = "0";
            txt_Amt.Text = "0";
            txt_CGSTper.Text = "0";
            txt_SGSTper.Text = "0";
            txt_IGSTper.Text = "0";
        }

        private void Calculate()
        {
            double total = 0;
            double CGSTAmt = 0;
            double SGSTAmt = 0;
            double IGSTAmt = 0;
            try
            {


                for (int i = 0; i < dgv_ItemInfo.Rows.Count; i++)
                {
                    total += Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                    CGSTAmt += Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["CGST"].Value);
                    SGSTAmt += Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["SGST"].Value);
                    IGSTAmt += Convert.ToDouble(dgv_ItemInfo.Rows[i].Cells["IGST"].Value);
                }

                txt_TotalAmt.Text = total.ToString();
                lbl_CGSTValue.Text = CGSTAmt.ToString();
                lbl_SGSTValue.Text = SGSTAmt.ToString();
                lbl_IGSTValue.Text = IGSTAmt.ToString();

                txt_NetAmt.Text = Convert.ToString(total + CGSTAmt + SGSTAmt + IGSTAmt);

            }
            catch (Exception ex)
            {
                _error.AddException(ex, "Purchase");
            }
        }

        private void bttn_Sale_Click(object sender, EventArgs e)
        {
            string BillNo = txt_BillNo.Text;
             MessageBox.Show("Do you Want to Continue With Bill Amount of ₹ " + txt_NetAmt.Text.ToString());
            if (cmb_Name.Text != "" || txt_ContactNo.Text != "")
            {
                if (!_Cust.checkCustomerAccount(cmb_Name.Text))
                {
                    _Cust.AddCustomerDetails(txt_AccNo.Text, cmb_Name.Text, txt_Address.Text, txt_ContactNo.Text);
                }
            }
            try
            {

                for (int i = 0; i < dgv_ItemInfo.Rows.Count; i++)
                {
                        string Category = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value);
                        string SubCategory = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SubCategory"].Value);
                        string Amount = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SellingAmt"].Value);
                        //string narration = Convert.ToString(dgv_ItemInfo.Rows[i].Cells[" "].Value);
                        BillNo = Convert.ToString(txt_BillNo.Text);
                        string AccNo = Convert.ToString(txt_AccNo.Text);
                        string size = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["size"].Value);
                    if (dgv_ItemInfo.Rows[i].Cells["BarcodeNo"].Value.ToString() == "" ||dgv_ItemInfo.Rows[i].Cells["BarcodeNo"].Value.ToString() == string.Empty)
                        
                    {
                        _Sale.AddItemDetails(Category, SubCategory, Amount, size, " ", BillNo, AccNo, dtp_Date.Value.ToString("dd/MM/yyyy"), "Sale");
                    }

                    else
                    {
                        _Sale.UpdateItem(Convert.ToString(dgv_ItemInfo.Rows[i].Cells["BarcodeNo"].Value), txt_BillNo.Text);
                    }

                }
                _Sale.AddBillDetails(txt_BillNo.Text, txt_AccNo.Text, txt_TotalAmt.Text, "",txt_NetAmt.Text,"", dtp_Date.Value.ToString("dd/MM/yyyy"));

            }
            catch (Exception ex)
            {
                _error.AddException(ex, "Sale");
            }

            _Sale.PrintBill(BillNo);
            MessageBox.Show("Sale Successfully Done");
            Masterclear();
            this.BringToFront();
            
            
        }

        private void frm_SaleForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Add)
            {
                txt_TotalAmt.Focus();
            }
        }

        private int calculateVAT()
        {
            
            int totalamt = Convert.ToInt32(txt_TotalAmt.Text);
            return 0 ;
        }

        private void dgv_ItemInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex >= -1)
                {
                    bttn_Delete.Enabled = true;
                    bttn_Update.Enabled = true;
                    bttn_Add.Enabled = false;
                    cmb_Category.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Category"].Value.ToString();
                    cmb_SubCategory.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SubCategory"].Value.ToString();
                    txt_SellingAmt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SellingAmt"].Value.ToString();
                    
                    txt_Qty.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Qty"].Value.ToString();
                    txt_Amt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["TotalAmt"].Value.ToString();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                _error.AddException(ex, "Sale");
            }
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            try
            {

                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Category"].Value = cmb_Category.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SubCategory"].Value = cmb_SubCategory.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SellingAmt"].Value = txt_SellingAmt.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Qty"].Value = txt_Qty.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["TotalAmt"].Value = txt_Amt.Text;
                Calculate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable To Update", "Application says", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _error.AddException(ex, "sale");
            }
            bttn_Add.Enabled = true;
            Clear();
            Calculate();
            
            txt_NetAmt.Text = Convert.ToString(Convert.ToInt32(txt_TotalAmt.Text));
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_ItemInfo.Rows.RemoveAt(dgv_ItemInfo.CurrentCell.RowIndex);
                Calculate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable To Delete", "Application says", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _error.AddException(ex, "Sale");
            }
            bttn_Add.Enabled = true;
            Clear();

        }

        private void txt_SellingAmt_TextChanged(object sender, EventArgs e)
        {
            if(txt_SellingAmt.Text!="" && txt_Qty.Text!="")
            txt_Amt.Text = Convert.ToString((Convert.ToInt32(txt_SellingAmt.Text)) * (Convert.ToInt32(txt_Qty.Text)));
        }
        
        private void bttn_All_Click(object sender, EventArgs e)
        {
            dgv_ItemInfo.Rows.Clear();
        }

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmb_State_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Address.Focus();
            }
        }

        private void txt_GSTIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_BarcodeNo.Focus();
            }
        }

        private void txt_HSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_BatchNo.Focus();
            }
        }

        private void txt_BatchNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_SellingAmt.Focus();
            }
            
        }

        private void txt_CGSTper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_SGSTper.Focus();
            }
        }

        private void txt_SGSTper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add();
            }
        }

        private void cmb_State_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_State.Text == _a.GetState())
            {
                txt_IGSTper.Enabled = false;
                txt_CGSTper.Enabled = true;
                txt_SGSTper.Enabled = true;
            }
            else
            {
                txt_IGSTper.Enabled = true;
                txt_CGSTper.Enabled = false;
                txt_SGSTper.Enabled = false;

            }
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_SubCategory.DataSource=_a.GetSubCategoryByCategory(cmb_Category.Text);
        }

        private void txt_CGSTper_TextChanged(object sender, EventArgs e)
        {
            if (txt_CGSTper.Text != "")
            {
                lbl_CGSTAmt.Text = Convert.ToString((Convert.ToDouble(txt_CGSTper.Text)*0.01)*Convert.ToDouble(txt_Amt.Text));
            }
        }

        private void txt_SGSTper_TextChanged(object sender, EventArgs e)
        {
            if (txt_SGSTper.Text != "")
            {
                lbl_SGSTAmt.Text = Convert.ToString((Convert.ToDouble(txt_SGSTper.Text) * 0.01) * Convert.ToDouble(txt_Amt.Text));
            }
        }

        private void txt_IGSTper_TextChanged(object sender, EventArgs e)
        {
            if (txt_IGSTper.Text != "")
            {
                lbl_IGSTAmt.Text = Convert.ToString((Convert.ToDouble(txt_IGSTper.Text) * 0.01) * Convert.ToDouble(txt_Amt.Text));
            }
        }

        private void txt_IGSTper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add();
            }
        }
    }
}
