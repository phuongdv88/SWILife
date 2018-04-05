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
    public class EmailTemplateManager
    {
        public async static Task<DataTable> GetEmailTemplatesAsync()
        {
            string sql = string.Format("SELECT T1.*, T2.UserName as Owner FROM swilifecore.emailtemplate T1 left join swilifecore.user T2 on T1.UserId = T2.UserId order by T1.Type");
            DataTable tbl = null;
            await Task.Run(() =>
            {
                tbl = DataAccess.Instance.getDataTable(sql);
            });            
            return tbl;
        }

        public static EmailTemplate GetEmailTemplateById(int tempId, ref List<string> listTitle)
        {
            if (tempId < 0)
            {
                string sql1 = string.Format("SELECT Title FROM swilifecore.emailtemplate");
                DataTable dt = DataAccess.Instance.getDataTable(sql1);
                if (dt == null) return null;
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    DataRow data_row = dt.Rows[i];
                    listTitle.Add(data_row["Title"].ToString());
                }
                return null;
            }
            string sql = string.Format("SELECT T1.*, T2.UserName as Owner FROM swilifecore.emailtemplate T1 left join swilifecore.user T2 on T1.UserId = T2.UserId where T1.EmailTemplateId = '{0}'", tempId);
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            EmailTemplate temp = null;
            if (tbl.Rows.Count > 0)
            {
                DataRow datarow = tbl.Rows[0];
                temp = Data.CreateItemFromRow<EmailTemplate>(datarow);
            }
            return temp;
        }

        public static void InsertEmailTemplate(EmailTemplate temp)
        {
            temp.UserId = UserManager.ActivatedUser.UserId;
            string sql = string.Format("INSERT INTO `swilifecore`.`emailtemplate` " + 
                "(`Language`, `Type`, `Title`, `Subject`, `Content`, `UserId`) " + 
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                QueryBuilder.mySqlEscape(temp.Language), QueryBuilder.mySqlEscape(temp.Type), QueryBuilder.mySqlEscape(temp.Title),
                QueryBuilder.mySqlEscape(temp.Subject) , QueryBuilder.mySqlEscape(temp.Content), temp.UserId);
            DataAccess.Instance.executeNonQuery(sql);
        }

        public static void UpdateEmailTemplate(EmailTemplate temp)
        {
            string sql = string.Format("UPDATE `swilifecore`.`emailtemplate` SET `Language`='{0}', `Type`='{1}', `Title`='{2}', `Subject`='{3}' " +
                ", `Content`='{4}' WHERE `EmailTemplateId`='{5}'",
                QueryBuilder.mySqlEscape(temp.Language), QueryBuilder.mySqlEscape(temp.Type), QueryBuilder.mySqlEscape(temp.Title),
                QueryBuilder.mySqlEscape(temp.Subject), QueryBuilder.mySqlEscape(temp.Content), temp.EmailTemplateId);

            DataAccess.Instance.executeNonQuery(sql);
        }

        public static void DeleteEmailTemplate(int tempId)
        {
            string sql = string.Format("DELETE FROM `swilifecore`.`emailtemplate` WHERE `EmailTemplateId`='{0}';", tempId);
            DataAccess.Instance.executeNonQuery(sql);
        }
    }
}
