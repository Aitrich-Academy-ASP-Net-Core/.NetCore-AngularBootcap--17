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
using JOBPORTALPROJECT.Controllers;

namespace HireMeNow_WebApi.API.Admin
{
    [ApiController]
    [Route("api/admin")]
    [Authorize(Roles = "ADMIN")]
    public class AdminController : BaseApiController<AdminController>
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

            var adminUserDto = await _loginService.AdminLoginAsync(request.Email, request.Password);

            if (adminUserDto == null)
                return BadRequest("Invalid email or password");

            return Ok(adminUserDto);
        }

        //// =================== Debug Admin ===================
        [AllowAnonymous]
        [HttpGet("debug-token")]
        public async Task<IActionResult> DebugToken()
        {
            var adminUser = await _authUserRepository.GetAuthUserByUserEmail("admin@hiremenow.com");
            if (adminUser == null) return NotFound("Admin not found");

            var token = _authUserRepository. CreateToken(adminUser);
            return Ok(new { Token = token });
        }



        // =================== Get All Job Seekers ===================
        [HttpGet("jobseekers")]
        public async Task<IActionResult> GetJobSeekers()
        {
            var jobSeekers = await _adminService.GetJobSeekers();
            return Ok(_mapper.Map<List<JobSeekerDto>>(jobSeekers));
        }

        // =================== Get All Companies =======================
        [HttpGet("companies")]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _adminService.GetCompanies();
            return Ok(_mapper.Map<List<JobProviderDto>>(companies));
        }


        [HttpGet("search")]
        public async Task<IActionResult> SearchCompanies([FromQuery] string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return BadRequest("Search term is required.");
            }

            var companies = await _adminService.SearchCompaniesAsync(searchTerm);
            if (companies == null || !companies.Any())
            {
                return NotFound("No companies found matching the search term.");
            }

            return Ok(companies);
        }

        // =================== Remove Company ===================
        [HttpDelete("company/{companyId}")]
        public async Task<IActionResult> RemoveCompany(Guid companyId)
        {
            var result = await _adminService.RemoveCompanyAsync(companyId);
            return result
                ? Ok("Company deleted successfully")
                : NotFound("Company not found");
        }





        // =================== Get Company Users ===================
        [HttpGet("companyusers")]
        public async Task<IActionResult> GetCompanyUsers()
        {
            var companyUsers = await _adminService.GetCompanyUsers();
            return Ok(_mapper.Map<List<CompanyUsersDto>>(companyUsers));
        }

      
        // =================== Remove Company User ===================
        [HttpDelete("companyuser/{userId}")]
        public async Task<IActionResult> RemoveCompanyUser(Guid userId)
        {
            var result = await _adminService.RemoveCompanyUserAsync(userId);
            return result
                ? Ok("Company user deleted successfully")
                : NotFound("Company user not found");
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

        [HttpGet("industries")]
        public async Task<IActionResult> GetIndustries()
        {
            var industries = await _adminService.GetIndustriesAsync();
            return Ok(industries);
        }



        // =================== Remove Industry ===================
        [HttpDelete("industry/{industryId}")]
        public async Task<IActionResult> RemoveIndustry(Guid industryId)
        {
            var result = await _adminService.RemoveIndustryAsync(industryId);
            return result
                ? Ok("Industry deleted successfully")
                : NotFound("Industry not found");
        }
        




        // =================== Add Category ===================
        [HttpPost("category")]
        public async Task<IActionResult> AddCategory([FromBody] CategoryRequest request)
        {
            var category = _mapper.Map<JobCategory>(request);
            var result = await _adminService.AddCategory(category);
            return Ok(result);
        }

        [HttpGet("categories")] 
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _adminService.GetCategoriesAsync();
            return Ok(categories);
        }




        // =================== Remove Job Category ===================
        [HttpDelete("category/{categoryId}")]
        public async Task<IActionResult> RemoveCategory(Guid categoryId)
        {
            var result = await _adminService.RemoveCategoryAsync(categoryId);
            return result
                ? Ok("Category deleted successfully")
                : NotFound("Category not found");
        }
        // =================== Add Location ===================
        [HttpPost("location")]
        public async Task<IActionResult> AddLocation([FromBody] LocationRequest request)
        {
            var location = _mapper.Map<Location>(request);
            var result = await _adminService.AddLocation(location);
            return Ok(result);
        }

        [HttpGet("locations")]
        public async Task<IActionResult> GetLocations()
        {
            var locations = await _adminService.GetLocationsAsync();
            return Ok(locations);
        }



        // =================== Remove Location ===================
        [HttpDelete("location/{locationId}")]
        public async Task<IActionResult> RemoveLocation(Guid locationId)
        {
            var result = await _adminService.RemoveLocationAsync(locationId);
            return result
                ? Ok("Location deleted successfully")
                : NotFound("Location not found");
        }


        // -----------All Jobs-----------
        [HttpGet("jobs")]
        public async Task<IActionResult> GetAllJobs()
        {
            var jobs = await _adminService.GetAllJobsAsync();
            return Ok(jobs);
        }


       

        //------ Get Job Provider Count-------
        [HttpGet("jobprovidercount")]
        public async Task<IActionResult> GetJobProviderCount()
        {
            var count = await _adminService.GetJobProviderCountAsync();
            return Ok(new { JobProviderCount = count });
        }

        // ------Get Job Seeker Count--------
        [HttpGet("jobseekercount")]
        public async Task<IActionResult> GetJobSeekerCount()
        {
            var count = await _adminService.GetJobSeekerCountAsync();
            return Ok(new { JobSeekerCount = count });
        }

        // ----------- Get Job Count--------
        [HttpGet("jobcount")]
        public async Task<IActionResult> GetJobCount()
        {
            var count = await _adminService.GetJobCountAsync();
            return Ok(new { JobCount = count });
        }
    }

    // =================== Password Hash Helper ===================
    //public static class PasswordHelper
    //{
    //    public static string HashPassword(string password)
    //    {
    //        using var sha256 = SHA256.Create();
    //        var bytes = Encoding.UTF8.GetBytes(password);
    //        var hash = sha256.ComputeHash(bytes);
    //        return Convert.ToBase64String(hash);
    //    }}

      



    
}


