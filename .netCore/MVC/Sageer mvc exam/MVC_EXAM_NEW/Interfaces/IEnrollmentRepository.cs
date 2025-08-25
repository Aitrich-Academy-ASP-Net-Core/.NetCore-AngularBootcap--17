using MVC_EXAM_NEW.Models;

namespace MVC_EXAM_NEW.Interfaces
{
    public interface IEnrollmentRepository
    {
        Task <IEnumerable <Enrolment>> GetByUserIdAsync(int userId);
        Task<Enrolment> GetByUserAnsCourseAsync(int userId,int courseId);
        Task AddAsync(Enrolment enrolment);
        Task DeleteAsync(int id);
    }
}
