
using AppliedJobs.Interface;
using AppliedJobs.Model;
using AppliedJobs.Repository;
using AppliedJobs.Service;
using Microsoft.EntityFrameworkCore;

namespace AppliedJobs.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
          (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));



            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IApplicationRepository, ApplicationRepository>();
            services.AddScoped<IApplicationService, ApplicationService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();






            return services;
        }
    }
}
