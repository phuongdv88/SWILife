using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWIBLL.Models
{
    public class ReportHiringOverview
    {
        public string Period { get; set; } // first week day, folow monthly, yearly
        public int Submissions { get; set; } // submittion
        public int Interviews { get; set; }
        public int Hires { get; set; }
        public ReportHiringOverview(string period)
        {
            Period = period;
        }
    }
}
