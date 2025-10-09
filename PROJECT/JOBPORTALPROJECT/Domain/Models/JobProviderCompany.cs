using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class JobProviderCompany
    {
        public Guid Id { get; set; }
        public string LegalName { get; set; }
        public string Website { get; set; }
        public ICollection<CompanyUser> CompanyUsers { get; set; }
        public ICollection<JobPost> JobPosts { get; set; }
    }
}
