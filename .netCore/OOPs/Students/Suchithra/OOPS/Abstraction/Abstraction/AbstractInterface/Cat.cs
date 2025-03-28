using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
    internal class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("cat is mwahwooo...");
        }
    }
}
