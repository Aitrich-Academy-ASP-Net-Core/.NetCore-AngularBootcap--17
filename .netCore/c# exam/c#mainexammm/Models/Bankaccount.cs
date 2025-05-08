using c_mainexammm.methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_mainexammm.Models
{   public enum AccountType
    {
        Savings,
        Current
    } 
    public class Bankaccount
    {
        public int Acno { get; set; }
        public string AcHolderName { get; set; }
        public double Balance { get; set; }
        public AccountType AcType { get; set; }

        public Bankaccount(int acno, string acHolderName, double balance, AccountType acType)
        {
            Acno = acno;
            AcHolderName = acHolderName;
            Balance = balance;
            AcType = acType;
        }
       
            public void Deposit(double Amount)
        {
            //Console.WriteLine("Enter Account Type:(savings/current)");
            //AcType = Console.ReadLine();
            //List<Bankaccount> Bac = new List<Bankaccount>();
            if (Amount < 1)
            {
                Console.WriteLine("the amount cannot be less than One");
            }
            else
            {
                Balance = Balance + Amount;
                Console.WriteLine("Depositted Amount: " + Amount);
                Console.WriteLine("Current Balance: " + Balance);
            }
        }
        
        public void Withdraw( double Amount)
        {
            if (Amount < 1)
            {
                Console.WriteLine("the amount cannot be less than One");
            }
            if (Amount > Balance)
            {
                Console.WriteLine("the amount cannot be greater than that of balance");
            }
            else
            {
                Balance = Balance - Amount;
                Console.WriteLine("Withdrawn Amount: " + Amount);
                Console.WriteLine("Current Balance: " + Balance);
            }
        }
    }
}
