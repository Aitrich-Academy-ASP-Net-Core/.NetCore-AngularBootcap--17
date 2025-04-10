using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiringMnaagamentSystem.Models;

namespace HiringMnaagamentSystem.Utils
{
    internal class Printer
    {
        public void Print(Job[] jobs)
        {
            Console.WriteLine("VIEW AVAILABLE JOBS");
            for (int i = 0; i < jobs.Length; i++)
            {
                Console.WriteLine($"____________________________JOB: {i + 1}_______________________________");
                Console.WriteLine($"ID:{jobs[i].Id}");
                Console.WriteLine($"Title:{jobs[i].Title}");
                Console.WriteLine($"Experience Level:{jobs[i].ExperienceLevel}");
                Console.WriteLine($"Company:{jobs[i].Company}");
                Console.WriteLine($"Salary Range:{jobs[i].SalaryRange}");
                Console.WriteLine($"Location:{jobs[i].Location}");
                Console.WriteLine($"JobType:{jobs[i].JobType}");
            }

        }

        public void Print(User[] registrations, int usercount)
        {

            if (usercount == 0)
            {
                Console.WriteLine("No users Registered");




            }
            else
            {
                Console.WriteLine(" Registered Users List:");
                for (int i = 0; i < usercount; i++)
                {
                    Console.WriteLine($"_______________________________________USER NO:{i + 1}________________________________");
                    Console.WriteLine($"ID:{registrations[i].Id}");
                    Console.WriteLine($"Full Name:{registrations[i].FirstName} {registrations[i].LastName}");
                    Console.WriteLine($"Email:{registrations[i].Email}");
                    Console.WriteLine($"Password: {registrations[i].Password}");
                    Console.WriteLine($"Phone Number: {registrations[i].Phone}");
                    Console.WriteLine($"Role of User:{registrations[i].Role}\n");
                }

            }


        }


    }
}
