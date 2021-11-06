using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Treinamento.Domain.Application.Interfaces;
using Treinamento.Domain.Application.UseCases;

namespace Treinamento.Adapters.IOC
{
    public static class DomainInjectorExtensions
    {

        public static IServiceCollection RegisterDomain(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUseCaseAbrirConta, UseCaseAbrirConta>();
            return services;
        }
    }
}
