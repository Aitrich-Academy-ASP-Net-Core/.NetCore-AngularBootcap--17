using Domain.Models;
using Domain.Service.JobseekerAuth.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JOBPORTALPROJECT.API.JobSeeker
{
    [Route("api/jobseeker/auth")]
    [ApiController]
    public class JobSeekerAuthController : ControllerBase
    {
        private readonly IJobSeekerAuthService _authService;

        public JobSeekerAuthController(IJobSeekerAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(SignUpRequest request)
        {
            var result = await _authService.RegisterAsync(request);
            if (!result) return BadRequest("Email already exists");
            return Ok("OTP sent to your email");
        }

        [HttpPost("verify")]
        public async Task<IActionResult> VerifyOtp(string email, string otp)
        {
            var result = await _authService.VerifyOtpAsync(email, otp);
            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            var token = await _authService.LoginAsync(email, password);
            if (token == null) return Unauthorized("Invalid credentials");
            return Ok(new { Token = token });
        }
    }
}

