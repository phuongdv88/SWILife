using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWIDAL;
using SWIDAL.Model;
namespace SWIBLL
{
    public class UserManager
    {
        public static User ActivatedUser = null;
        public static void connectoDB(string connection_string)
        {
            DataAccess.Instance.ConnectToDB(connection_string);
        }

        public static void closeConnectionToDB()
        {
            DataAccess.Instance.closeConnectionToDB();
        }
        public static bool login(string userName, string password)
        {
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            // get user info
            ActivatedUser = DataAccess.Instance.getDataByUserName(userName);
            // check user info
            if (ActivatedUser == null || comparer.Compare(password, ActivatedUser.Password) != 0)
            {
                Exception ex = new Exception("User name or password is incorrect!");
                throw ex;
            }
            if (ActivatedUser.IsOnline)
            {
                Exception ex = new Exception("Account is used by another user!");
                throw ex;
            }
            // if correct , update login state of user
            if (DataAccess.Instance.updateLoginState(userName, true))
            {
                ActivatedUser.IsOnline = true;
                return true;
            }
            else
                return false;
        }

        public static bool logout()
        {
            if (ActivatedUser == null) return false;
            // if correct , update login state of user
            if (DataAccess.Instance.updateLoginState(ActivatedUser.UserName, false))
            {
                ActivatedUser.IsOnline = false;
                return true;
            }
            return false;
        }
    }
}
