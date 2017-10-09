using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using PrimeSolutions.Report;
using PrimeSolutions.Library;
using PrimeSolutions.Common;

namespace PrimeSolutions.Report
{
    public partial class PrinterSetting : Form
    {
        public PrinterSetting()
        {
            InitializeComponent();
        }

        public string PrinterName { get; set; }
        SettingValue dtsett;
        PrinterSettings _setting = new PrinterSettings();
        Simplevalidations _objSimpal = new Simplevalidations();
        clsCommon _common = new clsCommon();
        public int copies { get; set;} 

        int i = 0;

        private void PrinterSetting_Load(object sender, EventArgs e)
        {
            dtsett = _common.getSettingValue();
            copies = Convert.ToInt32(dtsett.BillCount);
            txt_copy.Text = dtsett.BillCount ;
            try
            {
                if (PrinterSettings.InstalledPrinters.Count <= 0)
                {
                    MessageBox.Show("Printer not found!");
                    return;
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            
            }
            //Get all available printers and add them to the combo box
            try
            {
               
                var printerS = new PrinterSettings();
                cmbPrintlist.Items.Add(printerS.PrinterName);
                

                foreach (String printer in PrinterSettings.InstalledPrinters)
                {
                    if (printer.ToString()!= printerS.PrinterName)
                    {
                        cmbPrintlist.Items.Add(printer.ToString());
                    }
                }
                cmbPrintlist.SelectedIndex = 0;

            }
            catch (System.Exception ex)
            {
            	
            }
           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            PrinterName = cmbPrintlist.SelectedItem.ToString();
            SendResult();
        }

        public int SendResult()
        {
            i = 1;return i;
            
        }

        private void txt_index_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitOnly(e);
        }
    }
}
