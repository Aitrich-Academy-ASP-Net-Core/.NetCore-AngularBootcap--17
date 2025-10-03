using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Resume
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FilePath { get; set; }

        [Required]
        public Guid ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
