using MVC_EXAM_NEW.DTO;

namespace MVC_EXAM_NEW.Interfaces
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseDto>> GetAllAsync();
        Task<CourseDto> GetByIdAsync(int id);
        Task AddAsync(CourseDto courseDto);
        Task UpdateAsync(CourseDto courseDto);
        Task DeleteAsync(int id);
    }
}
