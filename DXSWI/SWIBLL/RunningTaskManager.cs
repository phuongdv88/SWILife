using System;
using SWIBLL.Models;
using SWIDAL;
using System.Data;
using MySql.Data.MySqlClient;

namespace SWIBLL
{
    public class RunningTaskManager  // it 's named "pipeline"
    {
        public static bool createRunningTask(RunningTask rtask)
        {
            // duplicated verify
            string sql = string.Format("select RunningTaskId from runningtask T where T.CandidateId = '{0}' and T.JobOrderId = '{1}'", rtask.CandidateId, rtask.JobOrderId);
            var result = DataAccess.Instance.executeScalar(sql);
            if(result != null)
            {
                Exception ex = new Exception("This Job Order has assigned!");
                throw ex;
            }
            sql = string.Format("INSERT INTO `swilifecore`.`runningtask` (`CandidateId`, `JobOrderId`, `Status`, `Match`, `Added`, `EnteredBy`, `isSubmitted`) " +
                "VALUES ('{0}', '{1}', 'Not Contact', '0', now(), '{2}', '0')", 
                rtask.CandidateId, rtask.JobOrderId, rtask.EnteredBy);
            long rs = DataAccess.Instance.executeInsertingQuery(sql);

            Activity act = new Activity()
            {
                Type = "Add Candidate to Job Pipeline",
                ActivityOf = Activity.TypeOfLogActivity.Pipeline,
                JobOrderId = rtask.JobOrderId,
                CandidateId = rtask.CandidateId,
                RunningTaskId = rs
            };
            // add activity to db
            ActivityManager.insert(act, null);

            return rs > 0 ? true : false;
        }

        public static bool updateRunningTask(RunningTask rtask)
        {
            //string sql = string.Format("UPDATE `swilifecore`.`runningtask` SET `CandidateId`='{0}', `JobOrderId`='{1}', `Status`='{2}', `Match`='{3}' WHERE `RunningtaskId`='{4}';", rtask.CandidateId, rtask.JobOrderId, rtask.Status, rtask.Match, rtask.RunningtaskId);
            string sql = string.Format("UPDATE `swilifecore`.`runningtask` SET `CandidateId`='{0}', `JobOrderId`='{1}', `Status`='{2}', `Match`='{3}', `isSubmitted`='{4}' WHERE `RunningTaskId`='{5}'",
                rtask.CandidateId, rtask.JobOrderId, rtask.Status, rtask.Match, Convert.ToInt32(rtask.isSubmitted), rtask.RunningtaskId);
            int result = DataAccess.Instance.executeNonQuery(sql);
            return result > 0 ? true : false;
        }

        public static bool updateStatusWithTransaction(string status, long id)
        {
            string sql = string.Format("UPDATE `swilifecore`.`runningtask` SET `Status`='{0}' WHERE `RunningtaskId`='{1}';", status, id);
            return DataAccess.Instance.executeNonQueryTransaction(sql);
        }

        public static bool updateSubmittedStateWithTransaction(bool isSubmitted, long id)
        {
            string sql = string.Format("UPDATE `swilifecore`.`runningtask` SET `isSubmitted`='{0}' WHERE `RunningtaskId`='{1}';", Convert.ToInt32(isSubmitted), id);
            return DataAccess.Instance.executeNonQueryTransaction(sql);
        }

        public static DataTable getRunningTaskJobs(long candidateId)
        {
            string sql = string.Format("select T1.RunningtaskId, T1.JobOrderId, T1.Status, T1.Match, T2.Title, date_format(T1.Added, '%d-%m-%Y') as Added, T1.EnteredBy, T4.UserName Owner, T3.Name CompanyName from swilifecore.runningtask T1 inner join swilifecore.joborder T2 on T1.JobOrderId = t2.JobOrderId inner join swilifecore.company T3 on T2.CompanyId = T3.CompanyId left join swilifecore.user T4 on T2.OwnerId = T4.UserId where T1.CandidateId = '{0}'", candidateId);
            return DataAccess.Instance.getTable(sql);
        }
        public static DataTable getRunningTaskCandidates(long jobId)
        {
            return DataAccess.Instance.getPipelineCandidates(jobId);
        }

        public static bool deleteRunningTask(long id)
        {            
            string sql = string.Format("DELETE FROM `swilifecore`.`runningtask` WHERE `RunningTaskId`='{0}'", id);
            int result = DataAccess.Instance.executeNonQuery(sql);
            return result > 0 ? true : false;

        }

        public static bool isExist(long CandidateId, long JobOrderId)
        {
            string sql = string.Format("Select count(*) from `swilifecore`.`runningtask` WHERE `CandidateId`='{0}' and `JobOrderId`='{1}'", CandidateId, JobOrderId);
            MySqlDataReader reader = DataAccess.Instance.getReader(sql);
            while (reader.Read())
            {
                int count = reader.GetInt32(0);
                reader.Dispose();
                if(count >=1)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
