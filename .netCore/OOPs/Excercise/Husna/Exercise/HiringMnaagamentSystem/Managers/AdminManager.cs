using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiringMnaagamentSystem.Models;
using HiringMnaagamentSystem.Utils;

namespace HiringMnaagamentSystem.Managers
{
    internal class AdminManager
    {
        private Printer printer = new Printer();
        public void PrintUsers(User[] NewUsers, int countofuser)
        {

            printer.Print(NewUsers, countofuser);
        }
        public void PrintJobs(Job[] NewJobs)
        {

            printer.Print(NewJobs);
        }

    }
}
