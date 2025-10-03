using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class JobApplication
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid JobSeekerId { get; set; }
        public JobSeeker JobSeeker { get; set; }

        [Required]
        public Guid JobPostId { get; set; }
        public JobPost JobPost { get; set; }

        public DateTime AppliedOn { get; set; } = DateTime.UtcNow;
    }
}
