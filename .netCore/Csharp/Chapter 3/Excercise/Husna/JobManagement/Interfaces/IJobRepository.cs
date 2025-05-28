using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManagement.Manager;
using JobManagement.Models;

namespace JobManagement.Interfaces
{
    public interface IJobRepository
    {
        void PostJob(Job job);
        List<Job> GetAllJobs();
        Job GetJobById(int id);
    }
}
