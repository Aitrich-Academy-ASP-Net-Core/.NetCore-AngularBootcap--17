using Example1;
using System;
namespace Abstract_Class_Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            JobSeeker js=new JobSeeker();
            string name = "subha";
            string email = "subha.s.sivan@gmail.com";
            js.Login(name,email);
            js.ApplyJob();
            js.welcome();
        }
    }
}