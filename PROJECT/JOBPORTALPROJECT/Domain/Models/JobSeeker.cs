using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class JobSeeker
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid AuthUserId { get; set; }
        public AuthUser AuthUser { get; set; }

        // One-to-Many Profiles
        public ICollection<JobSeekerProfile> Profiles { get; set; } = new List<JobSeekerProfile>();

        // Applications
        public ICollection<JobApplication> Applications { get; set; } = new List<JobApplication>();

        // Saved Jobs (Many-to-Many with JobPost)
        public ICollection<SavedJob> SavedJobs { get; set; } = new List<SavedJob>();
    }
}
