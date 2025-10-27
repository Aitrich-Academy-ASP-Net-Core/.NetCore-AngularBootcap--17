using System.Security.Claims;
using AutoMapper;
using Domain.Models;
using Domain.Service.AdminLogin.DTOs;
using Domain.Service.Authuser.Dto;
using Domain.Service.JobSeekerProfiles;
using Domain.Service.JobSeekerProfiles.Dtos;
using Domain.Service.JobSeekerProfiles.Dtos;
using Domain.Service.JobSeekerProfiles.Interfaces;
using HireMeNow_WebApi.API.Admin;
using JOBPORTALPROJECT.API.JobSeekerProfile.Request_Object;
using JOBPORTALPROJECT.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JOBPORTALPROJECT.API.JobSeekerProfile
{
    [ApiController]
    [Route("api/jobSeekerProfile")]
    [Authorize(Roles = "JOB_SEEKER")]
    public class JobSeekerProfileController : BaseApiController<JobSeekerProfileController>
    {
        private readonly IJobSeekerProfileServices _profileService;
        private readonly IMapper _mapper;

        public JobSeekerProfileController(IJobSeekerProfileServices profileService, IMapper mapper)
        {
            _profileService = profileService;
            _mapper = mapper;
        }

        // ---------------- PROFILE ----------------

        [HttpPost("add")]
        public async Task<IActionResult> AddProfile([FromBody] JobSeekerProfileRequest request)
        {
            // Extract JobSeeker Id from JWT token
            var jobSeekerIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.Sid)?.Value;
            if (jobSeekerIdClaim == null)
                return Unauthorized("JobSeeker Id missing in token.");

            var jobSeekerId = Guid.Parse(jobSeekerIdClaim);

            // Call service
            await _profileService.AddProfileForJobSeekerAsync(jobSeekerId, request.ProfileName, request.ProfileSummary);

            return Ok("Profile added successfully");
        }
        
        [HttpPut("update/{profileId}")]
        public async Task<IActionResult> UpdateProfile(Guid profileId, [FromBody] JobSeekerProfileRequest request)
        {
            var jobSeekerId = Guid.Parse(User.Claims.First(c => c.Type == ClaimTypes.Sid).Value);

            var updatedProfile = await _profileService.UpdateJobSeekerProfileAsync(
                jobSeekerId,
                profileId,
                request.ProfileName,
                request.ProfileSummary
            );

            if (updatedProfile == null)
                return NotFound("Profile not found or does not belong to this user");

            return Ok(updatedProfile);
        }

        [HttpGet("myProfiles")]
        public async Task<IActionResult> GetMyProfiles()
        {
            var jobSeekerId = Guid.Parse(User.Claims.First(c => c.Type == ClaimTypes.Sid).Value);

            var profiles = await _profileService.GetProfilesByJobSeekerAsync(jobSeekerId);

            return Ok(profiles);
        }

        //// ---------------- RESUME ----------------

    //    [HttpPost("{profileId}/resumes")]
    //    public async Task<IActionResult> UploadResume(Guid profileId, [FromForm] IFormFile file, [FromForm] string title)
    //    {
    //        var jobSeekerIdClaim = User.FindFirst(ClaimTypes.Sid)?.Value;
    //        if (jobSeekerIdClaim == null)
    //            return Unauthorized();

    //        Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

    //        using var ms = new MemoryStream();
    //        await file.CopyToAsync(ms);
    //        byte[] fileData = ms.ToArray();

    //        await _profileService.UploadResumeAsync(profileId, jobSeekerId, title, fileData);
    //        return Ok("Resume uploaded successfully");
    //    }



    //    [HttpGet("{profileId}/resumes")]
    //    public async Task<IActionResult> GetResumes(Guid profileId)
    //    {
    //        var resumes = await _profileService.GetProfileResumesAsync(profileId);
    //        return Ok(resumes);
    //    }

    //    [HttpPut("resumes/{resumeId}")]
    //    public async Task<IActionResult> UpdateResume(Guid resumeId, [FromBody] string title)
    //    {
    //        await _profileService.UpdateResumeAsync(resumeId, title);
    //        return NoContent();
    //    }

    //    [HttpDelete("resumes/{resumeId}")]
    //    public async Task<IActionResult> DeleteResume(Guid resumeId)
    //    {
    //        await _profileService.DeleteResumeAsync(resumeId);
    //        return NoContent();
    //    }

    //    [HttpGet("resumes/{resumeId}")]
    //    public async Task<IActionResult> GetResume(Guid resumeId)
    //    {
    //        var resume = await _profileService.GetResumeByIdAsync(resumeId);
    //        if (resume == null) return NotFound();
    //        return Ok(resume);
    //    }
    //}


    // ---------------- QUALIFICATIONS ----------------

    //[HttpPost("{jobSeekerId}/{profileId}/qualification")]
    //        public async Task<IActionResult> AddQualification(Guid jobSeekerId, Guid profileId, [FromBody] QualificationRequest request)
    //        {
    //            var dto = _mapper.Map<JobSeekerQualificationDTO>(request);
    //            await _profileService.AddQualificationToProfileAsync(jobSeekerId, profileId, dto);
    //            return Ok("Qualification added successfully");
    //        }

    //        [HttpGet("{profileId}/qualification")]
    //        public async Task<IActionResult> GetQualifications(Guid profileId)
    //        {
    //            var qualifications = await _profileService.GetQualificationsAsync(profileId);
    //            if (qualifications == null || !qualifications.Any())
    //                return NotFound("No qualifications found");
    //            return Ok(qualifications);
    //        }

    // ---------------- EXPERIENCE ----------------

    //[HttpPost("{jobSeekerId}/{profileId}/experience")]
    //public async Task<IActionResult> AddExperience(Guid jobSeekerId, Guid profileId, [FromBody] WorkExperienceRequest request)
    //{
    //    var dto = _mapper.Map<JobSeekerWorkExperienceDTO>(request);
    //    await _profileService.AddWorkExperienceToProfileAsync(jobSeekerId, profileId, dto);
    //    return Ok("Experience added successfully");
    //}

    //[HttpGet("{jobSeekerId}/{profileId}/experience")]
    //public async Task<IActionResult> GetExperience(Guid jobSeekerId, Guid profileId)
    //{
    //    var experiences = await _profileService.GetExperienceAsync(jobSeekerId, profileId);
    //    if (experiences == null || !experiences.Any())
    //        return NotFound("No experiences found");
    //    return Ok(experiences);
    }


}









