using Assesment.Interfaces;
using Assesment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.Manager
{
    internal class StudentManager : IDepartment
    {
        Student[] Students=new Student[10];
        Student student1 = new Student();
    
        int student_count = 0;
        int[] mark = new int[6];
       




        public void AddStudent()
        {

            if (student_count >= Students.Length)
            
            {
                Console.WriteLine("Limit reached can't add more students");
                return;
            
            }

           
            Console.WriteLine("Enter the Name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter Age:");
            int age =Convert.ToInt32( Console.ReadLine());
           
            int[] marks = new int[6];
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Enter mark for subject {i + 1}:");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            Student student = new Student(name, age, marks);
           

            Students[student_count] = student;
            student_count++;
            Console.WriteLine("Student Added Succesfully");
            


        }

       
        public void FindTopper()
        {
            if(student_count == 0)
            {
                Console.WriteLine("No students found");
            }

            Student student_topper = Students[0];

            for (int i = 0; i < student_count; i++)
            {

                if (student1.CalculateCGPA() >student_topper. CalculateCGPA())
                {
                    student_topper = Students[i];
                }
               
            }
            Console.WriteLine($"Topper:{student_topper.Name},CGPA:{student_topper.CalculateCGPA()},Grade:{student_topper.Getgrade()}");
        }

        public void ListStudent()
        {

            if (student_count == 0)
            {
                Console.WriteLine("No students found");

            }

            for (int i = 0; i < student_count; i++)
            {
                Student student = Students[i];
                Console.WriteLine($"Name:{student.Name},Age:{student.Age},Mark:{string.Join(",",student.Marks)},Cgpa:{student.CalculateCGPA()}");

            }
        }  
}
}
