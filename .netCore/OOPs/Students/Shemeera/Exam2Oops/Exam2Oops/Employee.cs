using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exam2Oops
{
    internal class Employee
    {

        private string name;
        private string jobPosition;
        private double salary;
        public string AuthorisedPerson;


        public string Name
        {

            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot Empty");


                }

            }


        }

        public string JobPosition
        { get { return jobPosition; } set { jobPosition = value; } }
        public double Salary
        {
            get { return salary; }

            set
            {

                salary = value;
            }
        }

        public Employee(string name, string jobPosition, double salary)
        {
            Name = name;
            JobPosition = jobPosition;
            Salary = salary;

        }

        public void SalaryIncrease(double percentage)
        {
            double percentage1 = (salary * percentage) / 100;
            Console.WriteLine("Your Percentage is " + percentage + "%");

            if (percentage > 20)
            {
                Console.WriteLine("percentage increase shouldnot exceed 20%");
            }
            else
            {
                Console.WriteLine("Your salary incresing to be Validated ");
                Console.WriteLine("Your salary percentage is " + percentage1);

                Console.WriteLine("Your old salary is " + salary);
                Console.WriteLine("Your New Salary is " + (salary + percentage1));
            }



        }

        public void Display()
        {

            Console.WriteLine("EMPLOYEE DATA MANAGEMENT");
            Console.WriteLine("**************************");
            Console.WriteLine();

            Console.WriteLine("Employee Name is  :" + name);
            Console.WriteLine("Employee Job Position is :" + jobPosition);
            Console.WriteLine("Employee Salary is :" + salary);
        }

        public void SalaryaValidation()
        {

            string AuthorisedPerson = "Admin";

            Console.WriteLine("Enter the Position of the Authorised Person");
            string Person = Console.ReadLine();
            if (Person != AuthorisedPerson)
            {
                Console.WriteLine("Your salary is validate only Authorisedpaerson");


            }
            else if (Person == AuthorisedPerson)
            {
                Console.WriteLine("Your salary is validate By Authorised Person");

                Console.WriteLine("EMPLOYEE DATA MANAGEMENT");
                Console.WriteLine("**************************");
                Console.WriteLine();

                Console.WriteLine("Employee Name is  :" + name);
                Console.WriteLine("Employee Job Position is :" + jobPosition);
                Console.WriteLine("Employee Salary is :" + salary);


                //            void SalaryIncrease()
                //    {


                //        Console.WriteLine("Enter the percentage for increasing salary");
                //        double percentage = Convert.ToDouble(Console.ReadLine());


                //        double percentage1 = (salary * percentage) / 100;
                //        Console.WriteLine("Your Percentage is " + percentage + "%");

                //        if (percentage > 20)
                //        {
                //            Console.WriteLine("percentage increase shouldnot exceed 20%");
                //        }
                //        else
                //        {
                //            Console.WriteLine("Your salary incresing to be Validated ");
                //            Console.WriteLine("Your salary percentage is " + percentage1);

                //            Console.WriteLine("Your old salary is " + salary);
                //            Console.WriteLine("Your New Salary is " + (salary + percentage1));
                //        }
                //    }

                //}


            }
        }
    }

}
    



    



       

    

