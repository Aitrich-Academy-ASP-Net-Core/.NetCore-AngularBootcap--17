using System;
namespace Abstraction
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.MakeSound();
            dog1.Eat();

            Cat cat1 = new Cat();
            cat1.MakeSound();
            cat1.Eat();

        }
    }
}