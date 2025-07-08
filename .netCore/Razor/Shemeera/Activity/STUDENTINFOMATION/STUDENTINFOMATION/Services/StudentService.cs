using AutoMapper;
using Microsoft.EntityFrameworkCore;
using STUDENTINFOMATION.Interface;
using STUDENTINFOMATION.Model;
using STUDENTINFOMATION.Repository;
using STUDENTINFOMATION.Userdto;

namespace STUDENTINFOMATION.Services
{
    public class StudentService:IStudentService
    {
        private readonly StudentRepository _studentRepository;
        private readonly IMapper mapper;



        //public StudentService(StudentRepository studentRepository)
        //{
        //    _studentRepository = studentRepository;

        //}
        public StudentService(StudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            this.mapper = mapper;
        }



        public async Task<List<Student>> GetAllStudentAsync()
        {
            return await _studentRepository.GetAllStudentAsync();
        }
        public async Task AddStudentAsync(Studentdto studentdto)
        {
            await _studentRepository.AddStudentAsync(studentdto);



        }

        public async Task UpdateStudentAsync(Studentdto studentDto)
        {
            await _studentRepository.UpdateStudentAsync(studentDto);

        }


        public async Task<Studentdto> GetStudentByIdAsync(int id)
        {
            var student = await _studentRepository.GetStudentByIdAsync(id);
            if (student == null) return null;

            return mapper.Map<Studentdto>(student);
        }

        public async Task DeleteStudentAsync(int id)
        {
            await _studentRepository.DeleteStudentAsync(id);
        }



    }
}
