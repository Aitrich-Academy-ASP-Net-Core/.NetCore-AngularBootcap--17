using System.ComponentModel.DataAnnotations;

namespace JobSeekerManagement.Dto
{
    public class ApplicationDto
    {
        [Required]
        public int JobId { get; set; }

        [Required]
        public int UserId { get; set; }

        public DateTime AppliedOn { get; set; } = DateTime.Now;
        public string Title { get; set; }
        public string Company { get; set; }
    }
}
