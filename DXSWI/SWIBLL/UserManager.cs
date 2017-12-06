using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWIDAL;
using SWIBLL.Models;
using MySql.Data.MySqlClient;

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
        public static bool login(string userName, string password, ref int index, ref int role)
        {
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            // get user info
            //ActivatedUser = DataAccess.Instance.getDataByUserName(userName);
            //User user_info = null;
            ActivatedUser = null;
            try
            {
                MySqlDataReader reader = DataAccess.Instance.getDataByUserName(userName);
                if (reader.Read())
                {
                    //string temp = string.Format("{0} {1} {2} {3} {4} {5}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                    ActivatedUser = new User()
                    {
                        Index = int.Parse(reader[0].ToString()),
                        UserName = reader[1].ToString(),
                        Password = reader[2].ToString(),
                        Salt = reader[3].ToString(),
                        Role = (User.UserRole)int.Parse(reader[4].ToString()),
                        IsOnline = Convert.ToBoolean(int.Parse(reader[5].ToString()))
                    };
                }

                reader.Dispose();
            }
            catch
            {
                throw;
            }
            // check user info
            if (ActivatedUser == null || comparer.Compare(password, ActivatedUser.Password) != 0)
            {
                Exception ex = new Exception("User name or password is incorrect!");
                throw ex;
            }
            //if (ActivatedUser.IsOnline)
            //{
            //    Exception ex = new Exception("Account is used by another user!");
            //    throw ex;
            //}
            // if correct , update login state of user
            DataAccess.Instance.updateLoginState(userName, true);
            ActivatedUser.IsOnline = true;

            // save to property.setting
            role = (int)ActivatedUser.Role;
            index = ActivatedUser.Index;


            return true;
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

        public static string getUserName(int id)
        {
            string userName = DataAccess.Instance.getUserName(id);
            return userName;
        }

    }
}
