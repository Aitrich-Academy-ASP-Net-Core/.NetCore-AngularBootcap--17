using JobManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManagement.Enum;
using JobManagement.Models;
using JobManagement.Exceptions;

namespace JobManagement.Repository
{
    public sealed class UserRepository:IUserRepository
    {
        private List<User> users = new List<User>
{
    new User(1, "John", "Doe", "provider1@example.com", 1234890, "pass123", Roles.JobProvider),
    new User(2, "Alice", "Smith", "seeker1@example.com", 9876210, "pass456", Roles.JobSeeker)
};


        private static User loggedUser;

        public List<User> GetAllUsers()
        {
            return users;
        }

        public User Login(string email, string password)
        {
            loggedUser = users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (loggedUser == null)
                throw new InvalidLoginException("Invalid email or password. Please try again!");

            return loggedUser;
        }

        public void Register(User user)
        {
            user.Id = users.Max(u => u.Id) + 1;
            users.Add(user);
        }

        public User GetLoggedUser()
        {
            return loggedUser;
        }
    }
}
