using System;

namespace JobPortal
{
    class Program
    {
        struct Job
        {
            public int JobID;
            public string Title;
            public string Experience;
            public string Company;
            public string Location;
            public string SalaryRange;
        }

        struct User
        {
            public string Email;
            public string Password;
            public string Name;
        }

        static void Main()
        {
            User user = new User();
            Job[] jobs = new Job[]
            {
                new Job { JobID = 1, Title = "Software Engineer", Experience = "3+ years", Company = "Acme Inc.", Location = "New York, NY", SalaryRange = "$100,000 - $150,000" },
                new Job { JobID = 2, Title = "Product Manager", Experience = "5+ years", Company = "Globex Corp.", Location = "San Francisco, CA", SalaryRange = "$120,000 - $180,000" },
                new Job { JobID = 3, Title = "Marketing Specialist", Experience = "2+ years", Company = "Hooli Enterprises", Location = "Seattle, WA", SalaryRange = "$70,000 - $90,000" }
            };

            bool isRegistered = false;
            bool isLoggedIn = false;
                                                

            Console.WriteLine("Welcome to the job portal!");

            while (true)
            {
                Console.WriteLine("\n1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");
                string option = Console.ReadLine();

                if (option == "1") // User Registration
                {
                    Console.Write("\nEnter your email: ");
                    user.Email = Console.ReadLine();
                    Console.Write("Enter your password: ");
                    user.Password = Console.ReadLine();
                    Console.Write("Enter your name: ");
                    user.Name = Console.ReadLine();

                    isRegistered = true;
                    Console.WriteLine("Registration successful!");
                }
                else if (option == "2" && isRegistered) // User Login
                {
                    Console.Write("\nPlease enter your email: ");
                    string email = Console.ReadLine();
                    Console.Write("Please enter your password: ");
                    string password = Console.ReadLine();

                    if (email == user.Email && password == user.Password)
                    {
                        Console.WriteLine($"Login successful!\nWelcome {user.Name}!");
                        isLoggedIn = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid credentials! Try again.");
                        continue;
                    }

                    while (isLoggedIn)
                    {
                        Console.WriteLine("\n1. List all jobs");
                        Console.WriteLine("2. My profile");
                        Console.WriteLine("3. Logout");
                        Console.Write("Enter your choice: ");
                        string choice = Console.ReadLine();

                        if (choice == "1") // Display job listings
                        {
                            Console.WriteLine("\nJobs available:");
                            Console.WriteLine("ID\tTitle\t\t\tExperience\tCompany\t\t\tLocation\t\tSalary Range");
                            foreach (var job in jobs)
                            {
                                Console.WriteLine($"{job.JobID}\t{job.Title}\t{job.Experience}\t{job.Company}\t{job.Location}\t{job.SalaryRange}");
                            }
                        }
                        else if (choice == "2") // View profile
                        {
                            Console.WriteLine("\nYour Profile:");
                            Console.WriteLine($"Name: {user.Name}");
                            Console.WriteLine($"Email: {user.Email}");
                        }
                        else if (choice == "3") // Logout
                        {
                            Console.WriteLine("Logged out successfully!");
                            isLoggedIn = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid option. Try again.");
                        }
                    }
                    break;
                }
                else if (option == "3")
                {
                    Console.WriteLine("Thank you for using the Job Portal. Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please register first.");
                }
            }
        }
    }
}


