using Microsoft.Extensions.DependencyInjection;
using Supermercado.Interfaces;
using Supermercado.Models.ApplicationService;
using Supermercado.Models.DomainService;
using Supermercado.Repository.DataService;
using Supermercado.Repository.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.DependencyInjection
{
    public static class AdicionaDependencias
    {
        public static void AddTransient(IServiceCollection services)
        {
            services.AddTransient<IDataService, DataService>();

            services.AddTransient<IMercadoRepository, MercadoRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();

            // Mercado
            services.AddTransient<IMercadoDomainService, MercadoDomainService>();
            services.AddTransient<IMercadoApplicationService, MercadoApplicationService>();

            // Produto
            services.AddTransient<IProdutoDomainService, ProdutoDomainService>();
            services.AddTransient<IProdutoApplicationService, ProdutoApplicationService>();
        }
    }
}
