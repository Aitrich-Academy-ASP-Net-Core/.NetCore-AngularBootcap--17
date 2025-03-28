using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobSeekerModule.Enum;



namespace JobSeekerModule.Models
{
   
        public class Job
        {
            public string JobId { get; set; }
            public string Title { get; set; }
            public  ExperienceLevels ExpLevel{ get; set; }
            public string Company { get; set; }
            public string Location { get; set; }
            public string SalaryRange { get; set; }
            public string JobType { get; set; }

        }
    public class JobSeeker
    {
        Job[] appliedJob = new Job[3];
        int i = 0;
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string AboutMe { get; set; }
        public ExperienceLevels ExpLevel { get; set; }
        public string Qualification { get; set; }
        public string Password { get; set; }

        public Job[] addAppliedJob(Job job) {


            do
            {
                if (job != null)
                {
                    appliedJob[i] = job;
                    i++;
                }

            } while (i < appliedJob.Length);
            return appliedJob;
        }
        //public void GetAppliedJobs() { }
        //public void addSavedJob(Job job) { }
        //public void GetSavedJobs() { }


    }
}

