using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Activity_2.Models
{
   internal class Student
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string MobileNo { get; set; }
        public ICollection<Mark> Marks { get; set; } = new List<Mark>();
    }
}
