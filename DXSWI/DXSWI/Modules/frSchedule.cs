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
        public static Random RandomInstance = new Random();
        private BindingList<CustomResource> CustomResourceCollection = new BindingList<CustomResource>();
        private BindingList<CustomAppointment> CustomEventList = new BindingList<CustomAppointment>();

        public frSchedule()
        {
            InitializeComponent();
            schedulerStorage1.Resources.ColorSaving = ColorSavingType.Color;
        }
        private void frSchedule_Load(object sender, EventArgs e)
        {
            scMain.Start = DateTime.Now;
        }

        public void Init()
        {
            try
            {
                InitResource();
                InitAppointments();

                // init timmer check schedule event
                Timer aTimer = new Timer();
                aTimer.Tick += OnTimedAppointments;
                aTimer.Interval = 1000 * 60 * 15; // check every 15 minutes 
                aTimer.Enabled = true;
                OnTimedAppointments(null, null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void OnTimedAppointments(object source, EventArgs e)
        {
            foreach(var ap in CustomEventList)
            {
                if(ap.StartTime > DateTime.Now)
                {
                    if(ap.StartTime.AddMinutes(-30) < DateTime.Now)
                    {
                        ScreenManager.Instance.ShowNoticeMessage(ap.Subject, "Appointment comming soon", MessageBoxIcon.Information);
                    }
                }
            }
        }

        public void NewAppointment()
        {
            newAppointmentItem1.PerformClick();
        }


        private void InitResource()
        {
            CustomResourceCollection.Clear();
            // add resource list from list User:
            if (UserManager.ActivatedUser.RoleName == "ADMIN")
            {
                UserManager.GetListResource(CustomResourceCollection);
            }
            else
            {
                CustomResourceCollection.Add(CreateCustomResource(UserManager.ActivatedUser.UserId, UserManager.ActivatedUser.UserName, Color.SandyBrown));
            }
            schedulerStorage1.Resources.DataSource = CustomResourceCollection;

        }

        private CustomResource CreateCustomResource(long resId, string caption, Color resColor)
        {
            return new CustomResource() { ResId = resId, Name = caption, ResColor = resColor };
        }

        private void InitAppointments()
        {
            CustomEventList.Clear();
            if (UserManager.ActivatedUser.RoleName == "ADMIN")
            {
                AppointmentManager.GetListAppointment(CustomEventList);
            } else
            {
                AppointmentManager.GetListAppointment(UserManager.ActivatedUser.UserId, CustomEventList);
            }
            this.schedulerStorage1.Appointments.DataSource = CustomEventList;
        }

        private void schedulerStorage1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e)
        {
            try
            {
                //appointment
                var listApt = e.Objects as AppointmentBaseCollection;
                for (int i = 0; i < listApt.Count; ++i)
                {
                    var apt = listApt[i] as Appointment;
                    if (apt != null)
                    {
                        if (apt.Id == null)
                            return;
                        CustomAppointment ap = new CustomAppointment()
                        {
                            AppointmentId = Convert.ToInt64(apt.Id?.ToString()),
                            Type = (int)apt.Type,
                            StartTime = apt.Start,
                            EndTime = apt.End,
                            AllDay = apt.AllDay,
                            Subject = apt.Subject,
                            Location = apt.Location,
                            Description = apt.Description,
                            Status = int.Parse(apt.StatusKey?.ToString()),
                            Label = int.Parse(apt.LabelKey?.ToString()),
                            ResourceId = apt.ResourceId,
                        };
                        // update to db
                        AppointmentManager.UpdateAppointment(ap);

                    }
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void schedulerStorage1_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
        {
            try
            {
                var listApt = e.Objects as AppointmentBaseCollection;
                for (int i = 0; i < listApt.Count; ++i)
                {
                    var apt = listApt[i] as Appointment;
                    if (apt != null)
                    {
                        if (apt.Id != null)
                        {
                            long id = Convert.ToInt64(apt.Id.ToString());
                            // update to db
                            AppointmentManager.DeleteAppointment(id);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void schedulerStorage1_AppointmentsInserted(object sender, PersistentObjectsEventArgs e)
        {
            try
            {
                var listApt = e.Objects as AppointmentBaseCollection;
                for (int i = 0; i < listApt.Count; ++i)
                {
                    var apt = listApt[i] as Appointment;
                    if (apt != null)
                    {
                        CustomAppointment ap = new CustomAppointment()
                        {
                            AppointmentId = -1,
                            Type = (int)apt.Type,
                            StartTime = apt.Start,
                            EndTime = apt.End,
                            AllDay = apt.AllDay,
                            Subject = apt.Subject,
                            Location = apt.Location,
                            Description = apt.Description,
                            Status = int.Parse(apt.StatusKey?.ToString()),
                            Label = int.Parse(apt.LabelKey?.ToString()),
                            ResourceId = apt.ResourceId,
                        };
                        // update to db
                        long id = AppointmentManager.InsertAppointment(ap);
                        schedulerStorage1.SetAppointmentId(apt, id);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
