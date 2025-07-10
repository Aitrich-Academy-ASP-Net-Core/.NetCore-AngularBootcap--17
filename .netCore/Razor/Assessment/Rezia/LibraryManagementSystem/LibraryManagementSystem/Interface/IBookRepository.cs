using LibraryManagementSystem.Dto;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Interface
{
    public interface IBookRepository
    {
        public Task<List<Book>> GetAllBooksAsync();
        public Task<Book> GetBookByIdAsync(int id);
        public Task AddBookAsync(BookDto book);
        public Task DeleteBookAsync(int id);

    }
}
