using AutoMapper;
using JobProvider.Dto;
using JobProvider.Model;
namespace JobProvider.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<JobProviderr, JobProviderDto>().ReverseMap();
            CreateMap<Job, JobDto>().ReverseMap();
        }
    
    }
}
