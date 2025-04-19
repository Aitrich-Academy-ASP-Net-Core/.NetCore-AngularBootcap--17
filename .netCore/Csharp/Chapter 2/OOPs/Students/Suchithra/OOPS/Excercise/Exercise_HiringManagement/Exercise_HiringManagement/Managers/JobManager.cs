using Exercise_HiringManagement.Interfaces;
using Exercise_HiringManagement.Models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_HiringManagement.Managers
{
    internal class JobManager
    {
        public Models.Job[] jobs = new Models.Job[10];
        private int jobCount = 0;


        public void Availablejobs() 
        {
            Job job1=new Job(001,".Net Developer",Enum.ExperienceLevel.Fresher,"Aitrich","Trissur","50000","oNLINE");
            jobs[jobCount] = job1;
            jobCount++;

            Job job2 = new Job(002, "Angular Developer", Enum.ExperienceLevel.Senior, "Avodha", "Tvm", "30000", "Onsite");
            jobs[jobCount] = job2;
            jobCount++;

            Job job3 = new Job(003, "Python Developer", Enum.ExperienceLevel.Midlevel, "Innovation", "Kochi", "50000", "oNLINE");
            jobs[jobCount] = job1;
            jobCount++;


        }
        public  void ListJob()
        {

            Console.WriteLine("Available jobs");
            for(int i = 0; i < jobCount; i++) {

                Console.WriteLine("Id:{0}", jobs[i].Id);
                Console.WriteLine("Tittle:{0}", jobs[i].Title);
                Console.WriteLine("Experience:{0}", jobs[i].Experience);
                Console.WriteLine("Company:{0}", jobs[i].Company);
                Console.WriteLine("Location:{0}", jobs[i].Location);
                Console.WriteLine("Salary:{0}", jobs[i].Salary);
                Console.WriteLine("JobType:{0}", jobs[i].JobType);
            }
        }
        public void AddJob()
        {
            if (jobCount == jobs.Length)
            {
                Console.WriteLine("maximum number of jobs reached pls try again later!!!");
                return;
            }
            Console.WriteLine("Enter job id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter job tittle");
            string tittle = Console.ReadLine();

            Console.WriteLine("Enter job eXPERIENCE:");
            string experience = Console.ReadLine();

            Console.WriteLine("Enter job salary");
            string salary = Console.ReadLine();

            Console.WriteLine("Enter job location");
            string location = Console.ReadLine();

            Console.WriteLine("Enter job company");
            string company = Console.ReadLine();

            Console.WriteLine("Enter job jobtype");
            string jobtype = Console.ReadLine();

            Job newJob = new Job(id, tittle, Enum.ExperienceLevel.Senior, salary, location,company,jobtype);
            jobs[jobCount] = newJob;
            jobCount++;

            Console.WriteLine("Job Added succesfully!");
        }

    }
}
