namespace DocumentAnalyzer
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vendorNumTB = new System.Windows.Forms.TextBox();
            this.vendorNameTB = new System.Windows.Forms.TextBox();
            this.bankTB = new System.Windows.Forms.TextBox();
            this.checkNumTB = new System.Windows.Forms.TextBox();
            this.checkTotalTB = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.checkDTP = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.documentSetCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pdfBrowser = new System.Windows.Forms.WebBrowser();
            this.deletePageButton = new System.Windows.Forms.Button();
            this.deletePageBox = new System.Windows.Forms.TextBox();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.splitPageButton = new System.Windows.Forms.Button();
            this.splitPageBox = new System.Windows.Forms.TextBox();
            this.saveTip = new System.Windows.Forms.ToolTip(this.components);
            this.clrTip = new System.Windows.Forms.ToolTip(this.components);
            this.searchTip = new System.Windows.Forms.ToolTip(this.components);
            this.deleteTip = new System.Windows.Forms.ToolTip(this.components);
            this.splitTip = new System.Windows.Forms.ToolTip(this.components);
            this.importTip = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.goTip = new System.Windows.Forms.ToolTip(this.components);
            this.deleteAst = new System.Windows.Forms.Label();
            this.splitAst = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1308, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click_1);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(1221, 800);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(12, 800);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vendor #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Check #:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bank:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vendor Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Check Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Check Total:";
            // 
            // vendorNumTB
            // 
            this.vendorNumTB.Location = new System.Drawing.Point(143, 356);
            this.vendorNumTB.Name = "vendorNumTB";
            this.vendorNumTB.Size = new System.Drawing.Size(321, 22);
            this.vendorNumTB.TabIndex = 13;
            // 
            // vendorNameTB
            // 
            this.vendorNameTB.Location = new System.Drawing.Point(142, 384);
            this.vendorNameTB.Name = "vendorNameTB";
            this.vendorNameTB.Size = new System.Drawing.Size(322, 22);
            this.vendorNameTB.TabIndex = 14;
            // 
            // bankTB
            // 
            this.bankTB.Location = new System.Drawing.Point(142, 410);
            this.bankTB.Name = "bankTB";
            this.bankTB.Size = new System.Drawing.Size(322, 22);
            this.bankTB.TabIndex = 15;
            // 
            // checkNumTB
            // 
            this.checkNumTB.Location = new System.Drawing.Point(143, 438);
            this.checkNumTB.Name = "checkNumTB";
            this.checkNumTB.Size = new System.Drawing.Size(321, 22);
            this.checkNumTB.TabIndex = 16;
            // 
            // checkTotalTB
            // 
            this.checkTotalTB.Location = new System.Drawing.Point(142, 496);
            this.checkTotalTB.Name = "checkTotalTB";
            this.checkTotalTB.Size = new System.Drawing.Size(322, 22);
            this.checkTotalTB.TabIndex = 18;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(40, 548);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(121, 548);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // checkDTP
            // 
            this.checkDTP.Location = new System.Drawing.Point(142, 466);
            this.checkDTP.Name = "checkDTP";
            this.checkDTP.Size = new System.Drawing.Size(322, 22);
            this.checkDTP.TabIndex = 21;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(202, 548);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 22;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // documentSetCB
            // 
            this.documentSetCB.FormattingEnabled = true;
            this.documentSetCB.Location = new System.Drawing.Point(142, 68);
            this.documentSetCB.Name = "documentSetCB";
            this.documentSetCB.Size = new System.Drawing.Size(322, 24);
            this.documentSetCB.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Document Set:";
            // 
            // pdfBrowser
            // 
            this.pdfBrowser.Location = new System.Drawing.Point(568, 68);
            this.pdfBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.pdfBrowser.Name = "pdfBrowser";
            this.pdfBrowser.Size = new System.Drawing.Size(728, 675);
            this.pdfBrowser.TabIndex = 25;
            // 
            // deletePageButton
            // 
            this.deletePageButton.Location = new System.Drawing.Point(568, 765);
            this.deletePageButton.Name = "deletePageButton";
            this.deletePageButton.Size = new System.Drawing.Size(114, 23);
            this.deletePageButton.TabIndex = 26;
            this.deletePageButton.Text = "Delete Page #:";
            this.deletePageButton.UseVisualStyleBackColor = true;
            this.deletePageButton.Click += new System.EventHandler(this.deletePageButton_Click);
            // 
            // deletePageBox
            // 
            this.deletePageBox.Location = new System.Drawing.Point(688, 765);
            this.deletePageBox.Name = "deletePageBox";
            this.deletePageBox.Size = new System.Drawing.Size(178, 22);
            this.deletePageBox.TabIndex = 27;
            // 
            // searchListBox
            // 
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.ItemHeight = 16;
            this.searchListBox.Items.AddRange(new object[] {
            "1)Import and save documents",
            "2)Search for documents",
            "3)Their IDs will be displayed here",
            "4)Double click an ID to show it"});
            this.searchListBox.Location = new System.Drawing.Point(40, 98);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(424, 244);
            this.searchListBox.TabIndex = 28;
            this.searchListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.searchListBox_MouseDoubleClick);
            // 
            // splitPageButton
            // 
            this.splitPageButton.Location = new System.Drawing.Point(568, 794);
            this.splitPageButton.Name = "splitPageButton";
            this.splitPageButton.Size = new System.Drawing.Size(114, 23);
            this.splitPageButton.TabIndex = 29;
            this.splitPageButton.Text = "Split Page #:";
            this.splitPageButton.UseVisualStyleBackColor = true;
            this.splitPageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitPageBox
            // 
            this.splitPageBox.Location = new System.Drawing.Point(688, 793);
            this.splitPageBox.Name = "splitPageBox";
            this.splitPageBox.Size = new System.Drawing.Size(178, 22);
            this.splitPageBox.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(396, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "*When the check total field is left blank, it is given a default value of zero.";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(470, 68);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 32;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // deleteAst
            // 
            this.deleteAst.AutoSize = true;
            this.deleteAst.ForeColor = System.Drawing.Color.Red;
            this.deleteAst.Location = new System.Drawing.Point(872, 768);
            this.deleteAst.Name = "deleteAst";
            this.deleteAst.Size = new System.Drawing.Size(13, 17);
            this.deleteAst.TabIndex = 33;
            this.deleteAst.Text = "*";
            this.deleteAst.Visible = false;
            // 
            // splitAst
            // 
            this.splitAst.AutoSize = true;
            this.splitAst.ForeColor = System.Drawing.Color.Red;
            this.splitAst.Location = new System.Drawing.Point(872, 796);
            this.splitAst.Name = "splitAst";
            this.splitAst.Size = new System.Drawing.Size(13, 17);
            this.splitAst.TabIndex = 34;
            this.splitAst.Text = "*";
            this.splitAst.Visible = false;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 835);
            this.Controls.Add(this.splitAst);
            this.Controls.Add(this.deleteAst);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.splitPageBox);
            this.Controls.Add(this.splitPageButton);
            this.Controls.Add(this.searchListBox);
            this.Controls.Add(this.deletePageBox);
            this.Controls.Add(this.deletePageButton);
            this.Controls.Add(this.pdfBrowser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.documentSetCB);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.checkDTP);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.checkTotalTB);
            this.Controls.Add(this.checkNumTB);
            this.Controls.Add(this.bankTB);
            this.Controls.Add(this.vendorNameTB);
            this.Controls.Add(this.vendorNumTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InputForm";
            this.Text = "Input Form";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vendorNumTB;
        private System.Windows.Forms.TextBox vendorNameTB;
        private System.Windows.Forms.TextBox bankTB;
        private System.Windows.Forms.TextBox checkNumTB;
        private System.Windows.Forms.TextBox checkTotalTB;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DateTimePicker checkDTP;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox documentSetCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.WebBrowser pdfBrowser;
        private System.Windows.Forms.Button deletePageButton;
        private System.Windows.Forms.TextBox deletePageBox;
        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.Button splitPageButton;
        private System.Windows.Forms.TextBox splitPageBox;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolTip saveTip;
        private System.Windows.Forms.ToolTip clrTip;
        private System.Windows.Forms.ToolTip searchTip;
        private System.Windows.Forms.ToolTip deleteTip;
        private System.Windows.Forms.ToolTip splitTip;
        private System.Windows.Forms.ToolTip importTip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ToolTip goTip;
        private System.Windows.Forms.Label deleteAst;
        private System.Windows.Forms.Label splitAst;
    }
}

