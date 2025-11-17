

using Domain.Helpers;
using Domain.Models;
using Domain.Service.Job.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Job.Interfaces
{
	public interface IJobRepository
	{

       
		Task<List<JobPost>> GetJobs();
		Task<List<JobPost>> GetJobsByCompany(Guid companyId);

        Task<List<JobPost>> GetJobsById(Guid companyId, Guid jobId);


        Task<SavedJob> saveJob(SavedJob savedJob);
        Task<List<SavedJob>> GetSavedJobsBySeekerId(Guid jobseekerId);
        SavedJob RemoveSavedJob(Guid seekerId, Guid jobid);
        bool SavedJobs(JobPostsDtos job, Guid userId);



        bool applyjob(JobApplication applyjob);

        Task<List<JobApplication>> GetAllAppliedJobs(Guid jobSeekerId);



        bool CancelAppliedJob(Guid jobseekerId, Guid JobApplicationId);
		
       

       
		
    }

}
