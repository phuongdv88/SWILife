using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWIBLL.Models
{
    public class SmsSending
    {
        public int SmsSendingId { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public DateTime TimeToSend { get; set; }
    }

    public class SmsReceiving
    {
        public int SmsReceivingId { get; set; }
        public int Index { get; set; }
        public string Status { get; set; }
        public string Sender { get; set; }
        public string Alphabet { get; set; }
        public string SentTime { get; set; }
        public string Message { get; set; }
    }
    public class SmsReceivingCollection : List<SmsReceiving>
    {

    }

    public class SmsTemplate
    {
        public int SmsTemplateId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
