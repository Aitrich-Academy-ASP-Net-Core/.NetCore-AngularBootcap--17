using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class MessageGroup
    {
        public Guid Id { get; set; }
        public string GroupName { get; set; }
        public List<Guid> ParticipantIds { get; set; } = new List<Guid>();
        public DateTime CreatedAt { get; set; }
    }
}
