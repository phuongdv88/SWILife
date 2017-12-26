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
            JobOrder = 0, // create JobOrder, edit joborder, Delete JobOrder,
            Contact = 1, // add, edit, delete contact
            Candidate = 2, // add, edit, delete candidate
            Pipeline = 3, // add running task
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
        public long ActivityId { get; set; }
        public string Regarding { get; set; }  //General, job order1, job order2...
        public RunningTaskStatus Status { get; set; } // each of job order have different status: no contact, contacted, candidate responded,
        //qualifying, submitted, interviewing, offered, not in consideration, client declined, placed.
        public string Type { get; set; } // Call, Call(talked), Message,CV Submitted, e-mail, meeting, other, add Job Order To PipeLIne, Add Candidate to Pipeline
        public string Notes { get; set; }

        public DateTime Created { get; set; }
        public TypeOfLogActivity ActivityOf { get; set; } // job order, contact, company, running task, candidate,
        public long JobOrderId { get; set; }
        public long CandidateId { get; set; }
        public long ContactID { get; set; }
        public long UserId { get; set; }

        public long RunningTaskId { get; set; }

        public long ScheduleEventId { get; set; }

        public Activity()
        {
            JobOrderId = -1;
            CandidateId = -1;
            ContactID = -1;
            UserId = -1;
            ScheduleEventId = -1;
            RunningTaskId = -1;
            Regarding = "General";
            Status = Activity.RunningTaskStatus.NOT_CONTACT;
            Notes = string.Empty;
        }
        ~Activity()
        {

        }
    }
}
