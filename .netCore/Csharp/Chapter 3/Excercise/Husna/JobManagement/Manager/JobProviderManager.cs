using JobManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManagement.Models;
using JobManagement.Repository;
using JobManagement.Exceptions;


namespace JobManagement.Manager
{
    public class JobProviderManager:IMenu
    {
        private readonly User loggedUser;
        private readonly JobRepository _jobRepository;

        public JobProviderManager(User loggedInUser, JobRepository jobRepository)
        {
            loggedUser = loggedInUser;
            _jobRepository = jobRepository;
        }


        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Job Provider Menu ---");
                Console.WriteLine("1. Post a Job");
                Console.WriteLine("2. List All Jobs");
                Console.WriteLine("3. Back to Main Menu");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PostJob();
                        break;
                    case "2":
                        ListJobs();
                        break;
                    case "3":
                        return; // Go back to main menu
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void PostJob()
        {
            Console.Write("Enter Job Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Job Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Location: ");
            string location = Console.ReadLine();

            Console.Write("Enter Job Type: ");
            string type = Console.ReadLine();

            Console.Write("Enter Salary: ");
            string salary = Console.ReadLine();

            Console.Write("Enter Company Name: ");
            string company = Console.ReadLine();

            int jobId = _jobRepository.GenerateJobId(); // 👈 generate unique ID

            Job newJob = new Job(jobId, title, description, location, type, salary, company); // 👈 pass ID

            _jobRepository.PostJob(newJob);

            Console.WriteLine("✅ Job posted successfully.");
        }


        private void ListJobs()
        {
            var jobs = _jobRepository.GetJobs();
            if (jobs.Count == 0)
            {
                Console.WriteLine("No jobs have been posted yet.");
                return;
            }

            Console.WriteLine("\n--- Posted Jobs ---");
            foreach (var job in jobs)
            {
                Console.WriteLine($"Title: {job.Title}, Company: {job.Company}, Location: {job.Location}");
            }
        }
    }
}
