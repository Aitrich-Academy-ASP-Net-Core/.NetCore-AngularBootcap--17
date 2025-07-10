using Library_Management.Helper;
using Library_Management.Interfaces;
using Library_Management.Models;
using Library_Management.Repository;
using Library_Management.Services;
using Microsoft.EntityFrameworkCore;

namespace Library_Management
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

           
            builder.Services.AddDbContext<LibraryDbContext>(options =>
     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddRazorPages();
            builder.Services.AddAutoMapper(typeof(AutomapperProfile));

            
            builder.Services.AddScoped<IBookRepo, BookRepository>();
            builder.Services.AddScoped<IUserRepo, UserRepository>();
            builder.Services.AddScoped<IBookService, BookService>(); 
            builder.Services.AddScoped<IUserService, UserService>();


            builder.Services.AddScoped<BookService>();
            builder.Services.AddScoped<UserService>();
            builder.Services.AddScoped<BookRepository>();
            builder.Services.AddScoped<UserRepository>();


            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession();
            builder.Services.AddHttpContextAccessor();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            

            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();




            app.MapRazorPages();
            app.Run();
        }
    }
}
