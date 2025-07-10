using AutoMapper;
using JOBMANAGEMENT.Dto;
using JOBMANAGEMENT.Model;

namespace JOBMANAGEMENT.Helper
{
    public class AutoMapperProfile:Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Jobs, JobsDto>().ReverseMap();
        }

    }
}
