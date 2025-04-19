using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example
{
    public class JobProvider:User
    {
        public string CompanyName { get; set; }

        // overriding Login()
        public override void Login()
        {
            Console.WriteLine(" JobProvider Login called !!!");
        }
    }
}
