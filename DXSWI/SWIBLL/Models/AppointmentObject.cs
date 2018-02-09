using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace SWIBLL.Models
{
    public class CustomAppointment : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string newName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(newName));
        }
        private long _AppointmentId;

        public long AppointmentId
        {
            get { return _AppointmentId; }
            set
            {
                if (_AppointmentId == value) return;
                _AppointmentId = value;
                //OnPropertyChanged("AppointmentId");
                OnPropertyChanged();
            }
        }

        public DateTime StartTime { get; set; }//
        public DateTime EndTime { get; set; }//
        public string Subject { get; set; }//
        public int Status { get; set; }//
        public string Description { get; set; }//
        public int Label { get; set; }//
        public string Location { get; set; }//
        public bool AllDay { get; set; }//
        public int Type { get; set; }//
        //public string RecurrenceInfo { get; set; }
        //public string ReminderInfo { get; set; }
        public object ResourceId { get; set; }//

        //public CustomAppointment()
        //{
        //    AppointmentId = -1;
        //    Type = -1;
        //    StartTime = DateTime.Now;
        //    EndTime = DateTime.Now;
        //    AllDay = false;
        //    Subject = string.Empty;
        //    Location = string.Empty;
        //    Description = string.Empty;
        //    Status = 0;
        //    Label = 0;
        //    ResourceId = null;
        //    ReminderInfo = string.Empty;
        //    RecurrenceInfo = string.Empty;
        //}
    }

    public class CustomResource
    {
        public string Name { get; set; }
        public long ResId { get; set; }
        public Color ResColor { get; set; }
        // Set the SchedulerStorage.Resources.ColorSaving property to ColorSavingType.Color to display resources using the specified color. 
    }
}
