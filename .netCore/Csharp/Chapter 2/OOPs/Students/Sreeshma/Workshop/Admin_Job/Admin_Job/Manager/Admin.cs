using Admin_Job.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Job.Manager
{
    internal class Admin
    {
        private User[] users = new User[2];
        private int num_users = 0;
        JobManager job=new JobManager();
        bool _isLogged=false;

        public void Register(string username,string password)
        {
            if (num_users == users.Length)
            {
                Console.WriteLine("Maximum no.of users reached.Please try again later");
                return;
            }

            for(int i = 0; i < num_users; i++)
            {
                if (users[i].UserName == username)
                {
                    Console.WriteLine("Username already exist");
                }
            }

            User newUser=new User(username,password);
            users[num_users] = newUser;
            num_users++;

            Console.WriteLine("Registration Successful");

        }

        public bool Login(string username, string password)
        {
            for(int i = 0;i < num_users;i++)
            {
                if(users[i].UserName == username && users[i].Password == password)
                {
                    Console.WriteLine("Login Successful");
                    _isLogged = true;
                    string ch = "0";
                    while(ch != "3")
                    {
                        Console.WriteLine("1. Add job");
                        Console.WriteLine("2. List Job");
                        Console.WriteLine("3. Back to main menu");
                        ch = Console.ReadLine();

                        if (ch == "1")
                        {
                            job.AddJob();
                        }
                        if(ch == "2")
                        {
                            job.ListJob();
                        }
                        if(ch == "3")
                        {
                            Console.WriteLine("Exiting");
                        }
                    }
                    return true;
                }
                
            }
            Console.WriteLine("Invalid Username or Password");
            return false;

        }
    }
}
