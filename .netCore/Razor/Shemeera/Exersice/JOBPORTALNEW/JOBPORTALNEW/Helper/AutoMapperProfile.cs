using AutoMapper;
using JOBPORTALNEW.JobDto;
using JOBPORTALNEW.Model;

namespace JOBPORTALNEW.Helper
{
    public class AutoMapperProfile:Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<JobsDto, Job>().ReverseMap();
            CreateMap<AppliedDto, Applied>().ReverseMap();
        }




    }
}
