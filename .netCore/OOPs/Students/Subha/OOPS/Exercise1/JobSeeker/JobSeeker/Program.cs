using System;
using JobSeekerModule.Managers;
namespace JobSeekerModule
{
    class Program
    {
        public static void Main(string[] args)
        {
            JobSeekerManager jobSeekerManager = new JobSeekerManager();
            jobSeekerManager.ShowMainMenu();

        }
        }
}