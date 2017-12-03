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
using SWIBLL.Model;

namespace DXSWI.Controls
{
    public partial class ucCandidateManager : DevExpress.XtraEditors.XtraUserControl
    {
        Candidate mCandidate;
        public ucCandidateManager()
        {
            InitializeComponent();
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
            this.CurrentEmployerTextEdit.Text = can.CurrentEmployer;
            this.KeySkillsTextEdit.Text = can.KeySkills;
            this.CanRelocateTextEdit.Text = can.CanRelocate.ToString();
            this.CurrentPayTextEdit.Text = can.CurrentPay;
            this.DesiredPayTextEdit.Text = can.DesiredPay;
            this.DOBMarriedTextEdit.Text = can.DOBMarried;
            this.InterviewNotesMemoEdit.Text = can.InterviewNotes;
            this.GenderTextEdit.Text = can.Gender.ToString();
            //this.UserIdTextEdit.Text = can.;
            this.MiscNotesMemoExEdit.Text = can.MiscNotes;
            //this.CreatedDateDateEdit.Text = can.create;
            this.DateAvailableDateEdit.Text = can.DateAvailable.ToString();
            // add data to view

            loadAvatar();
            loadAttachment();
            loadJobPipeLine();
            loadActivities();



        }

        private void loadAvatar()
        {
            //this.dataLayoutControl1.Controls.Add(this.peAvatar);
        }
        private void loadAttachment()
        {
            // load attach ment from disk
        }
        private void loadJobPipeLine()
        {
            // load job pipe line from running task by candidate id
        }
        private void loadActivities()
        {
            // load activities from activities by 
        }

    }
}
