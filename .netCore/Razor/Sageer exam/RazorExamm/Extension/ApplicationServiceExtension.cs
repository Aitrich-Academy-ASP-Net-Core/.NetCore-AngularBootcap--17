using Microsoft.EntityFrameworkCore;
using RazorExamm.Models;
using RazorExamm.Service;

namespace RazorExamm.Extension
{
    public class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
             (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<BookDBContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<BookServices>();
            services.AddScoped<BookRepo>();

            


            return services;
        }
    }
}
