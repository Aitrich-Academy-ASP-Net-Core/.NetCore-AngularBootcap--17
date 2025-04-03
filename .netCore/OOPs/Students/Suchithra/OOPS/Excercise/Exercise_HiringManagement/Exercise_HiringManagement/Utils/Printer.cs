using Exercise_HiringManagement.Enum;
using Exercise_HiringManagement.Interfaces;
using Exercise_HiringManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_HiringManagement.Utils
{
    internal class Printer
    {
        public void print(Job[] jobs)
        {
            Console.WriteLine("Listing Jobs");
            if (jobs != null)
            {
                foreach (Job job in jobs)
                {
                    Console.WriteLine($"Id:{job.Id},Title:{job.Title},Company:{job.Company},Location:{job.Location},Salary:{job.Salary},ExperienceLevel:{job.Experience}");
                }
            }
           
        }

        public void print(User[] registration) 
        {
            Console.WriteLine("User Registration");
            if (registration != null)
            {
                foreach (User user in registration)
                {
                    Console.WriteLine($"Id:{user.Id},Name:{user.FirstName} {user.LastName},Email:{user.Email},Phone:{user.Phone},Role:{user.Role}");
                }
            }
        }
    }
}
