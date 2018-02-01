using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWIDAL;
using SWIBLL.Models;
using System.Data;


namespace SWIBLL
{
    public class AppointmentManager
    {
        public static DataTable GetAppointment()
        {
            string sql = string.Format("SELECT * FROM swilifecore.appointment order by AppointmentId desc limit 1000");
            return DataAccess.Instance.getDataTable(sql);
        }

        public static AppointmentObject GetAppointmentId(int apId)
        {
            if (apId < 0) return null;
            string sql = string.Format("SELECT * FROM swilifecore.appointment where AppointmentId = '{0}'", apId);
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            AppointmentObject ap = null;
            if (tbl.Rows.Count > 0)
            {
                DataRow datarow = tbl.Rows[0];
                ap = Data.CreateItemFromRow<AppointmentObject>(datarow);
            }
            return ap;
        }

        public static void InsertAppointment(AppointmentObject ap)
        {
            string sql = string.Format("INSERT INTO `swilifecore`.`appointment` (`Type`, `StartDate`, `EndDate`, `AllDay`, `Subject`, `Location`, `Description`, `Status`, `Label`, `ResourceID`, `ResourceIDs`, `ReminderInfo`, `RecurrenceInfo`, `TimeZoneId`, `CustomField`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}'))",
                ap.Type, ap.StartDate.ToString("yyyy-MM-dd hh:mm:ss"), ap.EndDate.ToString("yyyy-MM-dd hh:mm:ss"), Convert.ToInt16(ap.AllDay), QueryBuilder.mySqlEscape(ap.Subject),
                QueryBuilder.mySqlEscape(ap.Location), QueryBuilder.mySqlEscape(ap.Description), ap.Status, ap.Label, ap.ResourceID,
                QueryBuilder.mySqlEscape(ap.ResourceIDs), QueryBuilder.mySqlEscape(ap.ReminderInfo), QueryBuilder.mySqlEscape(ap.RecurrenceInfo),
                QueryBuilder.mySqlEscape(ap.TimeZoneId), QueryBuilder.mySqlEscape(ap.CustomField));
            DataAccess.Instance.executeNonQuery(sql);
        }

        public static void UpdateAppointment(AppointmentObject ap)
        {
            string sql = string.Format("UPDATE `swilifecore`.`appointment` SET `Type`='{0}', `StartDate`='{1}', `EndDate`='{2}', `AllDay`='{3}', `Subject`='{4}', `Location`='{5}', `Description`='{6}', `Status`='{7}', `Label`='{8}', `ResourceID`='{9}', `ResourceIDs`='{10}', `ReminderInfo`='{11}', `RecurrenceInfo`='{12}', `TimeZoneId`='{13}', `CustomField`='{14}' WHERE `AppointmentId`='{15}';'",
                ap.Type, ap.StartDate.ToString("yyyy-MM-dd hh:mm:ss"), ap.EndDate.ToString("yyyy-MM-dd hh:mm:ss"), Convert.ToInt16(ap.AllDay), QueryBuilder.mySqlEscape(ap.Subject),
                QueryBuilder.mySqlEscape(ap.Location), QueryBuilder.mySqlEscape(ap.Description), ap.Status, ap.Label, ap.ResourceID,
                QueryBuilder.mySqlEscape(ap.ResourceIDs), QueryBuilder.mySqlEscape(ap.ReminderInfo), QueryBuilder.mySqlEscape(ap.RecurrenceInfo),
                QueryBuilder.mySqlEscape(ap.TimeZoneId), QueryBuilder.mySqlEscape(ap.CustomField), ap.AppointmentId);
            DataAccess.Instance.executeNonQuery(sql);
        }

        public static void DeleteAppointment(int apId)
        {
            string sql = string.Format("DELETE FROM `swilifecore`.`appointment` WHERE `AppointmentId`='{0}';", apId);
            DataAccess.Instance.executeNonQuery(sql);
        }
    }
}
