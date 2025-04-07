using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Interfaces
{
    interface IBorrowing
    {
       void BorrowBook();
        void ReturnBook();
        void ViewBorrowingHistory();
    }
}
