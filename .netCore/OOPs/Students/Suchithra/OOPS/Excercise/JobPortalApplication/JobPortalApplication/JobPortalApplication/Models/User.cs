﻿using JobPortalApplication.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalApplication.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public String? Phone { get; set; }
        public string? Password { get; set; }

        public Roles Role { get; set; }

        public User() { }
        public User(int id,string fname,string lname,string phone,string email,string password,Enums.Roles role) 
        {
            
            Id = id;    
            FirstName = fname;
            LastName = lname;
            Email = email;
            Password = password;
            Role = role;
            phone = phone;

        }

    }


}
