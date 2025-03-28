using HireMeNow_AdminApp.Interfaces;
using HireMeNow_AdminApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireMeNow_AdminApp.Managers
{
    public class UserManager : IMenu
    {
        JobManager jobManager= new JobManager();
        private User loggedUser;

        public UserManager()
        {
            
        }
        public UserManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }

        public void DisplayMenu(object? publicManager = null)
        {
            ShowJobSeekerMenu();
        }

        public void ShowJobSeekerMenu()
        {
            //  Console.WriteLine("Welcome " + loggedInJobSeeker.FirstName + "!");
            Console.WriteLine("1. List all jobs");
            Console.WriteLine("2. My profile");
            Console.WriteLine("3. Logout");
           

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    jobManager.ListJobs();
                    ShowJobSeekerMenu();
                    break;
                case "2":
                    ViewProfile();
                    ShowJobSeekerMenu();
                    break;
                case "3":
                    Logout();
                    break;
               
                  
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    ShowJobSeekerMenu();
                    break;
            }
        }

        public void ViewProfile()
        {
            Console.WriteLine("-------------------------------MY PROFILE-------------------------------------\n");
            Console.WriteLine($"First Name: {loggedUser.FirstName}");
            Console.WriteLine($"Last Name: {loggedUser.LastName}");
            Console.WriteLine($"Email: {loggedUser.Email}");
            Console.WriteLine($"Phone: {loggedUser.Phone}");
            //Console.WriteLine($"Location: {loggedUser.Location}");
            //Console.WriteLine($"AboutMe: {loggedUser.AboutMe}");
            //Console.WriteLine($"ExperienceLevel: {loggedUser.ExperienceLevel}");
            Console.WriteLine("\n");

        }

        public void Logout()
        {
            loggedUser = new User();
            Console.WriteLine("Logged out successfully!");
           
        }

       
    }
}
