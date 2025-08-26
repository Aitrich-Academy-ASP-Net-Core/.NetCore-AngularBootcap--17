using JobListingApp.Helper;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using JobListingApp.Model;
using JobListingApp.Service;
using JobListingApp.Repository;
using JobListingApp.Interface;

namespace JobListingApp.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
        {
            // Enable session support
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            // Add protected session storage for Blazor Server
            services.AddScoped<ProtectedSessionStorage>();

            // Register DbContext with SQL Server
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            // Register AutoMapper
            services.AddAutoMapper(typeof(MappingProfile));

        
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobSeekerRepository, JobSeekerRepository>();

            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IAuthService, AuthService>();

            return services;
        }
    }
}
