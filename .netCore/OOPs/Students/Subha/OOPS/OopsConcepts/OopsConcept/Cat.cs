using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Cat : Animal
    {
        public string name;
        public void displayCat(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("{0} is Mewing", name);
        }
    }
}
