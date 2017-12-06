using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWIBLL.Models;
using SWIDAL;
namespace SWIBLL
{
    public class RunningTaskManager
    {
        public static bool createRunningTask(RunningTask rtask)
        {
            // duplicate verify
            string sql = string.Format("select RunningTaskId from runningtask T where T.CandidateId = '{0}' and T.JobOrderId = '{1}'", rtask.CandidateId, rtask.JobOrderId);
            var result = DataAccess.Instance.executeScalar(sql);
            if(result != null)
            {
                Exception ex = new Exception("This Job Order has assigned!");
                throw ex;
            }
            sql = string.Format("INSERT INTO `swilifecore`.`runningtask` (`CandidateId`, `JobOrderId`, `Status`, `Match`) VALUES ('{0}', '{1}', 'Not Contact', '0')", rtask.CandidateId, rtask.JobOrderId);
            int rs = DataAccess.Instance.executeNonQuery(sql);
            return rs > 0 ? true : false;
        }

        public static bool updateRunningTask(RunningTask rtask)
        {
            string sql = string.Format("UPDATE `swilifecore`.`runningtask` SET `CandidateId`='{0}', `JobOrderId`='{1}', `Status`='{2}', `Match`='{3}' WHERE `RunningtaskId`='{4}';", rtask.CandidateId, rtask.JobOrderId, rtask.Status, rtask.Match, rtask.RunningtaskId);
            int result = DataAccess.Instance.executeNonQuery(sql);
            return result > 0 ? true : false;
        }
    }
}
