using codefirstexec.Models;
using System;
using System.Linq;

namespace codefirstexec
{
    

    class Program
    {
        static void Main()
        {
            using var context = new StudentDBContext();

            // Add a student
            context.Students.Add(new Student { Name = "Alice", Age = 22 });
            context.SaveChanges();

            // Read all students
            var students = context.Students.ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.StudentId}: {student.Name} ({student.Age})");
            }
        }
    }

}
