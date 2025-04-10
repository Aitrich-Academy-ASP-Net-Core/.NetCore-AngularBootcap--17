using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiringMnaagamentSystem.Models;
using HiringMnaagamentSystem.Utils;

namespace HiringMnaagamentSystem.Managers
{
    internal class UserManager:JobManager
    {
        Printer printer = new Printer();

        public void ApplyJobs()
        {

            bool found = false;

            printer.Print(jobs);

            Console.WriteLine("Apply for Job");
            Console.Write("enter Ttitle of the job to apply:");
            string jobname = Console.ReadLine().ToLower();
            for (int i = 0; i < jobs.Length; i++)
            {
                if (jobs[i] != null && jobs[i].Title.ToLower() == jobname)
                {
                    found = true;
                    Console.WriteLine($"You have successfully applied for ID:{jobs[i].Id} ,Ttitle:{jobs[i].Title}");
                }
            }
            if (!found)
            {
                Console.WriteLine("Job not found. Please enter a valid job title.");
            }



        }


    }
}
