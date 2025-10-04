using System.Text;
using Domain.Enum;
using Domain.Models;
using Domain.Service.Authuser.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JOBPORTALPROJECT.API.Login
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthUserRepository _userRepo;

        public AuthController(IAuthUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> Signup([FromBody] SignUpRequest req)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = await _userRepo.GetByEmailAsync(req.Email);
            if (existing != null)
                return BadRequest("User already exists");

            // Hash the password (example using some hash method)
            string hashed = HashPassword(req.Password);

            var user = new AuthUser
            {
                Id = Guid.NewGuid(),
                Email = req.Email,
                PasswordHash = hashed,
                Role = Role.JOB_SEEKER,
                FirstName = req.FirstName,
                LastName = req.LastName
            };

            await _userRepo.AddAsync(user);

            return Ok(new { message = "Signup successful" });
        }

        private string HashPassword(string password)
        {
            // TODO: Use a proper hashing algorithm like BCrypt or PBKDF2
            // For example, placeholder:
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        }
    }
}
