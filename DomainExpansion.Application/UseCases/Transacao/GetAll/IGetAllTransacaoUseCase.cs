using DomainExpansion.Communication.Responses;

namespace DomainExpansion.Application.UseCases.Transacao.GetAll
{
    public interface IGetAllTransacaoUseCase
    {
        Task<ResponseTransacaoJson> Execute();
    }
}
