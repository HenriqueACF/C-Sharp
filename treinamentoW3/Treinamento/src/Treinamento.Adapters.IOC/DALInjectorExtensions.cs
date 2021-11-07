using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Treinamento.Adapters.DAL.Context;
using Treinamento.Adapters.DAL.Interfaces;
using Treinamento.Adapters.DAL.Repositories;

namespace Treinamento.Adapters.IOC
{
    public static class DALInjectorExtensions
    {
        public static IServiceCollection RegisterDAL(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IDBConnectionFactory, DBConnectionFactory>();
            services.AddScoped<IContaRepository, ContaRepository>();
            return services;
        }

    }
}
