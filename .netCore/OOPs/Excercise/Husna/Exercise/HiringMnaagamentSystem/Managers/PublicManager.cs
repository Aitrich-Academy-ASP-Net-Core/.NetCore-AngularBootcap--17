using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiringMnaagamentSystem.Interface;
using HiringMnaagamentSystem.Models;
using static HiringMnaagamentSystem.Enum.Role;

namespace HiringMnaagamentSystem.Managers
{
    internal class PublicManager:ILogin,IMenu

    {
      
        private User[] users = new User[20];
        private int userCount = 0;
        bool isLoggedIn = false;

        AdminManager adminManager = new AdminManager();
        JobManager job = new JobManager();

        public void Register(User user)
        {
            if (userCount == users.Length)
            {
                Console.WriteLine("Maximum number of user reached please try again later");
                return;

            }
            users[userCount] = user;


            userCount++;



            Console.WriteLine("\nRegisteration Successfull!");





        }
        public bool Login(string email, string password)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (email == users[i].Email && password == users[i].Password)
                {
                    isLoggedIn = true;
                    Console.WriteLine("Login successfull!");
                    if (isLoggedIn)
                    {
                        return true;
                    }
                }

            }

            Console.WriteLine("login unsuccessfull (wrong email or password)");
            return false;

        }
        public void DisplayMenu(object? publicManager = null)
        {


            Console.WriteLine("Enter your Role:");
            string display = Console.ReadLine();
            Roles displayRole;
            bool valid = Roles.TryParse(display, true, out displayRole);
            if (!valid)
            {
                Console.WriteLine("Enter your Role correctly(Admin/Jobseeker)");


            }
            else if (displayRole == Roles.Jobseeker)
            {
                string option = "0";
                while (option != "3")
                {

                    Console.WriteLine("\n________________________________________________DISPLAY MENU FOR Jobseeker____________________________________________\n");
                    Console.WriteLine("1-Viewing Available Jobs");
                    Console.WriteLine("2-Apply for a Job");
                    Console.WriteLine("3-Back to main menu");
                    Console.WriteLine("Choose an option:");
                    option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            job.DisplayJobs();
                            break;
                        case "2":
                            UserManager user = new UserManager();
                            user.ApplyJobs();

                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;

                    }
                }

            }
            else if (displayRole == Roles.Admin)
            {
                string option = "0";

                while (option != "3")
                {
                    Console.WriteLine("\n________________________________________________DISPLAY MENU FOR Jobseeker____________________________________________\n");
                    Console.WriteLine("1-Viewing New Registerations");
                    Console.WriteLine("2-Listing Jobs");
                    Console.WriteLine("3-Back to main menu");
                    Console.WriteLine("Choose an option:");
                    option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":

                            adminManager.PrintUsers(users, userCount);

                            break;
                        case "2":
                            job.DisplayJobs();

                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;

                    }
                }

            }
        }
    }
}
