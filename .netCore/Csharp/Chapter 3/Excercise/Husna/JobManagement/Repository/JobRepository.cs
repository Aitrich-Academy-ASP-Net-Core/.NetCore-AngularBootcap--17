using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManagement.Interfaces;
using JobManagement.Models;
using JobManagement.Exceptions;



namespace JobManagement.Repository
{
    public class JobRepository
    {
        private List<Job> jobs = new List<Job>();
        private int nextId = 1;

        public void PostJob(Job job)
        {
            jobs.Add(job);
        }

        public List<Job> GetJobs()
        {
            return jobs;
        }

        public int GenerateJobId()
        {
            return nextId++;
        }
        public List<Job> GetAllJobs()
        {
            return jobs;
        }

        public Job GetJobById(int id)
        {
            var job = jobs.FirstOrDefault(j => j.JobId == id);
            if (job == null)
                throw new JobNotFoundException($"Job with ID {id} was not found.");
            return job;
        }
    }

}

