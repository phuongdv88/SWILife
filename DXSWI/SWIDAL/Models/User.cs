using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SWIDAL.Model
{
    public class User : BaseModel
    {
        public int Index { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public bool IsOnline { get; set; }
        public enum UserRole
        {
            ROLE_ADMIN = 0, // ADD, MODIFY, DELETE DB
            ROLE_MANAGER = 1, // VIEW ONLY
            ROLE_SALE = 2,
            ROLE_SUPPORTER = 3,
            ROLE_COMPANY = 4,
            ROLE_CANDIDATE = 5,
            ROLE_DEACTIVE = 6,

        }

        public UserRole Role { get; set; }

        public User()
        {

        }
        ~User()
        {
                
        }
    }
}
