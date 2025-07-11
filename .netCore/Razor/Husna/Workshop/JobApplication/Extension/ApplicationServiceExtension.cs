using JobApplication.Helper;
using JobApplication.Model;
using JobApplication.Repository;
using JobApplication.Service;
using Microsoft.EntityFrameworkCore;

namespace JobApplication.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            // Add Services
            services.AddScoped<JobService>();
            services.AddScoped<JobRepository>();
            // Add AutoMapper

            services.AddAutoMapper(typeof(AutoMapperProfile));
            return services;
        }

        }
    }
