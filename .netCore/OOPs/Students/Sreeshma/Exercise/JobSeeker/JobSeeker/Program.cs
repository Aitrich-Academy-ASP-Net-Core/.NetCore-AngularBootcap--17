using JobSeeker_Job.Managers;
using JobSeeker_Job.Model;

namespace JobSeeker_Job
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           JobSeekerManager seeker = new JobSeekerManager();

            Console.WriteLine("Hire Me Now.....");
            while (true)
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                string input= Console.ReadLine();

                switch(input)
                {
                    case "1":
                        {
                            seeker.RegisterJobseeker();
                        }
                        break;
                    case "2":
                        {
                            seeker.LoginJobSeeker();
                        }
                        break;
                    case "3":
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        break;
                }
            }
        }
    }
}
