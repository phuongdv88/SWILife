using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWIBLL.Models
{
    public class ResourceObject
    {
        public int UniqueID { get; set; }
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public int Color { get; set; }
        public char[] Image { get; set; }
        public string CustomField { get; set; }
    }
}
