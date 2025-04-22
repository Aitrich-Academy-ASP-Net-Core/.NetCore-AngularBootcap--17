using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example
{
    public class JobSeeker:User
    {
        public string Qualification { get; set; }

        // overriding Login()
        public override void Login()
        {
            Console.WriteLine(" JobSeeker Login called !!!");
        }
    }
}
