using Redemption;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMlToPstTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderInputPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void pstFolderSelect_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pst Outlook File|*.pst";
            saveFileDialog1.Title = "Save an Pst File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {

                pstOutputPath.Text = saveFileDialog1.FileName;
                if (!pstOutputPath.Text.EndsWith(".pst")){
                    pstOutputPath.Text += ".pst";
                }
                
            }


        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(pstOutputPath.Text) || string.IsNullOrEmpty(folderInputPath.Text))
            {
                MessageBox.Show("Please select both paths !");
                return;
            }



            RDOSession session = new RDOSession(); // throws exception 1
            //session.Logon("test@coffral.co.th");

            session.LogonPstStore(pstOutputPath.Text);
            RDOFolder folder = session.GetDefaultFolder(rdoDefaultFolders.olFolderInbox);

            string[] fileEntries = Directory.GetFiles(folderInputPath.Text, "*.eml");


            foreach (string filePath in fileEntries)
            {
                RDOMail mail = folder.Items.Add("IPM.Mail");
                mail.Sent = true;
                mail.Import(filePath, 1024);
                // folder.Items.Add(mail);
                mail.Save();
            }

            session.Logoff();


            MessageBox.Show("Done converting !");
        }
    }
}
