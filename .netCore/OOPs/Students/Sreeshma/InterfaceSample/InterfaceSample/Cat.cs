﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    internal class Cat : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Cat is Making sound Meow.....");
        }
    }
}
