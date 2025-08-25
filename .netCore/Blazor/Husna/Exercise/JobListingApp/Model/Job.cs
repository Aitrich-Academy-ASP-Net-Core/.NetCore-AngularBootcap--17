using System.ComponentModel.DataAnnotations;

namespace JobListingApp.Model
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } // e.g., "Dotnet Developer"

        public string Description { get; set; } // e.g., "Senior dotnet developer."

        [Required]
        public string Company { get; set; } // Icon can represent company

        public string Location { get; set; } // e.g., "Kochi"

        public string JobType { get; set; } // e.g., "Fulltime"

        public string SalaryRange { get; set; } // e.g., "$100000-300000"


        public string ExperienceLevel { get; set; } // e.g., "Senior"
    }
}
