using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    internal class Calculator
    {
        public int Add(int a,int b) {
          return a + b;
        }

        public int Add(int x, int y, int z) { 
        return x + y + z;
        }

        public double Add(double x, double y)
        {
            return x + y;
        }
    }
}
