using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTEST.Model
{
    class Activity : BaseModel
    {
        public int ActivityId { get; set; }
        public int Regarding { get; set; }  //General, job order1, job order2...
        //public int Status { get; set; } // each of job order have different status: no contact, contacted, candidate responded, qualifying, submitted, interviewing, offered, not in consideration, client declined, placed.
        public int Type { get; set; } // Call, Call(talked), Message,CV Submitted, e-mail, meeting, other
        public string Notes { get; set; }

        public DateTime DateTime { get; set; }
        public int ActivityOf { get; set; } // job order, contact, company, running task, candidate,
        public int JobOrderId { get; set; }
        public int CandidateId { get; set; }
        public int ContactID { get; set; }
        public int UserId { get; set; }

        public Activity()
        {

        }
        ~Activity()
        {

        }
    }
}
