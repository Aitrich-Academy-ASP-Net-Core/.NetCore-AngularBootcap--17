using ENROLLMENTSTUDENT.Models;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {

        using var context = new EnrollmentStudentContext();

        //Add a Course with Students 
        var course = new Course
        {
            Coursename = ".NET DEVELOPER",
            Students = new List<Student>
           {
                new Student { StudentName = "meenu"},
                new Student { StudentName = "Bibin" }
           }
        };

        context.Courses.Add(course);
        context.SaveChanges();
        Console.WriteLine("Course and students saved successfully.\n");

        // Display Courses and Their Students 
        var courses = context.Courses
                             .Include(c => c.Students)
                             .ToList();

        foreach (var c in courses)
        {
            Console.WriteLine($"Course: {c.Coursename}");
            foreach (var s in c.Students)
            {
                Console.WriteLine($"   Student: {s.StudentName}");
            }
        }



        //var students = context.Students.ToList();

        //// Students where age > 20
        //var olderStudents = context.Students.Where(s => s.Age > 20).ToList();

        // Find by name
        //var studentByName = context.Students.FirstOrDefault(s => s.StudentName == "Alice");




        //  Update Student Name 
        Console.Write("\nEnter the student ID to update: ");
        if (int.TryParse(Console.ReadLine(), out int studentId))
        {
            var student = context.Students.FirstOrDefault(s => s.StudentId == studentId);

            if (student != null)
            {
                Console.WriteLine($"Current Name: {student.StudentName}");
                Console.Write("Enter new name: ");
                string newName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newName))
                {
                    student.StudentName = newName;
                    context.SaveChanges();
                    Console.WriteLine("Student name updated successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid name. Update canceled.");
                }
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        else
        {
            Console.WriteLine("Invalid student ID.");
        }


        //delete

        Console.WriteLine("Enter the name of the student to delete:");
        string nameToDelete = Console.ReadLine();

        var studentToDelete = context.Students.FirstOrDefault(s => s.StudentName == nameToDelete);

        if (studentToDelete != null)
        {
            context.Students.Remove(studentToDelete);
            context.SaveChanges();
            Console.WriteLine($"Student '{nameToDelete}' has been deleted.");
        }
        else
        {
            Console.WriteLine($"Student '{nameToDelete}' not found.");
        }






        //  Add 3 Subjects 
        var subject1 = new Subject { Title = "Mathematics" };
        var subject2 = new Subject { Title = "Physics" };
        var subject3 = new Subject { Title = "Chemistry" };

        context.Subjects.Add(subject1);
        //context.Subjects.Add(subject2);
        //context.Subjects.Add(subject3);
        context.SaveChanges();

        // Assign Subjects to Students 
        var stud1 = context.Students.Include(s => s.Subjects).FirstOrDefault(s => s.StudentName == "Alice");
        var stud2 = context.Students.Include(s => s.Subjects).FirstOrDefault(s => s.StudentName == "Bob");

        if (stud1 != null && stud2 != null)
        {
            stud1.Subjects.Add(subject1);
            stud1.Subjects.Add(subject2);

            stud2.Subjects.Add(subject2);
            stud2.Subjects.Add(subject3);

            context.SaveChanges();
            Console.WriteLine("Subjects assigned to students.");
        }
        else
        {
            Console.WriteLine("One or both students not found.");
        }



        Console.WriteLine("\n--- Students and Their Subjects ---");

        var studentsWithSubjects = context.Students
            .Include(s => s.Subjects)
            .ToList();

        foreach (var student in studentsWithSubjects)
        {
            Console.WriteLine($"Student: {student.StudentName}");

            if (student.Subjects != null && student.Subjects.Any())
            {
                foreach (var subject in student.Subjects)
                {
                    Console.WriteLine($"   Subject: {subject.Title}");
                }
            }
            else
            {
                Console.WriteLine("   No subjects assigned.");
            }
        }







    }
}