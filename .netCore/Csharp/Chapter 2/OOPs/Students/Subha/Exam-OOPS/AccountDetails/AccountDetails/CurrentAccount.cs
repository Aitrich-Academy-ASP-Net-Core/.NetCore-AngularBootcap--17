using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetails
{
    internal class CurrentAccount
    {
        public void ApplyMaintenanceFee(int M_fees)
        {
            SavingsAccount account = new SavingsAccount();
            Console.WriteLine("Enter balance: ");
            account.Balance = Convert.ToInt32(Console.ReadLine());
            int amount = account.Balance - M_fees;
            Console.WriteLine("Balance after deducting monthly fees: "+amount);
        }
        
    }
}
