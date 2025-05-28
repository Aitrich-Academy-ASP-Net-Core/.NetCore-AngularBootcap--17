using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManagement.Enum;

namespace JobManagement.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }
        public List<int> SavedJobs { get; set; }
        public List<int> AppliedJobs { get; set; }

        public User()
        {
            SavedJobs = new List<int>();
            AppliedJobs = new List<int>();
        }

        public User(int id, string firstName, string lastName, string email, int phone, string password, Roles role)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Password = password;
            Role = role;
            SavedJobs = new List<int>();
            AppliedJobs = new List<int>();
        }
    }
}
