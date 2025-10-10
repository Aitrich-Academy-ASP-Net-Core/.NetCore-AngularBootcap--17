using System.Threading.Tasks;
using AutoMapper;
using Domain.Enums;
using Domain.Helpers;
using Domain.Service.Authuser;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.Login.Dtos;
using Domain.Service.Login.Interfaces;

namespace Domain.Service.Login
{
    public class LoginRequestService : ILoginRequestService
    {
        private readonly ILoginRequestRepository _jobSeekerRepository;
        private readonly IAuthUserRepository _authUserRepository;
        private readonly IMapper _mapper;

        public LoginRequestService(
            ILoginRequestRepository jobSeekerRepository,
            IMapper mapper,
            IAuthUserRepository authUserRepository)
        {
            _jobSeekerRepository = jobSeekerRepository;
            _mapper = mapper;
            _authUserRepository = authUserRepository;
        }

        // ================= Job Seeker Login =================
        public JobSeekerLoginDto login(string email, string password)
        {
            var user = _jobSeekerRepository.GetUserByEmailpassword(email, password);
            if (user == null) return null;

            if (!Domain.Helpers.PasswordHelper.VerifyPassword(password, user.Password))
                return null;

            var userReturn = _mapper.Map<JobSeekerLoginDto>(user);
            userReturn.Token = _authUserRepository.CreateToken(user);
            return userReturn;
        }

        // ================= Admin Login =================
        public async Task<AdminLoginDto> Adminlogin(string email, string password)
        {
            var user = await _authUserRepository.GetAuthUserByUserEmail(email);

            if (user == null || user.Role != Role.ADMIN)
                return null;

            // ✅ Check hashed password
            if (!PasswordHelper.VerifyPassword(password, user.Password))
                return null;

            return new AdminLoginDto
            {
                Email = user.Email,
                Name = user.FirstName,
                Role = "Admin",
                Token = _authUserRepository.CreateToken(user)
            };
        }



    }
}

