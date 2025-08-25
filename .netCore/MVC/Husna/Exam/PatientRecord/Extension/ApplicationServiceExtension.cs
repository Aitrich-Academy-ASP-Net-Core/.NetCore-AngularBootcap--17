using Microsoft.EntityFrameworkCore;
using PatientRecord.Helper;
using PatientRecord.Interface;
using PatientRecord.Models;
using PatientRecord.Repository;
using PatientRecord.Service;

namespace PatientRecord.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services,IConfiguration config)
        {
           services.AddDbContext<AppDbContext>(options => options.UseSqlServer
            (config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IPatientService, PatientService>();
            services.AddAutoMapper(typeof(AutoMappingProfile));
            return services; 
        }

    }
}
