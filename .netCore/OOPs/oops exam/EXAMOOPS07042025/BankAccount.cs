using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMOOPS07042025
{
    public abstract class BankAccount
    {
        public string Acholder;
        public int Balance;
        
        public abstract void Calcinterest();
    }
}
