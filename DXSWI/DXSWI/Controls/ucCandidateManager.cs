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
using SWIBLL.Models;
using SWIBLL;
using DXSWI.Forms;
using System.Security.Principal;
using System.IO;
using DevExpress.XtraLayout;

namespace DXSWI.Controls
{
    public partial class ucCandidateManager : DevExpress.XtraEditors.XtraUserControl
    {
        Candidate mCandidate;
        string fileNameAttachment;
        string linkAttachment;
        public ucCandidateManager()
        {
            InitializeComponent();
        }

        //public void setCurrentCandidate(Candidate can, string toolTip)
        //{
        //    if (!string.IsNullOrEmpty(toolTip))
        //    {
        //        peAvatar.ToolTip = toolTip;
        //        peAvatar.Cursor = Cursors.Hand;
        //    }
        //    else peAvatar.Cursor = Cursors.Default;
        //    mCandidate = can;
        //    updateData();
        //}

        public void setCurrentCandidate(int CanId, string toolTip)
        {
            if (!string.IsNullOrEmpty(toolTip))
            {
                peAvatar.ToolTip = toolTip;
                peAvatar.Cursor = Cursors.Hand;
            }
            else peAvatar.Cursor = Cursors.Default;
            mCandidate = CandidateManager.getCandidate(CanId);
            updateData();
        }

