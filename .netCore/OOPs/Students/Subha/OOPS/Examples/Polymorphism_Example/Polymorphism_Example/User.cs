using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example
{
    public class User
    {

        public virtual void Login()
        {
            Console.WriteLine("User Login called !!!");
        }

        public void Login(string username)
        {
            Console.WriteLine("logged successfully !!! \n Welcome "+ username);
        }
    }
}
