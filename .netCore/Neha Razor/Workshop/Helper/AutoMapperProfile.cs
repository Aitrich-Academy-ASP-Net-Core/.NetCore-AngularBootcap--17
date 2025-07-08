using AutoMapper;
using Workshop.DTO;
using Workshop.Models;

namespace Workshop.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job, JobDto>().ReverseMap();
        }
    }
}
