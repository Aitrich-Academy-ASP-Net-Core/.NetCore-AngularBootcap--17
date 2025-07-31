using AutoMapper;
using TaskManagement.Model;
namespace TaskManagement.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TaskItem, TaskItemDto>().ReverseMap();
        }
    }
}
