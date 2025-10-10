using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.AdminLogin.DTOs
{
    public class JobProviderDto
    {
        public Guid Id { get; set; }
        public string LegalName { get; set; }
        public string Website { get; set; }
    }
}
