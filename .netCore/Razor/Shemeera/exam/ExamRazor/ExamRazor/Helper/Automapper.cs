using AutoMapper;
using ExamRazor.LIbraryDto;
using ExamRazor.Model;

namespace ExamRazor.Helper
{
    public class Automapper:Profile
    {
        public Automapper()
        {

            CreateMap<User, UserDto>().ReverseMap();


            CreateMap<Book, BooksDto>().ReverseMap();
        }




    }
}
