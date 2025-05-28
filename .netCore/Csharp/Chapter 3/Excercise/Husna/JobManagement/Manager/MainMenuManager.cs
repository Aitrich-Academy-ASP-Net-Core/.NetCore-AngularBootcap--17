using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManagement.Enum;
using JobManagement.Interfaces;
using JobManagement.Models;
using JobManagement.Repository;
using JobManagement.Exceptions;

namespace JobManagement.Manager
{
    public class MainMenuManager
    {
        UserRepository userRepo = new UserRepository();
        JobRepository sharedJobRepo = new JobRepository();

        private readonly IUserRepository userRepository = new UserRepository();

        public void Start()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("--- Welcome to Job Management System ---");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Exit");
                Console.Write("Enter choice: ");
                string input = Console.ReadLine();

                try
                {
                    switch (input)
                    {
                        case "1":
                            Login();
                            break;
                        case "2":
                            Console.WriteLine("Thank you for using Job Management System!");
                            running = false;
                            break;
                        default:
                            throw new InvalidChoiceException("Invalid menu choice. Please select 1 or 2.");
                    }
                }
                catch (InvalidChoiceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
            }
        }

        private void Login()
        {
            try
            {
                Console.Write("Enter Email: ");
                string email = Console.ReadLine();
                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                User loggedUser = userRepository.Login(email, password);

                if (loggedUser == null)
                {
                    throw new InvalidLoginException("Invalid email or password. Please try again.");
                }

                if (loggedUser.Role == Roles.JobProvider)
                {
                    JobProviderManager jobproviderManager = new JobProviderManager(loggedUser, sharedJobRepo);
                    jobproviderManager.ShowMenu(); 
                }
                else if (loggedUser.Role == Roles.JobSeeker)
                {
                    JobSeekerManager jobSeekerManager = new JobSeekerManager(loggedUser, sharedJobRepo);
                    jobSeekerManager.ShowMenu(); 
                }
                else
                {
                    throw new InvalidLoginException("Invalid role detected.");
                }
            }
            catch (InvalidLoginException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during login: {ex.Message}");
            }
        }
    }
}
