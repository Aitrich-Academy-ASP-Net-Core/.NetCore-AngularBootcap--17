using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Qualification
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Degree { get; set; }

        [Required]
        public string University { get; set; }

        public int YearOfPassing { get; set; }

        public Guid ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
