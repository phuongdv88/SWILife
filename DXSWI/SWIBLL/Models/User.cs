using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SWIBLL.Models
{
    public class User : BaseModel
    {
        public long UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public bool IsOnline { get; set; }

        public int Role { get; set; }

        public string RoleName { get; set; }

        public int RoleValue { get; set; }
        public User()
        {
            UserId = -1;
            UserName = string.Empty;
            Password = string.Empty;
            Salt = string.Empty;
            IsOnline = false;
            Role = -1;
            RoleName = string.Empty;
            RoleValue = -1;
        }
        ~User()
        {

        }
    }
}
