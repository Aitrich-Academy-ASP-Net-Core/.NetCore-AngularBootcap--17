using WebApplication1.Model;
using WebApplication1.StudentDto;

namespace WebApplication1.Interface
{
    public interface IStudentService
    {
        public Task<List<Student>> GetAllStudentAsync();
        public Task AddStudentAsync(StudDto studDto);
        Task DeleteStudentAsync(int id);
        Task UpdateStudentAsync(StudDto studDto);
    }
}
