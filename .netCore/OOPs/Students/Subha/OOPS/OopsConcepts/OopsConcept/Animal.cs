using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Animal
    {
         public string name;
        
        public void displayAnimal(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("{0} is barking",name);
        }

    }
}
