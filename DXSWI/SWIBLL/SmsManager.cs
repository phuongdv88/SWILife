using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWIDAL;
using SWIBLL.Models;
using System.Data;
using System.Text.RegularExpressions;

namespace SWIBLL
{
    public class SmsManager
    {
        public static List<SmsTemplate> GetlistSmsTemplates()
        {
            List<SmsTemplate> lt = new List<SmsTemplate>();
            string sql = "SELECT * FROM swilifecore.smstemplate";
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            foreach (DataRow row in tbl.Rows)
            {
                lt.Add(Data.CreateItemFromRow<SmsTemplate>(row));
            }
            return lt;
        }

        public static void InsertSmsTemplate(SmsTemplate sms)
        {
            string sql = string.Format("INSERT INTO `swilifecore`.`smstemplate` (`Title`, `Message`) VALUES ('{0}', '{1}')",
                                        QueryBuilder.mySqlEscape(sms.Title), QueryBuilder.mySqlEscape(sms.Message));
            DataAccess.Instance.executeNonQuery(sql);

        }
        public static void UpdateSmsTemplate(SmsTemplate sms)
        {
            string sql = string.Format("UPDATE `swilifecore`.`smstemplate` SET `Title`='{0}', `Message`='{1}' WHERE `SmsTemplateId`='{2}'",
                                        QueryBuilder.mySqlEscape(sms.Title), QueryBuilder.mySqlEscape(sms.Message), sms.SmsTemplateId);
            DataAccess.Instance.executeNonQuery(sql);
        }
        public static void DeleteSmsTemplate(SmsTemplate sms)
        {
            string sql = string.Format("DELETE FROM `swilifecore`.`smstemplate` WHERE `SmsTemplateId`='{0}'", sms.SmsTemplateId);
            DataAccess.Instance.executeNonQuery(sql);
        }


        //------------- sending message-------------
        public static List<SmsSending> GetlistSmsSending()
        {
            List<SmsSending> lt = new List<SmsSending>();
            string sql = "SELECT * FROM swilifecore.smssending";
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            foreach (DataRow row in tbl.Rows)
            {
                lt.Add(Data.CreateItemFromRow<SmsSending>(row));
            }
            return lt;
        }
        public static DataTable GetDataTableSmsSending()
        {
            string sql = "SELECT T1.* , concat_ws(' ', ifnull(T2.FirstName, ''), ifnull(T2.LastName, '')) as 'CandidateName' FROM swilifecore.smssending T1 left join swilifecore.candidate T2 on T1.CandidateId = T2.CandidateId order by SmsSendingId";
            return DataAccess.Instance.getDataTable(sql);
        }
        public static async Task<DataTable> GetDataTableSmsSendingAsync()
        {
            string sql = "SELECT T1.* , concat_ws(' ', ifnull(T2.FirstName, ''), ifnull(T2.LastName, '')) as 'CandidateName' FROM swilifecore.smssending T1 left join swilifecore.candidate T2 on T1.CandidateId = T2.CandidateId order by SmsSendingId desc";
            DataTable x = null;
            await Task.Run(() =>
            {
                x = DataAccess.Instance.getDataTable(sql);
            });
            return x;
        }
        public static List<SmsSending> GetlistSmsWaitToSend()
        {
            List<SmsSending> lt = new List<SmsSending>();
            string sql = "SELECT * FROM swilifecore.smssending where Status = 'Waiting' order by SmsSendingId";
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            foreach (DataRow row in tbl.Rows)
            {
                lt.Add(Data.CreateItemFromRow<SmsSending>(row));
            }
            return lt;
        }
        public static List<SmsSending> GetlistSmsToResending()
        {
            List<SmsSending> lt = new List<SmsSending>();
            string sql = "SELECT * FROM swilifecore.smssending where Status = 'Resending' order by SmsSendingId";
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            foreach (DataRow row in tbl.Rows)
            {
                lt.Add(Data.CreateItemFromRow<SmsSending>(row));
            }
            return lt;
        }

