using Assesment.Manager;
using Assesment.Models;
using System;

internal class Program
{
    public static void Main(string[] args)
    {

        Department department=new Department();
        StudentManager studentManager=new StudentManager();
        Department[] departments = { new Department("CSE"), 
        new Department("ECE"),
        new Department("EEE"),
        new Department("CE")};


        while (true) 
        
        {
            Console.WriteLine("1.CSE \n 2.ECE \n 3.EEE \n4.CE");
            Console.WriteLine("select Department");
            string option= Console.ReadLine();
            
                Console.WriteLine($"Welcome to {department.Name_Department}");
            
            Console.WriteLine("1.Add Student \n2.List student \n 3.Find topper");
            Console.WriteLine("select option");
            string choice= Console.ReadLine();
            switch (choice) 
            
            {
                case "1":
                    {
                        studentManager.AddStudent();
                        break;
                    }
                    case "2": {
                    
                    studentManager.ListStudent(); break;    
                    }
                    case "3": {
                        studentManager.FindTopper();
                        break;
                    }
                    default: {

                        Console.WriteLine("Invalid option");
                        break;
                    }

            
            
            }
        
        
        
        
        }
    }

    
}