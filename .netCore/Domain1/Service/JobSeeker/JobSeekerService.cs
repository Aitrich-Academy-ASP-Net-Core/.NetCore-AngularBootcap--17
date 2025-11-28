//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Domain.Models;
//using Domain.Service.Jobseeker.Interfaces;
//using Domain.Service.Jobseeker.Dto;
//using AutoMapper;
//using System.Runtime.InteropServices;

//namespace Domain.Service.Jobseeker
//{
//    public class JobSeekerService : IJobSeekerService
//    {
//        private readonly IJobSeekerRepository _jobSeekerRepository;
//        private readonly IMapper _mapper;

//        public JobSeekerService(IJobSeekerRepository jobSeekerRepository, IMapper mapper)
//        {
//            _jobSeekerRepository = jobSeekerRepository;
//            _mapper = mapper;
//        }

//        public async Task<bool> CreateSignupRequest(JobSeekerSignupRequestDto signupRequest)
//        {
//            // Map DTO to Entity
//            var jobSeeker = _mapper.Map<JobSeeker>(signupRequest);

//            // Save to database
//            return await _jobSeekerRepository.AddJobSeekerAsync(jobSeeker);


//        }
//        public async Task<bool> VerifyEmailAsync(Guid jobSeekerSignupRequestId)
//        {
//            var jobSeeker = await _jobSeekerRepository.GetByIdAsync(jobSeekerSignupRequestId);
//            if (jobSeeker == null)
//                return false;

//            jobSeeker.IsEmailVerified = true;
//            return await _jobSeekerRepository.UpdateAsync(jobSeeker);
//        }

//    }
//}
