using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Domain.Enum;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class JobPost
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }
        public string Location { get; set; }
        public decimal Salary { get; set; }

        // FK to JobProvider (your friend will handle the JobProvider model)
        [Required]
        public Guid JobProviderId { get; set; }

        // Navigation
        // public JobProvider JobProvider { get; set; }  // your friend will add this

        // Applications
        public ICollection<JobApplication> Applications { get; set; }

        public ICollection<SavedJob> SavedBy { get; set; } = new List<SavedJob>();
    }
}
