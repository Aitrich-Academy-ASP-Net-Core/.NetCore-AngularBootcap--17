using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.JobseekerAuth.Dto
{
    public class JobSeekerRegisterDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }  // nullable

    }
}
