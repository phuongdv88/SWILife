using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWIDAL;
using SWIBLL.Models;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Drawing;

namespace SWIBLL
{
    public class UserManager
    {
        public static User ActivatedUser = null;
        //public static User ActivatedUser = new User() { UserName = "phuongdv", UserId = 5, IsOnline = true};
        public static void ConnectoDB(string connection_string)
        {
            DataAccess.Instance.ConnectToDB(connection_string);
        }

        public static void CloseConnectionToDB()
        {
            DataAccess.Instance.closeConnectionToDB();
        }
        public static bool Login(string userName, string password)
        {
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            // get user info
            ActivatedUser = getUserByName(userName);
            // check user info
            if (ActivatedUser == null || comparer.Compare(password, ActivatedUser.Password) != 0 || ActivatedUser.Role >= 6) // >=6 : deactivate
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
            DataAccess.Instance.updateLoginState(ActivatedUser.UserId, true);
            ActivatedUser.IsOnline = true;
            return true;
        }

        public static bool Logout()
        {
            if (ActivatedUser == null) return false;
            // if correct , update login state of user
            if (DataAccess.Instance.updateLoginState(ActivatedUser.UserId, false))
            {
                ActivatedUser.IsOnline = false;
                return true;
            }
            return false;
        }

        public static string GetSaltByUserName(string userName)
        {
            string sql = string.Format("select salt from swilifecore.user where UserName = '{0}'", QueryBuilder.mySqlEscape(userName));
            return DataAccess.Instance.executeScalar(sql)?.ToString();
        }

        public static User GetUser(long UserId)
        {
            User user = null;
            string sql = string.Format("select * from swilifecore.user T1 left join userrole T2 on T1.Role = T2.RoleId where UserId = '{0}'", UserId);
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            if (tbl.Rows.Count > 0)
            {
                DataRow datarow = tbl.Rows[0];
                user = Data.CreateItemFromRow<User>(datarow);
            }
            return user;
        }

        public static void DeleteUser(long UserId)
        {
            string sql = string.Format("DELETE FROM `swilifecore`.`user` WHERE `UserId`='{0}'", UserId);
            DataAccess.Instance.executeNonQuery(sql);
        }

        public static DataTable GetAllUsers()
        {
            string sql = "select T1.UserId, T1.UserName, T1.Password, T1.IsOnline,T1.LastLogin, T2.RoleName, T2.RoleValue from swilifecore.user T1 left join userrole T2 on T1.Role = T2.RoleId order by UserId";
            return DataAccess.Instance.getDataTable(sql);
        }

        public static string createMD5Hash(string input_string)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash_bytes = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(input_string));
                //convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash_bytes.Length; ++i)
                {
                    sb.Append(hash_bytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static bool verifyMd5Hash(string input, string hash)
        {
            string hashOfInput = createMD5Hash(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            return false;

        }

        public static void UpdateUser(User user)
        {
            if (user == null) return;
            string sql = string.Format("UPDATE `swilifecore`.`user` SET `UserName`='{0}', `Password`='{1}', `Salt`='{2}', `Role`='{3}', `EmailAccount`='{4}' WHERE `UserId`='{5}'"
                , QueryBuilder.mySqlEscape(user.UserName), user.Password, user.Salt, user.Role, QueryBuilder.mySqlEscape(user.EmailAccount), user.UserId);
            DataAccess.Instance.executeNonQuery(sql);
        }

        public static void InsertUser(User user)
        {
            if (user == null) return;
            string sql = string.Format("INSERT INTO `swilifecore`.`user` (`UserName`, `Password`, `Salt`, `Role`, `IsOnline`, `EmailAccount`) VALUES ('{0}', '{1}', '{2}', '{3}', 0, '{4}')"
                , QueryBuilder.mySqlEscape(user.UserName), user.Password, user.Salt, user.Role, QueryBuilder.mySqlEscape(user.EmailAccount));
            DataAccess.Instance.executeNonQuery(sql);

        }


        public static User getUserByName(string userName)
        {
            User user = null;
            string sql = string.Format("select * from swilifecore.user T1 left join userrole T2 on T1.Role = T2.RoleId where UserName = '{0}'", userName);
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            if (tbl.Rows.Count > 0)
            {
                DataRow datarow = tbl.Rows[0];
                user = Data.CreateItemFromRow<User>(datarow);
            }
            return user;
        }

        public static void GetListResource(BindingList<CustomResource> listResource)
        {
            Random rand = new Random();
            string sql = string.Format("select UserId, UserName from swilifecore.user order by UserId");
            var tbl = DataAccess.Instance.getDataTable(sql);
            for (int i = 0; i < tbl.Rows.Count; ++i)
            {
                var data_row = tbl.Rows[i];
                Color col = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                listResource.Add(new CustomResource() {ResId = Convert.ToInt32(data_row[0].ToString()),
                Name = data_row[1].ToString(), ResColor = col});
            }
        }

        public static DataTable getReportByMonth()
        {
            DataTable tbl = new DataTable("Report");
            List<DateTime> theLast4FirstDayOfMonthAndNow = new List<DateTime>();
            var today = DateTime.Today;
            theLast4FirstDayOfMonthAndNow.Add(today); // add today
            // add last 4 firt days of month
            int offset = 0;
            if (today.Day == 1)
            {
                offset = 1;
            }
            for (var i = 0; i < 4; i++)
            {
                int month = today.Month - 1 * (i + offset);
                int year = today.Year;
                if (month <= 0)
                {
                    month += 12;
                    year -= 1;
                }
                theLast4FirstDayOfMonthAndNow.Add(new DateTime(year, month, 1));
            }
            // this month:
            string monthName = string.Empty;
            tbl.Columns.Add(new DataColumn("Month", typeof(string)));
            tbl.Columns.Add(new DataColumn("NumberJobOrder", typeof(Int32)));
            tbl.Columns.Add(new DataColumn("NumberCandidate", typeof(Int32)));
            tbl.Columns.Add(new DataColumn("NumberCompany", typeof(Int32)));
            tbl.Columns.Add(new DataColumn("NumberSubmission", typeof(Int32)));
            tbl.Columns.Add(new DataColumn("NumberPlacement", typeof(Int32)));
            tbl.Columns.Add(new DataColumn("NumberContact", typeof(Int32)));

            theLast4FirstDayOfMonthAndNow.Reverse();

            for (var i = 0; i < theLast4FirstDayOfMonthAndNow.Count() - 1; ++i)
            {
                monthName = theLast4FirstDayOfMonthAndNow[i].ToString("MMMM - yyyy");
                DataTable dt = DataAccess.Instance.getReportByTime(theLast4FirstDayOfMonthAndNow[i], theLast4FirstDayOfMonthAndNow[i + 1]);
                DataRow row = dt.Rows[0];
                tbl.Rows.Add(monthName, row["NumberJobOrder"], row["NumberCandidate"], row["NumberCompany"], row["NumberSubmission"], row["NumberPlacement"], row["NumberContact"]);
            }
            return tbl;
        }
        public static DataTable getReportUserIn30Days()
        {
            return DataAccess.Instance.getReportUserIn30Days();
        }


    }
}
