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
        public static void getListRegardingForCandidate(long id, ref Dictionary<string, long> listRegarding, ref Dictionary<string, string> listRegardingStatus)
        {
            string sql = string.Format("SELECT T2.Title, T1.RunningTaskId, T1.Status " +
                "FROM swilifecore.runningtask T1 Join joborder T2 on T1.JobOrderId = T2.JobOrderId " +
                "Where T1.CandidateId = '{0}'", id);
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            for (int i = 0; i < tbl.Rows.Count; ++i)
            {
                if (!listRegarding.ContainsKey(tbl.Rows[i][0].ToString()))
                {
                    listRegarding.Add(tbl.Rows[i][0].ToString(), int.Parse(tbl.Rows[i][1].ToString()));
                }

                if (!listRegardingStatus.ContainsKey(tbl.Rows[i][0].ToString()))
                {
                    listRegardingStatus.Add(tbl.Rows[i][0].ToString(), tbl.Rows[i][2].ToString());
                }
            }
        }
        public static void getListRegardingForContact(long contactId, ref Dictionary<string, long> listRegarding)
        {
            string sql = string.Format("SELECT T2.Title, T2.JobOrderId FROM swilifecore.contact T1 " +
                                        "left join swilifecore.joborder T2 on T1.CompanyId = T2.CompanyId "+
                                        "where T1.ContactId = {0}", contactId);
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            for (int i = 0; i < tbl.Rows.Count; ++i)
            {
                if (tbl.Rows[i][0] != null && tbl.Rows[i][1] != null && tbl.Rows[i][1].ToString().Length > 0)
                {
                    if (!listRegarding.ContainsKey(tbl.Rows[i][0].ToString()))
                    {
                        listRegarding.Add(tbl.Rows[i][0].ToString(), Convert.ToInt64(tbl.Rows[i][1].ToString()));
                    }
                }
            }
        }

        public static void getListRunningTaskForJobOrder(long jobOrderId, ref Dictionary<long, long> listCandidateRunningTaskId)
        {
            string sql = string.Format("SELECT CandidateId, RunningTaskId FROM swilifecore.runningtask where JobOrderId = {0}", jobOrderId);
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            for (int i = 0; i < tbl.Rows.Count; ++i)
            {
                long canId = Convert.ToInt64(tbl.Rows[i][0].ToString());
                if (!listCandidateRunningTaskId.ContainsKey(canId))
                {
                    listCandidateRunningTaskId.Add(canId, Convert.ToInt64(tbl.Rows[i][1].ToString()));
                }
            }
        }

        public static void deleteActivity(long Activityid)
        {
            string sql = string.Empty;
            try
            {
                DataAccess.Instance.StartTransaction();
                //delete activity
                sql = string.Format("DELETE FROM `swilifecore`.`activity` WHERE `ActivityId`='{0}'", Activityid);
                DataAccess.Instance.executeNonQueryTransaction(sql);

                DataAccess.Instance.commitTransaction();
            }
            catch
            {
                DataAccess.Instance.rollbackTransaction();
                throw;
            }
        }

        public static DataTable getAllActivities()
        {
            return DataAccess.Instance.getDataTable("select T1.ActivityId, T1.Regarding, T1.Type, date_format(T1.Created,'%d/%m/%Y %T') as Created, T2.UserName from swilifecore.activity T1 left join swilifecore.user T2 on T1.UserId = T2.UserId order by T1.ActivityId desc limit 1,1000");
        }
        public static DataTable getActivitiesOfCandidate(long id)
        {
            string sql = string.Format("select T1.ActivityId, T1.Regarding, T1.Type, T1.Notes, date_format(T1.Created,'%d/%m/%Y %T') as Created, T2.UserName from swilifecore.activity T1 left join swilifecore.user T2 on T1.UserId = T2.UserId where CandidateId = '{0}' order by T1.ActivityId desc;", id);
            return DataAccess.Instance.getDataTable(sql);
        }
        public static DataTable getActivitiesOfContact(long id)
        {
            string sql = string.Format("select T1.ActivityId, T1.Regarding, T1.Type, T1.Notes, date_format(T1.Created,'%d/%m/%Y %T') as Created, T2.UserName from swilifecore.activity T1 left join swilifecore.user T2 on T1.UserId = T2.UserId where ContactId = '{0}' order by T1.ActivityId desc;", id);
            return DataAccess.Instance.getDataTable(sql);
        }


        public static void insert(Activity act)
        {
            string sql = string.Empty;
            // insert to database by transaction
            try
            {
                DataAccess.Instance.StartTransaction();
                act.UserId = UserManager.ActivatedUser.UserId;
                // add log activity
                sql = string.Format("INSERT INTO `swilifecore`.`activity` " +
                    "(`Regarding`, `Type`, `Notes`, `Created`, `ActivityOf`, " +
                    "`JobOrderId`, `CandidateId`, `ContactID`, `UserId`, `RunningTaskId`) " +
                    "VALUES ('{0}', '{1}', '{2}', now(), '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                    act.Regarding, act.Type, QueryBuilder.mySqlEscape(act.Notes), (int)act.ActivityOf,
                    act.JobOrderId, act.CandidateId, act.ContactId, act.UserId, act.RunningTaskId);
                DataAccess.Instance.executeInsertQueryTransaction(sql);

                // change status of running task or whatever folow by type of activity
                if (act.ActivityOf == Activity.TypeOfLogActivity.Pipeline)
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
                            RunningTaskManager.updateSubmittedStateWithTransaction(true, act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.OFFERED:
                            RunningTaskManager.updateStatusWithTransaction("Offered", act.RunningTaskId);
                            RunningTaskManager.updateSubmittedStateWithTransaction(true, act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.NOT_IN_CONSIDERATION:
                            RunningTaskManager.updateStatusWithTransaction("Not In Consideration", act.RunningTaskId);
                            RunningTaskManager.updateSubmittedStateWithTransaction(true, act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.CLIENT_DECLINED:
                            RunningTaskManager.updateStatusWithTransaction("Client Declined", act.RunningTaskId);
                            RunningTaskManager.updateSubmittedStateWithTransaction(true, act.RunningTaskId);
                            break;
                        case Activity.RunningTaskStatus.PLACED:
                            RunningTaskManager.updateStatusWithTransaction("Placed", act.RunningTaskId);
                            RunningTaskManager.updateSubmittedStateWithTransaction(true, act.RunningTaskId);
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

        public static void insertMultiActionForCandidates(Activity act, long jobOrderId, List<long> listCandidateId)
        {
            string sql = string.Empty;
            // insert to database by transaction
            try
            {
                DataAccess.Instance.StartTransaction();
                act.UserId = UserManager.ActivatedUser.UserId;
                Dictionary<long, long> listCandidateIdRunningTaskId = new Dictionary<long, long>();
                getListRunningTaskForJobOrder(jobOrderId, ref listCandidateIdRunningTaskId);
                // add log activity
                foreach (long canId in listCandidateId)
                {
                    if (listCandidateIdRunningTaskId.ContainsKey(canId))
                    {
                        long runningTaskId = listCandidateIdRunningTaskId[canId];
                        sql = string.Format("INSERT INTO `swilifecore`.`activity` " +
                            "(`Regarding`, `Type`, `Notes`, `Created`, `ActivityOf`, " +
                            "`JobOrderId`, `CandidateId`, `ContactID`, `UserId`, `RunningTaskId`) " +
                            "VALUES ('{0}', '{1}', '{2}', now(), '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                            act.Regarding, act.Type, QueryBuilder.mySqlEscape(act.Notes), (int)Activity.TypeOfLogActivity.Pipeline,
                            jobOrderId, canId, act.ContactId, act.UserId, runningTaskId);
                        DataAccess.Instance.executeInsertQueryTransaction(sql);

                        // check type of status to set data in running task
                        // if type of status is submitted -> set to running task also

                        switch (act.Status)
                        {
                            case Activity.RunningTaskStatus.NOT_CONTACT:
                                RunningTaskManager.updateStatusWithTransaction("Not Contact", runningTaskId);
                                break;
                            case Activity.RunningTaskStatus.CONTACTED:
                                RunningTaskManager.updateStatusWithTransaction("Contacted",runningTaskId);
                                break;
                            case Activity.RunningTaskStatus.CANDIDATE_RESPONDED:
                                RunningTaskManager.updateStatusWithTransaction("Candidate Responded", runningTaskId);
                                break;
                            case Activity.RunningTaskStatus.QUALIFYING:
                                RunningTaskManager.updateStatusWithTransaction("Qualifying", runningTaskId);
                                break;
                            case Activity.RunningTaskStatus.SUBMITTED:
                                RunningTaskManager.updateStatusWithTransaction("Submitted", runningTaskId);
                                RunningTaskManager.updateSubmittedStateWithTransaction(true, runningTaskId);

                                break;
                            case Activity.RunningTaskStatus.INTERVIEWING:
                                RunningTaskManager.updateStatusWithTransaction("Interviewing", runningTaskId);
                                break;
                            case Activity.RunningTaskStatus.OFFERED:
                                RunningTaskManager.updateStatusWithTransaction("Offered", runningTaskId);
                                break;
                            case Activity.RunningTaskStatus.NOT_IN_CONSIDERATION:
                                RunningTaskManager.updateStatusWithTransaction("Not In Consideration", runningTaskId);
                                break;
                            case Activity.RunningTaskStatus.CLIENT_DECLINED:
                                RunningTaskManager.updateStatusWithTransaction("Client Declined", runningTaskId);
                                break;
                            case Activity.RunningTaskStatus.PLACED:
                                RunningTaskManager.updateStatusWithTransaction("Placed", runningTaskId);
                                break;
                            default:
                                break;
                        }
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

        public static Activity getActivityById(long id)
        {
            string sql = string.Format("select * from `swilifecore`.`activity` where `ActivityId`='{0}' ", id);
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            if (tbl.Rows.Count > 0)
            {
                DataRow data_row = tbl.Rows[0];
                return Data.CreateItemFromRow<Activity>(data_row);
            }
            return null;
        }

        public static void update(Activity act)
        {
            string sql = string.Empty;
            // insert to database by transaction
            try
            {
                DataAccess.Instance.StartTransaction();
                // add log activity
                sql = string.Format("UPDATE `swilifecore`.`activity` SET " +
                        "`Regarding`='{0}', `Type`='{1}', `Notes`='{2}', `Created`='{3}', `ActivityOf`='{4}', `JobOrderId`='{5}', `CandidateId`='{6}', `ContactID`='{7}', `UserId`='{8}'" +
                        "WHERE `ActivityId`='{9}'",
                    act.Regarding, act.Type, QueryBuilder.mySqlEscape(act.Notes), act.Created.ToString("yyyy-MM-dd HH:mm:ss"), (int)act.ActivityOf,
                    act.JobOrderId, act.CandidateId, act.ContactId, act.UserId, act.ActivityId);
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
