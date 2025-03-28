using JobSeeker_Job.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace JobSeeker_Job.Managers
{
    
    internal class JobManager
    {
        public Job[] jobs=new Job[5];
        
        private int num_jobs = 0;
        
        
        
         

        public void AvailableJob()
        {


            Job job1 = new Job(1, "Java Developer", ExperienceLevel.MidLevel, "ABC", "Kochi", "20000-30000", "Full Time");
            jobs[num_jobs] = job1;
            num_jobs++;
            Job job2 = new Job(2, ".Net Developer", ExperienceLevel.Fresher, "CBD", "Chennai", "25000-30000", "Part Time");
            jobs[num_jobs] = job2;
            num_jobs++;
            Job job3 = new Job(3, "Python Developer", ExperienceLevel.Senior, "TCS", "Kochi", "50000-70000", "Online");
            jobs[num_jobs] = job3;
                num_jobs++;
            Job job4 = new Job(4, "Analyst", ExperienceLevel.MidLevel, "Infosys", "Kochi", "30000-35000", "Full Time");
            jobs[num_jobs] = job4;
            num_jobs++;
            Job job5 = new Job(5, "Java Developer", ExperienceLevel.Fresher, "TCS", "Kochi", "25000-30000", "Full Time");
            jobs[num_jobs] = job5;
            num_jobs++;


        }

        public void ListJob()
        {
            Console.WriteLine("Jobs...");
            for(int i=0;i<num_jobs;i++)
            {
                Console.WriteLine("Title: {0}", jobs[i].Title);
                Console.WriteLine("Experience: {0}", jobs[i].Experience);
                Console.WriteLine("Company : {0}", jobs[i].Company);
                Console.WriteLine("Location : {0}", jobs[i].Location);
                Console.WriteLine("Salary Range : {0}", jobs[i].SalaryRange);
                Console.WriteLine("Job Type : {0}", jobs[i].JobType);
            }
        }

        public void GetJobById(int SearchId)
        {
            
            for(int i = 0; i < num_jobs; i++)
            {
                if (SearchId == jobs[i].Id)
                {
                    Console.WriteLine("Title: {0}", jobs[i].Title);
                    Console.WriteLine("Experience: {0}", jobs[i].Experience);
                    Console.WriteLine("Company : {0}", jobs[i].Company);
                    Console.WriteLine("Location : {0}", jobs[i].Location);
                    Console.WriteLine("Salary Range : {0}", jobs[i].SalaryRange);
                    Console.WriteLine("Job Type : {0}", jobs[i].JobType);
                }
            }
        }

    }
}
