using JOBMANAGEMENT.Helper;
using JOBMANAGEMENT.Model;
using JOBMANAGEMENT.Repository;
using JOBMANAGEMENT.Servive;
using Microsoft.EntityFrameworkCore;

namespace JOBMANAGEMENT.Extension
{
    public static class ApplictionServiceExtesion
    {


        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<JobService>();
            services.AddScoped<JobRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
      
    }
}