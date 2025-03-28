using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismMethodoveriding
{
    internal class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal making sound....");
        }
    }
}
