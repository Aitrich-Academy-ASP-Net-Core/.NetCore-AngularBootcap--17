using System;
namespace AccountDetails

    {
    class Program
    {
        
        public static void Main(string[] args)
        {
            CurrentAccount current = new CurrentAccount();
            SavingsAccount savings = new SavingsAccount();
            int fees;
            string choice,option;
            do
            {
                Console.WriteLine("Select an Account: ");
                Console.WriteLine("1. Savings Account");
                Console.WriteLine("2. Current Account");
                Console.WriteLine("3.Exit");
               option=Console.ReadLine();
                switch(option)
                {
                    case "1":
                        
                        savings.CalculateInterest();
                break;
                        case "2":
                        Console.WriteLine("Enter Maintenance fees: ");
                        fees=Convert.ToInt32(Console.ReadLine());
                        current.ApplyMaintenanceFee(fees);

                        break;

                    case "3":
                        choice = "n";break;
                    default:Console.WriteLine("Invalid option");
                        break;
                }
                Console.WriteLine("Do you want to continue(y/n): ");
                choice = Console.ReadLine();
                
            } while(choice=="y"||choice=="Y");
           


        }

    }


}