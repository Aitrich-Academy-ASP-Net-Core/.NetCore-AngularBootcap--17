using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Exam : Student
    {
        public int Mark;

        public Exam(string name, int rollnumber , int mark) : base ( name ,rollnumber)
            {
            Mark = mark;

            }
        public void Display()
        {
            Console.WriteLine($"Name :{Name} \n Rollno :  {RollNumber} \n  MARK : {Mark}");
        }

    }
}