        private void loadAvatar()
        {
            //this.dataLayoutControl1.Controls.Add(this.peAvatar);
            try
            {
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
            // load attachment from disk
            if (mCandidate.ResumeLink.Length == 0)
            {
                sliAttachments.Text = "No file chosen";
                //layoutControlItem8.BeginInit();
                //sbAttachmentDownload.Visible = false;
                //layoutControlItem8.Control = null;
                //layoutControlItem8.EndInit();
                //layoutControlItem7.BeginInit();
                //sbAttachmentDelete.Visible = false;
                //layoutControlItem7.Control = null;
                //layoutControlItem7.EndInit();
                //layoutControl2.Refresh();

                //HideShowItemContent(layoutControl2, layoutControlItem8, true, sbAttachmentDelete);
                //HideShowItemContent(layoutControl2, layoutControlItem8, true, sbAttachmentDownload);
                sbAttachmentDelete.Enabled = false;
                sbAttachmentDownload.Enabled = false;

            }
            else
            {
                sliAttachments.Text = mCandidate.ResumeLink.Split('\\').Last();
                //sliAttachments.Text = string.Format("<a href =\"{0}\">here</a>", mCandidate.ResumeLink.Split('\\').Last()) + Environment.NewLine;
                //layoutControlItem8.BeginInit();
                //sbAttachmentDownload.Visible = true;
                //layoutControlItem8.EndInit();
                //layoutControlItem7.BeginInit();
                //sbAttachmentDelete.Visible = true;
                //layoutControlItem7.EndInit();
                //layoutControl2.Refresh();
                //HideShowItemContent(layoutControl2, layoutControlItem8, false, sbAttachmentDelete);
                //HideShowItemContent(layoutControl2, layoutControlItem8, false, sbAttachmentDownload);
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
                this.locAvatar.Image = DXSWI.Properties.Resources.user_male_3;
            }
            else
            {
                this.locAvatar.Image = DXSWI.Properties.Resources.user_female_5;
            }
        }

        public void tsmiAddJobToPipeLine_Click(object sender, EventArgs e)
        {
            AddJobToPipeLine();
        }

        public void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to delete this item?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // delete this running task data
                    if (gvJobOrderPipeline.SelectedRowsCount > 0)
                    {
                        int row = gvJobOrderPipeline.GetSelectedRows().First();
                        DataRow data_row = gvJobOrderPipeline.GetDataRow(row);
                        int id = int.Parse(data_row["RunningTaskId"].ToString());
                        RunningTaskManager.deleteRunningTask(id);
                        updateData();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void logActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logActivity();
        }

        public void editActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // delete this running task data
                if (gvActivities.SelectedRowsCount > 0)
                {
                    int row = gvActivities.GetSelectedRows().First();
                    DataRow data_row = gvActivities.GetDataRow(row);
                    int activity_index = int.Parse(data_row["ActivityId"].ToString());
                    int scheduleEvent_index = int.Parse(data_row["ScheduleEventId"].ToString());

                    dlgLogActivity dlg = new dlgLogActivity();
                    dlg.updateDataEvent += updateData;
                    dlg.init(mCandidate.CandidateId, mCandidate.FirstName + " " + mCandidate.MiddleName + " " + mCandidate.LastName, Activity.TypeOfLogActivity.Candidate);
                    dlg.setData(activity_index, scheduleEvent_index);
                    dlg.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deleteActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to delete this item?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // delete this running task data
                    if (gvActivities.SelectedRowsCount > 0)
                    {
                        int row = gvActivities.GetSelectedRows().First();
                        DataRow data_row = gvActivities.GetDataRow(row);
                        int activity_index = int.Parse(data_row["ActivityId"].ToString());
                        int scheduleEvent_index = int.Parse(data_row["ScheduleEventId"].ToString());
                        ActivityManager.deleteActivity(activity_index, scheduleEvent_index);
                        updateData();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            dlg.init(mCandidate.CandidateId, mCandidate.FirstName + " " + mCandidate.MiddleName + " " + mCandidate.LastName, Activity.TypeOfLogActivity.Candidate);
            dlg.ShowDialog();
        }

        private void updateData()
        {
            try
            {
                this.locAvatar.Text = string.Format("{0} {1} {2}", mCandidate.FirstName, mCandidate.MiddleName, mCandidate.LastName);
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
                this.CurrentEmployerTextEdit.Text = mCandidate.CurrentEmployer;
                this.KeySkillsTextEdit.Text = mCandidate.KeySkills;
                setGender(mCandidate.Gender);
                if (mCandidate.CanRelocate)
                {
                    this.CanRelocateTextEdit.Text = "Yes";
                }
                else
                {
                    this.CanRelocateTextEdit.Text = "No";
                }
                this.CurrentPayTextEdit.Text = mCandidate.CurrentPay;
                this.DesiredPayTextEdit.Text = mCandidate.DesiredPay;
                this.DOBMarriedTextEdit.Text = mCandidate.DOBMarried;
                this.InterviewNotesMemoEdit.Text = mCandidate.InterviewNotes;
                this.UserOwnerTexEdit.Text = UserManager.getUserName(mCandidate.UserId); // owner
                this.MiscNotesMemoExEdit.Text = mCandidate.MiscNotes;
                this.CreatedDateDateEdit.Text = mCandidate.CreatedDate.ToShortDateString();
                this.DateAvailableDateEdit.Text = mCandidate.DateAvailable.ToShortDateString();
                // add data to view

                loadAvatar();
                loadAttachment();
                loadJobPipeLine();
                loadActivities();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgLogActivity dlg = new dlgLogActivity();
            dlg.updateDataEvent += updateData;
            string regarding = string.Empty;

            if (gvJobOrderPipeline.SelectedRowsCount > 0)
            {
                int row = gvJobOrderPipeline.GetSelectedRows().First();
                DataRow data_row = gvJobOrderPipeline.GetDataRow(row);
                regarding = data_row["Title"].ToString();
            }
            dlg.init(mCandidate.CandidateId, mCandidate.FirstName + " " + mCandidate.MiddleName + " " + mCandidate.LastName, Activity.TypeOfLogActivity.Candidate);
            if (regarding.Length > 0)
            {
                //todo
                dlg.setRegarding(regarding);
            }
            dlg.ShowDialog();
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
            try {
                // create link file and folder in server
                if (mCandidate.ResumeLink.Length == 0)
                {
                    // save resum to hardisk: folder = createedtime + candidateName + randomstring
                    string folderName = mCandidate.CandidateId.ToString() + mCandidate.CreatedDate.ToString(@"_yyyy-MM-dd") + Utils.getRandomAlphaNumeric(10);
                    string dir = string.Format(@"{0}candidates\resume\{1}\{2}", Properties.Settings.Default.StorageLocation, folderName, fileNameAttachment);
                    mCandidate.ResumeLink = dir;
                }
                else
                {
                    // delete old file
                    File.Delete(mCandidate.ResumeLink);

                    // update link of avatar
                    if (fileNameAttachment.Length > 0)
                    {
                        var link = mCandidate.ResumeLink.Split('\\');
                        mCandidate.ResumeLink = mCandidate.ResumeLink.Replace(link.Last(), fileNameAttachment);
                    }
                }

                // copy image to server
                if (fileNameAttachment.Length > 0)
                {
                    if (linkAttachment.Length > 0)
                    {
                        AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
                        Directory.CreateDirectory(mCandidate.ResumeLink.Replace(mCandidate.ResumeLink.Split('\\').Last(), ""));
                        File.Copy(linkAttachment, mCandidate.ResumeLink, true);
                    }
                }
                // update to database
                if (CandidateManager.updateResumeLink(mCandidate))
                {
                    // update attackment
                    loadAttachment();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sbAttachmentDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to delete this file?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // delete file in server
                File.Delete(mCandidate.ResumeLink);
                mCandidate.ResumeLink = string.Empty;
                // update to database
                if (CandidateManager.updateResumeLink(mCandidate))
                {
                    // update attackment
                    loadAttachment();
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

        protected void HideShowItemContent(LayoutControl layoutControlMain, LayoutControlItem bli, bool hide, Control control)
        {
            bli.BeginInit();
            if (hide)
                bli.Control = null;
            else
                bli.Control = control;
            bli.SizeConstraintsType = SizeConstraintsType.Custom;
            if (hide)
            {
                bli.SizeConstraintsType = SizeConstraintsType.Custom;
                bli.MinSize = bli.Size;
                bli.MaxSize = bli.Size;
            }
            else
            {
                bli.SizeConstraintsType = SizeConstraintsType.Default;
            }
            control.Visible = !hide;
            bli.EndInit();
            layoutControlMain.Refresh();
        }
    }
}
