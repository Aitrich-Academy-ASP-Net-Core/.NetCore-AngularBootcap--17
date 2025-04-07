using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationSample
{
    internal class Person
    {
        private string? name;
        private int? age;
        public string? Name { get { return name; } set { if (!string.IsNullOrEmpty(value)) { name = value; } else { Console.WriteLine("Name can't be null"); } } }
            public int? Age { get { return age; } set { if (value >= 0) { age = value; } else { Console.WriteLine("Age should be greater than 0"); } } }

        public void PersonDetails()
        {
            Console.WriteLine("Name :{0} ",Name);
            Console.WriteLine("Age : {0}",Age);
        }
    }
}