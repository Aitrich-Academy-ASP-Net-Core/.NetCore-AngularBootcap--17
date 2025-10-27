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
        public Guid JobSeekerId { get; set; }  // must be included
        public string ProfileName { get; set; }
        public string ProfileSummary { get; set; }

        public ICollection<Resume> Resumes { get; set; } = new List<Resume>();

    }

}

