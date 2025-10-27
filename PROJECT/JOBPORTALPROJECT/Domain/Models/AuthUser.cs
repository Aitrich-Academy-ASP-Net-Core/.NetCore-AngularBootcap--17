using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Models
{


    public class AuthUser : SystemUser
    {
        public string? Password { get; set; }

        public Guid ProfileId { get; set; }
        public string? ConnectionId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? OTP { get; set; }

        public bool OnlineStatus { get; set; }
    }




}

