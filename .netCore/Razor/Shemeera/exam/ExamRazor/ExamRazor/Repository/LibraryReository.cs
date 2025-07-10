using AutoMapper;
using ExamRazor.Interface;
using ExamRazor.LIbraryDto;
using ExamRazor.Model;
using Microsoft.EntityFrameworkCore;

namespace ExamRazor.Repository
{
    public class LibraryReository : ILibraryRepository
    {

        private readonly LibraryDbContext _context;

        public LibraryReository(LibraryDbContext context)
        {
            _context = context;
        }

        
        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }




        // Book 
        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task AddBookAsync(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
        }

        //public async Task UpdateBookAsync(Book book)
        //{
        //    _context.Books.Update(book);
        //    await _context.SaveChangesAsync();
        //}

        public async Task DeleteBookAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
        }

    }
}