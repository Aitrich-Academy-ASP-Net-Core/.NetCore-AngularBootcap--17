using AutoMapper;
using JobSeekerManagement.Models;
using JobSeekerManagement.Dto;
namespace JobSeekerManagement.Helper
{
    public class AutoMappingProfile:Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Job, JobDto>().ReverseMap();
            // Application -> ApplicationDto
            CreateMap<Application, ApplicationDto>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Job.Title))
                .ForMember(dest => dest.Company, opt => opt.MapFrom(src => src.Job.Company));

            // ApplicationDto -> Application
            CreateMap<ApplicationDto, Application>();
            CreateMap<User, ProfileDto>().ReverseMap();
        }
    }
}
