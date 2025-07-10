using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }
        [Required]
        [StringLength (100)]
        [EmailAddress]
        public string UserEmail { get; set; }
        [Required]
        [StringLength (100)]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
        
    }
}
