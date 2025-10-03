using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MassTransit.ValidationResultExtensions;

namespace Domain.Models
{
    public class JobSeekerProfile
    {
        [Key]
        public Guid Id { get; set; }
        public Guid JobSeekerId { get; set; }
        public JobSeeker JobSeeker { get; set; }

        public string Bio { get; set; }
        public string ContactNumber { get; set; }

        // Navigation
        public ICollection<Resume> Resumes { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<WorkExperience> WorkExperiences { get; set; }
        public ICollection<Qualification> Qualifications { get; set; }
    }
}
