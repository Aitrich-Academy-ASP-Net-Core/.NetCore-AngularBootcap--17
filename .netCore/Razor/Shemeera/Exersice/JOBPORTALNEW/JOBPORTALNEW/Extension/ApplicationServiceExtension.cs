using JOBPORTALNEW.Helper;
using JOBPORTALNEW.Interface;
using JOBPORTALNEW.Model;
using JOBPORTALNEW.Repository;
using JOBPORTALNEW.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace JOBPORTALNEW.Extension
{
    public static class ApplicationServiceExtension
    {


        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IRepository, JobRepository>();
            services.AddScoped<IService, JobService>();
            services.AddDbContext<JobDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(typeof(Program));
            return services;





        }   }
}
