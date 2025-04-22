using HireMeNow_AdminApp.Interfaces;
using HireMeNow_AdminApp.Models;
using HireMeNow_AdminApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HireMeNow_AdminApp.Managers
{
    public class AdminManager : IMenu
    {
        private User loggedUser;
        private PublicManager _publicManager=new PublicManager();
        private Printer printer=new Printer();
        JobManager jobManager=new JobManager();
        public AdminManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }

        public void DisplayMenu(object? publicManager = null)
        {
            if(publicManager!=null)
            _publicManager = (PublicManager)publicManager;
            ShowAdminMenu();
        }

        public void ShowAdminMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. New Registrations ");
            Console.WriteLine("2. List all Jobs ");
           
            Console.WriteLine("3. Logout");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                   User[] users= _publicManager.getAllUsers();
                    printer.Print(users);
                    ShowAdminMenu();
                    break;
                case "2":

                    jobManager.ListJobs();
                    ShowAdminMenu();
                    break;
                case "3":
                    Logout();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    ShowAdminMenu();
                    break;
            }
        }

         public void Logout()
        {
            loggedUser = new User();
            Console.WriteLine("Logged out successfully!");
           
        }
    }
}
