using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;
using WebApplication1.Repository;
using WebApplication1.StudentDto;
using WebApplication1.Interface;

namespace WebApplication1.Services
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository _studentsRepository;
        public StudentService(IStudentRepository studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }
       public async Task<List<Student>> GetAllStudentAsync()
       {
           return await _studentsRepository.GetAllStudentAsync();
            

       }
        public async Task AddStudentAsync(StudDto studDto)
        {
            await _studentsRepository.AddStudentAsync(studDto);
        }
        public async Task DeleteStudentAsync(int id)
        {
            await _studentsRepository.DeleteStudentAsync(id);
        }
        public async Task UpdateStudentAsync(StudDto studDto)
        {
            await _studentsRepository.UpdateStudentAsync(studDto);
        }
    }
}
