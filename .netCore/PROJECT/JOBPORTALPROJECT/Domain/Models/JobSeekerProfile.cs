using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class JobSeekerProfile
    {
        public Guid Id { get; set; }
        public Guid JobSeekerId { get; set; }
        public string Summary { get; set; }
        public ICollection<Qualification> Qualifications { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<Experience> Experiences { get; set; }
    }
}
