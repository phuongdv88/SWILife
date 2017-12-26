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
        public dlgCandidateEdit(int canId, string toolTip)
        {
            InitializeComponent();
            try {
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
            this.FirstNameTextEdit.ReadOnly = true;
            this.MiddleNameTextEdit.ReadOnly = true;
            this.LastNameTextEdit.ReadOnly = true;
            this.EmailTextEdit.ReadOnly = true;
            this.SecondaryEmailTextEdit.ReadOnly = true;
            this.SkypeIMTextEdit.ReadOnly = true;
            this.CellPhoneTextEdit.ReadOnly = true;
            this.WorkPhoneTextEdit.ReadOnly = true;
            this.BestTimeToCallTextEdit.ReadOnly = true;
            this.AddressTextEdit.ReadOnly = true;
            this.WebSiteTextEdit.ReadOnly = true;
            this.SourceTextEdit.ReadOnly = true;
            this.CurrentPositionTextEdit.ReadOnly = true;
            this.DateAvailableDateEdit.ReadOnly = true;
            this.CurrentEmployerTextEdit.ReadOnly = true;
            this.KeySkillsTextEdit.ReadOnly = true;
            this.CanRelocateCheckEdit.ReadOnly = true;
            this.CurrentPayTextEdit.ReadOnly = true;
            this.DesiredPayTextEdit.ReadOnly = true;
            this.DOBMarriedTextEdit.ReadOnly = true;
            this.InterviewNotesMemoEdit.ReadOnly = true;
            this.GenderComboBoxEdit.ReadOnly = true;
            this.MiscNotesMemoEdit.ReadOnly = true;
            this.CityTextEdit.ReadOnly = true;
            this.CountryTextEdit.ReadOnly = true;
            this.PositionsUpTillNowTextEdit.ReadOnly = true;
            this.ProjectDoneMemoEdit.ReadOnly = true;
            this.IndustryTextEdit.ReadOnly = true;
            this.EducationMemoEdit.ReadOnly = true;
            this.LanguageTextEdit.ReadOnly = true;
            this.IsInBlacklistCheckEdit.ReadOnly = true;
            this.peAvatar.ReadOnly = true;
        }

        private void dlgCandidateEdit_Load(object sender, EventArgs e)
        {

        }

        public void setCurrentCandidate(int canId, string toolTip)
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
                this.FirstNameTextEdit.Text = string.Empty;
                this.MiddleNameTextEdit.Text = string.Empty;
                this.LastNameTextEdit.Text = string.Empty;
                this.EmailTextEdit.Text = string.Empty;
                this.SecondaryEmailTextEdit.Text = string.Empty;
                this.SkypeIMTextEdit.Text = string.Empty;
                this.CellPhoneTextEdit.Text = string.Empty;
                this.WorkPhoneTextEdit.Text = string.Empty;
                this.BestTimeToCallTextEdit.Text = string.Empty;
                this.AddressTextEdit.Text = string.Empty;
                this.WebSiteTextEdit.Text = string.Empty;
                this.SourceTextEdit.Text = string.Empty;
                this.CurrentPositionTextEdit.Text = string.Empty;
                this.DateAvailableDateEdit.Text = string.Empty;
                this.CurrentEmployerTextEdit.Text = string.Empty;
                this.KeySkillsTextEdit.Text = string.Empty;
                this.CanRelocateCheckEdit.Checked = false;
                this.CurrentPayTextEdit.Text = string.Empty;
                this.DesiredPayTextEdit.Text = string.Empty;
                this.DOBMarriedTextEdit.Text = string.Empty;
                this.InterviewNotesMemoEdit.Text = string.Empty;
                this.GenderComboBoxEdit.SelectedIndex = 0;
                this.MiscNotesMemoEdit.Text = string.Empty;
                this.CityTextEdit.Text = string.Empty;
                this.CountryTextEdit.Text = string.Empty;
                this.PositionsUpTillNowTextEdit.Text = string.Empty;
                this.ProjectDoneMemoEdit.Text = string.Empty;
                this.IndustryTextEdit.Text = string.Empty;
                this.EducationMemoEdit.Text = string.Empty;
                this.LanguageTextEdit.Text = string.Empty;
                this.IsInBlacklistCheckEdit.Checked = false;
                this.peAvatar.Image = null;
                return;
            }
            // fill data to ui
            mCandidate = CandidateManager.getCandidate(canId);
            if (mCandidate == null)
                return;
            this.FirstNameTextEdit.Text = mCandidate.FirstName;
            this.MiddleNameTextEdit.Text = mCandidate.MiddleName;
            this.LastNameTextEdit.Text = mCandidate.LastName;
            this.EmailTextEdit.Text = mCandidate.Email;
            this.SecondaryEmailTextEdit.Text = mCandidate.SecondaryEmail;
            this.SkypeIMTextEdit.Text = mCandidate.SkypeIM;
            this.CellPhoneTextEdit.Text = mCandidate.CellPhone;
            this.WorkPhoneTextEdit.Text = mCandidate.WorkPhone;
            this.BestTimeToCallTextEdit.Text = mCandidate.BestTimeToCall;
            this.AddressTextEdit.Text = mCandidate.Address;
            this.WebSiteTextEdit.Text = mCandidate.WebSite;
            this.SourceTextEdit.Text = mCandidate.Source;
            this.CurrentPositionTextEdit.Text = mCandidate.CurrentPosition;
            this.DateAvailableDateEdit.Text = mCandidate.DateAvailable.ToShortDateString();
            this.CurrentEmployerTextEdit.Text = mCandidate.CurrentEmployer;
            this.KeySkillsTextEdit.Text = mCandidate.KeySkills;
            this.CanRelocateCheckEdit.Checked = mCandidate.CanRelocate;
            this.CurrentPayTextEdit.Text = mCandidate.CurrentPay;
            this.DesiredPayTextEdit.Text = mCandidate.DesiredPay;
            this.DOBMarriedTextEdit.Text = mCandidate.DOBMarried;
            this.InterviewNotesMemoEdit.Text = mCandidate.InterviewNotes;
            if (mCandidate.Gender)
            {
                this.GenderComboBoxEdit.SelectedIndex = 1; // male
            }
            else
            {
                this.GenderComboBoxEdit.SelectedIndex = 0; // female
            }
            this.MiscNotesMemoEdit.Text = mCandidate.MiscNotes;
            this.CityTextEdit.Text = mCandidate.City;
            this.CountryTextEdit.Text = mCandidate.Country;
            this.PositionsUpTillNowTextEdit.Text = mCandidate.PositionsUpTillNow;
            this.ProjectDoneMemoEdit.Text = mCandidate.ProjectDone;
            this.IndustryTextEdit.Text = mCandidate.Industry;
            this.EducationMemoEdit.Text = mCandidate.Education;
            this.LanguageTextEdit.Text = mCandidate.Language;
            this.IsInBlacklistCheckEdit.Checked = mCandidate.IsInBlacklist;
            // load image
            try {
                peAvatar.Image = Bitmap.FromFile(mCandidate.ImageLink);
            } catch { };
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sbOk_Click(object sender, EventArgs e)
        {
            bool isNewCandidate = false;
            if (mCandidate == null)
            {
                mCandidate = new Candidate();
                isNewCandidate = true;
            }

            // todo validate du lieu
            //get data from ui to mcandidate
            try
            {
                getDataFromUI(ref mCandidate);
                if (mCandidate.ImageLink.Length == 0)
                {
                    // save image to hardisk: folder = createedtime + candidateName + randomstring
                    string folderName = mCandidate.CandidateId.ToString() + mCandidate.CreatedDate.ToString(@"_yyyy-MM-dd") + Utils.getRandomAlphaNumeric(10);
                    string dir = string.Format(@"{0}candidates\avatar\{1}\{2}", Properties.Settings.Default.StorageLocation, folderName, fileNameAvatar);
                    mCandidate.ImageLink = dir;
                }
                else
                {
                    // update link of avatar
                    if (fileNameAvatar.Length > 0)
                    {
                        var link = mCandidate.ImageLink.Split('\\');
                        mCandidate.ImageLink = mCandidate.ImageLink.Replace(link.Last(), fileNameAvatar);
                    }
                }

                // copy image to server
                if (fileNameAvatar.Length > 0)
                {
                    //peAvatar.Image.Save(mCandidate.ImageLink);
                    if(link.Length > 0)
                    {
                        AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
                        //WindowsIdentity idnt = new WindowsIdentity("Phuongdv", "1");
                        //WindowsImpersonationContext context = idnt.Impersonate();
                        Directory.CreateDirectory(mCandidate.ImageLink.Replace(mCandidate.ImageLink.Split('\\').Last(), ""));
                        File.Copy(link, mCandidate.ImageLink, true);
                        //context.Undo();
                    }
                }

                // save candidate to database: if it is new candidate -> use inserting function, else use updating function
                if (isNewCandidate)
                {
                    mCandidate.UserId = Properties.Settings.Default.userId;
                    mCandidate.CreatedId = Properties.Settings.Default.userId;
                    mCandidate.CreatedDate = DateTime.Now;
                    mCandidate.ResumeLink = "";
                    
                    if (CandidateManager.addCandidate(mCandidate))
                    {
                        XtraMessageBox.Show("Add new candidate successfully!", "Notice");

                    }
                }
                else
                {
                    
                    if (CandidateManager.updateCandidate(mCandidate))
                    {
                        //XtraMessageBox.Show("Update candidate successfully!", "Notice");

                    }
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
            can.FirstName = this.FirstNameTextEdit.Text;
            can.MiddleName = this.MiddleNameTextEdit.Text;
            can.LastName = this.LastNameTextEdit.Text;
            can.Email = this.EmailTextEdit.Text;
            can.SecondaryEmail = this.SecondaryEmailTextEdit.Text;
            can.SkypeIM = this.SkypeIMTextEdit.Text;
            can.CellPhone = this.CellPhoneTextEdit.Text;
            can.WorkPhone = this.WorkPhoneTextEdit.Text;
            can.BestTimeToCall = this.BestTimeToCallTextEdit.Text;
            can.Address = this.AddressTextEdit.Text;
            can.WebSite = this.WebSiteTextEdit.Text;
            can.Source = this.SourceTextEdit.Text;
            can.CurrentPosition = this.CurrentPositionTextEdit.Text;
            if (this.DateAvailableDateEdit.Text.Length > 0)
            {
                can.DateAvailable = DateTime.Parse(this.DateAvailableDateEdit.Text);
            }
            can.CurrentEmployer = this.CurrentEmployerTextEdit.Text;
            can.KeySkills = this.KeySkillsTextEdit.Text;
            can.CanRelocate = this.CanRelocateCheckEdit.Checked;
            can.CurrentPay = this.CurrentPayTextEdit.Text;
            can.DesiredPay = this.DesiredPayTextEdit.Text;
            can.DOBMarried = this.DOBMarriedTextEdit.Text;
            can.InterviewNotes = this.InterviewNotesMemoEdit.Text;
            can.Gender = Convert.ToBoolean(this.GenderComboBoxEdit.SelectedIndex);
            can.MiscNotes = this.MiscNotesMemoEdit.Text;
            can.City = this.CityTextEdit.Text;
            can.Country = this.CountryTextEdit.Text;
            can.PositionsUpTillNow = this.PositionsUpTillNowTextEdit.Text;
            can.ProjectDone = this.ProjectDoneMemoEdit.Text;
            can.Industry = this.IndustryTextEdit.Text;
            can.Education = this.EducationMemoEdit.Text;
            can.Language = this.LanguageTextEdit.Text;
            can.IsInBlacklist = this.IsInBlacklistCheckEdit.Checked;
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
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                peAvatar.Image = Bitmap.FromFile(openFileDlg.FileName);
                fileNameAvatar = openFileDlg.FileName.Split('\\').Last();
                link = openFileDlg.FileName;
            }
        }

        
    }
}