using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Application.Contracts.Persistence;
using Vehicle.Infrastructure.Persistence;
using Vehicle.Infrastructure.Repositories;

namespace Vehicle.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("OrderingConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IBusRepository, BusRepository>();
            services.AddScoped<IBoatRepository, BoatRepository>();


            return services;

        }
    }
}
