using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SavedJob
    {
        public Guid Id { get; set; }
        public Guid JobPostId { get; set; }
        public Guid SavedById { get; set; }  // JobSeeker Id
        public DateTime SavedDate { get; set; }
    }
}
