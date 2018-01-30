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
        bool isNew = false;
        // store link file 
        string linkAttachment = string.Empty;
        string fileNameAttachment = string.Empty;
        string deleteAttachmentPath = string.Empty;
        public enum ParseCandidateInfoStep
        {
            INIT,
            EXPERIENCE,
            EDUCATION,
            SKILL,
            SKILL_EXTEND,
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

        public void setEditInfoOnlyState()
        {
            gcActivities.ContextMenuStrip = null;
            gcJobOrderPipeline.ContextMenuStrip = null;
        }
        /// <summary>
        /// update joborder and activities
        /// </summary>
        private void updateData()
        {
            try
            {
                loadJobPipeLine();
                loadActivities();
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
            IsQualifiedCheckEdit.ReadOnly = true;
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

        private void FillUpToUi(Candidate can)
        {
            if (can == null)
                return;
            FirstNameTextEdit.Text = can.FirstName;
            MiddleNameTextEdit.Text = can.MiddleName;
            LastNameTextEdit.Text = can.LastName;
            EmailTextEdit.Text = can.Email;
            SecondaryEmailTextEdit.Text = can.SecondaryEmail;
            SkypeIMTextEdit.Text = can.SkypeIM;
            CellPhoneTextEdit.Text = can.CellPhone;
            WorkPhoneTextEdit.Text = can.WorkPhone;
            BestTimeToCallTextEdit.Text = can.BestTimeToCall;
            AddressTextEdit.Text = can.Address;
            WebSiteTextEdit.Text = can.WebSite;
            SourceTextEdit.Text = can.Source;
            CurrentPositionTextEdit.Text = can.CurrentPosition;
            DateAvailableDateEdit.Text = can.DateAvailable.ToShortDateString();
            CurrentEmployerTextEdit.Text = can.CurrentEmployer;
            KeySkillsTextEdit.Text = can.KeySkills;
            CanRelocateCheckEdit.Checked = can.CanRelocate;
            CurrentPayTextEdit.Text = can.CurrentPay;
            DesiredPayTextEdit.Text = can.DesiredPay;
            DOBMarriedTextEdit.Text = can.DOBMarried;
            InterviewNotesMemoEdit.Text = can.InterviewNotes;
            if (can.Gender)
            {
                GenderComboBoxEdit.SelectedIndex = 1; // male
            }
            else
            {
                GenderComboBoxEdit.SelectedIndex = 0; // female
            }
            MiscNotesMemoEdit.Text = can.MiscNotes;
            CityTextEdit.Text = can.City;
            CountryTextEdit.Text = can.Country;
            PositionsUpTillNowTextEdit.Text = can.PositionsUpTillNow;
            ProjectDoneMemoEdit.Text = can.ProjectDone;
            IndustryTextEdit.Text = can.Industry;
            EducationMemoEdit.Text = can.Education;
            LanguageTextEdit.Text = can.Language;
            IsInBlacklistCheckEdit.Checked = can.IsInBlacklist;
            IsQualifiedCheckEdit.Checked = can.IsQualified;
            // load image
            try
            {
                peAvatar.Image = Bitmap.FromFile(can.ImageLink);
            }
            catch
            {
                peAvatar.Image = null;
            };

            // set tooltip
            FirstNameTextEdit.ToolTip = can.FirstName;
            MiddleNameTextEdit.ToolTip = can.MiddleName;
            LastNameTextEdit.ToolTip = can.LastName;
            EmailTextEdit.ToolTip = can.Email;
            SecondaryEmailTextEdit.ToolTip = can.SecondaryEmail;
            SkypeIMTextEdit.ToolTip = can.SkypeIM;
            CellPhoneTextEdit.ToolTip = can.CellPhone;
            WorkPhoneTextEdit.ToolTip = can.WorkPhone;
            BestTimeToCallTextEdit.ToolTip = can.BestTimeToCall;
            AddressTextEdit.ToolTip = can.Address;
            WebSiteTextEdit.ToolTip = can.WebSite;
            SourceTextEdit.ToolTip = can.Source;
            CurrentPositionTextEdit.ToolTip = can.CurrentPosition;
            DateAvailableDateEdit.ToolTip = can.DateAvailable.ToShortDateString();
            CurrentEmployerTextEdit.ToolTip = can.CurrentEmployer;
            KeySkillsTextEdit.ToolTip = can.KeySkills;
            CurrentPayTextEdit.ToolTip = can.CurrentPay;
            DesiredPayTextEdit.ToolTip = can.DesiredPay;
            DOBMarriedTextEdit.ToolTip = can.DOBMarried;
            InterviewNotesMemoEdit.ToolTip = can.InterviewNotes;
            MiscNotesMemoEdit.ToolTip = can.MiscNotes;
            CityTextEdit.ToolTip = can.City;
            CountryTextEdit.ToolTip = can.Country;
            PositionsUpTillNowTextEdit.ToolTip = can.PositionsUpTillNow;
            ProjectDoneMemoEdit.ToolTip = can.ProjectDone;
            IndustryTextEdit.ToolTip = can.Industry;
            EducationMemoEdit.ToolTip = can.Education;
            LanguageTextEdit.ToolTip = can.Language;
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
                mCandidate = new Candidate();
                isNew = true;
                gcActivities.Enabled = false;
                gcJobOrderPipeline.Enabled = false;
                barJobOrder.Dispose();
                standaloneBarDockControl1.Dispose();
                return;
            }
            // fill data to ui
            mCandidate = CandidateManager.getCandidate(canId);
            FillUpToUi(mCandidate);
            loadAttachment(mCandidate.ResumeLink);
            updateData();
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

                //upload avatar
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
                // delete attachment 
                // delete file in server
                if (deleteAttachmentPath.Length > 0)
                {
                    File.Delete(mCandidate.ResumeLink);
                    mCandidate.ResumeLink = string.Empty;
                }

                // upload attachment

                if (fileNameAttachment.Length > 0)
                {
                    // create link file and folder in server
                    if (mCandidate.ResumeLink.Length == 0)
                    {
                        // save resum to hardisk: folder = createedtime + candidateName + randomstring
                        string folderName = mCandidate.FirstName + mCandidate.LastName + mCandidate.CreatedDate.ToString(@"_yyyy-MM-dd") + Utils.getRandomAlphaNumeric(10);
                        string dir = string.Format(@"{0}candidates\resume\{1}\{2}", Properties.Settings.Default.StorageLocation, folderName, fileNameAttachment);
                        mCandidate.ResumeLink = dir;
                    }
                    else
                    {
                        // delete old file
                        try
                        {
                            File.Delete(mCandidate.ResumeLink);
                        }
                        catch { }

                        // update link of avatar
                        if (fileNameAttachment.Length > 0)
                        {
                            var link = mCandidate.ResumeLink.Split('\\');
                            mCandidate.ResumeLink = mCandidate.ResumeLink.Replace(link.Last(), fileNameAttachment);
                        }
                    }

                    // copy image to server

                    if (linkAttachment.Length > 0)
                    {
                        AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
                        Directory.CreateDirectory(mCandidate.ResumeLink.Replace(mCandidate.ResumeLink.Split('\\').Last(), ""));
                        File.Copy(linkAttachment, mCandidate.ResumeLink, true);
                    }
                }

                // save candidate to database: if it is new candidate -> use inserting function, else use updating function
                if (isNew)
                {
                    mCandidate.UserId = UserManager.ActivatedUser.UserId;
                    mCandidate.CreatedId = UserManager.ActivatedUser.UserId;
                    mCandidate.CreatedDate = DateTime.Now;
                    if (!CandidateManager.IsCandidateExist(mCandidate))
                    {
                        CandidateManager.InsertCandidate(mCandidate);
                    }
                    else
                    {
                        if (XtraMessageBox.Show("This candiate has already existed. Would you want to load this candidate data?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // fill data to ui
                            mCandidate = CandidateManager.getCandidateByEmail(EmailTextEdit.Text.Trim());
                            if(mCandidate == null)
                            {
                                mCandidate = CandidateManager.getCandidateByCellPhone(CellPhoneTextEdit.Text.Trim());
                            }
                            if(mCandidate == null)
                            {
                                XtraMessageBox.Show("Load data fail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            isNew = false;
                            gcActivities.Enabled = true;
                            gcJobOrderPipeline.Enabled = true;
                            FillUpToUi(mCandidate);
                            loadAttachment(mCandidate.ResumeLink);
                            updateData();
                            return;
                        }
                    }
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
                case Keys.D:
                    if (e.Control)
                    {
                        try
                        {
                            Candidate can = new Candidate();
                            getCandidateLinkedInFromClipboard(ref can);
                            FillUpToUi(can);
                            SourceTextEdit.SelectedIndex = 1;
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                default:
                    break;
            }
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
            else if (line.Contains(" is also good at…"))
            {
                state = ParseCandidateInfoStep.SKILL_EXTEND;
            }
            else if (string.Equals(line, "Interests"))
            {
                state = ParseCandidateInfoStep.INTEREST;
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
        /// <summary>
        /// parse candidate information from linkedin data in clipboard
        /// It may don't work correctly when linkedin changes data fomat
        /// </summary>
        /// <param name="can"></param>
        private void getCandidateLinkedInFromClipboard(ref Candidate can)
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
                            if (line.Length > 0 && !line.Contains("account") && !line.Contains("upgrade") && !line.Contains("Background Image")
                                && !line.Contains("message") && !line.Contains("setting"))
                                break;
                        } while (true);

                        if (line.Contains("otification"))
                        {
                            continue;
                        }
                        string name = line;
                        string[] names = line.Split(' ');
                        can.FirstName = names.Last();
                        can.LastName = names.First();
                        can.MiddleName = line.Replace(can.FirstName, "").Replace(can.LastName, "").Trim();
                        // get position
                        ++i;
                        do
                        {
                            if (i == lines.Count() - 1)
                            {
                                break;
                            }
                            ++i;
                            line = lines[i].Trim();
                            if (line.Length > 0 && !line.Contains("1st") && !line.Contains(name) && !line.Contains("degree connection"))
                                break;
                        } while (true);
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
                        can.ProjectDone += line.TrimStart() + "\r\n";
                    }
                    continue;
                }
                else if (state == ParseCandidateInfoStep.EDUCATION)
                {
                    if (!getParseState(line, ref state))
                    {
                        if (!can.Education.Contains(line.Trim()))
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
                        if (!can.KeySkills.Contains(line))
                        {
                            //Featured Skills & Endorsements
                            //                            PCI DSS See 3 endorsements for PCI DSS 3
                            if (line.Contains("See"))
                            {
                                line = line.Split(new[] { "See" }, StringSplitOptions.None).First();
                                if (can.KeySkills.Length > 0)
                                {
                                    can.KeySkills += "; ";
                                }
                                can.KeySkills += line;
                            }
                            else
                            {
                                //LTE
                                //See 18 endorsements for LTE
                                //18
                                //Endorse
                                int j = i + 1;
                                if (j < lines.Length)
                                {
                                    string stemp = lines[j].Split(' ').First();
                                    if (lines[j].Contains("endorsement") && (stemp.ToUpper() == "NO" || stemp.ToUpper() == "SEE"))
                                    {
                                        i = j;
                                        if (can.KeySkills.Length > 0)
                                        {
                                            can.KeySkills += "; ";
                                        }
                                        can.KeySkills += line;
                                    }
                                }
                            }
                        }
                    }
                    continue;
                }
                else if (state == ParseCandidateInfoStep.SKILL_EXTEND)
                {
                    if (!getParseState(line, ref state))
                    {
                        if (can.KeySkills.Length > 0)
                        {
                            can.KeySkills += "; ";
                        }
                        can.KeySkills += line.Trim();
                    }
                }
                else if (state == ParseCandidateInfoStep.INTEREST)
                {
                    if (!getParseState(line, ref state))
                    {
                        // do nothing
                    }
                }
                else if (state == ParseCandidateInfoStep.ACCOMPLISHMENT)
                {
                    i++;
                    line = lines[i];
                    if (string.Equals(line, "Certifications") || string.Equals(line, "Certification"))
                    {
                        i++;
                        line = lines[i];

                        if (!can.Education.Contains(line.Trim()))
                        {
                            can.Education += "Certifications: " + line.TrimStart() + "\r\n";
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
                        can.CellPhone = line.Split(new[] { " (" }, StringSplitOptions.RemoveEmptyEntries).First();
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

        private void sbAttachment_Click(object sender, EventArgs e)
        {
            //todo version sau cho phep tai nhieu file len server
            OpenFileDialog openFileDlg = new OpenFileDialog();
            if (openFileDlg.ShowDialog() != DialogResult.OK)
                return;
            // check size of file
            if (new System.IO.FileInfo(openFileDlg.FileName).Length > 10e6) // 10MB
            {
                XtraMessageBox.Show("Attactment is too big (more than 10 MB)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // store link file 
            linkAttachment = openFileDlg.FileName;
            fileNameAttachment = linkAttachment.Split('\\').Last();
            sliAttachments.Text = fileNameAttachment;
            sbAttachmentDownload.Enabled = false;
        }

        private void sbAttachmentDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to delete this file?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    deleteAttachmentPath = mCandidate.ResumeLink;
                    fileNameAttachment = string.Empty;
                    linkAttachment = string.Empty;
                    // update to UI
                    loadAttachment(string.Empty);

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void sbAttachmentDownload_Click(object sender, EventArgs e)
        {
            // download to local or open this file
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Save resume to";
            dlg.RestoreDirectory = true;
            dlg.Filter = "All files (*.*)|*.*";
            dlg.FileName = mCandidate.ResumeLink.Split('\\').Last();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            string save_link = dlg.FileName;
            File.Copy(mCandidate.ResumeLink, save_link);
        }

        private void loadAttachment(string path)
        {
            if (path == null) return;
            // load attachment from disk
            if (path.Length == 0)
            {
                sliAttachments.Text = "No file chosen";
                sbAttachmentDelete.Enabled = false;
                sbAttachmentDownload.Enabled = false;

            }
            else
            {
                sliAttachments.Text = path.Split(new[] { '\\' }, StringSplitOptions.None).Last();
                sbAttachmentDelete.Enabled = true;
                sbAttachmentDownload.Enabled = true;
            }
        }
        private void loadJobPipeLine()
        {
            // load job pipe line from running task by candidate id
            try
            {
                gcJobOrderPipeline.DataSource = RunningTaskManager.getRunningTaskJobs(mCandidate.CandidateId);
            }
            catch
            {
                // donot do anything
                throw;
            }
        }
        private void loadActivities()
        {
            // load activities from activities by 
            try
            {
                gcActivities.DataSource = ActivityManager.getActivitiesOfCandidate(mCandidate.CandidateId);
            }
            catch
            {
                // donot do anything
                throw;
            }
        }

        private void setGender(bool isMan)
        {
            if (isMan)
            {
                this.lciAvatar.Image = DXSWI.Properties.Resources.user_male_3;
            }
            else
            {
                this.lciAvatar.Image = DXSWI.Properties.Resources.user_female_5;
            }
        }

        private void GenderComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ismale = false;
            if (GenderComboBoxEdit.SelectedIndex == 1)
            {
                ismale = true;
            }
            setGender(ismale);
        }
        public void AddJobToPipeLine()
        {
            dlgAddJobOrderToPipeline dlg = new dlgAddJobOrderToPipeline(mCandidate.CandidateId);
            dlg.updateDataEvent += updateData;
            dlg.ShowDialog();
        }

        public void logActivity()
        {
            dlgLogActivity dlg = new dlgLogActivity();
            dlg.updateDataEvent += updateData;
            dlg.init(mCandidate.FirstName + " " + mCandidate.MiddleName + " " + mCandidate.LastName, Activity.TypeOfLogActivity.Candidate, mCandidate.CandidateId, -1, -1);
            dlg.ShowDialog();
        }

        private void logActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logActivity();
        }

        private void gvJobOrderPipeline_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // if match value is changed, then update to DB
            try
            {
                if (e.Column.FieldName == "Match")
                {
                    int row = e.RowHandle;
                    DataRow data_row = gvJobOrderPipeline.GetDataRow(row);
                    int id = int.Parse(data_row["RunningTaskId"].ToString());
                    RunningTaskManager.updateMatchValue(Convert.ToInt32(e.Value.ToString()), id);
                    //updateData();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bbiAddJobToPipeline_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddJobToPipeLine();
        }

        private void bbiAddActivity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dlgLogActivity dlg = new dlgLogActivity();
            dlg.updateDataEvent += updateData;
            string regarding = string.Empty;
            int jobOrderId = -1;

            if (gvJobOrderPipeline.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Have not yet selected anything", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int row = gvJobOrderPipeline.GetSelectedRows().First();
            DataRow data_row = gvJobOrderPipeline.GetDataRow(row);
            regarding = data_row["Title"].ToString();
            jobOrderId = int.Parse(data_row["JobOrderId"].ToString());

            dlg.init(mCandidate.FirstName + " " + mCandidate.MiddleName + " " + mCandidate.LastName, Activity.TypeOfLogActivity.Pipeline, mCandidate.CandidateId, jobOrderId, -1);
            if (regarding.Length > 0)
            {
                dlg.setRegarding(regarding);
            }
            dlg.ShowDialog();
        }

        private void bbiRemoveJobOrderFromPipeline_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvJobOrderPipeline.SelectedRowsCount > 0)
            {
                if (XtraMessageBox.Show("Are you sure to delete this job order from pipeline?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        // delete this running task data

                        int row = gvJobOrderPipeline.GetSelectedRows().First();
                        DataRow data_row = gvJobOrderPipeline.GetDataRow(row);
                        int id = int.Parse(data_row["RunningTaskId"].ToString());
                        RunningTaskManager.deleteRunningTask(id);
                        updateData();

                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}