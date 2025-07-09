using Microsoft.EntityFrameworkCore;
namespace Registration_Activity.Models
{
    public class RegisterDbContext:DbContext
    {
        public RegisterDbContext(DbContextOptions<RegisterDbContext>options)
            : base(options)
        {

        }
      public  DbSet<User> Users { get; set; }
    }
}
