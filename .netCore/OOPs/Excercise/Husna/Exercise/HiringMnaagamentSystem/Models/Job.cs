using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HiringMnaagamentSystem.Enum.ExperienceLevel;

namespace HiringMnaagamentSystem.Models
{
    internal class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ExperienceLevels ExperienceLevel { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string SalaryRange { get; set; }
        public string JobType { get; set; }

        public Job(int id, string title, ExperienceLevels experienceLevel, string company, string location, string salaryRange, string jobType)
        {
            Id = id;
            Title = title;
            ExperienceLevel = experienceLevel;
            Company = company;
            Location = location;
            SalaryRange = salaryRange;
            JobType = jobType;
        }
    }
}
