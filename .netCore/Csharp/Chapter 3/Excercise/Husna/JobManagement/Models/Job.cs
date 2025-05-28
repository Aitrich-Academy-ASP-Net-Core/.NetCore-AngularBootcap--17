using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagement.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string JobType { get; set; }
        public string Salary { get; set; }
        public string Company { get; set; }

        public Job(int id, string title, string description, string location, string jobType, string salary, string company)
        {
            JobId = id;
            Title = title;
            Description = description;
            Location = location;
            JobType = jobType;
            Salary = salary;
            Company = company;
        }
    }
}
