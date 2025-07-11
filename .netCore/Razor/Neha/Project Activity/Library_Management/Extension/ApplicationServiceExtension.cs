using Library_Management.Helper;
using Library_Management.Models;
using Library_Management.Repository;
using Microsoft.EntityFrameworkCore;
using Library_Management.Services;

namespace Library_Management.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<LibraryDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(typeof(AutomapperProfile));
            services.AddScoped<BookRepository>();
            services.AddScoped<UserRepository>();
            services.AddScoped<BookService>();
            services.AddScoped<UserService>();
            return services;
        }
    }
}
