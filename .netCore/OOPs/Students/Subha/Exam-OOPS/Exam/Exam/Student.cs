using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Student
    {
       
        public string Name { get; set; }
        public string DeptName { get; set; }
        public int Age { get; set; }
        public int Mark1 {  get; set; }
        public int Mark2 { get; set; }

        public int Mark3 { get; set; }
        public int Mark4 { get; set; }
        public int Mark5 { get; set; }
        public int Mark6 { get; set; }
        public int CGPA { get; set; }
        
      

                public void FindCGPA(float CGPA) 
        { 

           
            if (CGPA > 9 && CGPA < 10)
            {
                Console.WriteLine("Grade A");
            }
            else if (CGPA > 8 && CGPA < 9)
            {
                Console.WriteLine("Grade B");
            }
            else if (CGPA > 7 && CGPA < 8)
            {
                Console.WriteLine("Grade C");
            }
            else if (CGPA > 6 && CGPA < 7)
            {
                Console.WriteLine("Grade D");
            }
            else if (CGPA > 5 && CGPA < 6)
            {
                Console.WriteLine("Grade E");
            }
            else
            { Console.WriteLine("Failed"); }
        }
    }
}
