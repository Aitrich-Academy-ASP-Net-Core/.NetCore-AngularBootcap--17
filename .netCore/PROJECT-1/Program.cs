using Domain.Enum;
using Domain.Helpers;
using Domain.Models;
using JobPortalApp.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Text;

namespace JobPortalApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // -------------------------------
            // Register Services
            // -------------------------------
            builder.Services.AddApplicationServices(builder.Configuration);
            builder.Services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
            builder.Services.AddControllers();
            builder.Services.AddSignalR();
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddDistributedMemoryCache();

            // -------------------------------
            // Swagger / OpenAPI Configuration
            // -------------------------------
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "Standard Authorization header using the Bearer scheme (\"bearer {token}\")",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });

                options.OperationFilter<SecurityRequirementsOperationFilter>();
            });
            //builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddJwtBearer(options =>
            //    {
            //        options.TokenValidationParameters = new TokenValidationParameters
            //        {
            //            ValidateIssuerSigningKey = true,
            //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
            //                .GetBytes(builder.Configuration.GetSection("AuthSettings:Token").Value)),
            //            ValidateIssuer = false,
            //            ValidateAudience = false
            //        };
            //    });

            // -------------------------------
            // CORS Policy
            // -------------------------------
            builder.Services.AddAuthentication(options =>
            {
                // Set the default scheme for authentication and challenge
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(builder.Configuration["AuthSettings:Token"])
        ),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});
            builder.Services.AddCors(options => options.AddPolicy(name: "NgOrigins",
  policy =>
  {
      policy.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
  }));
            builder.Services.AddSession();

            // -------------------------------
            // HTTP Logging
            // -------------------------------
            builder.Services.AddHttpLogging(logging =>
            {
                logging.LoggingFields = HttpLoggingFields.All;
                logging.MediaTypeOptions.AddText("application/javascript");
                logging.RequestBodyLogLimit = 4096;
                logging.ResponseBodyLogLimit = 4096;
            });





           
            var app = builder.Build();



            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<DbHireMeNowWebApiContext>();

                var admin = context.AuthUsers.FirstOrDefault(u => u.Email == "admin@hiremenow.com");

                if (admin == null)
                {
                    var newAdmin = new AuthUser
                    {
                        Id = Guid.NewGuid(),
                        FirstName = "Admin",
                        LastName = "User",
                        Email = "admin@hiremenow.com",
                        Phone = "98770000088", 
                        Role = Role.ADMIN,
                        ConnectionId = "14",
                        OnlineStatus = false,
                        CreatedAt = DateTime.UtcNow,
                        IsEmailVerified = true
                    };

                    // ✅ Hash password safely
                    newAdmin.Password = PasswordHelper.HashPassword(newAdmin, "Admin@123");

                    context.AuthUsers.Add(newAdmin);
                    context.SaveChanges();

                    Console.WriteLine(" Admin user created with hashed password!");
                }
                else
                {
                    Console.WriteLine(" Admin already exists in DB.");
                }
            }



            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            app.UseSwagger();
            app.UseSwaggerUI();
            //}
            /*app.UseCors("NgOrigins");*/
            app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowCredentials().SetIsOriginAllowed(origin => true));

            //app.UseCors();
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();




            

            app.Run();  // <-- this must remain LAST

        }
    }
}
