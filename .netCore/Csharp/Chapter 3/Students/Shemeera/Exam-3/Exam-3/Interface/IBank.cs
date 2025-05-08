using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_3.Modal;

namespace Exam_3.Interface
{
    internal interface IBank
    {
        void AddNewAccount(BankAccount account);

        void RemoveAccount(int accountno);
        void DisplayAllAccount();

        void Deposit(decimal amount);
        void Withdraw(decimal amount);

       

    }
}