        public static void InsertSmsSending(SmsSending sms)
        {
            string sql = string.Format("INSERT INTO `swilifecore`.`smssending` (`PhoneNumber`, `Message`, `Status`, `TimeToSend`, `CandidateId`) VALUES ('{0}', '{1}', 'Waiting', '{2}', '{3}')",
                                        QueryBuilder.mySqlEscape(sms.PhoneNumber), QueryBuilder.mySqlEscape(sms.Message), sms.TimeToSend.ToString("yyyy-MM-dd HH:mm:ss"), sms.CandidateId);
            DataAccess.Instance.executeNonQuery(sql);



        }
        public static void UpdateSmsSending(SmsSending sms)
        {
            string sql = string.Format("UPDATE `swilifecore`.`smssending` SET `PhoneNumber`='{0}', `Message`='{1}', `Status`='{2}', `TimeToSend`='{3}', `CandidateId`='{4}' WHERE `SmsSendingId`='{5}'",
                                        QueryBuilder.mySqlEscape(sms.PhoneNumber), QueryBuilder.mySqlEscape(sms.Message), QueryBuilder.mySqlEscape(sms.Status), sms.TimeToSend.ToString("yyyy-MM-dd HH:mm:ss"),sms.CandidateId, sms.SmsSendingId);
            DataAccess.Instance.executeNonQuery(sql);
        }
        public static void ResendSmsSending(long smsId)
        {
            string sql = string.Format("UPDATE `swilifecore`.`smssending` SET `Status`='Waiting', `TimeToSend`=now() WHERE `SmsSendingId`='{0}'", smsId);
            DataAccess.Instance.executeNonQuery(sql);
        }
        public static void DeleteSmsSending(int smsId)
        {
            string sql = string.Format("DELETE FROM `swilifecore`.`smssending` WHERE `SmsSendingId`='{0}'", smsId);
            DataAccess.Instance.executeNonQuery(sql);
        }

        //--------------- Receiving message--------------
        public static List<SmsReceiving> GetlistSmsReceiving()
        {
            List<SmsReceiving> lt = new List<SmsReceiving>();
            string sql = "SELECT * FROM swilifecore.smsreceiving";
            DataTable tbl = DataAccess.Instance.getDataTable(sql);
            foreach (DataRow row in tbl.Rows)
            {
                lt.Add(Data.CreateItemFromRow<SmsReceiving>(row));
            }

            return lt;
        }
        public static DataTable GetDataTableSmsReceiving()
        {
            string sql = "SELECT T1.*, concat_ws(' ', ifnull(T2.FirstName, ''), ifnull(T2.LastName, '')) as 'CandidateName' FROM swilifecore.smsreceiving T1 left join swilifecore.candidate T2 on T1.CandidateId = T2.CandidateId order by T1.SmsReceivingId";
            return DataAccess.Instance.getDataTable(sql);
        }
        public static async Task<DataTable> GetDataTableSmsReceivingAsync()
        {
            string sql = "SELECT T1.*, concat_ws(' ', ifnull(T2.FirstName, ''), ifnull(T2.LastName, '')) as 'CandidateName' FROM swilifecore.smsreceiving T1 left join swilifecore.candidate T2 on T1.CandidateId = T2.CandidateId order by T1.SmsReceivingId desc";
            DataTable x = null;
            await Task.Run(() =>
            {
                x = DataAccess.Instance.getDataTable(sql);
            });
            return x;
        }

