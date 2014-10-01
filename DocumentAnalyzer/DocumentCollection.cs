using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAnalyzer
{
    public class DocumentCollection
    {
        const short VEN_NUM_MAX = 100;
        const short VEN_NAME_MAX = 100;
        const short BANK_MAX = 100;
        const short CHECK_NUM_MAX = 100;
        const short CHECK_DATE_MAX = 100;
        const short CHECK_TOTAL_MAX = 100;
        int numberOfPages;
        string setName;
        string collectionID;
        string filePath;

        string[] vendorNumber= new string[VEN_NUM_MAX];
        string[] vendorName = new string[VEN_NAME_MAX];
        string[] bank = new string[BANK_MAX];
        string[] checkNumber = new string[CHECK_NUM_MAX];
        string[] checkDate = new string[CHECK_DATE_MAX];
        decimal[] checkTotal= new decimal[CHECK_TOTAL_MAX];
        
        public DocumentCollection()
        {
            setName = "NAME NOT SET";
            numberOfPages = 0;
            collectionID = "ID NOT SET";
        }
        public DocumentCollection(string nameOfCollection, string collectID, int numPages)
        {
            setName = nameOfCollection;
            numberOfPages = numPages;
            collectionID = collectID;
        }
        #region Get and Set Methods
        public string GetCollectionFilePath()
        {
            return filePath;
        }
        public int GetNumPages()
        {
            return numberOfPages;
        }
        public string GetCollectionName()
        {
            return setName;
        }
        public string GetCollectionID()
        {
            return collectionID;
        }
        public string GetVendorNumber(int index)
        {
            
            return vendorNumber[index];
        }
        public string GetVendorName(int index)
        {
            
            return vendorName[index];
        }
        public string GetBankName(int index)
        {
            
            return bank[index];
        }
        public string GetCheckNumber(int index)
        {
            
            return checkNumber[index];
        }
        public string GetCheckDate(int index)
        {
            
            return checkDate[index];
        }
        public decimal GetCheckTotal(int index)
        {
            
            return checkTotal[index];
        }
        public void SetCollectionFilePath(string path)
        {
            filePath = path;
        }
        public void SetNumPages(int pages)
        {
            numberOfPages = pages;
        }
        public void SetCollectionName(string name)
        {
            setName = name;
        }
        public void SetCollectionID(string name, string qualifier)
        {
            collectionID = name + qualifier;
        }
        
        //Recursive Set Methods
        public void SetVendorNumber(string venNum, int index)
        {
            if (vendorNumber[index] != null && vendorNumber[index] != "")
            {
                SetVendorNumber(venNum, index + 1);
            }
            else
            {
                vendorNumber[index] = venNum;
            }
        }
        public void SetVendorName(string name, int index)
        {
            if (vendorName[index] != null && vendorName[index] != "")
            {
                SetVendorName(name, index + 1);
            }
            else
            {
                vendorName[index] = name;
            }
        }
        public void SetBankName(string bankName, int index)
        {
            if (bank[index] != null && bank[index] != "")
            {
                SetBankName(bankName, index + 1);
            }
            else
            {
                bank[index] = bankName;
            }
        }
        public void SetCheckNumber(string checkNum, int index)
        {
            if (checkNumber[index] != null && checkNumber[index] != "")
            {
                SetCheckNumber(checkNum, index + 1);
            }
            else
            {
                checkNumber[index] = checkNum;
            }
        }
        public void SetCheckDate(string date, int index)
        {
            if (checkDate[index] != null && checkDate[index] != "")
            {
                SetCheckDate(date, index + 1);
            }
            else
            {
                checkDate[index] = date;
            }
        }
        public void SetCheckTotal(string total, int index)
        {
            if (checkTotal[index] != 0)
            {
                SetCheckTotal(total, index + 1);
            }
            else
            {
                try
                {
                    checkTotal[index] = decimal.Parse(total);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Check total formatted incorrectly.",
                        "Input error", System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
