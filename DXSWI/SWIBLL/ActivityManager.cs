using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWIDAL;
using SWIBLL.Models;
using System.Data;
using MySql.Data.MySqlClient;

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
                                        "left join swilifecore.joborder T2 on T1.CompanyId = T2.CompanyId " +
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
            var trans = DataAccess.Instance.StartTransaction();
            try
            {
                //delete activity
                sql = string.Format("DELETE FROM `swilifecore`.`activity` WHERE `ActivityId`='{0}'", Activityid);
                DataAccess.Instance.executeNonQueryTransaction(sql, trans);

                DataAccess.Instance.commitTransaction(trans);
            }
            catch
            {
                DataAccess.Instance.rollbackTransaction(trans);
                throw;
            }
            finally
            {
                DataAccess.Instance.ReturnConnectionTransaction(trans);
            }
        }

        public static async Task<DataTable> getAllActivitiesAsync()
        {
            DataTable tbl = null;
            await Task.Run(() =>
            {
                tbl = DataAccess.Instance.getDataTable("select T1.ActivityId, T1.Regarding, T1.Type, date_format(T1.Created,'%d/%m/%Y %T') as Created, T2.UserName from swilifecore.activity T1 left join swilifecore.user T2 on T1.UserId = T2.UserId order by T1.ActivityId desc limit 1,1000");
            });
            return tbl;
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
            var trans = DataAccess.Instance.StartTransaction();

            try
            {
                act.UserId = UserManager.ActivatedUser.UserId;
                // add log activity
                sql = string.Format("INSERT INTO `swilifecore`.`activity` " +
                    "(`Regarding`, `Type`, `Notes`, `Created`, `ActivityOf`, " +
                    "`JobOrderId`, `CandidateId`, `ContactID`, `UserId`, `RunningTaskId`) " +
                    "VALUES ('{0}', '{1}', '{2}', now(), '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                    act.Regarding, act.Type, QueryBuilder.mySqlEscape(act.Notes), (int)act.ActivityOf,
                    act.JobOrderId, act.CandidateId, act.ContactId, act.UserId, act.RunningTaskId);
                DataAccess.Instance.executeInsertQueryTransaction(sql, trans);
                // change status of running task or whatever folow by type of activity
                updateCandidateStatusWithTransaction(act.Status, act.RunningTaskId, trans);

                // commit 
                DataAccess.Instance.commitTransaction(trans);
            }
            catch
            {
                DataAccess.Instance.rollbackTransaction(trans);
                throw;
            }
            finally
            {
                DataAccess.Instance.ReturnConnectionTransaction(trans);
            }

        }

        public static void insertMultiActionForCandidates(Activity act, long jobOrderId, List<long> listCandidateId)
        {
            string sql = string.Empty;
            // insert to database by transaction
            var trans = DataAccess.Instance.StartTransaction();

            try
            {
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
                        DataAccess.Instance.executeInsertQueryTransaction(sql, trans);

                        // check type of status to set data in running task
                        // if type of status is submitted -> set to running task also
                        updateCandidateStatusWithTransaction(act.Status, runningTaskId, trans);

                    }
                }
                // commit 
                DataAccess.Instance.commitTransaction(trans);
            }
            catch
            {
                DataAccess.Instance.rollbackTransaction(trans);
                throw;
            }
            finally
            {
                DataAccess.Instance.ReturnConnectionTransaction(trans);
            }

        }

        private static void updateCandidateStatusWithTransaction(Activity.RunningTaskStatus Status, long runningTaskId, MySqlTransaction trans)
        {
            string statusInfo = string.Empty;
            switch (Status)
            {
                case Activity.RunningTaskStatus.NOT_CONTACT:
                    statusInfo = "Not Contact";
                    break;
                case Activity.RunningTaskStatus.CONTACTED:
                    statusInfo = "Contacted";
                    break;
                case Activity.RunningTaskStatus.CANDIDATE_RESPONDED:
                    statusInfo = "Candidate Responded";
                    break;
                case Activity.RunningTaskStatus.QUALIFYING:
                    statusInfo = "Qualifying";
                    break;
                case Activity.RunningTaskStatus.SUBMITTED:
                    statusInfo = "Submitted";
                    break;
                case Activity.RunningTaskStatus.INTERVIEWING:
                    statusInfo = "Interviewing";
                    break;
                case Activity.RunningTaskStatus.OFFERED:
                    statusInfo = "Offered";
                    break;
                case Activity.RunningTaskStatus.NOT_IN_CONSIDERATION:
                    statusInfo = "Not In Consideration";
                    break;
                case Activity.RunningTaskStatus.CLIENT_DECLINED:
                    statusInfo = "Client Declined";
                    break;
                case Activity.RunningTaskStatus.PLACED:
                    statusInfo = "Placed";
                    break;
                default:
                    break;
            }
            if (statusInfo.Length > 0)
            {
                RunningTaskManager.updateStatusWithTransaction(statusInfo, runningTaskId, trans);
                // update last status of candidate
                CandidateManager.updateLastStatusWithTransaction(statusInfo, runningTaskId, trans);
                // update submitted state
                if(Status >= Activity.RunningTaskStatus.SUBMITTED)
                {
                    RunningTaskManager.updateSubmittedStateWithTransaction(true, runningTaskId, trans);
                }
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
            var trans = DataAccess.Instance.StartTransaction();

            try
            {
                // add log activity
                sql = string.Format("UPDATE `swilifecore`.`activity` SET " +
                        "`Regarding`='{0}', `Type`='{1}', `Notes`='{2}', `Created`='{3}', `ActivityOf`='{4}', `JobOrderId`='{5}', `CandidateId`='{6}', `ContactID`='{7}', `UserId`='{8}'" +
                        "WHERE `ActivityId`='{9}'",
                    act.Regarding, act.Type, QueryBuilder.mySqlEscape(act.Notes), act.Created.ToString("yyyy-MM-dd HH:mm:ss"), (int)act.ActivityOf,
                    act.JobOrderId, act.CandidateId, act.ContactId, act.UserId, act.ActivityId);
                DataAccess.Instance.executeNonQueryTransaction(sql, trans);

                // change status of running task or whatever folow by type of activity
                if (act.ActivityOf == Activity.TypeOfLogActivity.Candidate)
                {
                    // check type of status to set data in running task
                    // if type of status is submitted -> set to running task also
                    updateCandidateStatusWithTransaction(act.Status, act.RunningTaskId, trans);
                }
                // commit 
                DataAccess.Instance.commitTransaction(trans);
            }
            catch
            {
                DataAccess.Instance.rollbackTransaction(trans);
                throw;
            }
            finally
            {
                DataAccess.Instance.ReturnConnectionTransaction(trans);
            }

        }
    }
}
