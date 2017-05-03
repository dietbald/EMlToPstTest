using Redemption;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMlToPstTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
  //          Type ExcelType = Type.GetTypeFromProgID("Redemption.RDOSession");

  //          set Session = CreateObject("Redemption.RDOSession")
  //Session.LogonPstStore("c:\temp\test.pst")
  //set Folder = Session.GetDefaultFolder(olFolderInbox)
  //set Msg = Folder.Items.Add("IPM.Note")
  //Msg.Sent = true
  //Msg.Import("c:\temp\test.eml", 1024)
  //Msg.Save

            //RDOSession session = new RDOSession(); // throws exception 1
            ////session.Logon("test@coffral.co.th");

            //session.LogonPstStore(@"c:\temp\antonio@coffral.ph.pst");
            //RDOFolder folder = session.GetDefaultFolder(rdoDefaultFolders.olFolderInbox);

            //string[] fileEntries = Directory.GetFiles(@"C:\Users\CoffralTJThailand\Documents\coffral\antonio@coffral.ph\antonio@coffral.ph\", "*.eml");


            //foreach (string filePath in fileEntries)
            //{
            //    RDOMail mail = folder.Items.Add("IPM.Mail");
            //    mail.Sent = true;
            //    mail.Import(filePath, 1024);
            //    // folder.Items.Add(mail);
            //    mail.Save();
            //}

            //session.Logoff();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
