using Domain.Models;
using Domain.Enums;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using HireMeNow_WebApi.Extensions;
using Domain.Helpers;
using Microsoft.EntityFrameworkCore;
using HireMeNow_WebApi.API.Admin;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();




var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddHttpContextAccessor();
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddControllers();
builder.Services.AddSignalR();

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
    options.OperationFilter<Swashbuckle.AspNetCore.Filters.SecurityRequirementsOperationFilter>();
});

// ===== JWT Authentication =====
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(builder.Configuration["AuthSettings:Token"])
        ),
        RoleClaimType = ClaimTypes.Role  
    };
});










// ===== Authorization =====
builder.Services.AddAuthorization();

// ===== CORS =====
builder.Services.AddCors(options =>
{
    options.AddPolicy("NgOrigins", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// ===== HTTP Logging =====
builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.All;
    logging.MediaTypeOptions.AddText("application/javascript");
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
});

var app = builder.Build();

// ===== Seed Admin User =====


using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    var admin = context.AuthUsers.FirstOrDefault(u => u.Email == "admin@hiremenow.com");

    if (admin != null)
    {
        admin.PasswordHash = PasswordHelper.HashPassword("Admin@123");
        admin.Password = null;
        admin.Role = Role.ADMIN; // Ensure role is correct
        admin.IsEmailVerified = true;
        context.SaveChanges();
        Console.WriteLine("Admin updated successfully");
    }
    else
    {
        var newAdmin = new AuthUser
        {
            Id = Guid.NewGuid(),
            FirstName = "Admin",
            LastName = "User",
            Email = "admin@hiremenow.com",
            PasswordHash = PasswordHelper.HashPassword("Admin@123"),
            Role = Role.ADMIN,
            ConnectionId = "",
            OnlineStatus = false,
            CreatedAt = DateTime.UtcNow,
            IsEmailVerified = true
        };
        context.AuthUsers.Add(newAdmin);
        context.SaveChanges();
        Console.WriteLine("Admin created successfully");
    }

    //var jobSeeker = context.AuthUsers.FirstOrDefault(u => u.Email == "testseeker1@example.com" && u.Role == Role.JOB_SEEKER);

    //if (jobSeeker != null)
    //{
    //    jobSeeker.PasswordHash = PasswordHelper.HashPassword("Test@123"); // new password
    //    jobSeeker.IsEmailVerified = true; // ensure verified
    //    context.SaveChanges();
    //    Console.WriteLine("Test JobSeeker password updated successfully!");
    //}
}




// ===== Middleware =====
app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("NgOrigins");

app.UseHttpsRedirection();

app.UseAuthentication();  
app.UseAuthorization();

app.MapControllers();

app.Run();

