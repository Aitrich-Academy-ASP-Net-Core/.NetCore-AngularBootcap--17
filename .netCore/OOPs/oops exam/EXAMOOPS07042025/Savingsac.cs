using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMOOPS07042025
{
    public class Savingsac : BankAccount
    {

        public override void Calcinterest()
        {
            //Console.WriteLine("Enter the current balance");
            //Balance = Convert.ToInt32(Console.ReadLine());
            int interest = (Balance * 5) / 100;
            Console.WriteLine($"SAVINGS ACCOUNT HOLDER NAME: " + Acholder);
            Console.WriteLine("INTEREST: " + interest);
            Console.WriteLine($"SAVINGS ACCOUNT BALANCE: {Balance + interest}\n\n");
        }
    }
}
