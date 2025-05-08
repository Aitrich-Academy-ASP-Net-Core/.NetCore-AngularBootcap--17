using c_mainexammm.Interfaces;
using c_mainexammm.methods;
using c_mainexammm.Models;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace c_mainexammm
{
    public class Program : Bankaccount
    {
        public Program(int acno, string acHolderName, double balance, AccountType acType) : base(acno, acHolderName, balance, acType)
        {
        }

        public void Main(string[] args)
        {
            Ibank bank = new Ibank();
            Console.WriteLine("enter your option:\n1.Add a Bank Account\n2." +
                "remove an account\n3.deposit money\n4.withdraw money\n5.check balance");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    Console.WriteLine("enter account details to add");
                    bank.AddAccount();
                    break;
                case 2:
                    Console.WriteLine("enter account details to remove");
                    bank.RemoveAccount();
                    break;
                    
                case 3:
                    Console.WriteLine("enter account details to deposit");
                    Deposit();
                    break;
                case 4:
                    Console.WriteLine("enter account details to withdraw");
                    Withdraw();
                    break;
                case 5:
                    Console.WriteLine("enter account details to check balance");
                    Console.WriteLine(Balance);
                    break;






            }
        }

        private void Withdraw()
        {
            throw new NotImplementedException();
        }

        private void Deposit()
        {
            throw new NotImplementedException();
        }
    }
}
