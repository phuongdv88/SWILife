using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWIBLL.Models
{
    public class Contact : BaseModel
    {
        public long ContactId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string ReportTo { get; set; }
        public bool isHot { get; set; }
        public string Email { get; set; }
        public string SecondaryEmail { get; set; }
        public string CellPhone { get; set; }
        public string WorkPhone { get; set; }
        public string OtherPhone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string ProfileLink { get; set; }
        public string MiscNotes { get; set; }
        public long CompanyId { get; set; }
        public string CompanyName { get; set; }
        public long UserId { get; set; }
        public string Owner { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string ImageLink { get; set; }
        public Contact()
        {
            ContactId = -1;
            ImageLink = string.Empty;
        }
        ~Contact()
        {
                
        }
    }
}
