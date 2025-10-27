using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Resume
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime UploadedOn { get; set; }

        public Guid? ProfileId { get; set; }  // nullable
        public JobSeekerProfile Profile { get; set; }
        public byte[] FileData { get; set; } = Array.Empty<byte>();
        public Guid? JobSeekerId { get; set; }
        public JobSeeker JobSeeker { get; set; }
    }
}
