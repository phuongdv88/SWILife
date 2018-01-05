using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWIBLL.Models
{
    public class Role
    {
        int RoleValue { get; set; }
        enum Group
        {
            MANAGER, // admin, moderator :R,W,D,Change Permission, reset pass, ban user, change owner permission of companies and candidates, assign to user
            OPERATOR, // sale, suporter: RWD,,
            USERS, //company, ,candidate, super user, nomal user: R ( candidate info, company info, all , limitted info)
            DEACTIVATED
        }
    }
}
