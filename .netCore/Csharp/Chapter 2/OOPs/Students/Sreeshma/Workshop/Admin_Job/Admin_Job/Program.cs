using Admin_Job.Manager;

namespace Admin_Job
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Admin admin=new Admin();

            Console.WriteLine("Welcome to Job Portal Admin Module");

            while (true)
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "1": 
                        {
                            Console.WriteLine("Enter Username");
                            string regUsername=Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            string regPassword=Console.ReadLine();
                            admin.Register(regUsername, regPassword);
                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine("Enter Username");
                            string regUsername = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            string regPassword = Console.ReadLine();
                            admin.Login(regUsername, regPassword);
                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine("Good Bye");
                            return;
                        }
                    case "4":
                        {
                            Console.WriteLine("Invalid input");
                            break;
                        }
                }




            }   
        }
    }
}