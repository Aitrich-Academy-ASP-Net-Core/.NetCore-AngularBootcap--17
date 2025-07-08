using Microsoft.EntityFrameworkCore;
using Workshop.Helper;
using Workshop.Interfaces;
using Workshop.Models;
using Workshop.Repository;
using Workshop.Services;

namespace Workshop.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<JobDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<JobServices>();
            services.AddScoped<JobRepo>();
            
            services.AddAutoMapper(typeof(AutoMapperProfile));
            return services;
        }
    }
}
