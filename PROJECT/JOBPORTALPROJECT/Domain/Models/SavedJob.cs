using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SavedJob
    {
        public Guid JobSeekerId { get; set; }
        public JobSeeker JobSeeker { get; set; }

        public Guid JobPostId { get; set; }
        public JobPost JobPost { get; set; }

        public DateTime SavedAt { get; set; } = DateTime.UtcNow;
    }
}
