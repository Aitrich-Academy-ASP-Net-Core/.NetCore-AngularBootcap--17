using Exercise_HiringManagement.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_HiringManagement.Models
{
    public class User
    {

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public String ? Phone {  get; set; }
        public string? Password {  get; set; }  

        public Roles Role { get; set; }

        public User(int id, string firstname,string lastname,string email,string phone,string password ,Roles role ) 
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone = phone;
           
            Password=password;
            Role = role;
        
        }
        public User() { }

    }
}
