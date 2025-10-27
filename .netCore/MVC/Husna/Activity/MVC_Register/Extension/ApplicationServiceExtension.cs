using Microsoft.EntityFrameworkCore;
using MVC_Register.Interface;
using MVC_Register.Models;
using MVC_Register.Repository;
using MVC_Register.Service;

namespace MVC_Register.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection
            services, IConfiguration config)
        {
            services.AddDbContext<UserDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<UserRepository>();
            services.AddAutoMapper(typeof(Program));
            services.AddSession();

            return services;
        }

    }
}
