using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portal.Infastructure.Persitence;
using Portal.Infastructure.Persitence.EntityFreamwork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.System
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection InjectApplicationServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>),typeof(EfRepository<>));
            return services;
        }
        public static IServiceCollection AddCustomizedDataStore(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<PortalDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),b=>b.MigrationsAssembly("Portal.Infastructure")));
            services.AddScoped<DbContext>(provider => provider.GetService<PortalDbContext>());
            return services;
        }
    }
}
