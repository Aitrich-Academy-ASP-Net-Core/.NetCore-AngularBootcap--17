using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal abstract class Account
    {
       public string AccountHolder = "Rakhi";
       public int AccountHolderId = 123;
        public double Balance;

       
        public abstract void CalculateInterest(double balance);
    }
}
