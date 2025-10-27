using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using Domain.Service.Authuser.Dto;
using Domain.Service.JobSeekerProfiles.Dtos;
using Domain.Service.JobSeekerProfiles.Interfaces;


namespace Domain.Service.JobSeekerProfiles
{
    public class JobSeekerProfileService : IJobSeekerProfileServices
    {
        private readonly IJobSeekerProfileRepository _repo;
        private readonly IMapper _mapper;

        public JobSeekerProfileService(IJobSeekerProfileRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // ---------------- PROFILE ----------------
        public async Task AddProfileForJobSeekerAsync(Guid jobSeekerId, string profileName, string profileSummary)
        {
            // ✅ Get the JobSeeker from JobSeeker repository
            var jobSeeker = await _repo.GetBySeekerIdAsync(jobSeekerId);
            if (jobSeeker == null)
            {
                throw new Exception("JobSeeker not found");
            }

            // ✅ Create JobSeekerProfile
            var profile = new JobSeekerProfile
            {
                Id = Guid.NewGuid(),
                JobSeekerId = jobSeeker.Id, // link to existing JobSeeker
                ProfileName = profileName,
                ProfileSummary = profileSummary
            };

            await _repo.AddProfileAsync(profile);
        }


        public async Task<List<JobSeekerProfile>> GetProfilesByJobSeekerAsync(Guid jobSeekerId)
        {
            return await _repo.GetProfilesByJobSeekerAsync(jobSeekerId);
        }

        public async Task<JobSeekerProfile?> UpdateJobSeekerProfileAsync(Guid jobSeekerId, Guid profileId, string profileName, string profileSummary)
        {
            // ✅ Get the profile by ID
            var profile = await _repo.GetProfileByIdAsync(profileId);

            if (profile == null || profile.JobSeekerId != jobSeekerId)
                return null; // Either profile not found or it does not belong to this JobSeeker

            // ✅ Update fields
            profile.ProfileName = profileName;
            profile.ProfileSummary = profileSummary;

            await _repo.UpdateProfileAsync(profile);

            return profile;
        }







        //=====Resume========
        public async Task UploadResumeAsync(Guid profileId, Guid jobSeekerId, string title, byte[] fileData)
        {
            if (fileData == null || fileData.Length == 0)
                throw new ArgumentException("Invalid file data.");

            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title is required.");

            await _repo.AddResumeAsync(profileId, jobSeekerId, title, fileData);
        }

        public async Task UpdateResumeAsync(Guid resumeId, string title)
        {
            await _repo.UpdateResumeAsync(resumeId, title);
        }

        public async Task<ResumeDTO?> GetResumeByIdAsync(Guid resumeId)
        {
            var resume = await _repo.GetResumeByIdAsync(resumeId);
            return resume == null ? null : _mapper.Map<ResumeDTO>(resume);
        }

        public async Task<List<ResumeDTO>> GetProfileResumesAsync(Guid profileId)
        {
            var resumes = await _repo.GetResumesByProfileIdAsync(profileId);
            return _mapper.Map<List<ResumeDTO>>(resumes);
        }

        public async Task DeleteResumeAsync(Guid resumeId)
        {
            await _repo.DeleteResumeAsync(resumeId);
        }
    }
}