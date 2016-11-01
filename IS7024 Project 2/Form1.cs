using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;


namespace IS7024_Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void FileSelection_Click(object sender, EventArgs e)
        {
            Stream xmlStream;
            ofd.Filter = "XML|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if ((xmlStream = ofd.OpenFile()) !=null)
                {
                    fileName.Text = ofd.FileName;
                    fileLocation.Text = ofd.SafeFileName;
                    
                    string xmlName = ofd.FileName;
                    string xmlText = File.ReadAllText(xmlName);
                    xmlView.Text = xmlText;
                }

            }
        }

        private void xpathButton_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(ofd.FileName);
                XmlNodeList nodeList;
                XmlNode root = xDoc.DocumentElement;
                string search = xpathQuery.Text;
                nodeList = root.SelectNodes(search);
                
                queryResults.Text = nodeList;
            }
        }
    }
}
