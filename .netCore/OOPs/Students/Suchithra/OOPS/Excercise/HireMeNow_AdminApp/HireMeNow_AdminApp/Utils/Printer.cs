using HireMeNow_AdminApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HireMeNow_AdminApp.Utils
{
    public class Printer
    {
        public void Print(Job[] jobs)
        {
            Console.WriteLine("Jobs : \n");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |  {5,-20} |  {6,-20}   ", "JobId", "Title", "Company", "Location", "SalaryRange", "ExperienceLevel");
            if (jobs != null)
                foreach (Job job in jobs)
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");

                    Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |  {5,-20} |  {6,-20}   ", job.Id, job.Title, job.Company, job.Location, job.SalaryRange, job.ExperienceLevel);
                }

            Console.WriteLine("\n");

        }

        public void Print(User[] registrstions)
        {
            Console.WriteLine("Registrations  : \n");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} ", "Id", "FirstName", "LastName", "Phone", "Email");
            if (registrstions != null)
                foreach (User item in registrstions)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");

                    Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} ", item.Id, item.FirstName, item.LastName, item.Phone, item.Email);
                }

            Console.WriteLine("\n");
        }
    }
}
