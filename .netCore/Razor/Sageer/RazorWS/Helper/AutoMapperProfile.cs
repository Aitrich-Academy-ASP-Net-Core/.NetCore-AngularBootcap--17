using AutoMapper;
using RazorWS.DTO;
using RazorWS.Models;

namespace RazorWS.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<JobApplication, JobDto>().ReverseMap();
        }
    }
}
