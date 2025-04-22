using HireMeNow_AdminApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireMeNow_AdminApp.Interfaces
{
    public interface ILogin
    {
        bool Login(string email, string password);
        void Register(User user);
    }
}
