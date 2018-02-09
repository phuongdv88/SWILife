using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWIDAL;
using SWIBLL.Models;
using System.Data;
using System.ComponentModel;

namespace SWIBLL
{
    public class AppointmentManager
    {
        public static void GetListAppointment(BindingList<CustomAppointment> listEvent)
        {
            string sql = string.Format("SELECT * FROM swilifecore.appointment order by AppointmentId desc limit 1000");
            var tbl = DataAccess.Instance.getDataTable(sql);
            for(int i = 0; i < tbl.Rows.Count; ++i)
            {
                var data_row = tbl.Rows[i];
                var ap = Data.CreateItemFromRow<CustomAppointment>(data_row);
                if(data_row["ResourceId"].ToString() == "-1")
                {
                    ap.ResourceId = null;
                }
                listEvent.Add(ap);
            }
        }

        public static void GetListAppointment(long userId, BindingList<CustomAppointment> listEvent)
        {
            string sql = string.Format("SELECT * FROM swilifecore.appointment where ResourceId = -1 or ResourceId = '{0}' order by AppointmentId desc", userId);
            var tbl = DataAccess.Instance.getDataTable(sql);
            for (int i = 0; i < tbl.Rows.Count; ++i)
            {
                var data_row = tbl.Rows[i];
                var ap = Data.CreateItemFromRow<CustomAppointment>(data_row);
                if (data_row["ResourceId"].ToString() == "-1")
                {
                    ap.ResourceId = null;
                } else
                {
                    ap.ResourceId = Convert.ToInt64(data_row["ResourceId"].ToString());
                }
                listEvent.Add(ap);
            }
        }
        public static void InsertAppointment(CustomAppointment ap)
        {
            int resourceId;
            if(!int.TryParse(ap.ResourceId.ToString(), out resourceId))
            {
                resourceId = -1;
            }
            string sql = string.Format("INSERT INTO `swilifecore`.`appointment` (`Type`, `StartTime`, `EndTime`, `AllDay`, `Subject`, `Location`, `Description`, `Status`, `Label`, `ResourceId`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                ap.Type, ap.StartTime.ToString("yyyy-MM-dd HH:mm:ss"), ap.EndTime.ToString("yyyy-MM-dd HH:mm:ss"), Convert.ToInt16(ap.AllDay), QueryBuilder.mySqlEscape(ap.Subject),
                QueryBuilder.mySqlEscape(ap.Location), QueryBuilder.mySqlEscape(ap.Description), ap.Status, ap.Label, resourceId);
            DataAccess.Instance.executeNonQuery(sql);
        }

        public static void UpdateAppointment(CustomAppointment ap)
        {
            int resourceId;
            if (!int.TryParse(ap.ResourceId.ToString(), out resourceId))
            {
                resourceId = -1;
            }
            string sql = string.Format("UPDATE `swilifecore`.`appointment` SET `Type`='{0}', `StartTime`='{1}', `EndTime`='{2}', `AllDay`='{3}', `Subject`='{4}', `Location`='{5}', `Description`='{6}', `Status`='{7}', `Label`='{8}', `ResourceId`='{9}' WHERE `AppointmentId`='{10}'",
                ap.Type, ap.StartTime.ToString("yyyy-MM-dd HH:mm:ss"), ap.EndTime.ToString("yyyy-MM-dd HH:mm:ss"), Convert.ToInt16(ap.AllDay), QueryBuilder.mySqlEscape(ap.Subject),
                QueryBuilder.mySqlEscape(ap.Location), QueryBuilder.mySqlEscape(ap.Description), ap.Status, ap.Label, resourceId, ap.AppointmentId);
            DataAccess.Instance.executeNonQuery(sql);
        }

        public static void DeleteAppointment(long apId)
        {
            string sql = string.Format("DELETE FROM `swilifecore`.`appointment` WHERE `AppointmentId`='{0}';", apId);
            DataAccess.Instance.executeNonQuery(sql);
        }
    }
}
