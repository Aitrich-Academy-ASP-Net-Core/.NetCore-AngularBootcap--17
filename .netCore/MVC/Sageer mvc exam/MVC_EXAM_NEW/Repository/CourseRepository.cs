using Microsoft.EntityFrameworkCore;
using MVC_EXAM_NEW.Data;
using MVC_EXAM_NEW.Interfaces;
using MVC_EXAM_NEW.Models;

namespace MVC_EXAM_NEW.Repository
{
    public class CourseRepository:ICourseRepository
    {
        private readonly CourseDBContext _context;
        public CourseRepository(CourseDBContext context)
        {
            _context = context;
        }
        public async Task <IEnumerable <Course>> GetAllAsync()
        {
            return await _context.courses.ToListAsync();
        }
        public async Task<Course> GetByIdAsync(int id)
        {
            return await _context.courses.FindAsync(id);
        }
        public async Task AddAsync(Course course)
        {
            _context.courses.Update(course);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var course = await GetByIdAsync(id);
            if(course != null)
            {
                _context.courses.Remove(course);
                await _context.SaveChangesAsync();
            }
        }
    }
}
