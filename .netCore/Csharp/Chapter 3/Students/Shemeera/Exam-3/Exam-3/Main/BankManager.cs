using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_3.Interface;
using Exam_3.Modal;

namespace Exam_3.Main
{
    internal class BankManager:IBank
    {
      public List<BankAccount> accounts=new List<BankAccount>();
        decimal Balance = 0;
        public void AddNewAccount(BankAccount account)
        {
            accounts.Add(account);
            Console.WriteLine("Account added Sucessfully");
        }

        public void RemoveAccount(int accountno)
        {

            var accno=accounts.FirstOrDefault(a => a.AccountNumber==accountno);
            if (accno == null)
            {
                throw new Exception("Account not Found");

            }
            accounts.Remove(accno);

        }

        public void DisplayAllAccount()
        {
            foreach (var acc in accounts)

            {
                acc.DisplayInfo();
            }

        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {

                Balance += amount;
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount must be positive");
            }
            if (amount > Balance)
            {
                throw new InvalidOperationException("InSufficent Balance");


            }
            Balance -= amount;


        }


       





    }
}
