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
            //parseCompanies(@"D:\BACKUP\CATS Vo beo\Demo\");
            //parseCompanies(@"D:\BACKUP\CATS Vo beo\CompanyLink\");
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
                        name = nodes[0].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.').Replace("  ", " ");
                        name = Regex.Replace(name, @"\s+", " ");
                        can.FirstName = name.Split(' ').First();
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
                        if (string.Equals(can_relocate.ToUpper(), "YES"))
                        {
                            can.CanRelocate = true;
                        }
                        can.CurrentPay = nodes[17].InnerText.Trim();
                        can.DesiredPay = nodes[18].InnerText.Trim();
                        can.DOBMarried = nodes[23].InnerText.Trim();
                        if (can.DOBMarried.Length > 255)
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
                        if (string.Equals(gender.ToUpper(), "FEMALE"))
                        {
                            can.Gender = false;
                        }
                        misc_notes = nodes[26].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.');
                        bytes = Encoding.Default.GetBytes(misc_notes);
                        misc_notes = Encoding.UTF8.GetString(bytes);
                        can.MiscNotes = misc_notes;


                        // insert to database
                        try
                        {
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

        private void parseCompanies(string sorce_folder)
        {
            // parse data from html and save to file
            string[] list_file = Directory.GetFiles(sorce_folder);
            int counter = 0;
            var doc = new HtmlAgilityPack.HtmlDocument();
            int index = 0;

            foreach (var file_name in list_file)
            {
                Company com = new Company() { UserId = UserManager.ActivatedUser.UserId };
                string billing_contact = "";
                string active = "";
                string misc_notes = "";
                string job_order_string = "";
                string contacts_string = "";

                try
                {
                    doc.Load(file_name);
                    ++index;
                    //parse general information
                    var nodes = doc.DocumentNode.SelectNodes("//table[@class='detailsInside']//td[@class='data']");
                    if (nodes != null)
                    {

                        com.Name = nodes[0].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.');
                        com.PrimaryPhone = nodes[1].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.');
                        com.SecondaryPhone = nodes[2].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.');
                        com.FaxNumber = nodes[3].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.');
                        com.Address = nodes[4].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.').Replace("&nbsp;", "");
                        com.City = nodes[5].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.').Replace("&nbsp;", ""); //?
                        com.CountryOfOrigin = nodes[6].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.');
                        active = nodes[7].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.');
                        if (string.Equals(active.ToUpper(), "NO"))
                        {
                            com.IsActive = false;
                        }
                        else
                        {
                            com.IsActive = true;
                        }
                        billing_contact = nodes[8].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.').Replace("&nbsp;", "");
                        if (billing_contact.Length > 0)
                        {
                            com.MiscNotes = "Billing Contact: " + billing_contact + "\r\n";
                        }
                        com.WebSite = nodes[9].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.');
                        com.KeyTechnologies = nodes[10].InnerText.Trim().Replace("&nbsp;", ""); ;
                        com.ServiceContractTerms = nodes[14].InnerText.Trim().Replace("&nbsp;", ""); ;
                        com.Industry = nodes[15].InnerText.Trim().Replace("&nbsp;", ""); ;
                        com.ABC = nodes[16].InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace('\n', '.');
                        misc_notes = nodes[18].InnerText.Trim();
                        byte[] bytes = Encoding.Default.GetBytes(misc_notes);
                        misc_notes = Encoding.UTF8.GetString(bytes);
                        com.MiscNotes += misc_notes;
                    }


                    //parse list job orders

                    nodes = doc.DocumentNode.SelectNodes("//table[@class='sortable']//tr[contains(@class,'TableRow')][not (@id)]");
                    if (nodes != null)
                    {
                        foreach (var node in nodes)
                        {
                            var ls = node.InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace("\n\n", "\n").Split('\n');
                            job_order_string += String.Join(" ", ls) + "; ";
                        }
                    }


                    if (job_order_string.Length > 1)
                    {
                        job_order_string = job_order_string.Remove(job_order_string.Length - 2, 2);
                        job_order_string = Regex.Replace(job_order_string, @"\s+", " ");

                        com.MiscNotes += "Job Orders: " + job_order_string + "\r\n";

                    }



                    //parse list contacts
                    nodes = doc.DocumentNode.SelectNodes("//table[@class='sortable']//tr[contains(@class,'TableRow') and contains(@id,'ContactsDefault')]");

                    if (nodes != null)
                    {
                        foreach (var node in nodes)
                        {
                            var ls = node.InnerText.Trim().Replace('\t', ' ').Replace('\r', ' ').Replace("\n\n", "\n").Split('\n');
                            contacts_string += String.Join(" ", ls) + "; ";
                        }
                    }


                    if (contacts_string.Length > 1)
                    {
                        contacts_string = contacts_string.Remove(contacts_string.Length - 2, 2);
                        contacts_string = Regex.Replace(contacts_string, @"\s+", " ");
                        com.MiscNotes += "Lis Contact: " + contacts_string + "\r\n";
                    }

                    com.MiscNotes = com.MiscNotes.Replace("&nbsp;", "").Replace("&amp;", "").Replace("Henry N.", "");
                    com.MiscNotes = Regex.Replace(com.MiscNotes, @"\s+", " ");

                    CompanyManager.addNewCompany(com);

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
