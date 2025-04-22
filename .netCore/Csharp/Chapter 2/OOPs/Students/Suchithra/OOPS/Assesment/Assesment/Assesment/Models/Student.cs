using Assesment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.Models
{
    internal class Student
    {


       
        private int age;
        public string Name { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18 || value > 25)
                    Console.WriteLine("Age must be between 18 and 25.");
                age = value;
            }
        }
        public int[] Marks { get; set; }
        public Student()
        {
            Marks = new int[6];
        }

        //public Student() { }
        public Student(string name, int age, int[] mark)
        {
           


            Name = name;
            Age = age;
            Marks = mark;
           





        }

        
        public double CalculateCGPA()
        {
            double tottal_mark=0;


            double cgpa;

            foreach( var marks in Marks)
            {
                tottal_mark += marks;
            }
            cgpa = (tottal_mark / 60) * 10;
            return cgpa;
        }

        public string Getgrade()

        {
            double cgpa = CalculateCGPA();
            if (cgpa >= 9) return "A";
            if (cgpa >= 8) return "B";
            if (cgpa >= 7) return "C";
            if (cgpa >= 6) return "D";
            if (cgpa >= 5) return "E";

            else
                return "F";



        }
    }

}
    