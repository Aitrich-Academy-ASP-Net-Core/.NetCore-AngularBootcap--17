using Library_Management.Models;
using Library_Management.DTO;

namespace Library_Management.Interfaces
{
    public interface IBookService
    {
        public Task<List<Book>> GetAllBookAsync();
        public Task<Book> GetAllBookByIdAsync(int id);
        public Task AddBookAsync(BookDto bookdto);
        public Task DeleteBookAsync(int id);
    }
}
