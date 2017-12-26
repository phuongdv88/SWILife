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

        Dictionary<string, long> listRegarding = new Dictionary<string, long>();   // title of regarding , IdOfRunningTask in database
        Dictionary<string, string> listRegardingStatus = new Dictionary<string, string>(); // status of regarding
        Activity.TypeOfLogActivity typeOfActivity;
        long CurrentCandidateId = -1;
        long CurrentJobOrderId = -1;
        long CurrentContactId = -1;
        bool isAddNew = true;
        Activity currentActivity = new Activity();
        ScheduleEvent currentScheduleEvent = new ScheduleEvent();
        public delegate void updateData();
        public event updateData updateDataEvent;

        public void init(string name, Activity.TypeOfLogActivity type, long CandidateId, long JobOrderId, long ContactId)
        {
            try
            {
                listRegarding.Clear();
                listRegardingStatus.Clear();
                listRegarding.Add("General", -1);
                listRegardingStatus.Add("General", "None");
                typeOfActivity = type;
                CurrentCandidateId = CandidateId;
                CurrentJobOrderId = JobOrderId;
                CurrentContactId = ContactId;
                this.Text = name;
                switch (type)
                {
                    case Activity.TypeOfLogActivity.JobOrder:
                        break;
                    case Activity.TypeOfLogActivity.Contact:
                        break;
                    case Activity.TypeOfLogActivity.Candidate:
                        // get list job order in pipeline
                        ActivityManager.getListRegardingForCandidate(CandidateId, ref listRegarding, ref listRegardingStatus);
                        break;
                    case Activity.TypeOfLogActivity.Pipeline:
                        // get list job order in pipeline
                        ActivityManager.getListRegardingForCandidate(CandidateId, ref listRegarding, ref listRegardingStatus);
                        break;
                    default:
                        break;
                }

                cbeRegarding.Properties.Items.BeginUpdate();
                cbeRegarding.Properties.Items.Clear();
                // add to combobox
                foreach (var item in listRegarding.Keys)
                {
                    cbeRegarding.Properties.Items.Add(item);
                }
                cbeRegarding.Properties.Items.EndUpdate();
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

        public void setData(int activityId, int ScheduleEventId)
        {
            isAddNew = false;
            sbAdd.Text = "Edit";
            //currentActivityId = activityId;
            //currentScheduleId = ScheduleEventId;
            try
            {

                //get data by id

                currentActivity = ActivityManager.getActivityById(activityId);
                currentScheduleEvent = ActivityManager.getScheduleEventById(ScheduleEventId);

                // fill data to UI
                    setActivityToUI(currentActivity);
                    ucScheduleEvent1.setScheduleEventToUI(currentScheduleEvent);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void ceScheduleEvent_CheckedChanged(object sender, EventArgs e)
        {
            ucScheduleEvent1.Enabled = ceScheduleEvent.Checked;
            ucScheduleEvent1.Visible = ceScheduleEvent.Checked;
        }

        private void ucScheduleEvent1_Load(object sender, EventArgs e)
        {

        }

        private void sbAdd_Click(object sender, EventArgs e)
        {
            ScheduleEvent ev = null;
            Activity act = null;
            try
            {

                // get object from UI
                if (ceScheduleEvent.Checked)
                {
                    ev = ucScheduleEvent1.GetScheduleEventFromUI();
                    ev.ScheduleEventId = currentScheduleEvent.ScheduleEventId;
                }
                act = getActivityFromUI();
                act.ActivityId = currentActivity.ActivityId;
                if (isAddNew)
                {
                    // insert to db by transaction
                    ActivityManager.insert(act, ev);
                }
                else
                {
                    ActivityManager.update(currentActivity, currentScheduleEvent);
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
            if (cbeActivityType.SelectedText.Length == 0)
            {
                act.Type = "Nothing";
            }
            else
            {
                act.Type = cbeActivityType.SelectedText;
            }
            act.Notes = meActivityNote.Text;
            act.Created = DateTime.Now;
            act.ActivityOf = typeOfActivity;
            act.RunningTaskId = listRegarding[cbeRegarding.SelectedText];  // get running task id of this activity
            act.CandidateId = CurrentCandidateId;
            act.JobOrderId = CurrentJobOrderId;
            act.ContactID = CurrentContactId;
            return act;
        }

        private void setActivityToUI(Activity act)
        {
            if (act == null)
                return;
            //todo
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
                cbeStatus.Text = listRegardingStatus[cbeRegarding.SelectedText];
            }

        }
    }
}