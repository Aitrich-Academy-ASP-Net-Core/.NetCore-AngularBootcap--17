using JobPortal.Helpers;
using JobPortal.Interface;
using JobPortal.Model;
using JobPortal.Repository;
using JobPortal.Service;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }



    }
}
