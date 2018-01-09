using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BarTender;

namespace PrimeSolutions.Library
{
    class cls_Barcode
    {
        SQLHelper _sql = new SQLHelper();

        public void PrintBarcodeA4(int i)
        {
            BarTender.Application btApp;
            BarTender.Messages btMsgs;
            BarTender.Database btDb;
            // Declare a BarTender document variable
            BarTender.Format btFormat;
            // Declare a BarTender query prompt variable
            BarTender.QueryPrompt btQueryPrompt;
            // Create a new instance of BarTender
            btApp = new BarTender.Application();
            // Set the BarTender application visible
            btApp.Visible = true;
            // Open a BarTender document
            btFormat = btApp.Formats.Open(Environment.CurrentDirectory + "\\" + "BarcodeA4 - Test");
            btDb = btFormat.Databases.GetDatabase(1);
            // Select the query prompt
            btQueryPrompt = btFormat.Databases.QueryPrompts.GetQueryPrompt("Item");
            btFormat.Print("Job" + (i + 1), false, -1, out btMsgs);
            // End the BarTender process
            btApp.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges);
        }
        public void PrintBarcode1No(int i)
        {
            BarTender.Application btApp;
            BarTender.Messages btMsgs;
            BarTender.Database btDb;
            // Declare a BarTender document variable
            BarTender.Format btFormat;
            // Declare a BarTender query prompt variable
            BarTender.QueryPrompt btQueryPrompt;
            // Create a new instance of BarTender
            btApp = new BarTender.Application();
            // Open a BarTender document
            btFormat = btApp.Formats.Open(Environment.CurrentDirectory + "\\" + "Barcode1Test");
            btDb = btFormat.Databases.GetDatabase(1);
            btFormat.Print("Job" + (i + 1), false, -1, out btMsgs);
            // End the BarTender process
            btApp.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges);
        }

        public void PrintBarcode2No(int i)
        {
            BarTender.Application btApp;
            BarTender.Messages btMsgs;
            BarTender.Database btDb;
            // Declare a BarTender document variable
            BarTender.Format btFormat;
            // Declare a BarTender query prompt variable
            BarTender.QueryPrompt btQueryPrompt;
            // Create a new instance of BarTender
            btApp = new BarTender.Application();
            // Open a BarTender document
            btFormat = btApp.Formats.Open(Environment.CurrentDirectory + "\\" + "Barcode2Test");
            btDb = btFormat.Databases.GetDatabase(1);
            btFormat.Print("Job" + (i + 1), false, -1, out btMsgs);
            // End the BarTender process
            btApp.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges);
        }
    }
}
