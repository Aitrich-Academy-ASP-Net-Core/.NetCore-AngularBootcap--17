using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mini_project.Helper;
using Mini_project.Models;
using Mini_project.Extension;
using Mini_project.Pages.Services;
using Mini_project.Pages.Repository;

namespace Mini_project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
           
            builder.Services.AddSession();
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

           builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

            builder.Services.AddScoped<MembService>();
            builder.Services.AddScoped<MembRepo>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseSession();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
