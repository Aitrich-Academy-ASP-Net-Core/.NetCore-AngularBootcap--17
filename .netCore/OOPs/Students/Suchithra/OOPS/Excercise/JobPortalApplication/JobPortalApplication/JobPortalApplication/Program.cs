using System;
using System.ComponentModel.DataAnnotations;
using JobPortalApplication.Enums;
using JobPortalApplication.Manager;
using JobPortalApplication.Models;

JobPortalManager manager = new JobPortalManager();
Printer printer = new Printer();
User loggedUser = new User();
Interview interview = new Interview();
Job job = new Job();

while (true)

{
    Console.WriteLine("JOb Portal System");
    Console.WriteLine("1.Register");
    Console.WriteLine("2.Login");
    Console.WriteLine("3.Exit");
    string option = Console.ReadLine();

    switch (option)
    {
        case "1":
            {
                Console.WriteLine("Registration");
               
                manager.RegisterUser();

                break;
            }

        case "2":
            {
                Console.WriteLine("Login");
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                manager.Login(username, password);
               
                break;
            }
            
        case "3":
            {
                Console.WriteLine("Exit");
                Environment.Exit(0);
                break;
            }
    }

}
