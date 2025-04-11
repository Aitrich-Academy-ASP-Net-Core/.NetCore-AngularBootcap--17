using HiringMnaagamentSystem.Managers;
using HiringMnaagamentSystem.Models;
using static HiringMnaagamentSystem.Enum.Role;

internal class Program
{
    private static void Main(string[] args)
    {
        PublicManager manager = new PublicManager();

        while (true)
        {
            Console.WriteLine("\n______________________________________________WELCOME TO HIRING MANAGEMENT SYSTEM_______________________________________\n");
            Console.WriteLine("Choose an option:\n");
            Console.WriteLine("1-Register");
            Console.WriteLine("2-Login");
            Console.WriteLine("3-Display(Role-based)");
            Console.WriteLine("4-Exit");
            string op = Console.ReadLine();
            switch (op)
            {
                case "1":
                    Console.Write("enter your ID:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("enter you FirstName:");
                    string fname = Console.ReadLine();
                    Console.Write("enter you LastName:");
                    string lname = Console.ReadLine();
                    Console.Write("enter you Email:");
                    string email = Console.ReadLine();
                    Console.Write("enter you Password:");
                    string password = Console.ReadLine();
                    Console.Write("enter you PhoneNumber:");
                    string number = Console.ReadLine();
                    Console.Write("enter you Role(Admin/Jobseeker):");
                    string value = Console.ReadLine();
                    Roles role;
                    bool isvalid = Roles.TryParse(value, true, out role);
                    if (!isvalid)
                    {
                        Console.WriteLine("Invalid role! Please enter 'Admin' or 'Jobseeker'.");
                        break;
                    }
                    User newuser = new User(id, fname, lname, email, password, number, role);
                    manager.Register(newuser);
                    break;
                case "2":
                    Console.Write("Enter your Email:");
                    string loginEmail = Console.ReadLine();
                    Console.Write("Enter your Password:");
                    string loginPword = Console.ReadLine();
                    manager.Login(loginEmail, loginPword);
                    break;
                case "3":

                    manager.DisplayMenu();
                    break;
                case "4":
                    Console.WriteLine("_________________________________Good Bye______________________________");
                    return;

                default:
                    Console.WriteLine("wrong option");
                    break;
            }
        }


    }
}