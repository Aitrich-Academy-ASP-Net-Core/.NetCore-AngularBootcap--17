using AutoMapper;
using DTONewProject.DTO;
using DTONewProject.Models;

namespace DTONewProject.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job, JobDTO>().ReverseMap();
        }
    }
}
