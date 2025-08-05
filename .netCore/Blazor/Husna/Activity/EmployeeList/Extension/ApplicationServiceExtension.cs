using EmployeeList.Models;
using EmployeeList.Repository;
using EmployeeList.Service;
using Microsoft.EntityFrameworkCore;

namespace EmployeeList.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<EmployeeRepository>();
            services.AddScoped<EmployeeService>();
            return services;
        }
    }
}
