using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class JobProvider : ILogin
    {
        public void Login()
        {
            Console.WriteLine("JobProvider Logged In");
        }
    }
}
