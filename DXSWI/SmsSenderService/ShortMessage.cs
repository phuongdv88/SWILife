using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsSenderService
{
    public class ShortMessage
    {
        public int Index { get; set; }
        public string Status { get; set; }
        public string Sender { get; set; }
        public string Alphabet { get; set; }
        public string SentTime { get; set; }
        public string Message { get; set; }
    }

    public class ShortMessageCollection : List<ShortMessage>
    {

    }
}
