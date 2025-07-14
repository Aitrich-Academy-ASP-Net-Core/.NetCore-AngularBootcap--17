using Microsoft.EntityFrameworkCore;
using Mini_project.Helper;
using Mini_project.Models;
using AutoMapper;
using Mini_project.Pages.Repository;
using Mini_project.Pages.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Mini_project.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
          (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddScoped<MembRepo>();
            services.AddScoped<MembService>();


            return services;
        }
    }
}
