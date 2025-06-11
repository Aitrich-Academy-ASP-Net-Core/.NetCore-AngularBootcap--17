using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodeFK.Model
{
    internal class StudentDbContext:DbContext 
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> Marks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=DESKTOP-9S833FK;Initial Catalog=Test;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
