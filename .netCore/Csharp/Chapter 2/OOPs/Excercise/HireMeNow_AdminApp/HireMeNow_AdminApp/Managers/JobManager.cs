
using HireMeNow_AdminApp.Enums;
using HireMeNow_AdminApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireMeNow_AdminApp.Managers
{
    public class JobManager
    {
        Job[] jobs = new Job[3]
       {
            new Job { Id = 1, Title = "Software Engineer", ExperienceLevel = ExperienceLevels.Senior, Company = "Acme Inc.", Location = "New York, NY", SalaryRange = "$100,000 - $150,000",JobType="Full Time" },
            new Job { Id = 2, Title = "Product Manager", ExperienceLevel = ExperienceLevels.MidLevel, Company = "Globex Corp.", Location = "San Francisco, CA", SalaryRange = "$120,000 - $180,000", JobType="Part Time" },
            new Job { Id = 3, Title = "Marketing Specialist", ExperienceLevel = ExperienceLevels.Fresher, Company = "Hooli Enterprises", Location = "Seattle, WA", SalaryRange = "$70,000 - $90,000",JobType="Intern" }
       };
        public void ListJobs()
        {
            Console.WriteLine("Jobs available: \n");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |  {5,-20} |  {6,-20}   ", "JobId", "Title", "ExperienceLevel", "Company", "Location", "SalaryRange", "JobType");

            foreach (Job job in jobs)
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |  {5,-20} |  {6,-20}   ", job.Id, job.Title, job.ExperienceLevel, job.Company, job.Location, job.SalaryRange, job.JobType);
            }

            Console.WriteLine("\n");
        }
    }
}
