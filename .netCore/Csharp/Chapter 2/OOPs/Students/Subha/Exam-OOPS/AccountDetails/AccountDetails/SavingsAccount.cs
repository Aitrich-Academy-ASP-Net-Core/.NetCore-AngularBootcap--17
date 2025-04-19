using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetails
{
    internal class SavingsAccount:Account
    {
        public override void CalculateInterest() {
            Console.Write("Enter Name: ");
            AccountHolder=Console.ReadLine();
            Console.WriteLine("Enter Balance: ");
            Balance =Convert.ToInt32 (Console.ReadLine());
            float interest;
            interest =( Balance*5)/100;
            Console.WriteLine("Interest:"+interest);
        
        }
    }
}
