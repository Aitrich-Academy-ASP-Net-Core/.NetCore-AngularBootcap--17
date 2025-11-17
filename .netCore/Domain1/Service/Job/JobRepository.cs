
using AutoMapper;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.Job.DTOs;
using Domain.Service.Job.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Domain.Service.Job
{
    public class JobRepository : IJobRepository
    {

        DbHireMeNowWebApiContext _context;
        IMapper _mapper;
        
        static List<JobPost> jobs;

        public JobRepository(DbHireMeNowWebApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        public async Task<List<JobPost>> GetJobs()
        {

            var jobs = await _context.JobPosts
        .Include(e => e.Location)
        .Include(e => e.Industry)
        .Include(e => e.Company)
        .Include(e => e.JobCategory)
        .ToListAsync();

            return jobs;
        }



        public async Task<List<JobPost>> GetJobsByCompany(Guid companyId)
        {

            return await _context.JobPosts.Where(e => e.CompanyId == companyId).ToListAsync();
        }


        public async Task<List<JobPost>> GetJobsById(Guid companyId, Guid jobId)
        {
            return await _context.JobPosts.Where(e => e.CompanyId == companyId && e.Id == jobId).ToListAsync();
        }









        public async Task<SavedJob> saveJob(SavedJob savedJob)
        {
            await _context.SavedJobs.AddAsync(savedJob);
            await _context.SaveChangesAsync();
            return savedJob;
        }


        public async Task<List<SavedJob>> GetSavedJobsBySeekerId(Guid jobseekerId)
        {
            return await _context.SavedJobs
                .Where(e => e.SavedBy == jobseekerId)
                .Include(e => e.JobPost) // include job post details
                .Include(e => e.JobPost.Company) // optional, include company details
                .OrderByDescending(e => e.DateSaved)
                .ToListAsync();
        }



        public SavedJob RemoveSavedJob(Guid seekerId, Guid jobid)
        {
            var savedJob = _context.SavedJobs
         .FirstOrDefault(e => e.SavedBy == seekerId && e.Id == jobid);

            if (savedJob == null)
            {
                return null; // No match found — nothing to remove
            }

            _context.SavedJobs.Remove(savedJob);
            _context.SaveChanges();
            return savedJob;
        }



        public bool SavedJobs(JobPostsDtos job, Guid userId)
        {
            // Assuming JobPostsDtos has an Id property
            bool isJobSaved = _context.SavedJobs.Any(e => e.Job == job.Id && e.SavedBy == userId);
            return isJobSaved;
        }


       



       



       
        public bool applyjob(JobApplication applyjob)
        {
            applyjob.status = Enum.Status.Pending;
            _context.JobApplications.Add(applyjob);
            _context.SaveChanges();
            return true;

        }



        public async Task<List<JobApplication>> GetAllAppliedJobs(Guid jobSeekerId)
        {
            return await _context.JobApplications
                .Where(e => e.Applicant == jobSeekerId)
                .Include(e => e.JobPost)
                .Include(e => e.JobPost.Company)
                .ToListAsync();
        }




        public bool CancelAppliedJob(Guid jobseekerId, Guid JobApplicationId)
        {
            try
            {
                var AppliedJob = _context.JobApplications.Where(e => e.Id == JobApplicationId).FirstOrDefault();
                if (AppliedJob != null)
                {
                    _context.JobApplications.Remove(AppliedJob);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }



        
       
       

    }

}

