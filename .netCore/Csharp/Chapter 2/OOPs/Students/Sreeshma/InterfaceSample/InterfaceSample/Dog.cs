using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    internal class Dog : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Dog is Barking...");
        }
    }
}
