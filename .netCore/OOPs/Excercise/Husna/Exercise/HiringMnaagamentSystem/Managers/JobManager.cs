using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiringMnaagamentSystem.Models;
using HiringMnaagamentSystem.Utils;
using static HiringMnaagamentSystem.Enum.ExperienceLevel;

namespace HiringMnaagamentSystem.Managers
{
    internal class JobManager
    {
        public Job[] jobs =
      {
        new Job(1, "Software Engineer", ExperienceLevels.MidLevel, "Google", "California", "$80,000 - $120,000", "Full-time"),
        new Job(2, "Data Analyst", ExperienceLevels.Senior, "Microsoft", "New York", "$60,000 - $90,000", "Full-time"),
       new Job(4, "Network Engineer", ExperienceLevels.Senior, "Cisco", "San Francisco", "$90,000 - $130,000", "Full-time"),
       new Job(5, "Cybersecurity Analyst", ExperienceLevels.MidLevel, "IBM", "Washington, D.C.", "$85,000 - $120,000", "Full-time"),
        new Job(6, "AI Researcher", ExperienceLevels.Senior, "OpenAI", "Remote", "$120,000 - $200,000", "Full-time")

        };




        Printer printer = new Printer();
        public void DisplayJobs()
        {


            printer.Print(jobs);

        }


    }
}
