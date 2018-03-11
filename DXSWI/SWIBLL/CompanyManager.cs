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
    public class CompanyManager
    {
        public static DataTable getAllCompanies()
        {
            return DataAccess.Instance.getCompaniesOverview();
        }

        public static DataTable getNameCompanies()
        {
            string sql = "SELECT CompanyId, Name From swilifecore.company  order by Modified desc";
            return DataAccess.Instance.getDataTable(sql);
        }

        public static Company getCompany(long companyId)
        {
            Company com = null;
            string sql = string.Format("SELECT * FROM swilifecore.company WHERE `CompanyId` = '{0}'", companyId);
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            if (tbl.Rows.Count > 0)
            {
                DataRow datarow = tbl.Rows[0];
                com = Data.CreateItemFromRow<Company>(datarow);
            }
            return com;
        }

        public static bool IsCompanyExisted(Company com)
        {
            // check duplicate:
            string sql = string.Format("select count(*) from swilifecore.company where (char_length(Name) > 0 and Name = '{0}') or (char_length(PrimaryPhone) > 0 and PrimaryPhone = '{1}')"
                , QueryBuilder.mySqlEscape(com.Name), QueryBuilder.mySqlEscape(com.PrimaryPhone));
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

        public static void addNewCompany(Company com)
        {
            if (com == null) return;
            string sql = string.Format("INSERT INTO `swilifecore`.`company` " +
                 "(`Name`, `PrimaryPhone`, `SecondaryPhone`, `FaxNumber`, `Address`, `CountryOfOrigin`, `WebSite`, `KeyTechnologies`, " +
                 "`ServiceContractTerms`, `Industry`, `ABC`, `IsActive`, `MiscNotes`, `City`, `State`, `PostalCode`, `IsHot`, " +
                 "`ContractSigingTime`, `ScanLink`, `UserId`, `Created`, `Modified`) VALUES " +
                 "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', " +
                 "'{15}', '{16}', '{17}', '{18}', '{19}', now(), now())",
                 QueryBuilder.mySqlEscape(com.Name), QueryBuilder.mySqlEscape(com.PrimaryPhone), QueryBuilder.mySqlEscape(com.SecondaryPhone),
                 QueryBuilder.mySqlEscape(com.FaxNumber), QueryBuilder.mySqlEscape(com.Address), QueryBuilder.mySqlEscape(com.CountryOfOrigin),
                 QueryBuilder.mySqlEscape(com.WebSite), QueryBuilder.mySqlEscape(com.KeyTechnologies), QueryBuilder.mySqlEscape(com.ServiceContractTerms),
                 QueryBuilder.mySqlEscape(com.Industry), QueryBuilder.mySqlEscape(com.ABC), Convert.ToInt32(com.IsActive),
                 QueryBuilder.mySqlEscape(com.MiscNotes), QueryBuilder.mySqlEscape(com.City), QueryBuilder.mySqlEscape(com.State),
                 QueryBuilder.mySqlEscape(com.PostalCode), Convert.ToInt32(com.IsHot), com.ContractSigingTime.ToString("yyyy/MM/dd"),
                 QueryBuilder.mySqlEscape(com.ScanLink), com.UserId);
            long company_Id = DataAccess.Instance.executeInsertingQuery(sql);

            Activity act = new Activity()
            {
                Type = "Insert new Company",
                ActivityOf = Activity.TypeOfLogActivity.Company,
                CompanyId = company_Id,
                Notes = string.Format("CompanyId = {0}", company_Id)
            };

            ActivityManager.insert(act);

        }

        public static void UpdateCompany(Company com)
        {
            if (com == null) return;
            string sql = string.Format("UPDATE `swilifecore`.`company` SET `Name`='{0}', `PrimaryPhone`='{1}', `SecondaryPhone`='{2}', `FaxNumber`='{3}', " +
                "`Address`='{4}', `CountryOfOrigin`='{5}', `WebSite`='{6}', `KeyTechnologies`='{7}', `ServiceContractTerms`='{8}', `Industry`='{9}', " +
                "`ABC`='{10}', `IsActive`='{11}', `MiscNotes`='{12}', `City`='{13}', `State`='{14}', `PostalCode`='{15}', `IsHot`='{16}', `ContractSigingTime`='{17}', " +
                "`ScanLink`='{18}', `UserId`='{19}', `Modified`=now() WHERE `CompanyId`='{20}'"
                , QueryBuilder.mySqlEscape(com.Name), QueryBuilder.mySqlEscape(com.PrimaryPhone), QueryBuilder.mySqlEscape(com.SecondaryPhone), QueryBuilder.mySqlEscape(com.FaxNumber),
                QueryBuilder.mySqlEscape(com.Address), QueryBuilder.mySqlEscape(com.CountryOfOrigin), QueryBuilder.mySqlEscape(com.WebSite), QueryBuilder.mySqlEscape(com.KeyTechnologies), QueryBuilder.mySqlEscape(com.ServiceContractTerms), QueryBuilder.mySqlEscape(com.Industry),
                QueryBuilder.mySqlEscape(com.ABC), Convert.ToInt32(com.IsActive), QueryBuilder.mySqlEscape(com.MiscNotes), QueryBuilder.mySqlEscape(com.City), QueryBuilder.mySqlEscape(com.State), QueryBuilder.mySqlEscape(com.PostalCode), Convert.ToInt32(com.IsHot), com.ContractSigingTime.ToString("yyyy/MM/dd"),
                QueryBuilder.mySqlEscape(com.ScanLink), com.UserId, com.CompanyId);
            DataAccess.Instance.executeNonQuery(sql);
            Activity act = new Activity()
            {
                Type = "Update Company",
                ActivityOf = Activity.TypeOfLogActivity.Company,
                CompanyId = com.CompanyId,
                Notes = string.Format("CompanyId = {0} company name = {1}", com.CompanyId, com.Name)
            };

            ActivityManager.insert(act);
        }
        public static void deleteCompany(long comId)
        {
            try
            {
                DataAccess.Instance.StartTransaction();

                // delete company
                string sql = string.Format("DELETE FROM `swilifecore`.`company` WHERE `CompanyId`='{0}'", comId);
                DataAccess.Instance.executeNonQueryTransaction(sql);
                // delete contact
                sql = string.Format("delete from `swilifecore`.`contact` where `CompanyId`='{0}'", comId);
                DataAccess.Instance.executeNonQueryTransaction(sql);

                sql = string.Format("select JobOrderId from `swilifecore`.`joborder` where `CompanyId`='{0}'", comId);
                MySqlDataReader reader = DataAccess.Instance.getReader(sql);
                while (reader.Read())
                {
                    long jobId = reader.GetInt64(0);
                    if (jobId > 0)
                    {
                        // delete all running task 
                        sql = string.Format("DELETE FROM `swilifecore`.`runningtask` WHERE `JobOrderId`='{0}'", jobId);
                        DataAccess.Instance.executeNonQueryTransaction(sql);
                    }
                }
                reader.Dispose();

                // delete JobOrder 
                sql = string.Format("delete from `swilifecore`.`joborder` where `CompanyId`='{0}'", comId);
                DataAccess.Instance.executeNonQueryTransaction(sql);


                DataAccess.Instance.executeNonQueryTransaction(sql);
                // commit 
                DataAccess.Instance.commitTransaction();

                Activity act = new Activity()
                {
                    Type = "Delete Company",
                    ActivityOf = Activity.TypeOfLogActivity.Company,
                    CompanyId = comId,
                    Notes = string.Format("CompanyId = {0}", comId)
                };

                ActivityManager.insert(act);
            }
            catch
            {
                DataAccess.Instance.rollbackTransaction();
                throw;
            }
        }
    }
}
