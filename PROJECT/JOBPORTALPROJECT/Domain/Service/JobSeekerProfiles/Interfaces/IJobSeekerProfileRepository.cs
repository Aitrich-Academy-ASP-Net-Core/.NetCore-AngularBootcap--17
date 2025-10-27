using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Service.JobSeekerProfiles.Interfaces
{
    public interface IJobSeekerProfileRepository
    {
        Task AddProfileAsync(JobSeekerProfile profile);
        Task<JobSeeker?> GetBySeekerIdAsync(Guid id);

        Task<List<JobSeekerProfile>> GetProfilesByJobSeekerAsync(Guid jobSeekerId);
        Task<JobSeekerProfile?> GetProfileByIdAsync(Guid profileId);
        Task UpdateProfileAsync(JobSeekerProfile profile);


        // ---------------- RESUME ----------------
        Task AddResumeAsync(Guid profileId, Guid jobSeekerId, string title, byte[] fileData);
        Task UpdateResumeAsync(Guid resumeId, string title);
        Task<Resume?> GetResumeByIdAsync(Guid resumeId);
        Task<List<Resume>> GetResumesByProfileIdAsync(Guid profileId);
        Task DeleteResumeAsync(Guid resumeId);



    }
}



