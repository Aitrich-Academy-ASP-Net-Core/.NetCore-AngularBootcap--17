using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.JobSeekerProfiles.Dtos;

namespace Domain.Service.JobSeekerProfiles.Interfaces
{
    public interface IJobSeekerProfileServices
    {
        Task AddProfileForJobSeekerAsync(Guid jobSeekerId, string profileName, string profileSummary);
        Task<List<JobSeekerProfile>> GetProfilesByJobSeekerAsync(Guid jobSeekerId);
        Task<JobSeekerProfile?> UpdateJobSeekerProfileAsync(Guid jobSeekerId, Guid profileId, string profileName, string profileSummary);


        // ---------------- RESUME ----------------
        Task UploadResumeAsync(Guid profileId, Guid jobSeekerId, string title, byte[] fileData);
        Task UpdateResumeAsync(Guid resumeId, string title);
        Task<ResumeDTO?> GetResumeByIdAsync(Guid resumeId);
        Task<List<ResumeDTO>> GetProfileResumesAsync(Guid profileId);
        Task DeleteResumeAsync(Guid resumeId);


    }
}
    






