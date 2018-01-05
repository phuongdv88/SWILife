using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWIBLL.Models
{
    public class JobOrder : BaseModel
    {
        public long JobOrderId { get; set; }
        public string Title { get; set; } // senior c++ engineer
        public string Department { get; set; }
        public string Salary { get; set; }
        public long ContactId { get; set; }
        public string ContactName { get; set; }
        public long CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long RecruiterId { get; set; }
        public long OwnerId { get; set; }

        public DateTime StartDate { get; set; }
        public string Duration { get; set; }
        public string Type { get; set; } //Hire, contract to hire, contract, freelane
        public int Openings { get; set; }
        public bool IsHot { get; set; } // will be colored when show to user
        public bool isPublic { get; set; } // will show to other user
        public string Description { get; set; }
        public string InternalNotes { get; set; }
        public string AttachmentLink { get; set; }
        public int ExperienceYear { get; set; }
        public string Status { get; set; }

        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string WebLink { get; set; }
        public JobOrder()
        {
            JobOrderId = -1;
            Title = string.Empty;
            Department = string.Empty;
            Salary = string.Empty;
            ContactName = string.Empty;
            CompanyName = string.Empty;
            City = string.Empty;
            State = string.Empty;
            Duration = string.Empty;
            Description = string.Empty;
            InternalNotes = string.Empty;
            AttachmentLink = string.Empty;
            Status = string.Empty;
            WebLink = string.Empty;

        }
        ~JobOrder()
        {

        }
    }
}
