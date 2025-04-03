using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Job.Model
{
    internal class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Salary { get; set; }
        public string Location {  get; set; }
        public Job(int id,string title,string description,string salary,string location)
        {
            Id = id;
            Title = title;
            Description = description;
            Salary = salary;
            Location = location;
        }
    }
}
