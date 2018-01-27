using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWIBLL.Models
{
    public class EmailTemplate
    {
        public int EmailTemplateId { get; set; }
        public string Language { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public long UserId { get; set; }
        public string Owner { get; set; }

        public EmailTemplate()
        {
            EmailTemplateId = -1;
            Language = string.Empty;
            Type = string.Empty;
            Title = string.Empty;
            Subject = string.Empty;
            Content = string.Empty;
            UserId = -1;
            Owner = string.Empty;
        }
    }
}
