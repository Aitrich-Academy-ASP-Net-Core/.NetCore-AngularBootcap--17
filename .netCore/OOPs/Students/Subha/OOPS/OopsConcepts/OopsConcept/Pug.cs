using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Pug:Dog
    {
        public string color;
        public void displayPug(string message)
        {
           Console.WriteLine(message);
            Console.WriteLine("Color is {0}",color);
        }

    }
}
