using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCode.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCode
{
    internal class StudentContext:DbContext
    {
        public DbSet<Student> Students { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=DESKTOP-9S833FK;Initial Catalog=studentportal;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
