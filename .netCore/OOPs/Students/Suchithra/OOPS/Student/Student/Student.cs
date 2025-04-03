using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void WriteExam()
        {
            Console.WriteLine("Todays Exam is Mathematics");
        }

        public void StudentDetails()
        {
            Console.WriteLine("Student name is:{0},Age is:{1}",Name,Age);

        }
        public Student() {
            Name = "Ajith";
            Age = 24;
        }
        public Student(string name,int age)
        {
            Name = name;
            Age = age;
        }
    }
}
