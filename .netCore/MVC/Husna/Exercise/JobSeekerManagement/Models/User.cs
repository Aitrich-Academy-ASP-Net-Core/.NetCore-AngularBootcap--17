using System.ComponentModel.DataAnnotations;

namespace JobSeekerManagement.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [StringLength(250)]
        public string? Skills { get; set; }

        [StringLength(500)]
        public string? Experience { get; set; }
        [Required]
        public string Gender { get; set; } = string.Empty;   // 👈 Added Gender

    }
}
