using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public Guid FromUserId { get; set; }
        public Guid? ToUserId { get; set; } // optional for group messages
        public Guid? GroupId { get; set; }  // optional for 1-to-1 messages
        public string Content { get; set; }
        public DateTime SentAt { get; set; }
    }
}
