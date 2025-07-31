using JobProvider.Model;
using JobProvider.Repository;
using JobProvider.Service;
using JobProvider.Helper;
using AutoMapper;
using JobProvider.Interface;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace JobProvider.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
        {
            services.AddDistributedMemoryCache(); // Required for session
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); // Session timeout
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddScoped<ProtectedSessionStorage>();

            services.AddDbContext<JobProviderAppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IJobProviderRepository, JobProviderRepository>();
            services.AddScoped<IJobRepository, JobRepository>();
           
            services.AddScoped<IJobService, JobService>();

            services.AddScoped<IAuthService, AuthService>();
            return services;

        }
    }
}
