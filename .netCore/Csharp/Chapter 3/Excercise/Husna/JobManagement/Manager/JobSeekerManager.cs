using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManagement.Interfaces;
using JobManagement.Models;
using JobManagement.Repository;
using JobManagement.Exceptions;

namespace JobManagement.Manager
{
    public class JobSeekerManager:IMenu
    {
        private readonly JobRepository _jobRepository;
        private readonly User loggedUser;

        public JobSeekerManager(User loggedInUser, JobRepository jobRepository)
        {
            loggedUser = loggedInUser;
            _jobRepository = jobRepository;
        }


        public void ShowMenu()
        {
            try
            {
                Console.WriteLine("\n--- Job Seeker Menu ---");
                Console.WriteLine("1. View My Profile");
                Console.WriteLine("2. List All Jobs");
                Console.WriteLine("3. Apply for Job");
                Console.WriteLine("4. Log Out");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewProfile();
                        break;
                    case "2":
                        ListAllJobs();
                        break;
                    case "3":
                        ApplyForJob();
                        break;
                    case "4":
                        Console.WriteLine("Logged out successfully.");
                        return;
                    default:
                        throw new InvalidChoiceException("Invalid choice, please select again.");
                }
                ShowMenu();
            }
            catch (InvalidChoiceException ex)
            {
                Console.WriteLine(ex.Message);
                ShowMenu();
            }
        }

        private void ViewProfile()
        {
            Console.WriteLine("\n--- My Profile ---");
            Console.WriteLine($"Name: {loggedUser.FirstName} {loggedUser.LastName}");
            Console.WriteLine($"Email: {loggedUser.Email}");
            Console.WriteLine($"Phone: {loggedUser.Phone}");
        }

        private void ListAllJobs()
        {
            var jobs = _jobRepository.GetAllJobs();
            Console.WriteLine("\n--- Available Jobs ---");
            foreach (var job in jobs)
            {
                Console.WriteLine($"{job.JobId} - {job.Title} at {job.Company} ({job.Location})");
            }
        }


        private void ApplyForJob()
        {
            Console.WriteLine("\nEnter Job ID to apply:");
            int jobId = int.Parse(Console.ReadLine());
            var job = _jobRepository.GetJobById(jobId);
            loggedUser.AppliedJobs.Add(jobId);
            Console.WriteLine($"Applied to {job.Title} at {job.Company} successfully!");
        }


    }
}
