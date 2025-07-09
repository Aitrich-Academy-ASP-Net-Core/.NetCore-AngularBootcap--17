using AppliedJobs.Extension;
using AppliedJobs.Helper;
using Microsoft.Extensions.DependencyInjection;

namespace AppliedJobs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddAutoMapper(typeof(AutoMapperProfile));




            builder.Services.AddApplicationServices(builder.Configuration);
            builder.Services.AddSession(); // 👈 Add this before builder.Build()


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession(); // 👈 Add this before app.UseRouting();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
