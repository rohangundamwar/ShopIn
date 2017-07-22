using PrimeSolutions.Library;
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

namespace PrimeSolutions
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void supplierDailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierBill  _form = new SupplierBill();
            this.IsMdiContainer = true;
            _form.TopLevel = false;
            panel2.Controls.Add(_form);
            _form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel2.Height = _form.Height;
            panel2.Width = _form.Width;
            _form.Dock = DockStyle.Fill;
            _form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SaleForm _form = new frm_SaleForm();
            this.IsMdiContainer = true;
            _form.TopLevel = false;
            panel2.Controls.Add(_form);
            _form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel2.Height = _form.Height;
            panel2.Width = _form.Width;
            _form.Dock = DockStyle.Fill;
            _form.Show();
        }

        private void stockCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Stock _form = new frm_Stock();
            this.IsMdiContainer = true;
            _form.TopLevel = false;
            panel2.Controls.Add(_form);
            _form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel2.Height = _form.Height;
            panel2.Width = _form.Width;
            _form.Dock = DockStyle.Fill;
            _form.Show();

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
            this.IsMdiContainer = true;
            _form.TopLevel = false;
            panel2.Controls.Add(_form);
            _form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel2.Height = _form.Height;
            panel2.Width = _form.Width;
            _form.Dock = DockStyle.Fill;
            _form.Show();
        }

        private void customerDailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SaleReport _form = new frm_SaleReport();
            this.IsMdiContainer = true;
            _form.TopLevel = false;
            panel2.Controls.Add(_form);
            _form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel2.Height = _form.Height;
            panel2.Width = _form.Width;
            _form.Dock = DockStyle.Fill;
            _form.Show();
        }
        
        private void duplicateBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DuplicateBill _d = new frm_DuplicateBill();
            _d.ShowDialog();
        }

        private void supplierBillDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SupplierBill _form = new frm_SupplierBill();
            this.IsMdiContainer = true;
            _form.TopLevel = false;
            panel2.Controls.Add(_form);
            _form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel2.Height = _form.Height;
            panel2.Width = _form.Width;
            _form.Dock = DockStyle.Fill;
            _form.Show();
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
                _form.TopLevel = false;
                panel2.Controls.Add(_form);
                _form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                panel2.Height = _form.Height;
                panel2.Width = _form.Width;
                _form.Dock = DockStyle.Fill;
                _form.Show();
            }

            if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)
            {
                frm_SaleForm _form = new frm_SaleForm();
                this.IsMdiContainer = true;
                _form.TopLevel = false;
                panel2.Controls.Add(_form);
                _form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                panel2.Height = _form.Height;
                panel2.Width = _form.Width;
                _form.Dock = DockStyle.Fill;
                _form.Show();
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
            this.IsMdiContainer = true;
            _form.TopLevel = false;
            panel2.Controls.Add(_form);
            _form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel2.Height = _form.Height;
            panel2.Width = _form.Width;
            _form.Dock = DockStyle.Fill;
            _form.Show();
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
    }
}
