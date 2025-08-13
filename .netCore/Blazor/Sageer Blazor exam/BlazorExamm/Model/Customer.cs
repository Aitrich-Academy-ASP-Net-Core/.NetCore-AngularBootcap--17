using System.ComponentModel.DataAnnotations;

namespace BlazorExamm.Model
{
    public class Customer
    {
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public string Comments { get; set; }
        [Required]
    }
}
