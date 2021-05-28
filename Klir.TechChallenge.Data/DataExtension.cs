using System;
using System.Collections.Generic;
using System.Text;
using Klir.TechChallenge.Data.Context;
using Klir.TechChallenge.Data.Dao.Definitions.Commands;
using Klir.TechChallenge.Data.Dao.Definitions.Querys;
using Klir.TechChallenge.Data.Dao.Definitions.Repository;
using Klir.TechChallenge.Data.Dao.Implementations.Commands;
using Klir.TechChallenge.Data.Dao.Implementations.Querys;
using Klir.TechChallenge.Data.Dao.Implementations.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Klir.TechChallenge.Data
{
    public static class DataExtension
    {
        public static IServiceCollection RegisterData(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IKlirContext, KlirContext>();

            services.AddTransient<IProductCommandDao, ProductCommandDao>();
            services.AddTransient<IShoppingCartCommandDao, ShoppingCartCommandDao>();
            services.AddTransient<IProductQueryDao, ProductQueryDao>();
            services.AddTransient<IShoppingCartQueryDao, ShoppingCartQueryDao>();
            services.AddDbContextPool<KlirContext>(context => context.UseSqlServer(configuration.GetConnectionString("Default")));
            return services;
        }
    }
}
