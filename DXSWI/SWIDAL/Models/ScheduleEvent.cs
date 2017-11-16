using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWIDAL.Model
{
    public class ScheduleEvent : BaseModel
    {
        public int ScheduleEventId { get; set; }
        public int Type { get; set; }  // call, email, meeting, interview*, personal, other
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public int Duration { get; set; } // 15. 30, 45, 1hour, 1.5, 2, 3, 4, morthan 4, all day (nospecial time)
        public bool IsPublicEntry { get; set; }
        public string Description { get; set; }
        public int ActivityId { get; set; }
        public ScheduleEvent()
        {

        }
        ~ScheduleEvent()
        {

        }
    }
}
