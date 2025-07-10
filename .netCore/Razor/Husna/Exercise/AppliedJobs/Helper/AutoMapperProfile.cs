using AutoMapper;
using AppliedJobs.Dto;
using AppliedJobs.Model;
namespace AppliedJobs.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job, JobDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();

            CreateMap<Application, ApplicationDto>()
                .ForMember(dest => dest.JobTitle, opt => opt.MapFrom(src => src.Job.Title))
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Job.Location));

        }
    }
}
