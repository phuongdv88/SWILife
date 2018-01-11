using System;
using System.Data;
using SWIDAL;
using SWIBLL.Models;

namespace SWIBLL
{
    public class JobOrderManager
    {
        public static DataTable getJobOrders()
        {
            return DataAccess.Instance.getJobOrders();
        }

        public static bool createJobOrder(JobOrder jobOrder)
        {
            // check duplicate:
            string sql = string.Format("select count(*) from swilifecore.joborder where (char_length(Title) > 0 and Title = '{0}') and (CompanyId != -1 and CompanyId = '{1}') "
                , QueryBuilder.mySqlEscape(jobOrder.Title), jobOrder.CompanyId);
            MySql.Data.MySqlClient.MySqlDataReader reader = DataAccess.Instance.getReader(sql);
            try
            {
                while (reader.Read())
                {
                    if (int.Parse(reader[0].ToString()) > 0)
                    {
                        throw new Exception("This candidate has existed!");
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
            sql = string.Format("INSERT INTO `swilifecore`.`joborder` " +
                "(`Title`, `Department`, `Salary`, `ContactId`, `CompanyId`, `City`, `State`, `RecruiterId`, `OwnerId`, `StartDate`, " +
                "`Duration`, `Type`, `Openings`, `IsHot`, `isPublic`, `Description`, `InternalNotes`, `Created`, `Modified`, `WebLink`, `Status`, `ExperienceYear`)" +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', " +
                "'{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', now(), now(), '{17}', '{18}', '{19}')",
                QueryBuilder.mySqlEscape(jobOrder.Title), QueryBuilder.mySqlEscape(jobOrder.Department), QueryBuilder.mySqlEscape(jobOrder.Salary), jobOrder.ContactId,
                jobOrder.CompanyId, QueryBuilder.mySqlEscape(jobOrder.City), QueryBuilder.mySqlEscape(jobOrder.State), jobOrder.RecruiterId, jobOrder.OwnerId,
                jobOrder.StartDate.ToString("yyyy-MM-dd"), QueryBuilder.mySqlEscape(jobOrder.Duration), QueryBuilder.mySqlEscape(jobOrder.Type), jobOrder.Openings,
                Convert.ToInt32(jobOrder.IsHot), Convert.ToInt32(jobOrder.isPublic), QueryBuilder.mySqlEscape(jobOrder.Description), QueryBuilder.mySqlEscape(jobOrder.InternalNotes),
                QueryBuilder.mySqlEscape(jobOrder.WebLink), QueryBuilder.mySqlEscape(jobOrder.Status), jobOrder.ExperienceYear);
            // add activity
            long rs = DataAccess.Instance.executeInsertingQuery(sql);
            Activity act = new Activity()
            {
                Type = "Add New Job Order",
                ActivityOf = Activity.TypeOfLogActivity.JobOrder,
                JobOrderId = rs,
            };
            // add activity to db
            ActivityManager.insert(act, null);
            return rs > 0 ? true : false; ;
        }

        public static bool updateJobOrder(JobOrder jobOrder)
        {
            string sql = string.Format("UPDATE `swilifecore`.`joborder` SET " +
                "`Title`='{0}', `Department`='{1}', `Salary`='{2}', `ContactId`='{3}', `CompanyId`='{4}', `City`='{5}', `State`='{6}', `RecruiterId`='{7}', " +
                "`OwnerId`='{8}', `StartDate`='{9}', `Duration`='{10}', `Type`='{11}', `IsHot`='{12}', `isPublic`='{13}', `Description`='{14}', `InternalNotes`='{15}', " +
                "`Modified`=now(), `WebLink`='{16}', `Status`='{17}', `ExperienceYear`='{18}' WHERE `JobOrderId`='{19}'",
                QueryBuilder.mySqlEscape(jobOrder.Title), QueryBuilder.mySqlEscape(jobOrder.Department), QueryBuilder.mySqlEscape(jobOrder.Salary), jobOrder.ContactId,
                jobOrder.CompanyId, QueryBuilder.mySqlEscape(jobOrder.City), QueryBuilder.mySqlEscape(jobOrder.State), jobOrder.RecruiterId, jobOrder.OwnerId,
                jobOrder.StartDate.ToString("yyyy-MM-dd"), QueryBuilder.mySqlEscape(jobOrder.Duration), QueryBuilder.mySqlEscape(jobOrder.Type),
                Convert.ToInt32(jobOrder.IsHot), Convert.ToInt32(jobOrder.isPublic), QueryBuilder.mySqlEscape(jobOrder.Description), QueryBuilder.mySqlEscape(jobOrder.InternalNotes),
                QueryBuilder.mySqlEscape(jobOrder.WebLink), QueryBuilder.mySqlEscape(jobOrder.Status), jobOrder.ExperienceYear, jobOrder.JobOrderId);
            int rs = DataAccess.Instance.executeNonQuery(sql);
            Activity act = new Activity()
            {
                Type = "Update Job Order",
                ActivityOf = Activity.TypeOfLogActivity.JobOrder,
                JobOrderId = jobOrder.JobOrderId,
            };
            // add activity to db
            ActivityManager.insert(act, null);
            return rs > 0 ? true : false;
        }

        public static void deleteJobOrder(int jobOrderId)
        {
            string sql = string.Format("delete from `swilifecore`.`joborder` where `JobOrderId`='{0}'", jobOrderId);
            try
            {
                DataAccess.Instance.StartTransaction();

                DataAccess.Instance.executeNonQueryTransaction(sql);
                // delete running task 
                sql = string.Format("DELETE FROM `swilifecore`.`runningtask` WHERE `JobOrderId`='{0}'", jobOrderId);
                DataAccess.Instance.executeNonQueryTransaction(sql);
                // commit 
                DataAccess.Instance.commitTransaction();

                Activity act = new Activity()
                {
                    Type = "Delete Job Order",
                    ActivityOf = Activity.TypeOfLogActivity.JobOrder,
                    JobOrderId = jobOrderId,
                };
                // add activity to db
                ActivityManager.insert(act, null);

            }
            catch
            {
                DataAccess.Instance.rollbackTransaction();
                throw;
            }
        }

        public static JobOrder getJobOrder(long id)
        {

            JobOrder job = null;
            DataTable tbl = DataAccess.Instance.getJobOrderById(id);
            if (tbl.Rows.Count > 0)
            {
                DataRow datarow = tbl.Rows[0];
                job = Data.CreateItemFromRow<JobOrder>(datarow);
            }
            return job;
        }

        public static bool updateAttactmentLink(JobOrder jobOrder)
        {
            string sql = string.Format("UPDATE `swilifecore`.`joborder` SET `AttachmentLink`='{0}' WHERE `JobOrderId`='{1}'", QueryBuilder.mySqlEscape(jobOrder.AttachmentLink), jobOrder.JobOrderId);
            int result = DataAccess.Instance.executeNonQuery(sql);
            return result > 0 ? true : false;
        }

    }
}
