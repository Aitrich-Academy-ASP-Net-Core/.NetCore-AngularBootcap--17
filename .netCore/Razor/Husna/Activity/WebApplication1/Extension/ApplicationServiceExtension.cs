using Microsoft.EntityFrameworkCore;
using WebApplication1.Helper;
using WebApplication1.Model;
using WebApplication1.Repository;
using WebApplication1.Services;
using WebApplication1.Extension;
using WebApplication1.Interface;

namespace WebApplication1.Extension;

public static class ApplicationServiceExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration config)
    {
        services.AddDbContext<StudentDbContext>
            (Options => Options.UseSqlServer(config.GetConnectionString("DefaultConnection")));


        // Register interfaces to implementations
        services.AddScoped<IStudentService, StudentService>();
        services.AddScoped<IStudentRepository, StudentsRepository>();

        services.AddAutoMapper(typeof(AutoMapperProfile));

        return services;
    }
        }
