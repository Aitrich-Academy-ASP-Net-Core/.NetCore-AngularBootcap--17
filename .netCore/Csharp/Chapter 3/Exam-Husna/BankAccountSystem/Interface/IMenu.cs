using BankAccountSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem.Interface
{
    public interface IMenu
    {
        void AddAccount(BankAccount account);
        void RemoveAccount(int accountNumber);
        void DisplayAccount();
        public BankAccount GetAccount(int AccountNumber);
       
    }
}
