using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWIBLL.Models
{
    public class Contact : BaseModel
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Tittle { get; set; }
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
        public int CompanyId { get; set; }
        public int UserId { get; set; }
        public Contact()
        {

        }
        ~Contact()
        {
                
        }
    }
}
