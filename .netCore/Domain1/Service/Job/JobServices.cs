
using Domain.Models;
using Domain.Service.Job.Interfaces;
using AutoMapper;
using Domain.Helpers;
using Domain.Service.Job.DTOs;
using Domain.Service.Login.DTOs;
using Domain.Service.SignUp.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SendGrid.Helpers.Mail;

namespace Domain.Service.Job
{
    public class JobServices : IJobServices
    {
        private IJobRepository _jobrepository;
        private IMapper _mapper;

        public JobServices(IJobRepository jobrepository, IMapper mapper)
        {
            _jobrepository = jobrepository;
            _mapper = mapper;
        }
       

        



		public async Task<List<JobPostsDtos>> GetJobs()
		{
     
            var jobs = await _jobrepository.GetJobs();
            var dtoList = _mapper.Map<List<JobPostsDtos>>(jobs);
            return dtoList;


        }




		public async Task<List<JobPost>> GetJobsByCompany(Guid companyId)
        {
            return await _jobrepository.GetJobsByCompany(companyId);
        }





        public async Task<List<JobPost>> GetJobsById(Guid companyId, Guid jobId)
        {
            return await _jobrepository.GetJobsById(companyId,jobId);
        }


        public async Task<SavedJob> saveJob(SavedJob savedJob)
        {
            return await _jobrepository.saveJob(savedJob);
        }


        public async Task<List<SavedJobsDtos>> GetSavedJobsBySeekerId(Guid jobseekerId)
        {
            var savedJobs = await _jobrepository.GetSavedJobsBySeekerId(jobseekerId);
            var savedJobsDto = _mapper.Map<List<SavedJobsDtos>>(savedJobs);
            return savedJobsDto;
        }



        public SavedJob RemoveSavedJob(Guid seekerId, Guid jobid)
        {

            return _jobrepository.RemoveSavedJob(seekerId, jobid);
        }




        public bool ApplyJob(JobApplication applyJob)

        {

            return _jobrepository.applyjob(applyJob);
        }




        public async Task<List<AppliedJobsDtos>> GetAllAppliedJobs(Guid jobSeekerId)
        {
            var appliedJobs = await _jobrepository.GetAllAppliedJobs(jobSeekerId);
            var appliedJobsDtos = _mapper.Map<List<AppliedJobsDtos>>(appliedJobs);
            return appliedJobsDtos;
        }


        public bool CancelAppliedJob(Guid jobseekerId, Guid JobApplicationId)
        {
            return _jobrepository.CancelAppliedJob(jobseekerId, JobApplicationId);
        }

    }

}
