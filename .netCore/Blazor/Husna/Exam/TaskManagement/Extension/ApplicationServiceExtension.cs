using TaskManagement.Model;
using TaskManagement.Interface;
using TaskManagement.Service;
using TaskManagement.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Mapper;

namespace TaskManagement.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration config)
        {
            {
                services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
                services.AddScoped<ITaskRepository, TaskRepository>();
                 services.AddScoped<ITaskService, TaskService>();
                services.AddAutoMapper(typeof(AutoMapperProfile));

                return services;
            }
        }
    }
}
