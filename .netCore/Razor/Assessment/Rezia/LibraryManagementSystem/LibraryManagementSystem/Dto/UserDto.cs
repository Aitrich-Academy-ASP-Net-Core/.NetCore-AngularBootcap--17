using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Dto
{
    public class UserDto
    {
        public string UserName { get; set; }
        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string UserEmail { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }

    }
}
