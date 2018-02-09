using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SWIDAL;
using SWIBLL.Models;

namespace SWIBLL
{
    public class ContactManager
    {
        public static DataTable getContacts()
        {
            string sql = string.Format("SELECT T1.ContactId, T1.FirstName, T1.LastName, T2.Name as CompanyName, T1.CellPhone, T1.Email, T1.Title, T1.Modified, T1.MiscNotes,  T3.UserName as Owner FROM swilifecore.contact T1 " +
                                        "left join swilifecore.company T2 on T1.CompanyId = T2.CompanyId " +
                                        "left join swilifecore.user T3 on T1.UserId = T3.UserId  order by ContactId desc");
            return DataAccess.Instance.getDataTable(sql);
        }

        public static DataTable getContactsNameByCompanyId(long comId)
        {
            string sql = string.Format("select ContactId, concat(ifnull(FirstName,''), ifnull(MiddleName,''), ifnull(LastName,'')) as ContactName from swilifecore.contact where CompanyId = '{0}'", comId);
            return DataAccess.Instance.getDataTable(sql);
        }

        public static Contact getContactById(long contactId)
        {
            if (contactId < 0) return null;
            string sql = string.Format("SELECT T1.*, T2.Name as CompanyName, T3.UserName as Owner FROM swilifecore.contact T1 " +
                                        "left join swilifecore.company T2 on T1.CompanyId = T2.CompanyId " +
                                        "left join swilifecore.user T3 on T1.UserId = T3.UserId where T1.ContactId = '{0}'", contactId);
            DataTable tbl =  DataAccess.Instance.getDataTable(sql);
            Contact con = null;
            if (tbl.Rows.Count > 0)
            {
                DataRow datarow = tbl.Rows[0];
                con = Data.CreateItemFromRow<Contact>(datarow);
            }
            return con;
        }

        public static bool IsContactExisted(Contact con)
        {
            // check duplicate:
            string sql = string.Format("select count(*) from swilifecore.contact where (char_length(CellPhone) > 0 and CellPhone = '{0}') or (char_length(Email) > 0 and Email = '{1}') or (char_length(WorkPhone) > 0 and WorkPhone = '{2}')",
                QueryBuilder.mySqlEscape(con.CellPhone), QueryBuilder.mySqlEscape(con.Email), QueryBuilder.mySqlEscape(con.WorkPhone));
            MySql.Data.MySqlClient.MySqlDataReader reader = DataAccess.Instance.getReader(sql);
            try
            {
                while (reader.Read())
                {
                    if (int.Parse(reader[0].ToString()) > 0)
                    {
                        return true;
                    }
                    break;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                reader.Dispose();
            }
            return false;
        }
        public static void InsertContact(Contact con)
        {
           
           string sql = string.Format("INSERT INTO `swilifecore`.`contact` " +
                "(`FirstName`, `MiddleName`, `LastName`, `Title`, `Department`, `ReportTo`, `isHot`, `Email`, " +
                "`SecondaryEmail`, `CellPhone`, `WorkPhone`, `OtherPhone`, `Address`, `City`, `State`, `PostalCode`, " +
                "`ProfileLink`, `MiscNotes`, `CompanyId`, `UserId`, `Created`, `Modified`, `ImageLink`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', " +
                "'{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', now(), now(), '{20}')",
                QueryBuilder.mySqlEscape(con.FirstName), QueryBuilder.mySqlEscape(con.MiddleName), QueryBuilder.mySqlEscape(con.LastName), 
                QueryBuilder.mySqlEscape(con.Title), QueryBuilder.mySqlEscape(con.Department), QueryBuilder.mySqlEscape(con.ReportTo), 
                Convert.ToInt32(con.isHot), QueryBuilder.mySqlEscape(con.Email), QueryBuilder.mySqlEscape(con.SecondaryEmail), QueryBuilder.mySqlEscape(con.CellPhone), 
                QueryBuilder.mySqlEscape(con.WorkPhone), QueryBuilder.mySqlEscape(con.OtherPhone), QueryBuilder.mySqlEscape(con.Address), 
                QueryBuilder.mySqlEscape(con.City), QueryBuilder.mySqlEscape(con.State), QueryBuilder.mySqlEscape(con.PostalCode), 
                QueryBuilder.mySqlEscape(con.ProfileLink), QueryBuilder.mySqlEscape(con.MiscNotes), con.CompanyId, con.UserId, QueryBuilder.mySqlEscape(con.ImageLink));

            long contact_id = DataAccess.Instance.executeInsertingQuery(sql);

            Activity act = new Activity()
            {
                Type = "Insert new Contact",
                ActivityOf = Activity.TypeOfLogActivity.Contact,
                ContactId = contact_id,
            };

            ActivityManager.insert(act);
        }

        public static void UpdateContact(Contact con)
        {
            string sql = string.Format("UPDATE `swilifecore`.`contact` SET `FirstName`='{0}', `MiddleName` = '{1}', `LastName`='{2}', `Title`='{3}', `Department`='{4}', " +
                "`ReportTo`='{5}', `isHot`='{6}', `Email`='{7}', `SecondaryEmail`='{8}', `CellPhone`='{9}', `WorkPhone`='{10}', `OtherPhone`='{11}', `Address`='{12}', `City`='{13}', " +
                "`State`='{14}', `PostalCode`='{15}', `ProfileLink`='{16}', `MiscNotes`='{17}', `CompanyId`='{18}', `UserId`='{19}', `Modified`=now(), `ImageLink`='{20}' " +
                "WHERE `ContactId`='{21}'",
                QueryBuilder.mySqlEscape(con.FirstName), QueryBuilder.mySqlEscape(con.MiddleName), QueryBuilder.mySqlEscape(con.LastName), QueryBuilder.mySqlEscape(con.Title), 
                QueryBuilder.mySqlEscape(con.Department), QueryBuilder.mySqlEscape(con.ReportTo), Convert.ToInt32(con.isHot), QueryBuilder.mySqlEscape(con.Email), 
                QueryBuilder.mySqlEscape(con.SecondaryEmail), QueryBuilder.mySqlEscape(con.CellPhone), QueryBuilder.mySqlEscape(con.WorkPhone), QueryBuilder.mySqlEscape(con.OtherPhone), 
                QueryBuilder.mySqlEscape(con.Address), QueryBuilder.mySqlEscape(con.City), QueryBuilder.mySqlEscape(con.State), QueryBuilder.mySqlEscape(con.PostalCode), 
                QueryBuilder.mySqlEscape(con.ProfileLink), QueryBuilder.mySqlEscape(con.MiscNotes), con.CompanyId, con.UserId, QueryBuilder.mySqlEscape(con.ImageLink), con.ContactId);
            DataAccess.Instance.executeNonQuery(sql);

            Activity act = new Activity()
            {
                Type = "Update Contact",
                ActivityOf = Activity.TypeOfLogActivity.Contact,
                ContactId = con.ContactId,
            };

            ActivityManager.insert(act);
        }

        public static void DeleteContact(long conId)
        {
            string sql = string.Format("DELETE FROM `swilifecore`.`contact` WHERE `ContactId`='{0}'", conId);
            DataAccess.Instance.executeNonQuery(sql);

            Activity act = new Activity()
            {
                Type = "Delete Contact",
                ActivityOf = Activity.TypeOfLogActivity.Contact,
                ContactId = conId,
            };

            ActivityManager.insert(act);
        }
    }
}
