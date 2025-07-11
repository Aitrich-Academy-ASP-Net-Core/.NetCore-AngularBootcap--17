using ExamRazor.Interface;
using ExamRazor.Model;
using ExamRazor.Repository;
using ExamRazor.Service;
using Microsoft.EntityFrameworkCore;

namespace ExamRazor.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ILibraryRepository, LibraryReository>();
            services.AddScoped<ILibraryService, LibraryService>();
            services.AddDbContext<LibraryDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(typeof(Program));
            return services;
        }



    }
}
