using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMOOPS07042025
{
    public class Currentac : Savingsac
    {
        public void Applymainfee(int mainfee)
        {
            Console.WriteLine("CURRENT ACCOUNT HOLDER NAME: " + Acholder);
            Console.WriteLine("MAINTENANCE FEE: " + mainfee);
            Console.WriteLine($"CURRENT ACCOUNT BALANCE: {Balance - mainfee}");
        }
    }
}
