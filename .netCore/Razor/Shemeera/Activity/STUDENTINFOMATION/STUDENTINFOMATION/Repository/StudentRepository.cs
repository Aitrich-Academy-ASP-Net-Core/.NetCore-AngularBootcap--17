using AutoMapper;
using Microsoft.EntityFrameworkCore;
using STUDENTINFOMATION.Interface;
using STUDENTINFOMATION.Model;
using STUDENTINFOMATION.Userdto;

namespace STUDENTINFOMATION.Repository
{
    public class StudentRepository:IStudentRepository
    {

            private readonly StudentDbContext _context;
            private readonly IMapper mapper;

            public StudentRepository(StudentDbContext context, IMapper mapper)
            {
                this._context = context;
                this.mapper = mapper;
            }


            public async Task<List<Student>> GetAllStudentAsync()
            {
            //var student = await _context.Students.ToListAsync();
            //return student;
            return await _context.Students.ToListAsync();
        }

            public async Task AddStudentAsync(Studentdto studentdto)
            {

                var student = mapper.Map<Student>(studentdto);
                _context.Students.Add(student);
                await _context.SaveChangesAsync();

            }

        public async Task UpdateStudentAsync(Studentdto studentDto)
        {
            var student = mapper.Map<Student>(studentDto);
            _context.Attach(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await _context.Students.FindAsync(id);
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



    }







}
