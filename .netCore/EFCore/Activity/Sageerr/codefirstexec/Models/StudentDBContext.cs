using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using codefirstexec.Models;

namespace codefirstexec.Models
{
    class StudentDBContext: DbContext
    {
        public DbSet <Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-LL6UVFL;Initial Catalog=SchoolDB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
