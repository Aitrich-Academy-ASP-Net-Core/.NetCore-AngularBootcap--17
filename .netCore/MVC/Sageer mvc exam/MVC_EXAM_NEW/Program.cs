using Microsoft.EntityFrameworkCore;
using MVC_EXAM_NEW.Data;
using MVC_EXAM_NEW.helper;
using MVC_EXAM_NEW.Interfaces;
using MVC_EXAM_NEW.Repository;
using MVC_EXAM_NEW.Services;

namespace MVC_EXAM_NEW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<CourseDBContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")))
            builder.Services.AddAutoMapper(typeof(AutomapperProfile));
            builder.Services.AddScoped<IUserRepository,UserRepository>();
            builder.Services.AddScoped<ICourseRepository, CourseRepository>();
            builder.Services.AddScoped<IEnrollmentRepository, EnrolmentRepository>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<ICourseService, CourseService>();
            builder.Services.AddScoped<IEnrollmentService, EnrollmentService>();
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
