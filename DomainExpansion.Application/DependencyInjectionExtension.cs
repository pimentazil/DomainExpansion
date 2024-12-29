using DomainExpansion.Application.AutoMapper;
using DomainExpansion.Application.UseCases.Transacao.Delete;
using DomainExpansion.Application.UseCases.Transacao.GetAll;
using DomainExpansion.Application.UseCases.Transacao.Register;
using Microsoft.Extensions.DependencyInjection;

namespace DomainExpansion.Application
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            AddAutoMapper(services);
            AddUseCases(services);
        }

        private static void AddAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapping));
        }

        private static void AddUseCases(IServiceCollection services)
        {
            services.AddScoped<IRegisterTransacaoUseCase, RegisterTransacaoUseCase>();
            services.AddScoped<IGetAllTransacaoUseCase, GetAllTransacaoUseCase>();
            services.AddScoped<IDeleteTransacaoUseCase, DeleteTransacaoUseCase>();
        }
    }
}
