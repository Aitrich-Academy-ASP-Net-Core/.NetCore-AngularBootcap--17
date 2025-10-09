using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Login.Dtos
{
    public class AdminLoginDto
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
        //public string Email { get; set; }
        //[Required]
        ///*   public string Password { get; set; }*/

        //public string? Token { get; set; }
    }
}

