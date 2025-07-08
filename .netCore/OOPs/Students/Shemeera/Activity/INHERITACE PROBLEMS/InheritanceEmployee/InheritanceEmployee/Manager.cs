using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEmployee
{
    internal class Manager:Employee
    {
        public int Bonus;

        public Manager(string name ,int salary , int bonus):base (name ,salary)
        {
            this.Bonus = bonus; 
        }
        public void Display()
        {
            Console.WriteLine($"Employee Name is {Name}  \n Salary is  {Salary} \n Bonus is {Bonus}"); 
        }

        int total = 0;
        public void TotalSalary()
        {

          total = Salary+Bonus;
            Console.WriteLine("Total salary ="+total);  
        }


    }
}
