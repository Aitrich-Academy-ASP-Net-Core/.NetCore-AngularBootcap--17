using LibraryManagementSystem.Dto;
using LibraryManagementSystem.Interface;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Service
{
    public class BookService : IBookService
    {
        private readonly BookRepository _repository;

        public BookService(BookRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _repository.GetAllBooksAsync();
        }
        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _repository.GetBookByIdAsync(id);
        }
        public async Task AddBookAsync(BookDto bookDto)
        {
            await _repository.AddBookAsync(bookDto);

        }
        public async Task DeleteBookAsync(int id)
        {
            await _repository.DeleteBookAsync(id);
        }
    }
}
