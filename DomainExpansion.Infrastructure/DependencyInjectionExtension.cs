using DomainExpansion.Domain.Repositories;
using DomainExpansion.Domain.Repositories.Transacao;
using DomainExpansion.Infrastructure.DataAccess;
using DomainExpansion.Infrastructure.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DomainExpansion.Infrastructure
{
    public static class DependencyInjectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddRepositories(services);
            AddDbContext(services, configuration);
        }
        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ITransacaoWriteOnlyRepository, TransacaoRepository>();      
        }

        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<DomainExpansionDbContext>(config => config.UseSqlServer(connectionString));
        }
    }
}
