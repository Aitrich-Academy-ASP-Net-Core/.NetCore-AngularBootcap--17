using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Exam_3.Enum;
using Exam_3.Main;
using Exam_3.Modal;

internal class Program
{


    private static void Main(string[] args)
    {

        BankManager bank = new BankManager();
        BankAccount bankAccount=new BankAccount();

        bool exit = false;
        while (!exit)

        {
            try
            {
                Console.WriteLine("Welcome to the Bank Account Management System ");
                Console.WriteLine("1 .Create a New BankAccount");
                Console.WriteLine("2 .Remove an Account");
                Console.WriteLine("3 .Deposit Money");
                Console.WriteLine("4 . Withdraw Money");
                Console.WriteLine("5 .Check Balance");
                Console.WriteLine("6 .Exit");

                Console.WriteLine("Choose The Option You Want");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":

                        Console.WriteLine("Enter the account no");
                        int Accno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the holder name");
                        var name = Console.ReadLine();
                        Console.WriteLine("enter the account type savings/current");
                        AccountType type = (AccountType)Enum.Parse(typeof(AccountType), Console.ReadLine(), true);



                        Console.WriteLine("enter the amount");
                        decimal balance = Convert.ToDecimal(Console.ReadLine());
                        var acc = new BankAccount(Accno, name, type, balance);
                        bank.AddNewAccount(acc);


                        break;

                    case "2":
                        Console.WriteLine("enter the accountno to remove");
                        int accno=Convert.ToInt32(Console.ReadLine());
                        bank.RemoveAccount(accno);
                        break;

                    case "3":


                        Console.WriteLine("enter the accountno ");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        bank.Deposit(deposit);
                        break;

                    case "4":
                        Console.WriteLine("enter the accountno ");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        bank.Withdraw(withdraw);    
                        break;

                    case "5":
                        Console.WriteLine("enter the accountno ");
                        int check = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"current Balance {bankAccount.Balance}");
                        break;

                    case "6":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("invalied");
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }
    }


    





}



    
