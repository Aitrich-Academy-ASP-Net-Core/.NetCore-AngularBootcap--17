using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<AuthUser> AuthUsers { get; set; }
       

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }

}
