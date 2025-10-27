using Domain.Models;

using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Domain.Service.SignUp.Interfaces;
using Domain.Service.SignUp;
using Domain.Service;
using Domain.Service.User.Interface;
using Domain.Service.User;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.Authuser;
using Domain.Service.Login.Interfaces;
using Domain.Service.Login;
using Domain.Service.Profile;
using Domain.Service.Profile.Interface;
using Domain.Service.Job.Interfaces;
using Domain.Service.Job;
using Domain.Service.Admin.Interfaces;
using Domain.Service.Admin;

namespace JobPortalApp.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            // DbContext
            services.AddDbContext<DbHireMeNowWebApiContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );

            // Services & Repositories
            //services.AddScoped<ISignUpRequestRepository, SignUpRequestRepository>();
            //services.AddScoped<ISignUpRequestService, SignUpRequestService>();
            //services.AddScoped<IEmailService, EmailService>();
            //services.AddHttpContextAccessor();
            //services.AddScoped<IUserService, UserServices>();

            //services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            //services.AddScoped<IAuthUserService, AuthUserService>();
            //services.AddScoped<ILoginRequestService, LoginRequestService>();
            //services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            //services.AddScoped<IJobSeekerProfileService, ProfileService>();
            //services.AddScoped<IJobSeekerProfileRepository, ProfileRepository>();
            //services.AddScoped<IJobServices, JobServices>();
            //services.AddScoped<IJobRepository, JobRepository>();


            //services.AddScoped<IAdminServices, AdminServices>();
            //services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            services.AddScoped<ISignUpRequestRepository, SignUpRequestRepository>();
            services.AddScoped<ISignUpRequestService, SignUpRequestService>();
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<IAuthUserService, AuthUserService>();

           // services.AddScoped<IJobProviderService, JobProviderService>();
           // services.AddScoped<IJobProviderRepository, JobProviderRepository>();

            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobServices, JobServices>();
            services.AddScoped<IAuthUserService, AuthUserService>();
            //services.AddScoped<ICompanyRepository, Companyrepository>();
            //services.AddScoped<ICompanyService, Companyservice>();
            services.AddHttpContextAccessor();
           // services.AddScoped<IInterviewService, InterviewService>();
           // services.AddScoped<IInterviewRepository, InterviewRepository>();

            services.AddScoped<IJobSeekerProfileService, ProfileService>();

            services.AddScoped<IJobSeekerProfileRepository, ProfileRepository>();

           // services.AddScoped<ICompanyRepository, Companyrepository>();
           // services.AddScoped<ICompanyService, Companyservice>();


            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobServices, JobServices>();

            //services.AddScoped<IJobProviderService, JobProviderService>();
           // services.AddScoped<IJobProviderRepository, JobProviderRepository>();
            services.AddScoped<IAdminServices, AdminServices>();
            services.AddScoped<IAdminRepository, AdminRepository>();

            services.AddScoped<IUserService, UserServices>();

            






            return services;
        }
    }
}
