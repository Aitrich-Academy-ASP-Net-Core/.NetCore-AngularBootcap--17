using System.ComponentModel.DataAnnotations;

namespace JobSeekerManagement.Dto
{
    public class ProfileDto
    {
        public int UserId { get; set; }  // 👈 Add this
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Phone]
        [StringLength(15)]
        public string Phone { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Location { get; set; }

   

        [StringLength(250)]
        public string? Skills { get; set; }

     

        [StringLength(500)]
        public string? Experience { get; set; }
    }
}
