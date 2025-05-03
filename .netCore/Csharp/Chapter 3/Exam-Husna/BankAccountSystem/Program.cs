using BankAccountSystem.Manager;
using BankAccountSystem.Models;

namespace BankAccountSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Bank bank = new Bank();
            while (true)
            {
                Console.WriteLine("Welcome to Bank Management System");
                Console.WriteLine("1.Create Account");
                Console.WriteLine("2.Remove Account");
                Console.WriteLine("3.Deposit");
                Console.WriteLine("4.Withdraw");
                Console.WriteLine("5.Balance");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Choose an option");
                string choice = Console.ReadLine();
                try
                {

                    switch (choice)
                    {

                        case "1":
                            Console.WriteLine("Account Number");
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("Holder Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Initial Balance");
                            decimal balance = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Account type:Savings/Current");
                            string type = Console.ReadLine();

                            BankAccount bankAccount = new BankAccount(number, name, balance, type);


                            bank.AddAccount(bankAccount);

                            Console.WriteLine("Account created");
                            break;


                        case "2":

                            Console.WriteLine("Enter Account number to remove");
                            int removeid = int.Parse(Console.ReadLine());

                            bank.RemoveAccount(removeid);

                            Console.WriteLine("Account Removed");
                            break;

                        case "3":
                            Console.WriteLine("Enter Account number to deposit");
                            int accnum = int.Parse(Console.ReadLine());
                            var depositAccount = bank.GetAccount(accnum);
                            Console.WriteLine("Enter Amount to Deposit");
                            decimal amount1 = Convert.ToDecimal(Console.ReadLine);
                            depositAccount.Deposit(amount1);
                            break;

                        case "4":
                            Console.WriteLine("Enter Account number to withdraw");
                            int accnumber = int.Parse(Console.ReadLine());
                            var withdrawalAccount = bank.GetAccount(accnumber);
                            Console.WriteLine("Enter Amount to Withdraw");
                            decimal amount2 = Convert.ToDecimal(Console.ReadLine);
                            withdrawalAccount.Withdraw(amount2);
                            break;

                        case "5":
                            bank.DisplayAccount();
                            break;
                        case "6":
                            return;
                        default:
                            Console.WriteLine("Invalid option");
                            break;






                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }

        }
    }
}
