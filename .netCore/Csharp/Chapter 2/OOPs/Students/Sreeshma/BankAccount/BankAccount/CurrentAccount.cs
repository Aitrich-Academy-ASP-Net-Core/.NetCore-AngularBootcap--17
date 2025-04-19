using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class CurrentAccount:Account
    {
        double monthlyCharge = 20;
        bool isLoggin=false;

        public void Login(string name, int id)
        {
            if (name == AccountHolder && id == AccountHolderId)
            {
                Console.WriteLine("Login Successfully");
                isLoggin = true;

            }
            else
            {
                Console.WriteLine("Please enter valid Id and Name");
                isLoggin=false;
            }
            if (isLoggin)
            {
                Balance = 100000;
                ApplyMaintananceFee(Balance);
            }
        }
        public void ApplyMaintananceFee(double currentBalance)
        {
            currentBalance = currentBalance - 20;
            Console.WriteLine("Your Current Account Balance After deducting Maintanance Charge is {0}",currentBalance);
        }

        public override void CalculateInterest(double balance)
        {
            throw new NotImplementedException();
        }
    }
}
