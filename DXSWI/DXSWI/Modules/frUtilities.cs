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
using OfficeOpenXml;
using System.Security.Principal;

namespace DXSWI.Modules
{
    public partial class frUtilities : DevExpress.XtraEditors.XtraUserControl
    {
        public frUtilities()
        {
            InitializeComponent();
            // fortest:
            //FileNameTextEdit.Text = @"C:\Users\phuon\Documents\PR2610.xlsx";
        }

        private void sbBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            if (openFileDlg.ShowDialog() != DialogResult.OK)
                return;
            FileNameTextEdit.Text = openFileDlg.FileName;
            printMessage("Load file: " + openFileDlg.FileName);

        }

        private void sbImport_Click(object sender, EventArgs e)
        {
            //// typeofdata: 0: candidate, 1: company, 2: contact
            //try
            //{
            //    switch (FileTypeComboBoxEdit.SelectedIndex)
            //    {
            //        case 0:
            //            importCandiate(FileNameTextEdit.Text);
            //            break;
            //        case 1:
            //            importCompany(FileNameTextEdit.Text);
            //            break;
            //        case 2:
            //            importContact(FileNameTextEdit.Text);
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    printMessage(string.Format("Error: {0}", ex.Message));
            //}

        }


        private void correctDB()
        {
            // get all candidateId, City, Cellphone
            DataTable dt = CandidateManager.getCandidatesOverview();
            string msg = string.Empty;
            int counter = 0;
            try
            {
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    // corect db
                    DataRow data_row = dt.Rows[i];
                    long candiateId = Convert.ToInt64(data_row["CandidateId"].ToString());
                    string city = data_row["City"].ToString();
                    string cellphone = data_row["CellPhone"].ToString();
                    string keySkills = data_row["KeySkills"].ToString();

                    city = city.Replace("Da nang", "Danang").Replace("Da Nang", "Danang").Replace("DA NANG", "Danang").Replace("DANANG", "Danang");
                    city = city.Replace("Ha Noi", "Hanoi").Replace("hanoi", "Hanoi").Replace("hANOI", "Hanoi").Replace("HaNoi", "Hanoi").Replace("HANOI", "Hanoi").Replace("HN", "Hanoi");
                    city = city.Replace("hcm", "HCM").Replace("Hcm", "HCM").Replace("HcM", "HCM").Replace("HCm", "HCM").Replace("HCMC", "HCM").Replace("HCN", "HCM").Replace("Ho Chi Minh", "HCM");
                    city = city.Trim();

                    cellphone = cellphone.Replace("(Mobile)", "").Replace("(Home)", "").Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace(".", "");
                    cellphone = cellphone.Trim();
                    keySkills = keySkills.Replace("Hanoi, ", "").Replace("HCM, ", "").Trim();

                    msg += string.Format("{0}\t\t{1}\t\t{2}\t\t{3} \r\n", candiateId, city, cellphone, keySkills);
                    counter = i;
                    // update to db
                    CandidateManager.correctDatabase(candiateId, city, cellphone, keySkills);
                }
                printMessage("Finish");
            }
            catch (Exception ex)
            {
                printMessage(string.Format("error id = {0}: {1}", counter, ex.Message));
                //++counter;
            }

        }
        private void printMessage(string msg)
        {
            InfoMemoEdit.Text += msg + "\r\n";
        }

        private void importCandiate(string filePath)
        {
            //parseCandidateFromLinks(@"D:\BACKUP\CATS Vo beo\links\");
            parseCandidateFromExel(filePath);
        }
        private void importCompany(string filePath)
        {
            //parseCompanies(@"D:\BACKUP\CATS Vo beo\Demo\");
            //parseCompanies(@"D:\BACKUP\CATS Vo beo\CompanyLink\");
        }

        private void importContact(string filePath)
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                if (package.Workbook.Worksheets.Count <= 1)
                    return;
                ExcelWorksheet workSheet = package.Workbook.Worksheets["PR tl"];
                //ExcelWorksheet workSheet = package.Workbook.Worksheets.FirstOrDefault();
                // read all data begin from row 2
                for (var rowNumber = 2; rowNumber < workSheet.Dimension.End.Row; rowNumber++)
                {
                    var row = workSheet.Cells[rowNumber, 1, rowNumber, workSheet.Dimension.End.Column];
                    var cells = row.ToList();
                    Contact con = new Contact();

                    con.FirstName = cells[0].Text.Trim(); //first name
                    con.LastName = cells[1].Text.Trim(); // lastname
                    con.CompanyName = cells[2].Text.Trim(); // company
                    if (con.CompanyName.Length == 0) continue;
                    con.Title = cells[3].Text.Trim(); // title
                    con.Email = cells[4].Text.Trim(); // email address
                    con.CellPhone = cells[5].Text.Trim(); // phone numbers
                    con.MiscNotes = con.CompanyName;
                    con.MiscNotes += "\r\n" + cells[6].Text;

                    con.UserId = UserManager.ActivatedUser.UserId;
                    // insert to database
                    try
                    {
                        ContactManager.InsertContact(con);
                    }
                    catch (Exception ex)
                    {
                        printMessage(string.Format("Error: {0} of row = {1}", ex.Message, rowNumber));
                    }

                    //Candidate can = new Candidate();

                    //can.FirstName = cells[0].Text.Trim(); //first name
                    //can.LastName = cells[1].Text.Trim(); // lastname
                    //can.CurrentEmployer = cells[2].Text.Trim(); // company
                    //if (can.CurrentEmployer.Length == 0) continue;
                    //can.CurrentPosition = cells[3].Text.Trim(); // title
                    //can.Email = cells[4].Text.Trim(); // email address
                    //can.CellPhone = cells[5].Text.Trim(); // phone numbers
                    //can.MiscNotes = can.CurrentEmployer;
                    //can.MiscNotes += "\r\n" + cells[6].Text;
                    //can.ProjectDone = "Need to update";

                    //can.UserId = UserManager.ActivatedUser.UserId;
                    //// insert to database
                    //try
                    //{
                    //    CandidateManager.InsertCandidate(can);
                    //}
                    //catch (Exception ex)
                    //{
                    //    printMessage(string.Format("Error: {0} of row = {1}", ex.Message, rowNumber));
                    //}
                }

            };
        }

        public void parseCandidateFromLinks(string sourceFolder)
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


        public void ParseCandidateFromQuandidateLinks(string inputFolder)
        {
            string[] inputFiles = Directory.GetFiles(inputFolder);
            var doc = new HtmlAgilityPack.HtmlDocument();
            List<string> listEmails = new List<string>();

            foreach (var fileName in inputFiles)
            //for (int j = 0;j < 2; ++j)
            {
                //var fileName = inputFiles[j];
                //necessary information
                Candidate can = new Candidate() { Source = "Other", Country = "Vietnam" };
                try
                {
                    doc.Load(fileName);
                    ////parse general information
                    var nodes = doc.DocumentNode.SelectNodes("//li[@class='text-notable']");
                    if (nodes != null && nodes.Count > 0)
                    {
                        var name = nodes[0].InnerText.Trim();
                        name = Regex.Replace(name, @"\s+\n*\t*\r*", " ", RegexOptions.Multiline).Replace("&nbsp;", "\n").Trim();
                        can.FirstName = name.Split(' ').First();
                        can.LastName = name.Replace(can.FirstName, "").Trim();
                    }
                    nodes = doc.DocumentNode.SelectNodes("//li");
                    var texts = nodes.Select(node =>
                    {
                        var s = Regex.Replace(node.InnerText.Replace("&nbsp;", "").Replace("\n", " ").Trim(), @"\s+\n+\t+\r+", " ", RegexOptions.Multiline);
                        return Regex.Replace(s, @"\s+", " ", RegexOptions.Multiline);
                    }).SkipWhile(text => string.Compare(text, "Hire") != 0).ToList();
                    can.KeySkills = texts[3];
                    can.KeySkills += "; Need update from CV";
                    var appState = texts[4].Split('/').First();
                    if (appState.Contains("Hired"))
                    {
                        can.CurrentEmployer = "Tek Expert";
                        can.CurrentPosition = texts[3];
                    }
                    can.InterviewNotes = "State of Candidate in Tek Experts: " + appState;
                    can.Address = texts[5].Replace("Address", "").Trim();
                    can.City = texts[6].Replace("Postal code / City", "");
                    can.City = Regex.Replace(can.City, @"\d+", string.Empty).Trim();
                    for (var i = 7; i < texts.Count; ++i)
                    {
                        var it = texts[i];
                        if (it.Contains("Tel ") && can.CellPhone.Length == 0)
                        {
                            can.CellPhone = it.Replace("Tel ", "");
                        }
                        else if (it.Contains("Email ") && can.Email.Length == 0)
                        {
                            can.Email = it.Replace("Email ", "");
                        }
                        else if (string.Compare(it, "Cover letter") != 0)
                        {
                            break;
                        }
                    }

                    if (can.Email.Length > 0)
                    {
                        if (can.Email.Contains(@"techspaces.com.vn"))
                        {
                            continue;
                        }

                        if (listEmails.Contains(can.Email))
                        {
                            continue;
                        }
                        else
                        {
                            listEmails.Add(can.Email);
                        }
                    }
                    can.MiscNotes += string.Join("\n", texts.SkipWhile(text => string.Compare(text, "Other applications") != 0).Skip(1));

                    // get note and cover letter
                    nodes = doc.DocumentNode.SelectNodes("//div[@id='box-motivation']//div[@class='box-content']");
                    if (nodes != null)
                    {
                        var coverLt = nodes.Select(node => Regex.Replace(node.InnerText.Trim(), @"\s+", " ", RegexOptions.Multiline)).ToList();
                        if (coverLt.Count > 0 && coverLt.First().Length > 0)
                        {
                            can.InterviewNotes = "Cover leter: " + coverLt.First();
                        }
                        can.InterviewNotes = can.InterviewNotes.Replace("&amp;", "&").Replace("&gt;", ">").Replace("&lt;", "<").Replace("&quote;", "\"").Replace("&nbsp;", " ");
                    }
                    nodes = doc.DocumentNode.SelectNodes("//textarea[@class='qeditor']");
                    if (nodes != null)
                    {
                        var tmp = nodes.Select(node => node.InnerText.Trim()).ToList();
                        foreach (var vl in tmp)
                        {
                            can.MiscNotes += vl + "\n";
                        }
                        can.MiscNotes = can.MiscNotes.Replace("&amp;", "&").Replace("&gt;", ">").Replace("&lt;", "<").Replace("&quote;", "\"").Replace("&nbsp;", " ");
                    }

                    try
                    {
                        var cvlinks = Directory.GetFiles(fileName.Replace(".html", ""));
                        if (cvlinks.Length > 0)
                        {
                            var cvs = cvlinks.Where(it => it.Contains(".doc") || it.Contains(".pdf")).ToList();
                            if (cvs.Count > 0)
                            {
                                var cvlink = cvs.First();
                                var cvFile = cvlink.Split('\\').Last();
                                if (cvFile.Length > 0)
                                {
                                    // gen link to candidate

                                    // save resum to hardisk: folder = createedtime + candidateName + randomstring
                                    string folderName = can.FirstName + can.LastName + DateTime.Now.ToString(@"_yyyy-MM-dd") + Utils.getRandomAlphaNumeric(10);
                                    string dir = string.Format(@"{0}candidates\resume\{1}\{2}", Properties.Settings.Default.StorageLocation, folderName, cvFile);
                                    can.ResumeLink = dir;
                                    // copy to server
                                    AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
                                    Directory.CreateDirectory(can.ResumeLink.Replace(cvFile, ""));
                                    File.Copy(cvlink, can.ResumeLink, true);

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        printMessage(string.Format("error when get cv file {0}: {1}", fileName, ex.Message));
                    };

                    // insert candidate
                    can.UserId = UserManager.ActivatedUser.UserId;
                    can.CreatedId = UserManager.ActivatedUser.UserId;
                    can.CreatedDate = DateTime.Now;
                    if (!CandidateManager.IsCandidateExist(can))
                    {
                        CandidateManager.InsertCandidate(can);
                    }
                    else
                    {
                        printMessage(string.Format("can is existed: {0}", fileName));
                    }
                }
                catch (Exception ex)
                {
                    printMessage(string.Format("error when parse file {0}: {1}", fileName, ex.Message));
                }
            }
        }

        public void parseCompanies(string sorce_folder)
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

        public void parseCandidateFromExel(string sourceFile)
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(sourceFile)))
            {
                if (package.Workbook.Worksheets.Count < 1)
                    return;

                ExcelWorksheet workSheet = package.Workbook.Worksheets["Head of VN wallet"];
                // read all data begin from row 2
                for (var rowNumber = 2; rowNumber <= workSheet.Dimension.End.Row; rowNumber++)
                {
                    var row = workSheet.Cells[rowNumber, 1, rowNumber, workSheet.Dimension.End.Column];
                    var cells = row.ToList();
                    if (cells.Count == 0)
                        continue;
                    Candidate can = new Candidate();
                    can.FirstName = cells[0].Text.Trim(); //first name
                    can.LastName = cells[1].Text.Trim(); // lastname
                    if (can.FirstName.Length == 0) continue;
                    can.CurrentEmployer = cells[2].Text.Trim(); // companies
                    can.CurrentPosition = cells[3].Text.Trim(); // title
                    can.WebSite = cells[4].Text.Trim(); // link
                    can.Email = cells[5].Text.Trim(); // email address
                    string phone_imskype = cells[6].Text.Trim(); //phone numbers
                    if (phone_imskype.Length > 0)
                    {
                        string[] items = phone_imskype.Split('/');
                        can.CellPhone = items.First().Trim();
                        if (items.Count() > 1)
                        {
                            can.SkypeIM = items.Last().Trim();
                        }
                    }
                    string keyskill = cells[7].Text.Trim(); // tags
                    if (keyskill == null || keyskill.Length == 0)
                    {
                        keyskill = "Head of VN wallet";
                    }
                    can.KeySkills = keyskill;
                    can.ProjectDone = cells[8].Text.Trim(); // note
                    can.MiscNotes = cells[9].Text.Trim();  // comment
                                                           //string gender = cells[10].Text.Trim(); // gender
                                                           //if(string.Equals(gender, "f"))
                                                           //{
                                                           //    can.Gender = false;
                                                           //}
                                                           //can.CurrentPay = cells[11].Text.Trim(); // current pay
                                                           //can.DesiredPay = cells[12].Text.Trim(); // desired
                                                           //can.DOBMarried = cells[13].Text.Trim(); // dob
                    can.City = "Hanoi";
                    can.Country = "Vietnam";
                    can.Source = "LinkedIn";
                    can.UserId = UserManager.ActivatedUser.UserId;

                    // insert to database
                    try
                    {
                        CandidateManager.InsertCandidate(can);
                        printMessage(string.Format("Insert row = {0}", rowNumber));
                    }
                    catch (Exception ex)
                    {
                        printMessage(string.Format("Error: {0} of row = {1}", ex.Message, rowNumber));
                    }
                }
            }
        }

        public DataTable ReadFromExelFile(string path, string sheetName)
        {
            DataTable dt = new DataTable();
            using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
            {
                if (package.Workbook.Worksheets.Count <= 1)
                    return null;
                ExcelWorksheet workSheet = sheetName != null ? package.Workbook.Worksheets[sheetName] : package.Workbook.Worksheets.FirstOrDefault();
                // read all of the headers
                foreach (var firstRowCell in workSheet.Cells[1, 1, 1, workSheet.Dimension.End.Column])
                {
                    dt.Columns.Add(firstRowCell.Text);
                }

                // read all data begin from row 2

                for (var rowNumber = 2; rowNumber < workSheet.Dimension.End.Row; rowNumber++)
                {
                    var row = workSheet.Cells[rowNumber, 1, rowNumber, workSheet.Dimension.End.Column];
                    var newrow = dt.NewRow();
                    foreach (var cell in row)
                    {
                        newrow[cell.Start.Column - 1] = cell.Text;
                    }
                    dt.Rows.Add(newrow);
                }

            };
            return dt;
        }
    }
}
