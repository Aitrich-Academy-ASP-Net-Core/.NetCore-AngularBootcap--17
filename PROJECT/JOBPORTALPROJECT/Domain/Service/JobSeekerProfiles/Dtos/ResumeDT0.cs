using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.JobSeekerProfiles.Dtos
{
    public class ResumeDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime UploadedOn { get; set; }

        public Guid? JobSeekerId { get; set; }

    }
}

