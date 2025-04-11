using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProfile
{
    internal class Program
    {
        struct AdminProfile
        {
            public string Fullname;
            public string Username;
            public string Email;
            public long Phonenumber;
        }
        static void Main(string[] args)
        {
            AdminProfile[] admin = new AdminProfile[1];

            string ch;
            
            Console.WriteLine(" Welcome to Admin Part\n");
            

            do
            {
                Console.WriteLine("A - Register as Admin");
                Console.WriteLine("D - Display Admin Details");
                Console.WriteLine("----------------------------------\n");
                Console.WriteLine("Select an option from the list\n");
                string Command = Console.ReadLine();
                switch (Command)
                {
                    case "A":
                        {


                            Console.WriteLine("-------------------Admin Registration-------------------------\n");
                            Console.WriteLine("-----------------------------------------------------------------\n");
                            Console.Write("Enter name of Admin:  \n ");
                            admin[0].Fullname = Console.ReadLine();
                            Console.Write("Enter username of admin : \n ");
                            admin[0].Username = Console.ReadLine();
                            Console.Write(" Email of admin : \n");
                            admin[0].Email = Console.ReadLine();
                            Console.Write("Phone no of Admin : \n");
                            admin[0].Phonenumber = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------\n");


                            break;
                        }

                    case "D":
                        {

                            Console.WriteLine("----------------------------------------------------------------List of Admin-------------------------------------------------------------------------------------\n");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                            Console.WriteLine("Name of Admin: " + admin[0].Fullname + "\n");
                            Console.WriteLine("Username of admin: " + admin[0].Username + "\n");
                            Console.WriteLine("Email of Admin: " + admin[0].Email + "\n");
                            Console.WriteLine("Phone no of Admin: " + admin[0].Phonenumber + "\n");





                            break;
                        }

                }
                Console.WriteLine("Do you want to continue (Y/N)");
                ch = Console.ReadLine();
            }
            while (ch == "Y" || ch == "y");

        }
    }
}




















