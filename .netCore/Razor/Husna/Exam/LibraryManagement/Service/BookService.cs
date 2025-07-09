using LibraryManagement.Dto;
using LibraryManagement.Interface;
using LibraryManagement.Model;

namespace LibraryManagement.Service
{
    public class BookService:IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _bookRepository.GetAllBooksAsync();
        }

        public async Task AddBookAsync(Bookdto bookDto)
        {
            await _bookRepository.AddBookAsync(bookDto);
        }

        public async Task DeleteBookAsync(int id)
        {
            await _bookRepository.DeleteBookAsync(id);
        }
        public async Task<int> GetTotalBookCountAsync()
        {
            return await _bookRepository.GetTotalBookCountAsync();
        }
    }
}
    

