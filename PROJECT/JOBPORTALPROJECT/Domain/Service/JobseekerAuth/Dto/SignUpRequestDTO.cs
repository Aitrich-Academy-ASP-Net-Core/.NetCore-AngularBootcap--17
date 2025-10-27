using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.JobseekerAuth.Dto
{
    public class SignupRequestDTO
    {
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }  // “JOB_SEEKER” / “JOB_PROVIDER”
    }
}
