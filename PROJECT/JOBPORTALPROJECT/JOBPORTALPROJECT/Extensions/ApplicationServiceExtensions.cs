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
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
           services.AddScoped<IEmailService, EmailService>();


            //services.AddScoped<ISignUpRequestRepository, SignUpRequestRepository>();
            //services.AddScoped<ISignUpRequestService, SignUpRequestService>();
            

            //services.AddScoped<IJobProviderService, JobProviderService>();
            //services.AddScoped<IJobProviderRepository, JobProviderRepository>();

			//services.AddScoped<IJobRepository, JobRepository>();
			//services.AddScoped<IJobServices, JobServices>();
			services.AddScoped<IAuthUserService, AuthUserService>();
            //services.AddScoped<ICompanyRepository, Companyrepository>();
            //services.AddScoped<ICompanyService,Companyservice>();
			
   //         services.AddScoped<IInterviewService,InterviewService>();   
   //         services.AddScoped<IInterviewRepository,InterviewRepository>();

   //         services.AddScoped<IJobSeekerProfileService, ProfileService>();
          
   //         services.AddScoped<IJobSeekerProfileRepository, ProfileRepository>();

   //         services.AddScoped<ICompanyRepository, Companyrepository>();
   //         services.AddScoped<ICompanyService,Companyservice>();   


			//services.AddScoped<IJobRepository,JobRepository>();
   //         services.AddScoped<IJobServices, JobServices>();

   //         services.AddScoped<IJobProviderService, JobProviderService>();
   //         services.AddScoped<IJobProviderRepository, JobProviderRepository>();
            

            //services.AddScoped<IChatRepository, ChatRepository>();
            //services.AddScoped<IMessageGroupRepository, MessageGroupRepository>();

            return services;
        }
    }
}
