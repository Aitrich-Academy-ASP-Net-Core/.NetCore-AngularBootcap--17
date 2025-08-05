using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Model
{
    public class Customer


    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Format")]
        public string Email { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public string Commends { get; set; }


    }
}
