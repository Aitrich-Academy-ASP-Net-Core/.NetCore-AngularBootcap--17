using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Interfaces
{
    interface IInventoryManager
    {
      void IsBookAvailable(string Tittle);
        void ViewInventory();
    }
}
