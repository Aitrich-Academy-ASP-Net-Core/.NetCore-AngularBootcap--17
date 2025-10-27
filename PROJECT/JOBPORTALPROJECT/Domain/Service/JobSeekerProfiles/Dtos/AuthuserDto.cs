using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.JobSeekerProfiles.Dtos
{
    public class AuthuserDto
    {
        public Guid Id { get; set; }            // User ID
        public Guid ProfileId { get; set; }     // Add this to reference the JobSeekerProfile

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public string? OTP { get; set; }


    }
}
