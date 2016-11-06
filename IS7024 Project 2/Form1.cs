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
using System.Collections;
using System.Runtime.InteropServices;
using System.Xml.XPath;
using System.Xml.Linq;

namespace IS7024_Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        XmlDocument xDoc = new XmlDocument();
        private class Result { };
        private void FileSelection_Click(object sender, EventArgs e)
        {
            Stream xmlStream;
            ofd.Filter = "XML|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if ((xmlStream = ofd.OpenFile()) != null)
                {


                    //assign text to text boxes
                    fileName.Text = ofd.FileName;
                    fileLocation.Text = ofd.SafeFileName;



                    //read in text from xml file
                    string xmlName = ofd.FileName;
                    string xmlText = File.ReadAllText(xmlName);
                    xmlView.Text = xmlText;
                }
            }
        }
        private void xpathButton_Click(object sender, EventArgs e)
        {
            var doc = XDocument.Load(ofd.FileName);
            var get = doc.XPathSelectElements(xpathQuery.Text).Elements();
            var result = get.Select(x => x.Value);
            var stringList = string.Join(",", result.ToArray());
            queryResults.Text = stringList;
        }
    }
}