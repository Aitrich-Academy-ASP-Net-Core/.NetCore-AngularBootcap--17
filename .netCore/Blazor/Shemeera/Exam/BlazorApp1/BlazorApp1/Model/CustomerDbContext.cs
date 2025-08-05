using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Model
{
    public class CustomerDbContext:DbContext
    {
       public CustomerDbContext(DbContextOptions<CustomerDbContext> Options) : base(Options) { }

        public DbSet<Customer> Customers { get; set; }


    }
}
