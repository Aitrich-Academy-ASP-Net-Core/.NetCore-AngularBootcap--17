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

        // ================= JobSeeker Login =================
        public async Task<JobSeekerLoginDto?> JobSeekerLoginAsync(string email, string password)
        {
            var user = await _authUserRepository.GetAuthUserByUserEmail(email);
            if (user == null || user.Role != Role.JOB_SEEKER || !PasswordHelper.VerifyPassword(password, user.PasswordHash))
                return null;

            return new JobSeekerLoginDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                Email = user.Email,
                Token = _authUserRepository.CreateToken(user) // ✅ Single token logic
            };
        }


        // ================= Admin Login =================
        public async Task<AdminLoginDto?> AdminLoginAsync(string email, string password)
        {
            var user = await _authUserRepository.GetAuthUserByUserEmail(email);
            if (user == null || user.Role != Role.ADMIN) return null;

            if (!PasswordHelper.VerifyPassword(password, user.PasswordHash)) return null;

            return new AdminLoginDto
            {
                Email = user.Email,
                Name = user.FirstName,
                Role = "Admin",
                Token = _authUserRepository.CreateToken(user) // same token method
            };
        }

        // ================= JobProvider Login (Optional) =================
        //public async Task<JobProviderLoginDto?> JobProviderLoginAsync(string email, string password)
        //{
        //    var user = await _authUserRepository.GetAuthUserByUserEmail(email);
        //    if (user == null || user.Role != Role.JOB_PROVIDER) return null;

        //    if (!PasswordHelper.VerifyPassword(password, user.PasswordHash)) return null;

        //    var dto = _mapper.Map<JobProviderLoginDto>(user);
        //    dto.Token = _authUserRepository.CreateToken(user);
        //    return dto;
        //}










        ////================= Job Seeker Login =================
        //public async Task<JobSeekerLoginDto?> JobSeekerLoginAsync(string email, string password)
        //{
        //    var user = await _authUserRepository.GetAuthUserByUserEmail(email);

        //    if (user == null || user.Role != Role.JOB_SEEKER)
        //        return null;

        //    //  Verify against PasswordHash
        //    if (!PasswordHelper.VerifyPassword(password, user.PasswordHash))
        //        return null;

        //    var dto = _mapper.Map<JobSeekerLoginDto>(user);
        //    dto.Token = _authUserRepository.CreateJobSeekerToken(user);
        //    return dto;
        //}



        //// ================= Admin Login =================
        //public async Task<AdminLoginDto> Adminlogin(string email, string password)
        //{
        //    var user = await _authUserRepository.GetAuthUserByUserEmail(email);

        //    if (user == null || user.Role != Role.ADMIN)
        //        return null;

        //    if (!PasswordHelper.VerifyPassword(password, user.PasswordHash))
        //        return null;




        //    return new AdminLoginDto
        //    {
        //        Email = user.Email,
        //        Name = user.FirstName,
        //        Role = "Admin",
        //        Token = _authUserRepository.CreateToken(user)
        //    };
        //}



    }
}

