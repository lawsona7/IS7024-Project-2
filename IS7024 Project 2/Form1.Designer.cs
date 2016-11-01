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
            this.SuspendLayout();
            // 
            // FileSelection
            // 
            this.FileSelection.Location = new System.Drawing.Point(85, 40);
            this.FileSelection.Name = "FileSelection";
            this.FileSelection.Size = new System.Drawing.Size(115, 26);
            this.FileSelection.TabIndex = 0;
            this.FileSelection.Text = "Select File";
            this.FileSelection.UseVisualStyleBackColor = true;
            this.FileSelection.Click += new System.EventHandler(this.FileSelection_Click);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(85, 72);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(571, 26);
            this.fileName.TabIndex = 1;
            // 
            // fileLocation
            // 
            this.fileLocation.Location = new System.Drawing.Point(206, 40);
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(450, 26);
            this.fileLocation.TabIndex = 2;
            // 
            // xmlView
            // 
            this.xmlView.Location = new System.Drawing.Point(85, 126);
            this.xmlView.Name = "xmlView";
            this.xmlView.Size = new System.Drawing.Size(571, 698);
            this.xmlView.TabIndex = 4;
            this.xmlView.Text = "";
            // 
            // queryResults
            // 
            this.queryResults.Location = new System.Drawing.Point(867, 126);
            this.queryResults.Name = "queryResults";
            this.queryResults.Size = new System.Drawing.Size(624, 698);
            this.queryResults.TabIndex = 5;
            this.queryResults.Text = "";
            // 
            // xpathQuery
            // 
            this.xpathQuery.Location = new System.Drawing.Point(992, 71);
            this.xpathQuery.Name = "xpathQuery";
            this.xpathQuery.Size = new System.Drawing.Size(499, 26);
            this.xpathQuery.TabIndex = 6;
            // 
            // xpathButton
            // 
            this.xpathButton.Location = new System.Drawing.Point(867, 70);
            this.xpathButton.Name = "xpathButton";
            this.xpathButton.Size = new System.Drawing.Size(116, 27);
            this.xpathButton.TabIndex = 7;
            this.xpathButton.Text = "Search";
            this.xpathButton.UseVisualStyleBackColor = true;
            this.xpathButton.Click += new System.EventHandler(this.xpathButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1830, 836);
            this.Controls.Add(this.xpathButton);
            this.Controls.Add(this.xpathQuery);
            this.Controls.Add(this.queryResults);
            this.Controls.Add(this.xmlView);
            this.Controls.Add(this.fileLocation);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.FileSelection);
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
    }
}

