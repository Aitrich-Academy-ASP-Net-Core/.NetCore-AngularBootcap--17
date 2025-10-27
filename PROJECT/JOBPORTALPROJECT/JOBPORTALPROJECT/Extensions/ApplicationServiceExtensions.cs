using Domain;

using Microsoft.EntityFrameworkCore;
using Domain.Service;
using MailKit;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.Authuser;

using Domain.Models;


using Domain.Service.Login.Interfaces;
using Domain.Service.Login;


using Domain.Service.AdminLogin;
using Domain.Service.User.Interface;
using Domain.Service.User;

using Domain.Service.AdminLogin.Interface;
using Domain.Service.JobseekerAuth.Interfaces;
using Domain.Service.JobseekerAuth;
using Domain.Service.JobSeekerProfiles.Interfaces;
using Domain.Service.JobSeekerProfiles;



namespace HireMeNow_WebApi.Extensions
{
    public static class ApplicationServiceExtensions
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );
            services.AddTransient<IEmailService, EmailService>();
            services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<IAuthUserService, AuthUserService>();
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserServices>();
            services.AddHttpContextAccessor();



            services.AddScoped<IJobSeekerAuthService, JobSeekerAuthService>();
            services.AddScoped<IJobSeekerAuthRepository, JobSeekerAuthRepository>();
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
           services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IJobSeekerProfileServices, JobSeekerProfileService>();
            services.AddScoped<IJobSeekerProfileRepository, JobSeekerProfileRepository>();





           
            services.AddScoped<IAuthUserService, AuthUserService>();
            

            return services;
        }
    }
}
