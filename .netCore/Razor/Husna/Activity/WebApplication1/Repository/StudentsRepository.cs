using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Interface;
using WebApplication1.Model;
using WebApplication1.StudentDto;

namespace WebApplication1.Repository
{
    public class StudentsRepository : IStudentRepository
    {
        private readonly StudentDbContext _context;
        private readonly IMapper _mapper;
        public StudentsRepository(StudentDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Student>> GetAllStudentAsync()
        {
            var student = await _context.Students.ToListAsync();
            return student;
        }
        public async Task AddStudentAsync(StudDto studDto)
        {
            var student = _mapper.Map<Student>(studDto);
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

        }
        public async Task DeleteStudentAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }
        }
        public async Task UpdateStudentAsync(StudDto studDto)
        {
            var existingStudent = await _context.Students.FindAsync(studDto.Id);
            if (existingStudent != null)
            {
                existingStudent.Name = studDto.Name;
                existingStudent.Age = studDto.Age ?? 0;
                existingStudent.Course = studDto.Course;

                await _context.SaveChangesAsync();
            }
        }

    }
}
