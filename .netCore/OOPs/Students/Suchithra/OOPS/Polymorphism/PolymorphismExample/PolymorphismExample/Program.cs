using System;
using System.ComponentModel;
namespace PolymorphismExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
          Calculator calculator1 = new Calculator();
           Console.WriteLine("Sum is:{0}", calculator1.Add(2,7));

            Console.WriteLine("sum is:{0}", calculator1.Add(3,8,7));

            Console.WriteLine("sum is :{0}", calculator1.Add(406.5, 7.8));
        }
    }
}