using ShopApp1.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using ShopApp1.Services;
using ShopApp1.Data;
using Microsoft.EntityFrameworkCore;

namespace ShopApp1.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection")); //UseSqlServer
            });
            
            return services;
        }

    }
}
