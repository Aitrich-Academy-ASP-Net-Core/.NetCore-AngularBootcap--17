using AutoMapper;
using Library_Management.DTO;
using Library_Management.Models;

namespace Library_Management.Helper
{
    public class AutomapperProfile:Profile
    {
       public AutomapperProfile()
        {
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
