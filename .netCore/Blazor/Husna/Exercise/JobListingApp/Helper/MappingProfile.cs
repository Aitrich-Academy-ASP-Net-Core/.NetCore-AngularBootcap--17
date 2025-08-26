using AutoMapper;
using JobListingApp.Model;
using JobListingApp.Dto;
namespace JobListingApp.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<JobSeeker, JobSeekerDto>().ReverseMap();
            CreateMap<Job, JobDto>().ReverseMap();
        }
    }
}
