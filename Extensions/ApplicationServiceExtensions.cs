using DotNetCore_Angular_SocialMedia_App.Data;
using DotNetCore_Angular_SocialMedia_App.Interface;
using DotNetCore_Angular_SocialMedia_App.Services;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_Angular_SocialMedia_App.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
            IConfiguration config)
        {
            services.AddControllers();
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            services.AddCors(setupAction =>
            {
                setupAction.AddPolicy("AllowAllOrigins", builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
