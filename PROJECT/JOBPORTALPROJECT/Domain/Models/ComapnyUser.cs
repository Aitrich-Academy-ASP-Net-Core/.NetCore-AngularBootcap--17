using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CompanyUser : SystemUser
    {
        public Guid CompanyId { get; set; }
        public JobProviderCompany Company { get; set; }
        public string Position { get; set; }

      
    }



}

