using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation1
{
    internal class Person
    {
        private string? name;
        private int age;
        public string Name { get { return name; } set { if (!string.IsNullOrEmpty(value)) { name = value; } 
                else { Console.WriteLine("Name can't be empty");
                } }  }

        public int Age {
            get { return age; } 
            
            set
            {
                if (value >= 0) { age = value; }
                else { Console.WriteLine("Age must be greater than zero"); }
            }
                   
        }

        public void Display()
        {
            Console.WriteLine("Name is:{0}",Name);
              Console.WriteLine(" Age is {0} :",Age);
        }
    }
}
