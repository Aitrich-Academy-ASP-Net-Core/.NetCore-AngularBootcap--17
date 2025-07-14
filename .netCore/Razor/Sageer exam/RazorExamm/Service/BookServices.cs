using RazorExamm.Models;

namespace RazorExamm.Service
{
    public class BookServices
    {
        private readonly BookDBContext _context;
        public BookServices(BookDBContext context)
        {
            _context = context;
        }
        public async Task<List<Book>> GetAllJobAsync()
        {
            return await _context.GetAllJobAsync();
        }
        public async Task GetJobByIdAsync(int id)
        {
            return await _context.GetJobByIdAsync(id);
        }
    }
}
