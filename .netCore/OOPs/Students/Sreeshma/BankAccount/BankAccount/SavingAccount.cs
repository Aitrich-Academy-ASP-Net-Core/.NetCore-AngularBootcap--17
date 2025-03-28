using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class SavingAccount : Account
    {
        //double SavingAccountBalance;
        private double interest;
        double SavingAccountTotalBalance;

        
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
            if(isLoggin)
            {
                Balance = 10000;
                CalculateInterest(Balance);
            }
        }

        
        
        public override void CalculateInterest(double balance)
        {
            interest = balance * 5 / (100*12);
            Console.WriteLine("Interest by Month {0}",interest);
            SavingAccountTotalBalance = interest+balance;
            //Balance=SavingAccountTotalBalance;

            Console.WriteLine("Your Savings Account Total Balance  = {0}",SavingAccountTotalBalance);
        }

       
    }
}
