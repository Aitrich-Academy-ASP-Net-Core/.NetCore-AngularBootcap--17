using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountSystem.Interface;
using BankAccountSystem.Manager;

namespace BankAccountSystem.Models
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; }

        public BankAccount(int accountNumber, string accountHolderName, decimal balance, string accountType)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
            AccountType = accountType;
        }
        public void Deposit(decimal amount)
        {
            Balance = Balance + amount;
        }
        public void Withdraw(decimal amount)
        {
            Balance = Balance - amount;
        }
    }
}
