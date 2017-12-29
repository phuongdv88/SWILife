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
using System.IO;
using System.Security.Principal;

namespace DXSWI.Forms
{
    public partial class dlgJobOrderEdit : DevExpress.XtraEditors.XtraForm
    {
        JobOrder mJobOrder = null;
        bool isNew = true;
        public delegate void onUpdateData();
        public event onUpdateData emitUpdateData;
        Dictionary<string, long> companiesNameAndId; // name, id
        Dictionary<string, long> contactsNameAndId; // contact name and id

        public dlgJobOrderEdit(long jobOrderId)
        {
            InitializeComponent();
            try
            {
                init(jobOrderId);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void init(long jobOrderId)
        {
            if (jobOrderId == -1)
            {
                isNew = true;
            }
            else
            {
                isNew = false;
                mJobOrder = JobOrderManager.getJobOrder(jobOrderId);
                fillCurrentJoborderToUI();
                loadAttachment();
                updateData();
            }

        }

        private void fillCurrentJoborderToUI()
        {
            if (mJobOrder == null)
                return;
            this.TitleTextEdit.Text = mJobOrder.Title;
            this.DepartmentTextEdit.Text = mJobOrder.Department;
            this.SalaryTextEdit.Text = mJobOrder.Salary;
            // todo:
            if(mJobOrder.CompanyId != -1)
            {
                // get company name
            } else
            {
                // load all company name to select in combobox
            }
            if(mJobOrder.ContactId != -1)
            {
                //get contact name
            } else
            {
                // load all contact name of this company
            }
            //this.companyComboxEdit.EditValue = mJobOrder.CompanyName;
            //this.contactComboboxEdit.EditValue = mJobOrder.ContactName;

            this.CityTextEdit.Text = mJobOrder.City;
            this.StateTextEdit.Text = mJobOrder.State;
            this.StartDateDateEdit.Text = mJobOrder.StartDate.ToString("dd/MM/yyyy");
            this.DurationTextEdit.Text = mJobOrder.Duration;
            this.TypeComboBoxEdit.EditValue = mJobOrder.Type;
            this.OpeningsTextEdit.Text = mJobOrder.Openings.ToString();
            this.IsHotCheckEdit.Checked = mJobOrder.IsHot;
            this.isPublicCheckEdit.Checked = mJobOrder.isPublic;
            this.ExperienceYearTextEdit.Text = mJobOrder.ExperienceYear.ToString();
            this.StatusComboBoxEdit.EditValue = mJobOrder.Status;
            this.WebLinkTextEdit.Text = mJobOrder.WebLink;
            this.DescriptionMemoExEdit.Text = mJobOrder.Description;
            this.meInternalNotes.Text = mJobOrder.InternalNotes;
        }

        private void getJobOrderFromUi()
        {
            if (mJobOrder == null)
                mJobOrder = new JobOrder();
            mJobOrder.Title = this.TitleTextEdit.Text;
            mJobOrder.Department = this.DepartmentTextEdit.Text;
            mJobOrder.Salary = this.SalaryTextEdit.Text;
            //todo
            //mJobOrder.ContactId = 
            //mJobOrder.ContactId = 
            mJobOrder.ContactName = this.contactComboboxEdit.Text;
            mJobOrder.CompanyName = this.companyComboxEdit.Text;
            mJobOrder.City = this.CityTextEdit.Text;
            mJobOrder.State = this.StateTextEdit.Text;
            if (StartDateDateEdit.Text.Length > 0)
            {
                mJobOrder.StartDate = DateTime.Parse(this.StartDateDateEdit.DateTime.ToString("yyyy/MM/dd"));
            }
            mJobOrder.Duration = this.DurationTextEdit.Text;
            mJobOrder.Type = this.TypeComboBoxEdit.Text;
            if (this.OpeningsTextEdit.Text.Length > 0)
            {
                mJobOrder.Openings = int.Parse(this.OpeningsTextEdit.Text);
            }
            mJobOrder.IsHot = this.IsHotCheckEdit.Checked;
            mJobOrder.isPublic = this.isPublicCheckEdit.Checked;
            if (this.ExperienceYearTextEdit.Text.Length > 0)
            {
                mJobOrder.ExperienceYear = int.Parse(this.ExperienceYearTextEdit.Text);
            }
            mJobOrder.Status = this.StatusComboBoxEdit.Text;
            mJobOrder.WebLink = this.WebLinkTextEdit.Text;
            mJobOrder.Description = this.DescriptionMemoExEdit.Text;
            mJobOrder.InternalNotes = this.meInternalNotes.Text;

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
            string linkAttachment = openFileDlg.FileName;
            string fileNameAttachment = linkAttachment.Split('\\').Last();
            try
            {
                // create link file and folder in server
                if (mJobOrder.AttachmentLink == null || mJobOrder.AttachmentLink.Length == 0)
                {
                    // save resum to hardisk: folder = createedtime + candidateName + randomstring
                    string folderName = mJobOrder.JobOrderId.ToString() + mJobOrder.Created.ToString(@"_yyyy-MM-dd") + Utils.getRandomAlphaNumeric(10);
                    string dir = string.Format(@"{0}joborder\attachment\{1}\{2}", Properties.Settings.Default.StorageLocation, folderName, fileNameAttachment);
                    mJobOrder.AttachmentLink = dir;
                }
                else
                {
                    // delete old file
                    File.Delete(mJobOrder.AttachmentLink);

                    // update link of avatar
                    if (fileNameAttachment.Length > 0)
                    {
                        var link = mJobOrder.AttachmentLink.Split('\\');
                        mJobOrder.AttachmentLink = mJobOrder.AttachmentLink.Replace(link.Last(), fileNameAttachment);
                    }
                }

                // copy image to server
                if (fileNameAttachment.Length > 0)
                {
                    if (linkAttachment.Length > 0)
                    {
                        AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
                        Directory.CreateDirectory(mJobOrder.AttachmentLink.Replace(mJobOrder.AttachmentLink.Split('\\').Last(), ""));
                        File.Copy(linkAttachment, mJobOrder.AttachmentLink, true);
                    }
                }
                // update to database
                if (JobOrderManager.updateAttactmentLink(mJobOrder))
                {
                    // update attackment
                    loadAttachment();
                }
                else
                {
                    throw new Exception("Cannot update attachment link");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadAttachment()
        {
            if (mJobOrder.AttachmentLink == null) return;
            // load attachment from disk
            if (mJobOrder.AttachmentLink.Length == 0)
            {
                this.sliAttachment.Text = "No file chosen";
                this.sbDelete.Enabled = false;
                this.sbDownload.Enabled = false;

            }
            else
            {
                this.sliAttachment.Text = mJobOrder.AttachmentLink.Split('\\').Last();
                this.sbDelete.Enabled = true;
                this.sbDownload.Enabled = true;
            }
        }

        private void sbDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to delete this file?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // delete file in server
                try
                {
                    File.Delete(mJobOrder.AttachmentLink);
                    mJobOrder.AttachmentLink = string.Empty;
                    // update to database
                    if (JobOrderManager.updateAttactmentLink(mJobOrder))
                    {
                        // update attackment
                        loadAttachment();
                    }
                    else
                    {
                        throw new Exception("Cannot update attachment link");
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void sbDownload_Click(object sender, EventArgs e)
        {
            // download to local or open this file
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Save resume to";
            dlg.RestoreDirectory = true;
            dlg.Filter = "All files (*.*)|*.*";
            dlg.FileName = mJobOrder.AttachmentLink.Split('\\').Last();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            string save_link = dlg.FileName;
            File.Copy(mJobOrder.AttachmentLink, save_link);
        }

        private void sbOK_Click(object sender, EventArgs e)
        {
            // validate data
            try {
                // get data from ui
                getJobOrderFromUi();
                // if it is new item, use inserting command, update username else use updating command
                if (isNew)
                {
                    mJobOrder.OwnerId = UserManager.ActivatedUser.Index;
                    mJobOrder.RecruiterId = UserManager.ActivatedUser.Index;
                    JobOrderManager.createJobOrder(mJobOrder);
                } else
                {
                    JobOrderManager.updateJobOrder(mJobOrder);
                }

                emitUpdateData?.Invoke();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addCandidateToPipelineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mJobOrder == null) return;
            dlgAddCandidateToPipeline dlg = new dlgAddCandidateToPipeline(mJobOrder.JobOrderId);
            dlg.updateDataEvent += updateData;
            dlg.ShowDialog();
        }

        private void addActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgLogActivity dlg = new dlgLogActivity();
            dlg.updateDataEvent += updateData;
            string regarding = mJobOrder.Title;
            int canId = -1;
            string canName = string.Empty;

            if (gvCandidatePipeline.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Have not yet selected anything", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try {
                int row = gvCandidatePipeline.GetSelectedRows().First();
                DataRow data_row = gvCandidatePipeline.GetDataRow(row);
                canId = int.Parse(data_row["CandidateId"].ToString());
                canName = data_row["FirstName"].ToString() + " " + data_row["MiddleName"].ToString() + " " + data_row["LastName"].ToString();
                dlg.init(canName, Activity.TypeOfLogActivity.Pipeline, canId, mJobOrder.JobOrderId, -1);
                if (mJobOrder.Title.Length > 0)
                {
                    //todo
                    dlg.setRegarding(mJobOrder.Title);
                }
                dlg.ShowDialog();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void emailToCandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void emailToAllCandidatesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteCandidateFromPipelineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to delete this item?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // delete this running task data
                    if (gvCandidatePipeline.SelectedRowsCount > 0)
                    {
                        int row = gvCandidatePipeline.GetSelectedRows().First();
                        DataRow data_row = gvCandidatePipeline.GetDataRow(row);
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

        private void updateData()
        {
            // load jobOrder pipe line
            loadPipeLineCandidates();
        }

        private void loadPipeLineCandidates()
        {
            if (mJobOrder == null)
                return;
            try
            {
                // load data in candidate table and show in grid control
                gcCandidatePipeline.DataSource = RunningTaskManager.getRunningTaskCandidates(mJobOrder.JobOrderId);
                //gcCandidatePipeline.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dlgJobOrderEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}