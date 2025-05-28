using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManagement.Manager;
using JobManagement.Models;

namespace JobManagement.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User Login(string email, string password);
        void Register(User user);
        User GetLoggedUser();
    }
}
