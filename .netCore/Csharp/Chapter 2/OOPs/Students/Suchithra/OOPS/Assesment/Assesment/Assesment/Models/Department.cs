using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.Models
{
    internal class Department:Student
    {
        public  string Name_Department {  get; set; }
        public Department(string dep_name) {

            Name_Department = dep_name;
        }
        public Department() { }
       
    }
}
