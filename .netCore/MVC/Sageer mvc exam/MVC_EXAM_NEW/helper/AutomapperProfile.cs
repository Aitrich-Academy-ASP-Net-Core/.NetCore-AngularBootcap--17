using AutoMapper;
using MVC_EXAM_NEW.DTO;
using MVC_EXAM_NEW.Models;

namespace MVC_EXAM_NEW.helper
{
    public class AutomapperProfile:Profile
    {
        public AutomapperProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap <Course, CourseDto>().ReverseMap();
            CreateMap <Enrolment, EnrolmentDto>().ReverseMap();
        }
    }
}
