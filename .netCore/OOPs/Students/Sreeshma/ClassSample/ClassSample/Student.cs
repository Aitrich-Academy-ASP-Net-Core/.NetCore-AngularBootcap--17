using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    internal class Student
    {
        public string ? Name { get; set; }
        public int Age { get; set; }

        public void SetTotalMarks()
        {
            Console.WriteLine("Enter total Marks");
        }

        public void PrintStudentDetails()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
        }

        public Student() 
        {
            Name = "Rakhi";
            Age = 32;
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
