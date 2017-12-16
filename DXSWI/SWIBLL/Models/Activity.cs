using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWIBLL.Models
{
    public class Activity : BaseModel
    {
        public enum TypeOfLogActivity{
            JobOrder = 0,
            Contact = 1,
            Candidate = 2,
        }

        public enum RunningTaskStatus
        {
            NOT_CONTACT = 0,
            CONTACTED,
            CANDIDATE_RESPONDED,
            QUALIFYING,
            SUBMITTED,
            INTERVIEWING,
            OFFERED,
            NOT_IN_CONSIDERATION,
            CLIENT_DECLINED,
            PLACED,
        }
        public int ActivityId { get; set; }
        public string Regarding { get; set; }  //General, job order1, job order2...
        public RunningTaskStatus Status { get; set; } // each of job order have different status: no contact, contacted, candidate responded,
        //qualifying, submitted, interviewing, offered, not in consideration, client declined, placed.
        public string Type { get; set; } // Call, Call(talked), Message,CV Submitted, e-mail, meeting, other
        public string Notes { get; set; }

        public DateTime Created { get; set; }
        public TypeOfLogActivity ActivityOf { get; set; } // job order, contact, company, running task, candidate,
        public int JobOrderId { get; set; }
        public int CandidateId { get; set; }
        public int ContactID { get; set; }
        public int UserId { get; set; }

        public int RunningTaskId { get; set; }

        public long ScheduleEventId { get; set; }

        public Activity()
        {
            JobOrderId = -1;
            CandidateId = -1;
            ContactID = -1;
            UserId = -1;
            ScheduleEventId = -1;
            RunningTaskId = -1;
        }
        ~Activity()
        {

        }
    }
}
