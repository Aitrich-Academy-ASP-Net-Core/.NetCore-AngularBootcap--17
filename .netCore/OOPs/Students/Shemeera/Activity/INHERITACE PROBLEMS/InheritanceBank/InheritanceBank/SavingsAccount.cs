using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBank
{
    internal class SavingsAccount:BankAccount
    {

        public double InterestRate;

        public SavingsAccount(int accountno ,int balance,double interestrate):base (accountno, balance)
        {
            InterestRate = interestrate;    
        }

        public void Display()
        {
            Console.WriteLine($"ACCONT NO = {AccountNo} \n BALANCE IS {Balance} \n INTEREST IS {InterestRate}%");
        }

        
        public void Interest()
            {

            double interest = (Balance * InterestRate) / 100;
            Console.WriteLine("Interest rate =" + interest);

           
            Console.WriteLine($"Total Balance after interest: ${Balance + interest}");



        }
    }
}
