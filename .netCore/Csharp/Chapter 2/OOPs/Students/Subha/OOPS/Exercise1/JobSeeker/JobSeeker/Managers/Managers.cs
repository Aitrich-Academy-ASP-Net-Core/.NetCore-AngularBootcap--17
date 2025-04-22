using System;
using JobSeekerModule.Enum;
using JobSeekerModule.Models;

namespace JobSeekerModule.Managers
{
   
    public class JobManager : Models.Job
    {
        JobSeeker jobSeeker = new JobSeeker();
        private Job[] jobs = {
            new Job { JobId = "1", Title = "Software Engineer", ExpLevel = ExperienceLevels.Fresher, Company = "Acme Inc.", Location = "NewYork, NY", SalaryRange = "$100,000-$150,000", JobType="Full-time" },
            new Job { JobId = "2", Title = "Product Manager", ExpLevel = ExperienceLevels.Senior, Company = "Globex Corp.", Location = "SanFrancisco, CA", SalaryRange = "$120,000-$180,000", JobType="Online" },
            new Job { JobId = "3", Title = "Marketing Specialist", ExpLevel = ExperienceLevels.MidLevel, Company = "Hooli Enterprises", Location = "Seattle, WA", SalaryRange = "$70,000-$90,000", JobType="Remote" }
        };

        public void ListJobs()
        {
            Console.WriteLine("ID   Title               ExperienceLevel   Company           Location          Salary      Job Type ");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            foreach (var job in jobs)
            {
                Console.WriteLine(job.JobId + "    " + job.Title + "     " + job.ExpLevel + "   " + job.Company + "   " + job.Location + "   " + job.SalaryRange + "    " + job.JobType);
            }
            Console.WriteLine();
        }

        public void PrintJobs()
        {
            ListJobs();
        }

        public Job GetJobById(string jobId)
        {
            foreach (var job in jobs)
            {
                if (job.JobId == jobId)
                    return job;
            }
            return null;
        }
    }

    public class JobSeekerManager
    {
        private JobSeeker[] jobSeekers = new JobSeeker[5];
        private int jobSeekerCount = 0;
        private JobSeeker loggedInJobSeeker;
        private JobManager jobManager = new JobManager();
        private bool isLoggedIn = false;
        
        public void RegisterJobSeeker()
        {
           
            JobSeeker newJobSeeker = new JobSeeker();

            Console.WriteLine("***** Enter Registration Details *****");
            Console.Write("Enter Id: ");
            newJobSeeker.Id = Console.ReadLine();
            Console.Write("Enter First Name: ");
            newJobSeeker.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            newJobSeeker.LastName = Console.ReadLine();
            Console.Write("Enter Email: ");
            newJobSeeker.Email = Console.ReadLine();
            Console.Write("Enter Phone: ");
            newJobSeeker.Phone = Console.ReadLine();
            Console.Write("Enter Location: ");
            newJobSeeker.Location = Console.ReadLine();
            Console.Write("Enter About me: ");
            newJobSeeker.AboutMe = Console.ReadLine();
            Console.Write("Enter Experience Level (Fresher/MidLevel/Senior): ");
            string expLevel = Console.ReadLine();
            if (expLevel == "Senior")
                newJobSeeker.ExpLevel = ExperienceLevels.Senior;
            else if (expLevel == "MidLevel")
                newJobSeeker.ExpLevel = ExperienceLevels.MidLevel;
            else
                newJobSeeker.ExpLevel = ExperienceLevels.Fresher;
            Console.Write("Enter Qualification: ");
            newJobSeeker.Qualification = Console.ReadLine();
            Console.Write("Enter Password: ");
            newJobSeeker.Password = Console.ReadLine();

            jobSeekers[jobSeekerCount++] = newJobSeeker;
            Console.WriteLine("Registration successful.");
        }

        public void LoginJobSeeker()
        {
            if (jobSeekerCount == 0)
            {
                Console.WriteLine("No registered users. Please register first.\n");
                ShowMainMenu();
                return;
            }

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            foreach (var seeker in jobSeekers)
            {
                if (seeker != null && seeker.Email == email && seeker.Password == password)
                {
                    loggedInJobSeeker = seeker;
                    Console.WriteLine("Login Successful! Welcome "+loggedInJobSeeker.FirstName);
                    isLoggedIn = true;
                    ShowJobSeekerMenu();
                   
                }
            }

            Console.WriteLine("Invalid email or password. Please try again.\n");
        }

        public void ShowJobSeekerMenu()
        {
            while (isLoggedIn)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Apply for Job");
                Console.WriteLine("2. Save Job");
                Console.WriteLine("3. View Profile");
                Console.WriteLine("4. Logout");
                Console.WriteLine("5. Back to Main Menu");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ApplyJob();
                        break;
                    case "2":
                        SaveJob();
                        break;
                    case "3":
                        ViewProfile();
                        break;
                    case "4":
                        Logout();
                        break;
                    case "5":
                        ShowMainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public void ApplyJob()
        {
            JobSeeker appliedJob = new JobSeeker();
            jobManager.ListJobs();
            Console.Write("Enter Job ID to apply: ");
            string jobId = Console.ReadLine();
            
            Job job1 = jobManager.GetJobById(jobId);
            appliedJob.addAppliedJob(job1);
            if (job1 != null)
            {
                Job[] job=appliedJob.addAppliedJob(job1 as Job);     
               for(int i=0;i<job.Length;i++)
                   { Console.WriteLine(job[i].JobId+"    " + job[i].Title+"     " + job[i].ExpLevel+"   " + job[i].Company+"   " + job[i].Location+"   " + job[i].SalaryRange+"    " + job[i].JobType);
                    Console.WriteLine("Successfully applied to " + job[i].Title + " at " + job[i].Company);
                }
            }
            else
            {
                Console.WriteLine("Job not found.");
            }
        }

        public void SaveJob()
        {
            
        }

        public void ViewProfile()
        {
            if (loggedInJobSeeker != null)
            {
                Console.WriteLine("\n--- Profile Information ---");
                Console.WriteLine("ID: "+loggedInJobSeeker.Id);
                Console.WriteLine("Name: "+loggedInJobSeeker.FirstName+" "+loggedInJobSeeker.LastName);
                Console.WriteLine("Email: "+loggedInJobSeeker.Email);
                Console.WriteLine("Phone: "+loggedInJobSeeker.Phone);
                Console.WriteLine("Location: "+loggedInJobSeeker.Location);
                Console.WriteLine("About Me: "+loggedInJobSeeker.AboutMe);
                Console.WriteLine("Experience Level: "+loggedInJobSeeker.ExpLevel);
                Console.WriteLine("Qualification: "+loggedInJobSeeker.Qualification);
            }
            else
            {
                Console.WriteLine("No profile information found.");
            }
        }

        public void Logout()
        {
            isLoggedIn = false;
            Console.WriteLine("Successfully logged out.");
            ShowMainMenu();
        }

        public void ShowMainMenu()
        {
            string choice;
            do
            {
                Console.WriteLine("Welcome to Job Portal");
                Console.WriteLine("----------------------");
                Console.WriteLine("\n--- Main Menu ---");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        RegisterJobSeeker();
                        break;
                    case "2":
                        LoginJobSeeker();
                        break;
                    case "3":
                        Console.WriteLine("Exiting application.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != "3");
        }
    }
}
