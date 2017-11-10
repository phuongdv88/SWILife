using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTEST.Model
{
    class Candidate
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string SecondaryEmail { get; set; }
        public string SkypeIM { get; set; }
        public string CellPhone { get; set; }
        public string WorkPhone { get; set; }
        public string BestTimeToCall { get; set; }
        public string Address { get; set; }
        public string WebSite { get; set; }
        public string Source { get; set; } // linkedin, referral, apply directly, vietnamwork, other
        public string CurrentPosition { get; set; }
        public DateTime DateAvailable { get; set; }
        public string CurrentEmployer { get; set; }
        public string KeySkills { get; set; }
        public bool CanRelocate { get; set; }
        public string CurrentPay { get; set; }
        public string DesiredPay { get; set; }
        public string DOBMarried { get; set; }
        public string InterviewNotes { get; set; }
        public string Gender { get; set; }
        public string MiscNotes { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ResumeLink { get; set; }
        public string PositionsUpTillNow { get; set; }
        public int Years { get; set; }
        public string ProjectDone { get; set; }
        public string Industry { get; set; }
        public string Education { get; set; }
        public string Language { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedId { get; set; }

        public bool IsInBlacklist { get; set; }
        //Listed all candidates with bad / unprofessional attitude , behaviors.
        //We will not delete those candidates from ATS, but keep to mornitor them and refrain from approaching them again.
        //This much time saving when we not spend time/efforts with those.
        public int UserId { get; set; }
        public Candidate()
        {

        }

        ~Candidate()
        {

        }
    }
}
