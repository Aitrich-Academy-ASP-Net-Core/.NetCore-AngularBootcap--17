

﻿using Domain.Helpers;
using Domain.Models;
using Domain.Service.Job.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Job.Interfaces
{
    public interface IJobServices
	{

      
		public Task<List<JobPostsDtos>> GetJobs();
		public Task<List<JobPost>> GetJobsByCompany(Guid companyId);

        public Task<List<JobPost>> GetJobsById(Guid companyId, Guid jobId);



        Task<SavedJob> saveJob(SavedJob savedJob);
        Task<List<SavedJobsDtos>> GetSavedJobsBySeekerId(Guid jobseekerId);
        SavedJob RemoveSavedJob(Guid seekerId, Guid jobid);

        Task<List<AppliedJobsDtos>> GetAllAppliedJobs(Guid jobSeekerId);
        bool ApplyJob(JobApplication applyJob);
        bool CancelAppliedJob(Guid jobseekerId, Guid JobApplicationId);
       


       
		
       




    }

}
