using System;
using BlazorApp1.Model;
using BlazorApp1.service;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Extension
{
    public static class ApplicationServiceExtension
    {

        public static IServiceCollection AddApplicationService
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<CustomerDbContext>(
                options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<CustomerRepository>();
            services.AddScoped<CustomerService>();

            return services;
        }


    }
}
