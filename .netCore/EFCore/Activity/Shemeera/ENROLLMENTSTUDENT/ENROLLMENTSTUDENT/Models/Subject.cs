using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENROLLMENTSTUDENT.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Title { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();





    }
}
