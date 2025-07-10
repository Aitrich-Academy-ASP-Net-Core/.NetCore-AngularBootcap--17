using WebApplication1.Model;
using WebApplication1.StudentDto;

namespace WebApplication1.Interface
{
    public interface IStudentRepository
    {
       Task<List<Student>> GetAllStudentAsync();
        Task AddStudentAsync(StudDto studDto);
        Task DeleteStudentAsync(int id);
        Task UpdateStudentAsync(StudDto studDto);

    }
}
