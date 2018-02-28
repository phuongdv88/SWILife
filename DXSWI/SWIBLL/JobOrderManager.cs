using System;
using System.Data;
using SWIDAL;
using SWIBLL.Models;
using System.Collections.Generic;
using System.Linq;

namespace SWIBLL
{
    public class JobOrderManager
    {
        public static DataTable getJobOrders()
        {
            return DataAccess.Instance.getJobOrders();
        }

        public static bool IsJobOrderExist(JobOrder jobOrder)
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
        public static bool createJobOrder(JobOrder jobOrder)
        {

            string sql = string.Format("INSERT INTO `swilifecore`.`joborder` " +
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
            ActivityManager.insert(act);
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
            ActivityManager.insert(act);
            return rs > 0 ? true : false;
        }

        public static void deleteJobOrder(long jobOrderId)
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
                ActivityManager.insert(act);

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
        public static JobOrder getJobOrderByTitle(string title, long comId)
        {

            JobOrder job = null;
            string sql = string.Format("select T1.*, T2.Name CompanyName, concat(T3.FirstName , T3.LastName) as ContactName, " +
                                        "(select count(RunningTaskId) from runningtask where runningtask.JobOrderId = T1.JobOrderId) as CanInPipeLine, " +
                                        "(select count(*) from runningtask where runningtask.JobOrderId = T1.JobOrderId and runningtask.IsSubmitted = '1') as Submitted " +
                                        "from swilifecore.joborder T1 left join swilifecore.company T2 on T1.CompanyId = T2.CompanyId " +
                                        "left join swilifecore.contact T3 on T1.ContactId = T3.ContactId " +
                                        "where T1.Title = {0} and T1.CompanyId = {1}", title, comId);
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
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

        public static List<ReportJobOrder> GetReport(long jobOrderId)
        {
            List<ReportJobOrder> rp = new List<ReportJobOrder>();
            string[] listStep = new string[] {"Contacted",
                                                "Candidate Responded",
                                                "Qualifying",
                                                "Submitted",
                                                "Interviewing",
                                                "Offered", // final state till end
                                                "Not In Consideration",
                                                "Client Declined",
                                                "Placed"};

            string sql = string.Empty;
            int value = 0;
            int numberFinalState = 0;
            for (int i = listStep.Length - 1; i > listStep.Length - 5; i--)
            {
                string tit = listStep[i];
                sql = string.Format("SELECT count(*) FROM swilifecore.runningtask where JobOrderId = {0} and Status = '{1}'", jobOrderId, tit);
                value = int.Parse(DataAccess.Instance.executeScalar(sql).ToString());
                rp.Add(new ReportJobOrder(tit, value));
                numberFinalState += value;
            }
            for (int i = listStep.Length - 5; i >= 0; i--)
            {
                string tit = listStep[i];
                sql = string.Format("SELECT count(*) FROM swilifecore.runningtask where JobOrderId = {0} and Status = '{1}'", jobOrderId, tit);
                value += int.Parse(DataAccess.Instance.executeScalar(sql).ToString()) + numberFinalState;
                rp.Add(new ReportJobOrder(tit, value));
                numberFinalState = 0;
            }
            sql = string.Format("SELECT count(*) FROM swilifecore.runningtask where JobOrderId = {0}", jobOrderId);
            value = int.Parse(DataAccess.Instance.executeScalar(sql).ToString());
            rp.Add(new ReportJobOrder("Total Pipeline", value));
            rp.Reverse();
            return rp;
        }
        /// <summary>
        /// get report Last 4 weeks
        /// </summary>
        /// <returns></returns>
        public static List<ReportHiringOverview> GetReportByWeek()
        {
            List<ReportHiringOverview> lrp = new List<ReportHiringOverview>();
            // get datetime of last 4 sundays in this month
            List<DateTime> theLast4SundaysAndNow = new List<DateTime>();
            var today = DateTime.Today;
            theLast4SundaysAndNow.Add(today); // add today
            // add last 4 sunday
            int offset = today.DayOfWeek == DayOfWeek.Sunday ? 7 : (int)today.DayOfWeek;
            DateTime theLastSunday = today.AddDays(-offset);

            for (int i = 0; i < 4; ++i)
            {
                theLast4SundaysAndNow.Add(theLastSunday.AddDays(-7 * i));
            }
            theLast4SundaysAndNow.Reverse();

            string period = string.Empty;

            for (var i = 0; i < theLast4SundaysAndNow.Count() - 1; ++i)
            {
                period = string.Format("{0} to {1}", theLast4SundaysAndNow[i].ToString("dd/MMM/yy"), theLast4SundaysAndNow[i + 1].ToString("dd/MMM/yy"));
                lrp.Add(getReportByDays(period, theLast4SundaysAndNow[i], theLast4SundaysAndNow[i + 1]));
            }
            return lrp;
        }
        public static List<ReportHiringOverview> GetReportByMonth()
        {
            List<ReportHiringOverview> lrp = new List<ReportHiringOverview>();
            // get datetime of 4 last first day of months
            List<DateTime> theLast4FirstDayOfMonthAndNow = new List<DateTime>();
            var today = DateTime.Today;
            theLast4FirstDayOfMonthAndNow.Add(today); // add today
            // add last 4 firt days of month
            int offset = 0;
            if(today.Day == 1)
            {
                offset = 1;
            }
            for(var i = 0; i < 4; i++)
            {
                int month = today.Month - 1 * (i + offset);
                int year = today.Year;
                if (month <= 0)
                {
                    month += 12;
                    year -= 1;
                }
                theLast4FirstDayOfMonthAndNow.Add(new DateTime(year, month, 1));
            }
            theLast4FirstDayOfMonthAndNow.Reverse();

            string period = string.Empty;

            for (var i = 0; i < theLast4FirstDayOfMonthAndNow.Count() - 1; ++i)
            {
                period = string.Format("{0} to {1}", theLast4FirstDayOfMonthAndNow[i].ToString("dd/MMM/yy"), theLast4FirstDayOfMonthAndNow[i + 1].ToString("dd/MMM/yy"));
                lrp.Add(getReportByDays(period, theLast4FirstDayOfMonthAndNow[i], theLast4FirstDayOfMonthAndNow[i + 1]));
            }
            return lrp;
        }
        public static List<ReportHiringOverview> GetReportByYear()
        {
            List<ReportHiringOverview> lrp = new List<ReportHiringOverview>();
            // get datetime of last 4 year
            List<DateTime> theLast4FirstDayOfYearAndNow = new List<DateTime>();
            var today = DateTime.Today;
            theLast4FirstDayOfYearAndNow.Add(today); // add today
            // add last 4 firt days of month
            int offset = 0;
            if (today.DayOfYear == 1)
            {
                offset = 1;
            }
            for (var i = 0; i < 4; i++)
            {
                int year = today.Year - 1 *(i + offset);
                theLast4FirstDayOfYearAndNow.Add(new DateTime(year, 1, 1));
            }
            theLast4FirstDayOfYearAndNow.Reverse();

            string period = string.Empty;

            for (var i = 0; i < theLast4FirstDayOfYearAndNow.Count() - 1; ++i)
            {
                period = string.Format("{0} to {1}", theLast4FirstDayOfYearAndNow[i].ToString("dd/MMM/yy"), theLast4FirstDayOfYearAndNow[i + 1].ToString("dd/MMM/yy"));
                lrp.Add(getReportByDays(period, theLast4FirstDayOfYearAndNow[i], theLast4FirstDayOfYearAndNow[i + 1]));
            }
            return lrp;
        }

        private static ReportHiringOverview getReportByDays(string period, DateTime startDate, DateTime lastDate)
        {
            ReportHiringOverview rp = new ReportHiringOverview(period);
            string sql = string.Format("SELECT count(*) FROM swilifecore.runningtask where Status = 'Placed' and Modified >= '{0}' and Modified < '{1}';", startDate.ToString("yyyy-MM-dd"), lastDate.ToString("yyyy-MM-dd"));
            rp.Hires = int.Parse(DataAccess.Instance.executeScalar(sql).ToString());
            sql = string.Format("SELECT count(*) FROM swilifecore.runningtask where ( Status = 'Interviewing' or Status = 'Offered' or Status = 'Not In Consideration'" +
                                " or Status = 'Client Declined' or Status = 'Placed') and Modified >= '{0}' and Modified < '{1}';", startDate.ToString("yyyy-MM-dd"), lastDate.ToString("yyyy-MM-dd"));
            rp.Interviews = int.Parse(DataAccess.Instance.executeScalar(sql).ToString());
            sql = string.Format("SELECT count(*) FROM swilifecore.runningtask where Status = 'Submitted' and Modified >= '{0}' and Modified < '{1}';", startDate.ToString("yyyy-MM-dd"), lastDate.ToString("yyyy-MM-dd"));
            rp.Submissions = rp.Interviews + int.Parse(DataAccess.Instance.executeScalar(sql).ToString());
            return rp;
        }

    }
}
