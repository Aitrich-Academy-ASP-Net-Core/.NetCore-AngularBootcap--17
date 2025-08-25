using Microsoft.EntityFrameworkCore;
using MVC_EXAM_NEW.Data;
using MVC_EXAM_NEW.Interfaces;
using MVC_EXAM_NEW.Models;

namespace MVC_EXAM_NEW.Repository
{
    public class EnrolmentRepository:IEnrollmentRepository
    {
        private readonly CourseDBContext _context;
        public EnrolmentRepository(CourseDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Enrolment>> GetByUserIdAsync(int userId)
        {
             return await _context.enrolments.Include(e=>e.Course).ToListAsync();
        }
        public async Task<Enrolment> GetByUserAnsCourseAsync(int userId, int courseId)
        {
            return await _context.enrolments.FirstOrDefaultAsync(e => e.Userid == userId && e.CourseId == courseId);
        }
        public async Task AddAsync(Enrolment enrolment)
        {
            _context.enrolments.Add(enrolment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var enrol = await _context.enrolments.FindAsync(id);
            if(enrol != null)
            {
                _context.enrolments.Remove(enrol);
                await _context.SaveChangesAsync();
            }
        }
    }
}
