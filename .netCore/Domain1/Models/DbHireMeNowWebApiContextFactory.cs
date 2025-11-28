using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    class DbHireMeNowWebApiContextFactory : IDesignTimeDbContextFactory<DbHireMeNowWebApiContext>
    {
        public DbHireMeNowWebApiContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbHireMeNowWebApiContext>();

            // ✅ Explicitly configure SQL Server provider here
            optionsBuilder.UseSqlServer("Data Source=SHEMEERA_1990\\SQLEXPRESS;Initial Catalog=JoobporatalAdmin;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");


            return new DbHireMeNowWebApiContext(optionsBuilder.Options);

        }
    }
}
