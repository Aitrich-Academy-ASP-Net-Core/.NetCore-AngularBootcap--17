using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountSystem.Manager;
using System;


namespace BankAccountSystem.Exceptions
{
    public class AccountNotFoundException:Exception
    {
        public AccountNotFoundException(string message) : base(message)  
        {

        }
    }
}
