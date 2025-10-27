using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.JobseekerAuth.Dto
{
   public class SetPasswordDto
    {
        public Guid UserId { get; set; }
        //public string Email { get; set; }
        public string Password { get; set; }


    }
}
