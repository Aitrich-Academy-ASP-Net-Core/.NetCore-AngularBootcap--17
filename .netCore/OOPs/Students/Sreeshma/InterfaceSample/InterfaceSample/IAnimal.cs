﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    internal interface IAnimal
    {
        void AnimalSound();
        void Eat()
        {
            Console.WriteLine("Animal is eating....");
        }
    }
}
