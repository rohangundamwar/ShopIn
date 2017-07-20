using PrimeSolutions.ClassFile;
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
            txt_TaxPer.Text =Convert.ToString(_common.GetTax());
            cmb_Name.Select();

        }

        private void Masterclear()
        {
            txt_BillNo.Text = _objSQLHelper.gmGetMstID("S", "0");
            cmb_Name.ResetText();
            cmb_Category.SelectedIndex=-1;
            cmb_SubCategory.SelectedIndex = -1;
            cmb_SubCategory.ResetText();
            txt_AccNo.ResetText();
            txt_Address.ResetText();
            txt_BalAmt.ResetText();
            panel.ResetText();
            txt_City.ResetText();
            txt_ContactNo.ResetText();
            txt_MobileNo.ResetText();
            txt_NetAmt.Text="0";
            txt_PaidAmt.Text="0";
            txt_Qty.Text = "1";
            txt_Size.ResetText();
            txt_TotalAmt.Text = "0";
            txt_Vat.Text="0";
            lbl_Vat.Text =Convert.ToString( dtSett.Rows[0]["Tax"]);
            txt_SellingAmt.Text = "0";
            txt_BarcodeNo.ResetText();
            dgv_ItemInfo.Rows.Clear();
            bttn_Sale.Enabled = false;
            cmb_Name.Select();
            
        }
        
        private void cmb_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==  Keys.Enter)
            {
                findCustomer();
                txt_Address.Focus();
            }

            if (e.KeyCode == Keys.Tab)
            {
                txt_BarcodeNo.Focus();
            }

        }

        private void findCustomer()
        {
            DataTable dt = _Sale.GetCustomer(cmb_Name.Text);
            if (dt.Rows.Count > 0)
            {
                txt_AccNo.Text = dt.Rows[0]["CustId"].ToString();
                txt_Address.Text = dt.Rows[0]["address"].ToString();
                //txt_City.Text = dt.Rows[0]["city"].ToString();
                txt_ContactNo.Text = dt.Rows[0]["ContactNo"].ToString();
                //txt_MobileNo.Text = dt.Rows[0]["phone_no"].ToString();
                //lbl_AccNo.Text = dt.Rows[0]["AccNo"].ToString();
            }
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

        private void txt_ContactNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_MobileNo.Focus();
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
                txt_SellingAmt.Select();
            }
        }

       

        private void txt_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Add_Click(sender, e);
            }
            
        }
        
        private void bttn_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_TotalAmt.Focus();
            }
        }

        private void txt_TotalAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Vat.Focus();
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

        private void txt_PaidAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_BalAmt.Focus();
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
            if (e.KeyCode == Keys.Space)
            {
                txt_BalAmt.Focus();
            }
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
                        txt_Size.Text = dt.Rows[0]["size"].ToString();
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
            }
        }

        private void txt_SellingAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Amt.Focus();
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

        private void txt_Vat_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_Vat.Text);
        }

        private void txt_NetAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_NetAmt.Text);
        }

        private void txt_PaidAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_PaidAmt.Text);
        }

        private void txt_BalAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_BalAmt.Text);
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
            try
            {
                
                dgv_ItemInfo.Rows.Add(txt_BarcodeNo.Text,cmb_Category.Text, cmb_SubCategory.Text, txt_SellingAmt.Text, txt_Qty.Text, txt_Amt.Text,txt_Size.Text);
                Clear();
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Calculate();
            txt_Vat.Text = calculateVAT().ToString();
            txt_NetAmt.Text = Convert.ToString(Convert.ToInt32(txt_Vat.Text) + Convert.ToInt32(txt_TotalAmt.Text));
            bttn_Sale.Enabled = true;

        }

        private void Clear()
        {
            cmb_Category.ResetText();
            cmb_SubCategory.ResetText();
            txt_Qty.Text = "1";
            txt_SellingAmt.Text = "0";
            txt_BarcodeNo.ResetText();
            txt_Amt.Text = "0";
            txt_Size.Text = " ";
        }

        private void Calculate()
        {
            double total = _common.sumGridViewColumn(dgv_ItemInfo, "TotalAmt");
            
            txt_TotalAmt.Text = total.ToString();
        }

        private void bttn_Sale_Click(object sender, EventArgs e)
        {
            string BillNo = txt_BillNo.Text;
             MessageBox.Show("Do you Want to Continue With Bill Amount of ₹ " + txt_NetAmt.Text.ToString());
            if (cmb_Name.Text != "" || txt_ContactNo.Text != "")
            {
                if (!_Cust.checkCustomerAccount(cmb_Name.Text))
                {
                    txt_AccNo.Text = _objSQLHelper.gmGetMstID("C", "0");
                    _Cust.AddCustomerDetails(txt_AccNo.Text, cmb_Name.Text, txt_Address.Text, txt_MobileNo.Text, txt_ContactNo.Text);
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

                    if (dgv_ItemInfo.Rows[i].Cells["BarcodeNo"].Value == "" ||dgv_ItemInfo.Rows[i].Cells["BarcodeNo"].Value == string.Empty)
                        
                    {
                        _Sale.AddItemDetails(Category, SubCategory, Amount, size, " ", BillNo, AccNo, dtp_Date.Value.ToString("dd/MM/yyyy"), "Sale");
                    }

                    else
                    {
                        _Sale.UpdateItem(Convert.ToString(dgv_ItemInfo.Rows[i].Cells["BarcodeNo"].Value), txt_BillNo.Text);
                    }

                }
                _Sale.AddBillDetails(txt_BillNo.Text, txt_AccNo.Text, txt_TotalAmt.Text, txt_Vat.Text, txt_NetAmt.Text, " ", dtp_Date.Value.ToString("dd/MM/yyyy"));

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
            int varper = Convert.ToInt32(txt_TaxPer.Text);
            int totalamt = Convert.ToInt32(txt_TotalAmt.Text);
            int VAT = (totalamt) * varper / 100;
            return VAT;
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
                    txt_Size.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["size"].Value.ToString();
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
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["size"].Value = txt_Size.Text;
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
            txt_Vat.Text = calculateVAT().ToString();
            txt_NetAmt.Text = Convert.ToString(Convert.ToInt32(txt_Vat.Text) + Convert.ToInt32(txt_TotalAmt.Text));
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

        private void txt_TaxPer_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txt_TaxPer.Text != "")
                    if (Convert.ToInt32(txt_TaxPer.Text) > 0)
                    {
                        txt_Vat.Text = calculateVAT().ToString();
                        txt_NetAmt.Text = Convert.ToString((Convert.ToInt32(txt_TotalAmt.Text)) + (Convert.ToInt32(txt_Vat.Text)));
                    }

                    else
                    {
                        txt_NetAmt.Text = Convert.ToString((Convert.ToInt32(txt_TotalAmt.Text)) * 1);
                        txt_Vat.Text = "0";
                    }
                else if (txt_TaxPer.Text == "0" || txt_Vat.Text == null)
                {
                    txt_NetAmt.Text = Convert.ToString((Convert.ToInt32(txt_TotalAmt.Text)) * 1);
                    txt_Vat.Text = "0";
                }
            }
            catch(Exception ex)
            {
                _error.AddException(ex, "Sale");
            }

        }

        private void txt_BalAmt_TextChanged(object sender, EventArgs e)
        {
            if(txt_BalAmt.Text!="")
            txt_PaidAmt.Text =Convert.ToString( Convert.ToInt32(txt_NetAmt.Text) - Convert.ToInt32(txt_BalAmt.Text));

        }

        private void cmb_Category_Enter(object sender, EventArgs e)
        {
            cmb_Category.FlatStyle = FlatStyle.Popup;
        }

        private void cmb_SubCategory_Enter(object sender, EventArgs e)
        {
            cmb_SubCategory.FlatStyle = FlatStyle.Popup;
        }
    }
}
