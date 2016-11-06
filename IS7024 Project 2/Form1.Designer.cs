namespace IS7024_Project_2
{
    partial class Form1
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
            this.FileSelection = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.fileLocation = new System.Windows.Forms.TextBox();
            this.xmlView = new System.Windows.Forms.RichTextBox();
            this.queryResults = new System.Windows.Forms.RichTextBox();
            this.xpathQuery = new System.Windows.Forms.TextBox();
            this.xpathButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchXpath = new System.Windows.Forms.Button();
            this.txtXpath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.xmlQueryResults = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FileSelection
            // 
            this.FileSelection.Location = new System.Drawing.Point(122, 56);
            this.FileSelection.Name = "FileSelection";
            this.FileSelection.Size = new System.Drawing.Size(116, 36);
            this.FileSelection.TabIndex = 0;
            this.FileSelection.Text = "Select File";
            this.FileSelection.UseVisualStyleBackColor = true;
            this.FileSelection.Click += new System.EventHandler(this.FileSelection_Click);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(122, 106);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(571, 26);
            this.fileName.TabIndex = 1;
            this.fileName.TextChanged += new System.EventHandler(this.fileName_TextChanged);
            // 
            // fileLocation
            // 
            this.fileLocation.Location = new System.Drawing.Point(244, 61);
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(450, 26);
            this.fileLocation.TabIndex = 2;
            this.fileLocation.TextChanged += new System.EventHandler(this.fileLocation_TextChanged);
            // 
            // xmlView
            // 
            this.xmlView.Location = new System.Drawing.Point(123, 215);
            this.xmlView.Name = "xmlView";
            this.xmlView.Size = new System.Drawing.Size(571, 423);
            this.xmlView.TabIndex = 4;
            this.xmlView.Text = "";
            this.xmlView.TextChanged += new System.EventHandler(this.xmlView_TextChanged);
            // 
            // queryResults
            // 
            this.queryResults.Location = new System.Drawing.Point(2908, 237);
            this.queryResults.Name = "queryResults";
            this.queryResults.Size = new System.Drawing.Size(624, 698);
            this.queryResults.TabIndex = 5;
            this.queryResults.Text = "";
            // 
            // xpathQuery
            // 
            this.xpathQuery.Location = new System.Drawing.Point(3033, 149);
            this.xpathQuery.Name = "xpathQuery";
            this.xpathQuery.Size = new System.Drawing.Size(499, 26);
            this.xpathQuery.TabIndex = 6;
            // 
            // xpathButton
            // 
            this.xpathButton.Location = new System.Drawing.Point(2908, 149);
            this.xpathButton.Name = "xpathButton";
            this.xpathButton.Size = new System.Drawing.Size(116, 28);
            this.xpathButton.TabIndex = 7;
            this.xpathButton.Text = "Search";
            this.xpathButton.UseVisualStyleBackColor = true;
            this.xpathButton.Click += new System.EventHandler(this.xpathButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3135, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(802, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(655, 796);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchXpath
            // 
            this.searchXpath.Location = new System.Drawing.Point(619, 152);
            this.searchXpath.Name = "searchXpath";
            this.searchXpath.Size = new System.Drawing.Size(75, 39);
            this.searchXpath.TabIndex = 13;
            this.searchXpath.Text = "Search";
            this.searchXpath.UseVisualStyleBackColor = true;
            this.searchXpath.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtXpath
            // 
            this.txtXpath.Location = new System.Drawing.Point(123, 158);
            this.txtXpath.Name = "txtXpath";
            this.txtXpath.Size = new System.Drawing.Size(489, 26);
            this.txtXpath.TabIndex = 14;
            this.txtXpath.TextChanged += new System.EventHandler(this.txtXpath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "XML File";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "XPath";
            // 
            // xmlQueryResults
            // 
            this.xmlQueryResults.Location = new System.Drawing.Point(123, 665);
            this.xmlQueryResults.Name = "xmlQueryResults";
            this.xmlQueryResults.Size = new System.Drawing.Size(571, 288);
            this.xmlQueryResults.TabIndex = 17;
            this.xmlQueryResults.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 1038);
            this.Controls.Add(this.xmlQueryResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXpath);
            this.Controls.Add(this.searchXpath);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xpathButton);
            this.Controls.Add(this.xpathQuery);
            this.Controls.Add(this.queryResults);
            this.Controls.Add(this.xmlView);
            this.Controls.Add(this.fileLocation);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.FileSelection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileSelection;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.TextBox fileLocation;
        private System.Windows.Forms.RichTextBox xmlView;
        private System.Windows.Forms.RichTextBox queryResults;
        private System.Windows.Forms.TextBox xpathQuery;
        private System.Windows.Forms.Button xpathButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchXpath;
        private System.Windows.Forms.TextBox txtXpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.RichTextBox xmlQueryResults;
    }
}

