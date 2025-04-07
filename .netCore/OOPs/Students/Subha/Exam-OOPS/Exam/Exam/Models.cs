using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class StudentClass
    {

        public string Name { get; set; }
       
        public int Age { get; set; }
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }

        public int Mark3 { get; set; }
        public int Mark4 { get; set; }
        public int Mark5 { get; set; }
        public int Mark6 { get; set; }
        public int CGPA { get; set; }
        public void AddStudent() { }
        public void ListStudent() { }
        public void FindCGPA() { }

    }

    internal class DepartmentClass
    {
        public string DeptName { get; set; }
        public void FindTopper() { }

    }
}
