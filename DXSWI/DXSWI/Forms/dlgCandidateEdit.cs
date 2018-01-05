using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SWIBLL.Models;
using SWIBLL;
using System.Security.Principal;
using System.IO;

namespace DXSWI.Forms
{
    public partial class dlgCandidateEdit : DevExpress.XtraEditors.XtraForm
    {
        public delegate void onUpdateData();
        public event onUpdateData emitUpdateData;
        Candidate mCandidate;
        string fileNameAvatar = string.Empty;
        string link = string.Empty;
        bool isNew = true;
        public enum ParseCandidateInfoStep
        {
            INIT,
            EXPERIENCE,
            EDUCATION,
            SKILL,
            ACCOMPLISHMENT,
            CONTACT,
            INTEREST,
            FINISH,

        }
        public dlgCandidateEdit(long canId, string toolTip)
        {
            InitializeComponent();
            try
            {
                setCurrentCandidate(canId, toolTip);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setViewMode()
        {
            sbOk.Enabled = false;
            FirstNameTextEdit.ReadOnly = true;
            MiddleNameTextEdit.ReadOnly = true;
            LastNameTextEdit.ReadOnly = true;
            EmailTextEdit.ReadOnly = true;
            SecondaryEmailTextEdit.ReadOnly = true;
            SkypeIMTextEdit.ReadOnly = true;
            CellPhoneTextEdit.ReadOnly = true;
            WorkPhoneTextEdit.ReadOnly = true;
            BestTimeToCallTextEdit.ReadOnly = true;
            AddressTextEdit.ReadOnly = true;
            WebSiteTextEdit.ReadOnly = true;
            SourceTextEdit.ReadOnly = true;
            CurrentPositionTextEdit.ReadOnly = true;
            DateAvailableDateEdit.ReadOnly = true;
            CurrentEmployerTextEdit.ReadOnly = true;
            KeySkillsTextEdit.ReadOnly = true;
            CanRelocateCheckEdit.ReadOnly = true;
            CurrentPayTextEdit.ReadOnly = true;
            DesiredPayTextEdit.ReadOnly = true;
            DOBMarriedTextEdit.ReadOnly = true;
            InterviewNotesMemoEdit.ReadOnly = true;
            GenderComboBoxEdit.ReadOnly = true;
            MiscNotesMemoEdit.ReadOnly = true;
            CityTextEdit.ReadOnly = true;
            CountryTextEdit.ReadOnly = true;
            PositionsUpTillNowTextEdit.ReadOnly = true;
            ProjectDoneMemoEdit.ReadOnly = true;
            IndustryTextEdit.ReadOnly = true;
            EducationMemoEdit.ReadOnly = true;
            LanguageTextEdit.ReadOnly = true;
            IsInBlacklistCheckEdit.ReadOnly = true;
            peAvatar.ReadOnly = true;
        }

        private void dlgCandidateEdit_Load(object sender, EventArgs e)
        {

        }

        private void FillUpToUi()
        {
            if (mCandidate == null)
                return;
            FirstNameTextEdit.Text = mCandidate.FirstName;
            MiddleNameTextEdit.Text = mCandidate.MiddleName;
            LastNameTextEdit.Text = mCandidate.LastName;
            EmailTextEdit.Text = mCandidate.Email;
            SecondaryEmailTextEdit.Text = mCandidate.SecondaryEmail;
            SkypeIMTextEdit.Text = mCandidate.SkypeIM;
            CellPhoneTextEdit.Text = mCandidate.CellPhone;
            WorkPhoneTextEdit.Text = mCandidate.WorkPhone;
            BestTimeToCallTextEdit.Text = mCandidate.BestTimeToCall;
            AddressTextEdit.Text = mCandidate.Address;
            WebSiteTextEdit.Text = mCandidate.WebSite;
            SourceTextEdit.Text = mCandidate.Source;
            CurrentPositionTextEdit.Text = mCandidate.CurrentPosition;
            DateAvailableDateEdit.Text = mCandidate.DateAvailable.ToShortDateString();
            CurrentEmployerTextEdit.Text = mCandidate.CurrentEmployer;
            KeySkillsTextEdit.Text = mCandidate.KeySkills;
            KeySkillsTextEdit.ToolTip = mCandidate.KeySkills;
            CanRelocateCheckEdit.Checked = mCandidate.CanRelocate;
            CurrentPayTextEdit.Text = mCandidate.CurrentPay;
            DesiredPayTextEdit.Text = mCandidate.DesiredPay;
            DOBMarriedTextEdit.Text = mCandidate.DOBMarried;
            InterviewNotesMemoEdit.Text = mCandidate.InterviewNotes;
            if (mCandidate.Gender)
            {
                GenderComboBoxEdit.SelectedIndex = 1; // male
            }
            else
            {
                GenderComboBoxEdit.SelectedIndex = 0; // female
            }
            MiscNotesMemoEdit.Text = mCandidate.MiscNotes;
            CityTextEdit.Text = mCandidate.City;
            CountryTextEdit.Text = mCandidate.Country;
            PositionsUpTillNowTextEdit.Text = mCandidate.PositionsUpTillNow;
            ProjectDoneMemoEdit.Text = mCandidate.ProjectDone;
            ProjectDoneMemoEdit.ToolTip = mCandidate.ProjectDone;
            IndustryTextEdit.Text = mCandidate.Industry;
            EducationMemoEdit.Text = mCandidate.Education;
            EducationMemoEdit.ToolTip = mCandidate.Education;
            LanguageTextEdit.Text = mCandidate.Language;
            IsInBlacklistCheckEdit.Checked = mCandidate.IsInBlacklist;
            IsQualifiedCheckEdit.Checked = mCandidate.IsQualified;
            // load image
            try
            {
                peAvatar.Image = Bitmap.FromFile(mCandidate.ImageLink);
            }
            catch
            {
                peAvatar.Image = null;
            };
        }

        public void setCurrentCandidate(long canId, string toolTip)
        {
            if (!string.IsNullOrEmpty(toolTip))
            {
                peAvatar.ToolTip = toolTip;
                peAvatar.Cursor = Cursors.Hand;
            }
            else peAvatar.Cursor = Cursors.Default;
            if (canId == -1)
            {
                //clear all ui
                FirstNameTextEdit.Text = string.Empty;
                MiddleNameTextEdit.Text = string.Empty;
                LastNameTextEdit.Text = string.Empty;
                EmailTextEdit.Text = string.Empty;
                SecondaryEmailTextEdit.Text = string.Empty;
                SkypeIMTextEdit.Text = string.Empty;
                CellPhoneTextEdit.Text = string.Empty;
                WorkPhoneTextEdit.Text = string.Empty;
                BestTimeToCallTextEdit.Text = string.Empty;
                AddressTextEdit.Text = string.Empty;
                WebSiteTextEdit.Text = string.Empty;
                SourceTextEdit.Text = string.Empty;
                CurrentPositionTextEdit.Text = string.Empty;
                DateAvailableDateEdit.Text = string.Empty;
                CurrentEmployerTextEdit.Text = string.Empty;
                KeySkillsTextEdit.Text = string.Empty;
                KeySkillsTextEdit.ToolTip = string.Empty;
                CanRelocateCheckEdit.Checked = false;
                CurrentPayTextEdit.Text = string.Empty;
                DesiredPayTextEdit.Text = string.Empty;
                DOBMarriedTextEdit.Text = string.Empty;
                InterviewNotesMemoEdit.Text = string.Empty;
                GenderComboBoxEdit.SelectedIndex = 0;
                MiscNotesMemoEdit.Text = string.Empty;
                CityTextEdit.Text = string.Empty;
                CountryTextEdit.Text = string.Empty;
                PositionsUpTillNowTextEdit.Text = string.Empty;
                ProjectDoneMemoEdit.Text = string.Empty;
                ProjectDoneMemoEdit.ToolTip = string.Empty;
                IndustryTextEdit.Text = string.Empty;
                EducationMemoEdit.Text = string.Empty;
                EducationMemoEdit.ToolTip = string.Empty;
                LanguageTextEdit.Text = string.Empty;
                IsInBlacklistCheckEdit.Checked = false;
                peAvatar.Image = null;

                mCandidate = new Candidate();
                isNew = true;
                return;
            }
            // fill data to ui
            mCandidate = CandidateManager.getCandidate(canId);
            isNew = false;
            FillUpToUi();
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sbOk_Click(object sender, EventArgs e)
        {
            // todo validate du lieu
            //get data from ui to mcandidate
            try
            {
                getDataFromUI(ref mCandidate);
                if (fileNameAvatar.Length > 0)
                {
                    if (mCandidate.ImageLink.Length == 0)
                    {
                        // save image to hardisk: folder = createedtime + candidateName + randomstring
                        string folderName = mCandidate.FirstName + mCandidate.LastName + mCandidate.CreatedDate.ToString(@"yyyy-MM-dd") + Utils.getRandomAlphaNumeric(10);
                        string dir = string.Format(@"{0}candidates\avatar\{1}\{2}", Properties.Settings.Default.StorageLocation, folderName, fileNameAvatar);
                        mCandidate.ImageLink = dir;
                    }
                    else
                    {
                        // update link of avatar
                        var link = mCandidate.ImageLink.Split('\\');
                        mCandidate.ImageLink = mCandidate.ImageLink.Replace(link.Last(), fileNameAvatar);
                    }

                    // copy image to server
                    //peAvatar.Image.Save(mCandidate.ImageLink);
                    if (link.Length > 0)
                    {
                        AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
                        Directory.CreateDirectory(mCandidate.ImageLink.Replace(mCandidate.ImageLink.Split('\\').Last(), ""));
                        File.Copy(link, mCandidate.ImageLink, true);
                    }
                }

                // save candidate to database: if it is new candidate -> use inserting function, else use updating function
                if (isNew)
                {
                    mCandidate.UserId = Properties.Settings.Default.userId;
                    mCandidate.CreatedId = Properties.Settings.Default.userId;
                    mCandidate.CreatedDate = DateTime.Now;
                    mCandidate.ResumeLink = "";

                    CandidateManager.InsertCandidate(mCandidate);
                }
                else
                {

                    CandidateManager.updateCandidate(mCandidate);
                }

                //emit main form reload gridview control
                emitUpdateData?.Invoke();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();


        }

        private void getDataFromUI(ref Candidate can)
        {
            can.FirstName = FirstNameTextEdit.Text;
            can.MiddleName = MiddleNameTextEdit.Text;
            can.LastName = LastNameTextEdit.Text;
            can.Email = EmailTextEdit.Text;
            can.SecondaryEmail = SecondaryEmailTextEdit.Text;
            can.SkypeIM = SkypeIMTextEdit.Text;
            can.CellPhone = CellPhoneTextEdit.Text;
            can.WorkPhone = WorkPhoneTextEdit.Text;
            can.BestTimeToCall = BestTimeToCallTextEdit.Text;
            can.Address = AddressTextEdit.Text;
            can.WebSite = WebSiteTextEdit.Text;
            can.Source = SourceTextEdit.Text;
            can.CurrentPosition = CurrentPositionTextEdit.Text;
            if (DateAvailableDateEdit.Text.Length > 0)
            {
                can.DateAvailable = DateTime.Parse(DateAvailableDateEdit.DateTime.ToString("yyyy/MM/dd "));
            }
            can.CurrentEmployer = CurrentEmployerTextEdit.Text;
            can.KeySkills = KeySkillsTextEdit.Text;
            can.CanRelocate = CanRelocateCheckEdit.Checked;
            can.CurrentPay = CurrentPayTextEdit.Text;
            can.DesiredPay = DesiredPayTextEdit.Text;
            can.DOBMarried = DOBMarriedTextEdit.Text;
            can.InterviewNotes = InterviewNotesMemoEdit.Text;
            can.Gender = Convert.ToBoolean(GenderComboBoxEdit.SelectedIndex);
            can.MiscNotes = MiscNotesMemoEdit.Text;
            can.City = CityTextEdit.Text;
            can.Country = CountryTextEdit.Text;
            can.PositionsUpTillNow = PositionsUpTillNowTextEdit.Text;
            can.ProjectDone = ProjectDoneMemoEdit.Text;
            can.Industry = IndustryTextEdit.Text;
            can.Education = EducationMemoEdit.Text;
            can.Language = LanguageTextEdit.Text;
            can.IsInBlacklist = IsInBlacklistCheckEdit.Checked;
            can.IsQualified = IsQualifiedCheckEdit.Checked;
            can.Modified = DateTime.Now;

            // todo: copy picture to hard disk
            // store link of this picture to db
            can.ImageLink = "";
        }

        private void peAvatar_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void peAvatar_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "Jpeps|*.jpg|Png|*.png|Bitmaps|*.bmp";
            try
            {
                if (openFileDlg.ShowDialog() == DialogResult.OK)
                {
                    peAvatar.Image = Bitmap.FromFile(openFileDlg.FileName);
                    fileNameAvatar = openFileDlg.FileName.Split('\\').Last();
                    link = openFileDlg.FileName;
                }
            }
            catch
            {
                peAvatar.Image = null;
            }
        }

        private void dlgCandidateEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                default:
                    break;
            }
        }

        private void IsInBlacklistCheckEdit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void IsQualifiedCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (IsInBlacklistCheckEdit.Checked)
                return;
            if (IsQualifiedCheckEdit.Checked)
            {
                lcgContactInfo.CaptionImage = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_32x32.png");
            }
            else
            {
                lcgContactInfo.CaptionImage = DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/info_32x32.png");
            }

        }

