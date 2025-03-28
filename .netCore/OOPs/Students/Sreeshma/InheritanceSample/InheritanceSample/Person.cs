﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    internal class Person
    {
        public string ? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";

        }

        public Person() 
        {
            FirstName = "Midhun";
            LastName = "Mohan";
            Age = 30;
        }

        public Person(string firstName, string lastName,int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age=age;
        }
    }
}
