using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person()
        {
            FirstName = "Aishani";
            LastName = "Nanda";
            Age = 23;
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void GetName() {
            Console.WriteLine(" Full Name is:{0} {1}",FirstName,LastName);
        }
    }
   
        

}
