using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWIBLL.Models
{
    public class RunningTask :BaseModel
    {
        public int RunningtaskId { get; set; }
        public int CandidateId { get; set; }
        public int JobOrderId { get; set; }
        public string Status { get; set; } // each of job order have different status: no contact, contacted, candidate responded, qualifying, submitted, interviewing, offered, not in consideration, client declined, placed.
        public int Match { get; set; }

        public DateTime Added { get; set; }
        public string EnteredBy { get; set; }
        public bool isSubmitted { get; set; }

        public RunningTask()
        {

        }
        ~RunningTask()
        {

        }
    }

}
