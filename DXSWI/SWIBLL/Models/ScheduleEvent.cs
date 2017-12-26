using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWIBLL.Models
{
    public class ScheduleEvent : BaseModel
    {
        public long ScheduleEventId { get; set; }
        public int Type { get; set; }  // call, email, meeting, interview*, personal, other
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public int Duration { get; set; } // 15 minutes 30 minutes 1 hour 1,5 hours 2 hours 4 hours more than 4 hours, all day (nospecial time)
        public bool IsPublicEntry { get; set; }
        public string Description { get; set; }
        public long ActivityId { get; set; }
        public ScheduleEvent()
        {

        }
        ~ScheduleEvent()
        {

        }
    }
}
