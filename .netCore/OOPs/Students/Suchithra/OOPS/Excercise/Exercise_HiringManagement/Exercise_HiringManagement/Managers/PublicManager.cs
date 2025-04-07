
using System;
using Exercise_HiringManagement.Enum;
using Exercise_HiringManagement.Interfaces;
using Exercise_HiringManagement.Models;
using System.Reflection.Metadata;

namespace Exercise_HiringManagement.Managers
{
    internal class PublicManager : ILogin, IMenu
    {

      public  User loggedUser = new User();
        User[] users = new User[] {};
        bool islogged=false;
        int nextId = 2;
        IMenu menu;
        public void DisplayMenu(object? publicManager = null)
        {
            showUserMenu();
        }

        private void showUserMenu()
        {
           bool exitprogram=false;
            while (!exitprogram) 
            {
                Console.WriteLine("1.Register");
                Console.WriteLine("2.Login");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter your option");
                string option=Console.ReadLine();

                switch (option) 
                {

                    case "1":
                        {
                            RegisterJobseeker();
                            break;
                        }
                        case "2":
                        {
                            LoginJobseeker();
                            if (islogged) 
                            menu.DisplayMenu(this);
                            break;
                        }
                        case "3": 
                        {
                            exitprogram = true;
                            break;
                        
                        }
                    default:
                        break;

                            
                  
                                


                    
                }
            
            }

        }

         void LoginJobseeker()
        {
            
            Console.WriteLine("Enter your email");
            string email=Console.ReadLine();

            Console.WriteLine("Enter your password");
            string password=Console.ReadLine();

            bool islogginSucces=false;
          islogginSucces=  Login(email, password);


            if (islogginSucces)
            {
                Console.WriteLine("Login Succes");
                islogged = true;
                Console.WriteLine("Welcome" + loggedUser.FirstName);

                if (loggedUser.Role == Roles.Admin)
                {
                    menu = new AdminManager(loggedUser);

                }

                else
                {
                    menu = new UserManager(loggedUser);
                }

            }
            else
            {
                menu = new PublicManager();
                islogged = false;
                Console.WriteLine("LOgin failed pls try Again!");
            
            }

        }

        void RegisterJobseeker()
        {
            User newJobseeker= new User();

            Console.WriteLine("Enter First name:");
            newJobseeker.FirstName= Console.ReadLine();

            Console.WriteLine("Enter last name");
            newJobseeker.LastName= Console.ReadLine();

            Console.WriteLine("Enter your Email");
            newJobseeker.Email= Console.ReadLine();

            Console.WriteLine("Enter phone");
            newJobseeker.Phone = Console.ReadLine();

            Console.WriteLine("Enter password:");
            newJobseeker.Password = Console.ReadLine();
            Register(newJobseeker);

            Console.WriteLine("Registration Succesfull!!!");

        }

        public bool Login(string email, string password)
        {
            if (users == null)
            {
                return false;
            }
            for(int i = 0; i < users.Length; i++)
            {
                if(users[i].Email == email && users[i].Password == password)
                {
                    islogged = true;
                   loggedUser = users[i];
                    break;
                }
            }
            return islogged;
            
        }

        public void Register(User user)
        {
            user.Id = nextId;
            user.Role=Roles.JobSeeker;
            nextId++;

            if (users == null)
            {
                users = new User[] { user };

            }
            else 
            {
                User[] newUsers= new User[users.Length+1];
                Array.Copy(users,newUsers,users.Length);
                newUsers[newUsers.Length-1] = user;
                users = newUsers;
            
            }

          
           

  
        }
        internal User[] GetUsers() {

            return users;
                }

    }
}