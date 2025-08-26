using MVC_EXAM_NEW.DTO;

namespace MVC_EXAM_NEW.Interfaces
{
    public interface IEnrollmentService
    {
        Task<IEnumerable<CourseDto>> GetEnrollmentCoursesAsync(int userId);
        Task EnrollAsync(int userId,int CourseId);
        Task DropAsync(int userId,int courseId);
    }
}
