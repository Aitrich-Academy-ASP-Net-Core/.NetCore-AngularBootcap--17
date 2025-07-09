using Microsoft.EntityFrameworkCore;
using STUDENTINFOMATION.Helper;
using STUDENTINFOMATION.Model;
using STUDENTINFOMATION.Repository;
using STUDENTINFOMATION.Services;

namespace STUDENTINFOMATION.Extension
{
    public static class ApplicationServiceExtension
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<StudentDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<StudentService>();
            services.AddScoped<StudentRepository>();
            services.AddAutoMapper(typeof(AutomapperProfile));

            return services; 
        }





    }
}
