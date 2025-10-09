using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Enums;

namespace Domain.Models
{
    public class Admin
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public Role Role { get; set; } = Role.ADMIN;  // use enum
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
