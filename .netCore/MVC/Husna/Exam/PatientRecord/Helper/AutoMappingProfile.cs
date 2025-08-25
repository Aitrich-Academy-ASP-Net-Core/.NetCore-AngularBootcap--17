using AutoMapper;
using PatientRecord.Dto;
using PatientRecord.Models;
namespace PatientRecord.Helper
{
    public class AutoMappingProfile:Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<Patient, PatientDto>().ReverseMap();
        }
    }
}
