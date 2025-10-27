using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobSeekerManagement.Models
{
    public class Application
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        [Required]
        public User User { get; set; }

        [Required]
        public int JobId { get; set; }
        [ForeignKey("JobId")]
        [Required]
        public Job Job { get; set; }

        public DateTime AppliedOn { get; set; } = DateTime.Now;
    }
}
