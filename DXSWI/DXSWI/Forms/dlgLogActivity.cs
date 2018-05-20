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
    public partial class dlgLogActivity : DevExpress.XtraEditors.XtraForm
    {

        Dictionary<string, long> listRegardingRunningTaskId = new Dictionary<string, long>();   // title of regarding , IdOfRunningTask in database
        Dictionary<string, long> listRegardingJobOrderId = new Dictionary<string, long>();   // title of regarding , JobOrderId in database
        Dictionary<string, string> listRegardingStatus = new Dictionary<string, string>(); // status of regarding
        Activity.TypeOfLogActivity typeOfActivity;
        long CurrentCandidateId = -1;
        long CurrentJobOrderId = -1;
        long CurrentContactId = -1;
        bool isAddNew = true;
        Activity currentActivity = new Activity();
        public delegate void updateData();
        public event updateData updateDataEvent;

        List<long> listCandidateId;
        bool isMultiCandidateSelected = false;

        public void init(string name, Activity.TypeOfLogActivity type, long CandidateId, long JobOrderId, long ContactId)
        {
            try
            {
                listRegardingRunningTaskId.Clear();
                listRegardingStatus.Clear();
                listRegardingJobOrderId.Clear();
                listRegardingRunningTaskId.Add("General", -1);
                listRegardingStatus.Add("General", "None");
                listRegardingJobOrderId.Add("General", -1);
                typeOfActivity = type;
                CurrentCandidateId = CandidateId;
                CurrentJobOrderId = JobOrderId;
                CurrentContactId = ContactId;
                this.Text = name;
                cbeRegarding.Properties.Items.BeginUpdate();
                cbeRegarding.Properties.Items.Clear();
                switch (type)
                {
                    case Activity.TypeOfLogActivity.Candidate:
                        // get list job order in pipeline
                        ActivityManager.getListRegardingForCandidate(CandidateId, ref listRegardingRunningTaskId, ref listRegardingStatus);
                        cbeRegarding.Properties.Items.AddRange(listRegardingRunningTaskId.Keys);

                        break;
                    case Activity.TypeOfLogActivity.Pipeline:
                        // get list job order in pipeline
                        ActivityManager.getListRegardingForCandidate(CandidateId, ref listRegardingRunningTaskId, ref listRegardingStatus);
                        cbeRegarding.Properties.Items.AddRange(listRegardingRunningTaskId.Keys);

                        break;
                    case Activity.TypeOfLogActivity.Contact:
                        // get list job order of company of this contact
                        ActivityManager.getListRegardingForContact(CurrentContactId, ref listRegardingJobOrderId);
                        cbeRegarding.Properties.Items.AddRange(listRegardingJobOrderId.Keys);
                        cbeStatus.Enabled = false;
                        break;
                    default:
                        break;
                }

                cbeRegarding.Properties.Items.EndUpdate();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void initForListCandidateInPipeline(string name, string regarding, long jobOrderId, List<long> CandidatesId)
        {
            try
            {
                isMultiCandidateSelected = true;
                listRegardingRunningTaskId.Clear();
                listRegardingStatus.Clear();
                this.Text = name;
                typeOfActivity = Activity.TypeOfLogActivity.Pipeline;
                CurrentJobOrderId = jobOrderId;
                listCandidateId = CandidatesId;
                // do not change regarding
                cbeRegarding.Properties.Items.BeginUpdate();
                cbeRegarding.Properties.Items.Clear();
                cbeRegarding.Properties.Items.Add(regarding);
                cbeRegarding.Properties.Items.EndUpdate();
                cbeRegarding.ReadOnly = true;

                // enable change status checkbox
                ceChangeStatus.Enabled = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void setRegarding(string regarding)
        {
            try
            {
                cbeRegarding.EditValue = regarding;
            }
            catch
            {
                //XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setData(long activityId)
        {
            isAddNew = false;
            sbAdd.Text = "Edit";

            try
            {

                //get data by id

                currentActivity = ActivityManager.getActivityById(activityId);

                // fill data to UI
                setActivityToUI(currentActivity);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void SetReadingMode()
        {
            ceLogActivity.Enabled = false;
            meActivityNote.ReadOnly = true;
            ceChangeStatus.Enabled = false;
            sbAdd.Dispose();
        }
        public dlgLogActivity()
        {
            InitializeComponent();
        }

        private void ceChangeStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (ceChangeStatus.Checked)
            {
                cbeStatus.Enabled = true;
                //cbeStatus.SelectedIndex = 0;
            }
            else
            {
                cbeStatus.Enabled = false;
                //cbeStatus.SelectedIndex = -1;
            }
        }

        private void ceLogActivity_CheckedChanged(object sender, EventArgs e)
        {
            if (ceLogActivity.Checked)
            {
                cbeActivityType.Enabled = true;
                //cbeActivityType.SelectedIndex = 0;
            }
            else
            {
                cbeActivityType.Enabled = false;
                //cbeActivityType.SelectedIndex = -1;
            }
        }


        private void sbAdd_Click(object sender, EventArgs e)
        {
            Activity act = null;
            try
            {

                // get object from UI
                act = getActivityFromUI();
                act.ActivityId = currentActivity.ActivityId;
                if (isAddNew)
                {
                    // insert to db by transaction
                    if (isMultiCandidateSelected)
                    {
                        // add multi action
                        ActivityManager.insertMultiActionForCandidates(act, CurrentJobOrderId, listCandidateId);
                    }
                    else
                    {
                        ActivityManager.insert(act);
                        // if status == place -> update current position = job title, current company = company name.
                        if(act.Status == Activity.RunningTaskStatus.PLACED)
                        {
                            long canid = act.CandidateId;
                            string currentPosition = act.Regarding;
                            long jobId = act.JobOrderId;
                            // get company name from job order id
                            string currentCompany = CompanyManager.getCompanyNameByJobOrderId(jobId);
                            CandidateManager.updateCurrentStatus(canid, currentPosition, currentCompany);
                        }
                    }
                }
                else
                {
                    ActivityManager.update(currentActivity);
                }
                updateDataEvent?.Invoke();

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

        private Activity getActivityFromUI()
        {
            Activity act = new Activity();
            act.Regarding = cbeRegarding.Text;
            act.Status = (Activity.RunningTaskStatus)cbeStatus.SelectedIndex;
            if (cbeActivityType.Text.Length == 0)
            {
                act.Type = "Orther";
            }
            else
            {
                act.Type = cbeActivityType.Text;
            }
            act.Notes = meActivityNote.Text;
            act.Created = DateTime.Now;
            act.ActivityOf = typeOfActivity;
            if (typeOfActivity == Activity.TypeOfLogActivity.Contact)
            {
                    act.RunningTaskId = -1;
                    act.CandidateId = CurrentCandidateId;
                    act.JobOrderId = listRegardingJobOrderId[cbeRegarding.Text];
                    act.ContactId = CurrentContactId;
            }
            else
            {
                if (!isMultiCandidateSelected)
                {
                    act.RunningTaskId = listRegardingRunningTaskId[cbeRegarding.Text];  // get running task id of this activity
                    act.CandidateId = CurrentCandidateId;
                    act.JobOrderId = CurrentJobOrderId;
                    act.ContactId = CurrentContactId;
                }
            }
            return act;
        }

        private void setActivityToUI(Activity act)
        {
            if (act == null)
                return;
            try
            {
                cbeRegarding.EditValue = act.Regarding;
            }
            catch { }
            cbeRegarding.Enabled = false;
            try
            {
                if (act.Status > 0 && (int)act.Status < cbeStatus.Properties.Items.Count)
                {
                    cbeStatus.SelectedIndex = (int)act.Status;
                }
            }
            catch { }
            try
            {
                cbeActivityType.EditValue = act.Type;
            }
            catch { }
            meActivityNote.Text = act.Notes;
        }
        private void cbeRegarding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeOfActivity == Activity.TypeOfLogActivity.Contact)
            {

            }
            else
            {
                if (!isMultiCandidateSelected)
                {
                    if (cbeRegarding.SelectedIndex == 0)
                    {
                        ceChangeStatus.Enabled = false;
                        cbeStatus.Enabled = false;
                        cbeStatus.SelectedIndex = -1;
                    }
                    else
                    {
                        ceChangeStatus.Enabled = true;
                        cbeStatus.Enabled = ceChangeStatus.Checked;
                        cbeStatus.Text = listRegardingStatus[cbeRegarding.Text];
                    }
                }
            }
        }

        private void dlgLogActivity_KeyDown(object sender, KeyEventArgs e)
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