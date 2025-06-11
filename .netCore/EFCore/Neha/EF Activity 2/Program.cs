using EF_Activity_2.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace EF_Activity_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var context = new StudentmarkAppDbContext();
            while (true)
            {
                Console.WriteLine("\nChoose Operation:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Add Marks");
                Console.WriteLine("6. View Marks");
                Console.WriteLine("7. Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Addstudent();
                        break;
                    case 2:
                        Viewstudent();
                        break;
                    case 3:
                        Updatestudent();
                        break;
                    case 4:
                        deletestudent();
                        break;
                    case 5:
                        Addmark();
                        break;
                    case 6:
                        Viewmark();
                        break;
                    case 7:
                        return;
                    default: Console.WriteLine("Invalid choice."); break;
                }
                static void Addstudent()
                {
                    var context = new StudentmarkAppDbContext();
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Mobile No: ");
                    string mobile = Console.ReadLine();
                    var stu1 = new Student { Name = name, MobileNo = mobile };
                    context.Students.Add(stu1);
                    context.SaveChanges();
                    Console.WriteLine("Student added successfully");
                }

                static void Viewstudent()
                {
                    var context = new StudentmarkAppDbContext();
                    var students = context.Students.ToList();
                    Console.WriteLine("\nStudents List:");
                    foreach (var student in students)
                    {
                        Console.WriteLine($"ID: {student.id}, Name: {student.Name}, Mobile: {student.MobileNo}");
                    }
                }
                static void Updatestudent()
                {
                    var context = new StudentmarkAppDbContext();
                    Console.Write("Enter the Id to update:");
                    var id = int.Parse(Console.ReadLine());
                    var stud1 = context.Students.Find(id);
                    if (stud1 == null)
                    {
                        Console.WriteLine("Student not found!");
                        return;
                    }
                    Console.Write("Enter new name:");
                    stud1.Name = Console.ReadLine();
                    Console.Write("Enter New Mobile No: ");
                    stud1.MobileNo = Console.ReadLine();

                    context.SaveChanges();
                    Console.WriteLine("Student Updated Successfully!");
                }
                static void deletestudent()
                {
                    var context = new StudentmarkAppDbContext();
                    Console.Write("Enter the Id to update:");
                    var id = int.Parse(Console.ReadLine());
                    var stud1 = context.Students.Find(id);
                    if (stud1 == null)
                    {
                        Console.WriteLine("Student not found!");
                        return;
                    }
                    context.Students.Remove(stud1);
                    context.SaveChanges();
                    Console.WriteLine("Student removed successfully!");
                }
                static void Addmark()
                {
                    var context = new StudentmarkAppDbContext();
                    Console.Write("Enter the Id to Addmark:");
                    var id = int.Parse(Console.ReadLine());
                    var stud1 = context.Students.Find(id);
                    if (stud1 == null)
                    {
                        Console.WriteLine("Student not found!");
                        return;

                    }
                    Console.Write("Enter Mark1: ");
                    int m1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter Mark2: ");
                    int m2 = int.Parse(Console.ReadLine());
                    Console.Write("Enter Mark3: ");
                    int m3 = int.Parse(Console.ReadLine());
                    var marks = new Mark { M1 = m1, M2 = m2, M3 = m3 };
                    context.Marks.Add(marks);
                    context.SaveChanges();
                    Console.WriteLine("Marks added successfully!");


                }
                static void Viewmark()
                {
                    var context = new StudentmarkAppDbContext();
                    {
                        var marks = context.Marks.ToList();
                        Console.WriteLine("Mark List:");
                        foreach (var mark in marks)
                        {
                            Console.WriteLine($"Mark ID: {mark.MarkId}, Student ID: {mark.Studentid}, M1: {mark.M1}, M2: {mark.M2}, M3: {mark.M3}");

                        }
                    }
                }
            }
        }
    }
}
