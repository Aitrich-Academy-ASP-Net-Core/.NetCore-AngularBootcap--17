using Microsoft.EntityFrameworkCore;

namespace DateAndTime.Model
{
    public class CountryContext:DbContext
    {

        public CountryContext(DbContextOptions<CountryContext> options) : base(options) { }


        public DbSet<Country> Countries { get; set; }






    }
}
