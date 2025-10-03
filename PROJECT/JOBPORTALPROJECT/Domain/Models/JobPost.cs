using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class JobPost
    {
        public Guid Id { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public Guid LocationId { get; set; }
        public Location Location { get; set; }
        public Guid IndustryId { get; set; }
        public Industry Industry { get; set; }
        public Guid JobCategoryId { get; set; }
        public JobCategory JobCategory { get; set; }
        public Guid PostedById { get; set; }
        public CompanyUser PostedBy { get; set; }
        public DateTime PostDate { get; set; }
    }

}
