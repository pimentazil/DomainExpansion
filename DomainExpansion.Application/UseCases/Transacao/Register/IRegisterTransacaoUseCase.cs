using DomainExpansion.Communication.Requests;
using DomainExpansion.Communication.Responses;

namespace DomainExpansion.Application.UseCases.Transacao.Register
{
    public interface IRegisterTransacaoUseCase
    {
        Task<ResponseTransacaoJson> Execute(RequestTransacaoJson request);
    }
}
