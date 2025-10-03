using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class WorkExperience
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public string Role { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Guid ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
