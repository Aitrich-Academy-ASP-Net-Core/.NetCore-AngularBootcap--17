using Domain.Helpers;
using Domain.Models;
using Domain.Service.Authuser.Dto;
using Domain.Service.JobseekerAuth.Dto;
using Domain.Service.JobseekerAuth.Interfaces;
using HireMeNow_WebApi.API.Admin;
using JOBPORTALPROJECT.API.JobSeeker.RequestObject;
using JOBPORTALPROJECT.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JOBPORTALPROJECT.API.JobSeeker
{

    [Route("api/jobseeker/auth")]
    [ApiController]
    public class JobSeekerAuthController : ControllerBase
    {
        private readonly IJobSeekerAuthService _service;

        public JobSeekerAuthController(IJobSeekerAuthService service)
        {
            _service = service;
        }

        // ✅ 1️⃣ Register JobSeeker
        [HttpPost("register")]
        public async Task<IActionResult> Register(JobSeekerRegisterRequest request)
        {
            await _service.RegisterAsync(new JobSeekerRegisterDto
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Phone = request.Phone
            });

            return Ok(new { message = "Verification email sent." });
        }

        // Verify Email
        [HttpGet("verify-email")]
        public async Task<IActionResult> VerifyEmail(Guid id, string email)
        {
            await _service.VerifyEmailByIdAsync(id, email);
            return Ok("Email verified successfully!");
        }

        //Set Password
        [HttpPost("set-password")]
        public async Task<IActionResult> SetPassword(SetPasswordRequest request)
        {
            try
            {
                await _service.SetPasswordAsync(request.UserId, request.Password);
                return Ok("Password set successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // Login
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] JobSeekerLoginRequest request)
        {
            var result = await _service.LoginAsync(request.Email, request.Password);
            if (result == null)
                return BadRequest("Invalid email or password");

            return Ok(result);
        }
    }
}




//    [Route("api/jobseeker/auth")]
//    [ApiController]
//    public class JobSeekerController : BaseApiController<JobSeekerController>
//    {
//        private readonly IJobSeekerAuthService _service;

//        public JobSeekerController(IJobSeekerAuthService service)
//        {
//            _service = service;
//        }

//        [HttpPost("register")]
//        public async Task<IActionResult> Register(JobSeekerRegisterRequest request)
//        {
//            await _service.RegisterAsync(new JobSeekerRegisterDto
//            {
//                FirstName = request.FirstName,
//                LastName = request.LastName,
//                Email = request.Email,
//                Phone = request.Phone,

//            });

//            return Ok(new
//            {
//                Message = "Verification email sent."
//            });
//        }





//        [HttpGet("verify-email")]
//        public async Task<IActionResult> VerifyEmail(Guid id, string email)
//        {
//            await _service.VerifyEmailByIdAsync(id, email);
//            return Ok("Email verified successfully!");
//        }



//        [HttpPost("set-password")]
//        public async Task<IActionResult> SetPassword(SetPasswordRequest request)
//        {
//            try
//            {
//                await _service.SetPasswordAsync(request.UserId, request.Password);
//                return Ok("Password set successfully.");
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }


//        [AllowAnonymous]
//        [HttpPost("login")]
//        public async Task<IActionResult> Login([FromBody] JobSeekerLoginRequest request)
//        {
//            var result = await _service.LoginAsync(request.Email, request.Password);

//            if (result == null)
//                return BadRequest("Invalid email or password");

//            return Ok(result);
//        }

//    }
//}


