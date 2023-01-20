using Microsoft.Extensions.DependencyInjection;
using Parking.Domain.Data;
using Parking.Infra.Write.Data;

namespace Parking.Infra.CrossCutting.Ioc
{
    public static class IocBootstrapper
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}