using HireMeNow_AdminApp.Interfaces;
using HireMeNow_AdminApp.Managers;
using HireMeNow_AdminApp.Models;
using System;

namespace HireMeNow_AdminApp
{
 
 

    class Program
    {
       
        static void Main(string[] args)
        {

            IMenu menu = new PublicManager();
            menu.DisplayMenu();
        }



    }
}