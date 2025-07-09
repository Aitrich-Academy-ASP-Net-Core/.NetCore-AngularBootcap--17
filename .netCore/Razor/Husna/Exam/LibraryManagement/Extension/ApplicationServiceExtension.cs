using LibraryManagement.Interface;
using LibraryManagement.Model;
using LibraryManagement.Repository;
using LibraryManagement.Service;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBookService, BookService>();

            return services;
        }
    }
}
