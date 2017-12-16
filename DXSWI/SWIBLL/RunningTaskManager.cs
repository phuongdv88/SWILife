using System;
using SWIBLL.Models;
using SWIDAL;
using System.Data;
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
                "VALUES ('{0}', '{1}', 'Not Contact', '0', '{2}', '{3}', '0')", 
                rtask.CandidateId, rtask.JobOrderId, rtask.Added.ToString("yyyy:MM:dd hh:mm:ss"), rtask.EnteredBy);
            int rs = DataAccess.Instance.executeNonQuery(sql);
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

        public static bool updateStatusWithTransaction(string status, int id)
        {
            string sql = string.Format("UPDATE `swilifecore`.`runningtask` SET `Status`='{0}' WHERE `RunningtaskId`='{1}';", status, id);
            return DataAccess.Instance.executeNonQueryTransaction(sql);
        }

        public static bool updateSubmittedStateWithTransaction(bool isSubmitted, int id)
        {
            string sql = string.Format("UPDATE `swilifecore`.`runningtask` SET `isSubmitted`='{0}' WHERE `RunningtaskId`='{1}';", Convert.ToInt32(isSubmitted), id);
            return DataAccess.Instance.executeNonQueryTransaction(sql);
        }

        public static DataTable getRunningTaskJobs(int candidateId)
        {
            string sql = string.Format("select T1.RunningtaskId, T1.JobOrderId, T1.Status, T1.Match, T2.Title, date_format(T1.Added, '%d-%m-%Y') as Added, T1.EnteredBy, T4.UserName Owner, T3.Name CompanyName from swilifecore.runningtask T1 inner join swilifecore.joborder T2 on T1.JobOrderId = t2.JobOrderId inner join swilifecore.company T3 on T2.CompanyId = T3.CompanyId left join swilifecore.user T4 on T2.OwnerId = T4.UserId where T1.CandidateId = '{0}'", candidateId);
            return DataAccess.Instance.getTable(sql);
        }
        public static DataTable getRunningTaskCandidate(int jobId)
        {
            string sql = string.Format("select T1.RunningtaskId, T1.CandidateId, T1.Status, T1.Match, T2.Title, date_format(T1.Added, '%d-%m-%Y') as Added, T1.EnteredBy, T4.UserName Owner, T3.Name CompanyName from swilifecore.runningtask T1 inner join swilifecore.joborder T2 on T1.JobOrderId = t2.JobOrderId inner join swilifecore.company T3 on T2.CompanyId = T3.CompanyId left join swilifecore.user T4 on T2.OwnerId = T4.UserId where T1.JobOrderId = '{0}'", jobId);
            return DataAccess.Instance.getTable(sql);
        }

        public static bool deleteRunningTask(int id)
        {            
            string sql = string.Format("DELETE FROM `swilifecore`.`runningtask` WHERE `RunningTaskId`='{0}'", id);
            int result = DataAccess.Instance.executeNonQuery(sql);
            return result > 0 ? true : false;

        }
    }
}
