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
        public Guid ProfileId { get; set; }
        public string Title { get; set; }
        public byte[] FileData { get; set; }
        public DateTime UploadedOn { get; set; }
    }
}
