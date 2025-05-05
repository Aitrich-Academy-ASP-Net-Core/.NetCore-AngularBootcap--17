using BankAccountSystem.Exceptions;
using BankAccountSystem.Interface;
using BankAccountSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem.Manager
{
    public class Bank:IMenu
    {
        private List<BankAccount> accounts = new List<BankAccount>();


        public void AddAccount(BankAccount account)
        {
            accounts.Add(account);
        }

        public void RemoveAccount(int accountNumber)
        {
            var account1 = accounts.Find(a => a.AccountNumber == accountNumber);
            if (account1 == null)
            {

                throw new AccountNotFoundException("Account Not Found");
            }
            accounts.Remove(account1);
            

        }
        public void DisplayAccount()
        {
            foreach(var acc in accounts)
            {
                Console.WriteLine($"BALANCE-Rupees {acc.Balance}");
            }
        }
        public BankAccount GetAccount(int accountNumber)
        {
            return accounts.Find(a => a.AccountNumber == accountNumber);
        }


    }
}
