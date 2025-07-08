using AutoMapper;
using Mini_project.DTO;
using Mini_project.Models;
using Mini_project.Extension;




namespace Mini_project.Helper
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<CompanyMember, MemberDto>().ReverseMap();
            
        }
    }
}
