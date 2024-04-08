using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using H20240408.AccesoADatos;
namespace H20240408.AccesoADatos
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddDALDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("conn")));
            services.AddScoped<PersonaHDAL>();

            return services;
        }
    }
}