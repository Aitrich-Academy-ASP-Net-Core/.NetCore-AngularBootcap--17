using JobSeekerManagement.Helper;
using JobSeekerManagement.Interface;
using JobSeekerManagement.Models;
using JobSeekerManagement.Service;
using JobSeekerManagement.Repository;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace JobSeekerManagement.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer
            (config.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(typeof(AutoMappingProfile));
            // Services
            services.AddScoped<IPublicService, PublicService>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IApplicationService, ApplicationService>();

            // Repositories
           services.AddScoped<IPublicRepository, PublicRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
          services.AddScoped<IJobRepository, JobRepository>();
        services.AddScoped<IApplicationRepository, ApplicationRepository>();
            return services;
        }
    }
}
