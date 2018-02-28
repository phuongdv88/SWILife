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

        public static void InsertSmsSending(SmsSending sms)
        {
            string sql = string.Format("INSERT INTO `swilifecore`.`smssending` (`PhoneNumber`, `Message`, `Status`, `TimeToSend`) VALUES ('{0}', '{1}', 'Waiting', '{2}')",
                                        QueryBuilder.mySqlEscape(sms.PhoneNumber), QueryBuilder.mySqlEscape(sms.Message), sms.TimeToSend.ToString("yyyy-MM-dd HH:mm:ss"));
            DataAccess.Instance.executeNonQuery(sql);
        }
        public static void UpdateSmsSending(SmsSending sms)
        {
            string sql = string.Format("UPDATE `swilifecore`.`smssending` SET `PhoneNumber`='{0}', `Message`='{1}', `Status`='{2}', `TimeToSend`='{3}' WHERE `SmsSendingId`='{4}'",
                                        QueryBuilder.mySqlEscape(sms.PhoneNumber), QueryBuilder.mySqlEscape(sms.Message), QueryBuilder.mySqlEscape(sms.Status), sms.TimeToSend.ToString("yyyy-MM-dd HH:mm:ss"), sms.SmsSendingId);
            DataAccess.Instance.executeNonQuery(sql);
        }
        public static void DeleteSmsSending(SmsSending sms)
        {
            string sql = string.Format("DELETE FROM `swilifecore`.`smssending` WHERE `SmsSendingId`='{0}'", sms.SmsSendingId);
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

        public static void InsertSmsReceiving(SmsReceiving sms)
        {
            string sql = string.Format("INSERT INTO `swilifecore`.`smsreceiving` (`Index`, `Status`, `Sender`, `Alphabet`, `SentTime`, `Message`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                                       sms.Index, QueryBuilder.mySqlEscape(sms.Status),
                                       QueryBuilder.mySqlEscape(sms.Sender), QueryBuilder.mySqlEscape(sms.Alphabet),
                                       QueryBuilder.mySqlEscape(sms.SentTime), QueryBuilder.mySqlEscape(sms.Message));
            DataAccess.Instance.executeNonQuery(sql);
        }
        public static void UpdateSmsReceiving(SmsReceiving sms)
        {
            string sql = string.Format("UPDATE `swilifecore`.`smsreceiving` SET `Index`='{0}', `Status`='{1}', `Sender`='{2}', `Alphabet`='{3}', `SentTime`='{4}', `Message`='{5}' WHERE `SmsReceivingId`='{6}';",
                                       sms.Index, QueryBuilder.mySqlEscape(sms.Status),
                                       QueryBuilder.mySqlEscape(sms.Sender), QueryBuilder.mySqlEscape(sms.Alphabet),
                                       QueryBuilder.mySqlEscape(sms.SentTime), QueryBuilder.mySqlEscape(sms.Message), sms.SmsReceivingId);
            DataAccess.Instance.executeNonQuery(sql);
        }
        public static void DeleteSmsReceiving(SmsReceiving sms)
        {
            string sql = string.Format("DELETE FROM `swilifecore`.`smsreceiving` WHERE `SmsReceivingId`='{0}'", sms.SmsReceivingId);
            DataAccess.Instance.executeNonQuery(sql);
        }
    }
}
