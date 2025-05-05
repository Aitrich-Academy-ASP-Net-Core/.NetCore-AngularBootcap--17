using Library_managementneha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_managementneha.Interfaces
{
   public interface ILibraryprocess
    {
        public void DisplayAdd(Book book);
        public void DisplayRemove(string isbn);
        public void DisplayBorrow(string isbn);
        public void DisplayBook();



    }
}
