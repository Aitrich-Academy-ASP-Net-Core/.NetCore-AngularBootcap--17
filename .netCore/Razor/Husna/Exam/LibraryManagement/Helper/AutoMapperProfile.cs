using AutoMapper;
using LibraryManagement.Dto;
using LibraryManagement.Model;
namespace LibraryManagement.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Book, Bookdto>().ReverseMap();
        }
    }
}
