using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWIBLL.Models
{
    public class ReportJobOrder
    {
        public string StepName { get; set; } // Total pipeline, Contacted, Cand replied, Qualifying, Submitted, interviewing, Offered, Declined, Placed
        public int Value { get; set; }
        public ReportJobOrder(string stepName, int value)
        {
            StepName = stepName;
            Value = value;
        }
    }
}
