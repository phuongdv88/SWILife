using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTEST.Model
{
    class JobOrder : BaseModel
    {
        public int joborderId { get; set; }
        public string Title { get; set; } // senior c++ engineer
        public string Department { get; set; }
        public string Salary { get; set; }
        public int ContactId { get; set; }
        public int CompanyId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int RecruiterId { get; set; }
        public int OwnerId { get; set; }
        public DateTime StartDate { get; set; }
        public string Duration { get; set; }
        public string MaximumRate { get; set; }
        public int Type { get; set; } //Hire, contract to hire, contract, freelane
        public int Openings { get; set; }
        public int CompanyJobId { get; set; }
        public bool IsHot { get; set; } // will be colored when show to user
        public bool isPublic { get; set; } // will show to other user
        public string Description { get; set; }
        public string InternalNotes { get; set; }
        public string AttachmentLink { get; set; }
        public int YearsOfExperiences { get; set; }
        public string Status { get; set; }
        public JobOrder()
        {

        }
        ~JobOrder()
        {

        }
    }
}
