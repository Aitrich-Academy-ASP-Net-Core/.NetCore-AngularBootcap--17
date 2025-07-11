using Microsoft.EntityFrameworkCore;
using RazorWS.Helper;
using RazorWS.Models;
using RazorWS.Repository;
using RazorWS.Services;

namespace RazorWS.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<JobDBContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<JobServices>();
            services.AddScoped<JobRepo>();
            
            services.AddAutoMapper(typeof(AutoMapperProfile));


            return services;
        }
    }
}
