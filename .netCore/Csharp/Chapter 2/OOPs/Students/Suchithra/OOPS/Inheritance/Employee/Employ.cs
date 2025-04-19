using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employ: Person
    {
        public int Id { get; set; }
        
        public string Position { get; set; }

        public Employ(): base()
        {

            Id = 002;
          
            Position = "Software Engineer";

        }

        public Employ(int id, string firstName, string lastName, int age, string position) : base(firstName,lastName,age) 
        {
            Id = id;
            Position = position;
        }
        public string GetEmployee()
        {
            return $"{Id},{Position},{FirstName},{LastName},{Age}";
        }
    }
}
