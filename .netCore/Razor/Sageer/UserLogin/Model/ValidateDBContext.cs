using Microsoft.EntityFrameworkCore;

namespace UserLogin.Model
{
    
        public class ValidateDBContext : DbContext
        {
            public DbSet<Validate> Students { get; set; }

            public ValidateDBContext(DbContextOptions<ValidateDBContext> options) : base(options) { }

        }
}
