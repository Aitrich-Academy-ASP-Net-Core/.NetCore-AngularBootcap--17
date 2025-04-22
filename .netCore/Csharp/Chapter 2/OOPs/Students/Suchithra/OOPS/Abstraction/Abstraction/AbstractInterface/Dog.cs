using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
    internal class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Dog is Barking....");
        }
    }
}
