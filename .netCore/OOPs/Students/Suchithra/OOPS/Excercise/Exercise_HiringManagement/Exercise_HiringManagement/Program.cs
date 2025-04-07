using System;
using Exercise_HiringManagement.Enum;
using Exercise_HiringManagement.Interfaces;
using Exercise_HiringManagement.Managers;
using Exercise_HiringManagement.Models;

namespace HiringManagementSystem
{
    class Program
        
    {
        public static void Main(string[] args) {
            IMenu menu = new PublicManager();
            menu.DisplayMenu();

}
    }
}
