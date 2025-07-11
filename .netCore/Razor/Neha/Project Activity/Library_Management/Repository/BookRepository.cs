using AutoMapper;
using Library_Management.Interfaces;
using Library_Management.Models;
using Microsoft.EntityFrameworkCore;
using Library_Management.DTO;
namespace Library_Management.Repository
{
    public class BookRepository:IBookRepo
    {
        private readonly LibraryDbContext _context;
        private readonly IMapper _mapper;
        public BookRepository(LibraryDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<Book>> GetAllBookAsync()
        {
            var book = await _context.Books.ToListAsync();
            return book;
        }
        public async Task<Book> GetAllBookByIdAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            return _mapper.Map<Book>(book);
        }
        public async Task AddBookAsync(BookDto bookdto)
        {
            var book1 =  _mapper.Map<Book>(bookdto);
            _context.Books.Add(book1);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteBookAsync(int id)
        {
            var book1 = await _context.Books.FindAsync(id);
            if (book1 != null)
            {
                _context.Books.Remove(book1);
                await _context.SaveChangesAsync();
                
            }
        }
    }
}
