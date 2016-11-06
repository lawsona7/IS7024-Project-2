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
            this.SuspendLayout();
            // 
            // FileSelection
            // 
            this.FileSelection.Location = new System.Drawing.Point(57, 95);
            this.FileSelection.Margin = new System.Windows.Forms.Padding(2);
            this.FileSelection.Name = "FileSelection";
            this.FileSelection.Size = new System.Drawing.Size(77, 17);
            this.FileSelection.TabIndex = 0;
            this.FileSelection.Text = "Select File";
            this.FileSelection.UseVisualStyleBackColor = true;
            this.FileSelection.Click += new System.EventHandler(this.FileSelection_Click);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(57, 116);
            this.fileName.Margin = new System.Windows.Forms.Padding(2);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(382, 20);
            this.fileName.TabIndex = 1;
            // 
            // fileLocation
            // 
            this.fileLocation.Location = new System.Drawing.Point(137, 95);
            this.fileLocation.Margin = new System.Windows.Forms.Padding(2);
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(301, 20);
            this.fileLocation.TabIndex = 2;
            // 
            // xmlView
            // 
            this.xmlView.Location = new System.Drawing.Point(56, 163);
            this.xmlView.Margin = new System.Windows.Forms.Padding(2);
            this.xmlView.Name = "xmlView";
            this.xmlView.Size = new System.Drawing.Size(382, 455);
            this.xmlView.TabIndex = 4;
            this.xmlView.Text = "";
            // 
            // queryResults
            // 
            this.queryResults.Location = new System.Drawing.Point(1939, 154);
            this.queryResults.Margin = new System.Windows.Forms.Padding(2);
            this.queryResults.Name = "queryResults";
            this.queryResults.Size = new System.Drawing.Size(417, 455);
            this.queryResults.TabIndex = 5;
            this.queryResults.Text = "";
            // 
            // xpathQuery
            // 
            this.xpathQuery.Location = new System.Drawing.Point(2022, 97);
            this.xpathQuery.Margin = new System.Windows.Forms.Padding(2);
            this.xpathQuery.Name = "xpathQuery";
            this.xpathQuery.Size = new System.Drawing.Size(334, 20);
            this.xpathQuery.TabIndex = 6;
            // 
            // xpathButton
            // 
            this.xpathButton.Location = new System.Drawing.Point(1939, 97);
            this.xpathButton.Margin = new System.Windows.Forms.Padding(2);
            this.xpathButton.Name = "xpathButton";
            this.xpathButton.Size = new System.Drawing.Size(77, 18);
            this.xpathButton.TabIndex = 7;
            this.xpathButton.Text = "Search";
            this.xpathButton.UseVisualStyleBackColor = true;
            this.xpathButton.Click += new System.EventHandler(this.xpathButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2090, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2410, 879);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xpathButton);
            this.Controls.Add(this.xpathQuery);
            this.Controls.Add(this.queryResults);
            this.Controls.Add(this.xmlView);
            this.Controls.Add(this.fileLocation);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.FileSelection);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

