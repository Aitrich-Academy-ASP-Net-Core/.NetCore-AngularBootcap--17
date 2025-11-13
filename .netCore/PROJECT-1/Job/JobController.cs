using AutoMapper;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.Job.DTOs;
using Domain.Service.Job.Interfaces;
using Domain.Service.User.Interface;
using JobPortalApp.API;
using JobPortalApp.API.JobSeekerr.RequestObjects;
using JobPortalApp.API.Job.SavedJobObjects;
using JobPortalApp.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalApp.Job
{

    [ApiController]
    [Route("api/job-seekerr")] // base route
    [Authorize(Roles = "JOB_SEEKER")]
    public class JobController : BaseApiController<JobController>   C]
    {
        private readonly IJobServices _jobService;
        private readonly IMapper _mapper;
        IJobRepository _jobRepository;
        IUserService _userService;

        private IMapper mapper;


        public JobController(IMapper mapper, IJobServices jobService, IJobRepository jobRepostory, IUserService userService)
        {
            _mapper = mapper;
            _jobService = jobService;
            _jobRepository = jobRepostory;
            _userService = userService;


        }





        
        [HttpGet]
        [Route("jobs")]
      
        public async Task<IActionResult> GetJobs()
        {
            var jobposts = await _jobService.GetJobs();
            return Ok(jobposts);
        }







        [HttpGet]
        [Route("jobs/{companyId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetJobsByCompany(Guid companyId)
        {
            try
            {
                List<JobPost> jobposts = await _jobService.GetJobsByCompany(companyId);
                return Ok(_mapper.Map<List<JobPostsDtos>>(jobposts));
            }
            catch (Exception )
            {
                return BadRequest();
            }
        }








        [HttpGet]
        [Route("company/{companyId}/jobs/{jobId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetJobsById(Guid companyId, Guid jobId)
        {
            try
            {
                List<JobPost> jobposts = await _jobService.GetJobsById(companyId, jobId);
                return Ok(_mapper.Map<List<JobPostsDtos>>(jobposts));
            }
            catch (Exception )
            {
                return BadRequest();
            }
        }






        [Authorize]
        [HttpPost]
        [Route("job-seeker/SaveJob/{JobId}")]
        public async Task<IActionResult> SaveJob(Guid JobId)
        {
            SaveJobRequest saveJobRequest = new SaveJobRequest();
            var UserId = new Guid(_userService.GetUserId());
            saveJobRequest.SavedBy = UserId;
            saveJobRequest.Job = JobId;

            var savedjob = _mapper.Map<SavedJob>(saveJobRequest);
            var savedJob = await _jobService.saveJob(savedjob);
            if (savedJob != null)
            {
                return Ok("JobsSaved Succesfully");
            }
            else
            {
                return BadRequest();
            }
        }






        [HttpGet]
        [Route("job-seeker/{jobseekerId}/savedjobs")]
        public async Task<IActionResult> GetSavedJobsBySeekerId(Guid jobseekerId)
        {
            var savedJobs = await _jobService.GetSavedJobsBySeekerId(jobseekerId);

            if (savedJobs == null || !savedJobs.Any())
                return NotFound("No saved jobs found for this job seeker.");

            return Ok(savedJobs);
        }




        [Authorize]
        [HttpPost]
        [Route("job-seeker/job-application/{JobId}")]
        public async Task<IActionResult> applyJob(Guid JobId, Guid ResumeId, string CoverLetter)
        {
            ApplyJobRequest applyJobRequest = new ApplyJobRequest();
            var UserId = _userService.GetUserId();
            applyJobRequest.Applicant = new Guid(UserId);
            applyJobRequest.CoverLetter = CoverLetter;
            applyJobRequest.Resume_id = ResumeId;
            applyJobRequest.JobPost_id = JobId;
            var appliedJobs = _mapper.Map<JobApplication>(applyJobRequest);
            var status = _jobService.ApplyJob(appliedJobs);
            if (status == true)
            {
                return Ok(new { Message = "JobsApplied Succesfully" });

            }
            else
            {
                return BadRequest();
            }
        }





      
        [HttpGet]
        [Route("job-seeker/{jobSeekerId}/appliedjobs")]
        public async Task<IActionResult> GetAllAppliedJobs(Guid jobSeekerId)
        {
            var appliedJobs = await _jobService.GetAllAppliedJobs(jobSeekerId);

            if (appliedJobs == null || !appliedJobs.Any())
            {
                return NotFound("No applied jobs found for this job seeker.");
            }

            return Ok(appliedJobs);
        }







        [Authorize]
        [HttpDelete]
        [Route("job-seeker/{jobseekerId}/job-application/{JobApplicationId}/cancel")]
        public async Task<ActionResult> CancelAppliedJob(Guid jobseekerId, Guid JobApplicationId)
        {
            var UserId = new Guid(_userService.GetUserId());
            var status = _jobService.CancelAppliedJob(UserId, JobApplicationId);
            if (status == true)
            {
                return Ok(new { Message = "deleted" });

            }
            else
            {
                return NotFound();
            }
        }



    }
}
