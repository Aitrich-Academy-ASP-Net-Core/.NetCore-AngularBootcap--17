using JobSeeker_Job.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker_Job.Managers
{
    internal class JobSeekerManager
    {
        private JobSeeker[] seeker=new JobSeeker[10];
        private int num_seeker = 0;
        JobSeeker LoggedInJobSeeker=new JobSeeker();
        JobManager jobManager=new JobManager();
        
       

        public void RegisterJobseeker()
        {
            Console.WriteLine("Register here.... ");
            if (num_seeker ==seeker.Length)
            {
                Console.WriteLine("Maximum no.of user reached.Please try again later");
                return;
            }

            Console.WriteLine("Enter Id");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Name");
            string firstName=Console.ReadLine();
            Console.WriteLine("Enter Last Name ");
            string lastName=Console.ReadLine();
            Console.WriteLine("Enter Email");
            string email=Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            string phone=Console.ReadLine();
            Console.WriteLine("Enter Location");
            string location=Console.ReadLine();
            Console.WriteLine("Enter a brief description About You");
            string aboutMe=Console.ReadLine();
            Console.WriteLine("Enter Qualification");
            string qualification=Console.ReadLine();
            Console.WriteLine("Enter Experience (Fresher/MidLevel/Senior)");
            string experience=Console.ReadLine();
            ExperienceLevel level=(ExperienceLevel)Enum.Parse(typeof(ExperienceLevel), experience);
            Console.WriteLine("Enter Password");
            string password=Console.ReadLine();

            JobSeeker NewSeeker=new JobSeeker(id,firstName,lastName,email, phone,
                location, aboutMe,qualification,level,password);
            seeker[num_seeker] = NewSeeker;
            num_seeker++;

            Console.WriteLine("Registration Successful");
            //for(int j=0; j<num_seeker; j++)
            //{
            //    Console.WriteLine("Full Name :{0} {1}", seeker[j].FirstName, seeker[j].LastName);
            //}
                                                               
        }

        public bool LoginJobSeeker()
        {
            Console.WriteLine("Enter the Email");
            string EnterEmail = Console.ReadLine();
            Console.WriteLine("Enter The Password");
            string EnterPassword = Console.ReadLine();
            string ch = "0";

            for (int i = 0; i < num_seeker; i++)
            {
                if (EnterEmail == seeker[i].Email && EnterPassword == seeker[i].Password)
                {
                    Console.WriteLine("Login Successful");
                    jobManager.AvailableJob();
                    while (ch != "7")
                    {
                        Console.WriteLine("1. Apply Job");
                        Console.WriteLine("2. Save Job");
                        Console.WriteLine("3. View Profile");
                        Console.WriteLine("4. Applied Job");
                        Console.WriteLine("5. Saved Job");
                        Console.WriteLine("6. Search Job by Id");
                        Console.WriteLine("7. Logout");

                        ch = Console.ReadLine();

                        if (ch == "1")
                        {

                            for (int j = 0; j < jobManager.jobs.Length; j++)
                            {

                                Console.WriteLine(jobManager.jobs[j].Title);
                                Console.WriteLine(jobManager.jobs[j].Experience);
                                Console.WriteLine(jobManager.jobs[j].Company);
                                Console.WriteLine(jobManager.jobs[j].Location);
                                Console.WriteLine(jobManager.jobs[j].SalaryRange);
                                Console.WriteLine(jobManager.jobs[j].JobType);
                                Console.WriteLine("1. Apply Job");
                                string Applied = Console.ReadLine();
                                if (Applied == "1")
                                {
                                    LoggedInJobSeeker.AddAppliedJob(jobManager.jobs[j]);
                                }
                            }

                        }
                        if (ch == "2")
                        {

                            for (int j = 0; j < jobManager.jobs.Length; j++)
                            {
                                Console.WriteLine(jobManager.jobs[j].Title);
                                Console.WriteLine(jobManager.jobs[j].Experience);
                                Console.WriteLine(jobManager.jobs[j].Company);
                                Console.WriteLine(jobManager.jobs[j].Location);
                                Console.WriteLine(jobManager.jobs[j].SalaryRange);
                                Console.WriteLine(jobManager.jobs[j].JobType);
                                Console.WriteLine("1. Save Job");
                                string Saved = Console.ReadLine();
                                if (Saved == "1")
                                {
                                    LoggedInJobSeeker.AddSavedJob(jobManager.jobs[j]);
                                }
                            }

                        }
                        if (ch == "3")
                        {
                            Console.WriteLine("Profile");
                            Console.WriteLine("First Name : {0}", seeker[i].FirstName);
                            Console.WriteLine("Last Name : {0}", seeker[i].LastName);
                            Console.WriteLine("Email : {0}", seeker[i].Email);
                            Console.WriteLine("Phone : {0}", seeker[i].Phone);
                            Console.WriteLine("Location : {0}", seeker[i].Location);
                            Console.WriteLine("About Me : {0}", seeker[i].AboutMe);
                            Console.WriteLine("Qualification : {0}", seeker[i].Qualification);
                            Console.WriteLine("Experience : {0}", seeker[i].Experience);
                        }
                        if (ch == "4")
                        {
                            LoggedInJobSeeker.GetAppliedJob();

                        }
                        if (ch == "5")
                        {
                            LoggedInJobSeeker.GetSavedJob();
                        }
                        if (ch == "6")
                        {

                            Console.WriteLine("Enter Id Between 1 to 5");
                            int searchId = Convert.ToInt32(Console.ReadLine());
                            jobManager.GetJobById(searchId);
                        }
                        if (ch == "7")
                        {
                            Console.WriteLine("Logging Out...");
                        }
                    }
                    return true;
                }

            }
            Console.WriteLine("Invalid Email or Password");
            return false;
        }

      

    }
}
