using Domain.Enums;
using Domain.Models;
using Domain.Service.AdminLogin.Interface;
using Domain.Service.Authuser;
using Domain.Service.Authuser.Interfaces;
using HireMeNow_WebApi.API.Admin.RequestObjects;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System.Security.Cryptography;
using System.Text;
using Domain.Service.AdminLogin.DTOs;
using Domain.Service.Login.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Domain.Service.Login.Dtos;
using Domain.Service.AdminLogin;

namespace HireMeNow_WebApi.API.Admin
{
    [ApiController]
    [Route("api/admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        private readonly IAuthUserRepository _authUserRepository;
        private readonly IAdminService _adminService;
        private readonly IMapper _mapper;
        private readonly ILoginRequestService _loginService;

        public AdminController(
            IAuthUserRepository authUserRepository,
            IAdminService adminService,
            IMapper mapper,
            ILoginRequestService loginService)
        {
            _authUserRepository = authUserRepository;
            _adminService = adminService;
            _mapper = mapper;
            _loginService = loginService;
        }

        // =================== Admin Login ===================
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AdminLoginRequests request)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid request");

            var adminUserDto = await _loginService.Adminlogin(request.Email, request.Password);

            if (adminUserDto == null)
                return BadRequest("Invalid email or password");

            return Ok(adminUserDto);
        }

        // =================== Debug Admin ===================
        [AllowAnonymous]
        [HttpGet("debug-admin")]
        public async Task<IActionResult> DebugAdmin()
        {
            var user = await _authUserRepository.GetAuthUserByUserEmail("admin@hiremenow.com");
            if (user == null) return NotFound("Admin not found");

            return Ok(new { user.Email, user.Password, user.Role });
        }

        // =================== Get All Job Seekers ===================
        [HttpGet("jobseekers")]
        public async Task<IActionResult> GetJobSeekers()
        {
            var jobSeekers = await _adminService.GetJobSeekers();
            return Ok(_mapper.Map<List<JobSeekerDto>>(jobSeekers));
        }

        // =================== Get All Companies ===================
        [HttpGet("companies")]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _adminService.GetCompanies();
            return Ok(_mapper.Map<List<JobProviderDto>>(companies));
        }

        // =================== Get Company Users ===================
        [HttpGet("companyusers")]
        public async Task<IActionResult> GetCompanyUsers()
        {
            var companyUsers = await _adminService.GetCompanyUsers();
            return Ok(_mapper.Map<List<CompanyUsersDto>>(companyUsers));
        }

        // =================== Add Skill ===================

        [HttpGet("skills")]
        public async Task<IActionResult> GetSkills()
        {
            var skills = await _adminService.GetAllSkillsAsync(); // returns List<Skill>
            var skillDtos = _mapper.Map<List<SkillDto>>(skills);
            return Ok(skillDtos);
        }



        [HttpPost("skills")]
        public async Task<IActionResult> AddSkill([FromBody] SkillRequest skillRequest)
        {
            // map request -> SkillDto
            var skillDto = _mapper.Map<SkillDto>(skillRequest);

            // service returns the created SkillDto (with Id)
            var created = await _adminService.AddSkillAsync(skillDto);
            return CreatedAtAction(nameof(GetSkills), new { id = created.Id }, created);
        }









        // =================== Remove Skill ===================
        [HttpDelete("skills/{skillId}")]
        public async Task<IActionResult> RemoveSkill(Guid skillId)
        {
            var result = await _adminService.RemoveSkillAsync(skillId);
            return result ? Ok("Skill deleted successfully") : NotFound("Skill not found");
        }

        // =================== Add Industry ===================
        [HttpPost("industry")]
        public async Task<IActionResult> AddIndustry([FromBody] IndustryRequest request)
        {
            var industry = _mapper.Map<Industry>(request);
            var result = await _adminService.AddIndustry(industry);
            return Ok(result);
        }

        // =================== Add Category ===================
        [HttpPost("category")]
        public async Task<IActionResult> AddCategory([FromBody] CategoryRequest request)
        {
            var category = _mapper.Map<JobCategory>(request);
            var result = await _adminService.AddCategory(category);
            return Ok(result);
        }

        // =================== Add Location ===================
        [HttpPost("location")]
        public async Task<IActionResult> AddLocation([FromBody] LocationRequest request)
        {
            var location = _mapper.Map<Location>(request);
            var result = await _adminService.AddLocation(location);
            return Ok(result);
        }
    

    [HttpGet("jobs")]
        public async Task<IActionResult> GetAllJobs()
        {
            var jobs = await _adminService.GetAllJobsAsync();
            return Ok(jobs);
        }
    



    // =================== Password Hash Helper ===================
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

      



    }
}}

