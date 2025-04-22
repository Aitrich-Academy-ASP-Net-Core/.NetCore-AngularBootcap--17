using Exercise_HiringManagement.Interfaces;
using Exercise_HiringManagement.Models;
using Exercise_HiringManagement.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_HiringManagement.Managers
{
    internal class UserManager:IMenu
        

    {

        JobManager jobManager=new JobManager();
        private User loggedUser;
       

        public UserManager() { }

        public UserManager(User loggedUser)

        { 
            this.loggedUser=loggedUser;
        
        }

        public void DisplayMenu(object? publicManager = null)
        {
            showJobSeekerMenu();
        }

        private void showJobSeekerMenu()
        {
            Console.WriteLine("welcome"+loggedUser.FirstName);
            Console.WriteLine("1.List all jobs");
            Console.WriteLine("2.view profile");
            Console.WriteLine("Logout");
            Console.WriteLine("Enter your choice");
            string choice=Console.ReadLine();

            switch (choice) 
            {
                case "1":
                    {
                        jobManager.ListJob();
                        showJobSeekerMenu();
                        break;
                    }
                    case "2":
                    {
                        viewProfile();
                        showJobSeekerMenu();
                        break;
                    }
                    case "3":
                    {
                        Logout();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid option!");
                        break;
                    }
            }

        }

        private void Logout()
        {
            loggedUser = null;
            Console.WriteLine("Logout Succesfully");
        }

        private void viewProfile()
        {

            Console.WriteLine("***************Profile***************");
            Console.WriteLine($"FirstName:{loggedUser.FirstName }");
            Console.WriteLine($"SecondName:{loggedUser.LastName}");
            Console.WriteLine($"Email:{loggedUser.Email}");
                Console.WriteLine($"Phone:{loggedUser.Phone}");
            
        }

    }
}