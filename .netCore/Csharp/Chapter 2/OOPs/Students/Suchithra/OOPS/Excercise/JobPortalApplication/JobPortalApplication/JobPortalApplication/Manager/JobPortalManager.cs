using JobPortalApplication.Enums;
using JobPortalApplication.Interface;
using JobPortalApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JobPortalApplication.Manager
{
    internal class JobPortalManager : IUser, IJobProvider, IInterviewProvider

    {
        public User loggedUser = new User();
        public bool islogged = false;
        private Job[] jobs = new Job[10];
        private Interview[] interviews = new Interview[10];
        private User[] users = new User[10];
        public int Usercount = 0;
        public int Jobcount = 0;
        public int Interviewcount = 0;
        int NextUserid = 1;

        Printer Printer = new Printer();
        public Application[] applications = new Application[] {new Application(1,"james","Delhi","Mca","6+ years")};

        

      

       

        public Interview[] GetInterviews()
        {
          return interviews;
        }

        public Job[] GetJobs()
        {
            return jobs;
        }
            
           

        public void Login(string username, string password)
        {
           bool islogged= false;
           
            for (int i = 0; i < Usercount; i++) 
            {
                if (users[i].FirstName == username && users[i].Password == password)
                {
                    islogged=true;
                   
                    Console.WriteLine($"welcome  {username}",username);
                    if (users[i].Role == Roles.JobProvider)
                    {
                        bool ExitJobprovider = false;
                        while (!ExitJobprovider)
                        {
                            Console.WriteLine("1.Listing jobs");
                            Console.WriteLine("2.Post job");
                            Console.WriteLine("3.Application List");
                            Console.WriteLine("4.Exit");
                            string option = Console.ReadLine();

                            if (option == "1")
                            {
                                Printer.print(jobs);
                            }
                            if (option == "2")
                            {
                                Postingjob();
                            }
                            if (option == "3")
                            {
                                Printer.print(applications);
                            }
                            if (option == "4")
                            {
                                Console.WriteLine("Exiting");
                                ExitJobprovider = true;
                            }
                        }
                    }
                    else if (users[i].Role == Roles.InterviewProvider)
                    {
                        bool exitinterviewprovider = false;
                        while (!exitinterviewprovider)
                        {
                            Console.WriteLine("1.Listinginterview");
                            Console.WriteLine("2.Schedule interview");

                            Console.WriteLine("3.Exit");
                            string option = Console.ReadLine();
                            if (option == "1")
                            {
                                Printer.print(interviews);
                            }
                            if (option == "2")
                            {
                                SheduleInterview();
                            }
                            if (option == "3")
                            {
                                Console.WriteLine("Exiting...");
                                exitinterviewprovider = true;
                            }
                        }
                    }
                    //else if (users[i].Role == Roles.JobSeeker)
                    //{
                    //    bool exitinterviewprovider = false;
                    //    while (!exitinterviewprovider)
                    //    {
                    //        Console.WriteLine("1.Listing job");
                    //        Console.WriteLine("2.list interview");

                    //        Console.WriteLine("3.Exit");
                    //        string option = Console.ReadLine();
                    //        if (option == "1")
                    //        {
                    //            Printer.print(jobs);
                    //        }
                    //        if (option == "2")
                    //        {
                    //            Printer.print(interviews);
                    //        }
                    //        if (option == "3")
                    //        {
                    //            Console.WriteLine("Exiting...");
                    //            exitinterviewprovider = true;
                    //        }
                    //    }
                    //}
                    }
            
            }

           
        }

        public void Postingjob()
        {

            Job job1 = new Job();
            Console.WriteLine("Enter job Tittle:");
            job1.Title = Console.ReadLine();
            Console.WriteLine("pls say about your job");
            job1.Description = Console.ReadLine();
            Console.WriteLine("Enter your Location:");
            job1.Location = Console.ReadLine();
            Console.WriteLine("Enter your salary");
            job1.Salary = Console.ReadLine();
            Console.WriteLine("Enter your job type");
            job1.Type = Console.ReadLine();
            Console.WriteLine("Enter your Commpany");
            job1.Company = Console.ReadLine();
            PostJob(job1);
        }

               public void PostJob(Job job) {

                               
                    jobs[Jobcount] = job;
                    Jobcount++;
                    Console.WriteLine("jobs added succesfully");

                }

                   

        public void SheduleInterview()
        {

            int id = Interviewcount;
            Interviewcount++;

               
                Console.WriteLine("Enter your company");
                string company = Console.ReadLine();
                Console.WriteLine("Enter job post for interview");
               string Post = Console.ReadLine();
                Console.WriteLine("Enter interview date:");
               string Date = Console.ReadLine();
                Console.WriteLine("Enter location");
                string Location = Console.ReadLine();
            Console.WriteLine("Enter time");
            string time= Console.ReadLine();
            Interview interview1 = new Interview(id, company, Post, Date, Location, time);
            ScheduleInterview(interview1);

            }
       
            
        
        public void Logout()
        {
            islogged= false;
            loggedUser = null;
            Console.WriteLine("Loged out...");
        }
        public void RegisterUser() {
            int id = NextUserid;
            NextUserid++;
            Console.WriteLine("Enter first name");
            string fname=Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lname=Console.ReadLine();
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your phone number");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter role (JobProvider/InterviewProvider):");
            Roles role = Enum.Parse<Roles>(Console.ReadLine());
            User NewUser=new User(id,fname, lname, email, phone, password,role);
            Register(NewUser);
        }
        public void Register(User user)
        {
          

          
                users[Usercount] = user;
                Usercount++;
                Console.WriteLine("Registration Succesfull");
            

        }

        public void ScheduleInterview(Interview interview)
        {
            interviews[Interviewcount] = interview;
            Interviewcount++;
            Console.WriteLine("interview added succesfully");

        }
    }
}
