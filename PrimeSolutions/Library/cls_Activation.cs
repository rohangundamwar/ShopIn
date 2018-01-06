using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Security.Cryptography;
using System.IO;
using System.Management;
using PrimeSolutions.Common;

namespace PrimeSolutions.Library
{
    class cls_Activation
    {
        clsCommon _common = new clsCommon();
        SQLHelper _sql = new SQLHelper();
        DataTable Act { get; set; }

        public cls_Activation()
        {
           
        }

        public string CheckValidity()
        {
            DateTime start = Convert.ToDateTime(Act.Rows[0]["StartDate"]);
            int ValidDays = Convert.ToInt32(Act.Rows[0]["Validity"]);
            DateTime ValidTo = start.AddDays(ValidDays);
            DateTime CurrentDate = DateTime.Now;
            if (CurrentDate < ValidTo)
            {
                if (ValidTo.AddDays(-15) < CurrentDate)
                {
                    string days = Convert.ToString((ValidTo.Date - CurrentDate.Date).Days);
                    return days;
                }
                else
                    return "Valid";
            }

            else
                return "Invalid";
        }

        public bool CheckActivation()
        {
            string str = "SELECT * from Activation";
            Act = _sql.GetDataTable(str);

            String Serial = Encrypt(getMotherBoardID());
            if (Act.Rows[0]["SerialNo"].ToString() != Serial)
            {
                frm_Activation _Act = new frm_Activation();
                _Act.ShowDialog();

                string str1 = "SELECT * from Activation";
                Act = _sql.GetDataTable(str1);
            }

            string Encr = Encrypt(getMotherBoardID());

            if (Encr == Act.Rows[0]["SerialNo"].ToString())
                return true;
            else
                return false;

        }


        public string Encrypt(string clearText)
        {
            string EncryptionKey = "Primatus@111";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            clearText = clearText.Substring(3, 12);
            clearText = clearText.ToUpper(); 
            return clearText;
        }


        public String getMotherBoardID()
        {
            String serial = "";
            try
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
                ManagementObjectCollection moc = mos.Get();

                foreach (ManagementObject mo in moc)
                {
                    serial = mo["SerialNumber"].ToString();
                }
                return serial;
            }
            catch (Exception)
            {
                return serial;
            }
        }
        

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "Primatus@111";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, 12);
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }

            cipherText = cipherText.Substring(3, 12);
            return cipherText;
        }   
    }
}
