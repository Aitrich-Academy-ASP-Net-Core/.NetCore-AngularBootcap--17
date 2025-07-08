using AutoMapper;
using STUDENTINFOMATION.Model;
using STUDENTINFOMATION.Userdto;

namespace STUDENTINFOMATION.Helper
{
    public class AutomapperProfile:Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Student,Studentdto>().ReverseMap();



        }




    }
}
