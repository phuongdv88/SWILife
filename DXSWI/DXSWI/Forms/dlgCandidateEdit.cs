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

namespace DXSWI.Forms
{
    public partial class dlgCandidateEdit : DevExpress.XtraEditors.XtraForm
    {
        public delegate void onUpdateData();
        public event onUpdateData emitUpdateData;
        Candidate mCandidate;
        public dlgCandidateEdit(Candidate can, string toolTip)
        {
            InitializeComponent();
            setCurrentCandidate(can, toolTip);
        }

        private void dlgCandidateEdit_Load(object sender, EventArgs e)
        {

        }

        public void setCurrentCandidate(Candidate can, string toolTip)
        {
            if (!string.IsNullOrEmpty(toolTip))
            {
                peAvatar.ToolTip = toolTip;
                peAvatar.Cursor = Cursors.Hand;
            }
            else peAvatar.Cursor = Cursors.Default;
            mCandidate = can;
            if (can == null)
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

            this.FirstNameTextEdit.Text = can.FirstName;
            this.MiddleNameTextEdit.Text = can.MiddleName;
            this.LastNameTextEdit.Text = can.LastName;
            this.EmailTextEdit.Text = can.Email;
            this.SecondaryEmailTextEdit.Text = can.SecondaryEmail;
            this.SkypeIMTextEdit.Text = can.SkypeIM;
            this.CellPhoneTextEdit.Text = can.CellPhone;
            this.WorkPhoneTextEdit.Text = can.WorkPhone;
            this.BestTimeToCallTextEdit.Text = can.BestTimeToCall;
            this.AddressTextEdit.Text = can.Address;
            this.WebSiteTextEdit.Text = can.WebSite;
            this.SourceTextEdit.Text = can.Source;
            this.CurrentPositionTextEdit.Text = can.CurrentPosition;
            this.DateAvailableDateEdit.Text = can.DateAvailable.ToShortDateString();
            this.CurrentEmployerTextEdit.Text = can.CurrentEmployer;
            this.KeySkillsTextEdit.Text = can.KeySkills;
            this.CanRelocateCheckEdit.Checked = can.CanRelocate;
            this.CurrentPayTextEdit.Text = can.CurrentPay;
            this.DesiredPayTextEdit.Text = can.DesiredPay;
            this.DOBMarriedTextEdit.Text = can.DOBMarried;
            this.InterviewNotesMemoEdit.Text = can.InterviewNotes;
            if (can.Gender)
            {
                this.GenderComboBoxEdit.SelectedIndex = 1; // male
            }
            else
            {
                this.GenderComboBoxEdit.SelectedIndex = 0; // female
            }
            this.MiscNotesMemoEdit.Text = can.MiscNotes;
            this.CityTextEdit.Text = can.City;
            this.CountryTextEdit.Text = can.Country;
            this.PositionsUpTillNowTextEdit.Text = can.PositionsUpTillNow;
            this.ProjectDoneMemoEdit.Text = can.ProjectDone;
            this.IndustryTextEdit.Text = can.Industry;
            this.EducationMemoEdit.Text = can.Education;
            this.LanguageTextEdit.Text = can.Language;
            this.IsInBlacklistCheckEdit.Checked = can.IsInBlacklist;
            // load image
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

                // todo: update userid, modified, created

                // save candidate to database: if it is new candidate -> use inserting function, else use updating function
                if (isNewCandidate)
                {
                    if (CandidateManager.addCandidate(mCandidate))
                    {
                        XtraMessageBox.Show("Add new candidate successfully!", "Notice");

                    }
                }
                else
                {
                    if (CandidateManager.updateCandidate(mCandidate))
                    {
                        XtraMessageBox.Show("Update candidate successfully!", "Notice");

                    }
                }

                //emit main form reload gridview control
                emitUpdateData();
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
            // todo: copy picture to hard disk
            // store link of this picture to db
            can.ImageLink = "";
            can.ResumeLink = "";
        }

    }
}