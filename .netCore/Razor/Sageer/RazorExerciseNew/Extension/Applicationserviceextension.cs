using Microsoft.EntityFrameworkCore;
using RazorExerciseNew.Helper;
using RazorExerciseNew.Repository;
using RazorExerciseNew.Service;
using RazorExerciseNew.Models;
using Microsoft.Extensions.DependencyInjection;

namespace RazorExerciseNew.Extension
{
    public class Applicationserviceextension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<JobDBContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<JobServices>();
            services.AddScoped<Jobrepo>();

            services.AddAutoMapper(typeof(AutoMapperProfile));


            return services;
        }
    }
}
