using LibraryManagementSystem.Helper;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Service;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection ApplicationService
            (this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddScoped<UserRepository>();
            services.AddScoped<UserService>();
            services.AddScoped<BookRepository>();   
            services.AddScoped<BookService>();
            return services;
        }
    }
}
