using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetails
{
    public abstract class Account
    {
        public string AccountHolder { get; set; }    
        public int Balance { get; set; }
        abstract public void CalculateInterest();
    }
}
