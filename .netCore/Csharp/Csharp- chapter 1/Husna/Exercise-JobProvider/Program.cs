using System;

namespace JobPortal
{
    class Program
    {
        struct CompanyMember
        {
            public int UserID;
            public string Name;
            public string Designation;
            public string Email;
            public long Phone;
        }

        static void Main()
        {
            // Predefined login credentials
            string storedEmail = "jobprovider@gmail.com";
            string storedPassword = "123";

            CompanyMember[] members = new CompanyMember[10];
            int memberCount = 0;
            bool isLoggedIn = false;

            Console.WriteLine("Welcome to the Hire Me Now Job Portal!");

            while (true)
            {
                Console.WriteLine("\n1. Login");
                Console.WriteLine("2. Exit");
                Console.Write("Select an option: ");
                string option = Console.ReadLine();

                if (option == "1") // Login
                {
                    Console.Write("\nPlease enter your email: ");
                    string email = Console.ReadLine();
                    Console.Write("Please enter your password: ");
                    string password = Console.ReadLine();

                    if (email == storedEmail && password == storedPassword)
                    {
                        Console.WriteLine("Login successful!");
                        isLoggedIn = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid credentials! Try again.");
                        continue;
                    }

                    while (isLoggedIn)
                    {
                        Console.WriteLine("\n1. List all company members");
                        Console.WriteLine("2. Add company members");
                        Console.WriteLine("3. Logout");
                        Console.Write("Enter your choice: ");
                        string choice = Console.ReadLine();

                        if (choice == "1") // List members
                        {
                            Console.WriteLine("\nCompany Members:\n");
                            Console.WriteLine("UserID\tName\t\tDesignation\t\tEmail\t\t\tPhone");
                            for (int i = 0; i < memberCount; i++)
                            {
                                Console.WriteLine($"{members[i].UserID}\t{members[i].Name}\t\t{members[i].Designation}\t\t{members[i].Email}\t\t\t{members[i].Phone}");
                            }
                        }
                        else if (choice == "2") // Add a new member
                        {
                            if (memberCount < members.Length)
                            {
                                Console.Write("\nPlease enter company member name: ");
                                members[memberCount].Name = Console.ReadLine();
                                Console.Write("Please enter email: ");
                                members[memberCount].Email = Console.ReadLine();
                                Console.Write("Please enter Designation: ");
                                members[memberCount].Designation = Console.ReadLine();
                                Console.Write("Please enter phone number: ");
                                members[memberCount].Phone = Convert.ToInt64(Console.ReadLine());

                                members[memberCount].UserID = memberCount + 1;
                                memberCount++;

                                Console.WriteLine("Registration successful!");
                            }
                            else
                            {
                                Console.WriteLine("Member list is full! Cannot add more.");
                            }
                        }
                        else if (choice == "3") // Logout
                        {
                            Console.WriteLine("Logged out successfully!");
                            isLoggedIn = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid option. Try again.");
                        }
                    }
                }
                else if (option == "2") // Exit the program
                {



                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option! Please choose 1 or 2.");
                }
            }
        }
    }
}

