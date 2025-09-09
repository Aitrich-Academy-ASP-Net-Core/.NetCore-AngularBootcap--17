using AutoMapper;
using MVC_Register.Dto;
using MVC_Register.Models;
namespace MVC_Register.Helper
{
    public class AutoMappingProfile:Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
