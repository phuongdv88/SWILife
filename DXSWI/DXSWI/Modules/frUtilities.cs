using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using HtmlAgilityPack;
using SWIBLL;
using SWIBLL.Models;
using System.Text.RegularExpressions;

namespace DXSWI.Modules
{
    public partial class frUtilities : DevExpress.XtraEditors.XtraUserControl
    {
        string FilePath;
        public frUtilities()
        {
            InitializeComponent();
        }

        private void sbBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            if (openFileDlg.ShowDialog() != DialogResult.OK)
                return;
            FilePath = openFileDlg.FileName;
            FileNameTextEdit.Text = FilePath;
            printMessage("Load file: " + FilePath);

        }

        private void sbImport_Click(object sender, EventArgs e)
        {
            // typeofdata: 0: candidate, 1: company, 2: contact
            switch (FileTypeComboBoxEdit.SelectedIndex)
            {
                case 0:
                    importCandiate(FilePath);
                    break;
                case 1:
                    importCompany(FilePath);
                    break;
                case 2:
                    importContact(FilePath);
                    break;
                default:
                    break;
            }

        }

        private void printMessage(string msg)
        {
            InfoMemoEdit.Text += msg + "\r\n";
        }

        private void importCandiate(string filePath)
        {
            //parseCandidateFromLinks(@"D:\BACKUP\CATS Vo beo\links\");
            // parse line file and create object

            // check duplicate and then import to db

            // print result;
        }
        private void importCompany(string filePath)
        {

        }

        private void importContact(string filePath)
        {

        }

        private void parseCandidateFromLinks(string sourceFolder)
        {
            // parse data from html and save to file
            string[] list_file = Directory.GetFiles(sourceFolder);
            int counter = 0;
            var doc = new HtmlAgilityPack.HtmlDocument();
            int index = 0;
            foreach (var file_name in list_file)
            {
                index++;
                Candidate can = new Candidate();
                string name = "";
                string can_relocate = "";
                string interview_notes = "";
                string gender = "";
                string misc_notes = "";
                try
                {
                    doc.Load(file_name);
                    //parse general information
                    var nodes = doc.DocumentNode.SelectNodes("//table[@class='detailsInside']//td[@class='data']");

                    if (nodes != null)
                    {
                        name = nodes[0].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.').Replace("  "," ");
                        name = Regex.Replace(name, @"\s+", " ");
                        can.FirstName = name.Split(' ').Last();
                        can.LastName = name.Replace(can.FirstName, "").Trim();
                        can.Email = nodes[1].InnerText.Trim();
                        can.SecondaryEmail = nodes[2].InnerText.Trim();
                        can.SkypeIM = nodes[3].InnerText.Trim();
                        can.CellPhone = nodes[4].InnerText.Trim();
                        can.WorkPhone = nodes[5].InnerText.Trim();
                        can.BestTimeToCall = nodes[6].InnerText.Trim();
                        can.Address = nodes[7].InnerText.Trim();
                        can.City = nodes[8].InnerText.Trim();
                        can.WebSite = nodes[9].InnerText.Trim();
                        can.Source = nodes[10].InnerText.Trim();
                        can.CurrentPosition = nodes[11].InnerText.Trim();
                        can.CurrentEmployer = nodes[14].InnerText.Trim();
                        can.KeySkills = nodes[15].InnerText.Trim();
                        can_relocate = nodes[16].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.');
                        can.CanRelocate = false;
                        if(string.Equals(can_relocate.ToUpper(),"YES"))
                        {
                            can.CanRelocate = true;
                        }
                        can.CurrentPay = nodes[17].InnerText.Trim();
                        can.DesiredPay = nodes[18].InnerText.Trim();
                        can.DOBMarried = nodes[23].InnerText.Trim();
                        if(can.DOBMarried.Length > 255)
                        {
                            can.InterviewNotes = can.DOBMarried;
                            can.DOBMarried = string.Empty;
                        }
                        interview_notes = nodes[24].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.');
                        byte[] bytes = Encoding.Default.GetBytes(interview_notes);
                        interview_notes = Encoding.UTF8.GetString(bytes);
                        can.InterviewNotes += interview_notes;
                        gender = nodes[25].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.');
                        can.Gender = true; // male
                        if(string.Equals(gender.ToUpper(), "FEMALE"))
                        {
                            can.Gender = false;
                        }
                        misc_notes = nodes[26].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.');
                        bytes = Encoding.Default.GetBytes(misc_notes);
                        misc_notes = Encoding.UTF8.GetString(bytes);
                        can.MiscNotes = misc_notes;


                        // insert to database
                        try {
                            CandidateManager.InsertCandidate(can);
                        }
                        catch (Exception ex)
                        {
                            printMessage(string.Format("Error: {0} of index = {1}", ex.Message, index));
                        }

                    }
                }
                catch (Exception ex)
                {
                    printMessage(string.Format("error when parse file {0}: {1}", file_name, ex.Message));
                    ++counter;
                }


            }
            printMessage(string.Format("number of error parse file {0}", counter));
        }
    }
}
