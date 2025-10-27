using System.ComponentModel.DataAnnotations;

namespace JobPortalApp.API.JobSeekerr.RequestObjects
{
    public class JobSeekerLoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
