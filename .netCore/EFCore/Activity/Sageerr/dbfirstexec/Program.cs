using dbfirstexec.model;

namespace dbfirstexec
{
    

    class Program
    {
        static void Main()
        {
            using var context = new SchoolDBContext();

            var students = context.Students.ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.StudentId} - {student.Name}, Age: {student.Age}");
            }
        }
    }

}
