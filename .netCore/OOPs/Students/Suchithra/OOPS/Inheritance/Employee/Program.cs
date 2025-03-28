using Employee;
using System;
namespace Inheritance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.WriteLine($"Full Name is:{person1.GetName()}");
           

            Person person2 = new Person();
            Console.WriteLine($"FullName :{person1.GetName()},Age:{person1.Age}");

            Person person3 = new Person();
            Console.WriteLine("Full Name:{0}\t\t Age :{1}\t\t",person3.GetName(),person3.Age);

            Employ employee1=new Employ(3,"Arvin","Krish",25,"Senior Developer");
            Console.WriteLine("Emlployee Details:{0}",employee1.GetEmployee() );
           

            Employ employee2 = new Employ(001, "Aneesh", "Krishnan", 38, "Developer");
            Console.WriteLine($"Employee Detail:{ employee2.GetEmployee()}");

            Employ employee3 = new Employ();
            Console.WriteLine("Employee details:{0}",employee3.GetEmployee());






        }
    }
}
