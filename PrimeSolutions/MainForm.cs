﻿using PrimeSolutions.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Common;
using PrimeSolutions.Report;
using PrimeSolutions.Report.Customer;
using PrimeSolutions.Report.Sale;
using PrimeSolutions.Report.Purchase;
using PrimeSolutions.Accounting;
using PrimeSolutions.Sale;
using PrimeSolutions.Service;
using PrimeSolutions.Purchase;
using System.Net.NetworkInformation;
using System.Management;
using System.Security.Cryptography;
using System.IO;
using System.ServiceProcess;
using PrimeSolutions.Report.Profit_Loss;

namespace PrimeSolutions
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        clsCommon _common = new clsCommon();
        SettingValue dtSett = new SettingValue();
        cls_Activation _Act = new cls_Activation();


        private void supplierDailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierBill  _form = new SupplierBill();
            //this.IsMdiContainer = true;
            //_form.TopLevel = false;
            //panel2.Controls.Add(_form);
            //_form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //panel2.Height = _form.Height;
            //panel2.Width = _form.Width;
            //_form.Dock = DockStyle.Fill;
            _form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void stockCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Stock _form = new frm_Stock();
            _form.Dock = DockStyle.Fill;
            _form.ShowDialog();

        }


        private void backUpDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_backup _b = new frm_backup();
            _b.ShowDialog();
        }

        private void saleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_DuplicateBill _d = new frm_DuplicateBill();
            _d.ShowDialog();
        }

        private void customerDatatabseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CustomerContact _form = new frm_CustomerContact();
            //this.IsMdiContainer = true;
            //_form.TopLevel = false;
            //panel2.Controls.Add(_form);
            //_form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //panel2.Height = _form.Height;
            //panel2.Width = _form.Width;
            //_form.Dock = DockStyle.Fill;
            _form.ShowDialog();
        }

        private void customerDailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SaleReport _form = new frm_SaleReport();
            //this.IsMdiContainer = true;
            //_form.TopLevel = false;
            //panel2.Controls.Add(_form);
            //_form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //panel2.Height = _form.Height;
            //panel2.Width = _form.Width;
            //_form.Dock = DockStyle.Fill;
            _form.ShowDialog();
        }
        
        private void duplicateBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void supplierBillDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SupplierBill _form = new frm_SupplierBill();
            _form.ShowDialog();
        }

        private void prefrencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Setting _form = new frm_Setting();
            _form.ShowDialog();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P && Control.ModifierKeys==Keys.Control)
            {
                frm_PurchaseForm _form = new frm_PurchaseForm();
                this.IsMdiContainer = true;
                //_form.TopLevel = false;
                //panel2.Controls.Add(_form);
                //_form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                //panel2.Height = _form.Height;
                //panel2.Width = _form.Width;
                _form.Dock = DockStyle.Fill;
                _form.ShowDialog();
            }

            if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)
            {
                frm_SaleForm _form = new frm_SaleForm();
                this.IsMdiContainer = true;
                //_form.TopLevel = false;
                //panel2.Controls.Add(_form);
                //_form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                //panel2.Height = _form.Height;
                //panel2.Width = _form.Width;
                _form.Dock = DockStyle.Fill;
                _form.ShowDialog();
            }
        }

        private void errorReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Error _form = new frm_Error();
            _form.ShowDialog();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PurchaseForm _form = new frm_PurchaseForm();
            //_form.TopLevel = false;
            //panel2.Controls.Add(_form);
            //_form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //panel2.Height = _form.Height;
            //panel2.Width = _form.Width;
            _form.Dock = DockStyle.Fill;
            _form.ShowDialog();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Category _form = new frm_Category();
            _form.ShowDialog();
        }

        private void subCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SubCategory _form = new frm_SubCategory();
            _form.ShowDialog();
        }

        private void looseItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_LooseItem _form = new frm_LooseItem();
            _form.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openingBalanceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Common.frm_Openning _form = new frm_Openning();
            _form.ShowDialog();
        }

        private void customerBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CustomerBalance _form = new frm_CustomerBalance();
            _form.ShowDialog();
        }

        private void barcodeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_BarcodePrint _form = new frm_BarcodePrint();
            _form.ShowDialog();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAccountLedger form = new frmAccountLedger();
                frmAccountLedger open = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                if (open == null)
                {
                    form.ShowDialog();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 80 : " + ex.Message, "ShopIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentVoucher _form = new frmPaymentVoucher();
            _form.ShowDialog();
        }

        private void debitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceiptVoucher _form = new frmReceiptVoucher();
            _form.ShowDialog();
        }

        private void accountLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AccountLedgerReport form = new Frm_AccountLedgerReport();
            form.Show();
        }

        private void balanceSheetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBalanceSheet _form = new frmBalanceSheet();
            _form.ShowDialog();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PurchaseLedger _form = new frm_PurchaseLedger();
            //_form.MdiParent = this;
            //_form.TopMost = true;
            _form.ShowDialog();
        }

        private void saleLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SaleLedger _form = new frm_SaleLedger();
            _form.ShowDialog();
        }

        private void purchaseItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_EstimatePurchace _form = new frm_EstimatePurchace();
            _form.ShowDialog();
        }

        private void gSTSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SaleForm _form = new frm_SaleForm();
            _form.ShowDialog();
        }

        private void estimateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SaleEstimate _form = new frm_SaleEstimate();
            _form.ShowDialog();
        }

        private void supplierGSTReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SupplierGSTReport _form = new frm_SupplierGSTReport();
            _form.ShowDialog();
        }

        private void purchaseBilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }  

        private void saleBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ChangeBill _form = new frm_ChangeBill("All");
            _form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //string SqlStatus = _common.GetSqlStatus("MSSQLSERVER");
            //if (SqlStatus != "Running")
            //{
            //     _common.StartService("MSSQLSERVER", 100000);
            //}
           
            frm_Login _form = new frm_Login();
            _form.ShowDialog();

            menuStrip1.Visible = _form.result;
            bttn_Login.Visible = !_form.result;
            if (_form.type == "user")
            {
                reportToolStripMenuItem.Enabled = false;
            }
            


            if (!_Act.CheckActivation())
            {
                menuStrip1.Enabled = false;
            }

            string Valid = _Act.CheckValidity();

            if (Valid == "Valid")
            {
                label1.Visible = false;
            }
            else if (Valid == "Invalid")
            {
                MessageBox.Show("Validity Expired \n Please Contact Service Provider\n +91-7709885767");
                menuStrip1.Visible = false;
                label1.Visible = true;
            }
            else
            {
                lbl_ValidDays.Text = Valid + " Days left for Trial";
                lbl_ValidDays.Visible = true; 
            }

            dtSett = _common.getSettingValue();
            if (dtSett.Maintenance == "No")
            {
                serviceToolStripMenuItem.Visible = false;
            }
            else
            {
                serviceToolStripMenuItem.Visible = true;
            }
        }

        private void saleBillToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_DuplicateBill _d = new frm_DuplicateBill();
            _d.ShowDialog();
        }

        private void purchaseToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_PurchaseDuplicateBill _form = new frm_PurchaseDuplicateBill();
            _form.ShowDialog();
        }

        private void updateDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DeveloperLogin _objAccess = new Frm_DeveloperLogin();
            _objAccess.ShowDialog();
            if (_objAccess.Developer_login_Result == true)
            {
                frm_UpdateQuery _form = new frm_UpdateQuery();
                _form.ShowDialog();
            }
            
        }

        private void customerGSTReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CustomerGSTReport _form = new frm_CustomerGSTReport();
            _form.ShowDialog();
        }


        private void customerPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void deleteDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DeveloperLogin _objAccess = new Frm_DeveloperLogin();
            _objAccess.ShowDialog();
            if (_objAccess.Developer_login_Result == true)
            {
                frm_DeleteData  _form = new frm_DeleteData();
                _form.ShowDialog();
            }
        }
        

        private void purchaseGSTReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TotalSupplierGST _form = new frm_TotalSupplierGST();
            _form.ShowDialog(); 
        }

        private void customerPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_CustomerPayment _form = new frm_CustomerPayment();
            _form.ShowDialog();
        }

        private void supplierPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SupplierPayment _form = new frm_SupplierPayment();
            _form.ShowDialog(); 
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_SupplierBalance _form = new frm_SupplierBalance();
            _form.ShowDialog();
        }

        private void newJobToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_JobCard _form = new frm_JobCard();
            _form.ShowDialog();
        }

        private void serviceInvoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_ServiceInvoice _from = new frm_ServiceInvoice();
            _from.ShowDialog();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Login _login = new frm_Login();
            _login.Show();

            menuStrip1.Visible = _login.result;
        }

        private void saleGSTReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TotalCustomerGST _form = new frm_TotalCustomerGST();
            _form.ShowDialog();
        }

        private void monthlyGSTReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MonthlyGSTReport _form = new frm_MonthlyGSTReport();
            _form.ShowDialog();
        }

        private void qoutationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Qoutation _form = new frm_Qoutation();
            _form.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_Sales_Commission _form = new frm_Sales_Commission();
            _form.ShowDialog();
        }

        private void dailyProfitLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_profit_loss _form = new frm_profit_loss();
            _form.ShowDialog();
        }

        private void paymentReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DuplicateReceipt _form = new frm_DuplicateReceipt();
            _form.ShowDialog();
        }

        private void dailyExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Daily_Expenses _form = new frm_Daily_Expenses();
            _form.ShowDialog();
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_UpdateInfo _form = new frm_UpdateInfo();
            _form.ShowDialog();
        }

        private void executeQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DeveloperLogin _objAccess = new Frm_DeveloperLogin();
            _objAccess.ShowDialog();
            if (_objAccess.Developer_login_Result == true)
            {
                frm_ExecuteQuery _form = new frm_ExecuteQuery();
                _form.ShowDialog();
            }
        }

        private void rateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RateChange _form = new frm_RateChange();
            _form.ShowDialog();
        }

        private void customerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Openning _form = new frm_Openning();
            _form.ShowDialog();
        }

        private void offerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Offer _form = new frm_Offer();
            _form.ShowDialog();
        }

        private void stockCheckToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Stock _form = new frm_Stock();
            _form.Dock = DockStyle.Fill;
            _form.ShowDialog();
        }

        private void stockLEdgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_StockLedger _form = new frm_StockLedger();
            _form.ShowDialog();

        }

        private void deletedBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DeletedBill _frm = new frm_DeletedBill();
            _frm.ShowDialog();
        }

        private void rateMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RateMaster _form = new frm_RateMaster();
            _form.ShowDialog(); 
        }
    }
}
