using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HiringMnaagamentSystem.Enum.Role;

namespace HiringMnaagamentSystem.Models
{
    internal class User
    {
        private int id;
        private string? firstName;
        private string? lastName;
        private string email;
        private string password;
        private string phone;
        private Roles roles;



        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public Roles Role
        {
            get { return roles; }
            set { roles = value; }
        }
        public User(int id, string? firstName, string? lastName, string email, string password, string phone, Roles roles)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.phone = phone;
            this.roles = roles;
        }
    }
}
