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
    public class CandidateManager
    {
        int mPageNumber = 1;
        int mPageSize = 50;
        private int mNumberCandidates;

        public int NumberOfCandidates
        {
            get { return mNumberCandidates; }
            set { mNumberCandidates = value; }
        }


        public int PageNumber {
            get { return mPageNumber; }
            set { mPageNumber = value; }
        }

        public int PageSize
        {
            get { return mPageSize; }
            set { mPageSize = value; }
        }

        public CandidateManager()
        {
            NumberOfCandidates = DataAccess.Instance.getNumberOfCandidates();
        }
        ~CandidateManager()
        {
                
        }

        //public DataTable getCurrentPages()
        //{
        //    return GetLimitedCandidates(mPageNumber, mPageSize);
        //}

        //public DataTable getNextPage()
        //{
        //    ++mPageNumber;
        //    return  getCurrentPages();
        //}
        //public DataTable getPreviewPage()
        //{
        //    --mPageNumber;
        //    return getCurrentPages();
        //}

        public int getNumberOfPages()
        {
            return (mNumberCandidates + mPageSize - 1) / mPageSize;
        }


        public DataTable  GetLimitedCandidates(int page_count, int page_size)
        {
            return DataAccess.Instance.getLimitedCandidates((page_count - 1) * page_size, page_size);
        }

        public DataTable GetAllCandidatesOverView()
        {
            return DataAccess.Instance.getCandidatesOverview();
        }

        public static void deleteCadidate(long CandidateId)
        {
            //DELETE FROM `swilifecore`.`candidate` WHERE `CandidateId`='5';
            string sql = string.Format("DELETE FROM `swilifecore`.`candidate` WHERE `CandidateId`='{0}'", CandidateId);
            try
            {
                DataAccess.Instance.StartTransaction();

                DataAccess.Instance.executeNonQueryTransaction(sql);
                // delete running task 
                sql = string.Format("DELETE FROM `swilifecore`.`runningtask` WHERE `CandidateId`='{0}'", CandidateId);
                DataAccess.Instance.executeNonQueryTransaction(sql);
                // commit 
                DataAccess.Instance.commitTransaction();
                Activity act = new Activity()
                {
                    Type = "Delete Candidate",
                    ActivityOf = Activity.TypeOfLogActivity.Candidate,
                    CandidateId = CandidateId,
                };

                ActivityManager.insert(act);
            }
            catch
            {
                DataAccess.Instance.rollbackTransaction();
                throw;
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
            if(tbl.Rows.Count > 0)
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

    }
}
