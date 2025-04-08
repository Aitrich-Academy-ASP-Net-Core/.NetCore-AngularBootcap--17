using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentscore
{
    class Student
    {
        public string Name { get; set; }
        private int age;
        public double Mark1 { get; set; }
        public double Mark2 { get; set; }
        public double Mark3 { get; set; }
        public double Mark4 { get; set; }
        public double Mark5 { get; set; }
        public double Mark6 { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if(value>18 && value < 25)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age must be between 18 and 25");
                }
            }
        }
       

        public double CalculateCGPA()
        {
            return (Mark1 + Mark2 + Mark3 + Mark4 + Mark5 + Mark6)/ 6;
        }
        public string ShowGrade()
        {
            double cgpa = CalculateCGPA();
            if (cgpa >= 9)
            {
                return "A";
            }
            else if (cgpa >= 8)
            {
                return "B";
            }
            else if (cgpa >= 7)
            {
                return "C";
            }
            else if (cgpa >= 6)
            {
                return "D";
            }
            else if (cgpa >= 5)
            {
                return "E";
            }
            else
            {
                return "Failed";
            }
        }

    }
    class Department : Student
    {
        public string DepartmentName;
        
    }
}
