using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class JobSeeker : ILogin, IRegister
    {
        public void Login()
        {
            Console.WriteLine("Jobseeker Logged In");
        }

        public void Register()
        {
            Console.WriteLine("Jobseeker Registered successfully");
        }
    }
}
