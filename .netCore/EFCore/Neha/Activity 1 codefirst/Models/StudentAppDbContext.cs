using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1_codefirst.Models
{
   internal class StudentAppDbContext: DbContext
    {
      public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=MYPC;Initial Catalog=master;Integrated Security=True;Trust Server Certificate=True");
        }
    }

    
}
