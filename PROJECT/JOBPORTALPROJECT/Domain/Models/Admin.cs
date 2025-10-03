using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
   public class Admin
    {
        public Guid Id { get; set; } 
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } = "ADMIN";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
