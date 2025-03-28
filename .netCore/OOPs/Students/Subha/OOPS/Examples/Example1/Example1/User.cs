using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
       
        public bool Login(string username, string password)
        {
            Console.WriteLine("Welcome" + username);
            return true;

        }

        abstract public void welcome();
    }
}
