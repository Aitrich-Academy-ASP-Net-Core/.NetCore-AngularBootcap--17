using AutoMapper;
using Microsoft.AspNetCore.Builder;
using RazorExerciseNew.Models;
using RazorExerciseNew.DTO;

namespace RazorExerciseNew.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Application, JobDto>().ReverseMap();
        }
    }
}
