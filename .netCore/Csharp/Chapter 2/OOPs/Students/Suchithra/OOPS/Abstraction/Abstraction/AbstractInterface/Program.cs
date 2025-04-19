using AbstractInterface;
using System;
namespace InterfacExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.MakeSound();

            Cat cat1 = new Cat();
            cat1.MakeSound();
        }

    }
}