        public static long getCandidateIdFromNumber(string phoneNumber)
        {
            var phone = Regex.Replace(phoneNumber, "\\D+", "", RegexOptions.Multiline);
            if (phone.StartsWith("84"))
            {
                phone = phone.Remove(0, 2);
            }
            string sql = string.Format("SELECT CandidateId FROM swilifecore.candidate where Cellphone like '%{0}' or WorkPhone like '%{0}'", phone);
            long canId = -1;
            MySql.Data.MySqlClient.MySqlDataReader reader = DataAccess.Instance.getReader(sql);
            try
            {
                while (reader.Read())
                {
                    if (reader[0] != null)
                    {
                        canId = Convert.ToInt64(reader[0].ToString());
                    }
                    break;
                }
            }
            catch
            {
            }
            finally
            {
                reader.Dispose();
            }
            return canId;
        }
        public static void InsertSmsReceiving(SmsReceiving sms)
        {
            string sql = string.Format("INSERT INTO `swilifecore`.`smsreceiving` (`Index`, `Status`, `Sender`, `Alphabet`, `SentTime`, `Message`, `CandidateId`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                                       sms.Index, QueryBuilder.mySqlEscape(sms.Status),
                                       QueryBuilder.mySqlEscape(sms.Sender), QueryBuilder.mySqlEscape(sms.Alphabet),
                                       QueryBuilder.mySqlEscape(sms.SentTime), QueryBuilder.mySqlEscape(sms.Message), sms.CandidateId);
            DataAccess.Instance.executeNonQuery(sql);
        }
        public static void UpdateSmsReceiving(SmsReceiving sms)
        {
            string sql = string.Format("UPDATE `swilifecore`.`smsreceiving` SET `Index`='{0}', `Status`='{1}', `Sender`='{2}', `Alphabet`='{3}', `SentTime`='{4}', `Message`='{5}', `CandidateId`='{6}' WHERE `SmsReceivingId`='{7}';",
                                       sms.Index, QueryBuilder.mySqlEscape(sms.Status),
                                       QueryBuilder.mySqlEscape(sms.Sender), QueryBuilder.mySqlEscape(sms.Alphabet),
                                       QueryBuilder.mySqlEscape(sms.SentTime), QueryBuilder.mySqlEscape(sms.Message),sms.CandidateId, sms.SmsReceivingId);
            DataAccess.Instance.executeNonQuery(sql);
        }
        public static void DeleteSmsReceiving(int smsId)
        {
            string sql = string.Format("DELETE FROM `swilifecore`.`smsreceiving` WHERE `SmsReceivingId`='{0}'", smsId);
            DataAccess.Instance.executeNonQuery(sql);
        }

        public static string FromHexString(string hexString)
        {
            var bytes = new byte[hexString.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            return Encoding.BigEndianUnicode.GetString(bytes);
        }

        public static void CorrectSms()
        {
            var listSms = GetlistSmsReceiving();
            foreach (var sms in listSms)
            {
                try
                {
                    if (Regex.IsMatch(sms.Message, "^\\d+"))
                    {
                        sms.Message = FromHexString(sms.Message);
                        UpdateSmsReceiving(sms);
                    }
                }
                catch
                {
                }
            }
        }

        public static void CorrectSmsCandidateId()
        {
            var listSms = GetlistSmsReceiving();
            foreach (var sms in listSms)
            {
                try
                {
                    sms.CandidateId = SmsManager.getCandidateIdFromNumber(sms.Sender);
                    DateTime tmp = DateTime.ParseExact(sms.SentTime, "yy/MM/dd,HH:mm:ss+28", null);
                    if (tmp != null)
                    {
                        sms.SentTime = tmp.ToString("yyyy-MM-dd HH:mm:ss");
                    }
                    else
                    {
                        sms.SentTime = sms.SentTime.Replace(",", " ").Replace("/", "-").Replace("+28", "");
                    }
                    UpdateSmsReceiving(sms);
                }
                catch
                {
                }
            }
            var listSmsSending = GetlistSmsSending();
            foreach (var sms in listSmsSending)
            {
                try
                {
                    sms.CandidateId = SmsManager.getCandidateIdFromNumber(sms.PhoneNumber);
                    UpdateSmsSending(sms);
                }
                catch
                {
                }
            }

        }
    }
}
