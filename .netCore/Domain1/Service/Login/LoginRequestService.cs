using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Service.Authuser;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.Login.DTOs;
using Domain.Service.Login.Interfaces;
using Domain.Service.SignUp.Interfaces;
using Domain.Service.Admin.DTOs;
using Domain.Helpers;
using Domain.Enum;

namespace Domain.Service.Login
{
    public class LoginRequestService : ILoginRequestService
    {
        ILoginRequestRepository jobSeekerRepository;
        IAuthUserRepository authUserRepository;
        IMapper mapper;
        public LoginRequestService(ILoginRequestRepository _jobSeekerRepository, IMapper _mapper, IAuthUserRepository _authUserRepository)
        {
            jobSeekerRepository = _jobSeekerRepository;
            mapper = _mapper;
            
            authUserRepository = _authUserRepository;
        }

        public JobSeekerLoginDto login(string email, string password)
        {
           
            var user = jobSeekerRepository.GetUserByEmail(email);
            if (user == null)
                return null;

            // verify hashed password
            if (!PasswordHelper.VerifyPassword(user, password))
                return null;

            // password verified -> create DTO, token and return
            var userReturn = mapper.Map<JobSeekerLoginDto>(user);
            userReturn.Token = authUserRepository.CreateToken(user);
            return userReturn;
        }



        //public AdminLoginDTO Adminlogin(string email, string password)
        //{
        //    var user = jobSeekerRepository.GetUserByEmail(email);
        //    if (user == null)
        //    {
        //        return null;
        //    }


        //    if (PasswordHelper.VerifyPassword(user, password))
        //    {
        //        var userReturn = mapper.Map<AdminLoginDTO>(user);
        //        userReturn.Token = authUserRepository.CreateToken(user);
        //        return userReturn;
        //    }


        //    return null;
        //}

        public async Task<AdminLoginDTO> Adminlogin(string email, string password)
        {
            var user = await authUserRepository.GetAuthUserByUserEmail(email);
            if (user == null || user.Role != Role.ADMIN)
                return null;

            if (!PasswordHelper.VerifyPassword(user, password))
                return null;

            return new AdminLoginDTO
            {
                Email = user.Email,
                Name = user.FirstName,
                Role = "Admin",
                Token = authUserRepository.CreateToken(user)
            };
        }





    }

}

