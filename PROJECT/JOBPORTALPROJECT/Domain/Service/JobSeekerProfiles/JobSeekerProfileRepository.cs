using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.JobSeekerProfiles.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Domain.Service.JobSeekerProfiles
{






    public class JobSeekerProfileRepository : IJobSeekerProfileRepository
    {
        private readonly AppDbContext _context;

        public JobSeekerProfileRepository(AppDbContext context)
        {
            _context = context;
        }

        // ---------------- PROFILE ----------------
        public async Task AddProfileAsync(JobSeekerProfile profile)
        {
            _context.JobSeekerProfiles.Add(profile);
            await _context.SaveChangesAsync();
        }

        public async Task<List<JobSeekerProfile>> GetProfilesByJobSeekerAsync(Guid jobSeekerId)
        {
            return await _context.JobSeekerProfiles
                .Where(p => p.JobSeekerId == jobSeekerId)
                .ToListAsync();
        }

        public async Task<JobSeekerProfile?> GetProfileByIdAsync(Guid profileId)
        {
            return await _context.JobSeekerProfiles
                .FirstOrDefaultAsync(p => p.Id == profileId);
        }

        public async Task UpdateProfileAsync(JobSeekerProfile profile)
        {
            _context.JobSeekerProfiles.Update(profile);
            await _context.SaveChangesAsync();
        }

        //public async Task DeleteAsync(Guid profileId)
        //{
        //    var profile = await GetProfileByIdAsync(profileId);
        //    if (profile == null) throw new Exception("Profile not found");
        //    _context.JobSeekerProfiles.Remove(profile);
        //    await _context.SaveChangesAsync();
        //}

        public async Task<JobSeeker?> GetByIdAsync(Guid jobSeekerId)
        {
            return await _context.JobSeekers.FindAsync(jobSeekerId);
        }

        // ---------------- RESUME ----------------
        public async Task AddResumeAsync(Guid profileId, Guid jobSeekerId, string title, byte[] fileData)
        {
            var resume = new Resume
            {
                Id = Guid.NewGuid(),
                Title = title,
                UploadedOn = DateTime.UtcNow,
                ProfileId = profileId,
                JobSeekerId = jobSeekerId,
                FileData = fileData
            };

            _context.Resumes.Add(resume);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateResumeAsync(Guid resumeId, string title)
        {
            var resume = await _context.Resumes.FindAsync(resumeId);
            if (resume == null) throw new Exception("Resume not found");

            resume.Title = title;
            resume.UploadedOn = DateTime.UtcNow;
            await _context.SaveChangesAsync();
        }

        public async Task<Resume?> GetResumeByIdAsync(Guid resumeId)
        {
            return await _context.Resumes.FindAsync(resumeId);
        }

        public async Task<List<Resume>> GetResumesByProfileIdAsync(Guid profileId)
        {
            return await _context.Resumes
                .Where(r => r.ProfileId == profileId)
                .ToListAsync();
        }

        public async Task DeleteResumeAsync(Guid resumeId)
        {
            var resume = await _context.Resumes.FindAsync(resumeId);
            if (resume == null) throw new Exception("Resume not found");

            _context.Resumes.Remove(resume);
            await _context.SaveChangesAsync();
        }

        public async Task<JobSeeker?> GetBySeekerIdAsync(Guid id)
        {
            return await _context.JobSeekers.FindAsync(id);
        }







    }





}
