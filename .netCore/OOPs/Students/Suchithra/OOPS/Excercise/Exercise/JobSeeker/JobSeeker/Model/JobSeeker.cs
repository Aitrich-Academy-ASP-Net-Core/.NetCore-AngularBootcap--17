using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker_Job.Model
{
    internal class JobSeeker
    {
        private int num_applied=0;
        Job[] AppliedJob=new Job[10];
        private int num_saved = 0;
        Job[] SavedJob=new Job[10];
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string AboutMe { get; set; }
        public string Qualification {  get; set; }
        public ExperienceLevel Experience {  get; set; }

        private string password;
        public string Password 
        {
            get {return password;}
            set {password = value;}
        }

        public JobSeeker(int id,string firstName,string lastName,string email,
            string phone,string location,string aboutMe,string qualification,ExperienceLevel experience,string password)
        {
            Id= id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Location = location;
            AboutMe = aboutMe;
            Qualification = qualification;
            Experience = experience;
            Password = password;
        }

        public JobSeeker()
        {
            
        }
        public void AddAppliedJob(Job job)
        {
            AppliedJob[num_applied] = job;
            num_applied++;
            Console.WriteLine("Job Applied");
        }
        public void GetAppliedJob()
        {
            Console.WriteLine("Applied Jobs");
            for(int i = 0; i < num_applied; i++)
            {
                Console.WriteLine("Title : {0}", AppliedJob[i].Title);
                Console.WriteLine("Experience : {0}", AppliedJob[i].Experience);
                Console.WriteLine("Company : {0}", AppliedJob[i].Company);
                Console.WriteLine("Location : {0}", AppliedJob[i].Location);
                Console.WriteLine("Salary Range :{0}", AppliedJob[i].SalaryRange);
                Console.WriteLine("Job Type : {0}", AppliedJob[i].JobType);
            }
        }

        public void AddSavedJob(Job job)
        {
            SavedJob[num_saved] = job;
            num_saved++;
            Console.WriteLine("Job Saved");
        }
        public void GetSavedJob()
        {
            Console.WriteLine("Saved Jobs");
            for (int i = 0; i < num_saved; i++)
            {
                Console.WriteLine("Title : {0}", SavedJob[i].Title);
                Console.WriteLine("Experience : {0}", SavedJob[i].Experience);
                Console.WriteLine("Company : {0}", SavedJob[i].Company);
                Console.WriteLine("Location : {0}", SavedJob[i].Location);
                Console.WriteLine("Salary Range :{0}", SavedJob[i].SalaryRange);
                Console.WriteLine("Job Type : {0}", SavedJob[i].JobType);
            }
        }




    }
}
