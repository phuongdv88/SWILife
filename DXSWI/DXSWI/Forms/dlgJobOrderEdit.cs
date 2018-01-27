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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;

namespace DXSWI.Forms
{
    public partial class dlgJobOrderEdit : DevExpress.XtraEditors.XtraForm
    {
        JobOrder mJobOrder = null;
        bool isNew = true;
        public delegate void onUpdateData();
        public event onUpdateData UpdateDataEvent;
        Dictionary<string, long> companiesNameAndId = new Dictionary<string, long>(); // name, id
        Dictionary<string, long> contactsNameAndId = new Dictionary<string, long>(); // contact name and id

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
                // load all company name to select in combobox
                getCompanies(ref companiesNameAndId);
                companyComboxEdit.Properties.Items.Clear();
                companyComboxEdit.Properties.Items.AddRange(companiesNameAndId.Keys);
                gcCandidatePipeline.Enabled = false;
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

        public void SetCompanyName(string comName)
        {
            companyComboxEdit.EditValue = comName;
            companyComboxEdit.ReadOnly = true;
        }

        private void fillCurrentJoborderToUI()
        {
            if (mJobOrder == null)
                return;
            this.TitleTextEdit.Text = mJobOrder.Title;
            this.DepartmentTextEdit.Text = mJobOrder.Department;
            this.SalaryTextEdit.Text = mJobOrder.Salary;
            // todo:
            // load all company name to select in combobox
            getCompanies(ref companiesNameAndId);
            companyComboxEdit.Properties.Items.Clear();
            companyComboxEdit.Properties.Items.AddRange(companiesNameAndId.Keys);

            if (mJobOrder.CompanyId != -1)
            {
                companyComboxEdit.EditValue = mJobOrder.CompanyName;
            }
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

            // tooltip
            this.TitleTextEdit.ToolTip = mJobOrder.Title;
            this.DepartmentTextEdit.ToolTip = mJobOrder.Department;
            this.SalaryTextEdit.ToolTip = mJobOrder.Salary;
            this.CityTextEdit.ToolTip = mJobOrder.City;
            this.StateTextEdit.ToolTip = mJobOrder.State;
            this.StartDateDateEdit.ToolTip = mJobOrder.StartDate.ToString("dd/MM/yyyy");
            this.DurationTextEdit.ToolTip = mJobOrder.Duration;
            this.OpeningsTextEdit.ToolTip = mJobOrder.Openings.ToString();
            this.ExperienceYearTextEdit.ToolTip = mJobOrder.ExperienceYear.ToString();
            this.WebLinkTextEdit.ToolTip = mJobOrder.WebLink;
            this.DescriptionMemoExEdit.ToolTip = mJobOrder.Description;
            this.meInternalNotes.ToolTip = mJobOrder.InternalNotes;
        }

