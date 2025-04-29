using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    internal class Dog:Animal
    {
        public override void MakeSound()
        {

            Console.WriteLine("dog is barking");

        }


    }
}
