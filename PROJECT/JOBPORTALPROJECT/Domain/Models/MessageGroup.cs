using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class MessageGroup
    {
        [Key]
        public Guid Id { get; set; }
        public string GroupName { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}
