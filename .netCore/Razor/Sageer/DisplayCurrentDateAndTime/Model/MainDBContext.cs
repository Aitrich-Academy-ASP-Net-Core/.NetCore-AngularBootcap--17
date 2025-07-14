using Microsoft.EntityFrameworkCore;

namespace DisplayCurrentDateAndTime.Model
{
    
        public class MainDBContext : DbContext
        {
            public DbSet<MainPage> Main { get; set; }

            public MainDBContext(DbContextOptions<MainDBContext> options) : base(options) { }

        }
    
}
