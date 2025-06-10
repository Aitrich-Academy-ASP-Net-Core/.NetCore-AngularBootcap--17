using EF_data_fest_2.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace EF_data_fest_2

{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new StudentDatafestContext();

            
            if (!context.Students.Any())
            {
                var students = new List<Student>
            {
                new Student { Name = "John", Age = 19 },
                new Student { Name = "Alice",Age = 22 },
                new Student { Name = "Raj",Age = 21 }
            };
                context.Students.AddRange(students);
                context.SaveChanges();
            }

            
            var adults = context.Students.Where(s => s.Age > 20).ToList();
            Console.WriteLine("Students older than 20:");
            foreach (var s in adults)
                Console.WriteLine($"{s.Name}, Age: {s.Age}");

            
            if (!context.Courses.Any())
            {
                var course = new Course { CourseName = "Mathematics", Credits = 4 };
                context.Courses.Add(course);
                context.SaveChanges();

                
                var studentsToAssign = context.Students.Take(2).ToList();
                foreach (var student in studentsToAssign)
                {
                    student.CourseId = course.CourseId;  
                }
                context.SaveChanges();
            }

            
            var studentsWithCourses = context.Students.Include(s => s.Course).ToList();
            Console.WriteLine("Students and their courses:");
            foreach (var s in studentsWithCourses)
            {
                Console.WriteLine($"{s.Name} enrolled in {s.Course?.CourseName ?? "No course"}");
            }

            
            var studentToUpdate = context.Students.FirstOrDefault(s => s.Name == "Raj");
            if (studentToUpdate != null)
            {
                studentToUpdate.Name = "Rajan";
                studentToUpdate.Age = 23;
                context.SaveChanges();
                Console.WriteLine("Updated student Raj to Rajan");
            }

            
            var studentToDelete = context.Students.FirstOrDefault(s => s.Name == "John");
            if (studentToDelete != null)
            {
                context.Students.Remove(studentToDelete);
                context.SaveChanges();
                Console.WriteLine("Deleted student John");
            }

            
            if (!context.Subjects.Any())
            {
                var subjects = new List<Subject>
            {
                new Subject { SubjectName = "Physics" },
                new Subject { SubjectName = "Chemistry" },
                new Subject { SubjectName = "Biology" }
            };
                context.Subjects.AddRange(subjects);
                context.SaveChanges();

                
                var alice = context.Students.FirstOrDefault(s => s.Name == "Alice");
                if (alice != null)
                {
                    foreach (var subj in subjects)
                    {
                        context.studentsubjects.Add(new StudentSubject
                        {
                            StudentId = alice.Id,
                            SubjectId = subj.SubjectId
                        });
                    }
                    context.SaveChanges();
                }
            }

            
            var aliceSubjects = context.Subjects
                .Where(ss => ss.Student.Name == "Alice")
                .Include(ss => ss.Subject)
                .Select(ss => ss.Subject.SubjectName)
                .ToList();

            Console.WriteLine("Subjects Alice is enrolled in:");
            foreach (var sub in aliceSubjects)
                Console.WriteLine(sub);
        }
    }
}



