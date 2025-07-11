using AutoMapper;
using DTONewProject.Helper;
using DTONewProject.Interfaces;
using DTONewProject.Models;
using DTONewProject.Services;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace DTONewProject.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<JobDBContext>(options => options.UseSqlServer
            (config.GetConnectionString("DefaultConnection")));
            
            services.AddScoped<Jservice>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddScoped<Jobrepository>();
            return services;
        }
    }
}
