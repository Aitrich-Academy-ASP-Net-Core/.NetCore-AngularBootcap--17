using Admin_Job.Interface;
using Admin_Job.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Job.Manager
{
    internal class JobManager :IJob
    {
        private int num_job = 0;
        private Job[] jobs=new Job[100];

        public void AddJob()
        {
            if(num_job==jobs.Length)
            {
                Console.WriteLine("Maximum no.of jobs reached.Please try again later");
                return;
            }

            Console.WriteLine("Enter job id");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Job Title");
            string title=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Job Description");
            string description=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Job Salary");
            string salary=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Location");
            string location=Convert.ToString(Console.ReadLine());

            Job newJob=new Job(id, title, description, salary, location);
            jobs[num_job]=newJob;
            num_job++;

            Console.WriteLine("Job added Successfully");


        }

        public void ListJob()
        {
            Console.WriteLine("Jobs");
            for(int i=0; i<num_job; i++)
            {
                Console.WriteLine($"Title : {jobs[i].Title}");
                Console.WriteLine($"Description : {jobs[i].Description}");
                Console.WriteLine($"Salary : {jobs[i].Salary}");
                Console.WriteLine($"Location : {jobs[i].Location}");
            }
        }
    }
}
