using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the DI container
builder.Services.AddControllers();

// Add AutoMapper, your services, repositories, etc.
// builder.Services.AddAutoMapper(...);
// builder.Services.AddScoped<IAdminServices, AdminServices>();
// builder.Services.AddScoped<IAuthUserRepository, AuthUserRepository>();
// etc.

// Configure Authentication & JWT
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    // Read Jwt settings
    var jwtSection = builder.Configuration.GetSection("Jwt");
    var secretKey = jwtSection.GetValue<string>("Key");
    var issuer = jwtSection.GetValue<string>("Issuer");
    var audience = jwtSection.GetValue<string>("Audience");

    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),

        ValidateIssuer = true,
        ValidIssuer = issuer,

        ValidateAudience = true,
        ValidAudience = audience,

        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero  // optional: no tolerance for expired token
    };
});

// Add Authorization
builder.Services.AddAuthorization();

var app = builder.Build();

// Use the authentication & authorization middleware
app.UseAuthentication();
app.UseAuthorization();

// Map controllers
app.MapControllers();

app.Run();
