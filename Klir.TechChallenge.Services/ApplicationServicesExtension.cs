using System;
using System.Collections.Generic;
using System.Text;
using Klir.TechChallenge.Data;
using Klir.TechChallenge.Services.Commands.Definitions;
using Klir.TechChallenge.Services.Commands.Implementations;
using Klir.TechChallenge.Services.Querys.Definitions;
using Klir.TechChallenge.Services.Querys.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Klir.TechChallenge.Services
{
    public static class ApplicationServicesExtension
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ICreateShoppingCartCommand, CreateShoppingCartCommand>();
            services.AddTransient<IGetProductsQuery, GetProductsQuery>();
            services.AddTransient<IGetShoppingCartQuery, GetShoppingCartQuery>();
            services.RegisterData(configuration);
            return services;
        }
    }
}
