using AutoMapper;
using ExamRazor.Interface;
using ExamRazor.LIbraryDto;
using ExamRazor.Model;

namespace ExamRazor.Service
{
    public class LibraryService:ILibraryService
    {
        private readonly ILibraryRepository _repository;

        public LibraryService(ILibraryRepository repository)
        {
            _repository = repository;
        }

        // User 
        public async Task<User> LoginAsync(string username, string password)
        {
            var user = await _repository.GetUserByUsernameAsync(username);
            if (user != null && user.Password == password)
                return user;
            return null;
        }

       
        public async Task<bool> RegisterUserAsync(User user)
        {
            var existingUser = await _repository.GetUserByUsernameAsync(user.Username);
            if (existingUser != null)
                return false;

            await _repository.AddUserAsync(user);
            return true;
        }

        // Book 
        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _repository.GetAllBooksAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _repository.GetBookByIdAsync(id);
        }

        public async Task AddBookAsync(Book book)
        {
            await _repository.AddBookAsync(book);
        }

        //public async Task UpdateBookAsync(Book book)
        //{
        //    await _repository.UpdateBookAsync(book);
        //}

        public async Task DeleteBookAsync(int id)
        {
            await _repository.DeleteBookAsync(id);
        }
    }

}