        private void getJobOrderFromUi()
        {
            if (mJobOrder == null)
                mJobOrder = new JobOrder();
            mJobOrder.Title = this.TitleTextEdit.Text;
            mJobOrder.Department = this.DepartmentTextEdit.Text;
            mJobOrder.Salary = this.SalaryTextEdit.Text;
            try
            {
                mJobOrder.CompanyId = companiesNameAndId[companyComboxEdit.Text];
            }
            catch
            {
                mJobOrder.CompanyId = -1;
            }
            try
            {
                mJobOrder.ContactId = contactsNameAndId[contactComboboxEdit.Text];
            }
            catch
            {
                mJobOrder.ContactId = -1;
            }
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
            try
            {
                // get data from ui
                getJobOrderFromUi();
                // if it is new item, use inserting command, update username else use updating command
                if (isNew)
                {
                    mJobOrder.OwnerId = UserManager.ActivatedUser.UserId;
                    mJobOrder.RecruiterId = UserManager.ActivatedUser.UserId;
                    if (!JobOrderManager.IsJobOrderExist(mJobOrder))
                    {
                        JobOrderManager.createJobOrder(mJobOrder);
                    }
                    else
                    {
                        if (XtraMessageBox.Show("This job order has already existed. Would you want to load this candidate data?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            gcCandidatePipeline.Enabled = true;
                            isNew = false;
                            mJobOrder = JobOrderManager.getJobOrderByTitle(TitleTextEdit.Text.Trim(), companiesNameAndId[companyComboxEdit.Text]);
                            if (mJobOrder == null)
                            {
                                XtraMessageBox.Show("Load data fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Close();
                            }
                            fillCurrentJoborderToUI();
                            loadAttachment();
                            updateData();
                            return;
                        }
                    }
                }
                else
                {
                    JobOrderManager.updateJobOrder(mJobOrder);
                }

                UpdateDataEvent?.Invoke();
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
            //todo: support multiselection
            List<long> candidatesId = new List<long>();



            string regarding = mJobOrder.Title;
            long canId = -1;
            string canName = string.Empty;

            if (gvCandidatePipeline.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Have not yet selected anything", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                foreach (var row in gvCandidatePipeline.GetSelectedRows())
                {
                    DataRow data_row = gvCandidatePipeline.GetDataRow(row);
                    canId = Convert.ToInt64(data_row["CandidateId"].ToString());
                    candidatesId.Add(canId);
                    if (candidatesId.Count == 1)
                    {
                        canName = data_row["FirstName"].ToString() + " " + data_row["MiddleName"].ToString() + " " + data_row["LastName"].ToString();
                    }
                    else
                    {
                        canName = "Update Multi Candidates";
                    }
                }
                dlg.initForListCandidateInPipeline(canName, mJobOrder.Title, mJobOrder.JobOrderId, candidatesId);
                if (mJobOrder.Title.Length > 0)
                {
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
            List<string> emails = new List<string>();
            List<string> names = new List<string>();
            List<long> runningTaskIds = new List<long>();
            List<long> canIds = new List<long>();
            if (gvCandidatePipeline.SelectedRowsCount > 0)
            {
                try
                {
                    int row = gvCandidatePipeline.GetSelectedRows().First();
                    DataRow data_row = gvCandidatePipeline.GetDataRow(row);
                    emails.Add(data_row["Email"].ToString());
                    runningTaskIds.Add(Convert.ToInt64(data_row["RunningTaskId"].ToString()));
                    names.Add(string.Join(" ", data_row["FirstName"].ToString(), data_row["LastName"].ToString()));
                    canIds.Add(Convert.ToInt64(data_row["CandidateId"].ToString()));
                    EmailToCandidates(runningTaskIds, emails, names, canIds);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void EmailToCandidates(List<long> runningTaskIds, List<string> emails, List<string> names, List<long> canIds)
        {
            // test:
            dlgMailEdit dlg = new dlgMailEdit(runningTaskIds, emails, names,canIds, mJobOrder.CompanyName, mJobOrder.Title, mJobOrder.JobOrderId);
            dlg.ShowDialog();
        }

        private void emailToAllCandidatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> emails = new List<string>();
            List<string> names = new List<string>();
            List<long> runningTaskIds = new List<long>();
            List<long> canIds = new List<long>();
            if (gvCandidatePipeline.SelectedRowsCount > 0)
            {
                try
                {
                    foreach (var row in gvCandidatePipeline.GetSelectedRows())
                    {
                        DataRow data_row = gvCandidatePipeline.GetDataRow(row);
                        emails.Add(data_row["Email"].ToString());
                        runningTaskIds.Add(Convert.ToInt64(data_row["RunningTaskId"].ToString()));
                        names.Add(string.Join(" ", data_row["FirstName"].ToString(), data_row["LastName"].ToString()));
                        canIds.Add(Convert.ToInt64(data_row["CandidateId"].ToString()));
                    }
                    EmailToCandidates(runningTaskIds, emails, names, canIds);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteCandidateFromPipelineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gvCandidatePipeline.SelectedRowsCount > 0)
            {
                if (XtraMessageBox.Show("Are you sure to delete this item?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // delete this running task data

                        int row = gvCandidatePipeline.GetSelectedRows().First();
                        DataRow data_row = gvCandidatePipeline.GetDataRow(row);
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
                int[] rows = null;
                if (gvCandidatePipeline.SelectedRowsCount > 0)
                    rows = gvCandidatePipeline.GetSelectedRows();
                gcCandidatePipeline.DataSource = RunningTaskManager.getRunningTaskCandidates(mJobOrder.JobOrderId);
                //gcCandidatePipeline.Refresh();
                if (rows != null)
                {
                    if (rows.First() < gvCandidatePipeline.RowCount)
                    {
                        gvCandidatePipeline.ClearSelection();
                        gvCandidatePipeline.SelectRow(rows.First());
                        gvCandidatePipeline.FocusedRowHandle = rows.First();
                    }
                }

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

        private void getCompanies(ref Dictionary<string, long> listCompanyAndId)
        {
            listCompanyAndId.Clear();
            try
            {
                DataTable dt = CompanyManager.getNameCompanies();
                if (dt == null) return;
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    DataRow data_row = dt.Rows[i];
                    listCompanyAndId.Add(data_row["Name"].ToString(), Convert.ToInt64(data_row["CompanyId"].ToString()));
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getContacts(long CompanyId, ref Dictionary<string, long> listContactAndId)
        {
            listContactAndId.Clear();
            try
            {
                DataTable dt = ContactManager.getContactsNameByCompanyId(CompanyId);
                if (dt == null) return;
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    DataRow data_row = dt.Rows[i];
                    listContactAndId.Add(data_row["ContactName"].ToString(), Convert.ToInt64(data_row["ContactId"].ToString()));
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void companyComboxEdit_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                getContacts(companiesNameAndId[companyComboxEdit.Text], ref contactsNameAndId);
                contactComboboxEdit.Properties.Items.Clear();
                contactComboboxEdit.Properties.Items.AddRange(contactsNameAndId.Keys);
                if (mJobOrder == null)
                {
                    contactComboboxEdit.Text = string.Empty;
                    return;
                }

                if (!contactsNameAndId.ContainsValue(mJobOrder.ContactId))
                    contactComboboxEdit.Text = string.Empty;
                else
                {
                    contactComboboxEdit.EditValue = mJobOrder?.ContactName;
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gcCandidatePipeline_DoubleClick(object sender, EventArgs e)
        {
            editCandidateToolStripMenuItem.PerformClick();
        }

        private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.Info != null || e.SelectedControl != gcCandidatePipeline) return;

            //Get the view at the current mouse position
            GridView view = gcCandidatePipeline.FocusedView as GridView;
            if (view == null) return;
            //Get the view's element information that resides at the current position
            GridHitInfo info = view.CalcHitInfo(e.ControlMousePosition);
            //Display a hint for row indicator cells
            if (info.InRowCell)
            {
                string text = view.GetRowCellDisplayText(info.RowHandle, info.Column);
                string cellKey = info.RowHandle.ToString() + " - " + info.Column.ToString();
                e.Info = new ToolTipControlInfo(cellKey, text);
            }
        }

        private void editCandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long canId = -1;
            if (gvCandidatePipeline.SelectedRowsCount > 0)
            {
                canId = Convert.ToInt64(gvCandidatePipeline.GetDataRow(gvCandidatePipeline.GetSelectedRows().First())["CandidateId"].ToString());
            }
            if (canId == -1)
                return;
            // todo show dlgCandidateEdit but in mode view only
            dlgCandidateEdit dlg = new dlgCandidateEdit(canId, null);
            dlg.emitUpdateData += updateData;
            dlg.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void gvCandidatePipeline_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // if match value is changed, then update to DB
            try
            {
                if (e.Column.FieldName == "Match")
                {
                    int row = e.RowHandle;
                    DataRow data_row = gvCandidatePipeline.GetDataRow(row);
                    long id = Convert.ToInt64(data_row["RunningTaskId"].ToString());
                    RunningTaskManager.updateMatchValue(Convert.ToInt32(e.Value.ToString()), id);
                    //updateData();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}