using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Activity_2.Models
{
   internal class Mark
    {
        [Key]
        public int MarkId { get; set; }
        [Required]

        [ForeignKey("Student")]
        public int Studentid { get; set; }
        public Student Student1 { get; set; }

        public int M1 { get; set; }
        public int M2 { get; set; }
        public int M3 { get; set; }
    }
}
