using AutoMapper;
using LibraryManagementSystem.Dto;
using LibraryManagementSystem.Interface;
using LibraryManagementSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repository
{
    public class BookRepository  : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public BookRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            var book = await _context.Books.ToListAsync();
            return book;

        }
        public async Task<Book> GetBookByIdAsync(int id)
        {
            var books = await _context.Books.FindAsync(id);
            return books;
        }
        public async Task AddBookAsync(BookDto book)
        {
            var bk = _mapper.Map<Book>(book);
          await  _context.Books.AddAsync(bk);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteBookAsync(int id)
        {
            var bookid = await _context.Books.FindAsync(id);
            if (bookid != null)
            {

                _context.Books.Remove(bookid);
                await _context.SaveChangesAsync();
            }
        }
        }
    }

