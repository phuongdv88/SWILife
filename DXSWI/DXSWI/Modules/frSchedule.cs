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
using DevExpress.XtraScheduler;
using SWIBLL;
using SWIBLL.Models;

namespace DXSWI.Modules
{
    public partial class frSchedule : DevExpress.XtraEditors.XtraUserControl
    {
        public frSchedule()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            UpdateData();
        }

        public void UpdateData()
        {
            try
            {
                // get all appointment and bind to schedulecontrol
                scMain.DataStorage.Appointments.DataSource = AppointmentManager.GetAppointment();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            DXSWI.Modules.OutlookAppointmentForm form = new DXSWI.Modules.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }

        private void scMain_Click(object sender, EventArgs e)
        {

        }
    }
}
