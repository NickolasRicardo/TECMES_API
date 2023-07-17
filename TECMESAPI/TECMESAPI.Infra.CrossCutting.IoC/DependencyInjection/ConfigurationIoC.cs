using TECMESAPI.Application.Interfaces.Services;
using TECMESAPI.Application.Services.Services;
using TECMESAPI.Domain.Interfaces.Repository;
using TECMESAPI.Domain.Interfaces.Services;
using TECMESAPI.Domain.Services.Services;
using TECMESAPI.Infra.Data.Context;
using TECMESAPI.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TECMESAPI.CrossCutting.IoC.DependencyInjection
{
    public class ConfigurationIoC
    {
        public static void RegisterServices(
            IServiceCollection services,
            IConfiguration configuration
        )
        {
            string conn = configuration.GetConnectionString("Mysql_DB");

            services.AddDbContext<DataBaseContext>(
                options => options.UseMySql(conn, ServerVersion.AutoDetect(conn))
            );

            RegisterServices(services);
            RegisterApplication(services);
            RegisterRepositories(services);
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IMaquinaService, MaquinaService>();
            services.AddScoped<IOrdemProducaoService, OrdemProducaoService>();
            services.AddScoped<IProducaoService, ProducaoService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IVendaService, VendaService>();
        }

        private static void RegisterApplication(IServiceCollection services)
        {
            services.AddScoped(
                typeof(IApplicationServiceBase<,>),
                typeof(ApplicationServiceBase<,>)
            );

            services.AddScoped<IClienteApplicationService, ClienteApplicationService>();
            services.AddScoped<IMaquinaApplicationService, MaquinaApplicationService>();
            services.AddScoped<IOrdemProducaoApplicationService, OrdemProducaoApplicationService>();
            services.AddScoped<IProducaoApplicationService, ProducaoApplicationService>();
            services.AddScoped<IProdutoApplicationService, ProdutoApplicationService>();
            services.AddScoped<IVendaApplicationService, VendaApplicationService>();
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IMaquinaRepository, MaquinaRepository>();
            services.AddScoped<IOrdemProducaoRepository, OrdemProducaoRepository>();
            services.AddScoped<IProducaoRepository, ProducaoRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IVendaRepository, VendaRepository>();
        }
    }
}
