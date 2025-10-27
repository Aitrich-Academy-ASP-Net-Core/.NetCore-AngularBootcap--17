
using AutoMapper;
using Domain.Models;
using Domain.Service.AdminLogin.DTOs;
using Domain.Service.JobSeekerProfiles.Dtos;
using HireMeNow_WebApi.API.Admin.RequestObjects;
using JOBPORTALPROJECT.API.JobSeekerProfile.Request_Object;


namespace HireMeNow_WebApi.Extensions
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {

            CreateMap<SignUpRequest, SystemUser>().ReverseMap();
            CreateMap<AuthUser, Domain.Models.JobSeeker>().ReverseMap();
            CreateMap<AuthUser, SystemUser>().ReverseMap();
            CreateMap<AuthUser, Domain.Models.CompanyUser>().ReverseMap();



            CreateMap<JobSeeker, JobSeekerDto>();

            CreateMap<JobProviderCompany, JobProviderDto>().ReverseMap();
            CreateMap<CompanyUser, CompanyUsersDto>().ReverseMap();
            CreateMap<JobSeeker, JobSeekerDto>().ReverseMap();
           

            CreateMap<CompanyUser, CompanyUsersDto>()
                .ForMember(dest => dest.Company, opt => opt.MapFrom(src => src.Company))
                .ReverseMap();

            CreateMap<JobPost, JobpostDto>().ReverseMap();

            CreateMap<SkillRequest, SkillDto>().ReverseMap();  
            CreateMap<SkillDto, Skill>().ReverseMap();         

            // ================= Industry =================
            CreateMap<IndustryRequest, Industry>().ReverseMap();

            // ================= JobCategory =================
            CreateMap<CategoryRequest, JobCategory>().ReverseMap();

            // ================= Location =================
            CreateMap<LocationRequest, Location>().ReverseMap();

            // ================= JobProviderCompany =================
            CreateMap<JobProviderCompany, JobProviderDto>().ReverseMap();

            // ================= CompanyUser =================
            CreateMap<CompanyUser, CompanyUsersDto>().ReverseMap();

            // ================= JobSeeker =================
            CreateMap<JobSeeker, JobSeekerDto>().ReverseMap();



            CreateMap<JobSeekerProfileRequest, ProfileDto>();
            CreateMap<ProfileDto, JobSeekerProfile>();
            CreateMap<AuthUserRequest, AuthuserDto>();
            CreateMap<Resume, ResumeDTO>().ReverseMap();
            CreateMap<JobSeekerProfile, ProfileDto>().ReverseMap();



            CreateMap<QualificationRequest, JobSeekerQualificationDTO>();
            CreateMap<WorkExperienceRequest, JobSeekerWorkExperienceDTO>();

           

          
           




           
        }
    }
}
