using System.ComponentModel.DataAnnotations;


namespace JobSeekerManagement.Models
    {
        public class Job
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [StringLength(100)]
            public string Title { get; set; } = string.Empty;

            [Required]
            [StringLength(100)]
            public string Company { get; set; } = string.Empty;

            [Required]
            [StringLength(200)]
            public string Location { get; set; } = string.Empty;

            [StringLength(1000)]
            public string Description { get; set; } = string.Empty;

            [Required]
            [StringLength(50)]
            public string SalaryRange { get; set; } = string.Empty;  // 👈 Added Salary Range

            [Required]
            [StringLength(50)]
            public string EmploymentType { get; set; } = string.Empty;  // 👈 Added Employment Type
        public ICollection<Application> Applications { get; set; }                                                            // e.g., "Full-Time", "Part-Time", "Internship", "Contract"
    }
    }


