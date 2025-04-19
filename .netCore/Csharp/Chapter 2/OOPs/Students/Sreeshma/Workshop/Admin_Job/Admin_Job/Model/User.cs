using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Job.Model
{
    internal class User
    {
        private string username;
        private string password;

        public User(string Username,string Password) 
        {
            username = Username;
            password = Password;
        }

        public string UserName 
        {  
            get { return username; } 
            set { username = value; }
        }
        public string Password 
        {
            get { return password; }
            set { password = value; }
        }
    }
}
