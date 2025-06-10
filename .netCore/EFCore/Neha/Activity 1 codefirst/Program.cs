using Activity_1_codefirst.Models;

namespace Activity_1_codefirst
{
    internal class Program
    {
       private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nCRUD Operations:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Read Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                var options = Console.ReadLine();
                switch (options)
                {
                    case "1":
                        CreateStudent();
                        break;
                    case "2":
                        ReadStudents();
                        break;
                    case "3":
                        UpdateStudent();
                        break;
                    case "4":
                        DeleteStudent();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid Option! Try again.");
                        break;
                }
                static void CreateStudent()
                {
                    var context = new StudentAppDbContext();
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Age: ");
                    int age = int.Parse(Console.ReadLine());
                    var student1 = new Student { Name = name, Age = age };
                    context.Students.Add(student1);
                    context.SaveChanges();

                    Console.WriteLine("Student Added Successfully!");

                }
                static void ReadStudents()
                {
                    var context = new StudentAppDbContext();
                    var student1 = context.Students.ToList();
                    if (student1==null)
                    {
                        Console.WriteLine("No students found.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Students List:");
                        foreach (var item in student1)
                        {
                            Console.WriteLine($"ID: {item.id}, Name: {item.Name}, Age: {item.Age}");

                        }
                    }

                }
                static void UpdateStudent()
                {
                    var context = new StudentAppDbContext();
                    Console.Write("Enter the id of student to update: ");
                    var stuid =int.Parse( Console.ReadLine());
                    var stu2 = context.Students.Find(stuid);
                    if (stu2==null)
                    {
                        Console.WriteLine("Student Not Found!");
                        return;
                    }
                    else
                    {
                        Console.Write("Enter New Name:");
                        stu2.Name = Console.ReadLine();
                        Console.Write("Enter New Age:");
                        stu2.Age = int.Parse(Console.ReadLine());
                        context.SaveChanges();
                        Console.WriteLine("Student updated successfully");

                    }
                }
                static void DeleteStudent()
                {
                    var context = new StudentAppDbContext();
                    Console.Write("Enter the id to delete:");
                    var id = int.Parse(Console.ReadLine());
                    var stu1 = context.Students.Find(id);
                    if (stu1==null)
                    {
                        Console.WriteLine("Student Not Found!");
                        return;
                    }
                    else
                    {
                        context.Students.Remove(stu1);
                        context.SaveChanges();
                        Console.WriteLine("Student Removed successsfully");
                    }
                }


            }
            }

        }
    }

