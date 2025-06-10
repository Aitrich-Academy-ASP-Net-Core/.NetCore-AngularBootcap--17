using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1_codefirst.Models
{
   internal class Student
    {
        [Key]
        public int id { get; set; }
        [Required]
         public string Name { get; set; }
        public int Age { get; set; }

    }
}