        private void IsInBlacklistCheckEdit_CheckedChanged_1(object sender, EventArgs e)
        {
            if (IsInBlacklistCheckEdit.Checked)
            {
                lcgContactInfo.CaptionImage = DevExpress.Images.ImageResourceCache.Default.GetImage("images/status/warning_32x32.png");
            }
            else
            {
                if (IsQualifiedCheckEdit.Checked)
                {
                    lcgContactInfo.CaptionImage = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_32x32.png");
                }
                else
                {
                    lcgContactInfo.CaptionImage = DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/info_32x32.png");
                }
            }
        }

        private void sbImportLinkedInClipboard_Click(object sender, EventArgs e)
        {
            // open textbox and paste clipboard to this
            //dlgImportFromClipboard dlg = new dlgImportFromClipboard(dlgImportFromClipboard.ImportType.CANDIDATE);
            //dlg.FillUpObjectDataEvent += fillUpObjectData;
            //dlg.ShowDialog();
            try
            {
                mCandidate = new Candidate();
                getCandidateFromClipboard(ref mCandidate);
                FillUpToUi();
                SourceTextEdit.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool getParseState(string line, ref ParseCandidateInfoStep state)
        {
            line = line.Trim();
            if (string.Equals(line, "Experience"))
            {
                state = ParseCandidateInfoStep.EXPERIENCE;
            }
            else if (string.Equals(line, "Education") || string.Equals(line, "Certifications"))
            {
                state = ParseCandidateInfoStep.EDUCATION;
            }
            else if (line.Contains("Contact and Personal Info"))
            {
                state = ParseCandidateInfoStep.CONTACT;
            }
            else if (string.Equals(line, "Featured Skills & Endorsements"))
            {
                state = ParseCandidateInfoStep.SKILL;
            }
            else if (string.Equals(line, "Accomplishments"))
            {
                state = ParseCandidateInfoStep.ACCOMPLISHMENT;
            }
            else
            {
                return false;
            }

            return true;
        }
        private void getCandidateFromClipboard(ref Candidate can)
        {
            // parse can from memoINfo.Text
            ParseCandidateInfoStep state = ParseCandidateInfoStep.INIT;
            string[] lines = Clipboard.GetText().Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (lines.Count() < 9) return;
            for (int i = 8; i < lines.Length; ++i)
            {
                string line = lines[i].TrimStart();
                if (state == ParseCandidateInfoStep.INIT)
                {
                    // get name:
                    if (string.Equals(line.Trim(), "Messaging"))
                    {
                        line = line.Trim();
                        // get name
                        do
                        {
                            if (i == lines.Count() - 1)
                            {
                                break;
                            }
                            ++i;
                            line = lines[i].Trim();
                            if (!line.Contains("account") && !line.Contains("upgrade") && !line.Contains("Background Image"))
                                break;
                        } while (true);

                        string[] names = line.Split(' ');
                        can.FirstName = names.Last();
                        can.LastName = names.First();
                        can.MiddleName = line.Replace(can.FirstName, "").Replace(can.LastName, "").Trim();
                        // get position
                        i += 2;
                        line = lines[i].Trim();
                        can.CurrentPosition = line;
                        //string[] test = line.Split('\n');
                        // get current company and education
                        ++i;
                        line = lines[i].Trim();
                        can.CurrentEmployer = line;
                        // get location
                        ++i;
                        line = lines[i].Trim();
                        can.Country = line.Split(' ').First(); ;

                    }
                    else
                    {
                        getParseState(line, ref state);
                    }
                    continue;
                }
                else if (state == ParseCandidateInfoStep.EXPERIENCE)
                {
                    if (!getParseState(line, ref state))
                    {
                        if (can.ProjectDone.Length + line.Length < 2000 - 2)
                        {
                            can.ProjectDone += line.TrimStart() + "\r\n";
                        }
                    }
                    continue;
                }
                else if (state == ParseCandidateInfoStep.EDUCATION)
                {
                    if (!getParseState(line, ref state))
                    {
                        if (can.Education.Length + line.Length < 2000 - 2 && !can.Education.Contains(line.Trim()))
                        {
                            can.Education += line.TrimStart() + "\r\n";
                            if (can.CurrentEmployer.Contains(line.Trim()))
                            {
                                can.CurrentEmployer = can.CurrentEmployer.Replace(line.Trim(), "").Trim();
                            }
                        }
                    }
                    continue;
                }
                else if (state == ParseCandidateInfoStep.SKILL)
                {
                    line = line.Trim();
                    if (!getParseState(line, ref state))
                    {
                        if (can.KeySkills.Length + line.Length < 1000 - 2 && !can.KeySkills.Contains(line))
                        {
                            if (line.Contains("See"))
                            {
                                line = line.Split(new[] { "See" }, StringSplitOptions.None).First();
                                if (can.KeySkills.Length > 0)
                                {
                                    can.KeySkills += "; ";
                                }
                                can.KeySkills += line;
                            }
                        }
                    }
                    continue;
                }
                else if (state == ParseCandidateInfoStep.ACCOMPLISHMENT)
                {
                    i ++;
                    line = lines[i];
                    if(string.Equals(line, "Certifications"))
                    {
                        i++;
                        line = lines[i];

                        if (can.Education.Length + line.Length < 2000 - 2 && !can.Education.Contains(line.Trim()))
                        {
                            can.Education += "Certifications: " +line.TrimStart() + "\r\n";
                            if (can.CurrentEmployer.Contains(line.Trim()))
                            {
                                can.CurrentEmployer = can.CurrentEmployer.Replace(line.Trim(), "").Trim();
                            }
                        }
                        i += 2;
                        line = lines[i];

                    }
                    if (string.Equals(line, "Language"))
                    {
                        i++;
                        line = lines[i];
                        can.Language = line.Trim();
                    }
                    state = ParseCandidateInfoStep.CONTACT;
                    continue;
                }
                else if (state == ParseCandidateInfoStep.CONTACT)
                {
                    line = line.Trim();
                    if (line.Contains("Profile"))
                    {
                        ++i;
                        line = lines[i].Trim();
                        can.WebSite = line;
                    }
                    else if (string.Equals(line, "Phone"))
                    {
                        ++i;
                        line = lines[i].Trim();
                        can.WorkPhone = line.Split(new[] { " (" }, StringSplitOptions.RemoveEmptyEntries).First();
                    }
                    else if (string.Equals(line, "Email"))
                    {
                        ++i;
                        line = lines[i].Trim();
                        can.Email = line;
                    }
                    else if (string.Equals(line, "IM"))
                    {
                        ++i;
                        line = lines[i].Trim();
                        can.SkypeIM = line;
                    }
                    continue;
                }
            }
        }

        private void fillUpObjectData(object obj)
        {
            if (obj is Candidate)
            {
                mCandidate = obj as Candidate;
                FillUpToUi();
            }
        }
    }
}