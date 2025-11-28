using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Authuser.Dto
{
    public class AuthUserDTO
    {
        public Guid JobseekerId { get; set; }
        public string? UserName { get; set; }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IFormFile? Image { get; set; } // Added for image upload
        public string? Phone { get; set; }

        public string? Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }  // If you return JWT token
    }
}
