using AutoMapper;
using JobApplication.Model;
using JobApplication.Dto;
namespace JobApplication.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job, JobDto>().ReverseMap();
        }
    }
}
