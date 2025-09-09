using AutoMapper;
using JobPortal.Dto;
using JobPortal.Model;

namespace JobPortal.Helpers
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job, JobDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }


    }
}
