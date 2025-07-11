using Library_Management.Interfaces;
using Library_Management.Models;
using Library_Management.Repository;
using Library_Management.DTO;

namespace Library_Management.Services
{
    public class BookService:IBookService
    {
        private readonly IBookRepo _bookserve;
        public BookService(IBookRepo bookserve)
        {
            _bookserve = bookserve;
        }
        public async Task<List<Book>> GetAllBookAsync()
        {
            return await _bookserve.GetAllBookAsync();
        }
        public async Task<Book> GetAllBookByIdAsync(int id)
        {
            return await _bookserve.GetAllBookByIdAsync(id);
        }
        public Task AddBookAsync(BookDto bookdto)
        {
            return _bookserve.AddBookAsync(bookdto);
        }
        public Task DeleteBookAsync(int id)
        {
            return _bookserve.DeleteBookAsync(id);
        }
    }
}
