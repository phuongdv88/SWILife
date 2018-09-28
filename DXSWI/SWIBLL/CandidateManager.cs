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
    public class CandidateManager
    {

        public static async Task<DataTable> GetAllCandidatesOverViewAsync()
        {
            DataTable tbl = null;
            await Task.Run(() =>
            {
                tbl = DataAccess.Instance.getCandidatesOverview();
            });
            return tbl;
        }

        public static async Task<DataTable> GetAllCandidatesAvailableForJobAsync(long JobId)
        {
            DataTable tbl = null;
            await Task.Run(() =>
            {
                tbl = DataAccess.Instance.getCandidatesAvailableForJob(JobId);
            });
            return tbl;
        }

        public static void deleteCadidate(long CandidateId)
        {
            //DELETE FROM `swilifecore`.`candidate` WHERE `CandidateId`='5';
            string sql = string.Format("DELETE FROM `swilifecore`.`candidate` WHERE `CandidateId`='{0}'", CandidateId);
            var trans = DataAccess.Instance.StartTransaction();

            try
            {

                DataAccess.Instance.executeNonQueryTransaction(sql, trans);
                // delete running task 
                sql = string.Format("DELETE FROM `swilifecore`.`runningtask` WHERE `CandidateId`='{0}'", CandidateId);
                DataAccess.Instance.executeNonQueryTransaction(sql, trans);
                // commit 
                DataAccess.Instance.commitTransaction(trans);
                Activity act = new Activity()
                {
                    Type = "Delete Candidate",
                    ActivityOf = Activity.TypeOfLogActivity.Candidate,
                    CandidateId = CandidateId,
                    Notes = string.Format("Delete candidateid = {0}", CandidateId)
                };

                ActivityManager.insert(act);
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
        public static bool IsCandidateExist(Candidate can)
        {
            // check duplicate:
            string sql = string.Format("select count(*) from swilifecore.candidate where (char_length(CellPhone) > 0 and CellPhone = '{0}') or (char_length(Email) > 0 and Email = '{1}') or (char_length(WorkPhone) > 0 and WorkPhone = '{2}')"
                , QueryBuilder.mySqlEscape(can.CellPhone), QueryBuilder.mySqlEscape(can.Email), QueryBuilder.mySqlEscape(can.WorkPhone));
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

        public static bool IsCandidateExistByPhoneAndEmail(string cellPhone, string email)
        {
            // check duplicate:
            string sql = string.Format("select count(1) from swilifecore.candidate where (char_length(CellPhone) > 0 and CellPhone = '{0}') or (char_length(Email) > 0 and Email = '{1}') or (char_length(WorkPhone) > 0 and WorkPhone = '{0}')"
                , QueryBuilder.mySqlEscape(cellPhone), QueryBuilder.mySqlEscape(email));
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

        public static void InsertCandidate(Candidate can)
        {
            //INSERT INTO `swilifecore`.`candidate` (`FirstName`, `MiddleName`, `LastName`, `Email`, `SecondaryEmail`, `SkypeIM`, `CellPhone`, `WorkPhone`, `BestTimeToCall`, `Address`, `WebSite`, `Source`, `CurrentPosition`, `DateAvailable`, `CurrentEmployer`, `KeySkills`, `CanRelocate`, `CurrentPay`, `DesiredPay`, `DOBMarried`, `InterviewNotes`, `Gender`, `MiscNotes`, `City`, `Country`, `ResumeLink`, `PositionsUpTillNow`, `Years`, `ProjectDone`, `Industry`, `Education`, `Language`, `CreatedDate`, `CreatedId`, `IsInBlacklist`, `UserId`, `Modified`, `ImageLink`) 
            //VALUES('1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1');
            string sql = string.Format("INSERT INTO `swilifecore`.`candidate` " +
                 "(`FirstName`, `MiddleName`, `LastName`, `Email`, `SecondaryEmail`, " +
                 "`SkypeIM`, `CellPhone`, `WorkPhone`, `BestTimeToCall`, `Address`, " +
                 "`WebSite`, `Source`, `CurrentPosition`, `DateAvailable`, `CurrentEmployer`, " +
                 "`KeySkills`, `CanRelocate`, `CurrentPay`, `DesiredPay`, `DOBMarried`, " +
                 "`InterviewNotes`, `Gender`, `MiscNotes`, `City`, `Country`, `ResumeLink`, " +
                 "`PositionsUpTillNow`, `Years`, `ProjectDone`, `Industry`, `Education`, " +
                 "`Language`, `CreatedDate`, `CreatedId`, `IsInBlacklist`, `UserId`, " +
                 "`Modified`, `ImageLink`, `IsQualified`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', " +
                 "'{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', " +
                 "'{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', " +
                 "'{31}', now(), '{32}', '{33}', '{34}',now(), '{35}', '{36}')",
                 QueryBuilder.mySqlEscape(can.FirstName), QueryBuilder.mySqlEscape(can.MiddleName), QueryBuilder.mySqlEscape(can.LastName), QueryBuilder.mySqlEscape(can.Email), QueryBuilder.mySqlEscape(can.SecondaryEmail),
                 QueryBuilder.mySqlEscape(can.SkypeIM), QueryBuilder.mySqlEscape(can.CellPhone), QueryBuilder.mySqlEscape(can.WorkPhone), QueryBuilder.mySqlEscape(can.BestTimeToCall), QueryBuilder.mySqlEscape(can.Address),
                 QueryBuilder.mySqlEscape(can.WebSite), QueryBuilder.mySqlEscape(can.Source), QueryBuilder.mySqlEscape(can.CurrentPosition), can.DateAvailable.ToString("yyyy-MM-dd H:mm:ss"), QueryBuilder.mySqlEscape(can.CurrentEmployer),
                 QueryBuilder.mySqlEscape(can.KeySkills), Convert.ToInt32(can.CanRelocate), QueryBuilder.mySqlEscape(can.CurrentPay), QueryBuilder.mySqlEscape(can.DesiredPay), QueryBuilder.mySqlEscape(can.DOBMarried),
                 QueryBuilder.mySqlEscape(can.InterviewNotes), Convert.ToInt32(can.Gender), QueryBuilder.mySqlEscape(can.MiscNotes), QueryBuilder.mySqlEscape(can.City), QueryBuilder.mySqlEscape(can.Country), QueryBuilder.mySqlEscape(can.ResumeLink),
                 QueryBuilder.mySqlEscape(can.PositionsUpTillNow), can.Years, QueryBuilder.mySqlEscape(can.ProjectDone), QueryBuilder.mySqlEscape(can.Industry), QueryBuilder.mySqlEscape(can.Education),
                 QueryBuilder.mySqlEscape(can.Language), can.CreatedId, Convert.ToInt32(can.IsInBlacklist), can.UserId,
                 QueryBuilder.mySqlEscape(can.ImageLink), Convert.ToInt32(can.IsQualified));
            long can_id = DataAccess.Instance.executeInsertingQuery(sql);
            Activity act = new Activity()
            {
                Type = "Insert new Candidate",
                ActivityOf = Activity.TypeOfLogActivity.Candidate,
                CandidateId = can_id,
                Notes = string.Format("Candidateid={0} name = {1}", can_id, can.FirstName + " " + can.LastName)
            };

            ActivityManager.insert(act);
        }
        public static void updateCandidate(Candidate can)
        {
            //UPDATE `swilifecore`.`candidate` SET `FirstName`='2', `MiddleName`='2', `LastName`='2', `Email`='2', `SecondaryEmail`='2', `SkypeIM`='2', `CellPhone`='2', `WorkPhone`='22', `BestTimeToCall`='2', `Address`='2',
            //`WebSite`='2', `Source`='2', `CurrentPosition`='2', `DateAvailable`='2018-02-16', `CurrentEmployer`='2', `KeySkills`='2', `CanRelocate`='2', `CurrentPay`='2', `DesiredPay`='2', `DOBMarried`='2', `InterviewNotes`='2', 
            //`Gender`='2', `MiscNotes`='2', `City`='2', `Country`='2', `ResumeLink`='2', `PositionsUpTillNow`='2', `Years`='2', `ProjectDone`='2', `Industry`='2', `Education`='2', `Language`='2', `CreatedDate`='2017-11-23 00:00:00', 
            //`CreatedId`='2', `IsInBlacklist`='2', `UserId`='2', `Modified`='2017-11-23 00:00:00', `ImageLink`='2' WHERE `CandidateId`='3';
            string sql = string.Format("UPDATE `swilifecore`.`candidate` SET " +
                "`FirstName`='{0}', `MiddleName`='{1}', `LastName`='{2}', `Email`='{3}', `SecondaryEmail`='{4}', " +
                "`SkypeIM`='{5}', `CellPhone`='{6}', `WorkPhone`='{7}', `BestTimeToCall`='{8}', `Address`='{9}', " +
                "`WebSite`='{10}', `Source`='{11}', `CurrentPosition`='{12}', `DateAvailable`='{13}', " +
                "`CurrentEmployer`='{14}', `KeySkills`='{15}', `CanRelocate`='{16}', `CurrentPay`='{17}', " +
                "`DesiredPay`='{18}', `DOBMarried`='{19}', `InterviewNotes`='{20}', `Gender`='{21}', `MiscNotes`='{22}', " +
                "`City`='{23}', `Country`='{24}', `ResumeLink`='{25}', `PositionsUpTillNow`='{26}', `Years`='{27}', " +
                "`ProjectDone`='{28}', `Industry`='{29}', `Education`='{30}', `Language`='{31}', " +
                "`CreatedId`='{32}', `IsInBlacklist`='{33}', " +
                "`UserId`='{34}', `Modified`=now(), `ImageLink`='{35}', `IsQualified`='{36}' " +
                "WHERE `CandidateId`='{37}'",
                QueryBuilder.mySqlEscape(can.FirstName), QueryBuilder.mySqlEscape(can.MiddleName), QueryBuilder.mySqlEscape(can.LastName), QueryBuilder.mySqlEscape(can.Email), QueryBuilder.mySqlEscape(can.SecondaryEmail),
                QueryBuilder.mySqlEscape(can.SkypeIM), QueryBuilder.mySqlEscape(can.CellPhone), QueryBuilder.mySqlEscape(can.WorkPhone), QueryBuilder.mySqlEscape(can.BestTimeToCall), QueryBuilder.mySqlEscape(can.Address),
                QueryBuilder.mySqlEscape(can.WebSite), QueryBuilder.mySqlEscape(can.Source), QueryBuilder.mySqlEscape(can.CurrentPosition), can.DateAvailable.ToString("yyyy-MM-dd H:mm:ss"),
                QueryBuilder.mySqlEscape(can.CurrentEmployer), QueryBuilder.mySqlEscape(can.KeySkills), Convert.ToInt32(can.CanRelocate), QueryBuilder.mySqlEscape(can.CurrentPay),
                QueryBuilder.mySqlEscape(can.DesiredPay), QueryBuilder.mySqlEscape(can.DOBMarried), QueryBuilder.mySqlEscape(can.InterviewNotes), Convert.ToInt32(can.Gender), QueryBuilder.mySqlEscape(can.MiscNotes),
                QueryBuilder.mySqlEscape(can.City), QueryBuilder.mySqlEscape(can.Country), QueryBuilder.mySqlEscape(can.ResumeLink), QueryBuilder.mySqlEscape(can.PositionsUpTillNow), can.Years,
                QueryBuilder.mySqlEscape(can.ProjectDone), QueryBuilder.mySqlEscape(can.Industry), QueryBuilder.mySqlEscape(can.Education), QueryBuilder.mySqlEscape(can.Language),
                can.CreatedId, Convert.ToInt32(can.IsInBlacklist),
                can.UserId, QueryBuilder.mySqlEscape(can.ImageLink), Convert.ToInt32(can.IsQualified), can.CandidateId);
            DataAccess.Instance.executeNonQuery(sql);
            Activity act = new Activity()
            {
                Type = "Update Candidate",
                ActivityOf = Activity.TypeOfLogActivity.Candidate,
                CandidateId = can.CandidateId,
                Notes = string.Format("Candidateid={0}", can.CandidateId)
            };

            ActivityManager.insert(act);
        }

        public static bool updateResumeLink(Candidate can)
        {
            string sql = string.Format("UPDATE `swilifecore`.`candidate` SET `ResumeLink`='{0}' WHERE `CandidateId`='{1}'", QueryBuilder.mySqlEscape(can.ResumeLink), can.CandidateId);
            int result = DataAccess.Instance.executeNonQuery(sql);
            return result > 0 ? true : false;
        }

        public static Candidate getCandidate(long id)
        {
            if (id < 0) return null;
            Candidate can = null;
            string sql = string.Format("select T1.*, T2.UserName as Owner from `swilifecore`.`candidate` T1 left join user T2 on T1.UserId = T2.UserId where `CandidateId`='{0}'", id);
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            if (tbl.Rows.Count > 0)
            {
                DataRow datarow = tbl.Rows[0];
                can = Data.CreateItemFromRow<Candidate>(datarow);
            }
            return can;
        }

        public static Candidate getCandidateByEmail(string email)
        {
            Candidate can = null;
            string sql = string.Format("select T1.*, T2.UserName as Owner from `swilifecore`.`candidate` T1 left join user T2 on T1.UserId = T2.UserId where `Email`='{0}'", email);
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            if (tbl.Rows.Count > 0)
            {
                DataRow datarow = tbl.Rows[0];
                can = Data.CreateItemFromRow<Candidate>(datarow);
            }
            return can;
        }

        public static Candidate getCandidateByCellPhone(string cellphone)
        {
            // convert to 10 digit number first
            Candidate can = null;
            string sql = string.Format("select T1.*, T2.UserName as Owner from `swilifecore`.`candidate` T1 left join user T2 on T1.UserId = T2.UserId where `CellPhone`='{0}'", cellphone);
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            if (tbl.Rows.Count > 0)
            {
                DataRow datarow = tbl.Rows[0];
                can = Data.CreateItemFromRow<Candidate>(datarow);
            }
            return can;
        }

        public static DataTable getCandidatesOverview()
        {
            return DataAccess.Instance.getCandidatesOverview();
        }

        public static void correctDatabase(long canId, string city, string cellphone, string keyskills)
        {
            string sql = string.Format("UPDATE `swilifecore`.`candidate` SET `CellPhone`='{0}', `KeySkills`='{1}', `City`='{2}' WHERE `CandidateId`='{3}';"
                , QueryBuilder.mySqlEscape(cellphone), QueryBuilder.mySqlEscape(keyskills), QueryBuilder.mySqlEscape(city), canId);
            DataAccess.Instance.executeNonQuery(sql);
        }
        public static void correctDatabasePhone(long canId, string cellphone, string workPhone)
        {
            string sql = string.Format("UPDATE `swilifecore`.`candidate` SET `CellPhone`='{0}', `WorkPhone`='{1}' WHERE `CandidateId`='{2}';",
                QueryBuilder.mySqlEscape(cellphone), QueryBuilder.mySqlEscape(workPhone), canId);
            DataAccess.Instance.executeNonQuery(sql);
        }

        public static void updateCurrentStatus(long candidateid, string currentPosition, string currentCompany)
        {
            // get candidate id and jobtitle
            string sql = string.Format("UPDATE `swilifecore`.`candidate` SET `CurrentPosition`='{0}', `CurrentEmployer`='{1}' WHERE `CandidateId`='{2}'; ", QueryBuilder.mySqlEscape(currentPosition), QueryBuilder.mySqlEscape(currentCompany), candidateid);
            DataAccess.Instance.executeNonQuery(sql);
        }

        public static void updateLastStatus(string statusInfo, long runningTaskId)
        {
            // get candidate id and jobtitle
            string sql = string.Format("SELECT T1.CandidateId, T2.Title FROM swilifecore.runningtask T1 " +
                                        "left join swilifecore.joborder T2 on T1.JobOrderId = T2.JobOrderId where RunningTaskId = {0} ", runningTaskId);
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            var status = string.Empty;
            long canId = -1;
            if (tbl.Rows.Count > 0)
            {
                DataRow datarow = tbl.Rows[0];
                canId = Convert.ToInt64(datarow["CandidateId"].ToString());
                status = string.Format("{0} - {1}", statusInfo, datarow["Title"].ToString());
            }
            sql = string.Format("UPDATE `swilifecore`.`candidate` SET `LastStatus`='{0}' WHERE `CandidateId`='{1}'", QueryBuilder.mySqlEscape(status), canId);
            DataAccess.Instance.executeInsertingQuery(sql);
        }
        public static bool updateLastStatusWithTransaction(string statusInfo, long runningTaskId, MySqlTransaction trans)
        {
            // get candidate id and jobtitle
            string sql = string.Format("SELECT T1.CandidateId, T2.Title FROM swilifecore.runningtask T1 " +
                                        "left join swilifecore.joborder T2 on T1.JobOrderId = T2.JobOrderId where RunningTaskId = {0} ", runningTaskId);
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            var status = string.Empty;
            long canId = -1;
            if (tbl.Rows.Count > 0)
            {
                DataRow datarow = tbl.Rows[0];
                canId = Convert.ToInt64(datarow["CandidateId"].ToString());
                status = string.Format("{0} - {1}", statusInfo, datarow["Title"].ToString());
            }
            sql = string.Format("UPDATE `swilifecore`.`candidate` SET `LastStatus`='{0}' WHERE `CandidateId`='{1}'", QueryBuilder.mySqlEscape(status), canId);
            return DataAccess.Instance.executeNonQueryTransaction(sql, trans);
        }

        public static void CorrectLastStatusCandidates()
        {
            // get all candidate id in running task
            var sql = string.Format("SELECT distinct CandidateId FROM swilifecore.runningtask");
            var dt = DataAccess.Instance.getDataTable(sql);
            // get state of running task
            var status = string.Empty;
            long canId = -1;
            foreach (DataRow datarow in dt.Rows)
            {
                canId = Convert.ToInt64(datarow["CandidateId"].ToString());
                // get last status and job title
                sql = string.Format("select T1.Status, T2.Title from swilifecore.runningtask T1 " +
                                    "left join swilifecore.joborder T2 on T1.JobOrderId = T2.JobOrderId " +
                                    "where T1.CandidateId = {0} order by T2.Modified desc limit 1", canId);
                var tbl = DataAccess.Instance.getDataTable(sql);
                if (tbl.Rows.Count > 0)
                {
                    status = string.Format("{0} - {1}", tbl.Rows[0]["Status"].ToString(), tbl.Rows[0]["Title"].ToString());
                }

                sql = string.Format("UPDATE `swilifecore`.`candidate` SET `LastStatus`='{0}' WHERE `CandidateId`='{1}'", QueryBuilder.mySqlEscape(status), canId);
                DataAccess.Instance.executeInsertingQuery(sql);
                continue;
            }
            return;
        }
    }
}
