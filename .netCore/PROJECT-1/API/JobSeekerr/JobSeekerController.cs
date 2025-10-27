using AutoMapper;
using Domain.Service.JobSeeker.DTOs;
using Domain.Service.SignUp.Interfaces;
using Domain.Service.SignUp.DTOs;
using JobPortalApp.API.JobSeekerr.RequestObjects;
using Domain.Service.Login.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Service.Profile.DTOs;
using Domain.Service.Profile.Interface;
using Domain.Service.Profile;
namespace JobPortalApp.API.JobSeekerr
{
    [ApiController]
    [Route("api/job-seekerr")] // base route
    
    public class JobSeekerController : BaseApiController<JobSeekerController>
    {
        public ISignUpRequestService jobSeekerService { get; set; }
        public IJobSeekerProfileService profileService { get; set; }

       public ILoginRequestService loginRequestService { get; set; }

        public IMapper mapper { get; set; }
        public JobSeekerController(IJobSeekerProfileService _profileService,ISignUpRequestService _jobSeekerService, IMapper _mapper, ILoginRequestService _loginRequestService)
        {
            jobSeekerService = _jobSeekerService;
            loginRequestService = _loginRequestService;
            mapper = _mapper;
            profileService = _profileService;





        }
        // POST: api/job-seeker/signup
        [HttpPost("signup")]
        public async Task<ActionResult> createJobSeekerSignupRequest(JobSeekerSignupRequest data)
        {
            var jobSeekerSignupRequestDto = mapper.Map<JobSeekerSignupRequestDto>(data);
            jobSeekerService.CreateSignupRequest(jobSeekerSignupRequestDto);
            return Ok(data);
        }
        [HttpGet]
        [Route("job-seeker/signup/{jobSeekerSignupRequestId}/verify-email")]
        public async Task<ActionResult> VerifyJobSeekerEmail(Guid jobSeekerSignupRequestId)
        {
            var isVerified = await jobSeekerService.VerifyEmailAsync(jobSeekerSignupRequestId);
            if (isVerified)
            {
                return Ok("Email Verified");
            }
            return BadRequest();
        }
        [HttpPost]
        [Route("job-seeker/signup/{jobSeekerSignupRequestId}/set-password")]
        public async Task<ActionResult> createJobSeekerSignupRequest(Guid jobSeekerSignupRequestId, [FromBody] string password)
        {
            //var jobSeekerSignupRequestDto = mapper.Map<JobSeekerSignupRequestDto>(data);
            await jobSeekerService.CreateJobseeker(jobSeekerSignupRequestId, password);
            return Ok("Password Set Successfully");
        }
        [HttpPost]
        [Route("job-seeker/login")]
        public async Task<ActionResult> Login(JobSeekerLoginRequest logdata)
        {
            //var user = _mapper.Map<User>(userDto);
            var user = loginRequestService.login(logdata.Email, logdata.Password);

            if (user == null)
            {
                return BadRequest("Login Failed");
            }
            return Ok(user);
        }






        [HttpPost("AddProfile")]
        public async Task<IActionResult> AddProfile([FromBody] JobseekerProfileRequest profileRequest)
        {
            if (profileRequest == null)
                return BadRequest("Profile data is required.");

            var addProfileDto = mapper.Map<ProfileDTO>(profileRequest);

            var profile = await profileService.AddProfileAsync(addProfileDto);

            if (profile != null)
            {
                return Ok(new
                {
                    message = "Profile added successfully.",
                    profileId = profile.Id,      
                    jobSeekerId = profile.JobSeekerId,
                    
                });
            }
            return BadRequest("Failed to add profile.");
        }




        [HttpPost]
        [Route("job-seeker/upload-resume")]
        public async Task<ActionResult> UploadResume(Guid jobSeekerId, Guid profileId, string profileName, string profileSummary, string title, IFormFile file)
        {
            var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);
            byte[] fileData = memoryStream.ToArray();

            Guid resumeId = await jobSeekerService.addResume(title, fileData);

            await jobSeekerService.addResumeToProfile(profileId, resumeId, jobSeekerId, profileName, profileSummary);
            return Ok(new
            {
                message = "Resume successfully uploaded to profile",
                resumeId = resumeId
            });
        }






        [HttpPut]
        [Route("job-seeker/update-resume")]
        public async Task<ActionResult> UpdateResume(Guid profileId, IFormFile file)
        {

            Guid resumeId = await jobSeekerService.getResumeId(profileId);

            var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);
            byte[] fileData = memoryStream.ToArray();

            await jobSeekerService.UpdateResume(resumeId, fileData);


            return Ok();
        }
        [HttpGet]
        [Route("job-seeker/getResume/{profileId}")]
        public async Task<ActionResult<byte[]>> GetResume(Guid profileId)
        {
            try
            {
                Guid resumeId = await jobSeekerService.getResumeId(profileId);

                /* byte[] byteArray = await jobSeekerService.getResumeFile(resumeId);

				 if (byteArray == null)
				 {
					 return NotFound(); // Or any appropriate status code if the file doesn't exist.
				 }

				 return byteArray;*/

                List<Resume> resume = await jobSeekerService.getResumeById(resumeId);
                return Ok(mapper.Map<List<resumeDto>>(resume));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("job-seeker/delete-resume")]
        public async Task<ActionResult> DeleteResume(Guid profileId)
        {

            Guid resumeId = await jobSeekerService.getResumeId(profileId);

            await jobSeekerService.DeleteResume(resumeId);


            return Ok();
        }
       


    }
}
