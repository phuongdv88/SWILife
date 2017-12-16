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
    public class ActivityManager
    {
        /// <summary>
        /// get title and running task id to generate in regarding list and running task id
        /// </summary>
        /// <param name="id">id of candidate</param>
        /// <returns></returns>
        public static void getListRegardingForCandidate(int id, ref Dictionary<string, int> listRegarding, ref Dictionary<string, string> listRegardingStatus)
        {
            string sql = string.Format("SELECT T2.Title, T1.RunningTaskId, T1.Status FROM swilifecore.runningtask T1 Join joborder T2 on T1.JobOrderId = T2.JobOrderId Where T1.CandidateId = '{0}'", id);
            DataTable tbl = DataAccess.Instance.getTable(sql);
            for(int i = 0; i < tbl.Rows.Count; ++i)
            {
                if (!listRegarding.ContainsKey(tbl.Rows[i][0].ToString())){
                    listRegarding.Add(tbl.Rows[i][0].ToString(), int.Parse(tbl.Rows[i][1].ToString()));
                }

                if (!listRegardingStatus.ContainsKey(tbl.Rows[i][0].ToString()))
                {
                    listRegardingStatus.Add(tbl.Rows[i][0].ToString(), tbl.Rows[i][2].ToString());
                }
            }
        }

        public static bool deleteActivity(int Activityid, int ScheduleEventId)
        {
            string sql = string.Empty;
            if (ScheduleEventId != -1)
            {
                // delete scheduleEvent
                sql = string.Format("DELETE FROM `swilifecore`.`scheduleevent` WHERE `ScheduleEventId`='{0}'", ScheduleEventId);
                DataAccess.Instance.executeNonQuery(sql);

            }
            //delete activity
            sql = string.Format("DELETE FROM `swilifecore`.`activity` WHERE `ActivityId`='{0}'", Activityid);
            int result = DataAccess.Instance.executeNonQuery(sql);
            return result > 0 ? true : false;
        }

        public static bool deleteScheduleEvent(int id)
        {
            //todo:update eventId in activity
            string sql = string.Format("UPDATE `swilifecore`.`activity` SET `ScheduleEventId`='-1' WHERE `ScheduleEventId`='id'");
            DataAccess.Instance.executeNonQuery(sql);
            // delete 
            sql = string.Format("DELETE FROM `swilifecore`.`scheduleevent` WHERE `ScheduleEventId`='{0}'", id);
            int result = DataAccess.Instance.executeNonQuery(sql);
            return result > 0 ? true : false;
        }

        public static DataTable getAllActivities()
        {
            return DataAccess.Instance.getTable("select * from swilifecore.activity limmit 1,1000");
        }
        public static DataTable getActivitiesOfCandidate(int id)
        {
            string sql = string.Format("select * from swilifecore.activity where ActivityOf = '{0}' and CandidateId = '{1}'", (int)Activity.TypeOfLogActivity.Candidate, id);
            return DataAccess.Instance.getTable(sql);
        }


        public static void insert(Activity act, ScheduleEvent ev)
        {
            string sql = string.Empty;
            // insert to database by transaction
            try {
                DataAccess.Instance.StartTransaction();
                if (ev != null)
                {
                    // add schedule event
                    sql = string.Format("INSERT INTO `swilifecore`.`scheduleevent` " +
                        "(`Type`, `Title`, `DateTime`, `Duration`, `IsPublicEntry`, `Description`) " +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                        ev.Type, QueryBuilder.mySqlEscape(ev.Title), ev.DateTime.ToString("yyyy-MM-dd hh:mm"), ev.Duration, Convert.ToInt32(ev.IsPublicEntry), QueryBuilder.mySqlEscape(ev.Description));
                    act.ScheduleEventId = DataAccess.Instance.executeInsertQueryTransaction(sql);
                }

                // add log activity
                sql = string.Format("INSERT INTO `swilifecore`.`activity` " +
                    "(`Regarding`, `Type`, `Notes`, `Created`, `ActivityOf`, " +
                    "`JobOrderId`, `CandidateId`, `ContactID`, `UserId`, `ScheduleEventId`) " +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                    act.Regarding, act.Type, QueryBuilder.mySqlEscape(act.Notes), act.Created.ToString("yyyy-MM-dd hh:mm:ss"), (int)act.ActivityOf,
                    act.JobOrderId, act.CandidateId, act.ContactID, act.UserId, act.ScheduleEventId);
                DataAccess.Instance.executeInsertQueryTransaction(sql);

                // change status of running task or whatever folow by type of activity
                if(act.ActivityOf == Activity.TypeOfLogActivity.Candidate)
                {
                    // check type of status to set data in running task
                    // if type of status is submitted -> set to running task also

                    switch (act.Status)
                    {
                        case Activity.RunningTaskStatus.NOT_CONTACT:
                            RunningTaskManager.updateStatusWithTransaction("Not Contact", act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.CONTACTED:
                            RunningTaskManager.updateStatusWithTransaction("Contacted", act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.CANDIDATE_RESPONDED:
                            RunningTaskManager.updateStatusWithTransaction("Candidate Responded", act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.QUALIFYING:
                            RunningTaskManager.updateStatusWithTransaction("Qualifying", act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.SUBMITTED:
                            RunningTaskManager.updateStatusWithTransaction("Submitted", act.RunningTaskId);
                            RunningTaskManager.updateSubmittedStateWithTransaction(true, act.RunningTaskId);
                            
                            break;
                        case Activity.RunningTaskStatus.INTERVIEWING:
                            RunningTaskManager.updateStatusWithTransaction("Interviewing", act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.OFFERED:
                            RunningTaskManager.updateStatusWithTransaction("Offered", act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.NOT_IN_CONSIDERATION:
                            RunningTaskManager.updateStatusWithTransaction("Not In Consideration", act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.CLIENT_DECLINED:
                            RunningTaskManager.updateStatusWithTransaction("Client Declined", act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.PLACED:
                            RunningTaskManager.updateStatusWithTransaction("Placed", act.RunningTaskId);
                            break;
                        default:
                            break;
                    }
                }
                // commit 
                DataAccess.Instance.commitTransaction();
            }
            catch
            {
                DataAccess.Instance.rollbackTransaction();
                throw;
            }

        }
        
        public static Activity getActivityById(int id)
        {
            string sql = string.Format("select * from `swilifecore`.`activity` where `ActivityId`='{0}' ", id);
            DataTable tbl = DataAccess.Instance.getTable(sql);
            if(tbl.Rows.Count > 0)
            {
                DataRow data_row = tbl.Rows[0];
                return Data.CreateItemFromRow<Activity>(data_row);
            }
            return null;
        }

        public static ScheduleEvent getScheduleEventById(int id)
        {
            string sql = string.Format("select * from `swilifecore`.`scheduleevent` where `ScheduleEventId`='{0}' ", id);
            DataTable tbl = DataAccess.Instance.getTable(sql);
            if (tbl.Rows.Count > 0)
            {
                DataRow data_row = tbl.Rows[0];
                return Data.CreateItemFromRow<ScheduleEvent>(data_row);
            }
            return null;
        }


        public static void update(Activity act, ScheduleEvent ev)
        {
            string sql = string.Empty;
            // insert to database by transaction
            try
            {
                DataAccess.Instance.StartTransaction();
                if (ev != null)
                {
                    // check event is exist
                    if (ev.ScheduleEventId == -1)
                    {
                        // if not add schedule event
                        sql = string.Format("INSERT INTO `swilifecore`.`scheduleevent` " +
                            "(`Type`, `Title`, `DateTime`, `Duration`, `IsPublicEntry`, `Description`) " +
                            "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                            ev.Type, QueryBuilder.mySqlEscape(ev.Title), ev.DateTime.ToString("yyyy-MM-dd hh:mm"), ev.Duration, Convert.ToInt32(ev.IsPublicEntry), QueryBuilder.mySqlEscape(ev.Description));
                        act.ScheduleEventId = DataAccess.Instance.executeInsertQueryTransaction(sql);
                    }
                    else
                    {
                        // else update schedule event
                        sql = string.Format("UPDATE `swilifecore`.`scheduleevent` SET `Type`='{0}', `Title`='{1}', `DateTime`='{2}', `Duration`='{3}', `IsPublicEntry`='{4}', `Description`='{5}' WHERE `ScheduleEventId`='{6}'",
                            ev.Type, QueryBuilder.mySqlEscape(ev.Title), ev.DateTime.ToString("yyyy-MM-dd hh:mm"), ev.Duration, Convert.ToInt32(ev.IsPublicEntry), QueryBuilder.mySqlEscape(ev.Description), ev.ScheduleEventId);
                        DataAccess.Instance.executeNonQueryTransaction(sql);
                    }
                }

                // add log activity
                sql = string.Format("UPDATE `swilifecore`.`activity` SET " +
                        "`Regarding`='{0}', `Type`='{1}', `Notes`='{2}', `Created`='{3}', `ActivityOf`='{4}', `JobOrderId`='{5}', `CandidateId`='{6}', `ContactID`='{7}', `UserId`='{8}', `ScheduleEventId`='{9}'" +
                        "WHERE `ActivityId`='{10}'",
                    act.Regarding, act.Type, QueryBuilder.mySqlEscape(act.Notes), act.Created.ToString("yyyy-MM-dd hh:mm:ss"), (int)act.ActivityOf,
                    act.JobOrderId, act.CandidateId, act.ContactID, act.UserId,act.ScheduleEventId, act.ActivityId);
                DataAccess.Instance.executeNonQueryTransaction(sql);

                // change status of running task or whatever folow by type of activity
                if (act.ActivityOf == Activity.TypeOfLogActivity.Candidate)
                {
                    // check type of status to set data in running task
                    // if type of status is submitted -> set to running task also

                    switch (act.Status)
                    {
                        case Activity.RunningTaskStatus.NOT_CONTACT:
                            RunningTaskManager.updateStatusWithTransaction("Not Contact", act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.CONTACTED:
                            RunningTaskManager.updateStatusWithTransaction("Contacted", act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.CANDIDATE_RESPONDED:
                            RunningTaskManager.updateStatusWithTransaction("Candidate Responded", act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.QUALIFYING:
                            RunningTaskManager.updateStatusWithTransaction("Qualifying", act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.SUBMITTED:
                            RunningTaskManager.updateStatusWithTransaction("Submitted", act.RunningTaskId);
                            RunningTaskManager.updateSubmittedStateWithTransaction(true, act.RunningTaskId);

                            break;
                        case Activity.RunningTaskStatus.INTERVIEWING:
                            RunningTaskManager.updateStatusWithTransaction("Interviewing", act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.OFFERED:
                            RunningTaskManager.updateStatusWithTransaction("Offered", act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.NOT_IN_CONSIDERATION:
                            RunningTaskManager.updateStatusWithTransaction("Not In Consideration", act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.CLIENT_DECLINED:
                            RunningTaskManager.updateStatusWithTransaction("Client Declined", act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.PLACED:
                            RunningTaskManager.updateStatusWithTransaction("Placed", act.RunningTaskId);
                            break;
                        default:
                            break;
                    }
                }
                // commit 
                DataAccess.Instance.commitTransaction();
            }
            catch
            {
                DataAccess.Instance.rollbackTransaction();
                throw;
            }

        }
    }
}
