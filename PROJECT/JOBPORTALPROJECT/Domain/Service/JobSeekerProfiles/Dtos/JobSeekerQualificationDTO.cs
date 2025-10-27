using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.JobSeekerProfiles.Dtos
{
    public class JobSeekerQualificationDTO
    {
        public Guid Id { get; set; }
        public string QualificationName { get; set; }
        public string University { get; set; }
        public string Grade { get; set; }
        public DateTime PassingYear { get; set; }


    }
}
