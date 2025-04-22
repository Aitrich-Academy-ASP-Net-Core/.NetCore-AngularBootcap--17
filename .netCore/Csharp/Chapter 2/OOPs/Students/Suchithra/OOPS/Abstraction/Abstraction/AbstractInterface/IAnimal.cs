using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
    internal interface IAnimal
    {
        void MakeSound();
        void Eat()
        {
            Console.WriteLine("Animals Eating... ");
        }

    }
}
