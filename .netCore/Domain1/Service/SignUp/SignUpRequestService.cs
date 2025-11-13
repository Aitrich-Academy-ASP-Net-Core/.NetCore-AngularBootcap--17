using AutoMapper;
using Domain.Helpers;
using Domain.Models;
using Domain.Enum;
using Domain.Service.Authuser.Dto;
using Domain.Service.Authuser;
using Domain.Service.Authuser.Interfaces;

using Domain.Service.SignUp.DTOs;
using Domain.Service.SignUp.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.SignUp
{
    public class SignUpRequestService : ISignUpRequestService
    {
        ISignUpRequestRepository jobSeekerRepository;
        IAuthUserRepository authUserRepository;
        IMapper mapper;
        IEmailService emailService;
        public SignUpRequestService(ISignUpRequestRepository _jobSeekerRepository, IMapper _mapper, IEmailService _emailService, IAuthUserRepository _authUserRepository)
        {
            jobSeekerRepository = _jobSeekerRepository;
            mapper = _mapper;
            emailService = _emailService;
            authUserRepository = _authUserRepository;
        }

        public async Task CreateJobseeker(Guid jobSeekerSignupRequestId, string password)
        {
            
            try
            {
                SignUpRequest signUpRequest = await jobSeekerRepository.GetSignupRequestByIdAsync(jobSeekerSignupRequestId);
                if (signUpRequest == null)
                    throw new Exception("Signup request not found.");

                if (signUpRequest.Status == Enum.Status.Verified)
                {
                    // build authUser object
                    AuthUser authUser = new AuthUser
                    {
                        UserName = signUpRequest.UserName,
                        Role = Enum.Role.JOB_SEEKER,
                        FirstName = signUpRequest.FirstName,
                        LastName = signUpRequest.LastName,
                        Email = signUpRequest.Email,
                        Phone = signUpRequest.Phone
                    };

                    // HASH the password here using PasswordHelper
                    authUser.Password = PasswordHelper.HashPassword(authUser, password);

                    // save the user
                    authUser = await authUserRepository.AddAuthUser(authUser);

                    // update signup status
                    signUpRequest.Status = Enum.Status.Created;
                    jobSeekerRepository.UpdateSignupRequest(signUpRequest);

                    // optionally map to domain JobSeeker entity and save if needed
                    Models.JobSeeker jobseeker = mapper.Map<Models.JobSeeker>(authUser);
                    // await jobSeekerRepository.AddJobSeekerAsync(jobseeker);
                }
            }
            catch (Exception)
            {
                // rethrow preserving stack trace
                throw;
            }

        }

        public async void CreateSignupRequest(JobSeekerSignupRequestDto data)
        {

            var signUpRequest = mapper.Map<SignUpRequest>(data);
            var signUpId = jobSeekerRepository.AddSignupRequest(signUpRequest);
            MailRequest mailRequest = new MailRequest();
            mailRequest.Subject = "HireMeNow SignUp Verification";
            mailRequest.Body = "http://localhost:4200/set-password?signupid=" + signUpId.ToString();
            mailRequest.ToEmail = signUpRequest.Email;
            await emailService.SendEmailAsync(mailRequest);
        }

        public async Task<bool> VerifyEmailAsync(Guid jobSeekerSignupRequestId)
        {

            SignUpRequest signUpRequest = await jobSeekerRepository.GetSignupRequestByIdAsync(jobSeekerSignupRequestId);
            if (signUpRequest != null)
            {
                signUpRequest.Status = Enum
                    .Status.Verified;
                jobSeekerRepository.UpdateSignupRequest(signUpRequest);
                return true;
            }
            return false;
        }


        public async Task<Guid> addResume(string title, byte[] fileData)
        {
            Guid resumeId = Guid.NewGuid();
            await jobSeekerRepository.addResume(resumeId, title, fileData);

            return resumeId;
        }

        public async Task addResumeToProfile(Guid profileId, Guid resumeId, Guid jobSeekerId, string profileName, string profileSummary)
        {
            await jobSeekerRepository.addResumeToProfile(profileId, resumeId, jobSeekerId, profileName, profileSummary);
        }
       
        public async Task<byte[]> getResumeFile(Guid resumeId)
        {
            byte[] byteArray = await jobSeekerRepository.getResumeFile(resumeId);
            return byteArray;
        }


        public async Task<Guid> getResumeId(Guid profileId)
        {
            Guid resumeId = await jobSeekerRepository.getResumeId(profileId);
            return resumeId;
        }


        public async Task UpdateResume(Guid resumeId, byte[] fileData)
        {
            await jobSeekerRepository.UpdateResume(resumeId, fileData);
        }

        public async Task<List<Resume>> getResumeById(Guid resumeId)
        {
            return await jobSeekerRepository.getResume(resumeId);
        }
        public async Task DeleteResume(Guid resumeId)
        {
            await jobSeekerRepository.DeleteResume(resumeId);
        }
    }
}
