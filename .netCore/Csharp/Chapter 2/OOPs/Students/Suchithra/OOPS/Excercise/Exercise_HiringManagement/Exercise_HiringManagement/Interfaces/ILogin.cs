using Exercise_HiringManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_HiringManagement.Interfaces
{
    public interface ILogin
    {
        bool Login(string email, string password);

        void Register(User user);
    }
}
