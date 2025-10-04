using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Experience
    {
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public string CompanyName { get; set; }
        public string Role { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
    }
}
