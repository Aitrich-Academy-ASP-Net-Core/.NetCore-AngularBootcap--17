using c_mainexammm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_mainexammm.Interfaces
{
    public class Ibank :Bankaccount
    {
        private List<Bankaccount> bankaccounts = new List<Bankaccount>();

        public Ibank(int acno, string acHolderName, double balance, AccountType acType) : base(acno, acHolderName, balance, acType)
        {
        }

        

        public void AddAccount(Bankaccount account)
        {
            Console.WriteLine("enter account number: ");
            Acno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter account holder name: ");
            AcHolderName = Convert.ToString(Console.ReadLine());

            bankaccounts.Add(account);
            Console.WriteLine($"account ADDED successfully");
        }
        public void RemoveAccount(Bankaccount account)
        {
            Console.WriteLine("enter account number: ");
            Acno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter account holder name: ");
            AcHolderName = Convert.ToString(Console.ReadLine());
            bankaccounts.Remove(account);
            Console.WriteLine($"account REMOVED ");
        }
        public void DisplayAccount()
        {
            if (bankaccounts.Count == 0)
            {
                Console.WriteLine("no accounts found");

            }
            else
            {
                foreach (var a in bankaccounts)
                {
                    Console.WriteLine($"account number: {a.Acno}" +
                        $"account holder:{a.AcHolderName}" +
                        $"current balance:{a.Balance}");
                }
            }
        }

        internal void AddAccount()
        {
            throw new NotImplementedException();
        }

        internal void RemoveAccount()
        {
            throw new NotImplementedException();
        }
    }
}
