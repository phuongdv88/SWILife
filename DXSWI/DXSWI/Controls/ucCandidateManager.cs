﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SWIBLL.Models;
using SWIBLL;

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
            try {
                this.locAvatar.Text = string.Format("{0} {1} {2}", can.FirstName, can.MiddleName, can.LastName);
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
                setGender(can.Gender);
                if (can.CanRelocate)
                {
                    this.CanRelocateTextEdit.Text = "Yes";
                } else
                {
                    this.CanRelocateTextEdit.Text = "No";
                }
                this.CurrentPayTextEdit.Text = can.CurrentPay;
                this.DesiredPayTextEdit.Text = can.DesiredPay;
                this.DOBMarriedTextEdit.Text = can.DOBMarried;
                this.InterviewNotesMemoEdit.Text = can.InterviewNotes;
                this.UserOwnerTexEdit.Text = UserManager.getUserName(can.UserId); // owner
                this.MiscNotesMemoExEdit.Text = can.MiscNotes;
                this.CreatedDateDateEdit.Text = can.CreatedDate.ToShortDateString();
                this.DateAvailableDateEdit.Text = can.DateAvailable.ToShortDateString();
                // add data to view

                loadAvatar();
                loadAttachment();
                loadJobPipeLine();
                loadActivities();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void loadAvatar()
        {
            //this.dataLayoutControl1.Controls.Add(this.peAvatar);
            try {
                if (mCandidate.ImageLink?.Length > 0)
                {
                    this.peAvatar.Image = Bitmap.FromFile(mCandidate.ImageLink);
                }
            }
            catch
            {
                // donot do anything
            }
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

        private void setGender(bool isMan)
        {
            if (isMan)
            {
                this.locAvatar.Image = DXSWI.Properties.Resources.user_male_3;
            } else
            {
                this.locAvatar.Image = DXSWI.Properties.Resources.user_female_5;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
