using HireMeNow_AdminApp.Enums;
using HireMeNow_AdminApp.Interfaces;
using HireMeNow_AdminApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireMeNow_AdminApp.Managers
{
    public class PublicManager:IMenu,ILogin
    {
        public User LoggedUser = new User();
        User[] users=new User[] {
            new User(1,"admin","","admin@gmail.com","","123",Roles.Admin) 
            //new JobSeeker(1,"manu","raj ","manu@gmail.com","789654254","123",Roles.JobSeeker) ,
            //    new JobSeeker(1,"vicky","shroff ","vicky@gmail.com","9655856956","123",Roles.JobSeeker) ,
                            };
        bool _isLogged = false;
        IMenu menu;
       
        private int nextId = 2;

        public void DisplayMenu(object? publicManager = null)
        {
            showUserMenu();
        }

        private void showUserMenu()
        {
            bool exitProgram = false;


            while (!exitProgram)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Exit");

                string option1 = Console.ReadLine();
                
                switch (option1)
                {
                    case "1":
                        LoginJobSeeker();
                        if(_isLogged)
                        menu.DisplayMenu(this);
                        break;
                    case "2":
                        RegisterJobSeeker();
                        break;
                    case "3":
                        exitProgram = true;
                        break;
                    default:
                        break;
                }
            }
        }
        void LoginJobSeeker()
        {
            
            Console.WriteLine("Please enter your email:");
            string email = Console.ReadLine();

            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();

            
            bool loginSuccessful = false;
            loginSuccessful = Login(email, password);


            if (loginSuccessful)
            {
                Console.WriteLine("Login successful!");
                _isLogged = true;
                Console.WriteLine("Welcome " + LoggedUser.FirstName);
                if (LoggedUser.Role == Roles.Admin)
                {
                    menu = new AdminManager(LoggedUser);
                }
                else
                {
                    menu=new UserManager(LoggedUser);
                }
            }
            else
            {
                menu = new PublicManager();
                _isLogged = false;
                Console.WriteLine("Login failed. Please try again.");
            }
        }
        void RegisterJobSeeker()
        {
            User newJobSeeker = new User();

            Console.WriteLine("Please enter your first name:");
            newJobSeeker.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            newJobSeeker.LastName = Console.ReadLine();

            Console.WriteLine("Please enter your email address:");
            newJobSeeker.Email = Console.ReadLine();

            Console.WriteLine("Please enter your phone number:");
            newJobSeeker.Phone = Console.ReadLine();

            Console.WriteLine("Please enter a password:");
            newJobSeeker.Password = Console.ReadLine();

            Register(newJobSeeker);

            Console.WriteLine("Registration successful");
        }

        public bool Login(string email, string password)
        {
          if(users == null)
              return false;
          for(int i=0; i<users.Length; i++)
            {
                if (users[i].Email== email && users[i].Password == password)
                {
                    _isLogged = true;
                    LoggedUser = users[i];
                    break;
                }
            }
          return _isLogged;
        }

        public void Register(User user)
        {
            user.Id = nextId;
            user.Role= Roles.JobSeeker;
            nextId++;
            if (users == null)
            {
                users = new User[] { user };
            }
            else
            {
                User[] newUsers = new User[users.Length + 1];
                Array.Copy(users, newUsers, users.Length);
                newUsers[newUsers.Length - 1] = user;
                users = newUsers;
            }
        }

        internal User[] getAllUsers()
        {
           return users;
        }
    }
}
