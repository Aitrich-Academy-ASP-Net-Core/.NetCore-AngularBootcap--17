using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_3.Enum;

namespace Exam_3.Modal
{
    internal class BankAccount
    {
        private int accno;
        private string? name;
        private int type;

        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }

        public decimal Balance { get; set; }  

        public AccountType Type { get; set; }

        public BankAccount()
        {
           
        }
        public BankAccount(int accountNumber, string accountHolderName, decimal balance, AccountType type)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
            Type = type;
        }

        public BankAccount(int accno, string? name, int type, decimal balance)
        {
            this.accno = accno;
            this.name = name;
            this.type = type;
            Balance = balance;
        }

        //decimal Balance = 0;


        public void DisplayInfo()
        {
            Console.WriteLine($"Account Number : {AccountNumber} , AccountHolderName: {AccountHolderName}  ,AccountType:  {Type}  ,Balance is {Balance}");
        }












    }
}
