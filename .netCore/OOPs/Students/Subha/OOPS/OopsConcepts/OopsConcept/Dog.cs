using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Dog:Animal
    {
        public string breed;
        
        public void displayDog(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine( "Breed is {0}", breed);
        }
        

    }
}
