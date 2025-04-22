using Exercise_HiringManagement.Interfaces;
using Exercise_HiringManagement.Models;
using Exercise_HiringManagement.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_HiringManagement.Managers
{
    internal class AdminManager:IMenu
    {
        private User loggeduser;
        private PublicManager publicManager=new PublicManager();
        private Printer printer=new Printer();
        JobManager jobManager = new JobManager();

        public AdminManager(User loggedUser) 
        {
            this.loggeduser = loggedUser;
        
        }
       
public void DisplayMenu(object? publicManager = null)
        {
            if (publicManager != null) 
            {
                publicManager=(PublicManager)publicManager;
                ShowAdminMenu();
            }
        }

        private void ShowAdminMenu()
        {
            Console.WriteLine("1.New Registration ");
            Console.WriteLine("2.List all Jobs");
            Console.WriteLine("3.Logout");
            Console.WriteLine("Enter your choice");
            String choice=Console.ReadLine();

            switch (choice)
            {
                case "1":
                    {
                        User[] users=publicManager.GetUsers();
                        printer.print(users);
                        ShowAdminMenu();
                        break;
                    }
                    case "2": 
                    {
                        jobManager.ListJob();
                        ShowAdminMenu() ;
                        break;
                    }
                    case "3":
                    {
                        Logout();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid choice pls try again");
                        ShowAdminMenu();
                        break;
                    }
            }

        }

        private void Logout()
        {
            loggeduser = null;
            Console.WriteLine("Logout!!");

        }
    }





    }
    