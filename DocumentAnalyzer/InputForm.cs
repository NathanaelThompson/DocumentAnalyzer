//Nathanael Thompson
//Applications Programming, Project 5
//SPSU Fall 2014
//Dr. Mamo

/*
 * Notes
 * ------
 * 9/20/14: First rule of software design: understand the problem.
 * 
 * 9/22/14: I don't think I understand the problem. Not like I should.
 *          I was under the impression that we should be scanning each document
 *          dynamically for information, but it seems like some of that
 *          information can, and should be, hard-coded.
 *          
 * 9/25/14: Since we were granted an extension for this assignment, I suppose I should 
 *          take it seriously.  As far as I can tell, the best way to be able to remove 
 *          pages from a pdf document at will is to convert each page to a different
 *          type of document, delete the necessary page, then recompile the document
 *          to display to the user.  
 *          
 * 9/30/14: I have no idea what I'm doing, but let's make something.
 * 
 *          Ok, as of 5:35 today, users can import any PDF,
 *          users can delete a page from a PDF, users can split a
 *          PDF document into two separate documents, and users can assign data
 *          to a collection.  What is left is the search function, assigning tooltips(COMPLETE),
 *          updating the list box with search values(IN PROGRESS), manipulating the files to 
 *          correctly show their IDs(COMPLETE), and updating the Help Documentation(COMPLETE).
 * 
 * 10/1/14: I think this is done.  The search function is sloppy, but it works.
 *          I learned quite a bit about file manipulation and I/O from this project, so I guess
 *          whoever designed this project designed it well.  I can't help but shake the feeling
 *          that I'm forgetting something though...
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace DocumentAnalyzer
{
    public partial class InputForm : Form
    {
        static List<string> listDocumentIDs = new List<string>();
        static List<DocumentCollection> allCollections = new List<DocumentCollection>(100);
        
        //general purpose pdf reader and writer
        PdfReader reader;
        PdfWriter outputWriter1, outputWriter2;
        
        string fileName;
        DateTime date = DateTime.Today;
        public static DocumentCollection currentCollection;
        
        public InputForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //This function's name should be changed to "importButton_Click"
        private void scanButton_Click(object sender, EventArgs e)
        {
            //new instance of an Open File Dialog
            OpenFileDialog opf = new OpenFileDialog();

            //new instance of a DocumentCollection
            DocumentCollection importedDocumentSet = new DocumentCollection();
            
            //settings for opf
            opf.Filter = "PDF Files|*.pdf";
            opf.Title = "Select a PDF File";
            int size = 0;

            if (opf.ShowDialog() == DialogResult.OK)
            {
                //once user has selected a file, store the path as a string
                //and try to gather and set information about the collection
                fileName = opf.FileName;
                try
                {
                    reader = new PdfReader(fileName);
                    size = reader.NumberOfPages;
                    importedDocumentSet.SetNumPages(size);

                    //for testing purposes only
                    if (fileName == "C:\\Users\\nate\\Documents\\Visual Studio 2012\\Projects\\CSharpOnVS2012\\DocumentScannerUploader\\DocumentScannerUploader\\bin\\Debug\\convertdocs.pdf")
                    {
                        //hard coding data for testing purposes
                        importedDocumentSet.SetVendorNumber("0000286970", 0);
                        importedDocumentSet.SetVendorName("UNIVERSAL PROTECTION SERV", 0);
                        importedDocumentSet.SetBankName("BANK OF AMERICA", 0);
                        importedDocumentSet.SetCheckNumber("0000019949", 0);
                        importedDocumentSet.SetCheckDate("5/16/2014", 0);
                        importedDocumentSet.SetCheckTotal("21,822.36", 0);

                        importedDocumentSet.SetVendorNumber("0000286970", 1);
                        importedDocumentSet.SetVendorName("XEROX CORPORATION", 1);
                        importedDocumentSet.SetBankName("BANK OF AMERICA", 1);
                        importedDocumentSet.SetCheckNumber("0000019950", 1);
                        importedDocumentSet.SetCheckDate("5/16/2014", 1);
                        importedDocumentSet.SetCheckTotal("271.07", 1);

                        importedDocumentSet.SetVendorNumber("0000286970", 2);
                        importedDocumentSet.SetVendorName("UNIVERSAL PROTECTION SERV", 2);
                        importedDocumentSet.SetBankName("BANK OF AMERICA", 2);
                        importedDocumentSet.SetCheckNumber("0000019962", 2);
                        importedDocumentSet.SetCheckDate("5/16/2014", 2);
                        importedDocumentSet.SetCheckTotal("7,731.37", 2);

                        importedDocumentSet.SetCollectionID("1", "convertDocs");
                        importedDocumentSet.SetCollectionName("convertDocs");
                        
                        //adds this collection's name to the documentSetCB
                        documentSetCB.Items.Add(importedDocumentSet.GetCollectionName());
                        
                        //navigating to the PDF of concern
                        pdfBrowser.Navigate(fileName);
                        
                        //setting the currentCollection to this most recent collection
                        currentCollection = importedDocumentSet;
                        allCollections.Add(importedDocumentSet);
                    }
                    else
                    {
                        pdfBrowser.Navigate(fileName);
                    }
                }
                catch(IOException ioex)
                {
                    MessageBox.Show(ioex.Message, "PDF error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            vendorNameTB.Text = "";
            vendorNumTB.Text = "";
            bankTB.Text = "";
            checkNumTB.Text = "";
            checkTotalTB.Text = "";
        }
        public void AssignData()
        {
            try
            {
                DocumentCollection docCollection = new DocumentCollection();
                bool allInputsFilled = true;

                //creates a new reader object with a file path
                reader = new PdfReader(fileName);
                docCollection.SetNumPages(reader.NumberOfPages);
                docCollection.SetCollectionFilePath(fileName);

                //this collection of "if" statements check for empty fields
                //and if the field isn't empty, it assigns a value to the collection
                if (vendorNumTB.Text != "")
                {
                    docCollection.SetVendorNumber(vendorNumTB.Text, 0);
                }
                else
                {
                    allInputsFilled = false;
                }

                if (vendorNameTB.Text != "")
                {
                    docCollection.SetVendorName(vendorNameTB.Text, 0);
                }
                else
                {
                    allInputsFilled = false;
                }

                if (bankTB.Text != "")
                {
                    docCollection.SetBankName(bankTB.Text, 0);
                }
                else
                {
                    allInputsFilled = false;
                }

                if (checkNumTB.Text != "")
                {
                    docCollection.SetCheckNumber(checkNumTB.Text, 0);
                }
                else
                {
                    allInputsFilled = false;
                }

                if (checkTotalTB.Text != "")
                {
                    docCollection.SetCheckTotal(checkTotalTB.Text, 0);
                }
                else
                {
                    allInputsFilled = false;
                }

                if (allInputsFilled == true)
                {
                    //if the user inputs all information, 
                    //the collection is assigned an ID, a name, 
                    //and is put in the combobox "documentSetCB"
                    docCollection.SetCollectionID(date.ToString("MMddyyyy"), "-" + vendorNameTB.Text);
                    docCollection.SetCollectionName(vendorNameTB.Text + "-" + checkNumTB.Text);
                    listDocumentIDs.Add(docCollection.GetCollectionID());
                    documentSetCB.Items.Add(docCollection.GetCollectionID());
                }
                else
                {
                    Random rng = new Random();
                    //if the user doesn't put in the necessary information, 
                    //the program will generate a random number to and give the collection a temporary ID
                    docCollection.SetCollectionID("TEMP_ID_", rng.Next(1000, 9999).ToString());
                    docCollection.SetCollectionName("TEMP_NAME_" + rng.Next(1000, 9999).ToString());
                    listDocumentIDs.Add(docCollection.GetCollectionID());
                    documentSetCB.Items.Add(docCollection.GetCollectionID());
                }
                //setting the most currentCollection to this collection
                currentCollection = docCollection;
                allCollections.Add(docCollection);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletePageButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (deletePageBox.Text.Equals("0"))
                {
                    MessageBox.Show("Page # cannot be zero. Please try again.",
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    deleteAst.Visible = true;
                    return;
                }
                else
                {
                    deleteAst.Visible = false;
                }
                //method for extracting selected pages from a PDF
                string outfile = Path.Combine(Application.StartupPath, currentCollection.GetCollectionName() + int.Parse(deletePageBox.Text) +".pdf");
                ExtractPagesFromPDF(fileName, outfile, 1, reader.NumberOfPages, int.Parse(deletePageBox.Text));
            }
            catch (Exception ex)
            {
                deleteAst.Visible = true;
                MessageBox.Show("Page # formatted incorrectly. Please try again.", 
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //This code inspired by this blog:
        //http://www.jamesewelch.com/2008/11/14/how-to-extract-pages-from-a-pdf-document/#comment-683
        //used to remove pages from a PDF file
        public void ExtractPagesFromPDF(string infile, string outfile, int start, int end, int pageToRemove)
        {
            //set reader object to new instance with a file path
            reader = new PdfReader(infile);
            int pageCount = reader.NumberOfPages;
            
            //if the end is less than the start or greater than pageCount, adjust
            if (end < start || end > pageCount)
            {
                end = pageCount;
            }
            
            //new instance of inputDoc from reader 
            //used to write extracted pages from pdf
            Document inputDoc = new Document(reader.GetPageSizeWithRotation(1));
            using (FileStream fs = new FileStream(outfile, FileMode.Create))
            {
                //new instance of outputWriter1
                outputWriter1 = PdfWriter.GetInstance(inputDoc, fs);
                inputDoc.Open();
                
                //grabbing direct content from outputWriter1
                PdfContentByte contentBytes = outputWriter1.DirectContent;

                for (int i = start; i <= end; i++)
                {
                    inputDoc.SetPageSize(reader.GetPageSizeWithRotation(1));
                    inputDoc.NewPage();
                    PdfImportedPage page = outputWriter1.GetImportedPage(reader, i);
                    int rotation = reader.GetPageRotation(i);

                    if (rotation == 90 || rotation == 270)
                    {
                        //adds a new page rotating it upright
                        contentBytes.AddTemplate(page, 0, -1f, 1f, 0, 0, reader.GetPageSizeWithRotation(i).Height);
                    }
                    else if (i == pageToRemove)
                    {
                        //do nothing, skipping this page
                    }
                    else
                    {
                        //adds a new page
                        contentBytes.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
                    }
                }
                //the browser navigates to the newly created file
                fileName = outfile;
                pdfBrowser.Navigate(outfile);

                inputDoc.Close();
                MessageBox.Show("Page deleted, new document located in the Debug folder.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void SplitPDFPages(string infile, string outfile1, string outfile2, int pageToSplit)
        {
            try
            {
                //assigns reader to the input file
                reader = new PdfReader(infile);
                
                //gets number of pages in file
                int pageCount = reader.NumberOfPages;
                
                //uses filestream to create a new file from selected pages
                using (FileStream fs = new FileStream(outfile1, FileMode.Create))
                {
                    //creates new inputDoc and sets it to the page rotation of the reader object
                    Document inputDoc = new Document(reader.GetPageSizeWithRotation(1));
                    outputWriter1 = PdfWriter.GetInstance(inputDoc, fs);
                    inputDoc.Open();

                    //Gets the exact bytes in outputWriter1
                    PdfContentByte contentBytes = outputWriter1.DirectContent;

                    //from page 1 to pageToSplit
                    for (int i = 1; i <= pageToSplit; i++)
                    {
                        //Set page size and create new page
                        inputDoc.SetPageSize(reader.GetPageSizeWithRotation(1));
                        inputDoc.NewPage();
                        PdfImportedPage page = outputWriter1.GetImportedPage(reader, i);

                        //if the rotation of the page is laid width-wise, this catches and corrects it
                        int rotation = reader.GetPageRotation(i);
                        if (rotation == 90 || rotation == 270)
                        {
                            contentBytes.AddTemplate(page, 0, -1f, 1f, 0, 0, reader.GetPageSizeWithRotation(i).Height);
                        }
                        else
                        {
                            contentBytes.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
                        }
                    }
                    inputDoc.Close();
                }
                
                using (FileStream fs2 = new FileStream(outfile2, FileMode.Create))
                {
                    Document inputDoc2 = new Document(reader.GetPageSizeWithRotation(1));
                    outputWriter2 = PdfWriter.GetInstance(inputDoc2, fs2);
                    inputDoc2.Open();

                    PdfContentByte contentBytes2 = outputWriter2.DirectContent;
                    
                    //from the last page of the first document + 1
                    for (int i = pageToSplit + 1; i < pageCount + 1; i++)
                    {
                        inputDoc2.SetPageSize(reader.GetPageSizeWithRotation(1));
                        inputDoc2.NewPage();
                        PdfImportedPage page = outputWriter2.GetImportedPage(reader, i);
                        int rotation = reader.GetPageRotation(i);

                        //if the rotation of the page is laid width-wise, this catches and corrects it
                        if (rotation == 90 || rotation == 270)
                        {
                            contentBytes2.AddTemplate(page, 0, -1f, 1f, 0, 0, reader.GetPageSizeWithRotation(i).Height);
                        }
                        else
                        {
                            contentBytes2.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
                        }
                    }
                    inputDoc2.Close();
                }
                
                MessageBox.Show("Documents split, new documents located in the Debug folder.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (searchListBox.Items[0].Equals("1)Import and save documents"))
            {
                searchListBox.Items.Clear();
            }
            
            AssignData();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            try
            {
                //on starting the application, the browser displays a short message
                pdfBrowser.Navigate(Path.Combine(Application.StartupPath, "StartPage.pdf"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Must have PDF Reader installed.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #region Tool tips
            string saveMsg = "Click this button to save selected values to selected document.";
            string clrMsg = "Click this button to clear the values in these fields.";
            string searchMsg = "Click this button to search for values in the fields above.";
            string deleteMsg = "Click this button to delete a page entered.";
            string splitMsg = "Click this button to split this document into two separate documents.";
            string importMsg = "Click this button to import a new PDF document.";
            string goMsg = "Select a document set, then press go to view that document set.";
            
            saveTip.ShowAlways = true;
            clrTip.ShowAlways = true;
            searchTip.ShowAlways = true;
            deleteTip.ShowAlways = true;
            splitTip.ShowAlways = true;
            importTip.ShowAlways = true;
            goTip.ShowAlways = true;

            saveTip.SetToolTip(saveButton, saveMsg);
            clrTip.SetToolTip(clearButton, clrMsg);
            searchTip.SetToolTip(searchButton, searchMsg);
            deleteTip.SetToolTip(deletePageButton, deleteMsg);
            deleteTip.SetToolTip(deletePageBox, deleteMsg);
            splitTip.SetToolTip(splitPageButton, splitMsg);
            splitTip.SetToolTip(splitPageBox, splitMsg);
            importTip.SetToolTip(importButton, importMsg);
            goTip.SetToolTip(goButton, goMsg);
            #endregion
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfBrowser.Navigate(Path.Combine(Application.StartupPath,"HelpPage.pdf"));
        }

        private void quitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //This is the "Split Page" button click function
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //if the user inputs 0, it breaks the PDF, so this
                //"if" statement prevents 0 from being passed as a value
                //and informs the user they must try again
                if (splitPageBox.Text.Equals("0"))
                {
                    MessageBox.Show("Page # cannot be zero. Please try again.",
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    splitAst.Visible = true;
                    return;
                }
                //sends two files to be split
                string outpath1 = Path.Combine(Application.StartupPath, currentCollection.GetCollectionName() +"_1.pdf");
                string outpath2 = Path.Combine(Application.StartupPath, currentCollection.GetCollectionName() + "_2.pdf");
                SplitPDFPages(fileName, outpath1, outpath2, int.Parse(splitPageBox.Text));
            }
            catch (Exception ex)
            {
                splitAst.Visible = true;
                MessageBox.Show(ex.Message, "Must have at least one saved document.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            string venNumSearch = vendorNumTB.Text;
            string venNameSearch = vendorNameTB.Text;
            string bankSearch = bankTB.Text;
            string checkNumSearch = checkNumTB.Text;
            decimal checkTotalSearch;
            try
            {
                //this decision block is a small failsafe
                //if the check total box is left empty, the program 
                //gives the search value a default of 0
                if (checkTotalTB.Text == "")
                {
                    checkTotalSearch = 0;
                }
                else
                {
                    checkTotalSearch = decimal.Parse(checkTotalTB.Text);
                }
                
                int total = 0;

                for (int i = 0; i < allCollections.Count; i++)
                {
                    if (allCollections[i].GetVendorNumber(i) == venNumSearch)
                    {
                        searchListBox.Items.Add(allCollections[i].GetCollectionID());
                        total++;

                    }
                    else if (allCollections[i].GetVendorName(i) == venNameSearch)
                    {
                        searchListBox.Items.Add(allCollections[i].GetCollectionID());
                        total++;
                    }
                    else if (allCollections[i].GetBankName(i) == bankSearch)
                    {
                        searchListBox.Items.Add(allCollections[i].GetCollectionID());
                        total++;
                    }
                    else if (allCollections[i].GetCheckNumber(i) == checkNumSearch)
                    {
                        searchListBox.Items.Add(allCollections[i].GetCollectionID());
                        total++;
                    }
                    else if (allCollections[i].GetCheckTotal(i) == checkTotalSearch)
                    {
                        searchListBox.Items.Add(allCollections[i].GetCollectionID());
                        total++;
                    }
                }
                MessageBox.Show("Search complete, " + total + " items found.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message,
                    "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        void searchListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //This function grabs the location of the user double clicking
            //checks to see if there is a value where the user clicked
            //and if found, will navigate to that file path

            int index = this.searchListBox.IndexFromPoint(e.Location);
            DocumentCollection docCollection = new DocumentCollection();

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                pdfBrowser.Navigate(allCollections[index].GetCollectionFilePath());
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            try
            {
                string documentSetID = (string)documentSetCB.SelectedItem;
                string path;
                foreach (DocumentCollection coll in allCollections)
                {
                    if (coll.GetCollectionID().Equals(documentSetID))
                    {
                        path = coll.GetCollectionFilePath();
                        pdfBrowser.Navigate(path);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Document Set ID not valid, none entered, or none found.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
