using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class JobApplication
    {
        public Guid Id { get; set; }
        public Guid JobPostId { get; set; }
        public Guid ApplicantId { get; set; }  // JobSeeker Id
        public Guid ResumeId { get; set; }
        public string CoverLetter { get; set; }
        public DateTime AppliedDate { get; set; }
    }
}
