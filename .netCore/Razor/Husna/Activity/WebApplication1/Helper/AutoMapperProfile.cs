using AutoMapper;
using WebApplication1.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;
using WebApplication1.StudentDto;

namespace WebApplication1.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, StudDto>().ReverseMap();
        }

    }

}
